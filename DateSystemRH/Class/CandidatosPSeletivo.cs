using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateSystemRH
{
    class CandidatosPSeletivo
    {
        public CandidatosPSeletivo()
        {
            this.idProcessoSeletivo = 0;
            this.IdPessoa = 0;
        }

        public CandidatosPSeletivo(int ID_PROCESSO_SELETIVO, int ID_PESSOA)
        {

            this.idProcessoSeletivo = ID_PROCESSO_SELETIVO;
            this.IdPessoa = ID_PESSOA;

        }

        private int ID_PROCESSO_SELETIVO;
        public int idProcessoSeletivo
        {
            get
            {
                return this.ID_PROCESSO_SELETIVO;

            }
            set
            {
                this.ID_PROCESSO_SELETIVO = value;
            }
        }
        private int ID_PESSOA;
        public int IdPessoa
        {
            get
            {
                return this.ID_PESSOA;

            }
            set
            {
                this.ID_PESSOA = value;
            }
        }   
    }
}
