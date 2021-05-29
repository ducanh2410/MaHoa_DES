using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MaHoa_DES
{
    public partial class Form1 : Form
    {
        private C_MaHoaDES DES = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DES = new C_MaHoaDES(Directory.GetCurrentDirectory() + "\\DLL\\KhoiTao_DES", Directory.GetCurrentDirectory() + "\\DLL\\ASCtoNhiPhan");
        }

        private void btnMaHoa_Click(object sender, EventArgs e)
        {
            if (txtKhoa.Text.Length == 8)
            {
                if (txtBanRo.Text != "")
                {
                    txtBanMaHoa.Text = DES.DES(txtBanRo.Text, txtKhoa.Text);
                    txtKetQua.Text = C_MaHoaDES.thaoTac;
                }
                else
                    MessageBox.Show("Hãy nhập từ cần mã hóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Khóa nhập vào phải đúng 8 kí tự", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}