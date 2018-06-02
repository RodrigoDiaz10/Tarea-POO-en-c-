using System;

namespace auto
{
    class Motor
    {
         public double cilindrajeMotor;
         public string construccionMotor;
         public int numeroCilindros;
         public void Mostrar()
         {
             Console.WriteLine("motor en marcha");
             Console.WriteLine("\nCilindraje del Motor = "+cilindrajeMotor);
             Console.WriteLine("\nTipo de construccion del motor = "+construccionMotor);
             Console.WriteLine("\nNumero de cilindros="+numeroCilindros);
         }
    }
}