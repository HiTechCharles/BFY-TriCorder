namespace BFY_TriCorder
{
    partial class Form1
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
            this.TempGRP = new System.Windows.Forms.GroupBox();
            this.AfternoonNUD = new System.Windows.Forms.NumericUpDown();
            this.MorningNUD = new System.Windows.Forms.NumericUpDown();
            this.AfternoonLBL = new System.Windows.Forms.Label();
            this.MorningLBL = new System.Windows.Forms.Label();
            this.DepositGRP = new System.Windows.Forms.GroupBox();
            this.AmountNUD = new System.Windows.Forms.NumericUpDown();
            this.AmountLBL = new System.Windows.Forms.Label();
            this.SaveBTN = new System.Windows.Forms.Button();
            this.ReadBTN = new System.Windows.Forms.Button();
            this.TempGRP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AfternoonNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MorningNUD)).BeginInit();
            this.DepositGRP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AmountNUD)).BeginInit();
            this.SuspendLayout();
            // 
            // TempGRP
            // 
            this.TempGRP.Controls.Add(this.AfternoonNUD);
            this.TempGRP.Controls.Add(this.MorningNUD);
            this.TempGRP.Controls.Add(this.AfternoonLBL);
            this.TempGRP.Controls.Add(this.MorningLBL);
            this.TempGRP.ForeColor = System.Drawing.Color.Yellow;
            this.TempGRP.Location = new System.Drawing.Point(13, 26);
            this.TempGRP.Name = "TempGRP";
            this.TempGRP.Size = new System.Drawing.Size(521, 237);
            this.TempGRP.TabIndex = 0;
            this.TempGRP.TabStop = false;
            this.TempGRP.Text = "&Temperature";
            // 
            // AfternoonNUD
            // 
            this.AfternoonNUD.Location = new System.Drawing.Point(364, 145);
            this.AfternoonNUD.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.AfternoonNUD.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.AfternoonNUD.Name = "AfternoonNUD";
            this.AfternoonNUD.Size = new System.Drawing.Size(137, 46);
            this.AfternoonNUD.TabIndex = 3;
            this.AfternoonNUD.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.AfternoonNUD.Value = new decimal(new int[] {
            35,
            0,
            0,
            0});
            // 
            // MorningNUD
            // 
            this.MorningNUD.Location = new System.Drawing.Point(364, 66);
            this.MorningNUD.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.MorningNUD.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.MorningNUD.Name = "MorningNUD";
            this.MorningNUD.Size = new System.Drawing.Size(137, 46);
            this.MorningNUD.TabIndex = 1;
            this.MorningNUD.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.MorningNUD.Value = new decimal(new int[] {
            35,
            0,
            0,
            0});
            // 
            // AfternoonLBL
            // 
            this.AfternoonLBL.AutoSize = true;
            this.AfternoonLBL.Location = new System.Drawing.Point(61, 152);
            this.AfternoonLBL.Name = "AfternoonLBL";
            this.AfternoonLBL.Size = new System.Drawing.Size(177, 39);
            this.AfternoonLBL.TabIndex = 2;
            this.AfternoonLBL.Text = "&Afternoon";
            this.AfternoonLBL.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // MorningLBL
            // 
            this.MorningLBL.AutoSize = true;
            this.MorningLBL.Location = new System.Drawing.Point(88, 73);
            this.MorningLBL.Name = "MorningLBL";
            this.MorningLBL.Size = new System.Drawing.Size(150, 39);
            this.MorningLBL.TabIndex = 0;
            this.MorningLBL.Text = "&Morning";
            this.MorningLBL.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // DepositGRP
            // 
            this.DepositGRP.Controls.Add(this.AmountNUD);
            this.DepositGRP.Controls.Add(this.AmountLBL);
            this.DepositGRP.ForeColor = System.Drawing.Color.LightGreen;
            this.DepositGRP.Location = new System.Drawing.Point(13, 307);
            this.DepositGRP.Name = "DepositGRP";
            this.DepositGRP.Size = new System.Drawing.Size(521, 154);
            this.DepositGRP.TabIndex = 1;
            this.DepositGRP.TabStop = false;
            this.DepositGRP.Text = "&Deposit";
            // 
            // AmountNUD
            // 
            this.AmountNUD.DecimalPlaces = 2;
            this.AmountNUD.Increment = new decimal(new int[] {
            25,
            0,
            0,
            131072});
            this.AmountNUD.Location = new System.Drawing.Point(364, 66);
            this.AmountNUD.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            131072});
            this.AmountNUD.Name = "AmountNUD";
            this.AmountNUD.Size = new System.Drawing.Size(137, 46);
            this.AmountNUD.TabIndex = 1;
            this.AmountNUD.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.AmountNUD.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // AmountLBL
            // 
            this.AmountLBL.AutoSize = true;
            this.AmountLBL.Location = new System.Drawing.Point(95, 73);
            this.AmountLBL.Name = "AmountLBL";
            this.AmountLBL.Size = new System.Drawing.Size(143, 39);
            this.AmountLBL.TabIndex = 0;
            this.AmountLBL.Text = "Am&ount";
            this.AmountLBL.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // SaveBTN
            // 
            this.SaveBTN.ForeColor = System.Drawing.Color.Black;
            this.SaveBTN.Location = new System.Drawing.Point(377, 485);
            this.SaveBTN.Name = "SaveBTN";
            this.SaveBTN.Size = new System.Drawing.Size(137, 46);
            this.SaveBTN.TabIndex = 3;
            this.SaveBTN.Text = "&Save";
            this.SaveBTN.UseVisualStyleBackColor = true;
            this.SaveBTN.Click += new System.EventHandler(this.SaveBTN_Click);
            // 
            // ReadBTN
            // 
            this.ReadBTN.ForeColor = System.Drawing.Color.Black;
            this.ReadBTN.Location = new System.Drawing.Point(13, 485);
            this.ReadBTN.Name = "ReadBTN";
            this.ReadBTN.Size = new System.Drawing.Size(137, 46);
            this.ReadBTN.TabIndex = 2;
            this.ReadBTN.Text = "&Read";
            this.ReadBTN.UseVisualStyleBackColor = true;
            this.ReadBTN.Click += new System.EventHandler(this.ReadBTN_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(20F, 39F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkBlue;
            this.ClientSize = new System.Drawing.Size(555, 563);
            this.Controls.Add(this.ReadBTN);
            this.Controls.Add(this.SaveBTN);
            this.Controls.Add(this.DepositGRP);
            this.Controls.Add(this.TempGRP);
            this.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold);
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.Name = "Form1";
            this.Text = "Brew For You TriCorder";
            this.TopMost = true;
            this.TempGRP.ResumeLayout(false);
            this.TempGRP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AfternoonNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MorningNUD)).EndInit();
            this.DepositGRP.ResumeLayout(false);
            this.DepositGRP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AmountNUD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox TempGRP;
        private System.Windows.Forms.Label AfternoonLBL;
        private System.Windows.Forms.Label MorningLBL;
        private System.Windows.Forms.NumericUpDown AfternoonNUD;
        private System.Windows.Forms.NumericUpDown MorningNUD;
        private System.Windows.Forms.GroupBox DepositGRP;
        private System.Windows.Forms.NumericUpDown AmountNUD;
        private System.Windows.Forms.Label AmountLBL;
        private System.Windows.Forms.Button SaveBTN;
        private System.Windows.Forms.Button ReadBTN;
    }
}

