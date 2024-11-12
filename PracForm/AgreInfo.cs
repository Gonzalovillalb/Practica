using Practica.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracForm
{
    public partial class AgreInfo : Form
    {
        private Figura figura;
        public AgreInfo()
        {
            InitializeComponent();
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            CargarDatosComboColorRelleno();
            if (figura != null)
            {
                txtRadio.Text = figura.GetRadio().ToString();
                cboColores.SelectedItem = figura.Relleno;
                if (figura.Borde == Borde.Solido)
                {
                    rbtSolido.Checked = true;
                }
                else if (figura.Borde == Borde.Rayas)
                {
                    rbtRayas.Checked = true;
                }
                else
                {
                    rbtPuntos.Checked = true;
                }
            }
        }

        private void CargarDatosComboColorRelleno()
        {
            var listaColores = Enum.GetValues(typeof(Relleno)).Cast<Relleno>().ToList();
            cboColores.DataSource = listaColores;
            cboColores.SelectedIndex = 0;
        }

        internal Figura GetFigura()
        {
            return figura;
        }
        private bool ValidarDatos()
        {
            bool valido = true;
            errorProvider1.Clear();
            if (!int.TryParse(txtRadio.Text, out int Radio))
            {
                valido = false;
                errorProvider1.SetError(txtRadio, "Número mal ingresado");

            }
            else if (Radio <= 0)
            {
                valido = false;
                errorProvider1.SetError(txtRadio, "Valor del Radio no válido");
            }
            return valido;
        }

        private void AgreInfo_Load(object sender, EventArgs e)
        {

        }

        private void btnOK_Click_1(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                if (figura == null)
                {
                    figura = new Figura()
;
                }
                figura.SetRadio(int.Parse(txtRadio.Text));
                figura.Relleno = (Relleno)cboColores.SelectedItem;
                if (rbtSolido.Checked)
                {
                    figura.Borde = Borde.Solido;
                }
                else if (rbtRayas.Checked)
                {
                    figura.Borde = Borde.Rayas;
                }
                else
                {
                    figura.Borde = Borde.Puntos;
                }
                DialogResult = DialogResult.OK;
            }
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        internal void SetFigura(Figura? figura)
        {
            this.figura = figura;
        }
    }
}
