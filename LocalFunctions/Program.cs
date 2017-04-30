using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocalFunctions
{

    class MyData
    {
        #region example 4
        //public MyData()
        //{
        //    // Method calling
        //    GetMyName();

        //    //Method Declaration
        //    void GetMyName()
        //    {
        //        Console.WriteLine($"My Name Is Omar Maher");
        //    }
        //}

        #endregion
        #region example 5
        public MyData(string name)
        {
            // Method calling
            GetMyName();

            //Method Declaration
            void GetMyName()
            {
                Console.WriteLine($"My Name Is {name}");
            }
        }
        #endregion

    }
    class Program
    {
        static void Main(string[] args)
        {
            #region example 1
            //Method calling
            GetMyName();

            //Method Declaration
            void GetMyName()
            {
                Console.WriteLine($"My Name Is Omar Maher");
            }
            #endregion

            #region example 2
            //// Method calling
            //GetMyName("Omar Maher");

            ////Method Declaration
            //void GetMyName(string name)
            //{
            //    Console.WriteLine($"My Name Is {name}");
            //}

            #endregion
            #region example 3
            //string name = "Omar Maher";
            //// Method calling
            //GetMyName();

            ////Method Declaration
            //void GetMyName()
            //{
            //    Console.WriteLine($"My Name Is {name}");
            //}

            #endregion
            #region example 4
            //   MyData data = new MyData();
            #endregion

            #region example 5
            //   MyData data1 = new MyData("Omar Maher");

            #endregion

        }
    }
}
