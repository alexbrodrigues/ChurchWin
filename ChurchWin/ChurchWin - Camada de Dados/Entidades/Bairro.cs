using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChurchWin___Camada_de_Dados.Entidades
{
    public class Bairro
    {
        private int COD_BAIRRO;

        private string NOME;

        private int MUNICIPIO_COD_MUNICIPIO;

        public int COD_BAIRRO1 // GET E SET
        {
            get
            {
                return COD_BAIRRO;
            }

            set
            {
                COD_BAIRRO = value;
            }
        }

        public string NOME1 //GET E SET
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

        public int MUNICIPIO_COD_MUNICIPIO1 //GET E SET
        {
            get
            {
                return MUNICIPIO_COD_MUNICIPIO;
            }

            set
            {
                MUNICIPIO_COD_MUNICIPIO = value;
            }
        }

        public Bairro(int codigo, string nome, int cod_municipio) // Construtor com PK
        {
            COD_BAIRRO = codigo;
            NOME = nome;
            MUNICIPIO_COD_MUNICIPIO = cod_municipio;
        }

        public Bairro(string nome, int cod_municipio) // Construtor sem PK
        {
            NOME = nome;
            MUNICIPIO_COD_MUNICIPIO = cod_municipio;
        }
    }
}
