using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Nhom13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lvView.Columns[0].Width = (int)(lvView.Width * 0.25);
            lvView.Columns[1].Width = (int)(lvView.Width * 0.25);
            lvView.Columns[2].Width = (int)(lvView.Width * 0.25);
            lvView.Columns[3].Width = (int)(lvView.Width * 0.25);
            lvView.View = View.Details;
            lvView.GridLines = true;
            lvView.FullRowSelect = true;

            btnLuu.Enabled = false;
            btnKhongLuu.Enabled = false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ListViewItem item = lvView.Items.Add(txtMSSV.Text);
            item.SubItems.Add(dtNS.Text);
            item.SubItems.Add(txtHoTen.Text);
            item.SubItems.Add(cbLop.Text);

            

            MessageBox.Show("Thêm thành công!");
            //lvView.Items.Add(item);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            ListViewItem list = lvView.SelectedItems[0];
            lvView.Items.Remove(list);
            MessageBox.Show("Xóa thành công!");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (lvView.SelectedItems.Count > 0)
            {
                ListViewItem select = lvView.SelectedItems[0];
                if(select.SubItems.Count >= 0)
                {
                    select.SubItems[0].Text = txtMSSV.Text;
                    select.SubItems[1].Text = dtNS.Text;
                    select.SubItems[2].Text = txtHoTen.Text;
                    select.SubItems[3].Text = cbLop.Text;
                }
                MessageBox.Show("Sửa thành công!");
            }
        }

        private void lvView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvView.SelectedItems.Count > 0)
            {
                txtMSSV.Text = lvView.SelectedItems[0].SubItems[0].Text;
                dtNS.Text = lvView.SelectedItems[0].SubItems[1].Text;
                txtHoTen.Text = lvView.SelectedItems[0].SubItems[2].Text;
                cbLop.Text = lvView.SelectedItems[0].SubItems[3].Text;
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
