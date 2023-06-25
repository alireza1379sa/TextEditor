namespace ReadAndWrite
{
    public partial class Form1 : Form
    {
        string path = "";
        bool select = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonChoose_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                string format = Path.GetExtension(openFile.FileName);
                if (format == ".txt")
                {
                    select = true;
                    path = openFile.FileName;
                    textEditor.Text = File.ReadAllText(openFile.FileName);
                }
                else
                {
                    MessageBox.Show("فرمت فایل اشتباه است", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            openFile.Dispose();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (select == true)
            {
                File.WriteAllText(path, textEditor.Text);
                MessageBox.Show("تغییرات با موفقیت انجام شد");
                textEditor.Clear();
            }
            else
            {
                MessageBox.Show("شما فایلی را از سیستم خود انتخاب نکرده اید.");
            }
        }


        private void Save_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folder = new FolderBrowserDialog();
            if (folder.ShowDialog() == DialogResult.OK)
            {
                string filePath = folder.SelectedPath + "\\new.txt";
                string text = "";
                if (textEditor.Text == "")
                {
                    text = File.ReadAllText(path);
                }
                else
                {
                    text = textEditor.Text;
                }
                if (File.Exists(filePath))
                {
                    File.Delete(filePath);
                }
                File.Copy(path, filePath, true);
            }
            folder.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "(*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog1.Title = "Save an text File";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (Stream s = File.Open(saveFileDialog1.FileName, FileMode.Create))
                using (StreamWriter sw = new StreamWriter(s))
                {
                    string text = "";
                    if (textEditor.Text == "")
                    {
                        text = File.ReadAllText(path);
                    }
                    else
                    {
                        text = textEditor.Text;
                    }
                    sw.Write(text);
                }
            }
        }
    }
}