using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChurchWin___Camada_de_Dados.Entidades
{
    class Cargo
    {
        private int COD_CARGO;
        private string DESCRICAO;
        private int PESSOA_COD_MEMBRO;

        public int COD_CARGO1
        {
            get
            {
                return COD_CARGO;
            }

            set
            {
                COD_CARGO = value;
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

        public int PESSOA_COD_MEMBRO1
        {
            get
            {
                return PESSOA_COD_MEMBRO;
            }

            set
            {
                PESSOA_COD_MEMBRO = value;
            }
        }
        public Cargo (int cod_cargo, string descricao, int cod_pessoa_membro)
        {
            COD_CARGO = cod_cargo;
            DESCRICAO = descricao;
            PESSOA_COD_MEMBRO = cod_pessoa_membro;
        }
        public Cargo(string descricao, int Pessoa_cod_Membro)
        {
            DESCRICAO = descricao;
            PESSOA_COD_MEMBRO = Pessoa_cod_Membro;
        }
    }
}
