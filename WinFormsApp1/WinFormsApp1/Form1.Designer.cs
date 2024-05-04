namespace WinFormsApp1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            listView1 = new ListView();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            listView2 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(31, 92);
            button1.Name = "button1";
            button1.Size = new Size(113, 38);
            button1.TabIndex = 0;
            button1.Text = "Добавить заказ";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(181, 92);
            button2.Name = "button2";
            button2.Size = new Size(100, 38);
            button2.TabIndex = 1;
            button2.Text = "Удалить заказ";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(31, 286);
            button3.Name = "button3";
            button3.Size = new Size(113, 36);
            button3.TabIndex = 2;
            button3.Text = "Редактировать заказ";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.White;
            button4.Font = new Font("Bahnschrift Condensed", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            button4.Location = new Point(63, 400);
            button4.Name = "button4";
            button4.Size = new Size(451, 38);
            button4.TabIndex = 3;
            button4.Text = "Оплатить заказ";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // listView1
            // 
            listView1.BackColor = Color.FromArgb(192, 192, 255);
            listView1.BackgroundImage = (Image)resources.GetObject("listView1.BackgroundImage");
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader4, columnHeader5, columnHeader6 });
            listView1.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            listView1.ForeColor = SystemColors.ActiveCaption;
            listView1.Location = new Point(584, 9);
            listView1.Name = "listView1";
            listView1.Size = new Size(204, 206);
            listView1.TabIndex = 4;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Заказ";
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Номер";
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Статус заказа";
            columnHeader6.Width = 80;
            // 
            // listView2
            // 
            listView2.BackColor = Color.FromArgb(192, 192, 255);
            listView2.BackgroundImage = (Image)resources.GetObject("listView2.BackgroundImage");
            listView2.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            listView2.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            listView2.ForeColor = Color.Black;
            listView2.Location = new Point(584, 240);
            listView2.Name = "listView2";
            listView2.Size = new Size(204, 198);
            listView2.TabIndex = 5;
            listView2.TileSize = new Size(200, 34);
            listView2.UseCompatibleStateImageBehavior = false;
            listView2.View = View.Details;
            listView2.SelectedIndexChanged += listView2_SelectedIndexChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Заказ";
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Номер";
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Статус заказа";
            columnHeader3.Width = 80;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(584, 218);
            label1.Name = "label1";
            label1.Size = new Size(46, 19);
            label1.TabIndex = 6;
            label1.Text = "Сумма:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(627, 218);
            label2.Name = "label2";
            label2.Size = new Size(16, 19);
            label2.TabIndex = 7;
            label2.Text = "0";
            label2.Click += label2_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(173, 173, 255);
            textBox1.Cursor = Cursors.IBeam;
            textBox1.Location = new Point(31, 211);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(113, 23);
            textBox1.TabIndex = 8;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(173, 173, 255);
            textBox2.Cursor = Cursors.IBeam;
            textBox2.Location = new Point(181, 63);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 9;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.FromArgb(173, 173, 255);
            textBox3.Cursor = Cursors.IBeam;
            textBox3.Location = new Point(31, 63);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(113, 23);
            textBox3.TabIndex = 10;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.FromArgb(173, 173, 255);
            textBox4.Cursor = Cursors.IBeam;
            textBox4.Location = new Point(31, 257);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(113, 23);
            textBox4.TabIndex = 11;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(173, 173, 255);
            label3.FlatStyle = FlatStyle.System;
            label3.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Transparent;
            label3.Location = new Point(12, 9);
            label3.Name = "label3";
            label3.Size = new Size(478, 19);
            label3.TabIndex = 12;
            label3.Text = "Примечание! Чтобы удалить и редактировать заказ введите номер товара, начиная с нуля";
            label3.Click += label3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(listView2);
            Controls.Add(listView1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private ListView listView1;
        private ListView listView2;
        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private Label label3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
    }
}