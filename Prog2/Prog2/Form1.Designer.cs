namespace Prog2
{
    partial class Program2
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
            this.classStanding = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.Label();
            this.initialBox = new System.Windows.Forms.TextBox();
            this.dateBox = new System.Windows.Forms.TextBox();
            this.timeBox = new System.Windows.Forms.TextBox();
            this.checkButton = new System.Windows.Forms.Button();
            this.freshButton = new System.Windows.Forms.RadioButton();
            this.sophButton = new System.Windows.Forms.RadioButton();
            this.junButton = new System.Windows.Forms.RadioButton();
            this.senButton = new System.Windows.Forms.RadioButton();
            this.time = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // classStanding
            // 
            this.classStanding.AutoSize = true;
            this.classStanding.Location = new System.Drawing.Point(0, 0);
            this.classStanding.Name = "classStanding";
            this.classStanding.Size = new System.Drawing.Size(165, 13);
            this.classStanding.TabIndex = 0;
            this.classStanding.Text = "Class Standing (Prior to Fall 2017)";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(0, 130);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(178, 13);
            this.lastNameLabel.TabIndex = 1;
            this.lastNameLabel.Text = "Enter the first initial of your last name";
            // 
            // date
            // 
            this.date.AutoSize = true;
            this.date.Location = new System.Drawing.Point(84, 209);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(30, 13);
            this.date.TabIndex = 2;
            this.date.Text = "Date";
            // 
            // initialBox
            // 
            this.initialBox.Location = new System.Drawing.Point(184, 127);
            this.initialBox.Name = "initialBox";
            this.initialBox.Size = new System.Drawing.Size(96, 20);
            this.initialBox.TabIndex = 3;
            // 
            // dateBox
            // 
            this.dateBox.Location = new System.Drawing.Point(120, 206);
            this.dateBox.Name = "dateBox";
            this.dateBox.ReadOnly = true;
            this.dateBox.Size = new System.Drawing.Size(122, 20);
            this.dateBox.TabIndex = 4;
            // 
            // timeBox
            // 
            this.timeBox.Location = new System.Drawing.Point(120, 232);
            this.timeBox.Name = "timeBox";
            this.timeBox.ReadOnly = true;
            this.timeBox.Size = new System.Drawing.Size(122, 20);
            this.timeBox.TabIndex = 5;
            // 
            // checkButton
            // 
            this.checkButton.Location = new System.Drawing.Point(41, 165);
            this.checkButton.Name = "checkButton";
            this.checkButton.Size = new System.Drawing.Size(214, 22);
            this.checkButton.TabIndex = 6;
            this.checkButton.Text = "Check your registration date and time";
            this.checkButton.UseVisualStyleBackColor = true;
            this.checkButton.Click += new System.EventHandler(this.checkButton_Click);
            // 
            // freshButton
            // 
            this.freshButton.AutoSize = true;
            this.freshButton.Location = new System.Drawing.Point(3, 24);
            this.freshButton.Name = "freshButton";
            this.freshButton.Size = new System.Drawing.Size(151, 17);
            this.freshButton.TabIndex = 7;
            this.freshButton.TabStop = true;
            this.freshButton.Text = "Freshman (under 30 hours)";
            this.freshButton.UseVisualStyleBackColor = true;
            // 
            // sophButton
            // 
            this.sophButton.AutoSize = true;
            this.sophButton.Location = new System.Drawing.Point(3, 47);
            this.sophButton.Name = "sophButton";
            this.sophButton.Size = new System.Drawing.Size(135, 17);
            this.sophButton.TabIndex = 8;
            this.sophButton.TabStop = true;
            this.sophButton.Text = "Sophomore (30+ hours)";
            this.sophButton.UseVisualStyleBackColor = true;
            // 
            // junButton
            // 
            this.junButton.AutoSize = true;
            this.junButton.Location = new System.Drawing.Point(3, 70);
            this.junButton.Name = "junButton";
            this.junButton.Size = new System.Drawing.Size(109, 17);
            this.junButton.TabIndex = 9;
            this.junButton.TabStop = true;
            this.junButton.Text = "Junior (60+ hours)";
            this.junButton.UseVisualStyleBackColor = true;
            // 
            // senButton
            // 
            this.senButton.AutoSize = true;
            this.senButton.Location = new System.Drawing.Point(3, 93);
            this.senButton.Name = "senButton";
            this.senButton.Size = new System.Drawing.Size(111, 17);
            this.senButton.TabIndex = 10;
            this.senButton.TabStop = true;
            this.senButton.Text = "Senior (90+ hours)";
            this.senButton.UseVisualStyleBackColor = true;
            // 
            // time
            // 
            this.time.AutoSize = true;
            this.time.Location = new System.Drawing.Point(82, 235);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(30, 13);
            this.time.TabIndex = 11;
            this.time.Text = "Time";
            // 
            // Program2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Controls.Add(this.time);
            this.Controls.Add(this.senButton);
            this.Controls.Add(this.junButton);
            this.Controls.Add(this.sophButton);
            this.Controls.Add(this.freshButton);
            this.Controls.Add(this.checkButton);
            this.Controls.Add(this.timeBox);
            this.Controls.Add(this.dateBox);
            this.Controls.Add(this.initialBox);
            this.Controls.Add(this.date);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.classStanding);
            this.Name = "Program2";
            this.Text = "Program 2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label classStanding;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Label date;
        private System.Windows.Forms.TextBox initialBox;
        private System.Windows.Forms.TextBox dateBox;
        private System.Windows.Forms.TextBox timeBox;
        private System.Windows.Forms.Button checkButton;
        private System.Windows.Forms.RadioButton freshButton;
        private System.Windows.Forms.RadioButton sophButton;
        private System.Windows.Forms.RadioButton junButton;
        private System.Windows.Forms.RadioButton senButton;
        private System.Windows.Forms.Label time;
    }
}

