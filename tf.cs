using System;

namespace CafeteriaUPN_Evaluacion
{
    internal class Program
    {
        private static readonly string[] NOMBRES_COMBO = { "Café + Pan", "Jugo + Sándwich", "Menú Saludable" };
        private static readonly double[] PRECIOS_COMBO = { 5.50, 7.00, 10.00 };
        private const int MAX_RESERVAS = 20;
        private const int NUM_TURNOS = 2;
        
        private static string[,] reservas = new string[NUM_TURNOS, MAX_RESERVAS];
        private static int[,] comboIndices = new int[NUM_TURNOS, MAX_RESERVAS];

        static void Main(string[] args)
        {
            InicializarDatos();
            EjecutarMenu();
        }

        static void InicializarDatos()
        {
            for (int i = 0; i < NUM_TURNOS; i++)
            {
                for (int j = 0; j < MAX_RESERVAS; j++)
                {
                    reservas[i, j] = "LIBRE";
                    comboIndices[i, j] = -1;
                }
            }
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
                        RegistrarReserva();
                        break;
                    case 3:
                        CancelarReserva();
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

        static void RegistrarReserva()
        {
            MostrarMenuCombos();
            Console.Write("\nNombre del Estudiante: ");
            string nombre = Console.ReadLine().Trim().ToUpper();
            
            Console.Write("Turno (1: Mañana | 2: Tarde): ");
            if (!int.TryParse(Console.ReadLine(), out int turno) || turno < 1 || turno > NUM_TURNOS)
            {
                Console.WriteLine(" Turno no válido.");
                return;
            }
            int fila = turno - 1;
            
            Console.Write("Combo a reservar [1, 2, 3...]: ");
            if (!int.TryParse(Console.ReadLine(), out int combo) || combo < 1 || combo > NOMBRES_COMBO.Length)
            {
                Console.WriteLine(" Combo no válido.");
                return;
            }
            int comboIndex = combo - 1;
            
            for (int col = 0; col < MAX_RESERVAS; col++)
            {
                if (reservas[fila, col] == "LIBRE")
                {
                    reservas[fila, col] = nombre;
                    comboIndices[fila, col] = comboIndex;
                    string turnoStr = fila == 0 ? "Mañana" : "Tarde";
                    Console.WriteLine($" Reserva registrada para {nombre} en turno {turnoStr}.");
                    return;
                }
            }
            
            Console.WriteLine($" El turno {(fila == 0 ? "Mañana" : "Tarde")} ha agotado su límite de {MAX_RESERVAS} reservas.");
        }

        static void CancelarReserva()
        {
            Console.Write("Nombre del Estudiante a Cancelar: ");
            string nombre = Console.ReadLine().Trim().ToUpper();
            
            for (int fila = 0; fila < NUM_TURNOS; fila++)
            {
                for (int col = 0; col < MAX_RESERVAS; col++)
                {
                    if (reservas[fila, col] == nombre)
                    {
                        string comboNombre = NOMBRES_COMBO[comboIndices[fila, col]];
                        reservas[fila, col] = "LIBRE";
                        comboIndices[fila, col] = -1;
                        string turnoStr = fila == 0 ? "Mañana" : "Tarde";
                        Console.WriteLine($" Reserva de {nombre} (Combo: {comboNombre}) en Turno {turnoStr} ha sido cancelada.");
                        return;
                    }
                }
            }
            Console.WriteLine($" Reserva de {nombre} no encontrada.");
        }
    }
}