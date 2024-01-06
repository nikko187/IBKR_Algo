using System.Diagnostics;
using System.Security.AccessControl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using IBApi;
using System.Linq.Expressions;

namespace IBKR_Algo
{
    public partial class Form1 : Form
    {
        IBKR_Algo.EWrapperImpl ibClient;
        private double openTick;
        private double closePrice;
        private double hod;
        private double lod;
        private double ydayHigh;
        private double ydayLow;
        private double theBid;
        private double theAsk;
        private double last;
        IBApi.Contract contract = new IBApi.Contract();
        DateTime now;

        public Form1()
        {
            InitializeComponent();

            ibClient = new IBKR_Algo.EWrapperImpl();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            ibClient.ClientSocket.eConnect("", 7497, 10);

            var reader = new EReader(ibClient.ClientSocket, ibClient.Signal);
            reader.Start();
            new Thread(() =>
            {
                while (ibClient.ClientSocket.IsConnected())
                {
                    ibClient.Signal.waitForSignal();
                    reader.processMsgs();
                }
            })
            { IsBackground = true }.Start();

            // Pause here until the connection is complete 
            while (ibClient.NextOrderId <= 0) { }

            ibClient.form1 = (Form1)Application.OpenForms[0];

        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            ibClient.ClientSocket.eDisconnect();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            contract.Symbol = tbSymbol.Text;
            contract.SecType = cbSecType.Text;
            contract.Exchange = cbExchange.Text;
            contract.PrimaryExch = tbPrimExch.Text;
            contract.Currency = "USD";
            contract.LastTradeDateOrContractMonth = tbExpiration.Text;

            ibClient.ClientSocket.reqMktData(1, contract, "", false, false, null);
            ibClient.ClientSocket.reqHistoricalData(1, contract, "", "5 D", "1 day", "TRADES", 0, 1, true, null);
            ibClient.ClientSocket.reqHistoricalData(2, contract, "", "1 D", "5 mins", "TRADES", 0, 1, true, null);
            timer1.Enabled = true;
            timer1.Start();
            timer2.Enabled = true;
            timer2.Start();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            ibClient.ClientSocket.cancelMktData(1);
            ibClient.ClientSocket.cancelHistoricalData(1);
            ibClient.ClientSocket.cancelHistoricalData(2);
        }

        delegate void TickPriceCallback(int field, double price);
        public void TickPrice(int field, double price)
        {
            if (this.tbLast.InvokeRequired)
            {
                TickPriceCallback d = new TickPriceCallback(TickPrice);
                this.Invoke(d, new object[] { field, price });
            }
            else
            {
                switch (field)
                {
                    case 1:     // BID PRICE
                        tbBid.Text = price.ToString();
                        theBid = price;
                        break;
                    case 2:     // ASK PRICE
                        tbAsk.Text = price.ToString();
                        theAsk = price;
                        break;
                    case 4:     // LAST PRICE
                        tbLast.Text = price.ToString();
                        last = price;
                        break;
                    case 6:     // HIGH OF THE DAY
                        hod = price;
                        break;
                    case 7:     // LOW OF THE DAY
                        lod = price;
                        break;
                    case 9:     // YDAY'S CLOSE PRICE
                        closePrice = price;
                        break;
                    case 14:    // TODAY's OPEN PRICE
                        openTick = price;
                        break;
                }
            }
        }

        delegate void ErrorCallback(int errorCode, string errorMsg);
        public void Error(int errorCode, string errorMsg)
        {
            if (this.lbData.InvokeRequired)
            {
                ErrorCallback d = new ErrorCallback(Error);
                this.Invoke(d, new object[] { errorCode, errorMsg });
            }
            else
            {
                lbData.Items.Insert(0, errorCode + ": " + errorMsg);
            }
        }

        private void tbSymbol_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLower(e.KeyChar))
            {
                e.KeyChar = char.ToUpper(e.KeyChar);
            }
        }

        private void tbSymbol_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                tbSymbol.SelectionStart = 0;
                tbSymbol.SelectionLength = tbSymbol.Text.Length;

                e.SuppressKeyPress = true;

                tbSymbol.SelectAll();

                btnStop.PerformClick();
                btnStart.PerformClick();
            }
        }

        private void cbSecType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbSecType.Text == "FUT")
            {
                cbExchange.Text = "CME";
                tbPrimExch.Text = "";
            }
            else if (cbSecType.Text == "STK")
            {
                cbExchange.Text = "SMART";
                tbPrimExch.Text = "ISLAND";
            }
        }

        delegate void HistoricalDataCallback(string time, double open, double high, double low, double close, decimal volume, decimal wap);
        public void HistoricalData(string time, double open, double high, double low, double close, decimal volume, decimal wap)
        {
            if (dataGridView1.InvokeRequired)
            {
                HistoricalDataCallback d = new HistoricalDataCallback(HistoricalData);
                this.Invoke(d, new object[] { time, open, high, low, close, volume, wap });
            }
            else
            {
                try
                {
                    dataGridView1.Rows.Insert(0, time, open, high, low, close, volume, wap);
                }
                catch (Exception ex)
                {
                    lbData.Items.Insert(0, ex.Message);
                }
            }
        }

        delegate void HistoricalDataUpdateCallback(Bar bar);
        public void HistoricalDataUpdate(Bar bar)
        {
            if (dataGridView1.InvokeRequired)
            {
                HistoricalDataUpdateCallback d = new HistoricalDataUpdateCallback(HistoricalDataUpdate);
                this.Invoke(d, new object[] { bar });
            }
            else
            {
                dataGridView1.Rows[0].SetValues(bar.Time, bar.Open, bar.High, bar.Low, bar.Close, bar.Volume, bar.WAP);
            }
        }

        delegate void Historical5minDataCallback(Bar bar);
        public void Historical5minData(Bar bar)
        {
            if (dataGridView5min.InvokeRequired)
            {
                Historical5minDataCallback d = new Historical5minDataCallback(Historical5minData);
                this.Invoke(d, new object[] { bar });
            }
            else
            {
                dataGridView5min.Rows.Insert(0, bar.Time, bar.Open, bar.High, bar.Low, bar.Close, bar.Volume, bar.WAP);
            }
        }
        
        delegate void Historical5minDataUpdateCallback(Bar bar);
        public void Historical5minDataUpdate(Bar bar)
        {
            if (dataGridView5min.InvokeRequired)
            {
                Historical5minDataUpdateCallback d = new Historical5minDataUpdateCallback(Historical5minDataUpdate);
                this.Invoke(d, new object[] { bar });
            }
            else
            {
                dataGridView5min.Rows[0].SetValues(bar.Time, bar.Open, bar.High, bar.Low, bar.Close, bar.Volume, bar.WAP); 
            }
        }
        delegate void YdayHLCallback();
        public void GetYdayHL()
        {
            if (dataGridView1.RowCount > 1)
            {
                ydayHigh = (double)dataGridView1.Rows[1].Cells["colHigh"].Value;
                ydayLow = (double)dataGridView1.Rows[1].Cells["colLow"].Value;

                if (lbData.InvokeRequired)
                {
                    YdayHLCallback d = new YdayHLCallback(GetYdayHL);
                    this.Invoke(d, new object[] { });
                }
                else
                {
                    lbData.Items.Insert(0, "Yday High: " + ydayHigh);
                    lbData.Items.Insert(0, "Yday Low: " + ydayLow);
                    lbData.Items.Insert(0, "HOD: " + hod);
                    lbData.Items.Insert(0, "LOD: " + lod);
                    lbData.Items.Insert(0, "PrevClose: " + closePrice);
                }
            }
            else
            {
                return;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            now = DateTime.Now;
            tbTime.Text = now.ToString("HH:mm:ss");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            ibClient.ClientSocket.eDisconnect();
            ibClient.ClientSocket.Close();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
        }
    }
}
