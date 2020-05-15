namespace TaxiService
{
    partial class UserEconomSettings
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
            this.checkBoxChildSeat = new System.Windows.Forms.CheckBox();
            this.checkBoxWheelChair = new System.Windows.Forms.CheckBox();
            this.numericUpDownAmountPeople = new System.Windows.Forms.NumericUpDown();
            this.buttonFind = new System.Windows.Forms.Button();
            this.labelPeople = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAmountPeople)).BeginInit();
            this.SuspendLayout();
            // 
            // checkBoxChildSeat
            // 
            this.checkBoxChildSeat.AutoSize = true;
            this.checkBoxChildSeat.Font = new System.Drawing.Font("Jost Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxChildSeat.Location = new System.Drawing.Point(38, 78);
            this.checkBoxChildSeat.Name = "checkBoxChildSeat";
            this.checkBoxChildSeat.Size = new System.Drawing.Size(117, 28);
            this.checkBoxChildSeat.TabIndex = 0;
            this.checkBoxChildSeat.Text = "Child seat";
            this.checkBoxChildSeat.UseVisualStyleBackColor = true;
            this.checkBoxChildSeat.CheckedChanged += new System.EventHandler(this.checkBoxChildSeat_CheckedChanged);
            // 
            // checkBoxWheelChair
            // 
            this.checkBoxWheelChair.AutoSize = true;
            this.checkBoxWheelChair.Font = new System.Drawing.Font("Jost Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxWheelChair.Location = new System.Drawing.Point(38, 105);
            this.checkBoxWheelChair.Name = "checkBoxWheelChair";
            this.checkBoxWheelChair.Size = new System.Drawing.Size(133, 28);
            this.checkBoxWheelChair.TabIndex = 1;
            this.checkBoxWheelChair.Text = "Wheel chair";
            this.checkBoxWheelChair.UseVisualStyleBackColor = true;
            this.checkBoxWheelChair.CheckedChanged += new System.EventHandler(this.checkBoxWheelChair_CheckedChanged);
            // 
            // numericUpDownAmountPeople
            // 
            this.numericUpDownAmountPeople.Font = new System.Drawing.Font("Jost Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDownAmountPeople.Location = new System.Drawing.Point(132, 40);
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
            this.numericUpDownAmountPeople.Size = new System.Drawing.Size(54, 32);
            this.numericUpDownAmountPeople.TabIndex = 2;
            this.numericUpDownAmountPeople.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownAmountPeople.ValueChanged += new System.EventHandler(this.numericUpDownAmountPeople_ValueChanged);
            // 
            // buttonFind
            // 
            this.buttonFind.BackColor = System.Drawing.Color.Lime;
            this.buttonFind.Font = new System.Drawing.Font("Jost Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonFind.Location = new System.Drawing.Point(38, 139);
            this.buttonFind.Name = "buttonFind";
            this.buttonFind.Size = new System.Drawing.Size(75, 40);
            this.buttonFind.TabIndex = 3;
            this.buttonFind.Text = "Find";
            this.buttonFind.UseVisualStyleBackColor = false;
            this.buttonFind.Click += new System.EventHandler(this.buttonFind_Click);
            // 
            // labelPeople
            // 
            this.labelPeople.AutoSize = true;
            this.labelPeople.Font = new System.Drawing.Font("Jost Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPeople.Location = new System.Drawing.Point(34, 42);
            this.labelPeople.Name = "labelPeople";
            this.labelPeople.Size = new System.Drawing.Size(79, 24);
            this.labelPeople.TabIndex = 4;
            this.labelPeople.Text = "People: ";
            // 
            // EconomSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(222, 202);
            this.Controls.Add(this.labelPeople);
            this.Controls.Add(this.buttonFind);
            this.Controls.Add(this.numericUpDownAmountPeople);
            this.Controls.Add(this.checkBoxWheelChair);
            this.Controls.Add(this.checkBoxChildSeat);
            this.Name = "EconomSettings";
            this.Text = "EconomSettings";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAmountPeople)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBoxChildSeat;
        private System.Windows.Forms.CheckBox checkBoxWheelChair;
        private System.Windows.Forms.NumericUpDown numericUpDownAmountPeople;
        private System.Windows.Forms.Button buttonFind;
        private System.Windows.Forms.Label labelPeople;
    }
}