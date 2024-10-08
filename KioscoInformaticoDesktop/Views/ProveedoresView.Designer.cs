namespace KioscoInformaticoDesktop.Views
{
    partial class ProveedoresView
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
            panel1 = new Panel();
            label1 = new Label();
            tabControl1 = new TabControl();
            tabPageLista = new TabPage();
            txtFiltro = new TextBox();
            label7 = new Label();
            btnEliminar = new FontAwesome.Sharp.IconButton();
            btnEditar = new FontAwesome.Sharp.IconButton();
            btnAgregar = new FontAwesome.Sharp.IconButton();
            btnBuscar = new FontAwesome.Sharp.IconButton();
            dataGridProveedoresView = new DataGridView();
            tabPageEditarAgregar = new TabPage();
            txtCondicionIVA = new TextBox();
            label8 = new Label();
            comboLocalidades = new ComboBox();
            label6 = new Label();
            txtCbu = new TextBox();
            label3 = new Label();
            txtTelefonos = new TextBox();
            label5 = new Label();
            txtDireccion = new TextBox();
            label4 = new Label();
            txtNombre = new TextBox();
            label2 = new Label();
            btnCancelar = new FontAwesome.Sharp.IconButton();
            btnGuardar = new FontAwesome.Sharp.IconButton();
            panel1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPageLista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridProveedoresView).BeginInit();
            tabPageEditarAgregar.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.DeepSkyBlue;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(1, 0);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(1340, 87);
            panel1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(14, 15);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(300, 50);
            label1.TabIndex = 0;
            label1.Text = "Proveedores";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPageLista);
            tabControl1.Controls.Add(tabPageEditarAgregar);
            tabControl1.Location = new Point(1, 97);
            tabControl1.Margin = new Padding(4, 5, 4, 5);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1340, 750);
            tabControl1.TabIndex = 3;
            // 
            // tabPageLista
            // 
            tabPageLista.Controls.Add(txtFiltro);
            tabPageLista.Controls.Add(label7);
            tabPageLista.Controls.Add(btnEliminar);
            tabPageLista.Controls.Add(btnEditar);
            tabPageLista.Controls.Add(btnAgregar);
            tabPageLista.Controls.Add(btnBuscar);
            tabPageLista.Controls.Add(dataGridProveedoresView);
            tabPageLista.Location = new Point(4, 34);
            tabPageLista.Margin = new Padding(4, 5, 4, 5);
            tabPageLista.Name = "tabPageLista";
            tabPageLista.Padding = new Padding(4, 5, 4, 5);
            tabPageLista.Size = new Size(1332, 712);
            tabPageLista.TabIndex = 0;
            tabPageLista.Text = "Lista";
            tabPageLista.UseVisualStyleBackColor = true;
            // 
            // txtFiltro
            // 
            txtFiltro.Location = new Point(174, 38);
            txtFiltro.Margin = new Padding(4, 5, 4, 5);
            txtFiltro.Name = "txtFiltro";
            txtFiltro.Size = new Size(963, 31);
            txtFiltro.TabIndex = 16;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(29, 43);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(146, 25);
            label7.TabIndex = 15;
            label7.Text = "Busar Proveedor:";
            // 
            // btnEliminar
            // 
            btnEliminar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnEliminar.BackColor = Color.OrangeRed;
            btnEliminar.ForeColor = Color.White;
            btnEliminar.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            btnEliminar.IconColor = Color.White;
            btnEliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEliminar.IconSize = 44;
            btnEliminar.ImageAlign = ContentAlignment.MiddleLeft;
            btnEliminar.Location = new Point(1147, 382);
            btnEliminar.Margin = new Padding(4, 5, 4, 5);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(154, 90);
            btnEliminar.TabIndex = 14;
            btnEliminar.Text = "Eli&minar";
            btnEliminar.TextAlign = ContentAlignment.MiddleRight;
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnEditar.BackColor = Color.OrangeRed;
            btnEditar.ForeColor = Color.White;
            btnEditar.IconChar = FontAwesome.Sharp.IconChar.Pencil;
            btnEditar.IconColor = Color.White;
            btnEditar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEditar.IconSize = 45;
            btnEditar.ImageAlign = ContentAlignment.MiddleLeft;
            btnEditar.Location = new Point(1147, 260);
            btnEditar.Margin = new Padding(4, 5, 4, 5);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(154, 90);
            btnEditar.TabIndex = 13;
            btnEditar.Text = "&Editar";
            btnEditar.TextAlign = ContentAlignment.MiddleRight;
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAgregar.BackColor = Color.OrangeRed;
            btnAgregar.ForeColor = Color.White;
            btnAgregar.IconChar = FontAwesome.Sharp.IconChar.FileCirclePlus;
            btnAgregar.IconColor = Color.White;
            btnAgregar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAgregar.ImageAlign = ContentAlignment.MiddleLeft;
            btnAgregar.Location = new Point(1147, 132);
            btnAgregar.Margin = new Padding(4, 5, 4, 5);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(154, 90);
            btnAgregar.TabIndex = 12;
            btnAgregar.Text = "&Agregar";
            btnAgregar.TextAlign = ContentAlignment.MiddleRight;
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnBuscar.BackColor = Color.OrangeRed;
            btnBuscar.ForeColor = Color.White;
            btnBuscar.IconChar = FontAwesome.Sharp.IconChar.Search;
            btnBuscar.IconColor = Color.White;
            btnBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnBuscar.ImageAlign = ContentAlignment.MiddleLeft;
            btnBuscar.Location = new Point(1147, 10);
            btnBuscar.Margin = new Padding(4, 5, 4, 5);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(154, 90);
            btnBuscar.TabIndex = 11;
            btnBuscar.Text = "&Buscar";
            btnBuscar.TextAlign = ContentAlignment.MiddleRight;
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // dataGridProveedoresView
            // 
            dataGridProveedoresView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridProveedoresView.Location = new Point(10, 79);
            dataGridProveedoresView.Margin = new Padding(4, 5, 4, 5);
            dataGridProveedoresView.Name = "dataGridProveedoresView";
            dataGridProveedoresView.RowHeadersWidth = 62;
            dataGridProveedoresView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridProveedoresView.Size = new Size(1130, 607);
            dataGridProveedoresView.TabIndex = 0;
            // 
            // tabPageEditarAgregar
            // 
            tabPageEditarAgregar.Controls.Add(txtCondicionIVA);
            tabPageEditarAgregar.Controls.Add(label8);
            tabPageEditarAgregar.Controls.Add(comboLocalidades);
            tabPageEditarAgregar.Controls.Add(label6);
            tabPageEditarAgregar.Controls.Add(txtCbu);
            tabPageEditarAgregar.Controls.Add(label3);
            tabPageEditarAgregar.Controls.Add(txtTelefonos);
            tabPageEditarAgregar.Controls.Add(label5);
            tabPageEditarAgregar.Controls.Add(txtDireccion);
            tabPageEditarAgregar.Controls.Add(label4);
            tabPageEditarAgregar.Controls.Add(txtNombre);
            tabPageEditarAgregar.Controls.Add(label2);
            tabPageEditarAgregar.Controls.Add(btnCancelar);
            tabPageEditarAgregar.Controls.Add(btnGuardar);
            tabPageEditarAgregar.Location = new Point(4, 34);
            tabPageEditarAgregar.Margin = new Padding(4, 5, 4, 5);
            tabPageEditarAgregar.Name = "tabPageEditarAgregar";
            tabPageEditarAgregar.Padding = new Padding(4, 5, 4, 5);
            tabPageEditarAgregar.Size = new Size(1332, 712);
            tabPageEditarAgregar.TabIndex = 1;
            tabPageEditarAgregar.Text = "Editar/Agregar";
            tabPageEditarAgregar.UseVisualStyleBackColor = true;
            // 
            // txtCondicionIVA
            // 
            txtCondicionIVA.Location = new Point(554, 385);
            txtCondicionIVA.Margin = new Padding(4, 5, 4, 5);
            txtCondicionIVA.Name = "txtCondicionIVA";
            txtCondicionIVA.Size = new Size(284, 31);
            txtCondicionIVA.TabIndex = 24;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(370, 390);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(128, 25);
            label8.TabIndex = 25;
            label8.Text = "Condicion IVA:";
            // 
            // comboLocalidades
            // 
            comboLocalidades.DropDownStyle = ComboBoxStyle.DropDownList;
            comboLocalidades.FormattingEnabled = true;
            comboLocalidades.Location = new Point(554, 465);
            comboLocalidades.Margin = new Padding(4, 5, 4, 5);
            comboLocalidades.Name = "comboLocalidades";
            comboLocalidades.Size = new Size(284, 33);
            comboLocalidades.TabIndex = 22;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(403, 465);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(91, 25);
            label6.TabIndex = 23;
            label6.Text = "Localidad:";
            // 
            // txtCbu
            // 
            txtCbu.Location = new Point(554, 300);
            txtCbu.Margin = new Padding(4, 5, 4, 5);
            txtCbu.Name = "txtCbu";
            txtCbu.Size = new Size(284, 31);
            txtCbu.TabIndex = 20;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(444, 313);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(48, 25);
            label3.TabIndex = 21;
            label3.Text = "Cbu:";
            // 
            // txtTelefonos
            // 
            txtTelefonos.Location = new Point(554, 202);
            txtTelefonos.Margin = new Padding(4, 5, 4, 5);
            txtTelefonos.Name = "txtTelefonos";
            txtTelefonos.Size = new Size(284, 31);
            txtTelefonos.TabIndex = 17;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(404, 215);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(91, 25);
            label5.TabIndex = 19;
            label5.Text = "Telefonos:";
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(554, 115);
            txtDireccion.Margin = new Padding(4, 5, 4, 5);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(284, 31);
            txtDireccion.TabIndex = 16;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(406, 128);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(89, 25);
            label4.TabIndex = 18;
            label4.Text = "Direccion:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(554, 38);
            txtNombre.Margin = new Padding(4, 5, 4, 5);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(284, 31);
            txtNombre.TabIndex = 15;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(414, 43);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(82, 25);
            label2.TabIndex = 14;
            label2.Text = "Nombre:";
            // 
            // btnCancelar
            // 
            btnCancelar.IconChar = FontAwesome.Sharp.IconChar.Cancel;
            btnCancelar.IconColor = Color.Black;
            btnCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCancelar.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancelar.Location = new Point(713, 592);
            btnCancelar.Margin = new Padding(4, 5, 4, 5);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(143, 100);
            btnCancelar.TabIndex = 13;
            btnCancelar.Text = "&Cancelar";
            btnCancelar.TextAlign = ContentAlignment.MiddleRight;
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.IconChar = FontAwesome.Sharp.IconChar.Save;
            btnGuardar.IconColor = Color.Black;
            btnGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnGuardar.ImageAlign = ContentAlignment.MiddleLeft;
            btnGuardar.Location = new Point(374, 592);
            btnGuardar.Margin = new Padding(4, 5, 4, 5);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(143, 100);
            btnGuardar.TabIndex = 12;
            btnGuardar.Text = "&Guardar";
            btnGuardar.TextAlign = ContentAlignment.MiddleRight;
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // ProveedoresView
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1340, 848);
            Controls.Add(tabControl1);
            Controls.Add(panel1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "ProveedoresView";
            Text = "ProveedoresView";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPageLista.ResumeLayout(false);
            tabPageLista.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridProveedoresView).EndInit();
            tabPageEditarAgregar.ResumeLayout(false);
            tabPageEditarAgregar.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private TabControl tabControl1;
        private TabPage tabPageLista;
        private TabPage tabPageEditarAgregar;
        private FontAwesome.Sharp.IconButton btnCancelar;
        private FontAwesome.Sharp.IconButton btnGuardar;
        private TextBox txtNombre;
        private Label label2;
        private TextBox txtTelefonos;
        private Label label5;
        private TextBox txtDireccion;
        private Label label4;
        private TextBox txtCbu;
        private Label label3;
        private ComboBox comboLocalidades;
        private Label label6;
        private DataGridView dataGridProveedoresView;
        private FontAwesome.Sharp.IconButton btnEliminar;
        private FontAwesome.Sharp.IconButton btnEditar;
        private FontAwesome.Sharp.IconButton btnAgregar;
        private FontAwesome.Sharp.IconButton btnBuscar;
        private TextBox txtFiltro;
        private Label label7;
        private TextBox txtCondicionIVA;
        private Label label8;
    }
}