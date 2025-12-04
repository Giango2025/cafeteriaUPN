using System;

namespace CafeteriaUPN_Evaluacion
{
    internal class Program
    {
        // Datos globales
        private static readonly string[] NOMBRES_COMBO = { "Café + Pan", "Jugo + Sándwich", "Menú Saludable" };
        private static readonly double[] PRECIOS_COMBO = { 5.50, 7.00, 10.00 };
        private const int MAX_RESERVAS = 20;
        private const int NUM_TURNOS = 2;

        static void Main(string[] args)
        {
            EjecutarMenu();
        }

        static void EjecutarMenu()
        {
            int opcion;
            do
            {
                Console.WriteLine("\n=== Sistema de Reservas UPN ===");
                Console.WriteLine("1. Mostrar Menú de Combos");
                Console.WriteLine("2. Registrar Reserva");
                Console.WriteLine("3. Cancelar Reserva");
                Console.WriteLine("4. Listar Reservas por Turno");
                Console.WriteLine("5. Reporte de Ingresos");
                Console.WriteLine("6. Buscar Reserva por Nombre");
                Console.WriteLine("0. Salir");
                Console.Write("Seleccione una opción: ");
                
                if (!int.TryParse(Console.ReadLine(), out opcion))
                {
                    opcion = -1;
                }
                
                Console.Clear();
                
                switch (opcion)
                {
                    case 1:
                        MostrarMenuCombos();
                        break;
                    case 2:
                        Console.WriteLine("Función pendiente: Registrar Reserva");
                        break;
                    case 3:
                        Console.WriteLine("Función pendiente: Cancelar Reserva");
                        break;
                    case 4:
                        Console.WriteLine("Función pendiente: Listar Reservas");
                        break;
                    case 5:
                        Console.WriteLine("Función pendiente: Reporte de Ingresos");
                        break;
                    case 6:
                        Console.WriteLine("Función pendiente: Buscar Reserva");
                        break;
                    case 0:
                        Console.WriteLine("Cerrando el sistema. ¡Adiós!");
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Intente de nuevo.");
                        break;
                }
                
                if (opcion != 0)
                {
                    Console.WriteLine("\n--- Presione cualquier tecla para continuar ---");
                    Console.ReadKey();
                    Console.Clear();
                }
            } while (opcion != 0);
        }

        static void MostrarMenuCombos()
        {
            Console.WriteLine("--- MENÚ DE COMBOS ---");
            for (int i = 0; i < NOMBRES_COMBO.Length; i++)
            {
                Console.WriteLine($"[{i + 1}] {NOMBRES_COMBO[i]} (S/. {PRECIOS_COMBO[i]:N2})");
            }
        }
    }
}