using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemafEstagio
{
    public class Sala
    {
        private int num_sala;
        private int num_lugares;
        private bool tem_computador;
        private bool tem_acesso_internet;
        private bool tem_tv_webcam;

        public Sala(int num_sala, int num_lugares, bool tem_computador, bool tem_acesso_internet, bool tem_tv_webcam)
        {
            this.num_sala = num_sala;
            this.num_lugares = num_lugares;
            this.tem_computador = tem_computador;
            this.tem_acesso_internet = tem_acesso_internet;
            this.tem_tv_webcam = tem_tv_webcam;
        }

        public int getNumLugares()
        {
            return num_lugares;
        }

        public bool getTemComputador()
        {
            return tem_computador;
        }

        public bool getTemAcessoInternet()
        {
            return tem_acesso_internet;
        }

        public bool getTemTvWebcam()
        {
            return tem_tv_webcam;
        }

    
        public int getNumSala()
        {
            return num_sala;
        }

        public void setNumSala(int num_sala)
        {
            this.num_sala = num_sala;
        }
    }
}
