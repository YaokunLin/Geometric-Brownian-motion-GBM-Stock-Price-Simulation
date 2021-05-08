namespace Geometric_Brownian_motion__GBM__Stock_Price_Simulation__ActuaryProgrammer_
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxStockTicker = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.label4 = new System.Windows.Forms.Label();
            this.PriceTime0 = new System.Windows.Forms.NumericUpDown();
            this.volatility = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.AnnualReturn = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.DaysForProjection = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.NumofSim = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.Run = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PriceTime0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.volatility)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AnnualReturn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DaysForProjection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumofSim)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(565, 567);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(446, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "GBM Simulation @yaokunlin.github.io/ActuaryProgrammer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(149, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ticker:";
            // 
            // textBoxStockTicker
            // 
            this.textBoxStockTicker.Location = new System.Drawing.Point(215, 36);
            this.textBoxStockTicker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxStockTicker.Name = "textBoxStockTicker";
            this.textBoxStockTicker.Size = new System.Drawing.Size(263, 22);
            this.textBoxStockTicker.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(144, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Time 0:";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(215, 78);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(196, 306);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Price at Time 0:";
            // 
            // PriceTime0
            // 
            this.PriceTime0.DecimalPlaces = 2;
            this.PriceTime0.Location = new System.Drawing.Point(357, 305);
            this.PriceTime0.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PriceTime0.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.PriceTime0.Name = "PriceTime0";
            this.PriceTime0.Size = new System.Drawing.Size(120, 22);
            this.PriceTime0.TabIndex = 6;
            this.PriceTime0.Value = new decimal(new int[] {
            325785,
            0,
            0,
            131072});
            // 
            // volatility
            // 
            this.volatility.DecimalPlaces = 2;
            this.volatility.Location = new System.Drawing.Point(357, 338);
            this.volatility.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.volatility.Name = "volatility";
            this.volatility.Size = new System.Drawing.Size(120, 22);
            this.volatility.TabIndex = 8;
            this.volatility.Value = new decimal(new int[] {
            125,
            0,
            0,
            65536});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(147, 341);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(178, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Annualized Volatility σ:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(504, 338);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(335, 18);
            this.label6.TabIndex = 9;
            this.label6.Text = "eg. For annualized volatility of 15.23%, enter 15.23";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(504, 306);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(326, 18);
            this.label7.TabIndex = 10;
            this.label7.Text = "eg. For initial stock price = $235.69, enter 235.69";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(504, 375);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(322, 18);
            this.label8.TabIndex = 13;
            this.label8.Text = "eg. For annualized return of 26.08%, enter 26.08";
            // 
            // AnnualReturn
            // 
            this.AnnualReturn.DecimalPlaces = 2;
            this.AnnualReturn.Location = new System.Drawing.Point(357, 375);
            this.AnnualReturn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AnnualReturn.Name = "AnnualReturn";
            this.AnnualReturn.Size = new System.Drawing.Size(120, 22);
            this.AnnualReturn.TabIndex = 12;
            this.AnnualReturn.Value = new decimal(new int[] {
            2608,
            0,
            0,
            131072});
            this.AnnualReturn.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(159, 375);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(165, 20);
            this.label9.TabIndex = 11;
            this.label9.Text = "Annualized Return μ:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(504, 412);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(382, 18);
            this.label10.TabIndex = 16;
            this.label10.Text = "eg. For simulating 1 Yr of Stock Prices (252 trading days)";
            // 
            // DaysForProjection
            // 
            this.DaysForProjection.Location = new System.Drawing.Point(352, 414);
            this.DaysForProjection.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DaysForProjection.Maximum = new decimal(new int[] {
            1500,
            0,
            0,
            0});
            this.DaysForProjection.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.DaysForProjection.Name = "DaysForProjection";
            this.DaysForProjection.Size = new System.Drawing.Size(120, 22);
            this.DaysForProjection.TabIndex = 15;
            this.DaysForProjection.Value = new decimal(new int[] {
            252,
            0,
            0,
            0});
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(15, 412);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(305, 20);
            this.label11.TabIndex = 14;
            this.label11.Text = "Number of Trading Days for Simulation:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(504, 430);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(189, 18);
            this.label12.TabIndex = 17;
            this.label12.Text = "enter 252, max = 1500 days";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(504, 459);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(300, 36);
            this.label13.TabIndex = 19;
            this.label13.Text = "Max = 10000 Simulations, with\r\n control variate method to enhance precision";
            // 
            // NumofSim
            // 
            this.NumofSim.Location = new System.Drawing.Point(352, 459);
            this.NumofSim.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NumofSim.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.NumofSim.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumofSim.Name = "NumofSim";
            this.NumofSim.Size = new System.Drawing.Size(120, 22);
            this.NumofSim.TabIndex = 18;
            this.NumofSim.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(139, 457);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(184, 20);
            this.label14.TabIndex = 20;
            this.label14.Text = "Number of Simulations:";
            // 
            // Run
            // 
            this.Run.Location = new System.Drawing.Point(200, 516);
            this.Run.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Run.Name = "Run";
            this.Run.Size = new System.Drawing.Size(317, 31);
            this.Run.TabIndex = 21;
            this.Run.Text = "Run Simulation";
            this.Run.UseVisualStyleBackColor = true;
            this.Run.Click += new System.EventHandler(this.Run_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1119, 620);
            this.Controls.Add(this.Run);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.NumofSim);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.DaysForProjection);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.AnnualReturn);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.volatility);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.PriceTime0);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxStockTicker);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Geometric Brownian Motion Stock Price Simulation";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PriceTime0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.volatility)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AnnualReturn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DaysForProjection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumofSim)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxStockTicker;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown PriceTime0;
        private System.Windows.Forms.NumericUpDown volatility;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown AnnualReturn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown DaysForProjection;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown NumofSim;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button Run;
    }
}

