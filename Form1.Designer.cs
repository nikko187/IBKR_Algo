namespace IBKR_Algo
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            btnConnect = new Button();
            btnDisconnect = new Button();
            btnStart = new Button();
            tbSymbol = new TextBox();
            btnStop = new Button();
            label1 = new Label();
            cbSecType = new ComboBox();
            label2 = new Label();
            cbExchange = new ComboBox();
            label3 = new Label();
            tbPrimExch = new TextBox();
            label4 = new Label();
            tbExpiration = new TextBox();
            label5 = new Label();
            tbBid = new TextBox();
            tbAsk = new TextBox();
            tbLast = new TextBox();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            lbData = new ListBox();
            label9 = new Label();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            dataGridView1 = new DataGridView();
            colTime = new DataGridViewTextBoxColumn();
            colOpen = new DataGridViewTextBoxColumn();
            colHigh = new DataGridViewTextBoxColumn();
            colLow = new DataGridViewTextBoxColumn();
            colClose = new DataGridViewTextBoxColumn();
            colVol = new DataGridViewTextBoxColumn();
            colWAP = new DataGridViewTextBoxColumn();
            tabPage2 = new TabPage();
            tabPage3 = new TabPage();
            dataGridView5min = new DataGridView();
            tbTime = new TextBox();
            timer1 = new System.Windows.Forms.Timer(components);
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView5min).BeginInit();
            SuspendLayout();
            // 
            // btnConnect
            // 
            btnConnect.Location = new Point(12, 12);
            btnConnect.Name = "btnConnect";
            btnConnect.Size = new Size(75, 23);
            btnConnect.TabIndex = 0;
            btnConnect.Text = "Connect";
            btnConnect.UseVisualStyleBackColor = true;
            btnConnect.Click += btnConnect_Click;
            // 
            // btnDisconnect
            // 
            btnDisconnect.Location = new Point(93, 12);
            btnDisconnect.Name = "btnDisconnect";
            btnDisconnect.Size = new Size(75, 23);
            btnDisconnect.TabIndex = 1;
            btnDisconnect.Text = "Disconnect";
            btnDisconnect.UseVisualStyleBackColor = true;
            btnDisconnect.Click += btnDisconnect_Click;
            // 
            // btnStart
            // 
            btnStart.Location = new Point(174, 12);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(75, 23);
            btnStart.TabIndex = 2;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // tbSymbol
            // 
            tbSymbol.Location = new Point(12, 56);
            tbSymbol.Name = "tbSymbol";
            tbSymbol.Size = new Size(75, 23);
            tbSymbol.TabIndex = 3;
            tbSymbol.Text = "MNQ";
            tbSymbol.KeyDown += tbSymbol_KeyDown;
            tbSymbol.KeyPress += tbSymbol_KeyPress;
            // 
            // btnStop
            // 
            btnStop.Location = new Point(255, 12);
            btnStop.Name = "btnStop";
            btnStop.Size = new Size(75, 23);
            btnStop.TabIndex = 4;
            btnStop.Text = "Stop";
            btnStop.UseVisualStyleBackColor = true;
            btnStop.Click += btnStop_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 38);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 5;
            label1.Text = "Symbol";
            // 
            // cbSecType
            // 
            cbSecType.FormattingEnabled = true;
            cbSecType.Items.AddRange(new object[] { "STK", "FUT" });
            cbSecType.Location = new Point(93, 56);
            cbSecType.Name = "cbSecType";
            cbSecType.Size = new Size(75, 23);
            cbSecType.TabIndex = 6;
            cbSecType.Text = "FUT";
            cbSecType.SelectedIndexChanged += cbSecType_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(93, 38);
            label2.Name = "label2";
            label2.Size = new Size(49, 15);
            label2.TabIndex = 7;
            label2.Text = "SecType";
            // 
            // cbExchange
            // 
            cbExchange.FormattingEnabled = true;
            cbExchange.Items.AddRange(new object[] { "SMART", "CME" });
            cbExchange.Location = new Point(174, 56);
            cbExchange.Name = "cbExchange";
            cbExchange.Size = new Size(75, 23);
            cbExchange.TabIndex = 8;
            cbExchange.Text = "CME";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(174, 38);
            label3.Name = "label3";
            label3.Size = new Size(58, 15);
            label3.TabIndex = 9;
            label3.Text = "Exchange";
            // 
            // tbPrimExch
            // 
            tbPrimExch.AutoCompleteCustomSource.AddRange(new string[] { "ISLAND", "NYSE" });
            tbPrimExch.Location = new Point(255, 56);
            tbPrimExch.Name = "tbPrimExch";
            tbPrimExch.PlaceholderText = "ISLAND/None";
            tbPrimExch.Size = new Size(75, 23);
            tbPrimExch.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(255, 38);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 11;
            label4.Text = "PrimExch";
            // 
            // tbExpiration
            // 
            tbExpiration.Location = new Point(336, 56);
            tbExpiration.Name = "tbExpiration";
            tbExpiration.PlaceholderText = "YYYYMM";
            tbExpiration.Size = new Size(75, 23);
            tbExpiration.TabIndex = 12;
            tbExpiration.Text = "202403";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(336, 38);
            label5.Name = "label5";
            label5.Size = new Size(60, 15);
            label5.TabIndex = 13;
            label5.Text = "Expiration";
            // 
            // tbBid
            // 
            tbBid.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbBid.Location = new Point(93, 109);
            tbBid.Name = "tbBid";
            tbBid.ReadOnly = true;
            tbBid.Size = new Size(75, 23);
            tbBid.TabIndex = 14;
            // 
            // tbAsk
            // 
            tbAsk.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbAsk.Location = new Point(174, 109);
            tbAsk.Name = "tbAsk";
            tbAsk.ReadOnly = true;
            tbAsk.Size = new Size(75, 23);
            tbAsk.TabIndex = 15;
            // 
            // tbLast
            // 
            tbLast.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbLast.Location = new Point(12, 109);
            tbLast.Name = "tbLast";
            tbLast.ReadOnly = true;
            tbLast.Size = new Size(75, 23);
            tbLast.TabIndex = 16;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(93, 91);
            label6.Name = "label6";
            label6.Size = new Size(24, 15);
            label6.TabIndex = 17;
            label6.Text = "Bid";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 91);
            label7.Name = "label7";
            label7.Size = new Size(28, 15);
            label7.TabIndex = 17;
            label7.Text = "Last";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(174, 91);
            label8.Name = "label8";
            label8.Size = new Size(26, 15);
            label8.TabIndex = 17;
            label8.Text = "Ask";
            // 
            // lbData
            // 
            lbData.FormattingEnabled = true;
            lbData.HorizontalScrollbar = true;
            lbData.ItemHeight = 15;
            lbData.Location = new Point(12, 154);
            lbData.Name = "lbData";
            lbData.SelectionMode = SelectionMode.None;
            lbData.Size = new Size(399, 154);
            lbData.TabIndex = 18;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(12, 136);
            label9.Name = "label9";
            label9.Size = new Size(73, 15);
            label9.TabIndex = 19;
            label9.Text = "Information:";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(417, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(490, 296);
            tabControl1.TabIndex = 20;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(dataGridView1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(482, 268);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Historical Data";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { colTime, colOpen, colHigh, colLow, colClose, colVol, colWAP });
            dataGridView1.Location = new Point(6, 6);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Size = new Size(470, 259);
            dataGridView1.TabIndex = 0;
            // 
            // colTime
            // 
            colTime.HeaderText = "Time";
            colTime.Name = "colTime";
            colTime.ReadOnly = true;
            colTime.Width = 58;
            // 
            // colOpen
            // 
            colOpen.HeaderText = "Open";
            colOpen.Name = "colOpen";
            colOpen.ReadOnly = true;
            colOpen.Width = 61;
            // 
            // colHigh
            // 
            colHigh.HeaderText = "High";
            colHigh.Name = "colHigh";
            colHigh.ReadOnly = true;
            colHigh.Width = 58;
            // 
            // colLow
            // 
            colLow.HeaderText = "Low";
            colLow.Name = "colLow";
            colLow.ReadOnly = true;
            colLow.Width = 54;
            // 
            // colClose
            // 
            colClose.HeaderText = "Close";
            colClose.Name = "colClose";
            colClose.ReadOnly = true;
            colClose.Width = 61;
            // 
            // colVol
            // 
            colVol.HeaderText = "Vol";
            colVol.Name = "colVol";
            colVol.ReadOnly = true;
            colVol.Width = 48;
            // 
            // colWAP
            // 
            colWAP.HeaderText = "WAP";
            colWAP.Name = "colWAP";
            colWAP.ReadOnly = true;
            colWAP.Width = 58;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(482, 268);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Chart";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(dataGridView5min);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(482, 268);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Historical Data 5m";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // dataGridView5min
            // 
            dataGridView5min.AllowUserToAddRows = false;
            dataGridView5min.AllowUserToDeleteRows = false;
            dataGridView5min.AllowUserToResizeRows = false;
            dataGridView5min.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView5min.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridView5min.Location = new Point(6, 5);
            dataGridView5min.MultiSelect = false;
            dataGridView5min.Name = "dataGridView5min";
            dataGridView5min.ReadOnly = true;
            dataGridView5min.RowHeadersVisible = false;
            dataGridView5min.Size = new Size(470, 259);
            dataGridView5min.TabIndex = 1;
            // 
            // tbTime
            // 
            tbTime.Location = new Point(336, 12);
            tbTime.Name = "tbTime";
            tbTime.ReadOnly = true;
            tbTime.Size = new Size(75, 23);
            tbTime.TabIndex = 21;
            // 
            // timer1
            // 
            timer1.Interval = 250;
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(919, 319);
            Controls.Add(tbTime);
            Controls.Add(tabControl1);
            Controls.Add(label9);
            Controls.Add(lbData);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(label6);
            Controls.Add(tbLast);
            Controls.Add(tbAsk);
            Controls.Add(tbBid);
            Controls.Add(label5);
            Controls.Add(tbExpiration);
            Controls.Add(label4);
            Controls.Add(tbPrimExch);
            Controls.Add(label3);
            Controls.Add(cbExchange);
            Controls.Add(label2);
            Controls.Add(cbSecType);
            Controls.Add(label1);
            Controls.Add(btnStop);
            Controls.Add(tbSymbol);
            Controls.Add(btnStart);
            Controls.Add(btnDisconnect);
            Controls.Add(btnConnect);
            Name = "Form1";
            Text = "Form1";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView5min).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnConnect;
        private Button btnDisconnect;
        private Button btnStart;
        private TextBox tbSymbol;
        private Button btnStop;
        private Label label1;
        private ComboBox cbSecType;
        private Label label2;
        private ComboBox cbExchange;
        private Label label3;
        private TextBox tbPrimExch;
        private Label label4;
        private TextBox tbExpiration;
        private Label label5;
        private TextBox tbBid;
        private TextBox tbAsk;
        private TextBox tbLast;
        private Label label6;
        private Label label7;
        private Label label8;
        private ListBox lbData;
        private Label label9;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private DataGridView dataGridView1;
        private TextBox tbTime;
        private DataGridViewTextBoxColumn colTime;
        private DataGridViewTextBoxColumn colOpen;
        private DataGridViewTextBoxColumn colHigh;
        private DataGridViewTextBoxColumn colLow;
        private DataGridViewTextBoxColumn colClose;
        private DataGridViewTextBoxColumn colVol;
        private DataGridViewTextBoxColumn colWAP;
        private System.Windows.Forms.Timer timer1;
        private TabPage tabPage3;
        private DataGridView dataGridView5min;
    }
}
