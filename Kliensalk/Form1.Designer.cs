namespace Kliensalk
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
            components = new System.ComponentModel.Container();
            monthCalendar1 = new MonthCalendar();
            Frissit = new Button();
            button2 = new Button();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            bindingSource1 = new BindingSource(components);
            Szerkeszt = new Button();
            Torles = new Button();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(18, 63);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 0;
            monthCalendar1.DateChanged += monthCalendar1_DateChanged;
            // 
            // Frissit
            // 
            Frissit.Location = new Point(18, 22);
            Frissit.Name = "Frissit";
            Frissit.Size = new Size(94, 29);
            Frissit.TabIndex = 1;
            Frissit.Text = "Frissít";
            Frissit.UseVisualStyleBackColor = true;
            Frissit.Click += Frissit_Click;
            // 
            // button2
            // 
            button2.Location = new Point(18, 282);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 2;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(18, 330);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 3;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.DataSource = bindingSource1;
            dataGridView1.Location = new Point(274, 22);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(504, 330);
            dataGridView1.TabIndex = 4;
            // 
            // Szerkeszt
            // 
            Szerkeszt.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            Szerkeszt.Location = new Point(274, 389);
            Szerkeszt.Name = "Szerkeszt";
            Szerkeszt.Size = new Size(94, 29);
            Szerkeszt.TabIndex = 5;
            Szerkeszt.Text = "Szerkesztés";
            Szerkeszt.UseVisualStyleBackColor = true;
            Szerkeszt.Click += Szerkeszt_Click;
            // 
            // Torles
            // 
            Torles.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            Torles.Location = new Point(386, 389);
            Torles.Name = "Torles";
            Torles.Size = new Size(94, 29);
            Torles.TabIndex = 6;
            Torles.Text = "Törlés";
            Torles.UseVisualStyleBackColor = true;
            Torles.Click += Torles_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(18, 391);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(229, 27);
            textBox1.TabIndex = 7;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox1);
            Controls.Add(Torles);
            Controls.Add(Szerkeszt);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Controls.Add(button2);
            Controls.Add(Frissit);
            Controls.Add(monthCalendar1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MonthCalendar monthCalendar1;
        private Button Frissit;
        private Button button2;
        private Button button1;
        private DataGridView dataGridView1;
        private Button button3;
        private Button Torles;
        private BindingSource bindingSource1;
        private Button Szerkeszt;
        private TextBox textBox1;
    }
}
