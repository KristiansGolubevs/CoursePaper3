namespace paper3
{
    partial class PartForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PartForm));
            comboBox1 = new ComboBox();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            comboBox2 = new ComboBox();
            textBox3 = new TextBox();
            label9 = new Label();
            textBox4 = new TextBox();
            label5 = new Label();
            label6 = new Label();
            button2 = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(53, 78);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(212, 31);
            comboBox1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.HotTrack;
            label2.Location = new Point(12, 9);
            label2.Name = "label2";
            label2.Size = new Size(40, 19);
            label2.TabIndex = 12;
            label2.Text = "Back";
            label2.Click += label2_Click_1;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 354);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(1260, 323);
            dataGridView1.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(53, 56);
            label1.Name = "label1";
            label1.Size = new Size(71, 19);
            label1.TabIndex = 50;
            label1.Text = "VIN Code";
            // 
            // textBox1
            // 
            textBox1.Enabled = false;
            textBox1.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            textBox1.Location = new Point(329, 78);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(196, 31);
            textBox1.TabIndex = 51;
            // 
            // textBox2
            // 
            textBox2.Enabled = false;
            textBox2.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            textBox2.Location = new Point(581, 78);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(196, 31);
            textBox2.TabIndex = 52;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(329, 56);
            label3.Name = "label3";
            label3.Size = new Size(47, 19);
            label3.TabIndex = 53;
            label3.Text = "Make";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(581, 56);
            label4.Name = "label4";
            label4.Size = new Size(53, 19);
            label4.TabIndex = 54;
            label4.Text = "Model";
            // 
            // comboBox2
            // 
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "", "Spark Plugs", "Pistons", "Rings", "Bearings", "Valves", "Gaskets", "Timing Belts/Chains", "Camshafts", "Crankshafts", "Engine Mounts", "Engine Sensors", "Transmission Fluid", "Clutch Kits", "Transmission Mounts", "Shifters", "Gearboxes", "Driveshafts", "Differentials", "Shocks", "Struts", "Coil Springs", "Leaf Springs", "Control Arms", "Ball Joints", "Tie Rod Ends", "Sway Bars", "Stabilizer Links", "Wheel Bearings", "Strut Mounts", "Air Suspension Kits", "Brake Pads", "Brake Rotors", "Brake Drums", "Brake Calipers", "Brake Lines", "Brake Fluid", "Master Cylinders", "Brake Boosters", "Power Steering Fluid", "Power Steering Pumps", "Steering Racks", "Steering Gearboxes", "Steering Linkages", "Steering Columns", "Pitman Arms", "Radiators", "Thermostats", "Water Pumps", "Hoses", "Clamps", "Coolant", "Radiator Fans", "Fan Clutches", "Overflow Tanks", "Mufflers", "Catalytic Converters", "Exhaust Pipes", "Exhaust Manifolds", "Resonators", "Exhaust Gaskets", "Exhaust Hangers", "Fuel Pumps", "Fuel Filters", "Fuel Injectors", "Carburetors", "Throttle Bodies", "Fuel Lines", "Gas Caps", "Batteries", "Alternators", "Starters", "Ignition Coils", "Sensors", "Fuses", "Relays", "Switches", "Wiring Harnesses", "Mirrors", "Headlights", "Taillights", "Turn Signals", "Door Handles", "Window Regulators", "Weatherstripping", "Body Panels", "Bumpers", "Grilles", "Emblems" });
            comboBox2.Location = new Point(842, 78);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(212, 31);
            comboBox2.TabIndex = 55;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            textBox3.Location = new Point(53, 169);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(212, 35);
            textBox3.TabIndex = 57;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(53, 147);
            label9.Name = "label9";
            label9.Size = new Size(69, 19);
            label9.TabIndex = 56;
            label9.Text = "Quantity";
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            textBox4.Location = new Point(329, 169);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(193, 35);
            textBox4.TabIndex = 59;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(329, 147);
            label5.Name = "label5";
            label5.Size = new Size(76, 19);
            label5.TabIndex = 58;
            label5.Text = "Unit price";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(842, 56);
            label6.Name = "label6";
            label6.Size = new Size(44, 19);
            label6.TabIndex = 60;
            label6.Text = "Parts";
            // 
            // button2
            // 
            button2.BackColor = SystemColors.HotTrack;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = SystemColors.ButtonFace;
            button2.Location = new Point(957, 171);
            button2.Name = "button2";
            button2.Size = new Size(97, 33);
            button2.TabIndex = 61;
            button2.Text = "Save";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.HotTrack;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = SystemColors.ButtonFace;
            button1.Location = new Point(581, 171);
            button1.Name = "button1";
            button1.Size = new Size(91, 33);
            button1.TabIndex = 62;
            button1.Text = "Refresh";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // PartForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1284, 689);
            Controls.Add(button1);
            Controls.Add(button2);
            Controls.Add(label6);
            Controls.Add(textBox4);
            Controls.Add(label5);
            Controls.Add(textBox3);
            Controls.Add(label9);
            Controls.Add(comboBox2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(label2);
            Controls.Add(comboBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "PartForm";
            Text = "  Parts";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private Label label2;
        private DataGridView dataGridView1;
        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label3;
        private Label label4;
        private ComboBox comboBox2;
        private TextBox textBox3;
        private Label label9;
        private TextBox textBox4;
        private Label label5;
        private Label label6;
        private Button button2;
        private Button button1;
    }
}