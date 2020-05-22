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
            this.components = new System.ComponentModel.Container();
            this.numericUpDownAmountPeople = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownCargo = new System.Windows.Forms.NumericUpDown();
            this.labelPeople = new System.Windows.Forms.Label();
            this.labelCargo = new System.Windows.Forms.Label();
            this.gunaControlBox2 = new Guna.UI.WinForms.GunaControlBox();
            this.gunaControlBox1 = new Guna.UI.WinForms.GunaControlBox();
            this.buttonFind = new Guna.UI.WinForms.GunaButton();
            this.gunaDragControl1 = new Guna.UI.WinForms.GunaDragControl(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAmountPeople)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCargo)).BeginInit();
            this.SuspendLayout();
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
            this.labelPeople.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPeople.ForeColor = System.Drawing.Color.White;
            this.labelPeople.Location = new System.Drawing.Point(2, 89);
            this.labelPeople.Name = "labelPeople";
            this.labelPeople.Size = new System.Drawing.Size(77, 25);
            this.labelPeople.TabIndex = 13;
            this.labelPeople.Text = "People:";
            // 
            // labelCargo
            // 
            this.labelCargo.AutoSize = true;
            this.labelCargo.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCargo.ForeColor = System.Drawing.Color.White;
            this.labelCargo.Location = new System.Drawing.Point(2, 50);
            this.labelCargo.Name = "labelCargo";
            this.labelCargo.Size = new System.Drawing.Size(162, 25);
            this.labelCargo.TabIndex = 14;
            this.labelCargo.Text = "Kilograms cargo:";
            // 
            // gunaControlBox2
            // 
            this.gunaControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaControlBox2.AnimationHoverSpeed = 0.07F;
            this.gunaControlBox2.AnimationSpeed = 0.03F;
            this.gunaControlBox2.ControlBoxType = Guna.UI.WinForms.FormControlBoxType.MinimizeBox;
            this.gunaControlBox2.IconColor = System.Drawing.Color.White;
            this.gunaControlBox2.IconSize = 15F;
            this.gunaControlBox2.Location = new System.Drawing.Point(222, 0);
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
            this.gunaControlBox1.Location = new System.Drawing.Point(262, 0);
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
            this.buttonFind.Location = new System.Drawing.Point(7, 139);
            this.buttonFind.Name = "buttonFind";
            this.buttonFind.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.buttonFind.OnHoverBorderColor = System.Drawing.Color.Black;
            this.buttonFind.OnHoverForeColor = System.Drawing.Color.White;
            this.buttonFind.OnHoverImage = null;
            this.buttonFind.OnPressedColor = System.Drawing.Color.Black;
            this.buttonFind.Size = new System.Drawing.Size(61, 37);
            this.buttonFind.TabIndex = 48;
            this.buttonFind.Text = "Find";
            this.buttonFind.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.buttonFind.Click += new System.EventHandler(this.buttonFind_Click);
            // 
            // gunaDragControl1
            // 
            this.gunaDragControl1.TargetControl = this;
            // 
            // UserTruckSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(29)))));
            this.ClientSize = new System.Drawing.Size(306, 205);
            this.Controls.Add(this.buttonFind);
            this.Controls.Add(this.gunaControlBox2);
            this.Controls.Add(this.gunaControlBox1);
            this.Controls.Add(this.labelCargo);
            this.Controls.Add(this.labelPeople);
            this.Controls.Add(this.numericUpDownCargo);
            this.Controls.Add(this.numericUpDownAmountPeople);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UserTruckSettings";
            this.Text = "TruckSettings";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAmountPeople)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCargo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.NumericUpDown numericUpDownAmountPeople;
        private System.Windows.Forms.NumericUpDown numericUpDownCargo;
        private System.Windows.Forms.Label labelPeople;
        private System.Windows.Forms.Label labelCargo;
        private Guna.UI.WinForms.GunaControlBox gunaControlBox2;
        private Guna.UI.WinForms.GunaControlBox gunaControlBox1;
        private Guna.UI.WinForms.GunaButton buttonFind;
        private Guna.UI.WinForms.GunaDragControl gunaDragControl1;
    }
}