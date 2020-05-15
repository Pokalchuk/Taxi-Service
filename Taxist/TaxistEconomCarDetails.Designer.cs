namespace TaxiService
{
    partial class TaxistEconomCarDetails
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
            this.buttonOk = new System.Windows.Forms.Button();
            this.numericUpDownAmountPeople = new System.Windows.Forms.NumericUpDown();
            this.checkBoxWheelChair = new System.Windows.Forms.CheckBox();
            this.checkBoxChildSeat = new System.Windows.Forms.CheckBox();
            this.labelAmountSeats = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAmountPeople)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonOk
            // 
            this.buttonOk.BackColor = System.Drawing.Color.Lime;
            this.buttonOk.Font = new System.Drawing.Font("Jost Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOk.Location = new System.Drawing.Point(16, 137);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(61, 37);
            this.buttonOk.TabIndex = 7;
            this.buttonOk.Text = "OK";
            this.buttonOk.UseVisualStyleBackColor = false;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // numericUpDownAmountPeople
            // 
            this.numericUpDownAmountPeople.Font = new System.Drawing.Font("Jost Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDownAmountPeople.Location = new System.Drawing.Point(161, 47);
            this.numericUpDownAmountPeople.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numericUpDownAmountPeople.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownAmountPeople.Name = "numericUpDownAmountPeople";
            this.numericUpDownAmountPeople.Size = new System.Drawing.Size(46, 32);
            this.numericUpDownAmountPeople.TabIndex = 6;
            this.numericUpDownAmountPeople.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownAmountPeople.ValueChanged += new System.EventHandler(this.numericUpDownAmountPeople_ValueChanged);
            // 
            // checkBoxWheelChair
            // 
            this.checkBoxWheelChair.AutoSize = true;
            this.checkBoxWheelChair.Font = new System.Drawing.Font("Jost Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxWheelChair.Location = new System.Drawing.Point(16, 103);
            this.checkBoxWheelChair.Name = "checkBoxWheelChair";
            this.checkBoxWheelChair.Size = new System.Drawing.Size(133, 28);
            this.checkBoxWheelChair.TabIndex = 5;
            this.checkBoxWheelChair.Text = "Wheel chair";
            this.checkBoxWheelChair.UseVisualStyleBackColor = true;
            this.checkBoxWheelChair.CheckedChanged += new System.EventHandler(this.checkBoxWheelChair_CheckedChanged);
            // 
            // checkBoxChildSeat
            // 
            this.checkBoxChildSeat.AutoSize = true;
            this.checkBoxChildSeat.Font = new System.Drawing.Font("Jost Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxChildSeat.Location = new System.Drawing.Point(16, 76);
            this.checkBoxChildSeat.Name = "checkBoxChildSeat";
            this.checkBoxChildSeat.Size = new System.Drawing.Size(117, 28);
            this.checkBoxChildSeat.TabIndex = 4;
            this.checkBoxChildSeat.Text = "Child seat";
            this.checkBoxChildSeat.UseVisualStyleBackColor = true;
            this.checkBoxChildSeat.CheckedChanged += new System.EventHandler(this.checkBoxChildSeat_CheckedChanged);
            // 
            // labelAmountSeats
            // 
            this.labelAmountSeats.AutoSize = true;
            this.labelAmountSeats.Font = new System.Drawing.Font("Jost Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAmountSeats.Location = new System.Drawing.Point(12, 49);
            this.labelAmountSeats.Name = "labelAmountSeats";
            this.labelAmountSeats.Size = new System.Drawing.Size(129, 24);
            this.labelAmountSeats.TabIndex = 8;
            this.labelAmountSeats.Text = "Amount seats:";
            // 
            // TaxistEconomCarDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(232, 203);
            this.Controls.Add(this.labelAmountSeats);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.numericUpDownAmountPeople);
            this.Controls.Add(this.checkBoxWheelChair);
            this.Controls.Add(this.checkBoxChildSeat);
            this.Name = "TaxistEconomCarDetails";
            this.Text = "TaxistEconomCarDetails";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAmountPeople)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.NumericUpDown numericUpDownAmountPeople;
        private System.Windows.Forms.CheckBox checkBoxWheelChair;
        private System.Windows.Forms.CheckBox checkBoxChildSeat;
        private System.Windows.Forms.Label labelAmountSeats;
    }
}