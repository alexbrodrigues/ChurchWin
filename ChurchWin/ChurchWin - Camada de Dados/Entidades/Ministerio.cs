using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChurchWin___Camada_de_Dados.Entidades
{
    class Ministerio
    {
        private int COD_MINISTERIO;

        private string NOME_MINISTERIO;

        private string DESCRICAO;

        private int IGREJA_COD_IGREJA;

        private int MEMBRO_COD_MEMBRO;

        private string ATIVO;

        public int COD_MINISTERIO1
        {
            get
            {
                return COD_MINISTERIO;
            }

            set
            {
                COD_MINISTERIO = value;
            }
        }

        public string NOME_MINISTERIO1
        {
            get
            {
                return NOME_MINISTERIO;
            }

            set
            {
                NOME_MINISTERIO = value;
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

        public int IGREJA_COD_IGREJA1
        {
            get
            {
                return IGREJA_COD_IGREJA;
            }

            set
            {
                IGREJA_COD_IGREJA = value;
            }
        }

        public int MEMBRO_COD_MEMBRO1
        {
            get
            {
                return MEMBRO_COD_MEMBRO;
            }

            set
            {
                MEMBRO_COD_MEMBRO = value;
            }
        }

        public string ATIVO1
        {
            get
            {
                return ATIVO;
            }

            set
            {
                ATIVO = value;
            }
        }

        public Ministerio (int cod_ministerio, string nome_ministerio, string descricao, int igreja_cod_igreja, int membro_cod_membro, string ativo) //com pk
        {
            COD_MINISTERIO = cod_ministerio;
            NOME_MINISTERIO = nome_ministerio;
            DESCRICAO = descricao;
            IGREJA_COD_IGREJA = igreja_cod_igreja;
            MEMBRO_COD_MEMBRO = membro_cod_membro;
            ATIVO = ativo;
        }

        public Ministerio( string nome_ministerio, string descricao, int igreja_cod_igreja, int membro_cod_membro, string ativo) //sem pk
        {
            NOME_MINISTERIO = nome_ministerio;
            DESCRICAO = descricao;
            IGREJA_COD_IGREJA = igreja_cod_igreja;
            MEMBRO_COD_MEMBRO = membro_cod_membro;
            ATIVO = ativo;
        }
    }
}
