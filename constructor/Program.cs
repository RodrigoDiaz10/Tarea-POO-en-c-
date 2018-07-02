using System;
using System.Collections.Generic;

namespace constructor
{
  
public class Carro
{
   private string Nombre;
   private string Placa;
   
   public Carro(string NameC="chevrolet", string PlacaC="455")
   {
      Nombre = NameC;
      Placa = PlacaC; 
   }
   
   // Remaining implementation of Person class.
}
}

/*using System;

namespace constructor
{
    class Program
    {
       int silindaje=0;

    //interface Iordenada<T>
    //{ 
         Comparar(carro c1,c2)
        {
            if(c1.silindaje<c2.silindaje)
            {
            return -1;
            } 
            if(c1.silindaje==c2.silindaje)
            {
            return 0;
            } 
            return 1;
            } 
        }
    

    void ordenar(list<carros> ld)
    {
        while(ld.count()>0)
        {
            var imenor=0;
            for(int i=0;i<ld.count();i++)
            {
                resultado=igual(ld[i],ld[imenor]);
                if(resultado=-1){
                    imenor=i;
                }
                var intercambio=ld[i];
                ld[i]=ld[imenor];
                ld[imenor]=intercambio;
            }
            return ld;
        }
    }
 
    }*/
    
//}
