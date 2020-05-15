namespace TaxiService
{
    partial class TaxistTruckDetails
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
            this.labelCargo = new System.Windows.Forms.Label();
            this.labelAmountSeats = new System.Windows.Forms.Label();
            this.numericUpDownCargo = new System.Windows.Forms.NumericUpDown();
            this.buttonOk = new System.Windows.Forms.Button();
            this.numericUpDownAmountPeople = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCargo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAmountPeople)).BeginInit();
            this.SuspendLayout();
            // 
            // labelCargo
            // 
            this.labelCargo.AutoSize = true;
            this.labelCargo.Font = new System.Drawing.Font("Jost Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCargo.Location = new System.Drawing.Point(-1, 24);
            this.labelCargo.Name = "labelCargo";
            this.labelCargo.Size = new System.Drawing.Size(192, 24);
            this.labelCargo.TabIndex = 19;
            this.labelCargo.Text = "Max kilograms cargo:";
            // 
            // labelAmountSeats
            // 
            this.labelAmountSeats.AutoSize = true;
            this.labelAmountSeats.Font = new System.Drawing.Font("Jost Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAmountSeats.Location = new System.Drawing.Point(0, 61);
            this.labelAmountSeats.Name = "labelAmountSeats";
            this.labelAmountSeats.Size = new System.Drawing.Size(129, 24);
            this.labelAmountSeats.TabIndex = 18;
            this.labelAmountSeats.Text = "Amount seats:";
            // 
            // numericUpDownCargo
            // 
            this.numericUpDownCargo.Font = new System.Drawing.Font("Jost Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDownCargo.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDownCargo.Location = new System.Drawing.Point(217, 22);
            this.numericUpDownCargo.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownCargo.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDownCargo.Name = "numericUpDownCargo";
            this.numericUpDownCargo.Size = new System.Drawing.Size(92, 32);
            this.numericUpDownCargo.TabIndex = 17;
            this.numericUpDownCargo.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDownCargo.ValueChanged += new System.EventHandler(this.numericUpDownCargo_ValueChanged);
            // 
            // buttonOk
            // 
            this.buttonOk.BackColor = System.Drawing.Color.Lime;
            this.buttonOk.Font = new System.Drawing.Font("Jost Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOk.Location = new System.Drawing.Point(6, 102);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(70, 32);
            this.buttonOk.TabIndex = 16;
            this.buttonOk.Text = "OK";
            this.buttonOk.UseVisualStyleBackColor = false;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // numericUpDownAmountPeople
            // 
            this.numericUpDownAmountPeople.Font = new System.Drawing.Font("Jost Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDownAmountPeople.Location = new System.Drawing.Point(153, 59);
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
            this.numericUpDownAmountPeople.Size = new System.Drawing.Size(56, 32);
            this.numericUpDownAmountPeople.TabIndex = 15;
            this.numericUpDownAmountPeople.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownAmountPeople.ValueChanged += new System.EventHandler(this.numericUpDownAmountPeople_ValueChanged);
            // 
            // TaxistTruckDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(307, 147);
            this.Controls.Add(this.labelCargo);
            this.Controls.Add(this.labelAmountSeats);
            this.Controls.Add(this.numericUpDownCargo);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.numericUpDownAmountPeople);
            this.Name = "TaxistTruckDetails";
            this.Text = "TaxistTruckDetails";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCargo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAmountPeople)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCargo;
        private System.Windows.Forms.Label labelAmountSeats;
        private System.Windows.Forms.NumericUpDown numericUpDownCargo;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.NumericUpDown numericUpDownAmountPeople;
    }
}