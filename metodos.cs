using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arraysV2
{
    internal class metodos
    {
        public void valorArreglos()
        {

            int[] arreglo1 = new int[3] { 2, 4, 6 };
            int[] arreglo2 = new int[3] { 3, 6, 9 };
            int[] arregloAlmacenador = new int[3];

            for (int i = 0; i < 3; i++)
            {
                arregloAlmacenador[i] = arreglo1[i] + arreglo2[i];

                Console.WriteLine($"posicion {i} del arreglo uno {arreglo1[i]} mas la posicion {i} del arreglo dos {arreglo2[i]} = {arregloAlmacenador[i]}");

            }

        }
        public void indicarPosicion()
        {
            Console.WriteLine("Ingresa elemento para el array");
            int elemento = Convert.ToInt32(Console.ReadLine());
            bool encontrado = false;

            int[] arreglo = new int[5] { 2, 2, 3, 5, 3 };
            for (int i = 0; i < arreglo.Length; i++)
            {
                if (arreglo[i] == elemento)
                {
                    Console.Write($"se encuentra en la posicion {i + 1} ");
                    encontrado = true;
                }
            }

            if (!encontrado)
            {
                Console.WriteLine($"El elemento {elemento} no se encuentra en el arreglo.");
            }
        }
        public void Matriculas()
        {
            int[] Algebra = new int[4];
            int[] Analisis = new int[4];
            int[] resultado = new int[8];
            int contador = 4;
            int repetidos = 0;

            for (int i = 0; i < Algebra.Length; i++)
            {
                Console.WriteLine($"Ingresar matricula para grupo 1 ");
                Algebra[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int j = 0; j < Analisis.Length; j++)
            {

                Console.WriteLine($"Ingresar matricula  para grupo 2");
                Analisis[j] = Convert.ToInt32(Console.ReadLine());

            }
            for (int i = 0; i < Algebra.Length; i++)
            {
                resultado[i] = Algebra[i];
                resultado[contador] = Analisis[i];
                contador++;
            }
            for (int i = 0; i < resultado.Length; i++)
            {
                Console.WriteLine("Las matriclas son " + resultado[i]);

            }


            foreach (int IdAlumnoAlgebra in Algebra)
            {
                foreach (int IdAlumnoAnalisis in Analisis)
                {
                    if (IdAlumnoAlgebra == IdAlumnoAnalisis)
                    {
                        repetidos++;
                    }
                }
            }
            Console.WriteLine("el numero de alumnos repetidos en ambos grupos es " + repetidos);




        }
        public void Id()
        {
            Console.Write("Ingrese el tamaño del arreglo: ");
            int tamaño = Convert.ToInt32(Console.ReadLine());

            // Crear un arreglo para almacenar los números ingresados
            int[] numeros = new int[tamaño];

            // Llenar el arreglo sin valores repetidos
            for (int i = 0; i < tamaño; i++)
            {
                bool esRepetido;
                do
                {
                    esRepetido = false;
                    Console.Write($"Ingrese el valor #{i + 1}: ");
                    numeros[i] = Convert.ToInt32(Console.ReadLine());

                    // Verificar si el número ya ha sido ingresado
                    for (int j = 0; j < i; j++)
                    {
                        if (numeros[i] == numeros[j])
                        {
                            Console.WriteLine("Numero repetido, ingrese un número diferente");
                            esRepetido = true;
                            break;
                        }
                    }
                } while (esRepetido);
            }

            // Mostrar el contenido del arreglo
            Console.WriteLine("Contenido del arreglo:");
            for (int i = 0; i < tamaño; i++)
            {
                Console.WriteLine($"Número #{i + 1}: {numeros[i]}");
            }
        }
        public void Promeidos()
        {

            Console.Write("Ingrese la cantidad de notas: ");
            int N = Convert.ToInt32(Console.ReadLine());

            int[] notas = new int[N];
            int sumaAprobadas = 0, sumaDesaprobadas = 0;
            int contadorAprobadas = 0, contadorDesaprobadas = 0;

            // Leer las notas y calcular sumas y contadores
            for (int i = 0; i < N; i++)
            {
                Console.Write($"Ingrese la nota #{i + 1}: ");
                notas[i] = Convert.ToInt32(Console.ReadLine());

                // Verificar el rango de la nota y sumarla al promedio correspondiente
                if (notas[i] >= 0 && notas[i] <= 5)
                {
                    sumaDesaprobadas += notas[i];
                    contadorDesaprobadas++;
                }
                else if (notas[i] >= 6 && notas[i] <= 10)
                {
                    sumaAprobadas += notas[i];
                    contadorAprobadas++;
                }
                else if (notas[i] >= 11 && notas[i] <= 15)
                {
                    sumaAprobadas += notas[i];
                    contadorAprobadas++;
                }
                else if (notas[i] >= 16 && notas[i] <= 20)
                {
                    sumaAprobadas += notas[i];
                    contadorAprobadas++;
                }
                else
                {
                    Console.WriteLine("no es una nota valida");
                    i--;
                }
            }

            // Calcular promedios
            double promedioAprobadas = 0;
            double promedioDesaprobadas = 0;

            if (contadorAprobadas > 0)
            {
                promedioAprobadas = sumaAprobadas / contadorAprobadas;
            }

            if (contadorDesaprobadas > 0)
            {
                promedioDesaprobadas = sumaDesaprobadas / contadorDesaprobadas;
            }


            // Mostrar resultados
            Console.WriteLine($"Promedio de notas aprobadas: {promedioAprobadas}");
            Console.WriteLine($"Promedio de notas desaprobadas: {promedioDesaprobadas}");
            Console.WriteLine($"Cantidad de notas aprobadas: {contadorAprobadas}");
            Console.WriteLine($"Cantidad de notas desaprobadas: {contadorDesaprobadas}");

        }
    }

}

