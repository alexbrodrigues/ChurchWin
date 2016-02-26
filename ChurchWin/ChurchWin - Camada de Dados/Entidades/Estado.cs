using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChurchWin___Camada_de_Dados.Entidades
{
    class Estado
    {
        private int COD_ESTADO;

        private string NOME;

        private string SIGLA;

        private int PAIS_COD_PAIS;

        public int COD_ESTADO1
        {
            get
            {
                return COD_ESTADO;
            }

            set
            {
                COD_ESTADO = value;
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

        public int PAIS_COD_PAIS1
        {
            get
            {
                return PAIS_COD_PAIS;
            }

            set
            {
                PAIS_COD_PAIS = value;
            }
        }

        public Estado(int cod_estado, string nome, string sigla, int pais_cod_pais)// Construtor com PK
        {
            COD_ESTADO = cod_estado;
            NOME = nome;
            SIGLA = sigla;
            PAIS_COD_PAIS = pais_cod_pais;
        }

        public Estado(string nome, string sigla, int pais_cod_pais)//Construtor sem PK
        {
            NOME = nome;
            SIGLA = sigla;
            PAIS_COD_PAIS = pais_cod_pais;
        }
    }
}
