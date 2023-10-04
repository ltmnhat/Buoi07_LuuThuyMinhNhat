using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2_MinhNhat
{
    class TinhToan
    {
        float a;

        public float A
        {
            get { return a; }
            set { a = value; }
        }
        float b;

        public float B
        {
            get { return b; }
            set { b = value; }
        }
        public TinhToan()
        {
            a = 0;
            b = 0;
        }
        public TinhToan(float a,float b)
        {
            this.a=a;
            this.b=b;
        }
        public float TinhTong()
        {
            return a + b;
        }
        public float TinhHieu()
        {
            return a - b;
        }
        public float TinhTich()
        {
            return a * b;
        }
        public float TinhThuong()
        {
            return a / b;
        }
    }
}
