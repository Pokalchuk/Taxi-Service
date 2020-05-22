namespace TaxiService
{
    partial class TaxistWorking
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
            this.labelDistrict = new System.Windows.Forms.Label();
            this.gunaControlBox2 = new Guna.UI.WinForms.GunaControlBox();
            this.gunaControlBox1 = new Guna.UI.WinForms.GunaControlBox();
            this.comboBoxDistrict = new Guna.UI.WinForms.GunaComboBox();
            this.buttonWork = new Guna.UI.WinForms.GunaButton();
            this.gunaDragControl1 = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.SuspendLayout();
            // 
            // labelDistrict
            // 
            this.labelDistrict.AutoSize = true;
            this.labelDistrict.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDistrict.ForeColor = System.Drawing.Color.White;
            this.labelDistrict.Location = new System.Drawing.Point(107, 53);
            this.labelDistrict.Name = "labelDistrict";
            this.labelDistrict.Size = new System.Drawing.Size(80, 25);
            this.labelDistrict.TabIndex = 1;
            this.labelDistrict.Text = "District:";
            // 
            // gunaControlBox2
            // 
            this.gunaControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaControlBox2.AnimationHoverSpeed = 0.07F;
            this.gunaControlBox2.AnimationSpeed = 0.03F;
            this.gunaControlBox2.ControlBoxType = Guna.UI.WinForms.FormControlBoxType.MinimizeBox;
            this.gunaControlBox2.IconColor = System.Drawing.Color.White;
            this.gunaControlBox2.IconSize = 15F;
            this.gunaControlBox2.Location = new System.Drawing.Point(357, 3);
            this.gunaControlBox2.Name = "gunaControlBox2";
            this.gunaControlBox2.OnHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.gunaControlBox2.OnHoverIconColor = System.Drawing.Color.White;
            this.gunaControlBox2.OnPressedColor = System.Drawing.Color.Black;
            this.gunaControlBox2.Size = new System.Drawing.Size(45, 29);
            this.gunaControlBox2.TabIndex = 23;
            // 
            // gunaControlBox1
            // 
            this.gunaControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaControlBox1.AnimationHoverSpeed = 0.07F;
            this.gunaControlBox1.AnimationSpeed = 0.03F;
            this.gunaControlBox1.IconColor = System.Drawing.Color.White;
            this.gunaControlBox1.IconSize = 15F;
            this.gunaControlBox1.Location = new System.Drawing.Point(397, 3);
            this.gunaControlBox1.Name = "gunaControlBox1";
            this.gunaControlBox1.OnHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.gunaControlBox1.OnHoverIconColor = System.Drawing.Color.White;
            this.gunaControlBox1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaControlBox1.Size = new System.Drawing.Size(45, 29);
            this.gunaControlBox1.TabIndex = 22;
            // 
            // comboBoxDistrict
            // 
            this.comboBoxDistrict.BackColor = System.Drawing.Color.Transparent;
            this.comboBoxDistrict.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.comboBoxDistrict.BorderColor = System.Drawing.Color.Black;
            this.comboBoxDistrict.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxDistrict.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDistrict.FocusedColor = System.Drawing.Color.Empty;
            this.comboBoxDistrict.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboBoxDistrict.ForeColor = System.Drawing.Color.White;
            this.comboBoxDistrict.FormattingEnabled = true;
            this.comboBoxDistrict.Items.AddRange(new object[] {
            "Central",
            "Wetland",
            "Richland",
            "Monroe",
            "Dane"});
            this.comboBoxDistrict.Location = new System.Drawing.Point(204, 53);
            this.comboBoxDistrict.Name = "comboBoxDistrict";
            this.comboBoxDistrict.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.comboBoxDistrict.OnHoverItemForeColor = System.Drawing.Color.White;
            this.comboBoxDistrict.Size = new System.Drawing.Size(121, 31);
            this.comboBoxDistrict.TabIndex = 68;
            this.comboBoxDistrict.SelectedIndexChanged += new System.EventHandler(this.comboBoxDistrict_SelectedIndexChanged);
            // 
            // buttonWork
            // 
            this.buttonWork.AnimationHoverSpeed = 0.07F;
            this.buttonWork.AnimationSpeed = 0.03F;
            this.buttonWork.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(64)))), ((int)(((byte)(71)))));
            this.buttonWork.BorderColor = System.Drawing.Color.Black;
            this.buttonWork.DialogResult = System.Windows.Forms.DialogResult.None;
            this.buttonWork.FocusedColor = System.Drawing.Color.Empty;
            this.buttonWork.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonWork.ForeColor = System.Drawing.Color.White;
            this.buttonWork.Image = null;
            this.buttonWork.ImageSize = new System.Drawing.Size(20, 20);
            this.buttonWork.Location = new System.Drawing.Point(112, 119);
            this.buttonWork.Name = "buttonWork";
            this.buttonWork.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.buttonWork.OnHoverBorderColor = System.Drawing.Color.Black;
            this.buttonWork.OnHoverForeColor = System.Drawing.Color.White;
            this.buttonWork.OnHoverImage = null;
            this.buttonWork.OnPressedColor = System.Drawing.Color.Black;
            this.buttonWork.Size = new System.Drawing.Size(213, 57);
            this.buttonWork.TabIndex = 69;
            this.buttonWork.Text = "Work";
            this.buttonWork.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.buttonWork.Click += new System.EventHandler(this.buttonWork_Click);
            // 
            // gunaDragControl1
            // 
            this.gunaDragControl1.TargetControl = this;
            // 
            // TaxistWorking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(29)))));
            this.ClientSize = new System.Drawing.Size(442, 235);
            this.Controls.Add(this.buttonWork);
            this.Controls.Add(this.comboBoxDistrict);
            this.Controls.Add(this.gunaControlBox2);
            this.Controls.Add(this.gunaControlBox1);
            this.Controls.Add(this.labelDistrict);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TaxistWorking";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TaxistWorking";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelDistrict;
        private Guna.UI.WinForms.GunaControlBox gunaControlBox2;
        private Guna.UI.WinForms.GunaControlBox gunaControlBox1;
        private Guna.UI.WinForms.GunaComboBox comboBoxDistrict;
        private Guna.UI.WinForms.GunaButton buttonWork;
        private Guna.UI.WinForms.GunaDragControl gunaDragControl1;
    }
}