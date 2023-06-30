using MedidorModel.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedidorModel.DAL
{
    public interface ILecturaDAL
    {
        List<Lectura> ObtenerLecturas();

        void AgregarLectura(Lectura lecturas);

        
    }
}
