namespace PracForm
{
    partial class AgreInfo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            gbxBordes = new GroupBox();
            rbtPuntos = new RadioButton();
            rbtRayas = new RadioButton();
            rbtSolido = new RadioButton();
            cboColores = new ComboBox();
            btnCancelar = new Button();
            btnOK = new Button();
            txtRadio = new TextBox();
            label2 = new Label();
            label1 = new Label();
            errorProvider1 = new ErrorProvider(components);
            gbxBordes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // gbxBordes
            // 
            gbxBordes.Controls.Add(rbtPuntos);
            gbxBordes.Controls.Add(rbtRayas);
            gbxBordes.Controls.Add(rbtSolido);
            gbxBordes.Location = new Point(438, 2);
            gbxBordes.Margin = new Padding(4, 5, 4, 5);
            gbxBordes.Name = "gbxBordes";
            gbxBordes.Padding = new Padding(4, 5, 4, 5);
            gbxBordes.Size = new Size(256, 180);
            gbxBordes.TabIndex = 11;
            gbxBordes.TabStop = false;
            gbxBordes.Text = " Tipos de Bordes ";
            // 
            // rbtPuntos
            // 
            rbtPuntos.AutoSize = true;
            rbtPuntos.Location = new Point(20, 117);
            rbtPuntos.Margin = new Padding(4, 5, 4, 5);
            rbtPuntos.Name = "rbtPuntos";
            rbtPuntos.Size = new Size(92, 29);
            rbtPuntos.TabIndex = 0;
            rbtPuntos.Text = "Puntos";
            rbtPuntos.UseVisualStyleBackColor = true;
            // 
            // rbtRayas
            // 
            rbtRayas.AutoSize = true;
            rbtRayas.Location = new Point(20, 75);
            rbtRayas.Margin = new Padding(4, 5, 4, 5);
            rbtRayas.Name = "rbtRayas";
            rbtRayas.Size = new Size(83, 29);
            rbtRayas.TabIndex = 0;
            rbtRayas.Text = "Rayas";
            rbtRayas.UseVisualStyleBackColor = true;
            // 
            // rbtSolido
            // 
            rbtSolido.AutoSize = true;
            rbtSolido.Checked = true;
            rbtSolido.Location = new Point(20, 34);
            rbtSolido.Margin = new Padding(4, 5, 4, 5);
            rbtSolido.Name = "rbtSolido";
            rbtSolido.Size = new Size(88, 29);
            rbtSolido.TabIndex = 0;
            rbtSolido.TabStop = true;
            rbtSolido.Text = "Sólido";
            rbtSolido.UseVisualStyleBackColor = true;
            // 
            // cboColores
            // 
            cboColores.DropDownStyle = ComboBoxStyle.DropDownList;
            cboColores.FormattingEnabled = true;
            cboColores.Location = new Point(158, 97);
            cboColores.Margin = new Padding(4, 5, 4, 5);
            cboColores.Name = "cboColores";
            cboColores.Size = new Size(217, 33);
            cboColores.TabIndex = 10;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(239, 152);
            btnCancelar.Margin = new Padding(4, 5, 4, 5);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(136, 93);
            btnCancelar.TabIndex = 8;
            btnCancelar.Text = "Cancelar";
            btnCancelar.TextImageRelation = TextImageRelation.ImageAboveText;
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click_1;
            // 
            // btnOK
            // 
            btnOK.Location = new Point(13, 152);
            btnOK.Margin = new Padding(4, 5, 4, 5);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(136, 93);
            btnOK.TabIndex = 9;
            btnOK.Text = "OK";
            btnOK.TextImageRelation = TextImageRelation.ImageAboveText;
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click_1;
            // 
            // txtRadio
            // 
            txtRadio.Location = new Point(157, 20);
            txtRadio.Margin = new Padding(4, 5, 4, 5);
            txtRadio.Name = "txtRadio";
            txtRadio.Size = new Size(141, 31);
            txtRadio.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(8, 100);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(121, 25);
            label2.TabIndex = 5;
            label2.Text = "Color Relleno:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 25);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(156, 25);
            label1.TabIndex = 6;
            label1.Text = "Medida del Radio:";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // AgreInfo
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(715, 257);
            Controls.Add(gbxBordes);
            Controls.Add(cboColores);
            Controls.Add(btnCancelar);
            Controls.Add(btnOK);
            Controls.Add(txtRadio);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AgreInfo";
            Text = "AgreInfo";
            Load += AgreInfo_Load;
            gbxBordes.ResumeLayout(false);
            gbxBordes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox gbxBordes;
        private RadioButton rbtPuntos;
        private RadioButton rbtRayas;
        private RadioButton rbtSolido;
        private ComboBox cboColores;
        private Button btnCancelar;
        private Button btnOK;
        private TextBox txtRadio;
        private Label label2;
        private Label label1;
        private ErrorProvider errorProvider1;
    }
}