namespace oyutni_burtgel
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Компьютерын ухаан");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Мэдээллийн технологи");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Програм хангамж");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Мэдээлэл, холбооны технологийн сургууль", new System.Windows.Forms.TreeNode[] { treeNode1, treeNode2, treeNode3 });
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Математик");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Физик");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Байгалийн ухааны сургууль", new System.Windows.Forms.TreeNode[] { treeNode5, treeNode6 });

            textBox1 = new TextBox();
            labelTotal = new Label();
            linkLabel1 = new LinkLabel();
            checkBox1 = new CheckBox();
            radioButton1 = new RadioButton();
            checkedListBox1 = new CheckedListBox();
            numericUpDown1 = new NumericUpDown();
            comboBox1 = new ComboBox();
            maskedTextBox1 = new MaskedTextBox();
            dateTimePicker1 = new DateTimePicker();
            button1 = new Button();
            listBox1 = new ListBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            listView1 = new ListView();
            columnName = new ColumnHeader();
            columnPhone = new ColumnHeader();
            columnAge = new ColumnHeader();
            treeView1 = new TreeView();
            richTextBox1 = new RichTextBox();
            labelProgress = new Label();
            progressBar1 = new ProgressBar();
            notifyIcon1 = new NotifyIcon(components);
            toolTip1 = new ToolTip(components);
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // textBox1
            textBox1.Location = new Point(8, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(120, 23);
            textBox1.TabIndex = 0;
            textBox1.Text = "M.SW24D000";
            // labelTotal
            labelTotal.AutoSize = true;
            labelTotal.Location = new Point(168, 16);
            labelTotal.Name = "labelTotal";
            labelTotal.Text = "Нийт: 0";
            // linkLabel1
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(304, 16);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Цэвэрлэх";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // checkBox1
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(12, 57);
            checkBox1.Name = "checkBox1";
            checkBox1.TabIndex = 1;
            checkBox1.Text = "Тэтгэлэгтэй";
            checkBox1.CheckedChanged += Input_Changed;
            // radioButton1
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(12, 84);
            radioButton1.Name = "radioButton1";
            radioButton1.TabIndex = 2;
            radioButton1.Text = "Өдрийн сургалт";
            // checkedListBox1
            checkedListBox1.CheckOnClick = true;
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Items.AddRange(new object[] { "Програмчлал", "Өгөгдлийн бүтэц", "Алгоритм", "Өгөгдлийн сан", "Сүлжээ" });
            checkedListBox1.Location = new Point(8, 120);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(130, 94);
            checkedListBox1.TabIndex = 3;
            checkedListBox1.ItemCheck += checkedListBox1_ItemCheck;
            // numericUpDown1
            numericUpDown1.Location = new Point(8, 240);
            numericUpDown1.Maximum = 60;
            numericUpDown1.Minimum = 16;
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(120, 23);
            numericUpDown1.TabIndex = 4;
            numericUpDown1.Value = 18;
            // comboBox1
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(8, 330);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(130, 23);
            comboBox1.TabIndex = 5;
            comboBox1.SelectedIndexChanged += Input_Changed;
            // maskedTextBox1
            maskedTextBox1.Location = new Point(8, 360);
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(130, 23);
            maskedTextBox1.TabIndex = 6;
            maskedTextBox1.TextChanged += Input_Changed;
            maskedTextBox1.MaskInputRejected += maskedTextBox1_MaskInputRejected;
            // dateTimePicker1
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(8, 390);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(130, 23);
            dateTimePicker1.TabIndex = 7;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // button1
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button1.ForeColor = Color.Blue;
            button1.Location = new Point(8, 436);
            button1.Name = "button1";
            button1.Size = new Size(138, 40);
            button1.TabIndex = 8;
            button1.Text = "Бүртгэх";
            button1.Click += button1_Click;
            // listBox1
            listBox1.FormattingEnabled = true;
            listBox1.Items.AddRange(new object[] { "Монгол", "Англи", "Орос", "Хятад", "Япон", "Солонгос" });
            listBox1.Location = new Point(163, 98);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(125, 94);
            listBox1.TabIndex = 9;
            // label1
            label1.AutoSize = true;
            label1.Location = new Point(163, 196);
            label1.Name = "label1";
            label1.Text = "Цээж зураг";
            // pictureBox1
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Location = new Point(163, 222);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 130);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // listView1
            listView1.Columns.AddRange(new ColumnHeader[] { columnName, columnPhone, columnAge });
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
            listView1.HideSelection = false;
            listView1.Location = new Point(300, 98);
            listView1.MultiSelect = false;
            listView1.Name = "listView1";
            listView1.Size = new Size(210, 94);
            listView1.TabIndex = 10;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            columnName.Text = "Овог нэр";
            columnName.Width = 90;
            columnPhone.Text = "Утас";
            columnPhone.Width = 70;
            columnAge.Text = "Нас";
            columnAge.Width = 40;
            // treeView1
            treeView1.Location = new Point(300, 222);
            treeView1.Name = "treeView1";
            treeNode4.Name = "nodeIT";
            treeNode7.Name = "nodeScience";
            treeView1.Nodes.AddRange(new TreeNode[] { treeNode4, treeNode7 });
            treeView1.Size = new Size(210, 130);
            treeView1.TabIndex = 11;
            treeView1.AfterSelect += treeView1_AfterSelect;
            // richTextBox1
            richTextBox1.Location = new Point(163, 362);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ReadOnly = true;
            richTextBox1.Size = new Size(347, 210);
            richTextBox1.TabIndex = 12;
            richTextBox1.Text = "Бүртгэлийн мэдээлэл энд харагдана...";
            // labelProgress
            labelProgress.AutoSize = true;
            labelProgress.Location = new Point(22, 590);
            labelProgress.Name = "labelProgress";
            labelProgress.Text = "Бүртгэлийн явц";
            // progressBar1
            progressBar1.Location = new Point(20, 612);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(490, 22);
            progressBar1.TabIndex = 13;
            // notifyIcon1
            notifyIcon1.Text = "Оюутны бүртгэл";
            // Form1
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(524, 650);
            Controls.AddRange(new Control[] { textBox1, labelTotal, linkLabel1, checkBox1, radioButton1, checkedListBox1,
                numericUpDown1, comboBox1, maskedTextBox1, dateTimePicker1, button1, listBox1, label1, pictureBox1,
                listView1, treeView1, richTextBox1, labelProgress, progressBar1 });
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Оюутны бүртгэлийн программ";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion

        private TextBox textBox1;
        private Label labelTotal;
        private LinkLabel linkLabel1;
        private CheckBox checkBox1;
        private RadioButton radioButton1;
        private CheckedListBox checkedListBox1;
        private NumericUpDown numericUpDown1;
        private ComboBox comboBox1;
        private MaskedTextBox maskedTextBox1;
        private DateTimePicker dateTimePicker1;
        private Button button1;
        private ListBox listBox1;
        private Label label1;
        private PictureBox pictureBox1;
        private ListView listView1;
        private ColumnHeader columnName;
        private ColumnHeader columnPhone;
        private ColumnHeader columnAge;
        private TreeView treeView1;
        private RichTextBox richTextBox1;
        private Label labelProgress;
        private ProgressBar progressBar1;
        private NotifyIcon notifyIcon1;
        private ToolTip toolTip1;
    }
}