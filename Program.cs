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
        public static int vRespuesta, vMoralidad = 0, vCall = 0, vTiempo = 0;
        public static bool vNina, vBaja = false;
        public static string vNombre;
        #endregion

        static void Main(string[] args)
        {
            Titulo();
            Console.Clear();
            Menu();
            
            //Metodo para el Menu Principal
            void Menu()
            {
                Console.WriteLine("City Escape v1.0");
                Console.WriteLine();
                Console.WriteLine("1. Comenzar el Juego");
                Console.WriteLine("2. Salir del Juego");
                vRespuesta = Convert.ToInt32(Console.ReadLine());
                switch (vRespuesta)
                {
                    case 1:
                        Juego();
                        break;
                    case 2:
                        GameOver();
                        Environment.Exit(0);
                        break;
                }
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
                Console.WriteLine("no abrir las ventanas, prendes la televisión y ves que hay una noticia de que un meteorito impactó ");
                Console.WriteLine("con la Luna y la dejó en pedazos, causando que estos pedazos cayeran en la Tierra, causando desastres");
                Console.WriteLine("naturales como tsunamis y terremotos. La señal de la televisión se empieza a cortar mientras están");
                Console.WriteLine("recomendando a aquellas personas que viven en edificios, evacuar la ciudad lo antes posible.");
                Console.WriteLine();
                Thread.Sleep(2000);
                Console.WriteLine("De repente, se escucha una explosión, la cual rompe todas las ventanas de los edificios que te lo");
                Console.WriteLine("rodean, y al mismo tiempo, empieza a temblar la tierra y se va la luz. Empieza a temblar el edificio");
                Console.WriteLine("y de lo último que te enteras es que tu cuerpo se empieza a sentir ligero. Te levantas poco después");
                Console.WriteLine("con un gran dolor de cabeza y piensas que perdiste la vista. Cuando empiezas a sentir tu celular vibrando.");
                Console.WriteLine("Lo sacas de tu bolsillo y ves la pantalla que dice que la batería está baja. Es ahí cuando te das cuenta");
                Console.WriteLine("que no perdiste la vista, sino que todo lo que te rodea está en plena oscuridad.");
                Console.WriteLine("\nPresiona cualquier tecla para continuar...");
                Console.ReadKey();
                D1();
                A2();
            }

            #region Decisiones
            void A2()
            {
                D2();
                Thread.Sleep(1000);
                Console.WriteLine("Se siente un temblor y tienes miedo de que tu piso no sea lo suficientemente estable.");
                Console.WriteLine("Llegas a las escaleras y no sabes si subir o bajar.\n");
                Thread.Sleep(1500);
                Console.WriteLine("1. Subir al ultimo piso");
                Console.WriteLine("2. Bajar al decimo piso");

                vRespuesta = Convert.ToInt32(Console.ReadLine());
                switch (vRespuesta)
                {
                    case 1:
                        Console.Clear();
                        A8();
                        break;
                    case 2:
                        Console.Clear();
                        vBaja = true;
                        A3();
                        break;
                    default:
                        Console.Clear();
                        A2();
                        break;
                }
            }
            void A3()
            {
                Console.WriteLine("Pasando el pasillo del decimo piso, te diriges a las escaleras para encontrar la escalera ");
                Console.WriteLine("principal bloqueada por escombros, sin embargo hay un hueco por el cual puedes saltar.");
                Console.WriteLine("También, el ascensor se ve en buen estado pero dudas al ver el estado del resto del pasillo.\n");
                Thread.Sleep(1500);
                Console.WriteLine("1. Usar el elevador");
                Console.WriteLine("2. Saltar por el hueco");

                vRespuesta = Convert.ToInt32(Console.ReadLine());
                switch (vRespuesta)
                {
                    case 1:
                        Console.Clear();
                        Muertes(1);

                        break;
                    case 2:
                        Console.Clear();
                        A4();
                        break;
                    default:
                        Console.Clear();
                        A3();
                        break;
                }
            }

            void A4()
            {
                Console.WriteLine("Luego de saltar por el hueco, se oye el sonido del ascensor cayendo e impactando con el ");
                Console.WriteLine("suelo, lo cual causa que tiemblen los escombros del edificio. Ahora te encuentras en la tercera ");
                Console.WriteLine("novena del edificio, donde escuchas un sonido de una niña llorando y tosiendo.\n");
                Thread.Sleep(1500);
                Console.WriteLine("1. Ir a buscar a la niña");
                Console.WriteLine("2. Seguir bajando las escaleras");

                vRespuesta = Convert.ToInt32(Console.ReadLine());
                switch (vRespuesta)
                {
                    case 1:
                        Console.Clear();
                        D3();
                        vNina = true;
                        A5();
                        break;
                    case 2:
                        Console.Clear();
                        A5();
                        break;
                    default:
                        Console.Clear();
                        A4();
                        break;
                }
            }

            void A5()
            {
                if (vNina == true)
                {
                    Console.WriteLine("La niña esta en shock y no puede sacar palabras de su boca, pero acepta seguirte.");
                }
                Console.WriteLine(" Continúas bajando hasta que llegas al septimo piso, pero la escalera ahora está completamente ");
                Console.WriteLine(" bloqueada y tu único camino es subir de nuevo.\n");
                Thread.Sleep(1500);
                Console.WriteLine("1. Volver hacia arriba");
                Console.WriteLine("2. Intentar mover escombros");
                vRespuesta = Convert.ToInt32(Console.ReadLine());
                switch (vRespuesta)
                {
                    case 1:
                        Console.Clear();
                        A6();
                        break;
                    case 2:
                        Console.Clear();
                        Amini5();
                        break;
                }
            }
            void Amini5()
            {
                Console.WriteLine("Mueves algunos escombros pero no ves mucho progreso...\n");
                Console.WriteLine("1. Volver a intentarlo");
                Console.WriteLine("2. Volver hacia arriba");

                vTiempo++;

                if (vTiempo == 4)
                    Muertes(5);

                vRespuesta = Convert.ToInt32(Console.ReadLine());
                switch (vRespuesta)
                {
                    case 1:
                        Console.Clear();
                        Amini5();
                        break;
                    case 2:
                        Console.Clear();
                        A6();
                        break;
                    default:
                        Console.Clear();
                        Amini5();
                        break;
                }
            }
            void A6()
            {
                Console.WriteLine("Subes de nuevo y estas en el onceavo piso. Escuchas un sonido por la ventana.\n");
                Thread.Sleep(1500);
                Console.WriteLine("1. Vas en dirección a donde se escucha el sonido");
                Console.WriteLine("2. Seguir subiendo");

                vRespuesta = Convert.ToInt32(Console.ReadLine());
                switch (vRespuesta)
                {
                    case 1:
                        Console.Clear();
                        Muertes(2);
                        break;
                    case 2:
                        Console.Clear();
                        A7();
                        break;
                    default:
                        Console.Clear();
                        A6();
                        break;
                }
            }

            void A7()
            {
                if (vNina == true)
                {
                    Console.WriteLine("En el mismo onceavo piso encuentras la cocina comunal y hambriento buscas dentro de la ");
                    Console.WriteLine("nevera la cual irónicamente se encuentra completamente bien. Dentro encuentras una sola ");
                    Console.WriteLine("manzana. \n");
                    Thread.Sleep(1500);
                    Console.WriteLine("1. Compartir la manzana");
                    Console.WriteLine("2. Comertela en frente de la niña");

                    vRespuesta = Convert.ToInt32(Console.ReadLine());
                    switch (vRespuesta)
                        {
                            case 1:
                                Console.Clear();
                                A8();
                                break;
                            case 2:
                                Console.Clear();
                                vMoralidad -= 1/2;
                                A8();
                                break;
                            default:
                                Console.Clear();
                                A7();
                                break;
                        }
                }
                else A8();
            }

            void A8()
            {
                Console.WriteLine("En el catorceavo piso, encuentras de que se ha creado un rampa desde tu edificio hacia el ");
                Console.WriteLine("otro, se ve peligroso caminar por las paredes de lo que era el quinceavo piso pero crees que lo ");
                Console.WriteLine("puedes lograr.\n ");
                Thread.Sleep(1500);
                if (vBaja == false)
                {
                    Console.WriteLine("1. Bajar de nuevo al edificio");
                    Console.WriteLine("2. Intentar cruzar");

                    vRespuesta = Convert.ToInt32(Console.ReadLine());
                    switch (vRespuesta)
                    {
                        case 1:
                            Console.Clear();
                            vTiempo += 2;
                            Console.WriteLine("Te devuelves por las escaleras hasta que llegas al decimo piso");
                            A3();
                            break;
                        case 2:
                            Console.Clear();
                            A9();
                            break;
                        default:
                            Console.Clear();
                            A8();
                            break;
                    }
                }
                else
                {
                    A9();
                }
            }

            void A9()
            {
                Console.WriteLine("Llegas al otro edificio sano y salvo y encuentras que este edificio tiene energia. Una alerta de ");
                Console.WriteLine("tu celular te avisa que estas en 10% de bateria.\n");
                Thread.Sleep(1500);
                Console.WriteLine("1. Cargar el celular");
                Console.WriteLine("2. Seguir bajando del edificio");

                vRespuesta = Convert.ToInt32(Console.ReadLine());
                switch (vRespuesta)
                {
                    case 1:
                        Console.Clear();
                        A10();
                        break;
                    case 2:
                        Console.Clear();
                        A12();
                        break;
                    default:
                        Console.Clear();
                        A9();
                        break;
                }
            }
            void A10()
            {
                Console.WriteLine("De repente, se escucha una explosión, la cual rompe todas las ventanas de los edificios que te lo");
                Console.WriteLine("Luego de 10 minutos de cargar tu celular, la batería está en 70%.\n");
                Thread.Sleep(1500);
                Console.WriteLine("1. Cargar el celular");
                Console.WriteLine("2. Seguir bajando el edificio");
                vRespuesta = Convert.ToInt32(Console.ReadLine());
                switch (vRespuesta)
                {
                    case 1:
                        Console.Clear();
                        A11();
                        break;
                    case 2:
                        Console.Clear();
                        A12();
                        break;
                    default:
                        Console.Clear();
                        A10();
                        break;
                }
            }
            void A11()
            {
                Console.WriteLine("Con tu celular completamente cargado, notas que tienes un barra de señal y te llegan esperanzas de ");
                Console.WriteLine("escuchar a tu familia.\n");
                Thread.Sleep(1500);
                Console.WriteLine("1. Llamar a tu familia para ver si estan bien");
                Console.WriteLine("2. Seguir bajando el edificio");

                vRespuesta = Convert.ToInt32(Console.ReadLine());
                switch (vRespuesta)
                {
                    case 1:
                        Console.Clear();
                        EE1();
                        break;
                    case 2:
                        Console.Clear();
                        A12();
                        break;
                    default:
                        Console.Clear();
                        A11();
                        break;
                }
            }
            void A12()
            {
                if (vNina == true)
                {
                    Console.WriteLine("Cuando están bajando del edificio, notas que la niña tiene una cara de desesperación. Le preguntas que");
                    Console.WriteLine("qué le pasa y te dice que tiene que ir al baño urgentemente.\n");
                    Thread.Sleep(1500);
                    Console.WriteLine("1. Dejar a la niña ir al baño");
                    Console.WriteLine("2. Decir que no hay tiempo y continuar bajando el edificio");

                    vRespuesta = Convert.ToInt32(Console.ReadLine());
                    switch (vRespuesta)
                    {
                        case 1:
                            Console.Clear();
                            A13();
                            break;
                        case 2:
                            Console.Clear();
                            vMoralidad -= 1 / 2;
                            A13();
                            break;
                        default:
                            Console.Clear();
                            A12();
                            break;
                    }
                }
                else A14();
            }
            void A13()
            {
                D4();
                Console.WriteLine("Tu y la niña corren hasta alejarse lo suficiente del edificio que se esta cayendo. Después de varios ");
                Console.WriteLine("minuto corriendo, se paran a descansar. Cuando se sientan a descansar, la niña te dice su nombre. ");
                Console.WriteLine("'Joelia', dice la niña. Te presentas y le dices que te llamas {0}. Luego de presentarse, la niña ");
                Console.WriteLine("te dice que sus padres están trabajando hasta tarde y que no sabe donde estan y quisiera llamarlos ");
                Console.WriteLine("para hablar con ellos.\n", vNombre);
                Thread.Sleep(1500);
                Console.WriteLine("1. Le prestas el celular para que llame a sus padres");
                Console.WriteLine("2. Decir que no, ya que no hay señal y deben ir al refugio lo antes posible");

                vRespuesta = Convert.ToInt32(Console.ReadLine());
                switch (vRespuesta)
                {
                    case 1:
                        Console.Clear();
                        A15();
                        break;
                    case 2:
                        Console.Clear();
                        Final(4);
                        break;
                    default:
                        Console.Clear();
                        A13();
                        break;
                }
            }
            void A14()
            {
                D4();
                Console.WriteLine("Empiezas a correr para alejarte lo suficientemente del edificio que se esta cayendo. Luego de varios minutos");
                Console.WriteLine("corriendo, te paras a descansar. A la distancia puedes ver un grupo de militares rodeando un carro con una familia");
                Console.WriteLine("claramente angustiada.\n");
                Thread.Sleep(1500);
                Console.WriteLine("1. Acercarte a los militares y pedir que te ayuden");
                Console.WriteLine("2. Seguir tu camino hacia la direccion del refugio");

                vRespuesta = Convert.ToInt32(Console.ReadLine());
                switch (vRespuesta)
                {
                    case 1:
                        Console.Clear();
                        A16();
                        break;
                    case 2:
                        Console.Clear();
                        A19();
                        break;
                    default:
                        Console.Clear();
                        A14();
                        break;
                }
            }
            void A15()
            {
                Console.WriteLine("La nina te pasa tu celular como para que hables con alguien. Cuando lo tomas, empiezas a escuchar una voz femenina.");
                Console.WriteLine("Es la madre de Joelia! Esta te empieza a dar la direccion y te dice que vayas lo mas antes posible.\n");
                Thread.Sleep(1500);
                Console.WriteLine("1. Dirigirte hacia la direccion que te dio la madre de Joelia");
                Console.WriteLine("2. Seguir hacia la direccion del refugio");

                vRespuesta = Convert.ToInt32(Console.ReadLine());
                switch (vRespuesta)
                {
                    case 1:
                        Console.Clear();
                        if (vMoralidad == -1)
                            Final(2);
                        else Final(1);
                        break;
                    case 2:
                        Console.Clear();
                        Muertes(3);
                        break;
                    default:
                        Console.Clear();
                        A15();
                        break;
                }
            }
            void A16()
            {
                Console.WriteLine("Al acercarte a los militares, estos te miran sospechosamente y te interrogan del por que");
                Console.WriteLine("estas aqui. Del carro sale una mujer alarmada y te pregunta sobre el paradera de una tal Joelia,");
                Console.WriteLine("pregunta a la cual no sabes qué decir. Esta te explica que estaba en el mismo edificio que ");
                Console.WriteLine("vivias: (si no bajaste a la planta baja: “respondes que no viste ninguna niña”)");
                Thread.Sleep(1500);
                if (vBaja == true)
                {
                    Console.WriteLine("1. Explicar la situación sobre la voz que oiste en el edificio");
                    Console.WriteLine("2. Actuar que no oiste ninguna niña en el edificio");

                    vRespuesta = Convert.ToInt32(Console.ReadLine());
                    switch (vRespuesta)
                    {
                        case 1:
                            Console.Clear();
                            Muertes(4);
                            break;
                        case 2:
                            Console.Clear();
                            A17();
                            break;
                        default:
                            Console.Clear();
                            A16();
                            break;
                    }
                }
                else
                {
                    Thread.Sleep(1500);
                    Console.WriteLine();
                    Console.WriteLine("Sin embargo, no viste ninguna niña en tu edificio y solo respondes que no viste ninguna niña");
                    Console.WriteLine("Entristecida, la que crees que es la madre de Joelia, entra al carro y los militares prontamente te dejan irte");
                    Thread.Sleep(1000);
                    A19();
                }
            }

            void A17()
            {
                Console.WriteLine("Los militares pronto te interrogan al ver que dudaste bastante en responder");
                Thread.Sleep(1500);
                Console.WriteLine("1. Admitir tu mentira");
                Console.WriteLine("2. Seguir mintiendo");

                vRespuesta = Convert.ToInt32(Console.ReadLine());
                switch (vRespuesta)
                {
                    case 1:
                        Console.Clear();
                        Muertes(4);
                        break;
                    case 2:
                        Console.Clear();
                        A18();
                        break;
                    default:
                        Console.Clear();
                        A17();
                        break;
                }
            }

            void A18()
            {
                Console.WriteLine("Los militares estan dudosos pero te dejan ir con una advertencia, la madre de Joelia se rompe");
                Console.WriteLine("a gritos y se entra de nuevo al carro.");
                Thread.Sleep(1500);
                Console.WriteLine("1. Volver y confesar tus crimenes");
                Console.WriteLine("2. Seguir tu camino hacia el refugio");

                vRespuesta = Convert.ToInt32(Console.ReadLine());
                switch (vRespuesta)
                {
                    case 1:
                        Console.Clear();
                        Muertes(4);
                        break;
                    case 2:
                        Console.Clear();
                        A19();
                        break;
                    default:
                        Console.Clear();
                        A18();
                        break;
                }
            }

            void A19()
            {
                Console.WriteLine("Llegas al refugio en el cual te encuentras un perimetro militar pero te reciben con puertas abiertas");
                Final(3);
            }
            #endregion

            #region Enunciados
            void D1()
            {
                Console.Clear();
                Console.WriteLine("Te encuentras en tu habitación e intentas llamar a tu familia, sin embargo no hay señal. Lo unico que te llega");
                Console.WriteLine("al celular es una dirección de un refugio. Allí estan recibiendo sobrevivientes. Al ver esto, te pones en ");
                Console.WriteLine("marcha para salir del edificio.");

            }
            void D2()
            {
                Thread.Sleep(1000);
                Console.WriteLine();
                Console.WriteLine("Luego de levantarte, te das cuenta de que el edificio está de lado, pero no lo suficiente como para que no ");
                Console.WriteLine("puedas caminar.\n");

            }
            void D3()
            {
                Console.WriteLine("Te diriges al apartamento en el que escuchas a la niña y la ves escondida debajo de la cama. Le preguntas que");
                Console.WriteLine("si quiere ir contigo, a lo cual responde que sí. Luego de que la niña sale de abajo de la cama, ambos se ");
                Console.WriteLine("dirigen hacia las escaleras para bajar al primer piso.\n");
            }
            void D4()
            {
                Console.WriteLine("Ya cuando llegas al último piso, sales del edificio y observas la catástrofe que ha causado este evento.");
                Console.WriteLine("Los carros están en llamas, las calles están destruidas, los cables de los postes están en el suelo ");
                Console.WriteLine("y escombros por todos lados.");
                Console.WriteLine("De repente, empieza a temblar la tierra y ves que tu edificio se empieza a mover como que se va a caer.\n");

                Console.Clear();
            }
            #endregion

            #region EasterEgg
            void EE1()
            {
                vCall++;
                Console.WriteLine("No responden. \n");

                switch (vCall)
                {
                    case 1:
                        Console.WriteLine("1. Volver a intentar");
                        break;
                    case 2:
                        Console.WriteLine("1. Llamar por ultima vez");
                        break;
                    case 3:
                        Console.WriteLine("1. Ok. Esta es la ultima.");
                        break;
                    case 4:
                        Console.WriteLine("1. Si vuelves a llamar te derrumbo el edificio");
                        break;
                    case 5:
                        Console.WriteLine("1. No digas que no te lo adverti");
                        break;
                }
                Console.WriteLine("2. Seguir bajando el edificio");

                vRespuesta = Convert.ToInt32(Console.ReadLine());
                switch (vRespuesta)
                {
                    case 1:
                        Console.Clear();
                        if (vCall == 5)
                        {
                            EE2();
                        }
                        else
                        {
                            EE1();
                        }
                        break;
                    case 2:
                        Console.Clear();
                        A12();
                        break;
                    default:
                        Console.Clear();
                        EE1();
                        break;
                }
            }
            void EE2()
            {
                Console.WriteLine("Señor {0}, eres la llamada No.301204, tu localización está siendo determinada. Gracias a la información aportada ", vNombre);
                Console.WriteLine("por tu familia, podremos recogerte en helicoptero en breve.\n");
                Thread.Sleep(3500);
                Console.Clear();
                Console.WriteLine("Final Easter Egg!\n");
                Console.WriteLine("      ,--.");
                Thread.Sleep(1200);
                Console.WriteLine("     //^\\\\    ,;;;,                        .");
                Thread.Sleep(1200);
                Console.WriteLine("    ((-_-)))  (-_- ;                       /_\\");
                Thread.Sleep(1200);
                Console.WriteLine("     )))(((   >..'.    .:.     .--.        |  |");
                Thread.Sleep(1200);
                Console.WriteLine("     (_._ )  /.   .|  :-_-;   /-_-)");
                Thread.Sleep(1200);
                Console.WriteLine("    _))  ((_//| {0} ||  ,`-'.   ))-((", vNombre.Substring(0,1));
                Thread.Sleep(1200);
                Console.WriteLine("    `(    )`' |___|),;,   \\_/,`  ))");
                Thread.Sleep(1200);
                Console.WriteLine("      \\  /    | | |`' |___(/-'|___()  ,-.");
                Thread.Sleep(1200);
                Console.WriteLine("       )(     | | |   | | |   | | |  (-_-)    _____");
                Thread.Sleep(1200);
                Console.WriteLine("      / __\\   |_|_|   |_|_|   |_|_|  (\\I/\\.__|A|R|T|");
                Thread.Sleep(1200);
                Console.WriteLine("      `''     `-'-'   `-'-'   `-'-'  `'-`'   `o' `o'");
                Console.ReadKey();
            }
            #endregion
            
            //Aqui van las muertes y las pueden invocar con Muertes(Numero de muerte a invocar), todas estas terminaran con el juego saltando a la pantalla de Juego Over
            #region Muertes
            void Muertes(int i)
            {
                switch (i)
                {
                    case 1:
                        Console.WriteLine("Cuando decides entrar al ascensor, de repente el cordón del ascensor se rompe, causando que caigas 10 ");
                        Console.WriteLine("pisos en caída libre y te rompes la cabeza al impactar con el suelo. Moral de la historia, no uses ascensores ");
                        Console.WriteLine("cuando haya una emergencia.\n");
                        GameOver();
                        break;
                    case 2:
                        Console.WriteLine("Cuando te acercas a la ventana solo oyes un sonido ensordecedor el cual se hace mas alto cada segundo. De repente,");
                        Console.WriteLine("De repente, observamos un meteorito dirigiéndose directamente a tu cara. Reaccionaste tarde y el meteorito atravesó ");
                        Console.WriteLine("tu cabeza y te dejó un hoyo, matándote al instante.\n");
                        GameOver();
                        break;
                    case 3:
                        Console.WriteLine("La niña se molesta y empieza a llorar a gritos. Los militares cercanos escuchan y se ponen");
                        Console.WriteLine("atentos. Cuando acercas tu mano a la niña para callarla, una bala atraviesa tu mano.");
                        Console.WriteLine("Observando de dónde vino el disparo, dos balas mas atraviesan tu cuerpo, una por el ojo y otra");
                        Console.WriteLine("por el pulmon. Te caes al piso y tres balazos pas te terminan de matar. La niña es retirada de la");
                        Console.WriteLine("vista y se envia una alarma para buscar sus padres. Tu cuerpo se quedo abandonado en el");
                        Console.WriteLine("medio del desierto.");
                        GameOver();
                        break;
                    case 4:
                        Console.WriteLine("Los militares descubren que dejaste a la niña botada en el edificio colapsando. Cuando te ");
                        Console.WriteLine("preguntan y no sabes que responder, los militares se molestan. La madre en llantos sale del ");
                        Console.WriteLine("carro, te da con su tacon y te tumban al piso. Ella se voltea y les ordena a terminarte. Miles de ");
                        Console.WriteLine("balas atraviesan tu cuerpo.");
                        GameOver();
                        break;
                    case 5:
                        Console.WriteLine("Por tus intentos inefectivos de tratar de mover los escombros para salir, te has tomado mucho tiempo dentro");
                        Console.WriteLine("de un edificio inestable. Desafortunadamente, el edificio ha colapsado y has muerto aplastado por el edificio.");
                        GameOver();
                        break;
                    default:
                        break;
                }
            }
            #endregion

            #region Finales
            void Final(int i)
            {
                switch (i)
                {
                    case 1:
                        Console.WriteLine("\nSigues la dirección indicada por la madre de Joelia, y recorren un vasto recorrido a través de la ciudad y ");
                        Console.WriteLine("al llegar a la dirección, encuentras un carro militar y varios militares rodeandolo. Luego de montarte y ");
                        Console.WriteLine("tras un incómodo viaje en coche, llegas al paraje militar donde está toda la familia de Joelia. Estos gritan ");
                        Console.WriteLine("felices: “Joelia!, Joelia!”, corres detrás de ella y ellos te examinan pero Joelia te defiende y te dejan ");
                        Console.WriteLine("quedarte. Al llevarles a su hija todos llorando te dan las gracias y básicamente te “adoptan” como miembro ");
                        Console.WriteLine("de la familia. Te explican que tienen un cohete y que la NASA lo preparó para poder llevarlos a la colonia ");
                        Console.WriteLine("secreta de Marte. Feliz te preparas para la nueva vida en la colonia de Marte.\n");
                        
                        Console.WriteLine("GOOD ENDING");
                        break;
                    case 2:
                        Console.WriteLine("\nSigues la dirección indicada por la madre de Joelia, y recorren un vasto recorrido a través de la ciudad ");
                        Console.WriteLine("y al llegar a la dirección, encuentras un carro militar y varios militares rodeandolo. Debido a tu ");
                        Console.WriteLine("comportamiento egoísta, la niña corre hacia los militares y le susurra a uno de los militares. ");
                        Console.WriteLine("Estos te apuntan y te obligan a arrodillarte. Te entran a un carro militar y te llevan a su base. ");
                        Console.WriteLine("La familia de la niña te insultan y escupen mientras te llevan amarrado al compartimiento de ");
                        Console.WriteLine("equipaje de un cohete y te desmayas por falta de oxigeno. Cuando despiertas, te encuentras en");
                        Console.WriteLine("un tipo de cueva con tierra roja y rodeada por rejas. Detras de las rejas hay un soldado y le");
                        Console.WriteLine("preguntas que sucedió. Al parecer fuiste traido a Marte para ser un esclavo en la nueva colonia");
                        Console.WriteLine("secreta preparada por la NASA en caso de que el mundo llegara a acabarse. Tu fuiste escogido por");
                        Console.WriteLine("la familia de Joelia para ser el esclavo privado de ellos. Lo unico que puedes hacer es mirar");
                        Console.WriteLine("al techo gris de la cueva y contemplar que tan horrible sera tu vida en Marte.\n");

                        Console.WriteLine("BAD ENDING");
                        break;
                    case 3:
                        Console.WriteLine("Al llegar al refugio, conoces a una chica llamada Isabella,  la ves y te parece muy atractiva, te acercas");
                        Console.WriteLine(" a ella y te pregunta cómo llegaste al refugio, le explicas todos los eventos por los que tuviste que pasar");
                        Console.WriteLine(" y quedó impresionada, ambos siguen platicando y despierta un interés el uno por el otro, pasan dos semanas ");
                        Console.WriteLine("y su amor llegó tan lejos que se terminan casando, todas las personas del refugio realizan una ceremonia para ");
                        Console.WriteLine("el casamiento, ambos son declarados como marido y mujer y deciden vivir juntos hasta la muerte, pasan 3 semanas ");
                        Console.WriteLine("y el mundo colapsa con la luna (todos mueren).\n");

                        Console.WriteLine("GOOD ENDING");
                        break;
                    case 4:
                        Console.WriteLine("Te acercas al grupo de refugiados y todos han recibido el mismo aviso sobre la dirección. La ");
                        Console.WriteLine("niña se veía frustrada por no poderse comunicar con sus padres pero rápidamente se ");
                        Console.WriteLine("tranquilizó al ver que la estaban dejando atrás. En caravana, tú y los refugiados se dirigieron ");
                        Console.WriteLine("hacia el refugio. Cuando llegas al refugio, te sientes aliviado porque ya tú y la niña están fuera ");
                        Console.WriteLine("de peligro de la ciudad. Te vas acercando a la entrada del refugio y notas que hay militares ");
                        Console.WriteLine("marcando un perímetro, pero no te preocupas por eso. Ya dentro del refugio, disparan hacia el ");
                        Console.WriteLine("techo y todo el mundo se tira al piso. Empiezan a sacar personas del montón y los llevan a la ");
                        Console.WriteLine("fuerza a un perímetro cercado. Preguntas por qué hacen esto si no hiciste nada malo, a lo que ");
                        Console.WriteLine("te responden que al momento en el que entraste al refugio, pasaste a ser propiedad de los ");
                        Console.WriteLine("militares. Debido a que este grupo de los militares se enteraron de que había un plan de ");
                        Console.WriteLine("evacuar a la humanidad hacia la colonia de Marte y el gobierno los abandonó. Los jefes ");
                        Console.WriteLine("militares que fueron abandonados decidieron montar una dictadura militar y forzar a la gente a ");
                        Console.WriteLine("trabajar para poder sobrevivir.\n");

                        Console.WriteLine("BAD ENDING");
                        break;
                }
            }
            #endregion

            // Metodos para cambios de colores, animacion de titulo y de gameover
            #region Metodos de Animacion
            //Los proximos metodos se puedon usar para cambiar el color del fondo(La letra seguira en el color que estaba antes, para metodos de letra usar ForeGroundColor)
            
            void CambiarAzul()
            {
                Console.BackgroundColor = ConsoleColor.Blue;
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
                    Console.WriteLine("          ______     ______     __    __     ______        ______     __   __   ______     ______    ");
                    Console.WriteLine("         /\\  ___\\   /\\  __ \\   /\\ \\ \\./  \\   /\\  ___\\      /\\  __ \\   /\\ \\ / /  /\\  ___\\   /\\  == \\   ");
                    Console.WriteLine("         \\ \\ \\__ \\  \\ \\  __ \\  \\ \\ \\-./\\ \\  \\ \\  __\\      \\ \\ \\/\\ \\  \\ \\ \\/ /   \\ \\  __\\   \\ \\  __<   ");
                    Console.WriteLine("          \\ \\_____\\  \\ \\_\\ \\_\\  \\ \\_\\ \\ \\_\\  \\ \\_____\\     \\ \\_____\\  \\ \\__/    \\ \\_____\\  \\ \\_\\ \\_\\ ");
                    Console.WriteLine("           \\/_____/   \\/_/\\/_/   \\/_/  \\/_/   \\/_____/      \\/_____/   \\/_/      \\/_____/   \\/_/ /_/ ");
                    Thread.Sleep(500);
                }
                Thread.Sleep(3500);
                Console.Clear();
                GameOverTexto();
                CambiarRojo();
                GameOverTexto();
                CambiarNormal();
                GameOverTexto();
                CambiarRojo();
                GameOverTexto();
                CambiarNormal();
                GameOverTexto();
                CambiarRojo();
                GameOverTexto();
                CambiarNormal();
                GameOverTexto();
                Thread.Sleep(5500);
                Console.Clear();
                Console.WriteLine("¿Deseas empezar de nuevo? \n");
                Console.WriteLine("1. Si");
                Console.WriteLine("2. No");

                Console.ReadLine();
                vRespuesta = Convert.ToInt32(Console.ReadLine());
                switch (vRespuesta)
                {
                    case 1:
                        Menu();
                        break;
                    case 2:
                        Environment.Exit(0);
                        break;
                    default:
                        Environment.Exit(0);
                        break;
                }
            }
            #endregion

            #endregion
        }
    }
}


