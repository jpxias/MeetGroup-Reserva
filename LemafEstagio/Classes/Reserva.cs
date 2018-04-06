using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemafEstagio
{
    public class Reserva
    {
        private string data_inicio;
        private string hora_inicio;
        private string data_fim;
        private string hora_fim;
        private int quantidade_pessoas;
        private bool acesso_internet;
        private bool tv_webcam;
        private int numSala = -1;

        public Reserva(string data_inicio, string hora_inicio, string data_fim, string hora_fim, int quantidade_pessoas, bool acesso_internet, bool tv_webcam)
        {
            this.data_inicio = data_inicio;
            this.hora_inicio = hora_inicio;
            this.data_fim = data_fim;
            this.hora_fim = hora_fim;
            this.quantidade_pessoas = quantidade_pessoas;
            this.acesso_internet = acesso_internet;
            this.tv_webcam = tv_webcam;
        }

        public string getDataInicio()
        {
            return data_inicio;
        }

      
        public string getHoraInicio()
        {
            return hora_inicio;
        }

        public string getDataFim()
        {
            return data_fim;
        }

        public string getHoraFim()
        {
            return hora_fim;
        }

        public int getQuantidadePessoas()
        {
            return quantidade_pessoas;
        }

        public bool getAcessoInternet()
        {
            return acesso_internet;
        }

        public bool getTvWebcam()
        {
            return tv_webcam;
        }

        public int getNumSala()
        {
            return numSala;
        }

        public void setNumSala(int num)
        {
            this.numSala = num;
        }
    }
}
