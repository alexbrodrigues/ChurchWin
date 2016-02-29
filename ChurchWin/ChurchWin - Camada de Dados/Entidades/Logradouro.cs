using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChurchWin___Camada_de_Dados.Entidades
{
    class Logradouro
    {
        private int COD_LOGRADOURO;

        private string NOME;

        private string NUMERO;

        private string CEP;

        private string PONTO_REFERENCIA;

        private int BAIRRO_COD_BAIRRO;

        public int COD_LOGRADOURO1
        {
            get
            {
                return COD_LOGRADOURO;
            }

            set
            {
                COD_LOGRADOURO = value;
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

        public string NUMERO1
        {
            get
            {
                return NUMERO;
            }

            set
            {
                NUMERO = value;
            }
        }

        public string CEP1
        {
            get
            {
                return CEP;
            }

            set
            {
                CEP = value;
            }
        }

        public string PONTO_REFERENCIA1
        {
            get
            {
                return PONTO_REFERENCIA;
            }

            set
            {
                PONTO_REFERENCIA = value;
            }
        }

        public int BAIRRO_COD_BAIRRO1
        {
            get
            {
                return BAIRRO_COD_BAIRRO;
            }

            set
            {
                BAIRRO_COD_BAIRRO = value;
            }
        }

        public Logradouro(int cod_logradouro, string nome, string numero, string cep, string ponto_referencia, int bairro_cod_bairro)//sem pk
        {
            COD_LOGRADOURO = cod_logradouro;
            NOME = nome;
            NUMERO = numero;
            CEP = cep;
            PONTO_REFERENCIA = ponto_referencia;
            BAIRRO_COD_BAIRRO = bairro_cod_bairro;
        }

        public Logradouro(string nome, string numero, string cep, string ponto_referencia, int bairro_cod_bairro) // sem pk
        {
            NOME = nome;
            NUMERO = numero;
            CEP = cep;
            PONTO_REFERENCIA = ponto_referencia;
            BAIRRO_COD_BAIRRO = bairro_cod_bairro;
        }
    }
}
