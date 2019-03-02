using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Controle_Chave_Negocio.Negocio
{
   public class SG_Cadastro_Funcinario_NG
    {
        private static Funcionario_NG __Funcionario = null;

        public static Funcionario_NG Funcionario
        {
            get
            {
                if ( __Funcionario == null )
                    __Funcionario = new Funcionario_NG();
                return __Funcionario;
            }
        }
    }
}
