using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library.DataAccess;
using Library.WebCore;
using Globals = Library.WebCore.Globals;

namespace TrasnformerDB
{
    public partial class frmMain : Form
    {
        //chuỗi kết nối
        const string CONN_STR = @"Data Source=10.12.1.106:1521/erpdb01.nc.com;User ID=ERP;Password=RgVbstgs32Tg252Tf;Unicode=True;Pooling=false;Max Pool Size=1024";

        //Dữ liệu đã được chuẩn hoá, sẵn sàng cho việc gửi lên http://www.sqlines.com/online
        List<string> lstStandardData = new List<string>();

        //dữ liệu thô được lấy từ database
        List<string> lstSource = new List<string>();

        public frmMain()
        {
            InitializeComponent();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            CheckConnection();
        }

        /// <summary>
        /// Kiểm tra kết nối tới DB
        /// </summary>
        private void CheckConnection()
        {
            IData objIData = Library.DataAccess.Data.CreateData(CONN_STR, false);
            try
            {
                objIData.Connect();
                lblStatus.Text = @"Successed!";
            }
            catch (Exception objException)
            {
                lblStatus.Text = objException.Message;
            }
            finally
            {
                objIData.Disconnect();
            }
        }

        /// <summary>
        /// Lấy thông tin scritp Create Table
        /// </summary>
        /// <param name="strTableName">Table cần lấy script</param>
        /// <returns></returns>
        private string GetDataTable(string strTableName)
        {
            string strRsl = string.Empty;
            IData objIData = Library.DataAccess.Data.CreateData(CONN_STR, false);
            try
            {
                objIData.Connect();
                var dtb = objIData.ExecQueryToDataTable("SELECT DBMS_METADATA.GET_DDL('TABLE','" + strTableName + "','ERP') SQL FROM DUAL;");
                string strData = Convert.ToString(dtb.Rows[0][0]);
                strRsl = strData;
            }
            catch (Exception objEx)
            {
                new ResultMessage(true, Library.WebCore.SystemError.ErrorTypes.LoadInfo, "Lỗi lấy thông tin", objEx.ToString());
            }
            finally
            {
                objIData.Disconnect();
            }

            return strRsl;
        }

        private void btnGetData_Click(object sender, EventArgs e)
        {
            string strTable = txtSrc.Text.Trim();
            if (string.IsNullOrWhiteSpace(strTable)) return;
            StringBuilder strSource = new StringBuilder();
            lstStandardData.Clear();
            lstSource.Clear();
            var arrTable = strTable.Split(new string[] {"\r\n"}, StringSplitOptions.RemoveEmptyEntries);
            foreach (string strTableName in arrTable)
            {
                string strCreateTable = GetDataTable(strTableName);
                lstSource.Add(strCreateTable);

                string strDataStandard = StardardData(strCreateTable);
                lstStandardData.Add(strDataStandard);

                strSource.AppendLine(strCreateTable);
                strSource.AppendLine("-----------------------------------------------------");
            }

            txtSource.Text = strSource.ToString();
        }

        private string StardardData(string strSource)
        {
            string strRsl = string.Empty;
            if (strSource.Contains("USING INDEX"))
            {
                int intEndIndex = strSource.IndexOf("USING INDEX");
                strRsl = strSource.ToString().Substring(0, intEndIndex - 1);
                strRsl += ")";
            }

            strRsl = strRsl.Replace("\"ERP\".", "");
            return strRsl;
        }

        private async Task<string> ConvertDataAsync(string strSource)
        {
            string URL = @"http://www.sqlines.com/sqlines_run.php";
            HttpClient client = new HttpClient();
            var values = new Dictionary<string, string>
            {
                {"source", strSource},
                {"source_type", "Oracle"},
                {"target_type", "Microsoft SQL Server"}
            };

            var content = new FormUrlEncodedContent(values);

            var response = await client.PostAsync(URL, content);

            var responseString = await response.Content.ReadAsStringAsync();
            var strRsl = responseString.Replace(@"__SQLINES_MULTI_PART__", "");
            client.Dispose();
            return strRsl;
        }

        private void btnStandardData_Click(object sender, EventArgs e)
        {
            if (lstStandardData.Count < 1) return;
            StringBuilder sb = new StringBuilder();
            foreach (string strCreateTable in lstSource)
            {
                sb.AppendLine(StardardData(strCreateTable));
                sb.AppendLine("-----------------------------------------------------");
            }

            txtSource.Text = sb.ToString();
        }

        private void BtnOnlineConvert_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            if (lstStandardData.Count < 1) return;
            foreach (string strSource in lstStandardData)
            {
                var t = Task.Run(() => MakeRequest(strSource));
                t.Wait();
                sb.AppendLine(t.Result);
                sb.AppendLine("-----------------------------------------------------");
            }

            txtDestination.Text = sb.ToString();
        }

        private async Task<string> MakeRequest(string strSource)
        {
            var rsl = await ConvertDataAsync(strSource);
            return rsl;
        }
    }
}