namespace TaxiService
{
    partial class RegistrationTaxist
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
            this.buttonRegister = new System.Windows.Forms.Button();
            this.textBoxConfirmPass = new System.Windows.Forms.TextBox();
            this.labelConfirmPassword = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.textBoxNickname = new System.Windows.Forms.TextBox();
            this.labelNickname = new System.Windows.Forms.Label();
            this.labelBirthday = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.labelSurname = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxCarNumber = new System.Windows.Forms.TextBox();
            this.labelCarNumber = new System.Windows.Forms.Label();
            this.textBoxCarModel = new System.Windows.Forms.TextBox();
            this.labelCarModel = new System.Windows.Forms.Label();
            this.textBoxCarName = new System.Windows.Forms.TextBox();
            this.labelCarName = new System.Windows.Forms.Label();
            this.labelChoiceCar = new System.Windows.Forms.Label();
            this.comboBoxCarsType = new System.Windows.Forms.ComboBox();
            this.toolTipRegister = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // buttonRegister
            // 
            this.buttonRegister.BackColor = System.Drawing.Color.Lime;
            this.buttonRegister.Font = new System.Drawing.Font("Jost Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRegister.Location = new System.Drawing.Point(16, 327);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Size = new System.Drawing.Size(706, 46);
            this.buttonRegister.TabIndex = 31;
            this.buttonRegister.Text = "Register";
            this.toolTipRegister.SetToolTip(this.buttonRegister, "toolTipRegister");
            this.buttonRegister.UseVisualStyleBackColor = false;
            this.buttonRegister.Click += new System.EventHandler(this.buttonRegister_Click);
            // 
            // textBoxConfirmPass
            // 
            this.textBoxConfirmPass.Font = new System.Drawing.Font("Jost Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxConfirmPass.Location = new System.Drawing.Point(242, 266);
            this.textBoxConfirmPass.Name = "textBoxConfirmPass";
            this.textBoxConfirmPass.Size = new System.Drawing.Size(173, 32);
            this.textBoxConfirmPass.TabIndex = 30;
            // 
            // labelConfirmPassword
            // 
            this.labelConfirmPassword.AutoSize = true;
            this.labelConfirmPassword.Font = new System.Drawing.Font("Jost Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelConfirmPassword.Location = new System.Drawing.Point(12, 274);
            this.labelConfirmPassword.Name = "labelConfirmPassword";
            this.labelConfirmPassword.Size = new System.Drawing.Size(175, 24);
            this.labelConfirmPassword.TabIndex = 29;
            this.labelConfirmPassword.Text = "Confirm password: ";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Font = new System.Drawing.Font("Jost Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPassword.Location = new System.Drawing.Point(242, 226);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(173, 32);
            this.textBoxPassword.TabIndex = 28;
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Jost Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPassword.Location = new System.Drawing.Point(12, 234);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(188, 24);
            this.labelPassword.TabIndex = 27;
            this.labelPassword.Text = "Enter your password:";
            // 
            // textBoxNickname
            // 
            this.textBoxNickname.Font = new System.Drawing.Font("Jost Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxNickname.Location = new System.Drawing.Point(242, 189);
            this.textBoxNickname.Name = "textBoxNickname";
            this.textBoxNickname.Size = new System.Drawing.Size(173, 32);
            this.textBoxNickname.TabIndex = 26;
            // 
            // labelNickname
            // 
            this.labelNickname.AutoSize = true;
            this.labelNickname.Font = new System.Drawing.Font("Jost Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNickname.Location = new System.Drawing.Point(12, 197);
            this.labelNickname.Name = "labelNickname";
            this.labelNickname.Size = new System.Drawing.Size(194, 24);
            this.labelNickname.TabIndex = 25;
            this.labelNickname.Text = "Enter your nickname: ";
            // 
            // labelBirthday
            // 
            this.labelBirthday.AutoSize = true;
            this.labelBirthday.Font = new System.Drawing.Font("Jost Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelBirthday.Location = new System.Drawing.Point(166, 115);
            this.labelBirthday.Name = "labelBirthday";
            this.labelBirthday.Size = new System.Drawing.Size(123, 24);
            this.labelBirthday.TabIndex = 24;
            this.labelBirthday.Text = "Your birthday";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Jost Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePicker1.Location = new System.Drawing.Point(12, 142);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(360, 32);
            this.dateTimePicker1.TabIndex = 23;
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.Font = new System.Drawing.Font("Jost Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSurname.Location = new System.Drawing.Point(242, 79);
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.Size = new System.Drawing.Size(173, 32);
            this.textBoxSurname.TabIndex = 22;
            // 
            // labelSurname
            // 
            this.labelSurname.AutoSize = true;
            this.labelSurname.Font = new System.Drawing.Font("Jost Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSurname.Location = new System.Drawing.Point(12, 87);
            this.labelSurname.Name = "labelSurname";
            this.labelSurname.Size = new System.Drawing.Size(185, 24);
            this.labelSurname.TabIndex = 21;
            this.labelSurname.Text = "Enter your surname: ";
            // 
            // textBoxName
            // 
            this.textBoxName.Font = new System.Drawing.Font("Jost Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxName.Location = new System.Drawing.Point(242, 42);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(173, 32);
            this.textBoxName.TabIndex = 20;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Jost Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelName.Location = new System.Drawing.Point(12, 50);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(160, 24);
            this.labelName.TabIndex = 19;
            this.labelName.Text = "Enter your name: ";
            // 
            // textBoxCarNumber
            // 
            this.textBoxCarNumber.Font = new System.Drawing.Font("Jost Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxCarNumber.Location = new System.Drawing.Point(592, 258);
            this.textBoxCarNumber.Name = "textBoxCarNumber";
            this.textBoxCarNumber.Size = new System.Drawing.Size(125, 32);
            this.textBoxCarNumber.TabIndex = 39;
            // 
            // labelCarNumber
            // 
            this.labelCarNumber.AutoSize = true;
            this.labelCarNumber.Font = new System.Drawing.Font("Jost Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCarNumber.Location = new System.Drawing.Point(438, 266);
            this.labelCarNumber.Name = "labelCarNumber";
            this.labelCarNumber.Size = new System.Drawing.Size(115, 24);
            this.labelCarNumber.TabIndex = 38;
            this.labelCarNumber.Text = "Car number:";
            // 
            // textBoxCarModel
            // 
            this.textBoxCarModel.Font = new System.Drawing.Font("Jost Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxCarModel.Location = new System.Drawing.Point(592, 218);
            this.textBoxCarModel.Name = "textBoxCarModel";
            this.textBoxCarModel.Size = new System.Drawing.Size(125, 32);
            this.textBoxCarModel.TabIndex = 35;
            // 
            // labelCarModel
            // 
            this.labelCarModel.AutoSize = true;
            this.labelCarModel.Font = new System.Drawing.Font("Jost Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCarModel.Location = new System.Drawing.Point(438, 226);
            this.labelCarModel.Name = "labelCarModel";
            this.labelCarModel.Size = new System.Drawing.Size(110, 24);
            this.labelCarModel.TabIndex = 34;
            this.labelCarModel.Text = "Car model: ";
            // 
            // textBoxCarName
            // 
            this.textBoxCarName.Font = new System.Drawing.Font("Jost Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxCarName.Location = new System.Drawing.Point(592, 181);
            this.textBoxCarName.Name = "textBoxCarName";
            this.textBoxCarName.Size = new System.Drawing.Size(125, 32);
            this.textBoxCarName.TabIndex = 33;
            // 
            // labelCarName
            // 
            this.labelCarName.AutoSize = true;
            this.labelCarName.Font = new System.Drawing.Font("Jost Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCarName.Location = new System.Drawing.Point(438, 189);
            this.labelCarName.Name = "labelCarName";
            this.labelCarName.Size = new System.Drawing.Size(103, 24);
            this.labelCarName.TabIndex = 32;
            this.labelCarName.Text = "Car name: ";
            // 
            // labelChoiceCar
            // 
            this.labelChoiceCar.AutoSize = true;
            this.labelChoiceCar.Font = new System.Drawing.Font("Jost Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelChoiceCar.Location = new System.Drawing.Point(438, 84);
            this.labelChoiceCar.Name = "labelChoiceCar";
            this.labelChoiceCar.Size = new System.Drawing.Size(107, 24);
            this.labelChoiceCar.TabIndex = 43;
            this.labelChoiceCar.Text = "Choice car:";
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
            this.comboBoxCarsType.Location = new System.Drawing.Point(592, 81);
            this.comboBoxCarsType.Name = "comboBoxCarsType";
            this.comboBoxCarsType.Size = new System.Drawing.Size(121, 32);
            this.comboBoxCarsType.TabIndex = 42;
            this.comboBoxCarsType.SelectedIndexChanged += new System.EventHandler(this.comboBoxCarsType_SelectedIndexChanged);
            // 
            // toolTipRegister
            // 
            this.toolTipRegister.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTipRegister.ToolTipTitle = "Enter all fields before press this";
            // 
            // RegistrationTaxist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(760, 398);
            this.Controls.Add(this.labelChoiceCar);
            this.Controls.Add(this.comboBoxCarsType);
            this.Controls.Add(this.textBoxCarNumber);
            this.Controls.Add(this.labelCarNumber);
            this.Controls.Add(this.textBoxCarModel);
            this.Controls.Add(this.labelCarModel);
            this.Controls.Add(this.textBoxCarName);
            this.Controls.Add(this.labelCarName);
            this.Controls.Add(this.buttonRegister);
            this.Controls.Add(this.textBoxConfirmPass);
            this.Controls.Add(this.labelConfirmPassword);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.textBoxNickname);
            this.Controls.Add(this.labelNickname);
            this.Controls.Add(this.labelBirthday);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBoxSurname);
            this.Controls.Add(this.labelSurname);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelName);
            this.Name = "RegistrationTaxist";
            this.Text = "RegistrationTaxist";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonRegister;
        private System.Windows.Forms.TextBox textBoxConfirmPass;
        private System.Windows.Forms.Label labelConfirmPassword;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox textBoxNickname;
        private System.Windows.Forms.Label labelNickname;
        private System.Windows.Forms.Label labelBirthday;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBoxSurname;
        private System.Windows.Forms.Label labelSurname;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxCarNumber;
        private System.Windows.Forms.Label labelCarNumber;
        private System.Windows.Forms.TextBox textBoxCarModel;
        private System.Windows.Forms.Label labelCarModel;
        private System.Windows.Forms.TextBox textBoxCarName;
        private System.Windows.Forms.Label labelCarName;
        private System.Windows.Forms.Label labelChoiceCar;
        private System.Windows.Forms.ComboBox comboBoxCarsType;
        private System.Windows.Forms.ToolTip toolTipRegister;
    }
}