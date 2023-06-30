using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedidorModel.DTO
{
    public class Lectura
    {
        private Medidor medidor;
        private DateTime fechaLectura;
        private string horaLectura;
        private decimal valorConsumo;

        public Medidor Medidor { get => medidor; set => medidor = value; }
        public DateTime FechaLectura { get => fechaLectura; set => fechaLectura = value; }
        public string HoraLectura { get => horaLectura; set => horaLectura = value; }
        public decimal ValorConsumo { get => valorConsumo; set => valorConsumo = value; }
        
    }

}
