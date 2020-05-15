namespace TaxiService
{
    partial class TaxistLuxuryCarDetails
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
            this.labelAmountSeats = new System.Windows.Forms.Label();
            this.numericUpDownAmountPeople = new System.Windows.Forms.NumericUpDown();
            this.checkBoxAlcohol = new System.Windows.Forms.CheckBox();
            this.checkBoxTv = new System.Windows.Forms.CheckBox();
            this.buttonOk = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAmountPeople)).BeginInit();
            this.SuspendLayout();
            // 
            // labelAmountSeats
            // 
            this.labelAmountSeats.AutoSize = true;
            this.labelAmountSeats.Font = new System.Drawing.Font("Jost Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAmountSeats.Location = new System.Drawing.Point(12, 46);
            this.labelAmountSeats.Name = "labelAmountSeats";
            this.labelAmountSeats.Size = new System.Drawing.Size(129, 24);
            this.labelAmountSeats.TabIndex = 13;
            this.labelAmountSeats.Text = "Amount seats:";
            // 
            // numericUpDownAmountPeople
            // 
            this.numericUpDownAmountPeople.Font = new System.Drawing.Font("Jost Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDownAmountPeople.Location = new System.Drawing.Point(167, 44);
            this.numericUpDownAmountPeople.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDownAmountPeople.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownAmountPeople.Name = "numericUpDownAmountPeople";
            this.numericUpDownAmountPeople.Size = new System.Drawing.Size(45, 32);
            this.numericUpDownAmountPeople.TabIndex = 11;
            this.numericUpDownAmountPeople.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownAmountPeople.ValueChanged += new System.EventHandler(this.numericUpDownAmountPeople_ValueChanged);
            // 
            // checkBoxAlcohol
            // 
            this.checkBoxAlcohol.AutoSize = true;
            this.checkBoxAlcohol.Font = new System.Drawing.Font("Jost Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxAlcohol.Location = new System.Drawing.Point(16, 100);
            this.checkBoxAlcohol.Name = "checkBoxAlcohol";
            this.checkBoxAlcohol.Size = new System.Drawing.Size(96, 28);
            this.checkBoxAlcohol.TabIndex = 10;
            this.checkBoxAlcohol.Text = "Alcohol";
            this.checkBoxAlcohol.UseVisualStyleBackColor = true;
            this.checkBoxAlcohol.CheckedChanged += new System.EventHandler(this.checkBoxAlcohol_CheckedChanged);
            // 
            // checkBoxTv
            // 
            this.checkBoxTv.AutoSize = true;
            this.checkBoxTv.Font = new System.Drawing.Font("Jost Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxTv.Location = new System.Drawing.Point(16, 73);
            this.checkBoxTv.Name = "checkBoxTv";
            this.checkBoxTv.Size = new System.Drawing.Size(56, 28);
            this.checkBoxTv.TabIndex = 9;
            this.checkBoxTv.Text = "TV";
            this.checkBoxTv.UseVisualStyleBackColor = true;
            this.checkBoxTv.CheckedChanged += new System.EventHandler(this.checkBoxTv_CheckedChanged);
            // 
            // buttonOk
            // 
            this.buttonOk.BackColor = System.Drawing.Color.Lime;
            this.buttonOk.Font = new System.Drawing.Font("Jost Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOk.Location = new System.Drawing.Point(11, 138);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(61, 37);
            this.buttonOk.TabIndex = 14;
            this.buttonOk.Text = "OK";
            this.buttonOk.UseVisualStyleBackColor = false;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // TaxistLuxuryCarDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(232, 203);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.labelAmountSeats);
            this.Controls.Add(this.numericUpDownAmountPeople);
            this.Controls.Add(this.checkBoxAlcohol);
            this.Controls.Add(this.checkBoxTv);
            this.Name = "TaxistLuxuryCarDetails";
            this.Text = "TaxistLuxuryCarDetails";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAmountPeople)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAmountSeats;
        private System.Windows.Forms.NumericUpDown numericUpDownAmountPeople;
        private System.Windows.Forms.CheckBox checkBoxAlcohol;
        private System.Windows.Forms.CheckBox checkBoxTv;
        private System.Windows.Forms.Button buttonOk;
    }
}