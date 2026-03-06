namespace Lab3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtDate = new TextBox();
            btnDate = new Button();
            label1 = new Label();
            lblResultDate = new Label();
            txtTime = new TextBox();
            btnTime = new Button();
            label3 = new Label();
            lblResultTime = new Label();
            SuspendLayout();
            // 
            // txtDate
            // 
            txtDate.Location = new Point(12, 12);
            txtDate.Name = "txtDate";
            txtDate.Size = new Size(100, 23);
            txtDate.TabIndex = 0;
            // 
            // btnDate
            // 
            btnDate.Location = new Point(12, 53);
            btnDate.Name = "btnDate";
            btnDate.Size = new Size(75, 23);
            btnDate.TabIndex = 1;
            btnDate.Text = "Run";
            btnDate.UseVisualStyleBackColor = true;
            btnDate.Click += btnIncDate_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 90);
            label1.Name = "label1";
            label1.Size = new Size(35, 15);
            label1.TabIndex = 2;
            label1.Text = "Дата:";
            // 
            // lblResultDate
            // 
            lblResultDate.AutoSize = true;
            lblResultDate.Location = new Point(74, 90);
            lblResultDate.Name = "lblResultDate";
            lblResultDate.Size = new Size(0, 15);
            lblResultDate.TabIndex = 3;
            // 
            // txtTime
            // 
            txtTime.Location = new Point(229, 12);
            txtTime.Name = "txtTime";
            txtTime.Size = new Size(100, 23);
            txtTime.TabIndex = 4;
            // 
            // btnTime
            // 
            btnTime.Location = new Point(229, 53);
            btnTime.Name = "btnTime";
            btnTime.Size = new Size(75, 23);
            btnTime.TabIndex = 5;
            btnTime.Text = "Run";
            btnTime.UseVisualStyleBackColor = true;
            btnTime.Click += btnIncTime_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(229, 90);
            label3.Name = "label3";
            label3.Size = new Size(30, 15);
            label3.TabIndex = 6;
            label3.Text = "Час:";
            // 
            // lblResultTime
            // 
            lblResultTime.AutoSize = true;
            lblResultTime.Location = new Point(291, 90);
            lblResultTime.Name = "lblResultTime";
            lblResultTime.Size = new Size(0, 15);
            lblResultTime.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblResultTime);
            Controls.Add(label3);
            Controls.Add(btnTime);
            Controls.Add(txtTime);
            Controls.Add(lblResultDate);
            Controls.Add(label1);
            Controls.Add(btnDate);
            Controls.Add(txtDate);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtDate;
        private Button btnDate;
        private Label label1;
        private Label lblResultDate;
        private TextBox txtTime;
        private Button btnTime;
        private Label label3;
        private Label lblResultTime;
    }
}
