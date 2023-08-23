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
    //Crie o programa CalculaAumento que deve solicitar o valor atual do salário e o percentual de aumento. Ao
    //final deverá exibir todas as informações: salário inicial, percentual de aumento, valor do aumento e valor
    //do novo salário
    public class Calculadora
    {
        //double aux;
        public double CalculaAumento(double inicial, double percentual)
        {
            //aux = inicial + (inicial * (percentual / 100));
            return inicial + (inicial * (percentual / 100));

        }
        public double CalculaDiferenca(double inicial, double percentual)
        {
            return  CalculaAumento(inicial, percentual) - inicial;
        }
        
    }
   
    
}   
