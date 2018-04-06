using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LemafEstagio
{
    public partial class Form1 : Form
    {
        private Sala sala1;
        private Sala sala2;
        private Sala sala3;
        private Sala sala4;
        private Sala sala5;
        private Sala sala6;
        private Sala sala7;
        private Sala sala8;
        private Sala sala9;
        private Sala sala10;
        private Sala sala11;
        private Sala sala12;
        private ArrayList listaSalas;
        private ArrayList listaReservas;


        public Form1()
        {
            InitializeComponent();
            criaSalas();
            iniciaListView();
            this.CenterToScreen();
        }

        //Cria as salas fornecidas pelo desafio
        private void criaSalas()
        {
            listaSalas = new ArrayList();
            listaReservas = new ArrayList();
            sala1 = new Sala(1, 10, true, true, true);
            sala2 = new Sala(2, 10, true, true, true);
            sala3 = new Sala(3, 10, true, true, true);
            sala4 = new Sala(4, 10, true, true, true);
            sala5 = new Sala(5, 10, true, true, true);
            sala6 = new Sala(6, 10, false, true, false);
            sala7 = new Sala(7, 10, false, true, false);
            sala8 = new Sala(8, 3, true, true, true);
            sala9 = new Sala(9, 3, true, true, true);
            sala10 = new Sala(10, 3, true, true, true);
            sala11 = new Sala(11, 20, false, false, false);
            sala12 = new Sala(12, 20, false, false, false);
            listaSalas.Add(sala1);
            listaSalas.Add(sala2);
            listaSalas.Add(sala3);
            listaSalas.Add(sala4);
            listaSalas.Add(sala5);
            listaSalas.Add(sala6);
            listaSalas.Add(sala7);
            listaSalas.Add(sala8);
            listaSalas.Add(sala9);
            listaSalas.Add(sala10);
            listaSalas.Add(sala11);
            listaSalas.Add(sala12);
        }

        //Inicializa o listview com os cabeçalhos
        private void iniciaListView()
        {
            lvReservas.View = View.Details;
            lvReservas.Columns.Add("Data de inicio", 100);
            lvReservas.Columns.Add("Hora de inicio", 100);
            lvReservas.Columns.Add("Sala", 100);
        }
        
        //Adiciona elementos ao listview
        private void initListView()
        {
            lvReservas.Clear();
            iniciaListView();
            foreach (Reserva reserva in listaReservas)
            {
                var itemReserva = new ListViewItem(new[] { reserva.getDataInicio(), reserva.getHoraInicio()
                    , reserva.getNumSala().ToString()});
                lvReservas.Items.Add(itemReserva);
            }
        }


        //Verifica se a data escolhida representa um dia útil.
        public bool isDiaUtil(DateTime date)
        {
            if (date.DayOfWeek != DayOfWeek.Saturday && date.DayOfWeek != DayOfWeek.Sunday)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Decide a melhor sala para a reunião
        public Sala selecionaSala(Reserva reserva)
        {
            Sala sala = null;
            foreach (Sala s in listaSalas)
            {
                if (reserva.getQuantidadePessoas() <= s.getNumLugares())
                {
                    if (reserva.getTvWebcam() && reserva.getAcessoInternet())
                    {
                        if (s.getTemTvWebcam() && s.getTemAcessoInternet())
                        {
                            if (!verificaExistenciaReserva(reserva, s))
                            {
                                sala = s;
                                return sala;
                            }
                        }
                    }
                    else if (reserva.getTvWebcam() && !reserva.getAcessoInternet())
                    {
                        if (s.getTemTvWebcam() && !s.getTemAcessoInternet())
                        {
                            if (!verificaExistenciaReserva(reserva, s))
                            {
                                sala = s;
                                return sala;
                            }
                        }
                    }
                    else if (!reserva.getTvWebcam() && reserva.getAcessoInternet())
                    {
                        if (!s.getTemTvWebcam() && s.getTemAcessoInternet())
                        {
                            if (!verificaExistenciaReserva(reserva, s))
                            {
                                sala = s;
                                return sala;
                            }
                        }
                    }
                    else
                    {
                        if (!verificaExistenciaReserva(reserva, s))
                        {
                            sala = s;
                            return sala;
                        }
                    }
                }
            }
            return sala;
        }

        //Verifica se já foi feita uma reserva na mesma data/horário
        public bool verificaExistenciaReserva(Reserva reserva, Sala sala)
        {
            bool existeReserva = false;
            DateTime dataHoraInicio = ParaDateTime(reserva.getDataInicio(), reserva.getHoraInicio());
            DateTime dataHoraFim = ParaDateTime(reserva.getDataFim(), reserva.getHoraFim());
            foreach (Reserva r in listaReservas)
            {
                DateTime dataHoraRinicio = ParaDateTime(r.getDataInicio(), r.getHoraInicio());
                DateTime dataHoraRfim = ParaDateTime(r.getDataFim(), r.getHoraFim());
                if (r.getNumSala() == sala.getNumSala())
                {
                    if (dataHoraRinicio >= dataHoraInicio && dataHoraRinicio < dataHoraFim)
                    {
                        existeReserva = true;
                    }
                    if (dataHoraRfim > dataHoraInicio && dataHoraRfim <= dataHoraFim)
                    {
                        existeReserva = true;
                    }
                }
            }
            return existeReserva;
        }

        public DateTime ParaDateTime(String data, String hora)
        {
            String dataCompleta = data.Trim() + " " + hora.Trim();
            DateTime dateTime = DateTime.ParseExact(dataCompleta, "dd-MM-yyyy HH:mm",
                             System.Globalization.CultureInfo.InvariantCulture);
            return dateTime;
        }

        //Verifica se a reserva é valida
        public string validaReserva(String data, String dataFinal, int numReserva)
        {
            string resposta = "";
            numReserva = numReserva + 1;
            try
            {
                data = data.Trim();

                DateTime dataReserva = DateTime.ParseExact(data, "dd-MM-yyyy",
                              System.Globalization.CultureInfo.InvariantCulture);

                DateTime dataReservaFinal = DateTime.ParseExact(dataFinal, "dd-MM-yyyy",
                             System.Globalization.CultureInfo.InvariantCulture);

                DateTime dataAtual = DateTime.ParseExact(DateTime.Now.ToString("dd-MM-yyyy"), "dd-MM-yyyy",
                                      System.Globalization.CultureInfo.InvariantCulture);

                double numDias = (dataReserva - dataAtual).TotalDays;
                double numHoras = (dataReserva - dataReservaFinal).TotalHours;
                if (numDias < 0)
                {
                    resposta = "Reserva nº " + numReserva + ": Possui data inválida!";
                }
                else if (numDias == 0)
                {
                    resposta = "Reserva nº " + numReserva + ": A reserva deve ser feita com pelo menos 1 dia de antecedência";
                }
                else if (numDias > 40)
                {
                    resposta = "Reserva nº " + numReserva + ": A reserva não pode ser feita com mais de 40 dias de antecedência";
                }
                else if (!isDiaUtil(dataReserva))
                {
                    resposta = "Reserva nº " + numReserva + ": Reservas só podem ser feitas em dia útil!";
                }
                else if (numHoras > 8)
                {
                    resposta = "Reserva nº " + numReserva + ": A reunião deve durar até 8 horas!";
                }

            }
            catch (Exception ex)
            {
                Console.Write("EXCESSAO DATA " + ex);
                resposta = "Reserva nº " + numReserva + ": Possui data inválida!";
            }
            return resposta;
        }

        //Carrega o arquivo de reservas e adiciona reservas válidas
        private void bCarregar_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog1 = new OpenFileDialog();
                openFileDialog1.Filter = "Arquivos de texto | *.txt";
                if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    System.IO.StreamReader sr = new System.IO.StreamReader(openFileDialog1.FileName);
                    textDiretorio.Text = openFileDialog1.FileName;
                    string texto = sr.ReadToEnd().Trim();
                    sr.Close();
                    if (texto.Length > 0)
                    {
                        string[] textoSplit = texto.Split('\n');
                        for (int i = 0; i < textoSplit.Length; i++)
                        {
                            string[] reservaSplit = textoSplit[i].Split(';');
                            string dataInicio = reservaSplit[0];
                            string horaInicio = reservaSplit[1];
                            string dataFim = reservaSplit[2];
                            string horaFIm = reservaSplit[3];
                            int quantidadePessos = int.Parse(reservaSplit[4]);
                            bool temAcessoInternet;
                            bool temTVeWebcam;
                            string acessoInternet = reservaSplit[5].ToUpper();
                            if (acessoInternet.Equals("SIM"))
                            {
                                temAcessoInternet = true;
                            }
                            else
                            {
                                temAcessoInternet = false;
                            }
                            string tvEwebcam = reservaSplit[6].ToUpper().Trim();
                            if (tvEwebcam.Equals("SIM"))
                            {
                                temTVeWebcam = true;
                            }
                            else
                            {
                                temTVeWebcam = false;
                            }
                            string resposta = validaReserva(dataInicio, dataFim, i);
                            if (resposta.Equals(""))
                            {
                                Reserva reserva = new Reserva(dataInicio, horaInicio, dataFim, horaFIm, quantidadePessos, temAcessoInternet, temTVeWebcam);
                                Sala sala = selecionaSala(reserva);
                                int numReserva = i + 1;
                                if (sala != null)
                                {
                                    reserva.setNumSala(sala.getNumSala());
                                    listaReservas.Add(reserva);
                                    MessageBox.Show("Reserva nº " + numReserva + ": Cadastrada! \n" + "Sala:" + sala.getNumSala());
                                }
                                else
                                {
                                    MessageBox.Show("Reserva nº " + numReserva + ": Não possui vagas para a data!");
                                }
                            }
                            else
                            {
                                MessageBox.Show(resposta);
                            }

                        }

                    }
                }
                initListView();
            }
            catch (Exception ex)
            {
                Console.Write(ex);
            }

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        
        private void bGerarArquivo_Click(object sender, EventArgs e)
        {
            String texto = "";
            int count = 1;
            if (listaReservas.Count > 0)
            {
                foreach (Reserva r in listaReservas)
                {
                    texto += "Reserva " + count + ": " + "Sala " + r.getNumSala() + " / De " + r.getDataInicio() +
                        " às " + r.getHoraInicio() + " até " + r.getDataFim() + " às " + r.getHoraFim() + "\r\n";
                    count += + 1;
                }
                geraArquivoTexto(texto);
            }
            else
            {
                MessageBox.Show("Faça pelo menos uma reserva!");
            }
        }

        //Função utilizada para gerar o arquivo de texto
        public void geraArquivoTexto(String texto)
        {
            try
            {
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.Filter = "txt files (*.txt)|*.txt";
                saveFileDialog1.FilterIndex = 2;
                saveFileDialog1.RestoreDirectory = true;

                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    using (StreamWriter writer = new StreamWriter(saveFileDialog1.FileName))
                    {
                        writer.WriteLine(texto);
                        writer.Close();
                        MessageBox.Show("Arquivo criado com sucesso!");
                    }
                }
            }catch(Exception e)
            {
                Console.Write("EXCESSAO " + e);
                MessageBox.Show("Erro ao criar arquivo!");
            }
         
        }
    }
}
