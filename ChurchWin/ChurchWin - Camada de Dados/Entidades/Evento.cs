using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChurchWin___Camada_de_Dados.Entidades
{
    class Evento
    {
        private int COD_EVENTO;

        private string DESCRICAO;

        private int QTD_PESSOAS;

        private DateTime DATA_INICIO;

        private DateTime DATA_FINAL;

        private int MEMBRO_COD_MEMBRO;

        private int IGREJA_COD_IGREJA;

        private string ATIVO;

        public int COD_EVENTO1
        {
            get
            {
                return COD_EVENTO;
            }

            set
            {
                COD_EVENTO = value;
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

        public int QTD_PESSOAS1
        {
            get
            {
                return QTD_PESSOAS;
            }

            set
            {
                QTD_PESSOAS = value;
            }
        }

        public DateTime DATA_INICIO1
        {
            get
            {
                return DATA_INICIO;
            }

            set
            {
                DATA_INICIO = value;
            }
        }

        public DateTime DATA_FINAL1
        {
            get
            {
                return DATA_FINAL;
            }

            set
            {
                DATA_FINAL = value;
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

        public Evento ( int cod_evento, string descricao, int qtd_pessoas, DateTime data_inicio, DateTime data_final, int membro_cod_membro, int igreja_cod_igreja, string ativo) // com PK
        {
            COD_EVENTO = cod_evento;
            DESCRICAO = descricao;
            QTD_PESSOAS = qtd_pessoas;
            DATA_INICIO = data_inicio;
            DATA_FINAL = data_final;
            MEMBRO_COD_MEMBRO = membro_cod_membro;
            IGREJA_COD_IGREJA = igreja_cod_igreja;
            ATIVO = ativo;
        }

        public Evento( string descricao, int qtd_pessoas, DateTime data_inicio, DateTime data_final, int membro_cod_membro, int igreja_cod_igreja, string ativo) //sem PK
        {
            DESCRICAO = descricao;
            QTD_PESSOAS = qtd_pessoas;
            DATA_INICIO = data_inicio;
            DATA_FINAL = data_final;
            MEMBRO_COD_MEMBRO = membro_cod_membro;
            IGREJA_COD_IGREJA = igreja_cod_igreja;
            ATIVO = ativo;
        }
    }
}
