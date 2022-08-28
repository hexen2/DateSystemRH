using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateSystemRH
{
    class PassagemCriminal
    {
        public PassagemCriminal()
        {
            this.Id_PessoasPassagemCriminal = 0;
            this.checkboxPassagemCriminal = 0;
            this.txtComentarios = "";
        }
        public PassagemCriminal(int ID_PESSOA_PASSAGEM_CRIMINAL, int CHECKBOXPASSAGEMCRIMINAL, string TXTCOMENTARIOS)
        {
            this.Id_PessoasPassagemCriminal = ID_PESSOA_PASSAGEM_CRIMINAL;
            this.checkboxPassagemCriminal = CHECKBOXPASSAGEMCRIMINAL;
            this.txtComentarios = TXTCOMENTARIOS;
        }
        private int ID_PESSOA_PASSAGEM_CRIMINAL;
        public int Id_PessoasPassagemCriminal
        {
            get
            {
                return this.ID_PESSOA_PASSAGEM_CRIMINAL;

            }
            set
            {
                this.ID_PESSOA_PASSAGEM_CRIMINAL = value;
            }
        }

        private int CHECKBOXPASSAGEMCRIMINAL;
        public int checkboxPassagemCriminal
        {
            get
            {
                return this.CHECKBOXPASSAGEMCRIMINAL;

            }
            set
            {
                this.CHECKBOXPASSAGEMCRIMINAL = value;
            }
        }
        private string TXTCOMENTARIOS;
        public string txtComentarios
        {
            get
            {
                return this.TXTCOMENTARIOS;

            }
            set
            {
                this.TXTCOMENTARIOS = value;
            }
        }
    }
}
