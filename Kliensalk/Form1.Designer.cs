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
            bookingIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            moduleIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            startDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            endDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            emailDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            phoneNrDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            commentDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            statusDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            serializedProductBvinsDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            bookingBindingSource = new BindingSource(components);
            bindingSource1 = new BindingSource(components);
            Szerkeszt = new Button();
            Torles = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            button3 = new Button();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bookingBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // monthCalendar1
            // 
            monthCalendar1.Font = new Font("Bookman Old Style", 9F, FontStyle.Regular, GraphicsUnit.Point);
            monthCalendar1.ForeColor = Color.FromArgb(23, 53, 48);
            monthCalendar1.Location = new Point(18, 63);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 0;
            monthCalendar1.TitleBackColor = Color.FromArgb(192, 215, 187);
            monthCalendar1.TitleForeColor = Color.FromArgb(23, 53, 48);
            monthCalendar1.TrailingForeColor = Color.FromArgb(249, 245, 231);
            monthCalendar1.DateChanged += monthCalendar1_DateChanged;
            // 
            // Frissit
            // 
            Frissit.BackColor = Color.FromArgb(23, 53, 48);
            Frissit.Font = new Font("Bookman Old Style", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Frissit.ForeColor = Color.FromArgb(249, 245, 231);
            Frissit.Location = new Point(18, 22);
            Frissit.Name = "Frissit";
            Frissit.Size = new Size(94, 29);
            Frissit.TabIndex = 1;
            Frissit.Text = "Frissít";
            Frissit.UseVisualStyleBackColor = false;
            Frissit.Click += Frissit_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(23, 53, 48);
            button2.Font = new Font("Bookman Old Style", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = Color.FromArgb(249, 245, 231);
            button2.Location = new Point(18, 282);
            button2.Name = "button2";
            button2.Size = new Size(220, 29);
            button2.TabIndex = 2;
            button2.Text = "Belső tisztítás";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(23, 53, 48);
            button1.Font = new Font("Book Antiqua", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.FromArgb(249, 245, 231);
            button1.Location = new Point(18, 317);
            button1.Name = "button1";
            button1.Size = new Size(220, 29);
            button1.TabIndex = 3;
            button1.Text = "Külső mosás";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.BackgroundColor = Color.FromArgb(192, 215, 187);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { bookingIdDataGridViewTextBoxColumn, moduleIdDataGridViewTextBoxColumn, startDataGridViewTextBoxColumn, endDataGridViewTextBoxColumn, nameDataGridViewTextBoxColumn, emailDataGridViewTextBoxColumn, phoneNrDataGridViewTextBoxColumn, commentDataGridViewTextBoxColumn, statusDataGridViewTextBoxColumn, serializedProductBvinsDataGridViewTextBoxColumn });
            dataGridView1.DataSource = bookingBindingSource;
            dataGridView1.GridColor = Color.FromArgb(23, 53, 48);
            dataGridView1.Location = new Point(274, 22);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(709, 409);
            dataGridView1.TabIndex = 4;
            // 
            // bookingIdDataGridViewTextBoxColumn
            // 
            bookingIdDataGridViewTextBoxColumn.DataPropertyName = "BookingId";
            bookingIdDataGridViewTextBoxColumn.HeaderText = "BookingId";
            bookingIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            bookingIdDataGridViewTextBoxColumn.Name = "bookingIdDataGridViewTextBoxColumn";
            bookingIdDataGridViewTextBoxColumn.Width = 106;
            // 
            // moduleIdDataGridViewTextBoxColumn
            // 
            moduleIdDataGridViewTextBoxColumn.DataPropertyName = "ModuleId";
            moduleIdDataGridViewTextBoxColumn.HeaderText = "ModuleId";
            moduleIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            moduleIdDataGridViewTextBoxColumn.Name = "moduleIdDataGridViewTextBoxColumn";
            moduleIdDataGridViewTextBoxColumn.Visible = false;
            moduleIdDataGridViewTextBoxColumn.Width = 102;
            // 
            // startDataGridViewTextBoxColumn
            // 
            startDataGridViewTextBoxColumn.DataPropertyName = "Start";
            startDataGridViewTextBoxColumn.HeaderText = "Start";
            startDataGridViewTextBoxColumn.MinimumWidth = 6;
            startDataGridViewTextBoxColumn.Name = "startDataGridViewTextBoxColumn";
            startDataGridViewTextBoxColumn.Width = 69;
            // 
            // endDataGridViewTextBoxColumn
            // 
            endDataGridViewTextBoxColumn.DataPropertyName = "End";
            endDataGridViewTextBoxColumn.HeaderText = "End";
            endDataGridViewTextBoxColumn.MinimumWidth = 6;
            endDataGridViewTextBoxColumn.Name = "endDataGridViewTextBoxColumn";
            endDataGridViewTextBoxColumn.Width = 63;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.HeaderText = "Name";
            nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            nameDataGridViewTextBoxColumn.Width = 78;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            emailDataGridViewTextBoxColumn.HeaderText = "Email";
            emailDataGridViewTextBoxColumn.MinimumWidth = 6;
            emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            emailDataGridViewTextBoxColumn.Width = 75;
            // 
            // phoneNrDataGridViewTextBoxColumn
            // 
            phoneNrDataGridViewTextBoxColumn.DataPropertyName = "PhoneNr";
            phoneNrDataGridViewTextBoxColumn.HeaderText = "PhoneNr";
            phoneNrDataGridViewTextBoxColumn.MinimumWidth = 6;
            phoneNrDataGridViewTextBoxColumn.Name = "phoneNrDataGridViewTextBoxColumn";
            phoneNrDataGridViewTextBoxColumn.Width = 95;
            // 
            // commentDataGridViewTextBoxColumn
            // 
            commentDataGridViewTextBoxColumn.DataPropertyName = "Comment";
            commentDataGridViewTextBoxColumn.HeaderText = "Comment";
            commentDataGridViewTextBoxColumn.MinimumWidth = 6;
            commentDataGridViewTextBoxColumn.Name = "commentDataGridViewTextBoxColumn";
            commentDataGridViewTextBoxColumn.Width = 103;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            statusDataGridViewTextBoxColumn.HeaderText = "Status";
            statusDataGridViewTextBoxColumn.MinimumWidth = 6;
            statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            statusDataGridViewTextBoxColumn.Width = 78;
            // 
            // serializedProductBvinsDataGridViewTextBoxColumn
            // 
            serializedProductBvinsDataGridViewTextBoxColumn.DataPropertyName = "SerializedProductBvins";
            serializedProductBvinsDataGridViewTextBoxColumn.HeaderText = "SerializedProductBvins";
            serializedProductBvinsDataGridViewTextBoxColumn.MinimumWidth = 6;
            serializedProductBvinsDataGridViewTextBoxColumn.Name = "serializedProductBvinsDataGridViewTextBoxColumn";
            serializedProductBvinsDataGridViewTextBoxColumn.Visible = false;
            serializedProductBvinsDataGridViewTextBoxColumn.Width = 188;
            // 
            // bookingBindingSource
            // 
            bookingBindingSource.DataSource = typeof(Booking);
            // 
            // Szerkeszt
            // 
            Szerkeszt.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            Szerkeszt.BackColor = Color.FromArgb(23, 53, 48);
            Szerkeszt.Font = new Font("Bookman Old Style", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Szerkeszt.ForeColor = Color.FromArgb(249, 245, 231);
            Szerkeszt.Location = new Point(274, 468);
            Szerkeszt.Name = "Szerkeszt";
            Szerkeszt.Size = new Size(94, 29);
            Szerkeszt.TabIndex = 5;
            Szerkeszt.Text = "Szerkesztés";
            Szerkeszt.UseVisualStyleBackColor = false;
            Szerkeszt.Click += Szerkeszt_Click;
            // 
            // Torles
            // 
            Torles.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            Torles.BackColor = Color.FromArgb(23, 53, 48);
            Torles.Font = new Font("Bookman Old Style", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Torles.ForeColor = Color.FromArgb(249, 245, 231);
            Torles.Location = new Point(386, 468);
            Torles.Name = "Torles";
            Torles.Size = new Size(94, 29);
            Torles.TabIndex = 6;
            Torles.Text = "Törlés";
            Torles.UseVisualStyleBackColor = false;
            Torles.Click += Torles_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(18, 468);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(220, 27);
            textBox1.TabIndex = 7;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bookman Old Style", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(23, 53, 48);
            label1.Location = new Point(18, 434);
            label1.Name = "label1";
            label1.Size = new Size(57, 19);
            label1.TabIndex = 8;
            label1.Text = "Name:";
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(23, 53, 48);
            button3.Font = new Font("Bookman Old Style", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button3.ForeColor = Color.FromArgb(249, 245, 231);
            button3.Location = new Point(18, 352);
            button3.Name = "button3";
            button3.Size = new Size(220, 30);
            button3.TabIndex = 9;
            button3.Text = "Kerámia bevonat";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(23, 53, 48);
            button4.Font = new Font("Bookman Old Style", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button4.ForeColor = Color.FromArgb(249, 245, 231);
            button4.Location = new Point(18, 388);
            button4.Name = "button4";
            button4.Size = new Size(220, 30);
            button4.TabIndex = 10;
            button4.Text = "Teljes autópolírozás";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(249, 245, 231);
            ClientSize = new Size(1005, 529);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(label1);
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
            ((System.ComponentModel.ISupportInitialize)bookingBindingSource).EndInit();
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
        private BindingSource bookingBindingSource;
        private Label label1;
        private Button button4;
        private DataGridViewTextBoxColumn bookingIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn moduleIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn startDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn endDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn phoneNrDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn commentDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn serializedProductBvinsDataGridViewTextBoxColumn;
    }
}
