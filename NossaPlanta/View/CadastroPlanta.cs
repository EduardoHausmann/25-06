using Model;
using Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View
{
    public partial class CadastroPlanta : Form
    {
        public CadastroPlanta()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (lblId.Text == "")
            {
                Inserir();
            }
            else
            {
                Alterar();
            }
            LimparCampos();
            AtualizarTabela();
        }

        private void Alterar()
        {
            Planta planta = new Planta();
            planta.Id = Convert.ToInt32(lblId.Text);
            planta.Nome = txtNome.Text;
            planta.Altura = Convert.ToDecimal(mtbAltura.Text);
            planta.Peso = Convert.ToDecimal(mtbPeso.Text);
            planta.Carnivora = rbSim.Checked;

            PlantaRepositorio repositorio = new PlantaRepositorio();
            repositorio.Alterar(planta);
        }

        private void Inserir()
        {
            Planta planta = new Planta();
            planta.Nome = txtNome.Text;
            planta.Altura = Convert.ToDecimal(mtbAltura.Text);
            planta.Peso = Convert.ToDecimal(mtbPeso.Text);
            planta.Carnivora = rbSim.Checked;

            PlantaRepositorio repositorio = new PlantaRepositorio();
            repositorio.Inserir(planta);
        }

        private void LimparCampos()
        {
            lblId.Text = 0;
            txtNome.Clear();
            mtbAltura.Clear();
            mtbPeso.Clear();
            rbNao.Checked = false;
            rbSim.Checked = false;
        }

        private void CadastroPlanta_Load(object sender, EventArgs e)
        {
            AtualizarTabela();
        }

        private void AtualizarTabela()
        {
            PlantaRepositorio repopositorio = new PlantaRepositorio();
            string busca = txtBuscar.Text;
            List<Planta> plantas = repopositorio.ObterTodos(busca);
            dgvPlantas.RowCount = 0;
            for (int i = 0; i < plantas.Count; i++)
            {
                Planta planta = plantas[i];
                dgvPlantas.Rows.Add(new object[]
                {
                    planta.Id, planta.Nome, planta.Altura.ToString(), planta.Peso.ToString(), planta.Carnivora.ToString()
                });
            }
        }

        private void txtBuscar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                AtualizarTabela();
            }
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgvPlantas.CurrentRow.Cells[0].Value);
            PlantaRepositorio repositorio = new PlantaRepositorio();
            repositorio.Apagar(id);
            AtualizarTabela();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            PlantaRepositorio repositorio = new PlantaRepositorio();

            int id = Convert.ToInt32(dgvPlantas.CurrentRow.Cells[0].Value);
            Planta planta = repositorio.ObterPeloId(id);
            if (planta != null)
            {
                txtNome.Text = planta.Nome;
                mtbAltura.Text = planta.Altura.ToString("0.00");
                mtbPeso.Text = planta.Peso.ToString("000.00");
                if (planta.Carnivora == true)
                {
                    rbSim.Checked = true;
                }
                else
                {
                    rbNao.Checked = true;
                }
                lblId.Text = planta.Id.ToString();
            }
        }
    }
}
