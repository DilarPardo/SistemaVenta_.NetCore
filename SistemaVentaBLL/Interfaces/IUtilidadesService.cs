using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVentaBLL.Interfaces
{
    public interface IUtilidadesService
    {

        string GenerarClave();

        string ConvertirSha258(string texto);

    }
}
