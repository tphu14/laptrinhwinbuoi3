using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


            SetupListView();
        }

        private void SetupListView()
        {

            listView1.View = View.Details;
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string ten = textBox1.Text;
            string tuoi = textBox2.Text;
            string diaChi = textBox3.Text;

            if (!string.IsNullOrWhiteSpace(ten) && !string.IsNullOrWhiteSpace(tuoi) && !string.IsNullOrWhiteSpace(diaChi))
            {
                string[] row = { ten, tuoi, diaChi };
                listView1.Items.Add(new ListViewItem(row));


                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listView1.SelectedItems[0];


                selectedItem.SubItems[0].Text = textBox1.Text;
                selectedItem.SubItems[1].Text = textBox2.Text;
                selectedItem.SubItems[2].Text = textBox3.Text;

                MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn dòng cần sửa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void button3_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {

                listView1.Items.Remove(listView1.SelectedItems[0]);
                MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn dòng cần xóa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {

                ListViewItem selectedItem = listView1.SelectedItems[0];
                textBox1.Text = selectedItem.SubItems[0].Text;
                textBox2.Text = selectedItem.SubItems[1].Text;
                textBox3.Text = selectedItem.SubItems[2].Text;
            }
        }
    }
}