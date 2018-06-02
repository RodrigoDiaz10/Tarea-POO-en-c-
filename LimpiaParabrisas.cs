using System;

namespace auto
{
    class LimpiaParabrisas
    {
         private string formaLP="Alambre";
         private string materialLP="Aluminio";
         private string marca="Bosch";
         public void Imprimir()
         {
             Console.WriteLine("\nForma del limpiaparabrisas = "+formaLP);
             Console.WriteLine("\nMaterial del limpiaparabrisas = "+materialLP);
             Console.WriteLine("\nMarca"+marca);
         }
    }
}