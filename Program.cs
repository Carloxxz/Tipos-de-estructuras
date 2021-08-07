using System;

namespace Menu_de_interfaz
{
    class Program
    {
        static void Main(string[] args)
        {
            int seleccion, dato, dato2, dato3;
            string nombre, respuesta, datoS;
            do
            {
                Console.Clear();
                Console.WriteLine("Seleccione lo que desea aprender\n" +
                    "1.- Estructura de control secuencial\n" +
                    "2.- Estructura de repetición\n" +
                    "3.- Estructura de decisión\n" +
                    "4.- Estructuras de control repetitivas\n" +
                    "5.- Estructuras de control repetitivas anidadas\n" +
                    "6.- Estrucutras de control selectiva\n");
                seleccion = int.Parse(Console.ReadLine());
                Console.Clear();

                switch (seleccion)
                {
                    case 1:
                        Console.WriteLine("Has seleccionado las estructuras de control secuencial:\n" +
                            "\nEsta estructura será capaz de identificar unos datos de entrada, procesarlos y mostrarlos para imprimirlos en la salida\n" +
                            "\npresiona ENTER para continuar");
                        Console.ReadLine();
                        Console.Clear();
                        Console.WriteLine("Por ejemplo\n" + "Ingresa tu nombre");
                        nombre = Console.ReadLine();
                        Console.WriteLine("\nTu nombre es " + nombre + "\n");
                        Console.WriteLine("\nEn este caso el dato introducido es tu nombre y la salida es un mensaje con tu nombre");
                        Console.ReadLine();
                        break;
                    case 2:
                        Console.WriteLine("Has seleccionado estructuras de repetición\n" +
                            "\nTambién conocidas como estructuras cíclicas, nos permite ejecutar un conjunto de instrucciones de manera repetida" + "\nmientras que la expresión lógica a evaluar se cumpla\n" +
                            "\npresiona ENTER para continuar");
                        Console.ReadLine();
                        Console.Clear();
                        Console.WriteLine("Por ejemplo\n" + "\nUsaremos las estructuras de control secuencial para dar un mejor ejemplo\n" + "\nIntroduce un número");
                        dato = int.Parse(Console.ReadLine());
                        if (dato <= 19)
                        {

                            while (dato <= 20)
                            {
                                Console.WriteLine(dato);
                                dato++;
                            }
                            Console.WriteLine("\nComo podemos observar la secuencia comienza desde el numero ingresado sumandose de 1 hasta llegar al 20, porque la\n" + "función de las estructuras repetivas es reiniciar el ciclo hasta que se cumpla lo deseado.");
                        }
                        else
                        {
                            while (dato >= 20)
                            {
                                Console.WriteLine(dato);
                                dato--;
                            }
                            Console.WriteLine("\nComo se observa, el dato ingresado se resta hasta llegar al 20, porque la función de las estructuras de repetición es\n" + "reiniciar el ciclo hasta que se cumpla lo deseado.");
                        }
                        Console.WriteLine("\nDe no ser por las estructuras repetitivas tendríamos que escirbir cientas de líneas de código innecesariamente");
                        Console.ReadLine();
                        break;
                    case 3:
                        Console.WriteLine("Has seleccionado estructura de decisión\n" +
                          "\nNos permite que la ejecución de un algoritmo tome distintos caminos, que llevan a distintos resultados, dependiendo\n" + "de la condición o" + "condiciones presentes en la estructura de decisión.\n" +
                        "\nPresiona ENTER para continuar");
                        Console.ReadLine();
                        Console.Clear();
                        Console.WriteLine("Por ejemplo\n" + "\n¿Qué prefieres juegos de plataforma o shooters?");
                        datoS = Console.ReadLine();
                        Console.Clear();
                        if (datoS == "Plataforma" || datoS == "plataforma")
                        {
                            Console.WriteLine("El dato escogido fue " + datoS + " , es un genero muy divertido!");
                            Console.ReadLine();
                        }
                        else if (datoS == "shooters" || datoS == "Shooters")
                        {
                            Console.WriteLine("El dato escogido fue " + datoS + " , es un genero muy competitivo!");
                            Console.ReadLine();
                        }
                        else
                        {
                            Console.WriteLine("El dato introducido no coincide con las respuestas planteadas");
                            Console.ReadLine();
                        }

                        break;
                    case 4:
                        Console.WriteLine("Has seleccionado estructuras de control repetitivas\n" +
                            "\nSon aquellas que permiten ejecutar un\n" + "conjunto de instrucciones varias veces, de acuerdo al valor que genere la expresión\n" +
                            "relacional y/o lógica. Esto significa que una instrucción repetitiva permite saltar\n" + "a una instrucción anterior para volver a ejecutarla");
                        Console.ReadLine();
                        Console.Clear();
                        Console.WriteLine("El ejemplo mas claro es la repetición de este programa, en donde podemos seleccionar si continuar aprendiendo o salir");
                        Console.ReadLine();
                        break;
                    case 5:
                        Console.WriteLine("Has seleccionado estructuras de control repetitivas anidadas\n" +
                            "\nUna estructura puede estar dentro de otra estructura a esto se le\n" + "conoce como anidamiento o estructuras anidadas.\n" +
                            "\nYa que se trabajan con datos en estructuras, si definimos un tipo\n" + "de dato en una estructura y necesitamos definir ese dato\n" +
                            "dentro de otra estructura solamente se llama el dato de la estructura anterior.\n" + "\nUna " +
                            "estructura puede estar dentro de otra estructura a esto se le conoce como anidamiento o estructuras anidadas.\n" +
                            "Ya que se trabajan con datos en estructuras si definimos un tipo de dato en una estructura y necesitamos\n" +
                            "definir ese dato dentro de otra estructura solamente se llama el dato de la estructura anterior.\n" + "\nPresiona ENTER para continuar");
                        Console.ReadLine();
                        Console.WriteLine("Por ejemplo\n" + "\nIngresa un número");
                        dato = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese un segundo número");
                        dato2 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese un ultimo dato");
                        dato3 = int.Parse(Console.ReadLine());
                        if (dato > dato2 && dato > dato3)
                        {
                            Console.WriteLine("El mayor de los 3 números es " + dato);
                        }
                        else if (dato2 > dato && dato2 > dato3)
                        {
                            Console.WriteLine("El mayor de los 3 números es " + dato2);
                        }
                        else if (dato3 > dato && dato3 > dato2)
                        {
                            Console.WriteLine("El mayo de los 3 números es " + dato3);
                        }
                        Console.ReadLine();
                        break;
                    case 6:
                        Console.WriteLine("Has seleccionado estructuras de control selectivas\n" +
                          "Las estructuras selectivas se utilizan para tomar decisiones lógicas; de ahí que se suelan denominar también estructuras de decisión o alternativas" +
                          "\nEn las estructuras selectivas se evalúan una condición y en función del resultado de la misma se realiza una opción u otra\n" + "\nEjemplo\n" + "\nEl switch que estas usando para la selección de los datos 1, 2 , 3 ,4 y 5");
                        Console.ReadLine();
                        break;
                    default:
                        Console.Write("Por favor ingrese uno de los numeros listados");
                        break;
                }
                Console.Clear();
                Console.WriteLine("¿Desea aprender algo mas? (Y/N)");
                respuesta = Console.ReadLine();
            } while (respuesta == "Y" || respuesta == "y");
        }
    }
}

