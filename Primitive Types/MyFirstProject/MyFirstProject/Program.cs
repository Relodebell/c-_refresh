using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes
{
    class Program
    {
        static void Main(string[] args)
        {

            //int x = 10;
            //int y = 20;
            //int z = 30;

            //int x = 10,
            //   y = 20,
            //  z = 30;

            string textAge = "-23";
            int age = Convert.ToInt32(textAge);
            Console.WriteLine(age);
            //Console.WriteLine(int.MaxValue);
            //Console.WriteLine(int.MinValue);

            string textBigNumber = "-900000000";
            long bigNumber = Convert.ToInt64(textBigNumber);
            //long bigNumber = -900000000L;
            Console.WriteLine(bigNumber);
            // Console.WriteLine(long.MinValue);
            // Console.WriteLine(long.MaxValue);

            string textNegative = "-55.2";
            double negative = Convert.ToDouble(textNegative);
            //double negative = -55.2D;
            Console.WriteLine(negative);
            // Console.WriteLine(double.MinValue);
            //Console.WriteLine(double.MaxValue);


            string textprecision = "5.000001";
            float precision = Convert.ToSingle(textprecision);
            //float precision = 5.000001F;
            Console.WriteLine(precision);
            //Console.WriteLine(float.MinValue);
            //Console.WriteLine(float.MaxValue);


            string textMoney = "14.99";
            decimal money = Convert.ToDecimal(textMoney);
            //decimal money = 14.99M;
            Console.WriteLine(money);
            // Console.WriteLine(decimal.MinValue);
            //Console.WriteLine(decimal.MaxValue);

            //age = 50;
            Console.WriteLine(age);



            Console.ReadLine();
        }
    }
}
