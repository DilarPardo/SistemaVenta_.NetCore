using SistemaVentaEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVentaBLL.Interfaces
{
    public interface IUsuarioService
    {

        Task<List<Usuario>> Lista();

        Task<Usuario>Crear(Usuario entidad, Stream foto = null, string nombreFoto="", string urlPlantillaCorreo="");

        Task<Usuario> Editar(Usuario entidad, Stream foto = null, string nombreFoto = "");

    }
}
