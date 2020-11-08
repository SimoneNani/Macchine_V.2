namespace Macchine_V._2
{
    partial class frmMain
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.picRed = new System.Windows.Forms.PictureBox();
            this.picBlack = new System.Windows.Forms.PictureBox();
            this.picStreet = new System.Windows.Forms.PictureBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.txtVincitore = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBlack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picStreet)).BeginInit();
            this.SuspendLayout();
            // 
            // picRed
            // 
            this.picRed.Image = global::Macchine_V._2.Properties.Resources.macchinarossa;
            this.picRed.Location = new System.Drawing.Point(12, 253);
            this.picRed.Name = "picRed";
            this.picRed.Size = new System.Drawing.Size(200, 112);
            this.picRed.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picRed.TabIndex = 2;
            this.picRed.TabStop = false;
            // 
            // picBlack
            // 
            this.picBlack.Image = global::Macchine_V._2.Properties.Resources.macchinabianca;
            this.picBlack.Location = new System.Drawing.Point(12, 52);
            this.picBlack.Name = "picBlack";
            this.picBlack.Size = new System.Drawing.Size(200, 112);
            this.picBlack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBlack.TabIndex = 1;
            this.picBlack.TabStop = false;
            // 
            // picStreet
            // 
            this.picStreet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picStreet.Image = global::Macchine_V._2.Properties.Resources.road_trip_background_10864211;
            this.picStreet.Location = new System.Drawing.Point(0, 0);
            this.picStreet.Name = "picStreet";
            this.picStreet.Size = new System.Drawing.Size(1320, 423);
            this.picStreet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picStreet.TabIndex = 0;
            this.picStreet.TabStop = false;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(12, 196);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(196, 28);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "button1";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(227, 196);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(208, 28);
            this.btnReset.TabIndex = 4;
            this.btnReset.Text = "button1";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // txtVincitore
            // 
            this.txtVincitore.Location = new System.Drawing.Point(1126, 201);
            this.txtVincitore.Name = "txtVincitore";
            this.txtVincitore.Size = new System.Drawing.Size(163, 20);
            this.txtVincitore.TabIndex = 5;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1320, 423);
            this.Controls.Add(this.txtVincitore);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.picRed);
            this.Controls.Add(this.picBlack);
            this.Controls.Add(this.picStreet);
            this.Name = "frmMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBlack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picStreet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picStreet;
        private System.Windows.Forms.PictureBox picBlack;
        private System.Windows.Forms.PictureBox picRed;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.TextBox txtVincitore;
    }
}

