using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NguyenDuyHai_2001181091
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void textBox_KeyPressOnlyNumber(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && !(e.KeyChar == '.'))
                e.Handled = true;
            else if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
        private void txtDiemToan_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBox_KeyPressOnlyNumber(sender, e);
        }

        private void txtDiemLy_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBox_KeyPressOnlyNumber(sender, e);
        }

        private void txtDiemHoa_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBox_KeyPressOnlyNumber(sender, e);
        }

        private void txtDiemRenLuyen_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBox_KeyPressOnlyNumber(sender, e);
        }
        private void textBox_Leave(object sender, EventArgs e)
        {
            Control control = (Control)sender;
            TextBox textBox = (TextBox)control;
            if (textBox.Text.Length == 0)
            {
                errorProvider.SetError(control, "Khong duoc de trong");
            }
            else if(float.Parse(textBox.Text) > 10)
            {
                errorProvider.SetError(control, "Diem khong duoc lon hon 10");
            }
            else
            {
                errorProvider.Clear();
            }
                
        }
        private void txtDiemToan_Leave(object sender, EventArgs e)
        {
            textBox_Leave(sender, e);
        }

        private void txtDiemLy_Leave(object sender, EventArgs e)
        {
            textBox_Leave(sender, e);
        }

        private void txtDiemHoa_Leave(object sender, EventArgs e)
        {
            textBox_Leave(sender, e);
        }

        private bool checkControlTextBox(Control control)
        {
            foreach (Control item in control.Controls)
            {
                if (item is TextBox)
                {
                    if (((TextBox)item).ReadOnly == false)
                    {
                        if (errorProvider.GetError(control) != "" || item.Text.Length == 0 || float.Parse(item.Text) < 0 || float.Parse(item.Text) > 10)
                        {
                            control.Focus();
                            return false;
                        }
                    }
                }
            }
            return true;
        }
        private void txtDiemRenLuyen_Leave(object sender, EventArgs e)
        {
            textBox_Leave(sender, e);
        }

        private void btnXepLoai_Click(object sender, EventArgs e)
        {
            if (checkControlTextBox(this) == false)
                return;
            float diemToan = float.Parse(txtDiemToan.Text);
            float diemLy = float.Parse(txtDiemLy.Text);
            float diemHoa = float.Parse(txtDiemRenLuyen.Text);
            float diemRenLuyen = float.Parse(txtDiemRenLuyen.Text);
            HocSinh hocSinh = new HocSinh(diemToan,diemLy,diemHoa,diemRenLuyen);
            txtXepLoai.Text = hocSinh.XepLoaiTrungBinhMon();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtDiemToan.Text = null;
            txtDiemLy.Text = null;
            txtDiemHoa.Text = null;
            txtDiemRenLuyen.Text = null;
            txtXepLoai.Text = null;
            txtDiemToan.Focus();
        }
    }
}
