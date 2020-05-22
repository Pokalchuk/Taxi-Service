namespace TaxiService
{
    partial class OrderTaxiForm
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
            this.labelChoiceCar = new System.Windows.Forms.Label();
            this.labelCurrentAdress = new System.Windows.Forms.Label();
            this.labelFinalAdress = new System.Windows.Forms.Label();
            this.gunaControlBox2 = new Guna.UI.WinForms.GunaControlBox();
            this.gunaControlBox1 = new Guna.UI.WinForms.GunaControlBox();
            this.buttonFindCar = new Guna.UI.WinForms.GunaButton();
            this.textBoxCurrentAdress = new Guna.UI.WinForms.GunaTextBox();
            this.textBoxFinalAddress = new Guna.UI.WinForms.GunaTextBox();
            this.comboBoxCarsType = new Guna.UI.WinForms.GunaComboBox();
            this.gunaDragControl1 = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.SuspendLayout();
            // 
            // labelChoiceCar
            // 
            this.labelChoiceCar.AutoSize = true;
            this.labelChoiceCar.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelChoiceCar.ForeColor = System.Drawing.Color.White;
            this.labelChoiceCar.Location = new System.Drawing.Point(28, 43);
            this.labelChoiceCar.Name = "labelChoiceCar";
            this.labelChoiceCar.Size = new System.Drawing.Size(109, 25);
            this.labelChoiceCar.TabIndex = 1;
            this.labelChoiceCar.Text = "Choice car:";
            // 
            // labelCurrentAdress
            // 
            this.labelCurrentAdress.AutoSize = true;
            this.labelCurrentAdress.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCurrentAdress.ForeColor = System.Drawing.Color.White;
            this.labelCurrentAdress.Location = new System.Drawing.Point(28, 153);
            this.labelCurrentAdress.Name = "labelCurrentAdress";
            this.labelCurrentAdress.Size = new System.Drawing.Size(164, 25);
            this.labelCurrentAdress.TabIndex = 2;
            this.labelCurrentAdress.Text = "Current address: ";
            // 
            // labelFinalAdress
            // 
            this.labelFinalAdress.AutoSize = true;
            this.labelFinalAdress.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFinalAdress.ForeColor = System.Drawing.Color.White;
            this.labelFinalAdress.Location = new System.Drawing.Point(28, 192);
            this.labelFinalAdress.Name = "labelFinalAdress";
            this.labelFinalAdress.Size = new System.Drawing.Size(137, 25);
            this.labelFinalAdress.TabIndex = 4;
            this.labelFinalAdress.Text = "Final address: ";
            // 
            // gunaControlBox2
            // 
            this.gunaControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaControlBox2.AnimationHoverSpeed = 0.07F;
            this.gunaControlBox2.AnimationSpeed = 0.03F;
            this.gunaControlBox2.ControlBoxType = Guna.UI.WinForms.FormControlBoxType.MinimizeBox;
            this.gunaControlBox2.IconColor = System.Drawing.Color.White;
            this.gunaControlBox2.IconSize = 15F;
            this.gunaControlBox2.Location = new System.Drawing.Point(378, -3);
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
            this.gunaControlBox1.Location = new System.Drawing.Point(418, -3);
            this.gunaControlBox1.Name = "gunaControlBox1";
            this.gunaControlBox1.OnHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.gunaControlBox1.OnHoverIconColor = System.Drawing.Color.White;
            this.gunaControlBox1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaControlBox1.Size = new System.Drawing.Size(45, 29);
            this.gunaControlBox1.TabIndex = 37;
            // 
            // buttonFindCar
            // 
            this.buttonFindCar.AnimationHoverSpeed = 0.07F;
            this.buttonFindCar.AnimationSpeed = 0.03F;
            this.buttonFindCar.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(64)))), ((int)(((byte)(71)))));
            this.buttonFindCar.BorderColor = System.Drawing.Color.Black;
            this.buttonFindCar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.buttonFindCar.FocusedColor = System.Drawing.Color.Empty;
            this.buttonFindCar.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonFindCar.ForeColor = System.Drawing.Color.White;
            this.buttonFindCar.Image = null;
            this.buttonFindCar.ImageSize = new System.Drawing.Size(20, 20);
            this.buttonFindCar.Location = new System.Drawing.Point(32, 237);
            this.buttonFindCar.Name = "buttonFindCar";
            this.buttonFindCar.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.buttonFindCar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.buttonFindCar.OnHoverForeColor = System.Drawing.Color.White;
            this.buttonFindCar.OnHoverImage = null;
            this.buttonFindCar.OnPressedColor = System.Drawing.Color.Black;
            this.buttonFindCar.Size = new System.Drawing.Size(103, 39);
            this.buttonFindCar.TabIndex = 39;
            this.buttonFindCar.Text = "Find";
            this.buttonFindCar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.buttonFindCar.Click += new System.EventHandler(this.buttonFindCar_Click);
            // 
            // textBoxCurrentAdress
            // 
            this.textBoxCurrentAdress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(68)))), ((int)(((byte)(65)))));
            this.textBoxCurrentAdress.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.textBoxCurrentAdress.BorderColor = System.Drawing.Color.Black;
            this.textBoxCurrentAdress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxCurrentAdress.FocusedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(68)))), ((int)(((byte)(65)))));
            this.textBoxCurrentAdress.FocusedBorderColor = System.Drawing.Color.Black;
            this.textBoxCurrentAdress.FocusedForeColor = System.Drawing.Color.White;
            this.textBoxCurrentAdress.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxCurrentAdress.ForeColor = System.Drawing.Color.White;
            this.textBoxCurrentAdress.Location = new System.Drawing.Point(199, 144);
            this.textBoxCurrentAdress.Name = "textBoxCurrentAdress";
            this.textBoxCurrentAdress.PasswordChar = '\0';
            this.textBoxCurrentAdress.SelectedText = "";
            this.textBoxCurrentAdress.Size = new System.Drawing.Size(250, 34);
            this.textBoxCurrentAdress.TabIndex = 40;
            // 
            // textBoxFinalAddress
            // 
            this.textBoxFinalAddress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(68)))), ((int)(((byte)(65)))));
            this.textBoxFinalAddress.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.textBoxFinalAddress.BorderColor = System.Drawing.Color.Black;
            this.textBoxFinalAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxFinalAddress.FocusedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(68)))), ((int)(((byte)(65)))));
            this.textBoxFinalAddress.FocusedBorderColor = System.Drawing.Color.Black;
            this.textBoxFinalAddress.FocusedForeColor = System.Drawing.Color.White;
            this.textBoxFinalAddress.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxFinalAddress.ForeColor = System.Drawing.Color.White;
            this.textBoxFinalAddress.Location = new System.Drawing.Point(199, 192);
            this.textBoxFinalAddress.Name = "textBoxFinalAddress";
            this.textBoxFinalAddress.PasswordChar = '\0';
            this.textBoxFinalAddress.SelectedText = "";
            this.textBoxFinalAddress.Size = new System.Drawing.Size(250, 34);
            this.textBoxFinalAddress.TabIndex = 41;
            // 
            // comboBoxCarsType
            // 
            this.comboBoxCarsType.BackColor = System.Drawing.Color.Transparent;
            this.comboBoxCarsType.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.comboBoxCarsType.BorderColor = System.Drawing.Color.Black;
            this.comboBoxCarsType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxCarsType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCarsType.FocusedColor = System.Drawing.Color.Empty;
            this.comboBoxCarsType.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboBoxCarsType.ForeColor = System.Drawing.Color.White;
            this.comboBoxCarsType.FormattingEnabled = true;
            this.comboBoxCarsType.Items.AddRange(new object[] {
            "Econom",
            "Luxury",
            "Truck"});
            this.comboBoxCarsType.Location = new System.Drawing.Point(199, 43);
            this.comboBoxCarsType.Name = "comboBoxCarsType";
            this.comboBoxCarsType.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.comboBoxCarsType.OnHoverItemForeColor = System.Drawing.Color.White;
            this.comboBoxCarsType.Size = new System.Drawing.Size(251, 31);
            this.comboBoxCarsType.TabIndex = 68;
            // 
            // gunaDragControl1
            // 
            this.gunaDragControl1.TargetControl = this;
            // 
            // OrderTaxiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(29)))));
            this.ClientSize = new System.Drawing.Size(461, 299);
            this.Controls.Add(this.comboBoxCarsType);
            this.Controls.Add(this.textBoxFinalAddress);
            this.Controls.Add(this.textBoxCurrentAdress);
            this.Controls.Add(this.buttonFindCar);
            this.Controls.Add(this.gunaControlBox2);
            this.Controls.Add(this.gunaControlBox1);
            this.Controls.Add(this.labelFinalAdress);
            this.Controls.Add(this.labelCurrentAdress);
            this.Controls.Add(this.labelChoiceCar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OrderTaxiForm";
            this.Text = "Order form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelChoiceCar;
        private System.Windows.Forms.Label labelCurrentAdress;
        private System.Windows.Forms.Label labelFinalAdress;
        private Guna.UI.WinForms.GunaControlBox gunaControlBox2;
        private Guna.UI.WinForms.GunaControlBox gunaControlBox1;
        private Guna.UI.WinForms.GunaButton buttonFindCar;
        private Guna.UI.WinForms.GunaTextBox textBoxCurrentAdress;
        private Guna.UI.WinForms.GunaTextBox textBoxFinalAddress;
        private Guna.UI.WinForms.GunaComboBox comboBoxCarsType;
        private Guna.UI.WinForms.GunaDragControl gunaDragControl1;
    }
}