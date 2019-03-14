using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Controle_Chave_Negocio.Negocio
{
    class SG_Cadastro_Chave_NG
    {
        private static Chave_NG _Chave = null;

        public static Chave_NG Chave
        {
            get
            {
                if ( _Chave == null )
                    _Chave = new Chave_NG();
                return _Chave;
            }
        }

    }
}
