using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChurchWin___Camada_de_Dados.Entidades
{
    public class Caixa
    {
        private int COD_CAIXA;

        private string TIPO_LANCAMENTO;

        private string DESCRICAO_LANCAMENTO;

        private float VALOR;

        private DateTime DATA_LANCAMENTO;

        private int IGREJA_COD_IGREJA;

        private int MEMBRO_COD_MEMBRO;

        public int COD_CAIXA1
        {
            get
            {
                return COD_CAIXA;
            }

            set
            {
                COD_CAIXA = value;
            }
        }

        public string TIPO_LANCAMENTO1
        {
            get
            {
                return TIPO_LANCAMENTO;
            }

            set
            {
                TIPO_LANCAMENTO = value;
            }
        }

        public string DESCRICAO_LANCAMENTO1
        {
            get
            {
                return DESCRICAO_LANCAMENTO;
            }

            set
            {
                DESCRICAO_LANCAMENTO = value;
            }
        }

        public float VALOR1
        {
            get
            {
                return VALOR;
            }

            set
            {
                VALOR = value;
            }
        }

        public DateTime DATA_LANCAMENTO1
        {
            get
            {
                return DATA_LANCAMENTO;
            }

            set
            {
                DATA_LANCAMENTO = value;
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

        private Caixa(int codigo, string tipo, string descricao, float valor, DateTime data_lancamento, int cod_igreja, int cod_membro)//Construtor com PK
        {
            COD_CAIXA = codigo;
            TIPO_LANCAMENTO = tipo;
            DESCRICAO_LANCAMENTO = descricao;
            VALOR = valor;
            DATA_LANCAMENTO = data_lancamento;
            IGREJA_COD_IGREJA = cod_igreja;
            MEMBRO_COD_MEMBRO = cod_membro;
        }

        private Caixa( string tipo, string descricao, float valor, DateTime data_lancamento, int cod_igreja, int cod_membro) // Construtor sem PK
        {
            TIPO_LANCAMENTO = tipo;
            DESCRICAO_LANCAMENTO = descricao;
            VALOR = valor;
            DATA_LANCAMENTO = data_lancamento;
            IGREJA_COD_IGREJA = cod_igreja;
            MEMBRO_COD_MEMBRO = cod_membro;
        }
    }
}
