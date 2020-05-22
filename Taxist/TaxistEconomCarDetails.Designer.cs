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
            this.components = new System.ComponentModel.Container();
            this.labelAmountSeats = new System.Windows.Forms.Label();
            this.checkBoxChildSeat = new Guna.UI.WinForms.GunaCheckBox();
            this.checkBoxWheelChair = new Guna.UI.WinForms.GunaCheckBox();
            this.buttonOk = new Guna.UI.WinForms.GunaButton();
            this.gunaControlBox2 = new Guna.UI.WinForms.GunaControlBox();
            this.gunaControlBox1 = new Guna.UI.WinForms.GunaControlBox();
            this.numericUpDownAmountPeople = new System.Windows.Forms.NumericUpDown();
            this.gunaDragControl1 = new Guna.UI.WinForms.GunaDragControl(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAmountPeople)).BeginInit();
            this.SuspendLayout();
            // 
            // labelAmountSeats
            // 
            this.labelAmountSeats.AutoSize = true;
            this.labelAmountSeats.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAmountSeats.ForeColor = System.Drawing.Color.White;
            this.labelAmountSeats.Location = new System.Drawing.Point(12, 49);
            this.labelAmountSeats.Name = "labelAmountSeats";
            this.labelAmountSeats.Size = new System.Drawing.Size(138, 25);
            this.labelAmountSeats.TabIndex = 8;
            this.labelAmountSeats.Text = "Amount seats:";
            // 
            // checkBoxChildSeat
            // 
            this.checkBoxChildSeat.BaseColor = System.Drawing.Color.White;
            this.checkBoxChildSeat.CheckedOffColor = System.Drawing.Color.Gray;
            this.checkBoxChildSeat.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.checkBoxChildSeat.FillColor = System.Drawing.Color.White;
            this.checkBoxChildSeat.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxChildSeat.ForeColor = System.Drawing.Color.White;
            this.checkBoxChildSeat.Location = new System.Drawing.Point(16, 76);
            this.checkBoxChildSeat.Name = "checkBoxChildSeat";
            this.checkBoxChildSeat.Size = new System.Drawing.Size(117, 28);
            this.checkBoxChildSeat.TabIndex = 26;
            this.checkBoxChildSeat.Text = "Child seat";
            this.checkBoxChildSeat.CheckedChanged += new System.EventHandler(this.checkBoxChildSeat_CheckedChanged);
            // 
            // checkBoxWheelChair
            // 
            this.checkBoxWheelChair.BaseColor = System.Drawing.Color.White;
            this.checkBoxWheelChair.CheckedOffColor = System.Drawing.Color.Gray;
            this.checkBoxWheelChair.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.checkBoxWheelChair.FillColor = System.Drawing.Color.White;
            this.checkBoxWheelChair.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxWheelChair.ForeColor = System.Drawing.Color.White;
            this.checkBoxWheelChair.Location = new System.Drawing.Point(16, 103);
            this.checkBoxWheelChair.Name = "checkBoxWheelChair";
            this.checkBoxWheelChair.Size = new System.Drawing.Size(135, 28);
            this.checkBoxWheelChair.TabIndex = 27;
            this.checkBoxWheelChair.Text = "Wheel chair";
            this.checkBoxWheelChair.CheckedChanged += new System.EventHandler(this.checkBoxWheelChair_CheckedChanged);
            // 
            // buttonOk
            // 
            this.buttonOk.AnimationHoverSpeed = 0.07F;
            this.buttonOk.AnimationSpeed = 0.03F;
            this.buttonOk.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(64)))), ((int)(((byte)(71)))));
            this.buttonOk.BorderColor = System.Drawing.Color.Black;
            this.buttonOk.DialogResult = System.Windows.Forms.DialogResult.None;
            this.buttonOk.FocusedColor = System.Drawing.Color.Empty;
            this.buttonOk.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOk.ForeColor = System.Drawing.Color.White;
            this.buttonOk.Image = null;
            this.buttonOk.ImageSize = new System.Drawing.Size(20, 20);
            this.buttonOk.Location = new System.Drawing.Point(17, 137);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.buttonOk.OnHoverBorderColor = System.Drawing.Color.Black;
            this.buttonOk.OnHoverForeColor = System.Drawing.Color.White;
            this.buttonOk.OnHoverImage = null;
            this.buttonOk.OnPressedColor = System.Drawing.Color.Black;
            this.buttonOk.Size = new System.Drawing.Size(61, 37);
            this.buttonOk.TabIndex = 28;
            this.buttonOk.Text = "OK";
            this.buttonOk.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // gunaControlBox2
            // 
            this.gunaControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaControlBox2.AnimationHoverSpeed = 0.07F;
            this.gunaControlBox2.AnimationSpeed = 0.03F;
            this.gunaControlBox2.ControlBoxType = Guna.UI.WinForms.FormControlBoxType.MinimizeBox;
            this.gunaControlBox2.IconColor = System.Drawing.Color.White;
            this.gunaControlBox2.IconSize = 15F;
            this.gunaControlBox2.Location = new System.Drawing.Point(145, 1);
            this.gunaControlBox2.Name = "gunaControlBox2";
            this.gunaControlBox2.OnHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.gunaControlBox2.OnHoverIconColor = System.Drawing.Color.White;
            this.gunaControlBox2.OnPressedColor = System.Drawing.Color.Black;
            this.gunaControlBox2.Size = new System.Drawing.Size(45, 29);
            this.gunaControlBox2.TabIndex = 31;
            // 
            // gunaControlBox1
            // 
            this.gunaControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaControlBox1.AnimationHoverSpeed = 0.07F;
            this.gunaControlBox1.AnimationSpeed = 0.03F;
            this.gunaControlBox1.IconColor = System.Drawing.Color.White;
            this.gunaControlBox1.IconSize = 15F;
            this.gunaControlBox1.Location = new System.Drawing.Point(185, 1);
            this.gunaControlBox1.Name = "gunaControlBox1";
            this.gunaControlBox1.OnHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.gunaControlBox1.OnHoverIconColor = System.Drawing.Color.White;
            this.gunaControlBox1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaControlBox1.Size = new System.Drawing.Size(45, 29);
            this.gunaControlBox1.TabIndex = 30;
            // 
            // numericUpDownAmountPeople
            // 
            this.numericUpDownAmountPeople.Font = new System.Drawing.Font("Jost Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDownAmountPeople.Location = new System.Drawing.Point(156, 49);
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
            this.numericUpDownAmountPeople.Size = new System.Drawing.Size(56, 32);
            this.numericUpDownAmountPeople.TabIndex = 38;
            this.numericUpDownAmountPeople.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownAmountPeople.ValueChanged += new System.EventHandler(this.numericUpDownAmountPeople_ValueChanged);
            // 
            // gunaDragControl1
            // 
            this.gunaDragControl1.TargetControl = this;
            // 
            // TaxistEconomCarDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(29)))));
            this.ClientSize = new System.Drawing.Size(232, 203);
            this.Controls.Add(this.numericUpDownAmountPeople);
            this.Controls.Add(this.gunaControlBox2);
            this.Controls.Add(this.gunaControlBox1);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.checkBoxWheelChair);
            this.Controls.Add(this.checkBoxChildSeat);
            this.Controls.Add(this.labelAmountSeats);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TaxistEconomCarDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TaxistEconomCarDetails";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAmountPeople)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelAmountSeats;
        private Guna.UI.WinForms.GunaCheckBox checkBoxChildSeat;
        private Guna.UI.WinForms.GunaCheckBox checkBoxWheelChair;
        private Guna.UI.WinForms.GunaButton buttonOk;
        private Guna.UI.WinForms.GunaControlBox gunaControlBox2;
        private Guna.UI.WinForms.GunaControlBox gunaControlBox1;
        private System.Windows.Forms.NumericUpDown numericUpDownAmountPeople;
        private Guna.UI.WinForms.GunaDragControl gunaDragControl1;
    }
}