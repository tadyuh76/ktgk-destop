namespace Phan1
{
    public partial class Form1 : Form
    {
        List<NhanVien> dsNhanVien = new List<NhanVien>();
        bool dangThem = false;

        void ReadFile()
        {
            string filePath = "dulieu.txt";

            if (!File.Exists(filePath)) return;

            var lines = File.ReadAllLines(filePath);

            dsNhanVien.Clear();

            foreach (var line in lines)
            {
                var parts = line.Split(';');
                {
                    if (parts.Length == 4)
                    {
                        dsNhanVien.Add(new NhanVien
                        {
                            MaSo = parts[0],
                            HoTen = parts[1],
                            NgaySinh = DateTime.ParseExact(parts[2], "dd/MM/yyyy", null),
                            Email = parts[3]
                        });
                    };
                }
            }
        }

        void ShowOnListView()
        {
            listView.Items.Clear();
            foreach (var nv in dsNhanVien)
            {
                var item = new ListViewItem(nv.MaSo);
                item.SubItems.Add(nv.HoTen);
                item.SubItems.Add(nv.NgaySinh.ToString("dd/MM/yyyy"));
                item.SubItems.Add(nv.Email);

            }
        }

        void SaveFile()
        {
            var lines = dsNhanVien.Select(nv => $"{nv.MaSo};{nv.HoTen};{nv.NgaySinh:dd/MM/yyyy};{nv.Email}");
            File.WriteAllLines("duieu.txt", lines);
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView.SelectedItems.Count > 0)
            {
                var item = listView.SelectedItems[0];
                orderTextBox.Text = item.SubItems[0].Text;
                nameTextBox.Text = item.SubItems[1].Text;
                birthDateTextBox.Text = item.SubItems[2].Text;
                emailTextBox.Text = item.SubItems[3].Text;
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (!dangThem)
            {
                orderTextBox.Text = nameTextBox.Text = birthDateTextBox.Text = emailTextBox.Text = "";
                orderTextBox.Focus();
                saveButton.Enabled = true;
                addButton.Text = "Hủy";
                dangThem = true;
            }
            else
            {
                saveButton.Enabled = false;
                saveButton.Text = "Thêm";
                dangThem = false;
                //if (listView.SelectedItems.Count > 0) listView_SelectedIndexChange(null, null);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ReadFile();
            ShowOnListView();
            saveButton.Enabled = false;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                var nv = new NhanVien
                {
                    MaSo = orderTextBox.Text,
                    HoTen = nameTextBox.Text,
                    NgaySinh = DateTime.ParseExact(birthDateTextBox.Text, "dd/MM/yyyy", null),
                    Email = emailTextBox.Text
                };
                dsNhanVien.Add(nv);
                ShowOnListView();
                SaveFile();
                saveButton.Enabled = false;
                addButton.Text = "Thêm";
                dangThem = false;
            }
            catch
            {
                MessageBox.Show("Dữ liệu không hợp lệ!");
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveFile();
        }
    }
}
