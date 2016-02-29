using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChurchWin___Camada_de_Dados.Entidades
{
    class Tipo
    {
        private int COD_TIPO;

        private string DESCRICAO;

        public int COD_TIPO1
        {
            get
            {
                return COD_TIPO;
            }

            set
            {
                COD_TIPO = value;
            }
        }

        public string DESCRICAO1
        {
            get
            {
                return DESCRICAO;
            }

            set
            {
                DESCRICAO = value;
            }
        }
        public Tipo(int cod_tipo, string descricao) // com pk
        {
            COD_TIPO = cod_tipo;
            DESCRICAO = descricao;
        }

        public Tipo( string descricao) // sem pk
        {
            DESCRICAO = descricao;
        }
    }
}
