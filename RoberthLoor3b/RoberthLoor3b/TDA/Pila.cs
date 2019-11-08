using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace RoberthLoor3b.TDA
{
    public class Pila
    {
        

        //CREAMOS UNA PILA 
        Stack<String> pila = new Stack<string>();
     
        //CREAMOS LOS ATRIBUTOS CON LOS DATOS A NESESITAR PARA LA EJECUCION DEL SWITCH


        private String date;

        public String Date
        {
            get { return date; }
            set { date = value; }
        }

        /*METODO PARA PODER APILAR LOS DATOS PROPUESTOS EN LA PILA*/

        public void Apilar() {
            Pila pilita = new Pila();
            Console.Write("\t\tDigite elemento destinado a añadirse a la Pila "); pilita.Date = Convert.ToString(Console.ReadLine());
            pila.Push(pilita.Date);
        }


        /*METODO PARA PODER IMPRIMIR LOS DATOS ALMACENADOS EN LA PILA*/

        public void Imprimir() {
            foreach (String DatosDeLaPila in pila)
            {
                if (DatosDeLaPila != null)
                {
                    Console.Write("\t\tDato: ");
                    Console.WriteLine("\t"+DatosDeLaPila);
                }
           
                }
            }
        /*METODO PARA PODER DESAPILAR UNO A UNO LOS DATOS ALMACENADOS EN LA PILA*/

        public void Desapilar() {
            Console.WriteLine("\t\tEl dato desapilado fue: "+pila.Pop());
        
        
        }
        /*METODO PARA PODER MOSTRAR LA CIMA EN LA PILA*/
        public void Cima() {
            if (pila != null)
            {
                Console.WriteLine("\t\t\t Cima: " + pila.Peek());
            }
            else { Console.Write("La cola esta vacia"); }

        }

    }

}

