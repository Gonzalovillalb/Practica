using Practica;
using Practica.Entidades;

namespace PracForm
{
    public partial class Principal : Form
    {
        private Repositorio repo;
        private List<Figura> Lista;
        int intValor;
        public Principal()
        {
            InitializeComponent();
            repo = new Repositorio();
            ActualizarCantidadRegistros();
        }
        private void AgregarFila(DataGridViewRow r)
        {
            dgvDatos.Rows.Add(r);
        }

        private void SetearFila(DataGridViewRow r, Figura figura)
        {
            r.Cells[colradio.Index].Value = figura.GetRadio();
            r.Cells[colBorde.Index].Value = figura.Borde;
            r.Cells[colRelleno.Index].Value = figura.Relleno;
            r.Cells[colVolumen.Index].Value = figura.GetVolumen();
            r.Cells[colArea.Index].Value = figura.GetArea();

            r.Tag = figura;
        }

        private DataGridViewRow ConstruirFila()
        {
            DataGridViewRow r = new DataGridViewRow();
            r.CreateCells(dgvDatos);
            return r;
        }
        private void Principal_Load(object sender, EventArgs e)
        {
            CargarDatosComboBordes();
            if (repo.GetCantidad() > 0)
            {
                Lista = repo.GetLista();
                MostrarDatosEnGrilla();
            }
        }

        private void CargarDatosComboBordes()
        {
            var listaBordes = Enum.GetValues(typeof(Borde))
    .Cast<Borde>().ToList();
            foreach (var itemBorde in listaBordes)
            {
                tsbCboBordes.Items.Add(itemBorde);
            }
            tsbCboBordes.SelectedIndex = -1;
        }

        private void MostrarDatosEnGrilla()
        {
            dgvDatos.Rows.Clear();
            foreach (var figura in Lista)
            {
                DataGridViewRow r = ConstruirFila();
                SetearFila(r, figura);
                AgregarFila(r);
            }
        }

        private void ActualizarCantidadRegistros()
        {

            if (intValor > 0)
            {
                txtCantidad.Text = repo.GetCantidad(intValor).ToString();

            }
            else
            {
                txtCantidad.Text = repo.GetCantidad().ToString();

            }
        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            AgreInfo frm = new AgreInfo() { Text = "Agregar Circunferencia" };
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.Cancel)
            {
                return;
            }
            Figura figura = frm.GetFigura();
            if (!repo.Existe(figura))
            {
                repo.Agregar(figura);
                txtCantidad.Text = repo.GetCantidad().ToString();

                DataGridViewRow r = ConstruirFila();
                SetearFila(r, figura);
                AgregarFila(r);

                MessageBox.Show("Registro agregado", "Mensaje", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Registro existente", "Error", MessageBoxButtons.OK,
    MessageBoxIcon.Error);

            }
        }

        private void tsbBorrar_Click(object sender, EventArgs e)
        {
            if (dgvDatos.SelectedRows.Count == 0)
            {
                return;
            }
            DialogResult dr = MessageBox.Show("¿Desea dar de baja el Figura?",
                "Confirmar Baja",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.No)
            {
                return;
            }
            var filaSeleccionada = dgvDatos.SelectedRows[0];
            Figura figura = filaSeleccionada.Tag as Figura;
            repo.Borrar(figura);
            txtCantidad.Text = repo.GetCantidad().ToString();

            QuitarFila(filaSeleccionada);
            MessageBox.Show("Registro borrado", "Mensaje", MessageBoxButtons.OK,
    MessageBoxIcon.Information);

        }

        private void QuitarFila(DataGridViewRow r)
        {
            dgvDatos.Rows.Remove(r);
        }

        private void tsbSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tsbOrdenar_Click(object sender, EventArgs e)
        {

        }

        private void ascendenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Lista = repo.OrdenarAsc();
            MostrarDatosEnGrilla();
            ActualizarCantidadRegistros();
        }

        private void descendenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Lista = repo.OrdenarDesc();
            MostrarDatosEnGrilla();
            ActualizarCantidadRegistros();
        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {
            if (dgvDatos.SelectedRows.Count == 0)
            {
                return;
            }
            var filaSeleccionada = dgvDatos.SelectedRows[0];

            Figura figura = (Figura)filaSeleccionada.Tag;
            Figura figuraCopia = (Figura)figura.Clone();


            AgreInfo frm = new AgreInfo() { Text = "Editar Circunferencia" };
            frm.SetFigura(figura);
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.Cancel)
            {
                return;
            }
            figura = frm.GetFigura();
            if (!repo.Existe(figura))
            {
                repo.Editar(figuraCopia, figura);
                SetearFila(filaSeleccionada, figura);
                MessageBox.Show("Registro editado", "Mensaje", MessageBoxButtons.OK,
    MessageBoxIcon.Information);

            }
            else
            {
                SetearFila(filaSeleccionada, figuraCopia);
                MessageBox.Show("Registro existente", "Error", MessageBoxButtons.OK,
MessageBoxIcon.Error);

            }
        }

        private void dgvDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
