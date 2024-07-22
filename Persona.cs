using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaSemana8
{
    // Clase que representa una Persona
    class Persona
    {
        public string Nombre { get; set; } // Nombre de la persona

        // Constructor que inicializa una persona con su nombre
        public Persona(string nombre)
        {
            Nombre = nombre;
        }
    }

    // Clase que maneja la asignación de asientos en el avión
    class AsignacionAsientos
    {
        // Cola para manejar la espera de las personas
        private Queue<Persona> colaEspera = new Queue<Persona>();
        // Lista para registrar los asientos asignados
        private List<string> asientosAsignados = new List<string>();
        // Número total de asientos disponibles
        private int totalAsientos = 30;

        // Método para agregar una persona a la cola de espera
        public void AgregarPersona(string nombre)
        {
            if (asientosAsignados.Count < totalAsientos) // Verifica si aún hay asientos disponibles
            {
                colaEspera.Enqueue(new Persona(nombre)); // Agrega a la persona a la cola de espera
                Console.WriteLine($"{nombre} agregado a la cola de espera.");
            }
            else
            {
                Console.WriteLine("Todos los asientos están asignados. No se pueden agregar más personas.");
            }
        }

        // Método para asignar asientos en orden de llegada
        public void AsignarAsientos()
        {
            // Asigna asientos mientras haya personas en la cola y asientos disponibles
            while (colaEspera.Count > 0 && asientosAsignados.Count < totalAsientos)
            {
                Persona persona = colaEspera.Dequeue(); // Saca a la persona de la cola
                asientosAsignados.Add(persona.Nombre); // Agrega su nombre a la lista de asientos asignados
                Console.WriteLine($"{persona.Nombre} ha sido asignado al asiento {asientosAsignados.Count}.");
            }

            if (asientosAsignados.Count == totalAsientos)
            {
                Console.WriteLine("Todos los asientos han sido asignados.");
            }
        }

        // Método para imprimir la lista de asientos asignados
        public void ImprimirAsientosAsignados()
        {
            Console.WriteLine("Lista de asientos asignados:");
            for (int i = 0; i < asientosAsignados.Count; i++)
            {
                // Imprime el número del asiento y el nombre de la persona asignada a ese asiento
                Console.WriteLine($"Asiento {i + 1}: {asientosAsignados[i]}");                
            }
        }

        // Método para simular el llenado del vuelo
        public void SimularLlenadoVuelo()
        {
            Queue<string> nombres = new Queue<string>();

            // Llenado de nombres simulados
            for (int i = 0; i < 30; i++)
            {
                nombres.Enqueue("Usuario - " + i.ToString());
            }

            // Encolar los nombres simulados en la cola de espera
            while (nombres.Count > 0)
            {
                string nombre = nombres.Dequeue();
                AgregarPersona(nombre);
            }

            // Asignar los asientos en orden de llegada
            AsignarAsientos();

            // Imprimir la lista de asientos asignados
            ImprimirAsientosAsignados();
        }
    }

}
