using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RoberthLoor3b.TDA;
using System.Collections;

namespace RoberthLoor3b
{
    class Program
    {
        static void Main(string[] args)
        {
            Pila pila = new Pila();
            Cola cola = new Cola();
            Opciones op = new Opciones();//Constructor de la clase Opciones


            Console.Write("\t\t\t\tTAREA TDA COLA TDA PILA");
            Console.WriteLine("\n\t\tIngrese el numero correspondiente al tipo de TDA con el que " +
                "\n\t\tdesea trabajar" +
                "\n\t\t\t (1).- PILA" +
                "\n\t\t\t (2).- COLA" +
                "\n\t\t\t (3).- SALIR");
            Console.Write("\t\t\t\tOpcion: ");
            op.Option = Convert.ToByte(Console.ReadLine());
      /*---------------------------------------------------------------------------------------------------------------------------------------*/
             if (op.Option == 1)
             {
                 Console.Clear();
                 do
                 {
                     Console.WriteLine("\t\t-------------------------------------------------------");
                     Console.WriteLine("\t\t|\t\t\tTDA PILA ORIENTADA A OBJETOS");

                     Console.WriteLine("\t\t|Ingrese opcion:" +
                                         "\n\t\t|\t(1) Apilar datos (String) en la Pila" +
                                         "\n\t\t|\t(2) Imprimir datos (String) de la Pila:" +
                                         "\n\t\t|\t(3) Desapilar datos (String) de la pila" +
                                         "\n\t\t|\t(4) Mostrar la cima o tope (String) de la pila");
                     Console.Write("\t\t|\t\t\tOption: ");op.OptionPila = Convert.ToByte(Console.ReadLine());
                     Console.WriteLine("\t\t-------------------------------------------------------");
                     switch (op.OptionPila)
                     {
                         case 1: pila.Apilar();
                             break;
                         case 2: pila.Imprimir();break;
                         case 3: pila.Desapilar(); break;
                        case 4:  pila.Cima();  break;
                             }
                 } while (op.Option != 7); 
             }
      /*---------------------------------------------------------------------------------------------------------------------------------------*/

            if (op.Option == 2)
            {
                Console.Clear();
                do
                {

                    Console.WriteLine("\t\t-------------------------------------------------------");
                    Console.WriteLine("\t\t|\t\t\tTDA COLA ORIENTADA A OBJETOS");

                    Console.WriteLine("\t\t|Ingrese opcion:" +
                                        "\n\t\t|\t(1) Encolar datos (String) en la Cola" +
                                        "\n\t\t|\t(2) Imprimir datos (String) de la Cola:" +
                                        "\n\t\t|\t(3) Desencolar datos (String) de la Cola" +
                                        "\n\t\t|\t(4) Mostrar la cima o tope de la Cola");

                    Console.Write("\t\t|\t\t\tOption: "); op.Optioncola = Convert.ToByte(Console.ReadLine());
                    Console.WriteLine("\t\t-------------------------------------------------------");


                    switch (op.Optioncola)
                    {
                        case 1: cola.Encolar(); break;
                        case 2: cola.Imprimir(); break;
                        case 3: cola.Desencolar(); break;
                        case 4: cola.Cima(); break;
                    }
                } while (op.Option != 7);
            }
            else { Console.ReadKey(); }
        }
    }
}
