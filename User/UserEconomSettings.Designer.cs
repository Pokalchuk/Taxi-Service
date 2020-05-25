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
            this.components = new System.ComponentModel.Container();
            this.numericUpDownAmountPeople = new System.Windows.Forms.NumericUpDown();
            this.labelPeople = new System.Windows.Forms.Label();
            this.gunaControlBox2 = new Guna.UI.WinForms.GunaControlBox();
            this.gunaControlBox1 = new Guna.UI.WinForms.GunaControlBox();
            this.buttonFind = new Guna.UI.WinForms.GunaButton();
            this.checkBoxWheelChair = new Guna.UI.WinForms.GunaCheckBox();
            this.checkBoxChildSeat = new Guna.UI.WinForms.GunaCheckBox();
            this.gunaDragControl1 = new Guna.UI.WinForms.GunaDragControl(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAmountPeople)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDownAmountPeople
            // 
            this.numericUpDownAmountPeople.Font = new System.Drawing.Font("Jost Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDownAmountPeople.Location = new System.Drawing.Point(165, 46);
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
            // labelPeople
            // 
            this.labelPeople.AutoSize = true;
            this.labelPeople.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPeople.ForeColor = System.Drawing.Color.White;
            this.labelPeople.Location = new System.Drawing.Point(12, 46);
            this.labelPeople.Name = "labelPeople";
            this.labelPeople.Size = new System.Drawing.Size(82, 25);
            this.labelPeople.TabIndex = 4;
            this.labelPeople.Text = "People: ";
            // 
            // gunaControlBox2
            // 
            this.gunaControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaControlBox2.AnimationHoverSpeed = 0.07F;
            this.gunaControlBox2.AnimationSpeed = 0.03F;
            this.gunaControlBox2.ControlBoxType = Guna.UI.WinForms.FormControlBoxType.MinimizeBox;
            this.gunaControlBox2.IconColor = System.Drawing.Color.White;
            this.gunaControlBox2.IconSize = 15F;
            this.gunaControlBox2.Location = new System.Drawing.Point(148, 5);
            this.gunaControlBox2.Name = "gunaControlBox2";
            this.gunaControlBox2.OnHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.gunaControlBox2.OnHoverIconColor = System.Drawing.Color.White;
            this.gunaControlBox2.OnPressedColor = System.Drawing.Color.Black;
            this.gunaControlBox2.Size = new System.Drawing.Size(45, 29);
            this.gunaControlBox2.TabIndex = 38;
            // 
            // gunaControlBox1
            // 
            this.gunaControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaControlBox1.AnimationHoverSpeed = 0.07F;
            this.gunaControlBox1.AnimationSpeed = 0.03F;
            this.gunaControlBox1.IconColor = System.Drawing.Color.White;
            this.gunaControlBox1.IconSize = 15F;
            this.gunaControlBox1.Location = new System.Drawing.Point(188, 5);
            this.gunaControlBox1.Name = "gunaControlBox1";
            this.gunaControlBox1.OnHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.gunaControlBox1.OnHoverIconColor = System.Drawing.Color.White;
            this.gunaControlBox1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaControlBox1.Size = new System.Drawing.Size(45, 29);
            this.gunaControlBox1.TabIndex = 37;
            // 
            // buttonFind
            // 
            this.buttonFind.AnimationHoverSpeed = 0.07F;
            this.buttonFind.AnimationSpeed = 0.03F;
            this.buttonFind.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(64)))), ((int)(((byte)(71)))));
            this.buttonFind.BorderColor = System.Drawing.Color.Black;
            this.buttonFind.DialogResult = System.Windows.Forms.DialogResult.None;
            this.buttonFind.FocusedColor = System.Drawing.Color.Empty;
            this.buttonFind.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonFind.ForeColor = System.Drawing.Color.White;
            this.buttonFind.Image = null;
            this.buttonFind.ImageSize = new System.Drawing.Size(20, 20);
            this.buttonFind.Location = new System.Drawing.Point(16, 143);
            this.buttonFind.Name = "buttonFind";
            this.buttonFind.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.buttonFind.OnHoverBorderColor = System.Drawing.Color.Black;
            this.buttonFind.OnHoverForeColor = System.Drawing.Color.White;
            this.buttonFind.OnHoverImage = null;
            this.buttonFind.OnPressedColor = System.Drawing.Color.Black;
            this.buttonFind.Size = new System.Drawing.Size(61, 37);
            this.buttonFind.TabIndex = 42;
            this.buttonFind.Text = "Find";
            this.buttonFind.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.buttonFind.Click += new System.EventHandler(this.buttonFind_Click);
            // 
            // checkBoxWheelChair
            // 
            this.checkBoxWheelChair.BaseColor = System.Drawing.Color.White;
            this.checkBoxWheelChair.CheckedOffColor = System.Drawing.Color.Gray;
            this.checkBoxWheelChair.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.checkBoxWheelChair.FillColor = System.Drawing.Color.White;
            this.checkBoxWheelChair.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxWheelChair.ForeColor = System.Drawing.Color.White;
            this.checkBoxWheelChair.Location = new System.Drawing.Point(16, 109);
            this.checkBoxWheelChair.Name = "checkBoxWheelChair";
            this.checkBoxWheelChair.Size = new System.Drawing.Size(135, 28);
            this.checkBoxWheelChair.TabIndex = 41;
            this.checkBoxWheelChair.Text = "Wheel chair";
            this.checkBoxWheelChair.CheckedChanged += new System.EventHandler(this.checkBoxWheelChair_CheckedChanged);
            // 
            // checkBoxChildSeat
            // 
            this.checkBoxChildSeat.BaseColor = System.Drawing.Color.White;
            this.checkBoxChildSeat.CheckedOffColor = System.Drawing.Color.Gray;
            this.checkBoxChildSeat.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.checkBoxChildSeat.FillColor = System.Drawing.Color.White;
            this.checkBoxChildSeat.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxChildSeat.ForeColor = System.Drawing.Color.White;
            this.checkBoxChildSeat.Location = new System.Drawing.Point(16, 75);
            this.checkBoxChildSeat.Name = "checkBoxChildSeat";
            this.checkBoxChildSeat.Size = new System.Drawing.Size(117, 28);
            this.checkBoxChildSeat.TabIndex = 40;
            this.checkBoxChildSeat.Text = "Child seat";
            this.checkBoxChildSeat.CheckedChanged += new System.EventHandler(this.checkBoxChildSeat_CheckedChanged);
            // 
            // gunaDragControl1
            // 
            this.gunaDragControl1.TargetControl = this;
            // 
            // UserEconomSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(29)))));
            this.ClientSize = new System.Drawing.Size(232, 203);
            this.Controls.Add(this.buttonFind);
            this.Controls.Add(this.checkBoxWheelChair);
            this.Controls.Add(this.checkBoxChildSeat);
            this.Controls.Add(this.gunaControlBox2);
            this.Controls.Add(this.gunaControlBox1);
            this.Controls.Add(this.labelPeople);
            this.Controls.Add(this.numericUpDownAmountPeople);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UserEconomSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EconomSettings";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAmountPeople)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.NumericUpDown numericUpDownAmountPeople;
        private System.Windows.Forms.Label labelPeople;
        private Guna.UI.WinForms.GunaControlBox gunaControlBox2;
        private Guna.UI.WinForms.GunaControlBox gunaControlBox1;
        private Guna.UI.WinForms.GunaButton buttonFind;
        private Guna.UI.WinForms.GunaCheckBox checkBoxWheelChair;
        private Guna.UI.WinForms.GunaCheckBox checkBoxChildSeat;
        private Guna.UI.WinForms.GunaDragControl gunaDragControl1;
    }
}