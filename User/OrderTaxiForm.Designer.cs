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
            this.comboBoxCarsType = new System.Windows.Forms.ComboBox();
            this.labelChoiceCar = new System.Windows.Forms.Label();
            this.labelCurrentAdress = new System.Windows.Forms.Label();
            this.textBoxCurrentAdress = new System.Windows.Forms.TextBox();
            this.textBoxFinalAddress = new System.Windows.Forms.TextBox();
            this.labelFinalAdress = new System.Windows.Forms.Label();
            this.buttonFindCar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxCarsType
            // 
            this.comboBoxCarsType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCarsType.Font = new System.Drawing.Font("Jost Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxCarsType.FormattingEnabled = true;
            this.comboBoxCarsType.Items.AddRange(new object[] {
            "Econom",
            "Luxury",
            "Truck"});
            this.comboBoxCarsType.Location = new System.Drawing.Point(199, 42);
            this.comboBoxCarsType.Name = "comboBoxCarsType";
            this.comboBoxCarsType.Size = new System.Drawing.Size(251, 32);
            this.comboBoxCarsType.TabIndex = 0;
            // 
            // labelChoiceCar
            // 
            this.labelChoiceCar.AutoSize = true;
            this.labelChoiceCar.Font = new System.Drawing.Font("Jost Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelChoiceCar.Location = new System.Drawing.Point(28, 50);
            this.labelChoiceCar.Name = "labelChoiceCar";
            this.labelChoiceCar.Size = new System.Drawing.Size(107, 24);
            this.labelChoiceCar.TabIndex = 1;
            this.labelChoiceCar.Text = "Choice car:";
            // 
            // labelCurrentAdress
            // 
            this.labelCurrentAdress.AutoSize = true;
            this.labelCurrentAdress.Font = new System.Drawing.Font("Jost Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCurrentAdress.Location = new System.Drawing.Point(28, 153);
            this.labelCurrentAdress.Name = "labelCurrentAdress";
            this.labelCurrentAdress.Size = new System.Drawing.Size(156, 24);
            this.labelCurrentAdress.TabIndex = 2;
            this.labelCurrentAdress.Text = "Current address: ";
            // 
            // textBoxCurrentAdress
            // 
            this.textBoxCurrentAdress.Font = new System.Drawing.Font("Jost Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxCurrentAdress.Location = new System.Drawing.Point(199, 150);
            this.textBoxCurrentAdress.Name = "textBoxCurrentAdress";
            this.textBoxCurrentAdress.Size = new System.Drawing.Size(251, 32);
            this.textBoxCurrentAdress.TabIndex = 3;
            // 
            // textBoxFinalAddress
            // 
            this.textBoxFinalAddress.Font = new System.Drawing.Font("Jost Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxFinalAddress.Location = new System.Drawing.Point(199, 186);
            this.textBoxFinalAddress.Name = "textBoxFinalAddress";
            this.textBoxFinalAddress.Size = new System.Drawing.Size(251, 32);
            this.textBoxFinalAddress.TabIndex = 5;
            // 
            // labelFinalAdress
            // 
            this.labelFinalAdress.AutoSize = true;
            this.labelFinalAdress.Font = new System.Drawing.Font("Jost Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFinalAdress.Location = new System.Drawing.Point(28, 192);
            this.labelFinalAdress.Name = "labelFinalAdress";
            this.labelFinalAdress.Size = new System.Drawing.Size(134, 24);
            this.labelFinalAdress.TabIndex = 4;
            this.labelFinalAdress.Text = "Final address: ";
            // 
            // buttonFindCar
            // 
            this.buttonFindCar.BackColor = System.Drawing.Color.Lime;
            this.buttonFindCar.Font = new System.Drawing.Font("Jost Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonFindCar.Location = new System.Drawing.Point(32, 243);
            this.buttonFindCar.Name = "buttonFindCar";
            this.buttonFindCar.Size = new System.Drawing.Size(130, 42);
            this.buttonFindCar.TabIndex = 6;
            this.buttonFindCar.Text = "Find";
            this.buttonFindCar.UseVisualStyleBackColor = false;
            this.buttonFindCar.Click += new System.EventHandler(this.buttonFindCar_Click);
            // 
            // OrderTaxiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(461, 299);
            this.Controls.Add(this.buttonFindCar);
            this.Controls.Add(this.textBoxFinalAddress);
            this.Controls.Add(this.labelFinalAdress);
            this.Controls.Add(this.textBoxCurrentAdress);
            this.Controls.Add(this.labelCurrentAdress);
            this.Controls.Add(this.labelChoiceCar);
            this.Controls.Add(this.comboBoxCarsType);
            this.Name = "OrderTaxiForm";
            this.Text = "Order form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxCarsType;
        private System.Windows.Forms.Label labelChoiceCar;
        private System.Windows.Forms.Label labelCurrentAdress;
        private System.Windows.Forms.TextBox textBoxCurrentAdress;
        private System.Windows.Forms.TextBox textBoxFinalAddress;
        private System.Windows.Forms.Label labelFinalAdress;
        private System.Windows.Forms.Button buttonFindCar;
    }
}