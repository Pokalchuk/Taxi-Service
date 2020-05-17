namespace TaxiService
{
    partial class UserTruckSettings
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
            this.buttonFind = new System.Windows.Forms.Button();
            this.numericUpDownAmountPeople = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownCargo = new System.Windows.Forms.NumericUpDown();
            this.labelPeople = new System.Windows.Forms.Label();
            this.labelCargo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAmountPeople)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCargo)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonFind
            // 
            this.buttonFind.BackColor = System.Drawing.Color.Lime;
            this.buttonFind.Font = new System.Drawing.Font("Jost Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonFind.Location = new System.Drawing.Point(6, 137);
            this.buttonFind.Name = "buttonFind";
            this.buttonFind.Size = new System.Drawing.Size(82, 40);
            this.buttonFind.TabIndex = 11;
            this.buttonFind.Text = "Find";
            this.buttonFind.UseVisualStyleBackColor = false;
            this.buttonFind.Click += new System.EventHandler(this.buttonFind_Click);
            // 
            // numericUpDownAmountPeople
            // 
            this.numericUpDownAmountPeople.Font = new System.Drawing.Font("Jost Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDownAmountPeople.Location = new System.Drawing.Point(193, 89);
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
            this.numericUpDownAmountPeople.Size = new System.Drawing.Size(65, 32);
            this.numericUpDownAmountPeople.TabIndex = 10;
            this.numericUpDownAmountPeople.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDownCargo
            // 
            this.numericUpDownCargo.Font = new System.Drawing.Font("Jost Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDownCargo.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDownCargo.Location = new System.Drawing.Point(193, 48);
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
            this.numericUpDownCargo.Size = new System.Drawing.Size(99, 32);
            this.numericUpDownCargo.TabIndex = 12;
            this.numericUpDownCargo.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // labelPeople
            // 
            this.labelPeople.AutoSize = true;
            this.labelPeople.Font = new System.Drawing.Font("Jost Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPeople.Location = new System.Drawing.Point(2, 89);
            this.labelPeople.Name = "labelPeople";
            this.labelPeople.Size = new System.Drawing.Size(73, 24);
            this.labelPeople.TabIndex = 13;
            this.labelPeople.Text = "People:";
            // 
            // labelCargo
            // 
            this.labelCargo.AutoSize = true;
            this.labelCargo.Font = new System.Drawing.Font("Jost Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCargo.Location = new System.Drawing.Point(2, 50);
            this.labelCargo.Name = "labelCargo";
            this.labelCargo.Size = new System.Drawing.Size(155, 24);
            this.labelCargo.TabIndex = 14;
            this.labelCargo.Text = "Kilograms cargo:";
            // 
            // UserTruckSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(306, 205);
            this.Controls.Add(this.labelCargo);
            this.Controls.Add(this.labelPeople);
            this.Controls.Add(this.numericUpDownCargo);
            this.Controls.Add(this.buttonFind);
            this.Controls.Add(this.numericUpDownAmountPeople);
            this.Name = "UserTruckSettings";
            this.Text = "TruckSettings";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAmountPeople)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCargo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonFind;
        private System.Windows.Forms.NumericUpDown numericUpDownAmountPeople;
        private System.Windows.Forms.NumericUpDown numericUpDownCargo;
        private System.Windows.Forms.Label labelPeople;
        private System.Windows.Forms.Label labelCargo;
    }
}