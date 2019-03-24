using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Inheritance
    {
        // Every .cs its a different program
        public static void Main(string[] args)
        {
            Trangle t = new Trangle();
            Rectagle r = new Rectagle();    
           
            //BaseForm
            t.Height = 1;
            t.New();
            r.Base = 1;
            r.New();
            t.Values();
            r.Values();

            //Changes
            t.Base = 10;
            r.Height = 10;

            //Results
            t.Values();
            r.Values();
            Console.ReadKey();
        }

        public class Shape
        {
            //Encryption
            private int _Base;
            private int _Height;
            public int Base { get => _Base; set => _Base = value; }
            public int Height { get => _Height; set => _Height = value; }

            public void Values()
            {
                Console.WriteLine(string.Format("Base :{0} Height :{1}", Base, Height));
            }
        }

        public class Trangle : Shape
        {
            public void New()
            {
                Base = 1;
            }
        }
        
        public class Rectagle : Shape
        {
            public void New()
            {
                Height = 1;
            }
        }
            //This text is for running Polymrphisim
            //Polymrphism poli = new Polymrphism();
            //poli.Program();
            //}
    }
}
