using System;

namespace auto
{
    class Parachoque
    {
         public string materialPa="Hierro A36";
         public string grosorPa="3mm";
         public void Imprimir()
         {
             Console.WriteLine("\nMaterial de construccion del Parachoques = "+materialPa);
             Console.WriteLine("\nGrosor del Parachoques = "+grosorPa);
         }
    }
}