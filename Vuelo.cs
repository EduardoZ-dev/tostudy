using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Vuelo
    {
        public double NumeroVuelo { private set; get; }
        public string Origen { private set; get; } = string.Empty;
        public string Destino { private set; get; } = string.Empty;
        public DateTime Fecha { private set; get; }
        public DateTime HoraSalida { private set; get; }
        public int MaxCapacidad { private set; get; }
        public double PrecioBase { private set; get; }
        public int AsientosDisp { set; get;} = 240;
        public int AsientosOcup { private set; get; }
        public bool Disponibilidad { private set; get; }
        public Vuelo(double numeroVuelo, string origen, string destino, DateTime fecha, DateTime horaSalida, int maxCapacidad, double precioBase)
        {
            NumeroVuelo = numeroVuelo;
            Origen = origen;
            Destino = destino;
            Fecha = fecha;
            HoraSalida = horaSalida;
            MaxCapacidad = maxCapacidad;
            PrecioBase = precioBase;
        }
        int asientos;
        int salir = 0;
        public void ReservarAsiento()
        {

            do 
            {
                if (AsientosDisp == 0)
                {
                    Disponibilidad = false;
                    Console.WriteLine("Este vuelo no esta disponible");
                    break;
                }
                    Console.WriteLine("******Menu*******");
                    Console.WriteLine("Digite cuantos asientos desea reservar: ");
                    asientos = Convert.ToInt16(Console.ReadLine());
                    AsientosDisp -= asientos;
                if (asientos <= 0)
                    {
                        Console.WriteLine("Digite un valor valido");
                        return;
                    }
                    if (AsientosDisp > asientos)
                    {

                        Console.WriteLine("Ha comprado exitosamente");
                   
                    }
                    if (AsientosDisp < asientos)
                    {
                        Console.WriteLine("No hay suficientes asientos");
                        Console.WriteLine($"Quedan solo {AsientosDisp} Asientos Disponibles");

                    }
                Console.WriteLine("Desea continuar? ");
                Console.WriteLine("1. -> Si, reservar mas asientos");
                Console.WriteLine("2. -> No, deseo salir");
                salir = Convert.ToInt16(Console.ReadLine());
            } while (salir!=2);
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Información del vuelo:");
            sb.AppendLine($"Número de vuelo: {NumeroVuelo}");
            sb.AppendLine($"Origen: {Origen}");
            sb.AppendLine($"Destino: {Destino}");
            sb.AppendLine($"Fecha: {Fecha.ToShortDateString()}");
            sb.AppendLine($"Hora de salida: {HoraSalida.ToShortTimeString()}");
            sb.AppendLine($"Capacidad máxima: {MaxCapacidad}");
            sb.AppendLine($"Precio base, sumado asientos: {PrecioBase * asientos:C}");


            sb.AppendLine();
            sb.AppendLine($"Asientos ocupados: {MaxCapacidad - AsientosDisp}");
            sb.AppendLine($"Asientos disponibles: {AsientosDisp}");
            return sb.ToString();
        }
    }
}