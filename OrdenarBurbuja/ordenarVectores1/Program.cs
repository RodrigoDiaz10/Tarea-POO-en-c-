using System;
using System.Collections.Generic;

namespace ordenarVectores1
{
    public class Program
    {
        public static void Main (){
            // ingreso de los datos a la lista desordenada
            List<int> listaDesordenada= new List<int>();
            List<int> listaOrdenada=new List<int>();
            listaDesordenada.Add(3);
            listaDesordenada.Add(1);
            listaDesordenada.Add(5);
            listaDesordenada.Add(2);
            listaDesordenada.Add(4);
            foreach (int listasDesordenada in listaDesordenada)
            {
                Console.WriteLine(listasDesordenada);
                //Console.WriteLine(listaDesordenada.Count);
            }
            var imenor=0;
            while (listaDesordenada.Count>0)
            {
                
                for (int i = 0; i < listaDesordenada.Count; i++)
                {
                    if (listaDesordenada[i]<listaDesordenada[imenor])
                    {
                        imenor=i;
                    }
                }
               listaOrdenada.Add(listaDesordenada[imenor]);
               listaDesordenada.Remove(listaDesordenada[imenor]);  
               Console.WriteLine(listaOrdenada);
            }
           /* 
            foreach (int listasOrdenada in listaOrdenada)
            {
                Console.WriteLine(listasOrdenada);
                
            }*/
        }
        
        
    }
}
