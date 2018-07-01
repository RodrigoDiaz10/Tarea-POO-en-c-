using System;

namespace auto
{
    class Volante
    {
         public int diametroMilimetros;
         public string materialVolante;
         public void Imprimir()
         {
             Console.WriteLine("\nDiametro del Volante = "+diametroMilimetros);
             Console.WriteLine("\nMaterial del Volante = "+materialVolante);
         }
    }
}