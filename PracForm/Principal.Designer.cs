namespace PracForm
{
    partial class Principal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel2 = new Panel();
            panel1 = new Panel();
            txtCantidad = new TextBox();
            label1 = new Label();
            dgvDatos = new DataGridView();
            colradio = new DataGridViewTextBoxColumn();
            colRelleno = new DataGridViewTextBoxColumn();
            colBorde = new DataGridViewTextBoxColumn();
            colArea = new DataGridViewTextBoxColumn();
            colVolumen = new DataGridViewTextBoxColumn();
            toolStrip1 = new ToolStrip();
            tsbNuevo = new ToolStripButton();
            tsbBorrar = new ToolStripButton();
            tsbEditar = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            tsbFiltro = new ToolStripDropDownButton();
            porRadioToolStripMenuItem = new ToolStripMenuItem();
            porBordeToolStripMenuItem = new ToolStripMenuItem();
            tsbCboBordes = new ToolStripComboBox();
            porRellenoToolStripMenuItem = new ToolStripMenuItem();
            tsbActualizar = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            tsbOrdenar = new ToolStripDropDownButton();
            ascendenteToolStripMenuItem = new ToolStripMenuItem();
            descendenteToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator3 = new ToolStripSeparator();
            tsbSalir = new ToolStripButton();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDatos).BeginInit();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(panel1);
            panel2.Controls.Add(dgvDatos);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 27);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(682, 311);
            panel2.TabIndex = 4;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlDarkDark;
            panel1.Controls.Add(txtCantidad);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 241);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(682, 70);
            panel1.TabIndex = 2;
            // 
            // txtCantidad
            // 
            txtCantidad.Enabled = false;
            txtCantidad.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            txtCantidad.Location = new Point(146, 18);
            txtCantidad.Margin = new Padding(3, 4, 3, 4);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(114, 27);
            txtCantidad.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 22);
            label1.Name = "label1";
            label1.Size = new Size(133, 20);
            label1.TabIndex = 0;
            label1.Text = "Cantidad registros:";
            // 
            // dgvDatos
            // 
            dgvDatos.AllowUserToAddRows = false;
            dgvDatos.AllowUserToDeleteRows = false;
            dgvDatos.BackgroundColor = SystemColors.ActiveCaption;
            dgvDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDatos.Columns.AddRange(new DataGridViewColumn[] { colradio, colRelleno, colBorde, colArea, colVolumen });
            dgvDatos.Dock = DockStyle.Fill;
            dgvDatos.Location = new Point(0, 0);
            dgvDatos.Margin = new Padding(3, 4, 3, 4);
            dgvDatos.MultiSelect = false;
            dgvDatos.Name = "dgvDatos";
            dgvDatos.ReadOnly = true;
            dgvDatos.RowHeadersWidth = 62;
            dgvDatos.RowTemplate.Height = 25;
            dgvDatos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDatos.Size = new Size(682, 311);
            dgvDatos.TabIndex = 0;
            dgvDatos.CellContentClick += dgvDatos_CellContentClick;
            // 
            // colradio
            // 
            colradio.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colradio.HeaderText = "Radio";
            colradio.MinimumWidth = 8;
            colradio.Name = "colradio";
            colradio.ReadOnly = true;
            colradio.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // colRelleno
            // 
            colRelleno.HeaderText = "Relleno";
            colRelleno.MinimumWidth = 8;
            colRelleno.Name = "colRelleno";
            colRelleno.ReadOnly = true;
            colRelleno.Width = 150;
            // 
            // colBorde
            // 
            colBorde.HeaderText = "Borde";
            colBorde.MinimumWidth = 8;
            colBorde.Name = "colBorde";
            colBorde.ReadOnly = true;
            colBorde.Width = 150;
            // 
            // colArea
            // 
            colArea.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colArea.HeaderText = "Area";
            colArea.MinimumWidth = 8;
            colArea.Name = "colArea";
            colArea.ReadOnly = true;
            colArea.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // colVolumen
            // 
            colVolumen.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colVolumen.HeaderText = "Vollumen";
            colVolumen.MinimumWidth = 8;
            colVolumen.Name = "colVolumen";
            colVolumen.ReadOnly = true;
            colVolumen.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(24, 24);
            toolStrip1.Items.AddRange(new ToolStripItem[] { tsbNuevo, tsbBorrar, tsbEditar, toolStripSeparator1, tsbFiltro, tsbActualizar, toolStripSeparator2, tsbOrdenar, toolStripSeparator3, tsbSalir });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Padding = new Padding(0, 0, 2, 0);
            toolStrip1.Size = new Size(682, 27);
            toolStrip1.TabIndex = 3;
            toolStrip1.Text = "toolStrip1";
            // 
            // tsbNuevo
            // 
            tsbNuevo.ImageScaling = ToolStripItemImageScaling.None;
            tsbNuevo.ImageTransparentColor = Color.Magenta;
            tsbNuevo.Name = "tsbNuevo";
            tsbNuevo.Size = new Size(56, 24);
            tsbNuevo.Text = "Nuevo";
            tsbNuevo.TextImageRelation = TextImageRelation.ImageAboveText;
            tsbNuevo.Click += tsbNuevo_Click;
            // 
            // tsbBorrar
            // 
            tsbBorrar.ImageScaling = ToolStripItemImageScaling.None;
            tsbBorrar.ImageTransparentColor = Color.Magenta;
            tsbBorrar.Name = "tsbBorrar";
            tsbBorrar.Size = new Size(54, 24);
            tsbBorrar.Text = "Borrar";
            tsbBorrar.TextImageRelation = TextImageRelation.ImageAboveText;
            tsbBorrar.Click += tsbBorrar_Click;
            // 
            // tsbEditar
            // 
            tsbEditar.ImageScaling = ToolStripItemImageScaling.None;
            tsbEditar.ImageTransparentColor = Color.Magenta;
            tsbEditar.Name = "tsbEditar";
            tsbEditar.Size = new Size(52, 24);
            tsbEditar.Text = "Editar";
            tsbEditar.TextImageRelation = TextImageRelation.ImageAboveText;
            tsbEditar.Click += tsbEditar_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 27);
            // 
            // tsbFiltro
            // 
            tsbFiltro.DropDownItems.AddRange(new ToolStripItem[] { porRadioToolStripMenuItem, porBordeToolStripMenuItem, porRellenoToolStripMenuItem });
            tsbFiltro.ImageScaling = ToolStripItemImageScaling.None;
            tsbFiltro.ImageTransparentColor = Color.Magenta;
            tsbFiltro.Name = "tsbFiltro";
            tsbFiltro.Size = new Size(61, 24);
            tsbFiltro.Text = "Filtrar";
            tsbFiltro.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // porRadioToolStripMenuItem
            // 
            porRadioToolStripMenuItem.Name = "porRadioToolStripMenuItem";
            porRadioToolStripMenuItem.Size = new Size(224, 26);
            porRadioToolStripMenuItem.Text = "Por Radio";
            // 
            // porBordeToolStripMenuItem
            // 
            porBordeToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { tsbCboBordes });
            porBordeToolStripMenuItem.Name = "porBordeToolStripMenuItem";
            porBordeToolStripMenuItem.Size = new Size(224, 26);
            porBordeToolStripMenuItem.Text = "Por Borde";
            // 
            // tsbCboBordes
            // 
            tsbCboBordes.DropDownStyle = ComboBoxStyle.DropDownList;
            tsbCboBordes.Name = "tsbCboBordes";
            tsbCboBordes.Size = new Size(121, 28);
            // 
            // porRellenoToolStripMenuItem
            // 
            porRellenoToolStripMenuItem.Name = "porRellenoToolStripMenuItem";
            porRellenoToolStripMenuItem.Size = new Size(224, 26);
            porRellenoToolStripMenuItem.Text = "Por Relleno";
            // 
            // tsbActualizar
            // 
            tsbActualizar.ImageScaling = ToolStripItemImageScaling.None;
            tsbActualizar.ImageTransparentColor = Color.Magenta;
            tsbActualizar.Name = "tsbActualizar";
            tsbActualizar.Size = new Size(79, 24);
            tsbActualizar.Text = "Actualizar";
            tsbActualizar.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 27);
            // 
            // tsbOrdenar
            // 
            tsbOrdenar.DropDownItems.AddRange(new ToolStripItem[] { ascendenteToolStripMenuItem, descendenteToolStripMenuItem });
            tsbOrdenar.ImageScaling = ToolStripItemImageScaling.None;
            tsbOrdenar.ImageTransparentColor = Color.Magenta;
            tsbOrdenar.Name = "tsbOrdenar";
            tsbOrdenar.Size = new Size(77, 24);
            tsbOrdenar.Text = "Ordenar";
            tsbOrdenar.TextImageRelation = TextImageRelation.ImageAboveText;
            tsbOrdenar.Click += tsbOrdenar_Click;
            // 
            // ascendenteToolStripMenuItem
            // 
            ascendenteToolStripMenuItem.Name = "ascendenteToolStripMenuItem";
            ascendenteToolStripMenuItem.Size = new Size(224, 26);
            ascendenteToolStripMenuItem.Text = "Ascendente";
            ascendenteToolStripMenuItem.Click += ascendenteToolStripMenuItem_Click;
            // 
            // descendenteToolStripMenuItem
            // 
            descendenteToolStripMenuItem.Name = "descendenteToolStripMenuItem";
            descendenteToolStripMenuItem.Size = new Size(224, 26);
            descendenteToolStripMenuItem.Text = "Descendente";
            descendenteToolStripMenuItem.Click += descendenteToolStripMenuItem_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(6, 27);
            // 
            // tsbSalir
            // 
            tsbSalir.ImageScaling = ToolStripItemImageScaling.None;
            tsbSalir.ImageTransparentColor = Color.Magenta;
            tsbSalir.Name = "tsbSalir";
            tsbSalir.Size = new Size(42, 24);
            tsbSalir.Text = "Salir";
            tsbSalir.TextImageRelation = TextImageRelation.ImageAboveText;
            tsbSalir.Click += tsbSalir_Click;
            // 
            // Principal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(682, 338);
            Controls.Add(panel2);
            Controls.Add(toolStrip1);
            Margin = new Padding(2);
            Name = "Principal";
            Text = "Form1";
            Load += Principal_Load;
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDatos).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel2;
        private DataGridView dgvDatos;
        private DataGridViewTextBoxColumn colradio;
        private DataGridViewTextBoxColumn colRelleno;
        private DataGridViewTextBoxColumn colBorde;
        private DataGridViewTextBoxColumn colArea;
        private DataGridViewTextBoxColumn colVolumen;
        private ToolStrip toolStrip1;
        private ToolStripButton tsbNuevo;
        private ToolStripButton tsbBorrar;
        private ToolStripButton tsbEditar;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripDropDownButton tsbFiltro;
        private ToolStripMenuItem porRadioToolStripMenuItem;
        private ToolStripMenuItem porBordeToolStripMenuItem;
        private ToolStripComboBox tsbCboBordes;
        private ToolStripMenuItem porRellenoToolStripMenuItem;
        private ToolStripButton tsbActualizar;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripDropDownButton tsbOrdenar;
        private ToolStripMenuItem ascendenteToolStripMenuItem;
        private ToolStripMenuItem descendenteToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripButton tsbSalir;
        private Panel panel1;
        private TextBox txtCantidad;
        private Label label1;
    }
}
