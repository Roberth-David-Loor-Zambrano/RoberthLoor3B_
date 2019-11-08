using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoberthLoor3b.TDA
{
    public class Opciones
    {
        //ESTA CLASE ES UNICAMENTE PARA CREAR PARAMETROS QUE CONTENGAN LAS OPCIONES A ELEGIR EN EL SWICHT PRINSIPAL
        //YA QUE POS ESTETICA NO QUISE AÑADIRLO EN LA CLASE DE PILA, COLA O PEOR AUN EN EL MAIN

        //VARIABLE PARA EL MENU PRINSIPAL:
        private byte option;

        public byte Option
        {
            get { return option; }
            set { option = value; }
        }



        //VARIABLE PARA EL MENU DE LA PILA
        private byte optionpila;

        public byte OptionPila
        {
            get { return optionpila; }
            set { optionpila = value; }
        }
        //VARIABLE PARA EL MENU DE LA COLA:
        private byte optioncola;

        public byte Optioncola
        {
            get { return optioncola; }
            set { optioncola = value; }
        }
     


    }
}
