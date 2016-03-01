using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChurchWin___Camada_de_Dados.Entidades
{
    class Pessoa
    {
        private int COD_PESSOA;

        private string NOME;

        private string SEXO;

        private string RG;

        private string CPF;

        private string CNPJ;

        private string TELEFONE_CEL;

        private string TELEFONE_RES;

        private string EMAIL;

        private DateTime DATA_NASCIMENTO;

        private DateTime DATA_BATISMO;

        private DateTime DATA_CADASTRO;

        private byte[] FOTO;

         private int COD_LOGRADOURO;

        private int COD_IGREJA;

        private string ATIVO;

        private int COD_TIPO;

        public int COD_PESSOA1
        {
            get
            {
                return COD_PESSOA;
            }

            set
            {
                COD_PESSOA = value;
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

        public string SEXO1
        {
            get
            {
                return SEXO;
            }

            set
            {
                SEXO = value;
            }
        }

        public string RG1
        {
            get
            {
                return RG;
            }

            set
            {
                RG = value;
            }
        }

        public string CPF1
        {
            get
            {
                return CPF;
            }

            set
            {
                CPF = value;
            }
        }

        public string CNPJ1
        {
            get
            {
                return CNPJ;
            }

            set
            {
                CNPJ = value;
            }
        }

        public string TELEFONE_CEL1
        {
            get
            {
                return TELEFONE_CEL;
            }

            set
            {
                TELEFONE_CEL = value;
            }
        }

        public string TELEFONE_RES1
        {
            get
            {
                return TELEFONE_RES;
            }

            set
            {
                TELEFONE_RES = value;
            }
        }

        public string EMAIL1
        {
            get
            {
                return EMAIL;
            }

            set
            {
                EMAIL = value;
            }
        }

        public DateTime DATA_NASCIMENTO1
        {
            get
            {
                return DATA_NASCIMENTO;
            }

            set
            {
                DATA_NASCIMENTO = value;
            }
        }

        public DateTime DATA_BATISMO1
        {
            get
            {
                return DATA_BATISMO;
            }

            set
            {
                DATA_BATISMO = value;
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

        public byte[] FOTO1
        {
            get
            {
                return FOTO;
            }

            set
            {
                FOTO = value;
            }
        }
        public Pessoa(int cod_pessoa, string nome, string sexo,  string rg, string cpf, string cnpj, string telefone_cel, string telefone_res, string email, DateTime data_nascimento, DateTime data_batismo, DateTime data_cadastro, byte[] foto, int cod_logradouro, int cod_igreja, string ativo, int cod_tipo) //com pk
        {
            COD_PESSOA = cod_pessoa;
            NOME = nome;
            SEXO = sexo;
            RG = rg;
            CPF = cpf;
            CNPJ = cnpj;
            TELEFONE_CEL = telefone_cel;
            TELEFONE_RES = telefone_res;
            EMAIL = email;
            DATA_NASCIMENTO = data_nascimento;
            DATA_BATISMO = data_batismo;
            DATA_CADASTRO = data_cadastro;
            FOTO = foto;
            COD_LOGRADOURO = cod_logradouro;
            COD_IGREJA = cod_igreja;
            ATIVO = ativo;
            COD_TIPO = cod_tipo;
        }
        public Pessoa( string nome, string sexo, string rg, string cpf, string cnpj, string telefone_cel, string telefone_res, string email, DateTime data_nascimento, DateTime data_batismo, DateTime data_cadastro, byte[] foto, int cod_logradouro, int cod_igreja, string ativo, int cod_tipo)//sem pk
        {
            NOME = nome;
            SEXO = sexo;
            RG = rg;
            CPF = cpf;
            CNPJ = cnpj;
            TELEFONE_CEL = telefone_cel;
            TELEFONE_RES = telefone_res;
            EMAIL = email;
            DATA_NASCIMENTO = data_nascimento;
            DATA_BATISMO = data_batismo;
            DATA_CADASTRO = data_cadastro;
            FOTO = foto;
            COD_LOGRADOURO = cod_logradouro;
            COD_IGREJA = cod_igreja;
            ATIVO = ativo;
            COD_TIPO = cod_tipo;
        }
    }
}
