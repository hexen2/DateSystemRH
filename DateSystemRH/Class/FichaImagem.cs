using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateSystemRH
{
    class FichaImagem
    {
        public FichaImagem()
        {
            this.IdFichaImagem = 0;
            this.IdFicha = 0;
            this.Imagem = null;
            this.IdLoginUsuario = 0;
        }
        public FichaImagem(int ID_FICHA_IMAGEM, int ID_FICHA, byte[] IMAGEM, int ID_LOGIN_USUARIO)
        {
            this.IdFichaImagem = ID_FICHA_IMAGEM;
            this.IdFicha = ID_FICHA;
            this.Imagem = IMAGEM;
            this.IdLoginUsuario = ID_LOGIN_USUARIO;
        }

        private int ID_FICHA_IMAGEM;
        public int IdFichaImagem
        {
            get
            {
                return this.ID_FICHA_IMAGEM;

            }
            set
            {
                this.ID_FICHA_IMAGEM = value;
            }
        }

        private int ID_FICHA;
        public int IdFicha
        {
            get
            {
                return this.ID_FICHA;

            }
            set
            {
                this.ID_FICHA = value;
            }
        }
        private byte[] IMAGEM;
        public byte[] Imagem
        {
            get
            {
                return this.IMAGEM;

            }
            set
            {
                this.IMAGEM = value;
            }
        }
        private int ID_LOGIN_USUARIO;
        public int IdLoginUsuario
        {
            get
            {
                return this.ID_LOGIN_USUARIO;

            }
            set
            {
                this.ID_LOGIN_USUARIO = value;
            }
        }
    }
}
