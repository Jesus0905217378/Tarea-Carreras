using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_Carreras.Clases
{
    internal class Carro
    {
        public string Marca { get; }
        public int Modelo { get; }
        public string Color { get; set; }

        public string owner { get; set; }

        private int Encendido = 0;
        public int velocidad_actual = 0;

        public int MAXVELOCIDAD { get; }



        public Carro(string _marca, int _modelo, string _color, int maxvel)
        {
            Marca = _marca;
            Modelo = _modelo;
            Color = _color;
            Encendido = 0;
            MAXVELOCIDAD = maxvel;
            this.velocidad_actual = 0;
        }

        //construir 2do constructor
        public Carro(String _marca, string _owner, int maxvel =300)
        {
            Marca = _marca;
           // Modelo = _modelo;
           MAXVELOCIDAD = maxvel;
            owner = _owner;
            this.velocidad_actual = 0;
        }

        public int GetVelocidadActual()
        {
            return velocidad_actual;
        }
        public int GetVelocidadActual1()//regresa la velocidad a 0 despues de terminar la manga
        {
            return velocidad_actual = 0;
        }


        public string EncenderMotor()
        {
            if (Encendido == 0)
            {

                Encendido = 1;
                this.velocidad_actual = 0;
                return "run run run run, listo para correr";
            }
            else
            {
                return "Orales!!! ya esta encendido tu carro";
            }
        }


        public string acelerar()
        {
            string mensaje = "";
            if (Encendido == 0)
            {
                mensaje = $"no puedo acelerar con el carro apagado";
                return mensaje;
            }

            velocidad_actual += 10;
            if (velocidad_actual <= MAXVELOCIDAD)
            {
                mensaje = $"Vas a {velocidad_actual} KPH";
            }
            else
            {
                velocidad_actual = MAXVELOCIDAD;
                mensaje = $"{velocidad_actual}KPH   Aguas rapido y furioso, vas muy rapido y ya llegaste al tope";
            }


            return mensaje;

        }




        public string acelerar(int CuantosKPH)
        {
            string mensaje = "";
            if (Encendido == 0)
            {
                mensaje = $"no puedo acelerar con el carro apagado";
                return mensaje;
            }

            velocidad_actual += CuantosKPH;
            if (velocidad_actual <= MAXVELOCIDAD)
            {
                mensaje = $"{velocidad_actual} KPH";
            }
            else
            {
                velocidad_actual = MAXVELOCIDAD;
                mensaje = $"{velocidad_actual}KPH   Aguas rapido y furioso, vas muy rapido y ya llegaste al tope";
            }


            return mensaje;

        }


    }
}