using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4
{
    class PT_BacHai
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
        float c;

        public float C
        {
            get { return c; }
            set { c = value; }
        }
        public PT_BacHai()
        {
            a = 0;
            b = 0;
            c = 0;
        }
        public PT_BacHai(float a,float b,float c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        //public float TinhNghiem()
        //{
            
        //}
    }
}
