namespace paper3
{
    partial class EditForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditForm));
            button2 = new Button();
            comboBox1 = new ComboBox();
            label3 = new Label();
            textBox2 = new TextBox();
            label4 = new Label();
            comboBox2 = new ComboBox();
            label5 = new Label();
            comboBox3 = new ComboBox();
            label6 = new Label();
            comboBox4 = new ComboBox();
            label7 = new Label();
            comboBox5 = new ComboBox();
            label8 = new Label();
            textBox3 = new TextBox();
            label9 = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // button2
            // 
            button2.BackColor = SystemColors.HotTrack;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = SystemColors.ButtonFace;
            button2.Location = new Point(208, 478);
            button2.Name = "button2";
            button2.Size = new Size(193, 33);
            button2.TabIndex = 34;
            button2.Text = "Save";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "", "Acura", "Afeela", "Alfa Romeo", "Audi", "BMW", "Bentley", "Buick", "Cadillac", "Chevrolet", "Chrysler", "Dodge", "Fiat", "Fisker", "Ford", "GMC", "Genesis", "Honda", "Hyundai", "Infiniti", "Jaguar", "Jeep", "Kia", "Land Rover", "Lexus", "Lincoln", "Lotus", "Lucid", "Maserati", "Mazda", "Mercedes-Benz", "Merucry", "Mini", "Mitsubishi", "Nissan", "Polestar", "Pontiac", "Porsche", "Ram", "Rolce-Royce", "Saab", "Saturn", "Smart", "Subaru", "Suzuki", "Tesla", "Toyota", "Volkswagen", "Volvo" });
            comboBox1.Location = new Point(347, 70);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(194, 33);
            comboBox1.TabIndex = 36;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(347, 48);
            label3.Name = "label3";
            label3.Size = new Size(47, 19);
            label3.TabIndex = 35;
            label3.Text = "Make";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            textBox2.Location = new Point(65, 146);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(193, 33);
            textBox2.TabIndex = 38;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(65, 124);
            label4.Name = "label4";
            label4.Size = new Size(53, 19);
            label4.TabIndex = 37;
            label4.Text = "Model";
            // 
            // comboBox2
            // 
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "", "1970", "1971", "1972", "1973", "1974", "1975", "1976", "1977", "1978", "1979", "1980", "1981", "1982", "1983", "1984", "1985", "1986", "1987", "1988", "1989", "1990", "1991", "1992", "1993", "1994", "1995", "1996", "1997", "1998", "1999", "2000", "2001", "2002", "2003", "2004", "2005", "2006", "2007", "2008", "2009", "2010", "2011", "2012", "2013", "2014", "2015", "2016", "2017", "2018", "2019", "2020", "2021", "2022", "2023" });
            comboBox2.Location = new Point(348, 146);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(194, 33);
            comboBox2.TabIndex = 40;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(348, 124);
            label5.Name = "label5";
            label5.Size = new Size(38, 19);
            label5.TabIndex = 39;
            label5.Text = "Year";
            // 
            // comboBox3
            // 
            comboBox3.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "", "Sedan", "Coupe", "SUV", "Crossover", "Convertible", "Hatchback", "Pickup Truck", "Minivan", "Station Wagon", "Sports Car" });
            comboBox3.Location = new Point(64, 230);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(194, 33);
            comboBox3.TabIndex = 42;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(64, 208);
            label6.Name = "label6";
            label6.Size = new Size(81, 19);
            label6.TabIndex = 41;
            label6.Text = "Body Type";
            // 
            // comboBox4
            // 
            comboBox4.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox4.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox4.FormattingEnabled = true;
            comboBox4.Items.AddRange(new object[] { "", "Gasoline", "Diesel", "Electric", "Hybrid", "Natural Gas", "Propane/LPG", "Biofuel", "Hydrogen", "Ethanol" });
            comboBox4.Location = new Point(347, 230);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(194, 33);
            comboBox4.TabIndex = 44;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(347, 208);
            label7.Name = "label7";
            label7.Size = new Size(74, 19);
            label7.TabIndex = 43;
            label7.Text = "Fuel Type";
            // 
            // comboBox5
            // 
            comboBox5.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox5.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox5.FormattingEnabled = true;
            comboBox5.Items.AddRange(new object[] { "", "Automatic", "Manual", "Semi-Automatic" });
            comboBox5.Location = new Point(64, 320);
            comboBox5.Name = "comboBox5";
            comboBox5.Size = new Size(194, 33);
            comboBox5.TabIndex = 46;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(64, 298);
            label8.Name = "label8";
            label8.Size = new Size(96, 19);
            label8.TabIndex = 45;
            label8.Text = "Transmission";
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            textBox3.Location = new Point(348, 320);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(193, 35);
            textBox3.TabIndex = 48;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(348, 298);
            label9.Name = "label9";
            label9.Size = new Size(43, 19);
            label9.TabIndex = 47;
            label9.Text = "Price";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            textBox1.Location = new Point(65, 70);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(193, 31);
            textBox1.TabIndex = 50;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(65, 48);
            label1.Name = "label1";
            label1.Size = new Size(71, 19);
            label1.TabIndex = 49;
            label1.Text = "VIN Code";
            // 
            // EditForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(625, 580);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(textBox3);
            Controls.Add(label9);
            Controls.Add(comboBox5);
            Controls.Add(label8);
            Controls.Add(comboBox4);
            Controls.Add(label7);
            Controls.Add(comboBox3);
            Controls.Add(label6);
            Controls.Add(comboBox2);
            Controls.Add(label5);
            Controls.Add(textBox2);
            Controls.Add(label4);
            Controls.Add(comboBox1);
            Controls.Add(label3);
            Controls.Add(button2);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "EditForm";
            Text = "Edit";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private ComboBox comboBox1;
        private Label label3;
        private TextBox textBox2;
        private Label label4;
        private ComboBox comboBox2;
        private Label label5;
        private ComboBox comboBox3;
        private Label label6;
        private ComboBox comboBox4;
        private Label label7;
        private ComboBox comboBox5;
        private Label label8;
        private TextBox textBox3;
        private Label label9;
        private TextBox textBox1;
        private Label label1;
    }
}