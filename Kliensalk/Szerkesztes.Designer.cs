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
            label6 = new Label();
            txtmegj = new TextBox();
            dateTstart = new DateTimePicker();
            button1 = new Button();
            button2 = new Button();
            listBox1 = new ListBox();
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
            txtemail.Location = new Point(11, 112);
            txtemail.Name = "txtemail";
            txtemail.Size = new Size(239, 27);
            txtemail.TabIndex = 1;
            // 
            // txtphone
            // 
            txtphone.Location = new Point(12, 165);
            txtphone.Name = "txtphone";
            txtphone.Size = new Size(239, 27);
            txtphone.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bookman Old Style", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(23, 53, 48);
            label1.Location = new Point(12, 36);
            label1.Name = "label1";
            label1.Size = new Size(52, 19);
            label1.TabIndex = 3;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bookman Old Style", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(23, 53, 48);
            label2.Location = new Point(12, 89);
            label2.Name = "label2";
            label2.Size = new Size(52, 19);
            label2.TabIndex = 4;
            label2.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Bookman Old Style", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(23, 53, 48);
            label3.Location = new Point(11, 142);
            label3.Name = "label3";
            label3.Size = new Size(55, 19);
            label3.TabIndex = 5;
            label3.Text = "Phone";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Bookman Old Style", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(23, 53, 48);
            label4.Location = new Point(12, 195);
            label4.Name = "label4";
            label4.Size = new Size(93, 19);
            label4.TabIndex = 11;
            label4.Text = "Megjegyzes";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Bookman Old Style", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(23, 53, 48);
            label6.Location = new Point(330, 36);
            label6.Name = "label6";
            label6.Size = new Size(47, 19);
            label6.TabIndex = 9;
            label6.Text = "Start";
            // 
            // txtmegj
            // 
            txtmegj.Location = new Point(11, 218);
            txtmegj.Name = "txtmegj";
            txtmegj.Size = new Size(239, 27);
            txtmegj.TabIndex = 8;
            // 
            // dateTstart
            // 
            dateTstart.CalendarForeColor = Color.FromArgb(23, 53, 48);
            dateTstart.CalendarTitleForeColor = Color.FromArgb(23, 53, 48);
            dateTstart.Font = new Font("Bookman Old Style", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dateTstart.Location = new Point(330, 57);
            dateTstart.Name = "dateTstart";
            dateTstart.Size = new Size(274, 25);
            dateTstart.TabIndex = 12;
            // 
            // button1
            // 
            button1.Location = new Point(11, 272);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 14;
            button1.Text = "Mentés";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(111, 272);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 15;
            button2.Text = "Mégse";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // listBox1
            // 
            listBox1.Font = new Font("Bookman Old Style", 9F, FontStyle.Regular, GraphicsUnit.Point);
            listBox1.ForeColor = Color.FromArgb(23, 53, 48);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 19;
            listBox1.Location = new Point(626, 62);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(150, 23);
            listBox1.TabIndex = 16;
            // 
            // Szerkesztes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(249, 245, 231);
            ClientSize = new Size(800, 450);
            Controls.Add(listBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dateTstart);
            Controls.Add(label4);
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
        private Label label6;
        private TextBox txtmegj;
        private DateTimePicker dateTstart;
        private Button button1;
        private Button button2;
        private ListBox listBox1;
    }
}
