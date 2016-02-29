using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChurchWin___Camada_de_Dados.Entidades
{
    class Pais
    {
        private int COD_PAIS;

        private string NOME;

        private string SIGLA;

        public int COD_PAIS1
        {
            get
            {
                return COD_PAIS;
            }

            set
            {
                COD_PAIS = value;
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

        public Pais(int cod_pais, string nome, string sigla) //com pk
        {
            COD_PAIS = cod_pais;
            NOME = nome;
            SIGLA = sigla;
        }

        public Pais( string nome, string sigla) //sem pk
        {
            NOME = nome;
            SIGLA = sigla;
        }
    }
}
