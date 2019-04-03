using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace Proyecto_Programacion_I
{

    class Program
    {
        #region Variables Publicas
        public static int vRespuesta, vMoralidad = 0;
        public static bool vNina;
        public static string vNombre, vColorConsola;
        #endregion

        static void Main(string[] args)
        {
            Titulo();
            Console.Clear();
            Menu();

            switch (vRespuesta)
            {
                case 1:
                    Juego();
                    break;
                case 2:
                    Galeria();
                    break;
                case 3:
                    GameOver();
                    Environment.Exit(0);
                    break;
            }

            //Metodo para el Menu Principal
            void Menu()
            {
                Console.WriteLine("1. Comenzar el Juego");
                Console.WriteLine("2. Galeria");
                Console.WriteLine("3. Salir del Juego");
                vRespuesta = Convert.ToInt32(Console.ReadLine());
            }

            //Metodo principal para el juego (Aqui va la historia y las elecciones)
            void Juego()
            {
                Console.Clear();
                Console.Write("Favor introducir el nombre del personaje: ");
                vNombre = Console.ReadLine();
                Thread.Sleep(500);
                Console.Clear();

                Console.WriteLine("En medio de la noche, te levantas y escuchas sonidos como si estuvieran cayendo bombas. Por miedo de");
                Console.WriteLine("no abrir las ventanas, prendes la televisi�n y ves que hay una noticia de que un meteorito impact� ");
                Console.WriteLine("con la Luna y la dej� en pedazos, causando que estos pedazos cayeran en la Tierra, causando desastres");
                Console.WriteLine("naturales como tsunamis y terremotos. La se�al de la televisi�n se empieza a cortar mientras est�n");
                Console.WriteLine("recomendando a aquellas personas que viven en edificios, evacuar la ciudad lo antes posible.");
                Console.WriteLine();
                Thread.Sleep(2000);
                Console.WriteLine("De repente, se escucha una explosi�n, la cual rompe todas las ventanas de los edificios que te lo");
                Console.WriteLine("rodean, y al mismo tiempo, empieza a temblar la tierra y se va la luz. Empieza a temblar el edificio");
                Console.WriteLine("y de lo �ltimo que te enteras es que tu cuerpo se empieza a sentir ligero. Te levantas poco despu�s");
                Console.WriteLine("con un gran dolor de cabeza y piensas que perdiste la vista. Cuando empiezas a sentir tu celular vibrando.");
                Console.WriteLine("Lo sacas de tu bolsillo y ves la pantalla que dice que la bater�a est� baja. Es ah� cuando te das cuenta");
                Console.WriteLine("que no perdiste la vista, sino que todo lo que te rodea est� en plena oscuridad.");
                Console.ReadKey();

                A1();
            }

            #region Arco de Edificio
            void A1()
            {
                Console.WriteLine("Te encuentras en tu habitaci�n e intentas llamar a tu familia, sin embargo no hay se�al. ");
                Console.WriteLine("Lo unico que te llega al celular es una direcci�n de un refugio. All� estan recibiendo ");
                Console.WriteLine("sobrevivientes. Al ver esto, te pones en marcha para salir del edificio. \n");
                Console.WriteLine("Se siente un temblor y tienes miedo de que tu piso no sea lo suficientemente estable.");
                Console.WriteLine("Llegas a las escaleras y no sabes si subir o bajar.\n");
                Thread.Sleep(1500);
                Console.WriteLine("1. Subir al ultimo piso\n");
                Console.WriteLine("2. Bajar al decimo piso");

                vRespuesta = Convert.ToInt32(Console.ReadLine());
                switch (vRespuesta)
                {
                    case 1:
                        A2();
                        break;
                    case 2:
                        //A7();
                        break;
                    default:
                        GameOver();
                        break;
                }
            }
            void A2()
            {
                Console.WriteLine("Pasando el pasillo del decimo piso, te diriges a las escaleras para encontrar la escalera ");
                Console.WriteLine("principal bloqueada por escombros, sin embargo hay un hueco por el cual puedes saltar.");
                Console.WriteLine("Tambi�n, el ascensor se ve en buen estado pero dudas al ver el estado del resto del pasillo.\n");
                Thread.Sleep(1500);
                Console.WriteLine("1. Usar el elevador\n");
                Console.WriteLine("2. Saltar por el hueco");

                vRespuesta = Convert.ToInt32(Console.ReadLine());
                switch (vRespuesta)
                {
                    case 1:
                        Muertes(1);
                        break;
                    case 2:
                        //A4();
                        break;
                    default:
                        GameOver();
                        break;
                }
            }
            #endregion

            //Aqui el juego anota cuales finales se han obtenido y cuales faltan
            void Galeria()
            {

            }
            //Aqui van las muertes y las pueden invocar con Muertes(Numero de muerte a invocar), todas estas terminaran con el juego saltando a la pantalla de Juego Over
            void Muertes(int i)
            {
                switch (i)
                {
                    case 1:
                        Console.WriteLine("te caite por el ascensor. rayos intentalo de nuevo");
                        Thread.Sleep(3500);
                        GameOver();
                        break;

                    default:
                        break;
                }
            }

            // Metodos para cambios de colores, animacion de titulo y de gameover
            #region Metodos de Animacion
            //Los proximos metodos se puedon usar para cambiar el color del fondo(La letra seguira en el color que estaba antes, para metodos de letra usar ForeGroundColor)

            void CambiarVerde()
            {
                Console.BackgroundColor = ConsoleColor.Green;
                Console.Clear();
            }
            void CambiarAzul()
            {
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.Clear();
            }
            void CambiarAmarillo()
            {
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.Clear();
            }
            void CambiarRojo()
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.Clear();
            }
            void CambiarNormal()
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Clear();
            }

            //Animacion para el titulo al abrir la aplicacion
            void Titulo()
            {
                void TituloTexto()
                {
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("          ______     __     ______   __  __        ______     ______     ______     ______     ______   ______    ");
                    Console.WriteLine("         /\\  ___\\   /\\ \\   /\\__  _\\ /\\ \\_\\ \\      /\\  ___\\   /\\  ___\\   /\\  ___\\   /\\  __ \\   /\\  == \\ /\\  ___\\   ");
                    Console.WriteLine("         \\ \\ \\____  \\ \\ \\  \\/_/\\ \\/ \\ \\____ \\     \\ \\  __\\   \\ \\___  \\  \\ \\ \\____  \\ \\  __ \\  \\ \\  _-/ \\ \\  __\\   ");
                    Console.WriteLine("          \\ \\_____\\  \\ \\_\\    \\ \\_\\  \\/\\_____\\     \\ \\_____\\  \\/\\_____\\  \\ \\_____\\  \\ \\_\\ \\_\\  \\ \\_\\    \\ \\_____\\ ");
                    Console.WriteLine("           \\/_____/   \\/_/     \\/_/   \\/_____/      \\/_____/   \\/_____/   \\/_____/   \\/_/\\/_/   \\/_/     \\/_____/ ");
                    Thread.Sleep(500);
                }
                TituloTexto();
                CambiarAzul();
                TituloTexto();
                CambiarNormal();
                TituloTexto();
                CambiarAzul();
                TituloTexto();
                CambiarNormal();
                TituloTexto();
                Thread.Sleep(1500);
            }

            //Animacion de juego terminado
            #region GameOver
            void GameOver()
            {
                void GameOverTexto()
                {
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine(" ______     ______     __    __     ______        ______     __   __   ______     ______    ");
                    Console.WriteLine("/\\  ___\\   /\\  __ \\   /\\ \\ -./  \\   /\\  ___\\      /\\  __ \\   /\\ \\ / /  /\\  ___\\   /\\  == \\   ");
                    Console.WriteLine("\\ \\ \\__ \\  \\ \\  __ \\  \\ \\ \\-./\\ \\  \\ \\  __\\      \\ \\ \\/\\ \\  \\ \\ \\/ /   \\ \\  __\\   \\ \\  __<   ");
                    Console.WriteLine(" \\ \\_____\\  \\ \\_\\ \\_\\  \\ \\_\\ \\ \\_\\  \\ \\_____\\     \\ \\_____\\  \\ \\__/    \\ \\_____\\  \\ \\_\\ \\_\\ ");
                    Console.WriteLine("  \\/_____/   \\/_/\\/_/   \\/_/  \\/_/   \\/_____/      \\/_____/   \\/_/      \\/_____/   \\/_/ /_/ ");
                    Thread.Sleep(500);
                }
                GameOverTexto();
                CambiarRojo();
                GameOverTexto();
                CambiarNormal();
                GameOverTexto();
                CambiarRojo();
                GameOverTexto();
                CambiarNormal();
                GameOverTexto();
                Thread.Sleep(1500);
            }
            #endregion
            #endregion
        }
    }
}


