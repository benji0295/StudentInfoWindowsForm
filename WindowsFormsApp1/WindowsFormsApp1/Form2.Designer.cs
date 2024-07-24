namespace WindowsFormsApp1
{
    partial class Form2
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
            this.studentIDLabel = new System.Windows.Forms.Label();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.addressLabel = new System.Windows.Forms.Label();
            this.admissionMonthLabel = new System.Windows.Forms.Label();
            this.gradeLabel = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.monthComboBox = new System.Windows.Forms.ComboBox();
            this.studentIDBox = new System.Windows.Forms.TextBox();
            this.firstNameBox = new System.Windows.Forms.TextBox();
            this.lastNameBox = new System.Windows.Forms.TextBox();
            this.addressBox = new System.Windows.Forms.TextBox();
            this.gradeComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // studentIDLabel
            // 
            this.studentIDLabel.AutoSize = true;
            this.studentIDLabel.Location = new System.Drawing.Point(256, 54);
            this.studentIDLabel.Name = "studentIDLabel";
            this.studentIDLabel.Size = new System.Drawing.Size(112, 25);
            this.studentIDLabel.TabIndex = 0;
            this.studentIDLabel.Text = "Student ID";
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(256, 109);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(116, 25);
            this.firstNameLabel.TabIndex = 1;
            this.firstNameLabel.Text = "First Name";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(256, 166);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(115, 25);
            this.lastNameLabel.TabIndex = 2;
            this.lastNameLabel.Text = "Last Name";
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Location = new System.Drawing.Point(280, 219);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(91, 25);
            this.addressLabel.TabIndex = 3;
            this.addressLabel.Text = "Address";
            // 
            // admissionMonthLabel
            // 
            this.admissionMonthLabel.AutoSize = true;
            this.admissionMonthLabel.Location = new System.Drawing.Point(194, 275);
            this.admissionMonthLabel.Name = "admissionMonthLabel";
            this.admissionMonthLabel.Size = new System.Drawing.Size(177, 25);
            this.admissionMonthLabel.TabIndex = 4;
            this.admissionMonthLabel.Text = "Admission Month";
            // 
            // gradeLabel
            // 
            this.gradeLabel.AutoSize = true;
            this.gradeLabel.Location = new System.Drawing.Point(300, 326);
            this.gradeLabel.Name = "gradeLabel";
            this.gradeLabel.Size = new System.Drawing.Size(71, 25);
            this.gradeLabel.TabIndex = 5;
            this.gradeLabel.Text = "Grade";
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(241, 377);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(131, 45);
            this.addButton.TabIndex = 6;
            this.addButton.Text = "ADD";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(419, 377);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(131, 45);
            this.cancelButton.TabIndex = 7;
            this.cancelButton.Text = "CANCEL";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // monthComboBox
            // 
            this.monthComboBox.FormattingEnabled = true;
            this.monthComboBox.Location = new System.Drawing.Point(377, 272);
            this.monthComboBox.Name = "monthComboBox";
            this.monthComboBox.Size = new System.Drawing.Size(121, 33);
            this.monthComboBox.TabIndex = 8;
            // 
            // studentIDBox
            // 
            this.studentIDBox.Location = new System.Drawing.Point(377, 48);
            this.studentIDBox.Name = "studentIDBox";
            this.studentIDBox.Size = new System.Drawing.Size(229, 31);
            this.studentIDBox.TabIndex = 9;
            // 
            // firstNameBox
            // 
            this.firstNameBox.Location = new System.Drawing.Point(377, 103);
            this.firstNameBox.Name = "firstNameBox";
            this.firstNameBox.Size = new System.Drawing.Size(229, 31);
            this.firstNameBox.TabIndex = 10;
            // 
            // lastNameBox
            // 
            this.lastNameBox.Location = new System.Drawing.Point(377, 160);
            this.lastNameBox.Name = "lastNameBox";
            this.lastNameBox.Size = new System.Drawing.Size(229, 31);
            this.lastNameBox.TabIndex = 11;
            // 
            // addressBox
            // 
            this.addressBox.Location = new System.Drawing.Point(377, 213);
            this.addressBox.Name = "addressBox";
            this.addressBox.Size = new System.Drawing.Size(229, 31);
            this.addressBox.TabIndex = 12;
            // 
            // gradeComboBox
            // 
            this.gradeComboBox.FormattingEnabled = true;
            this.gradeComboBox.Location = new System.Drawing.Point(377, 323);
            this.gradeComboBox.Name = "gradeComboBox";
            this.gradeComboBox.Size = new System.Drawing.Size(121, 33);
            this.gradeComboBox.TabIndex = 13;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gradeComboBox);
            this.Controls.Add(this.addressBox);
            this.Controls.Add(this.lastNameBox);
            this.Controls.Add(this.firstNameBox);
            this.Controls.Add(this.studentIDBox);
            this.Controls.Add(this.monthComboBox);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.gradeLabel);
            this.Controls.Add(this.admissionMonthLabel);
            this.Controls.Add(this.addressLabel);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.firstNameLabel);
            this.Controls.Add(this.studentIDLabel);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label studentIDLabel;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.Label admissionMonthLabel;
        private System.Windows.Forms.Label gradeLabel;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.ComboBox monthComboBox;
        private System.Windows.Forms.TextBox studentIDBox;
        private System.Windows.Forms.TextBox firstNameBox;
        private System.Windows.Forms.TextBox lastNameBox;
        private System.Windows.Forms.TextBox addressBox;
        private System.Windows.Forms.ComboBox gradeComboBox;
    }
}