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
            this.components = new System.ComponentModel.Container();
            this.labelCargo = new System.Windows.Forms.Label();
            this.labelAmountSeats = new System.Windows.Forms.Label();
            this.numericUpDownCargo = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownAmountPeople = new System.Windows.Forms.NumericUpDown();
            this.buttonOk = new Guna.UI.WinForms.GunaButton();
            this.gunaControlBox2 = new Guna.UI.WinForms.GunaControlBox();
            this.gunaControlBox1 = new Guna.UI.WinForms.GunaControlBox();
            this.gunaDragControl1 = new Guna.UI.WinForms.GunaDragControl(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCargo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAmountPeople)).BeginInit();
            this.SuspendLayout();
            // 
            // labelCargo
            // 
            this.labelCargo.AutoSize = true;
            this.labelCargo.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCargo.ForeColor = System.Drawing.Color.White;
            this.labelCargo.Location = new System.Drawing.Point(3, 41);
            this.labelCargo.Name = "labelCargo";
            this.labelCargo.Size = new System.Drawing.Size(205, 25);
            this.labelCargo.TabIndex = 19;
            this.labelCargo.Text = "Max kilograms cargo:";
            // 
            // labelAmountSeats
            // 
            this.labelAmountSeats.AutoSize = true;
            this.labelAmountSeats.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAmountSeats.ForeColor = System.Drawing.Color.White;
            this.labelAmountSeats.Location = new System.Drawing.Point(4, 78);
            this.labelAmountSeats.Name = "labelAmountSeats";
            this.labelAmountSeats.Size = new System.Drawing.Size(138, 25);
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
            this.numericUpDownCargo.Location = new System.Drawing.Point(225, 41);
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
            // numericUpDownAmountPeople
            // 
            this.numericUpDownAmountPeople.Font = new System.Drawing.Font("Jost Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDownAmountPeople.Location = new System.Drawing.Point(261, 79);
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
            this.buttonOk.Location = new System.Drawing.Point(8, 126);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.buttonOk.OnHoverBorderColor = System.Drawing.Color.Black;
            this.buttonOk.OnHoverForeColor = System.Drawing.Color.White;
            this.buttonOk.OnHoverImage = null;
            this.buttonOk.OnPressedColor = System.Drawing.Color.Black;
            this.buttonOk.Size = new System.Drawing.Size(61, 37);
            this.buttonOk.TabIndex = 33;
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
            this.gunaControlBox2.Location = new System.Drawing.Point(240, 1);
            this.gunaControlBox2.Name = "gunaControlBox2";
            this.gunaControlBox2.OnHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.gunaControlBox2.OnHoverIconColor = System.Drawing.Color.White;
            this.gunaControlBox2.OnPressedColor = System.Drawing.Color.Black;
            this.gunaControlBox2.Size = new System.Drawing.Size(45, 29);
            this.gunaControlBox2.TabIndex = 37;
            // 
            // gunaControlBox1
            // 
            this.gunaControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaControlBox1.AnimationHoverSpeed = 0.07F;
            this.gunaControlBox1.AnimationSpeed = 0.03F;
            this.gunaControlBox1.IconColor = System.Drawing.Color.White;
            this.gunaControlBox1.IconSize = 15F;
            this.gunaControlBox1.Location = new System.Drawing.Point(280, 1);
            this.gunaControlBox1.Name = "gunaControlBox1";
            this.gunaControlBox1.OnHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.gunaControlBox1.OnHoverIconColor = System.Drawing.Color.White;
            this.gunaControlBox1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaControlBox1.Size = new System.Drawing.Size(45, 29);
            this.gunaControlBox1.TabIndex = 36;
            // 
            // gunaDragControl1
            // 
            this.gunaDragControl1.TargetControl = this;
            // 
            // TaxistTruckDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(29)))));
            this.ClientSize = new System.Drawing.Size(329, 203);
            this.Controls.Add(this.gunaControlBox2);
            this.Controls.Add(this.gunaControlBox1);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.labelCargo);
            this.Controls.Add(this.labelAmountSeats);
            this.Controls.Add(this.numericUpDownCargo);
            this.Controls.Add(this.numericUpDownAmountPeople);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
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
        private System.Windows.Forms.NumericUpDown numericUpDownAmountPeople;
        private Guna.UI.WinForms.GunaButton buttonOk;
        private Guna.UI.WinForms.GunaControlBox gunaControlBox2;
        private Guna.UI.WinForms.GunaControlBox gunaControlBox1;
        private Guna.UI.WinForms.GunaDragControl gunaDragControl1;
    }
}