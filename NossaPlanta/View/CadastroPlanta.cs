using Model;
using Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            Planta planta = new Planta();
            planta.Nome = txtNome.Text;
            planta.Altura = Convert.ToDecimal(mtbAltura.Text);
            planta.Peso = Convert.ToDecimal(mtbPeso.Text);
            planta.Carnivora = rbSim.Checked;

            PlantaRepositorio repositorio = new PlantaRepositorio();
            repositorio.Inserir(planta);
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
    }
}
