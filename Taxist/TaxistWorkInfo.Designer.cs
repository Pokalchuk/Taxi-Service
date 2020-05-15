namespace TaxiService
{
    partial class TaxistWorkInfo
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
            this.labelName = new System.Windows.Forms.Label();
            this.labelStreet = new System.Windows.Forms.Label();
            this.labelStreetChange = new System.Windows.Forms.Label();
            this.labelNameChange = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(121, 57);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(65, 24);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Name:";
            // 
            // labelStreet
            // 
            this.labelStreet.AutoSize = true;
            this.labelStreet.Location = new System.Drawing.Point(121, 97);
            this.labelStreet.Name = "labelStreet";
            this.labelStreet.Size = new System.Drawing.Size(60, 24);
            this.labelStreet.TabIndex = 1;
            this.labelStreet.Text = "Street";
            // 
            // labelStreetChange
            // 
            this.labelStreetChange.AutoSize = true;
            this.labelStreetChange.Location = new System.Drawing.Point(209, 97);
            this.labelStreetChange.Name = "labelStreetChange";
            this.labelStreetChange.Size = new System.Drawing.Size(57, 24);
            this.labelStreetChange.TabIndex = 3;
            this.labelStreetChange.Text = "street";
            // 
            // labelNameChange
            // 
            this.labelNameChange.AutoSize = true;
            this.labelNameChange.Location = new System.Drawing.Point(209, 57);
            this.labelNameChange.Name = "labelNameChange";
            this.labelNameChange.Size = new System.Drawing.Size(55, 24);
            this.labelNameChange.TabIndex = 2;
            this.labelNameChange.Text = "name";
            // 
            // TaxistWorkInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(408, 206);
            this.Controls.Add(this.labelStreetChange);
            this.Controls.Add(this.labelNameChange);
            this.Controls.Add(this.labelStreet);
            this.Controls.Add(this.labelName);
            this.Font = new System.Drawing.Font("Jost Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "TaxistWorkInfo";
            this.Text = "TaxistWorkInfo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelStreet;
        private System.Windows.Forms.Label labelStreetChange;
        private System.Windows.Forms.Label labelNameChange;
    }
}