using System;
using System.Collections.Generic;
using System.Linq;
using MetroFramework.Forms;
using System.Windows.Forms;
using DTO;
using BLL;

namespace UI
{
    public partial class MainForm : MetroForm
    {

        private List<Contato> contatosList;

        public MainForm()
        {
            InitializeComponent();

            this.MaximizeBox = false;

            contatosList = new AppController().getContatosList();

            if (contatosList != null)
            {
                grid_contatos.DataSource = contatosList.OrderBy(x => x.Nome).ThenBy(x => x.Setor).ToList();

                grid_contatos.Columns[0].Width = 168;

                grid_contatos.Columns[1].Width = 210;
                grid_contatos.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                grid_contatos.Columns[2].Width = 236;
                grid_contatos.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                grid_contatos.Columns[3].Width = 50;
                grid_contatos.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                grid_contatos.Columns[4].Width = 100;
                grid_contatos.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                grid_contatos.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;


                foreach (DataGridViewColumn c in grid_contatos.Columns)
                {
                    c.ReadOnly = true;
                }

                txt_search.Select();
            }
            else
            {

            }                                                                   
        }
              
        private void txt_search_TextChanged(object sender, System.EventArgs e)
        {
            string text = txt_search.Text;

            if (contatosList != null)
            {
                grid_contatos.DataSource = contatosList.Where(x => x.Nome.ToLower().Contains(text.ToLower()) || x.Email.ToLower().Contains(text.ToLower()) ||
                                                            x.Ramal.ToLower().Contains(text.ToLower()) || x.Celular.ToLower().Contains(text.ToLower()) ||
                                                            x.Setor.ToLower().Contains(text.ToLower())).OrderBy(x => x.Nome).ThenBy(x => x.Setor).ToList();
            }
        }

        private void grid_contatos_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            grid_contatos.ClearSelection();
        }

        private void defaultTab()
        {
            tabControl_1.SelectedTab = tab_contatos;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (contatosList == null)
            {
                string msg = "Não foi possível carregar a lista de contatos. Deseja continuar?";
                DialogResult result = MessageBox.Show(msg, "Contact Finder", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.No)
                {
                    Application.Exit();
                }                
            }

            defaultTab();
        }

        private void lnk_experimente_Click(object sender, EventArgs e)
        {
            defaultTab();
        }

    }   
}
