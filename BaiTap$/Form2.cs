using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace BaiTap_
{
    public partial class Form2 : Form
    {

        DataGridView fgrid;
        List<Student> studentList;

        public Form2(DataGridView fg, List<Student> studentList)
        {
            InitializeComponent();
            fgrid = fg;
            this.studentList = studentList;
        }

        public bool checkDTB()
        {
            float dtb = float.Parse(txtDTB.Text);
            if (dtb < 0 || dtb > 10) {
                return false;
            }

            return true;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMSSV.Text == "" || txtDTB.Text == "" || txtMSSV.Text == "")
                {
                    throw new Exception("Vui long nhap day du thong tin !");
                }

                if (studentList.Where(s => s.Mssv == txtMSSV.Text).Count() > 0)
                {
                    throw new Exception("Mã số sinh viên đã bị trùng !");
                }

                if (!checkDTB())
                {
                    txtDTB.Text = "";
                    throw new Exception("Diem khong hop le");
                   
                }


                studentList.Add(new Student() { Stt = studentList.Count() + 1, Mssv = txtMSSV.Text, HoTen = txtHoTen.Text, Khoa = comboBoxNganh.Text, Dtb = int.Parse(txtDTB.Text) });
                fgrid.DataSource = null;
                fgrid.DataSource = studentList;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK);
            }
        }
    }
}
