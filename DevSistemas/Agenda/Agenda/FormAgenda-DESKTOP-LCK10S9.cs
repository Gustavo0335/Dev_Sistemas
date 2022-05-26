using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agenda
{
    public enum EnumTipo
    {
        Email = 'E',
        Notificação = 'N',
        Tremer = 'T'
    }
    public enum EnumDescrição
    {
        Minuto = 'M',
        Horas = 'H',
        Dias = 'D',
        Semanas = 'S',
        Meses = 'X',
        Anos = 'A'
    }
    public enum EnumTarefa
    {
        Urgente = 'U',
        Alta = 'A',
        Normal = 'N',
        Baixa = 'B',
        Minima = 'M'
    }
    public enum EnumTipoLembrete
    {
        Dia = 'D',
        Semana = 'S',
        Mês = 'M',
        Ano = 'A',
    }

    public enum EnumRepetirLembrete
    {
        Segunda = 'A',
        Terça = 'B',
        Quarta = 'C',
        Quinta = 'D',
        Sexta = 'E',
        Sabado = 'F',
        Domingo = 'G'
    }
    public enum EnumTerminarLembrete
    {
        Nunca = 'N',
        Emdata = 'D',
        AposxOcorrencia = 'A'
    }


    public partial class FormAgenda : Form
    {
        List<compromisso> agenda;
        public FormAgenda(List<compromisso> agenda)
        {
            this.agenda = agenda;

            InitializeComponent();

            evento c1 = new evento("c1", "compromisso c1", new DateTime(2021, 9, 27, 19, 52, 00), new DateTime(2021, 9, 27, 22, 34, 54));
            c1.Notificacao.Add(new notificação((byte)40, 'M', 'N'));
            c1.Notificacao.Add(new notificação((byte)10, 'M', 'N'));
            agenda.Add(c1);

            var e1 = new evento();
            e1.Titulo = "E1";
            e1.Descricao = "Meu primeiro evento!";
            e1.Datahorainicio = new DateTime(2021, 10, 20, 22, 45, 0);
            e1.Datahorafim = new DateTime(2021, 10, 20, 23, 30, 0);
            e1.Notificacao.Add(new notificação((byte)4, 'H', 'E'));
            e1.Notificacao.Add(new notificação((byte)30, 'M', 'N'));

            e1.Local = "Centro de eventos do ABC Bolinhas";
            e1.Convidados.Add("ze@sei.la");
            e1.Convidados.Add("abc@bolinhas");
            e1.Convidados.Add("bolinhas@nem.sei");

            agenda.Add(e1);



            AtlzdataGridViewCompromisso();

        }
        
        public void AtlzdataGridViewCompromisso()
        {
            dataGridViewCompromisso.DataSource = null;
            dataGridViewCompromisso.DataSource = agenda;
        }
        public void AtlzdataGridViewNotificação()
        {
            compromisso aux = (compromisso)dataGridViewCompromisso.CurrentRow.DataBoundItem;
            dataGridViewNotificação.DataSource = null;
            dataGridViewNotificação.DataSource = aux.Notificacao;
        }    
        private void FormAgenda_Load(object sender, EventArgs e)
        {
          
        }
        private void button7_Click(object sender, EventArgs e)
        {
            evento aux = new();
            FormAgenda2 formAge2 = new FormAgenda2(aux, agenda, dataGridViewCompromisso, monthCalendarDataInicio, monthCalendarDatafim);
            formAge2.ShowDialog();
            dataGridViewCompromisso.DataSource = null;
            dataGridViewCompromisso.DataSource = agenda;
            
        }

        private void dataGridViewNotificação_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridViewCompromisso.DataSource = null;
            dataGridViewCompromisso.DataSource = agenda;
        }

        private void dataGridViewCompromisso_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dynamic aux = (dynamic)dataGridViewCompromisso.CurrentRow.DataBoundItem;
          
            if (aux != null)
            {
               
                dataGridViewNotificação.DataSource = null;
                dataGridViewNotificação.DataSource = aux.Notificacao;
                
            }
        }
       
        private void dataGridViewCompromisso_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

           
            dynamic aux = dataGridViewCompromisso.CurrentRow.DataBoundItem;
            MessageBox.Show($"{aux.GetType()}");


            if (aux is evento)
            {
                new FormAgenda2(agenda, aux).ShowDialog();
                dataGridViewCompromisso.DataSource = null;
                dataGridViewCompromisso.DataSource = agenda;           
            }
            else if (aux is Tarefa)
            {
                new FormAgenda2(agenda, aux).ShowDialog();
                dataGridViewCompromisso.DataSource = null;
                dataGridViewCompromisso.DataSource = agenda;
            }
            else if (aux is Lembrete)
            {
                new FormAgenda2(agenda, aux).ShowDialog();
                dataGridViewCompromisso.DataSource = null;
                dataGridViewCompromisso.DataSource = agenda;
            }




        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePickerDatainicio_ValueChanged(object sender, EventArgs e)
        {

        }
       
        private void SalvarTarefa_Click(object sender, EventArgs e)
        {
            Tarefa aux = new();
            FormAgenda2 formAge2 = new FormAgenda2(aux, agenda, dataGridViewCompromisso, monthCalendarDataInicio, monthCalendarDatafim);
            formAge2.ShowDialog();
            dataGridViewCompromisso.DataSource = null;
            dataGridViewCompromisso.DataSource = agenda;
        }

        private void NovoLembrete_Click(object sender, EventArgs e)
        {
            Lembrete aux = new();
            FormAgenda2 formAge2 = new FormAgenda2(aux, agenda, dataGridViewCompromisso, monthCalendarDataInicio, monthCalendarDatafim);
            formAge2.ShowDialog();
            dataGridViewCompromisso.DataSource = null;
            dataGridViewCompromisso.DataSource = agenda;
        }
    }
}
