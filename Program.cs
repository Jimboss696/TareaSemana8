using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaSemana8
{
    // Clase principal del programa
    class Program
    {
        // Función para mostrar la carátula del menú
        static void Caratula()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine("+             UNIVERSIDAD ESTATAL AMAZÓNICA           +");
            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine();
            Console.WriteLine("           Menú de opciones - Aerolinea Yanga");
            Console.WriteLine();
            Console.WriteLine("                 Escriba un número                     ");
            Console.WriteLine();
            Console.ResetColor();
        }

        static void Main()
        {
            // Crea una instancia de AsignacionAsientos
            AsignacionAsientos asignacionAsientos = new AsignacionAsientos();

            while (true) // Bucle principal del programa
            {
                Caratula(); // Llama a la función Caratula para mostrar la carátula del menú

                // Muestra el menú principal
                Console.WriteLine("Menu Principal:");
                Console.WriteLine("1. Agregar persona a la cola de espera");
                Console.WriteLine("2. Asignar asientos en orden de llegada");
                Console.WriteLine("3. Imprimir asientos asignados");
                Console.WriteLine("4. Simulación de llenado de vuelo");
                Console.WriteLine("5. Salir");
                Console.Write("Seleccione una opción: ");
                string entrada = Console.ReadLine();

                if (int.TryParse(entrada, out int opcionPrincipal)) // Valida que la entrada sea un número
                {
                    switch (opcionPrincipal)
                    {
                        case 1:
                            // Agregar persona a la cola de espera
                            Console.Write("Ingrese el nombre de la persona: ");
                            string nombre = Console.ReadLine();
                            asignacionAsientos.AgregarPersona(nombre);
                            break;
                        case 2:
                            // Asignar asientos en orden de llegada
                            asignacionAsientos.AsignarAsientos();
                            break;
                        case 3:
                            // Imprimir lista de asientos asignados
                            asignacionAsientos.ImprimirAsientosAsignados();
                            break;
                        case 4:
                            // Simulación de llenado de vuelo
                            asignacionAsientos.SimularLlenadoVuelo();
                            break;
                        case 5:
                            // Salir del programa
                            return;
                        default:
                            Console.WriteLine("Opción no válida.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Entrada no válida. Por favor ingrese un número.");                    
                }
                // Pausar para permitir ver el resultado antes de volver al menú
                Console.WriteLine("Presione cualquier tecla para regresar al menú...");
                Console.ReadKey();
            }
        }
    }
}
