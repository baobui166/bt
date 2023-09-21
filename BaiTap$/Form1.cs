using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTap_
{
    public partial class Form1 : Form
    {

        private DataGridView dvg;
        List<Student> studentList = new List<Student>();
        public Form1(DataGridView dvg, int index = -1)
        {
            InitializeComponent();
            this.dvg = dvg;
        }

        public Form1()
        {
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2(dgvStudent, studentList);
            f2.ShowDialog();
        }

        private void thêmSinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2(dgvStudent, studentList);            
            f2.ShowDialog();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void toolStripTextBox1_TextChanged(object sender, EventArgs e)
        {
            ToolStripTextBox toolStripTextBox = sender as ToolStripTextBox;
            if (toolStripTextBox.Text.Length == 0)
            {
                dgvStudent.DataSource = null;
                dgvStudent.DataSource = studentList;
            }
            else
            {
                dgvStudent.DataSource = null;
                List<Student> std = new List<Student>();
                std = studentList.Where(s => s.HoTen.Contains(toolStripTextBox.Text)).ToList();
                if (std.Count > 0)
                {
                    dgvStudent.DataSource = null;
                    dgvStudent.DataSource = std;
                }
            }
        }
    }
}
