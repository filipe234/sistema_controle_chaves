using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Controle_Chave_Negocio.Negocio
{
    public class SG_Cadastro_NG
    {
        private static Operador_NG _Operador = null;

        public static Operador_NG Operador
        {
            get
            {
                if ( _Operador == null )
                    _Operador = new Operador_NG();
                return _Operador;
            }
        }
    }
}
