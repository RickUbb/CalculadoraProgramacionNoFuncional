using System;

namespace CalculadoraSinProgramacionFuncional
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variable para el menu
            int opcion;

            do
            {
                ProgramHelpers.MostrarMenu();
                opcion = ObtenerOpcion();

                switch (opcion)
                {
                    case 1:
                        Sumar();
                        break;
                    case 2:
                        Restar();
                        break;
                    case 3:
                        Multiplicar();
                        break;
                    case 4:
                        Dividir();
                        break;
                    case 5:
                        PotenciaCuadrado();
                        break;
                    case 6:
                        PotenciaCubo();
                        break;
                    case 7:
                        RaizCuadrada();
                        break;
                    case 8:
                        RaizCubica();
                        break;
                    case 9:
                        Console.WriteLine("¡Hasta luego!");
                        break;
                    default:
                        Console.WriteLine("Opción inválida. Por favor, selecciona una opción válida.");
                        break;
                }

                Console.WriteLine();
                Console.WriteLine("Presiona cualquier tecla para continuar...");
                Console.ReadKey();
                Console.Clear();

            } while (opcion != 9);
        }

        static int ObtenerOpcion()
        {
            Console.Write("Ingresa una opción: ");
            int opcion;
            int.TryParse(Console.ReadLine(), out opcion);
            return opcion;
        }

        //Suma
        static void Sumar()
        {
            double num1, num2;
            Console.Write("Ingresa el primer número: ");
            double.TryParse(Console.ReadLine(), out num1);
            Console.Write("Ingresa el segundo número: ");
            double.TryParse(Console.ReadLine(), out num2);
            double resultado = num1 + num2;
            Console.WriteLine("Resultado: " + resultado);
            MostrarResultadoEnLetras(resultado);
        }

        static void Restar()
        {
            double num1, num2;
            Console.Write("Ingresa el primer número: ");
            double.TryParse(Console.ReadLine(), out num1);
            Console.Write("Ingresa el segundo número: ");
            double.TryParse(Console.ReadLine(), out num2);
            double resultado = num1 - num2;
            Console.WriteLine("Resultado: " + resultado);
            MostrarResultadoEnLetras(resultado);
        }

        static void Multiplicar()
        {
            double num1, num2;
            Console.Write("Ingresa el primer número: ");
            double.TryParse(Console.ReadLine(), out num1);
            Console.Write("Ingresa el segundo número: ");
            double.TryParse(Console.ReadLine(), out num2);
            double resultado = num1 * num2;
            Console.WriteLine("Resultado: " + resultado);
            MostrarResultadoEnLetras(resultado);
        }

        static void Dividir()
        {
            double num1, num2;
            Console.Write("Ingresa el dividendo: ");
            double.TryParse(Console.ReadLine(), out num1);
            Console.Write("Ingresa el divisor: ");
            double.TryParse(Console.ReadLine(), out num2);

            if (num2 != 0)
            {
                double resultado = num1 / num2;
                Console.WriteLine("Resultado: " + resultado);
                MostrarResultadoEnLetras(resultado);
            }
            else
            {
                Console.WriteLine("No es posible dividir entre cero.");
            }
        }

        static void PotenciaCuadrado()
        {
            double num;
            Console.Write("Ingresa el número: ");
            double.TryParse(Console.ReadLine(), out num);
            double resultado = num * num;
            Console.WriteLine("Resultado: " + resultado);
            MostrarResultadoEnLetras(resultado);
        }

        static void PotenciaCubo()
        {
            double num;
            Console.Write("Ingresa el número: ");
            double.TryParse(Console.ReadLine(), out num);
            double resultado = num * num * num;
            Console.WriteLine("Resultado: " + resultado);
            MostrarResultadoEnLetras(resultado);
        }

        static void RaizCuadrada()
        {
            double num;
            Console.Write("Ingresa el número: ");
            double.TryParse(Console.ReadLine(), out num);

            if (num >= 0)
            {
                double resultado = Math.Sqrt(num);
                Console.WriteLine("Resultado: " + resultado);
                MostrarResultadoEnLetras(resultado);
            }
            else
            {
                Console.WriteLine("No es posible calcular la raíz cuadrada de un número negativo.");
            }
        }

        static void RaizCubica()
        {
            double num;
            Console.Write("Ingresa el número: ");
            double.TryParse(Console.ReadLine(), out num);
            double resultado = Math.Pow(num, 1.0 / 3.0);
            Console.WriteLine("Resultado: " + resultado);
            MostrarResultadoEnLetras(resultado);
        }

        static void MostrarResultadoEnLetras(double resultado)
        {
            string resultadoEnLetras = ConvertirNumeroALetras(resultado);
            Console.WriteLine("Resultado: " + resultadoEnLetras);
        }

        static string ConvertirNumeroALetras(double numero)
{
    string[] unidades = { "cero", "uno", "dos", "tres", "cuatro", "cinco", "seis", "siete", "ocho", "nueve" };
    string[] especiales = { "diez", "once", "doce", "trece", "catorce", "quince", "dieciséis", "diecisiete", "dieciocho", "diecinueve" };
    string[] decenas = { "veinte", "treinta", "cuarenta", "cincuenta", "sesenta", "setenta", "ochenta", "noventa" };
    string[] centenas = { "cien", "doscientos", "trescientos", "cuatrocientos", "quinientos", "seiscientos", "setecientos", "ochocientos", "novecientos" };

    int numeroEntero = (int)numero;

    if (numero < 0)
    {
        return "menos " + ConvertirNumeroALetras(Math.Abs(numero));
    }
    else if (numero < 10)
    {
        return unidades[numeroEntero];
    }
    else if (numero < 20)
    {
        return especiales[numeroEntero - 10];
    }
    else if (numero < 100)
    {
        int decena = numeroEntero / 10 - 2;
        int unidad = numeroEntero % 10;
        if (unidad == 0)
        {
            return decenas[decena];
        }
        else
        {
            return decenas[decena] + " y " + unidades[unidad];
        }
    }
    else if (numero < 1000)
    {
        int centena = numeroEntero / 100;
        int resto = numeroEntero % 100;
        if (resto == 0)
        {
            return centenas[centena - 1];
        }
        else
        {
            return centenas[centena - 1] + " " + ConvertirNumeroALetras(resto);
        }
    }
    else
    {
        return numeroEntero.ToString(); // Fuera del alcance de este ejemplo, tratar números mayores a 999.
    }
}

    }
}
