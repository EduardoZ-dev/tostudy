using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Cliente
    {
        public string NombreCliente { set; get; }
        public string NumeroPasaporte { set; get; } = string.Empty;
        public Vuelo VueloReservado { set; get; }    
       

        public Cliente(string nombreclientes,string numeropasaporte,Vuelo vuelosRes) 
        {
            NombreCliente = nombreclientes;
            NumeroPasaporte = numeropasaporte;
            VueloReservado = vuelosRes;
        
        }
      /*  void ReservarVuelo(Vuelo vuelo)
        {
            if()
        }*/
    }

}
