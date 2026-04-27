namespace Kliensalk
{
    partial class Szerkesztes
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
            txtname = new TextBox();
            txtemail = new TextBox();
            txtphone = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtmegj = new TextBox();
            dateTstart = new DateTimePicker();
            dateTend = new DateTimePicker();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // txtname
            // 
            txtname.Location = new Point(12, 59);
            txtname.Name = "txtname";
            txtname.Size = new Size(239, 27);
            txtname.TabIndex = 0;
            // 
            // txtemail
            // 
            txtemail.Location = new Point(12, 152);
            txtemail.Name = "txtemail";
            txtemail.Size = new Size(239, 27);
            txtemail.TabIndex = 1;
            // 
            // txtphone
            // 
            txtphone.Location = new Point(12, 243);
            txtphone.Name = "txtphone";
            txtphone.Size = new Size(239, 27);
            txtphone.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 36);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 3;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 129);
            label2.Name = "label2";
            label2.Size = new Size(46, 20);
            label2.TabIndex = 4;
            label2.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(11, 220);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 5;
            label3.Text = "Phone";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(11, 309);
            label4.Name = "label4";
            label4.Size = new Size(88, 20);
            label4.TabIndex = 11;
            label4.Text = "Megjegyzes";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(464, 139);
            label5.Name = "label5";
            label5.Size = new Size(34, 20);
            label5.TabIndex = 10;
            label5.Text = "End";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(458, 36);
            label6.Name = "label6";
            label6.Size = new Size(40, 20);
            label6.TabIndex = 9;
            label6.Text = "Start";
            // 
            // txtmegj
            // 
            txtmegj.Location = new Point(12, 332);
            txtmegj.Name = "txtmegj";
            txtmegj.Size = new Size(239, 27);
            txtmegj.TabIndex = 8;
            // 
            // dateTstart
            // 
            dateTstart.Location = new Point(464, 72);
            dateTstart.Name = "dateTstart";
            dateTstart.Size = new Size(250, 27);
            dateTstart.TabIndex = 12;
            // 
            // dateTend
            // 
            dateTend.Location = new Point(464, 188);
            dateTend.Name = "dateTend";
            dateTend.Size = new Size(250, 27);
            dateTend.TabIndex = 13;
            // 
            // button1
            // 
            button1.Location = new Point(12, 409);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 14;
            button1.Text = "Mentés";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(128, 409);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 15;
            button2.Text = "Mégse";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Szerkesztes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dateTend);
            Controls.Add(dateTstart);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(txtmegj);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtphone);
            Controls.Add(txtemail);
            Controls.Add(txtname);
            Name = "Szerkesztes";
            Text = "Szerkesztes";
            Load += Szerkesztes_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtname;
        private TextBox txtemail;
        private TextBox txtphone;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtmegj;
        private DateTimePicker dateTstart;
        private DateTimePicker dateTend;
        private Button button1;
        private Button button2;
    }
}
