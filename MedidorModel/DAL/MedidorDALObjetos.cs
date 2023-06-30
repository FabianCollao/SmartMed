using MedidorModel.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedidorModel.DAL
{
    public class MedidorDALObjetos : IMedidorDAL
    {
        private static List<Medidor> medidores = new List<Medidor>();
        public void AgregarMedidor(Medidor medidor)
        {
            medidores.Add(medidor);
        }

        public List<Medidor> ObtenerMedidores()
        {
            return medidores;
        }
    }
}
