using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conceitosBasicos
{
    public class Somador
    {
        public  int Soma(int n1, int n2)
        {
            return n1 + n2;
        }
        public  double Soma(double n1, double n2)
        {
            return n1 + n2;
        }
    } 
    public class Conversor
    {
        public static double MetrosMilimetros(double metros)
        {
            return metros * 1000;
        }
    }
}   
