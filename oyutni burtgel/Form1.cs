// Лабораторийн ажил № 05. Оюутны бүртгэлийн программ
namespace oyutni_burtgel;

public partial class Form1 : Form
{
    private const string DefaultName = "M.SW24D000";
    private const string Placeholder = "Бүртгэлийн мэдээлэл энд харагдана...";

    public Form1()
    {
        InitializeComponent();
    }

    // ---------- Form events ----------
    private void Form1_Load(object sender, EventArgs e)
    {
        Text = "Оюутны бүртгэлийн программ - Лаб 05";
        button1.Text = "Бүртгэх";
        maskedTextBox1.Mask = "0000-0000";
        comboBox1.Items.AddRange(new object[]
        {
            "-- Тэнхим сонгох --", "Компьютерын ухаан", "Мэдээллийн технологи",
            "Програм хангамж", "Математик", "Физик"
        });
        comboBox1.SelectedIndex = 0;
        treeView1.ExpandAll();
        notifyIcon1.Icon = SystemIcons.Information;
        dateTimePicker1.Value = new DateTime(2005, 1, 28);
        progressBar1.Maximum = 5;
        listBox1.SelectedIndex = 1;
        UpdateProgress();
    }

    private void Form1_FormClosing(object sender, FormClosingEventArgs e)
    {
        notifyIcon1.Visible = false;
    }

    // ---------- Progress ----------
    private void Input_Changed(object sender, EventArgs e)
    {
        UpdateProgress();
    }

    private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
    {
        // ItemCheck fires BEFORE the state changes, so postpone the update
        BeginInvoke(new Action(UpdateProgress));
    }

    private void UpdateProgress()
    {
        int done = 0;
        if (!string.IsNullOrWhiteSpace(textBox1.Text)) done++;
        if (maskedTextBox1.MaskCompleted) done++;
        if (comboBox1.SelectedIndex > 0) done++;
        if (checkedListBox1.CheckedItems.Count > 0) done++;
        if (pictureBox1.Image != null) done++;
        progressBar1.Value = done;
    }

    // ---------- Input helpers ----------
    private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
    {
        int age = DateTime.Today.Year - dateTimePicker1.Value.Year;
        if (dateTimePicker1.Value.Date > DateTime.Today.AddYears(-age)) age--;
        if (age >= numericUpDown1.Minimum)
        {
            if (!(age > numericUpDown1.Maximum))
            {
                numericUpDown1.Value = age;
            }
        }
    }

    private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
    {
        toolTip1.Show("Зөвхөн тоо оруулна уу", maskedTextBox1, 0, maskedTextBox1.Height, 1500);
    }

    private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
    {
        int idx = comboBox1.Items.IndexOf(e.Node.Text);
        if (idx > 0) comboBox1.SelectedIndex = idx;
    }

    private void pictureBox1_Click(object sender, EventArgs e)
    {
        using (OpenFileDialog ofd = new OpenFileDialog())
        {
            ofd.Filter = "Зураг|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image?.Dispose();
                pictureBox1.Image = Image.FromFile(ofd.FileName);
                UpdateProgress();
            }
        }
    }

    // ---------- Register ----------
    private void button1_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(textBox1.Text))
        {
            Warn("Овог нэрээ оруулна уу.");
            textBox1.Focus();
            return;
        }
        if (!maskedTextBox1.MaskCompleted)
        {
            Warn("Утасны дугаараа бүрэн оруулна уу.");
            maskedTextBox1.Focus();
            return;
        }
        if (!(comboBox1.SelectedIndex > 0))
        {
            Warn("Тэнхимээ сонгоно уу.");
            comboBox1.Focus();
            return;
        }

        Student s = new Student();
        s.Name = textBox1.Text.Trim();
        s.Phone = maskedTextBox1.Text;
        s.Age = (int)numericUpDown1.Value;
        s.BirthDate = dateTimePicker1.Value.Date;
        s.Department = comboBox1.Text;
        s.HasScholarship = checkBox1.Checked;
        s.IsDaytime = radioButton1.Checked;
        if (listBox1.SelectedItem != null) s.Language = listBox1.SelectedItem.ToString();
        else s.Language = "-";
        foreach (object c in checkedListBox1.CheckedItems)
        {
            s.Courses.Add(c.ToString());
        }

        ShowInRichText(s);

        ListViewItem item = new ListViewItem(new string[] { s.Name, s.Phone, s.Age.ToString() });
        item.Tag = s;
        listView1.Items.Add(item);
        labelTotal.Text = "Нийт: " + listView1.Items.Count;

        notifyIcon1.Visible = true;
        notifyIcon1.ShowBalloonTip(2000, "Бүртгэл амжилттай", s.Name + " бүртгэгдлээ.", ToolTipIcon.Info);
    }

    private void Warn(string text)
    {
        MessageBox.Show(text, "Анхааруулга", MessageBoxButtons.OK, MessageBoxIcon.Warning);
    }

    private void listView1_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (listView1.SelectedItems.Count == 1)
        {
            Student s = listView1.SelectedItems[0].Tag as Student;
            if (s != null) ShowInRichText(s);
        }
    }

    private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
        textBox1.Text = DefaultName;
        maskedTextBox1.Clear();
        comboBox1.SelectedIndex = 0;
        checkBox1.Checked = false;
        radioButton1.Checked = false;
        for (int i = checkedListBox1.Items.Count - 1; i >= 0; i--)
        {
            checkedListBox1.SetItemChecked(i, false);
        }
        listBox1.SelectedIndex = 1;
        pictureBox1.Image?.Dispose();
        pictureBox1.Image = null;
        richTextBox1.Text = Placeholder;
        UpdateProgress();
    }

    // ---------- RichText output ----------
    private void AddLine(string label, string value)
    {
        richTextBox1.SelectionFont = new Font("Segoe UI", 10, FontStyle.Bold);
        richTextBox1.SelectionColor = Color.Black;
        richTextBox1.AppendText(label + ": ");
        richTextBox1.SelectionFont = new Font("Segoe UI", 10);
        richTextBox1.SelectionColor = Color.DarkGreen;
        richTextBox1.AppendText(value + "\n");
    }

    private void ShowInRichText(Student s)
    {
        richTextBox1.Clear();

        richTextBox1.SelectionFont = new Font("Segoe UI", 14, FontStyle.Bold);
        richTextBox1.SelectionColor = Color.Navy;
        richTextBox1.AppendText("ОЮУТНЫ БҮРТГЭЛ\n");
        richTextBox1.SelectionFont = new Font("Segoe UI", 9);
        richTextBox1.SelectionColor = Color.Gray;
        richTextBox1.AppendText("------------------------------\n");

        AddLine("Код", s.Name);
        AddLine("Утас", s.Phone);
        AddLine("Нас", s.Age.ToString());
        AddLine("Төрсөн өдөр", s.BirthDate.ToString("yyyy-MM-dd"));
        AddLine("Сургалт", s.IsDaytime ? "Өдрийн" : "Оройн/Бусад");
        AddLine("Тэнхим", s.Department);
        AddLine("Тэтгэлэг", s.HasScholarship ? "Тийм" : "Үгүй");
        AddLine("Хичээл", s.Courses.Count > 0 ? string.Join(", ", s.Courses) : "-");
        AddLine("Хэл", s.Language);
    }
}