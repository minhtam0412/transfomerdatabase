namespace TrasnformerDB
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnConnect = new System.Windows.Forms.Button();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblStatus = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtDestination = new System.Windows.Forms.TextBox();
            this.txtSource = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnStandardData = new System.Windows.Forms.Button();
            this.btnOnlineConvert = new System.Windows.Forms.Button();
            this.btnGetData = new System.Windows.Forms.Button();
            this.txtSrc = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabTable = new System.Windows.Forms.TabPage();
            this.tabStore = new System.Windows.Forms.TabPage();
            this.pnlTop.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabTable.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(6, 6);
            this.btnConnect.Margin = new System.Windows.Forms.Padding(6);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(226, 44);
            this.btnConnect.TabIndex = 0;
            this.btnConnect.Text = "Test Connection";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.lblStatus);
            this.pnlTop.Controls.Add(this.btnConnect);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Margin = new System.Windows.Forms.Padding(6);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1690, 56);
            this.pnlTop.TabIndex = 1;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(244, 17);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(144, 26);
            this.lblStatus.TabIndex = 1;
            this.lblStatus.Text = "Not Connect";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.txtSrc);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 56);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox1.Size = new System.Drawing.Size(1690, 1140);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Data";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(286, 30);
            this.panel1.Margin = new System.Windows.Forms.Padding(6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1398, 1104);
            this.panel1.TabIndex = 2;
            // 
            // txtDestination
            // 
            this.txtDestination.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDestination.Location = new System.Drawing.Point(819, 96);
            this.txtDestination.Margin = new System.Windows.Forms.Padding(6);
            this.txtDestination.Multiline = true;
            this.txtDestination.Name = "txtDestination";
            this.txtDestination.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDestination.Size = new System.Drawing.Size(554, 952);
            this.txtDestination.TabIndex = 2;
            // 
            // txtSource
            // 
            this.txtSource.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtSource.Location = new System.Drawing.Point(13, 96);
            this.txtSource.Margin = new System.Windows.Forms.Padding(6);
            this.txtSource.Multiline = true;
            this.txtSource.Name = "txtSource";
            this.txtSource.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtSource.Size = new System.Drawing.Size(794, 952);
            this.txtSource.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnStandardData);
            this.panel2.Controls.Add(this.btnOnlineConvert);
            this.panel2.Controls.Add(this.btnGetData);
            this.panel2.Location = new System.Drawing.Point(9, 21);
            this.panel2.Margin = new System.Windows.Forms.Padding(6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1630, 63);
            this.panel2.TabIndex = 1;
            // 
            // btnStandardData
            // 
            this.btnStandardData.Location = new System.Drawing.Point(264, 10);
            this.btnStandardData.Margin = new System.Windows.Forms.Padding(6);
            this.btnStandardData.Name = "btnStandardData";
            this.btnStandardData.Size = new System.Drawing.Size(190, 44);
            this.btnStandardData.TabIndex = 0;
            this.btnStandardData.Text = "Standard Data";
            this.btnStandardData.UseVisualStyleBackColor = true;
            this.btnStandardData.Click += new System.EventHandler(this.btnStandardData_Click);
            // 
            // btnOnlineConvert
            // 
            this.btnOnlineConvert.Location = new System.Drawing.Point(516, 10);
            this.btnOnlineConvert.Margin = new System.Windows.Forms.Padding(6);
            this.btnOnlineConvert.Name = "btnOnlineConvert";
            this.btnOnlineConvert.Size = new System.Drawing.Size(190, 44);
            this.btnOnlineConvert.TabIndex = 0;
            this.btnOnlineConvert.Text = "Online Convert";
            this.btnOnlineConvert.UseVisualStyleBackColor = true;
            this.btnOnlineConvert.Click += new System.EventHandler(this.BtnOnlineConvert_Click);
            // 
            // btnGetData
            // 
            this.btnGetData.Location = new System.Drawing.Point(12, 10);
            this.btnGetData.Margin = new System.Windows.Forms.Padding(6);
            this.btnGetData.Name = "btnGetData";
            this.btnGetData.Size = new System.Drawing.Size(190, 44);
            this.btnGetData.TabIndex = 0;
            this.btnGetData.Text = "Get Data";
            this.btnGetData.UseVisualStyleBackColor = true;
            this.btnGetData.Click += new System.EventHandler(this.btnGetData_Click);
            // 
            // txtSrc
            // 
            this.txtSrc.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtSrc.Location = new System.Drawing.Point(6, 30);
            this.txtSrc.Margin = new System.Windows.Forms.Padding(6);
            this.txtSrc.Multiline = true;
            this.txtSrc.Name = "txtSrc";
            this.txtSrc.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtSrc.Size = new System.Drawing.Size(280, 1104);
            this.txtSrc.TabIndex = 1;
            this.txtSrc.Text = "MD_ETHNICITY";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabTable);
            this.tabControl1.Controls.Add(this.tabStore);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1398, 1104);
            this.tabControl1.TabIndex = 3;
            // 
            // tabTable
            // 
            this.tabTable.Controls.Add(this.panel2);
            this.tabTable.Controls.Add(this.txtDestination);
            this.tabTable.Controls.Add(this.txtSource);
            this.tabTable.Location = new System.Drawing.Point(8, 39);
            this.tabTable.Name = "tabTable";
            this.tabTable.Padding = new System.Windows.Forms.Padding(3);
            this.tabTable.Size = new System.Drawing.Size(1382, 1057);
            this.tabTable.TabIndex = 0;
            this.tabTable.Text = "Table";
            this.tabTable.UseVisualStyleBackColor = true;
            // 
            // tabStore
            // 
            this.tabStore.Location = new System.Drawing.Point(8, 39);
            this.tabStore.Name = "tabStore";
            this.tabStore.Padding = new System.Windows.Forms.Padding(3);
            this.tabStore.Size = new System.Drawing.Size(1382, 1057);
            this.tabStore.TabIndex = 1;
            this.tabStore.Text = "Store";
            this.tabStore.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1690, 1196);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pnlTop);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMain";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Transformer";
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabTable.ResumeLayout(false);
            this.tabTable.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnGetData;
        private System.Windows.Forms.TextBox txtSrc;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtSource;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtDestination;
        private System.Windows.Forms.Button btnStandardData;
        private System.Windows.Forms.Button btnOnlineConvert;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabTable;
        private System.Windows.Forms.TabPage tabStore;
    }
}

