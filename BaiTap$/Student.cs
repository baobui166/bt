using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BaiTap_
{
    internal class Student
    {
        private int stt;
        private string mssv;
        private string hoTen;
        private string khoa;
        private float dtb;

        public int Stt { get; set; }
        public string Mssv { get { return mssv; } set { mssv = value; } }
        public string HoTen { get { return hoTen; } set { hoTen = value; } }
        public string Khoa { get { return khoa; } set { khoa = value; } }
        public float Dtb { get { return dtb; } set { dtb = value; } }
    }
}
