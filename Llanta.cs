using System;

namespace auto
{
    class Llanta
    {
         public int anchoLlantasMilimetros;
         public int altoLlantaMilimetros;
         public string a;
         public int diametroLlantaPulgadas;
         public int indiceCargaNeumatico;
         public void Muestra()
         {
             Console.WriteLine("llanta en movimiento");
             Console.WriteLine("\nAncho="+anchoLlantasMilimetros);
             Console.WriteLine("\nAlto="+altoLlantaMilimetros);
             Console.WriteLine("\nRadial/Diagonal="+a);
             Console.WriteLine("\nDiametro="+diametroLlantaPulgadas);
             Console.WriteLine("\nIndice de carga del neumatico="+indiceCargaNeumatico);
         }
    }
}