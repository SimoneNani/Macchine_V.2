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


namespace Macchine_V._2
{
    public partial class frmMain : Form
    {
        BackgroundWorker bgw1, bgw2;

        //globals
        const int ARRIVO = 1108;
        const int PARTENZA = 12;

        public frmMain()
        {
            InitializeComponent();
        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            this.Text = "Gara di Macchine";
            btnStart.Text = "START";
            btnReset.Text = "RESET";
            btnReset.Visible = false;
            btnReset.Enabled = false;

            txtVincitore.Text = "VINCITORE: ";
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            btnReset.Visible = true;
            btnStart.Enabled = false;

            bgw1 = new BackgroundWorker();
            bgw1.WorkerReportsProgress = true;
            bgw1.WorkerSupportsCancellation = true;
            bgw1.DoWork += Bwg_DoWork;
            bgw1.RunWorkerCompleted += Bgw_RunWorkerCompleted;

            bgw2 = new BackgroundWorker();
            bgw2.WorkerReportsProgress = true;
            bgw2.WorkerSupportsCancellation = true;
            bgw2.DoWork += Bwg_DoWork;
            bgw2.RunWorkerCompleted += Bgw_RunWorkerCompleted;

            bgw1.RunWorkerAsync(txtVincitore);
            bgw2.RunWorkerAsync(txtVincitore);
        }

        private void Bgw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            var (vincitore, tb) = (ValueTuple< string, TextBox>)e.Result;
            if (tb.Text=="VINCITORE: ")
            {
                tb.Text = tb.Text + vincitore;
            }       
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtVincitore.Text = "VINCITORE: ";
            btnStart.Enabled = true; 
            btnReset.Visible = false;
            bgw1.CancelAsync();
            bgw2.CancelAsync();

            picBlack.Location = new Point(PARTENZA, picBlack.Location.Y);
            picRed.Location = new Point(PARTENZA, picRed.Location.Y);
        }

        private void Bwg_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker bwg = sender as BackgroundWorker;
            TextBox tb = e.Argument as TextBox;
            Random r = new Random();
            int spostamento = 0;

            //valore X di fine finestra

            while (picRed.Location.X < ARRIVO || picBlack.Location.X < ARRIVO)
            {
                if (picBlack.Location.X < ARRIVO)                                                           //spostamento casuale macchina nera fino a traguardo
                {
                    spostamento = r.Next(0, 15);
                    picBlack.Location = new Point(picBlack.Location.X + spostamento, picBlack.Location.Y);
                }
                else
                {
                    bwg.CancelAsync();
                    if (bwg.CancellationPending)
                    {
                        e.Result = ("Nera",tb);
                        btnReset.Enabled = true;
                        return;
                    }
                }

                if (picRed.Location.X < ARRIVO)                                                            //spostamento casuele macchina rossa fino a traguardo
                {
                    spostamento = r.Next(0, 15);
                    picRed.Location = new Point(picRed.Location.X + spostamento, picRed.Location.Y);
                }
                else
                {
                    bwg.CancelAsync();
                    if (bwg.CancellationPending)
                    {
                        e.Result = ("Rossa",tb);
                        btnReset.Enabled = true;
                        return;
                    }
                }
                Thread.Sleep(30);                                                                           //pausa che evidenzia lo spostamento casuale
            }            
        }
    }
}
