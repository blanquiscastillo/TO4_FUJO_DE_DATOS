
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


namespace TO4_FUJO_DE_DATOS
{
    class Program
    {        

        static void Main(string[] args)
        {
            
            Console.WriteLine("T04 - Flujo de Datos");
            Console.WriteLine("\n EJERCICIO 1");
            Ejercicio1();
            Console.WriteLine("\n EJERCICIO 2 y 3");
            Ejercicio2_Ejercicio3();            
            Console.WriteLine("\n EJERCICIO 4");
            Ejercicio4();            
            Console.WriteLine("\n EJERCICIO 5");
            Ejercicio5();                     
            Console.WriteLine("\n EJERCICIO 6");
            Ejercicio6();            
            Console.WriteLine("\n EJERCICIO 7");
            Ejercicio7();
            
            Console.WriteLine("\n EJERCICIO 14");
            Ejercicio14();
            Console.WriteLine("\n EJERCICIO 16");
            Ejercicio16();
            Console.WriteLine("\n EJERCICIO 20");
            Ejercicio20();
            Console.WriteLine("\n EJERCICIO 21");
            Ejercicio21();
            
            Console.WriteLine("\n EJERCICIO 22");
            Ejercicio22();
            
            Console.WriteLine("\n EJERCICIO 23");
            Ejercicio23();
            


            Console.WriteLine("\n");
            Console.WriteLine("Presione cualquier tecla para salir");
            Console.ReadKey();
        }

        static void Ejercicio1()
        {

            int x = 20;
            int y = 10;
            int z = 10;
            int resultado;

            resultado = x + y + z;
            Console.WriteLine("La Suma de {0} + {1} + {2} es {3}", x, y, z, resultado);
        }

        static void Ejercicio2_Ejercicio3()
        {
            Console.WriteLine("Escribe tu nombre");
            string nombre = Console.ReadLine().ToUpper();
            Console.WriteLine("Escribe tu ciudad");
            string ciudad = Console.ReadLine().ToUpper();
            Console.WriteLine("Escribe tu edad");
            int edad = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Te llamas {0} y tu edad es  {1}", nombre, edad);
        }

        static void Ejercicio4()
        {
            Console.WriteLine("Ingresa dos numeros enteros");
            int numero1 = Convert.ToInt32(Console.ReadLine());
            int numero2 = Convert.ToInt32(Console.ReadLine());

            if (numero1 > numero2)
            {
                Console.WriteLine("El numero mayor es {0}", numero1);
            }
            else
            {
                Console.WriteLine("El numero mayor es {0}", numero2);
            }

        }

        static void Ejercicio5()
        {
            Console.WriteLine("Ingresa el nombre de un dia de la semana");
            string dia = Console.ReadLine().ToUpper();

            if (dia.Equals("SABADO") || dia.Equals("DOMINGO")){
                Console.WriteLine("ES FIN DE SEMANA");
            }
            else
            {
                if (dia.Equals("LUNES") || dia.Equals("MARTES") || dia.Equals("MIERCOLES") || dia.Equals("JUEVES") || dia.Equals("VIERNES")){
                    Console.WriteLine("NO ES FIN DE SEMANA");
                }
                else
                {
                    Console.WriteLine("NOMBRE DE DIA NO VALIDO");
                }

            }
        }

        static void Ejercicio6()
        {
            Console.WriteLine("Ingresa el precio de un producto (mayor a cero)");
            double precio = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingresa forma de pago (1. EFECTIVO y 2. TARJETA)");
            int forma_pago = Convert.ToInt32(Console.ReadLine());
            if (forma_pago == 2)
            {
                Console.WriteLine("Ingresa el numero de cuenta");
                Console.ReadLine();
            }
        }

        static void Ejercicio7()
        {            
            Console.WriteLine("Numeros pares del 1 al 20");
            for (int i = 1; i <= 20; i++)
            {
                if (i%2 == 0)
                Console.Write(i);
                Console.Write(" ");
            }
            Console.WriteLine("\n");
            Console.WriteLine("Numeros pares del 1 al 20 o divisibles entre 3");
            for (int i = 1; i <= 20; i++)
            {
                if ((i % 2 == 0) || (i % 3 == 0))
                    Console.Write(i);
                Console.Write(" ");
            }
        }

        static void Ejercicio14()
        {
           Console.WriteLine("INGRESE EL RADIO DEL CIRCULO");
            double radio = Convert.ToDouble(Console.ReadLine());
            double area = (Math.PI) * (Math.Pow(radio, 2));
            Console.WriteLine("EL AREA DEL CIRCULO ES: {0}",area);

        }

        static void Ejercicio16()
        {
            const double iva = 0.21;
            Console.WriteLine("INGRESE EL PRECIO DEL PRODUCTO");
            double precio = Convert.ToDouble(Console.ReadLine());
            double total = precio + (precio * iva);
            Console.WriteLine("EL PRECIO TOTAL CON IVA ES: {0}", total);

        }

        static void Ejercicio20()
        {            
            Console.WriteLine("INGRESE LA CANTIDAD DE VENTAS");
            int cantidad = Convert.ToInt32(Console.ReadLine());
            double suma = 0;
            for (int i = 0; i < cantidad; i++)
            {
                Console.WriteLine("INGRESE EL VALOR DE LA VENTA {0}",i);
                double precio = Convert.ToDouble(Console.ReadLine());
                suma = suma + precio;
            }
            Console.WriteLine("EL TOTAL DE LAS VENTAS ES: {0}", suma);
        }

        static void Ejercicio21()
        {
            Console.WriteLine("Ingresa el nombre de un dia de la semana");
            string dia = Console.ReadLine().ToUpper();

            switch (dia)
            {
                case "LUNES": 
                    Console.WriteLine("EL DIA {0} ES LABORAL", dia);
                    break;
                case "MARTES":
                    Console.WriteLine("EL DIA {0} ES LABORAL", dia);
                    break;
                case "MIERCOLES":
                    Console.WriteLine("EL DIA {0} ES LABORAL", dia);
                    break;
                case "JUEVES":
                    Console.WriteLine("EL DIA {0} ES LABORAL", dia);
                    break;
                case "VIERNES":
                    Console.WriteLine("EL DIA {0} ES LABORAL", dia);
                    break;
                case "SABADO":
                    Console.WriteLine("EL DIA {0} NO ES LABORAL", dia);
                    break;
                case "DOMINGO":
                    Console.WriteLine("EL DIA {0} NO ES LABORAL", dia);
                    break;

                default:
                    Console.WriteLine("EL DIA {0} NO EXISTE",dia);
                    break;
            }

        }

        static void Ejercicio22()
        {
            string contraseña = "123456";
            int correcto = 0;

            for (int i = 0; i < 3; i++)
            {                
                Console.WriteLine("Ingresa la contraseña");
                string contraseña2 = Console.ReadLine().ToUpper();
                if (contraseña.Equals(contraseña2)) 
                {
                    correcto = 1;
                    Console.WriteLine("¡¡¡¡¡ Enhorabuena !!!!");
                    break;
                }
            }

            if (correcto == 0)
            {
                Console.WriteLine("Superaste el maximo de 3 intentos");
            }
            

        }

        static void Ejercicio23()
        {
            Console.WriteLine("Ingresa dos numeros enteros");
            int numero1 = Convert.ToInt32(Console.ReadLine());
            int numero2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingresa un signo aritmetico entre (+ - * / ^ %)");
            string signo = Console.ReadLine();

            switch (signo)
            {
                case "+":
                    Console.WriteLine("La operacion {0} + {1} es {2}", numero1, numero2, numero1+numero2);
                    break;
                case "-":
                    Console.WriteLine("La operacion {0} - {1} es {2}", numero1, numero2, numero1 - numero2);
                    break;
                case "*":
                    Console.WriteLine("La operacion {0} * {1} es {2}", numero1, numero2, numero1 * numero2);
                    break;
                case "/":
                    Console.WriteLine("La operacion {0} / {1} es {2}", numero1, numero2, ((double)numero1 / (double)numero2));
                    break;
                case "^":
                    Console.WriteLine("La operacion {0} ^ {1} es {2}", numero1, numero2, (Math.Pow(numero1, numero2)));
                    break;
                case "%":
                    Console.WriteLine("La operacion {0} % {1} es {2}", numero1, numero2, numero1 % numero2);
                    break;

                default:
                    break;
            }

        }

    }// de la clase program
}// del namespace


