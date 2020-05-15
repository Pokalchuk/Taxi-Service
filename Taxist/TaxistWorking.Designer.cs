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
            this.comboBoxDistrict = new System.Windows.Forms.ComboBox();
            this.labelDistrict = new System.Windows.Forms.Label();
            this.buttonWork = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxDistrict
            // 
            this.comboBoxDistrict.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDistrict.Font = new System.Drawing.Font("Jost Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxDistrict.FormattingEnabled = true;
            this.comboBoxDistrict.Items.AddRange(new object[] {
            "Central",
            "Wetland",
            "Richland",
            "Monroe",
            "Dane"});
            this.comboBoxDistrict.Location = new System.Drawing.Point(204, 50);
            this.comboBoxDistrict.Name = "comboBoxDistrict";
            this.comboBoxDistrict.Size = new System.Drawing.Size(121, 32);
            this.comboBoxDistrict.TabIndex = 0;
            this.comboBoxDistrict.SelectedIndexChanged += new System.EventHandler(this.comboBoxDistrict_SelectedIndexChanged);
            // 
            // labelDistrict
            // 
            this.labelDistrict.AutoSize = true;
            this.labelDistrict.Font = new System.Drawing.Font("Jost Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDistrict.Location = new System.Drawing.Point(107, 53);
            this.labelDistrict.Name = "labelDistrict";
            this.labelDistrict.Size = new System.Drawing.Size(77, 24);
            this.labelDistrict.TabIndex = 1;
            this.labelDistrict.Text = "District:";
            // 
            // buttonWork
            // 
            this.buttonWork.BackColor = System.Drawing.Color.Lime;
            this.buttonWork.Font = new System.Drawing.Font("Jost Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonWork.Location = new System.Drawing.Point(111, 118);
            this.buttonWork.Name = "buttonWork";
            this.buttonWork.Size = new System.Drawing.Size(214, 54);
            this.buttonWork.TabIndex = 2;
            this.buttonWork.Text = "Work";
            this.buttonWork.UseVisualStyleBackColor = false;
            this.buttonWork.Click += new System.EventHandler(this.buttonWork_Click);
            // 
            // TaxistWorking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(442, 235);
            this.Controls.Add(this.buttonWork);
            this.Controls.Add(this.labelDistrict);
            this.Controls.Add(this.comboBoxDistrict);
            this.Name = "TaxistWorking";
            this.Text = "TaxistWorking";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxDistrict;
        private System.Windows.Forms.Label labelDistrict;
        private System.Windows.Forms.Button buttonWork;
    }
}