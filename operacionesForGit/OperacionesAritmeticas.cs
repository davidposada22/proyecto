﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operacionesForGit
{
    class OperacionesAritmeticas
    {
        //Atributos de la class
        public short nUno, nDos;

        //Metodos
        public void Sumar(short numeroUno, short numeroDos)
        {
            short sumarNumeros = 0;
            sumarNumeros = (short)(numeroUno + numeroDos);
            Console.WriteLine("Resultado de la suma: " + sumarNumeros);

        }

        //en la class Program vamos a invocar esta clase para utilizar sus atributos y el metodo creado
    }
}
