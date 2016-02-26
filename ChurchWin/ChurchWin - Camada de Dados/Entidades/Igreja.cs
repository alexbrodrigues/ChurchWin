using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChurchWin___Camada_de_Dados.Entidades
{
    class Igreja
    {
        private int COD_IGREJA;

        private string NOME;

        private string CNPJ;

        private string TELEFONE;

        private DateTime DATA_CADASTRO;

        private int LOGRADOURO_COD_LOGRADOURO;

        public int COD_IGREJA1
        {
            get
            {
                return COD_IGREJA;
            }

            set
            {
                COD_IGREJA = value;
            }
        }

        public string NOME1
        {
            get
            {
                return NOME;
            }

            set
            {
                NOME = value;
            }
        }

        public string TELEFONE1
        {
            get
            {
                return TELEFONE;
            }

            set
            {
                TELEFONE = value;
            }
        }

        public DateTime DATA_CADASTRO1
        {
            get
            {
                return DATA_CADASTRO;
            }

            set
            {
                DATA_CADASTRO = value;
            }
        }

        public int LOGRADOURO_COD_LOGRADOURO1
        {
            get
            {
                return LOGRADOURO_COD_LOGRADOURO;
            }

            set
            {
                LOGRADOURO_COD_LOGRADOURO = value;
            }
        }

        public Igreja(int cod_igreja, string nome, string cnpj, string telefone, DateTime data_cadastro, int logradouro_cod_logradouro) //com pk
        {
            NOME = nome;
            CNPJ = cnpj;
            TELEFONE = telefone;
            DATA_CADASTRO = data_cadastro;
            LOGRADOURO_COD_LOGRADOURO = logradouro_cod_logradouro;
        }

        public Igreja (string nome, string cnpj, string telefone, DateTime data_cadastro, int logradouro_cod_logradouro) //sem pk
        {
            CNPJ = cnpj;
            TELEFONE = telefone;
            DATA_CADASTRO = data_cadastro;
            LOGRADOURO_COD_LOGRADOURO = logradouro_cod_logradouro;
        }
    }
}
