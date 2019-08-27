namespace Thomasdy_EX4
{
    partial class Form1
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
            this.Save = new System.Windows.Forms.Button();
            this.Display = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.IDBox = new System.Windows.Forms.TextBox();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.StartDateBox = new System.Windows.Forms.TextBox();
            this.RateBox = new System.Windows.Forms.TextBox();
            this.HoursBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.OutputId = new System.Windows.Forms.TextBox();
            this.OutputName = new System.Windows.Forms.TextBox();
            this.OutputStartDate = new System.Windows.Forms.TextBox();
            this.OutputRate = new System.Windows.Forms.TextBox();
            this.OutputHours = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(80, 243);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(74, 39);
            this.Save.TabIndex = 0;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Display
            // 
            this.Display.Location = new System.Drawing.Point(469, 243);
            this.Display.Name = "Display";
            this.Display.Size = new System.Drawing.Size(72, 37);
            this.Display.TabIndex = 1;
            this.Display.Text = "Display";
            this.Display.UseVisualStyleBackColor = true;
            this.Display.Click += new System.EventHandler(this.Display_Click);
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(160, 243);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(72, 39);
            this.Clear.TabIndex = 2;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // IDBox
            // 
            this.IDBox.Location = new System.Drawing.Point(79, 27);
            this.IDBox.Name = "IDBox";
            this.IDBox.Size = new System.Drawing.Size(153, 20);
            this.IDBox.TabIndex = 3;
            this.IDBox.TextChanged += new System.EventHandler(this.IDBox_TextChanged);
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(80, 73);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(152, 20);
            this.NameBox.TabIndex = 4;
            this.NameBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // StartDateBox
            // 
            this.StartDateBox.Location = new System.Drawing.Point(79, 114);
            this.StartDateBox.Name = "StartDateBox";
            this.StartDateBox.Size = new System.Drawing.Size(153, 20);
            this.StartDateBox.TabIndex = 5;
            this.StartDateBox.TextChanged += new System.EventHandler(this.StartDateBox_TextChanged);
            // 
            // RateBox
            // 
            this.RateBox.Location = new System.Drawing.Point(79, 154);
            this.RateBox.Name = "RateBox";
            this.RateBox.Size = new System.Drawing.Size(153, 20);
            this.RateBox.TabIndex = 6;
            this.RateBox.TextChanged += new System.EventHandler(this.RateBox_TextChanged);
            // 
            // HoursBox
            // 
            this.HoursBox.Location = new System.Drawing.Point(79, 193);
            this.HoursBox.Name = "HoursBox";
            this.HoursBox.Size = new System.Drawing.Size(153, 20);
            this.HoursBox.TabIndex = 7;
            this.HoursBox.TextChanged += new System.EventHandler(this.HoursBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Id:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Start Date:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Rate:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 200);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Hours: ";
            // 
            // OutputId
            // 
            this.OutputId.Location = new System.Drawing.Point(429, 30);
            this.OutputId.Name = "OutputId";
            this.OutputId.Size = new System.Drawing.Size(146, 20);
            this.OutputId.TabIndex = 14;
            // 
            // OutputName
            // 
            this.OutputName.Location = new System.Drawing.Point(429, 70);
            this.OutputName.Name = "OutputName";
            this.OutputName.Size = new System.Drawing.Size(146, 20);
            this.OutputName.TabIndex = 15;
            // 
            // OutputStartDate
            // 
            this.OutputStartDate.Location = new System.Drawing.Point(428, 110);
            this.OutputStartDate.Name = "OutputStartDate";
            this.OutputStartDate.Size = new System.Drawing.Size(147, 20);
            this.OutputStartDate.TabIndex = 16;
            // 
            // OutputRate
            // 
            this.OutputRate.Location = new System.Drawing.Point(429, 151);
            this.OutputRate.Name = "OutputRate";
            this.OutputRate.Size = new System.Drawing.Size(146, 20);
            this.OutputRate.TabIndex = 17;
            // 
            // OutputHours
            // 
            this.OutputHours.Location = new System.Drawing.Point(429, 193);
            this.OutputHours.Name = "OutputHours";
            this.OutputHours.Size = new System.Drawing.Size(146, 20);
            this.OutputHours.TabIndex = 18;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(32, 340);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 61);
            this.button1.TabIndex = 19;
            this.button1.Text = "Click This if you are an Aurburn Tiger";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Thomasdy_EX4.Properties.Resources.AuburnTigersLogo;
            this.pictureBox2.Location = new System.Drawing.Point(469, 288);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(177, 173);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 22;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = global::Thomasdy_EX4.Properties.Resources.Alabama;
            this.pictureBox1.Location = new System.Drawing.Point(221, 288);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(187, 173);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 473);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.OutputHours);
            this.Controls.Add(this.OutputRate);
            this.Controls.Add(this.OutputStartDate);
            this.Controls.Add(this.OutputName);
            this.Controls.Add(this.OutputId);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.HoursBox);
            this.Controls.Add(this.RateBox);
            this.Controls.Add(this.StartDateBox);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.IDBox);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.Display);
            this.Controls.Add(this.Save);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button Display;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.TextBox IDBox;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.TextBox StartDateBox;
        private System.Windows.Forms.TextBox RateBox;
        private System.Windows.Forms.TextBox HoursBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox OutputId;
        private System.Windows.Forms.TextBox OutputName;
        private System.Windows.Forms.TextBox OutputStartDate;
        private System.Windows.Forms.TextBox OutputRate;
        private System.Windows.Forms.TextBox OutputHours;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

