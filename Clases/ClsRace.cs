using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_Carreras.Clases
{
    internal class ClsRace
    {
        private Carro CarroA;
        private Carro CarroB;
        private Carro CarroC;
        int contadorA = 0, contadorB = 0, contadorC = 0; //contaador para acumular las mangas ganadas

        public void PedirDatosCarrera()
        {



            CarroA = GetData();
            Console.WriteLine("Ahora datos del B");
            CarroB = GetData();
            Console.WriteLine("Ahora datos del C");
            CarroC = GetData();
        }

        public void IniciarCarrera()
        {
            string msgCarroA, msgCarroB, msgCarroC;
            
            Random velRandom = new Random();
            



            msgCarroA = CarroA.EncenderMotor();
            msgCarroB = CarroB.EncenderMotor();
            msgCarroC = CarroC.EncenderMotor();
            Console.WriteLine($"{CarroA.Marca} {msgCarroA}");
            Console.WriteLine($"{CarroB.Marca} {msgCarroB}");
            Console.WriteLine($"{CarroC.Marca} {msgCarroC}");


            for (int i = 0; i < 10; i++)
            {
                int acelera;
                acelera = velRandom.Next(1, 21);
                msgCarroA = CarroA.acelerar(acelera);
                acelera = velRandom.Next(1, 21);
                msgCarroB = CarroB.acelerar(acelera);
                acelera = velRandom.Next(1, 21);
                msgCarroC = CarroC.acelerar(acelera);
                Console.WriteLine($"{i + 1}- {CarroA.owner}:{msgCarroA}  {CarroB.owner}:{msgCarroB}  {CarroC.owner}:{msgCarroC}");
               
            }

            if (CarroA.GetVelocidadActual() > CarroB.GetVelocidadActual())
            {
                if (CarroA.GetVelocidadActual() > CarroC.GetVelocidadActual())
                {
                    Console.WriteLine($"{CarroA.owner} Wins!!!");
                    contadorA++;
                }
            }

            else
            {
                if (CarroB.GetVelocidadActual() > CarroC.GetVelocidadActual())
                {
                    Console.WriteLine($"{CarroB.owner} Wins!!!");
                    contadorB++;
                }
                else
                {
                    Console.WriteLine($"{CarroC.owner} Wins!!!");
                    contadorC++;
                }

            }
            CarroA.GetVelocidadActual1();
            CarroB.GetVelocidadActual1();
            CarroC.GetVelocidadActual1();
        }

        // Evaluar al ganador 

        public void Ganador()
        {
            if (contadorA > contadorB)
            {
                if (contadorA > contadorC)
                Console.WriteLine($"{CarroA.owner} Es el Ganador de las mangas");
            }
            else
            {
                if (contadorB > contadorC)
                {
                    Console.WriteLine($"{CarroB.owner} Es el Ganador de las mangas");
                }
                else
                {
                    Console.WriteLine($"{CarroC.owner} Es el Ganador de las mangas");
                }
            }
        }


        private Carro GetData()
        {
            string marca;
            string propietario;
            Carro carrotemporal;

            Console.WriteLine("Ingrese marca");
            marca = Console.ReadLine();
            Console.WriteLine("Propietario:");
            propietario = Console.ReadLine();

            carrotemporal = new Carro(marca, propietario);
            return carrotemporal;
        }

    }
}