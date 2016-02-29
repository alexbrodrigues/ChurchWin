using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChurchWin___Camada_de_Dados.Entidades
{
    class Municipio
    {
        private int COD_MUNICIPIO;

        private string NOME;

        private string SIGLA;

        private int ESTADO_COD_ESTADO;

        public int COD_MUNICIPIO1
        {
            get
            {
                return COD_MUNICIPIO;
            }

            set
            {
                COD_MUNICIPIO = value;
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

        public int ESTADO_COD_ESTADO1
        {
            get
            {
                return ESTADO_COD_ESTADO;
            }

            set
            {
                ESTADO_COD_ESTADO = value;
            }
        }

        public string SIGLA1
        {
            get
            {
                return SIGLA;
            }

            set
            {
                SIGLA = value;
            }
        }

        public Municipio(int cod_municipio, string nome, string sigla, int estado_cod_estado) //com pk
        {
            COD_MUNICIPIO = cod_municipio;
            NOME = nome;
            SIGLA = sigla;
            ESTADO_COD_ESTADO = estado_cod_estado;
        }

        public Municipio( string nome, string sigla, int estado_cod_estado) //sem pk
        {
            NOME = nome;
            SIGLA = sigla;
            ESTADO_COD_ESTADO = estado_cod_estado;
        }
    }
}
