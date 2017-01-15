using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication19
{
    class Program
    {
        static void Main(string[] args)
        {
            Head head = new Head();
            head.color = "green";
            Tongue tongue = new Tongue();
            tongue.color = "red";
            if (tongue.color == "red" && head.color == "green")
            {
                head.cut();
            }
        }

        class Head
        {
            
            public string color;
            public void cut()
            {
                
            }
        }

        class Tongue
        {
            public string color;
            void speak()
            {

            }
        }

    }
}
