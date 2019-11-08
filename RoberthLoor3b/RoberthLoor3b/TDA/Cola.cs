using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoberthLoor3b.TDA
{
    public class Cola
    {
        //CREAMOS UNA COLA 

        Queue<String> cola = new Queue<String>();
        //DE LA MISMA MANERA QUE LA PILA, TRABAJAREMOS CON UN DATO
        private String date2;
        public String Date2
        {
            set { date2 = value; }
            get { return date2; }
        }
        /*METODO ENCARGADO DE ENCOLAR LOS DATOS DE TIPO STRING. */
        public void Encolar()
        {
            Cola colita = new Cola();
            Console.Write("\t\tDigite elemento destinado a añadirse a la Cola: "); colita.Date2 = Convert.ToString(Console.ReadLine());
            cola.Enqueue(colita.Date2);
        }
        /*METODO ENCARGADO DE DESENCOLAR LOS DATOS UNO A UNO DE LA COLA DE TIPO STRING. */

        public void Desencolar()
        {
            Console.WriteLine("\t\tEl dato desencolado fue: " + cola.Dequeue());
        }

        /*METODO ENCARGADO DE IMPRIMIR LOS DATOS DE LA COLA DE TIPO STRING. */

        public void Imprimir()
        {
            foreach (string DatosDeLaCola in cola)
            {
                
                if (DatosDeLaCola != null)
                {
                    Console.WriteLine("\t\t\tDato: "+DatosDeLaCola);
                }
               
            }
        }
        /*METODO ENCARGADO DE IMPRIMIR EL DATO QUE ESTA EN LA CIMA DE LA COLA DE TIPO STRING. */
        public void Cima() {
            if (cola != null)
            {
                Console.WriteLine("\t\t\t Cima: " + cola.Peek());
            }
            else { Console.Write("La cola esta vacia"); }
        }



    }
}

