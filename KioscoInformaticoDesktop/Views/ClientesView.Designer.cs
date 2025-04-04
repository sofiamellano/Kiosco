using Service.Models;

namespace KioscoInformaticoDesktop.Views
{
    partial class ClientesView
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            panel1 = new Panel();
            label1 = new Label();
            tabControl = new TabControl();
            tabPageLista = new TabPage();
            iconButtonEliminar = new FontAwesome.Sharp.IconButton();
            iconButtonEditar = new FontAwesome.Sharp.IconButton();
            iconButtonAgregar = new FontAwesome.Sharp.IconButton();
            btnBuscar = new FontAwesome.Sharp.IconButton();
            txtFiltro = new TextBox();
            label3 = new Label();
            dataGridClientesView = new DataGridView();
            tabPageAgregarEditar = new TabPage();
            dateTimeFechaNacimiento = new DateTimePicker();
            label7 = new Label();
            comboLocalidades = new ComboBox();
            label6 = new Label();
            txtTelefonos = new TextBox();
            label5 = new Label();
            txtDireccion = new TextBox();
            label4 = new Label();
            btnCancelar = new FontAwesome.Sharp.IconButton();
            btnGuardar = new FontAwesome.Sharp.IconButton();
            txtNombre = new TextBox();
            label2 = new Label();
            clienteBindingSource = new BindingSource(components);
            panel1.SuspendLayout();
            tabControl.SuspendLayout();
            tabPageLista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridClientesView).BeginInit();
            tabPageAgregarEditar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)clienteBindingSource).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.DeepSkyBlue;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(904, 52);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(10, 9);
            label1.Name = "label1";
            label1.Size = new Size(134, 33);
            label1.TabIndex = 0;
            label1.Text = "Clientes";
            // 
            // tabControl
            // 
            tabControl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControl.Controls.Add(tabPageLista);
            tabControl.Controls.Add(tabPageAgregarEditar);
            tabControl.Location = new Point(0, 58);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(867, 453);
            tabControl.TabIndex = 0;
            // 
            // tabPageLista
            // 
            tabPageLista.Controls.Add(iconButtonEliminar);
            tabPageLista.Controls.Add(iconButtonEditar);
            tabPageLista.Controls.Add(iconButtonAgregar);
            tabPageLista.Controls.Add(btnBuscar);
            tabPageLista.Controls.Add(txtFiltro);
            tabPageLista.Controls.Add(label3);
            tabPageLista.Controls.Add(dataGridClientesView);
            tabPageLista.Location = new Point(4, 24);
            tabPageLista.Name = "tabPageLista";
            tabPageLista.Padding = new Padding(3, 3, 3, 3);
            tabPageLista.Size = new Size(859, 425);
            tabPageLista.TabIndex = 0;
            tabPageLista.Text = "Lista";
            tabPageLista.UseVisualStyleBackColor = true;
            // 
            // iconButtonEliminar
            // 
            iconButtonEliminar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            iconButtonEliminar.BackColor = Color.OrangeRed;
            iconButtonEliminar.ForeColor = Color.White;
            iconButtonEliminar.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            iconButtonEliminar.IconColor = Color.White;
            iconButtonEliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButtonEliminar.IconSize = 44;
            iconButtonEliminar.ImageAlign = ContentAlignment.MiddleLeft;
            iconButtonEliminar.Location = new Point(731, 232);
            iconButtonEliminar.Name = "iconButtonEliminar";
            iconButtonEliminar.Size = new Size(108, 54);
            iconButtonEliminar.TabIndex = 10;
            iconButtonEliminar.Text = "Eli&minar";
            iconButtonEliminar.TextAlign = ContentAlignment.MiddleRight;
            iconButtonEliminar.UseVisualStyleBackColor = false;
            iconButtonEliminar.Click += iconButtonEliminar_Click;
            // 
            // iconButtonEditar
            // 
            iconButtonEditar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            iconButtonEditar.BackColor = Color.OrangeRed;
            iconButtonEditar.ForeColor = Color.White;
            iconButtonEditar.IconChar = FontAwesome.Sharp.IconChar.Pencil;
            iconButtonEditar.IconColor = Color.White;
            iconButtonEditar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButtonEditar.IconSize = 45;
            iconButtonEditar.ImageAlign = ContentAlignment.MiddleLeft;
            iconButtonEditar.Location = new Point(731, 159);
            iconButtonEditar.Name = "iconButtonEditar";
            iconButtonEditar.Size = new Size(108, 54);
            iconButtonEditar.TabIndex = 9;
            iconButtonEditar.Text = "&Editar";
            iconButtonEditar.TextAlign = ContentAlignment.MiddleRight;
            iconButtonEditar.UseVisualStyleBackColor = false;
            iconButtonEditar.Click += iconButtonEditar_Click;
            // 
            // iconButtonAgregar
            // 
            iconButtonAgregar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            iconButtonAgregar.BackColor = Color.OrangeRed;
            iconButtonAgregar.ForeColor = Color.White;
            iconButtonAgregar.IconChar = FontAwesome.Sharp.IconChar.FileCirclePlus;
            iconButtonAgregar.IconColor = Color.White;
            iconButtonAgregar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButtonAgregar.ImageAlign = ContentAlignment.MiddleLeft;
            iconButtonAgregar.Location = new Point(731, 82);
            iconButtonAgregar.Name = "iconButtonAgregar";
            iconButtonAgregar.Size = new Size(108, 54);
            iconButtonAgregar.TabIndex = 8;
            iconButtonAgregar.Text = "&Agregar";
            iconButtonAgregar.TextAlign = ContentAlignment.MiddleRight;
            iconButtonAgregar.UseVisualStyleBackColor = false;
            iconButtonAgregar.Click += iconButtonAgregar_Click;
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
            btnBuscar.Location = new Point(731, 9);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(108, 54);
            btnBuscar.TabIndex = 7;
            btnBuscar.Text = "&Buscar";
            btnBuscar.TextAlign = ContentAlignment.MiddleRight;
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // txtFiltro
            // 
            txtFiltro.Location = new Point(124, 23);
            txtFiltro.Name = "txtFiltro";
            txtFiltro.Size = new Size(615, 23);
            txtFiltro.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(28, 29);
            label3.Name = "label3";
            label3.Size = new Size(91, 15);
            label3.TabIndex = 4;
            label3.Text = "Busar Producto:";
            // 
            // dataGridClientesView
            // 
            dataGridClientesView.AllowUserToAddRows = false;
            dataGridClientesView.AllowUserToDeleteRows = false;
            dataGridClientesView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridClientesView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = null;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dataGridClientesView.DefaultCellStyle = dataGridViewCellStyle1;
            dataGridClientesView.Location = new Point(3, 73);
            dataGridClientesView.Name = "dataGridClientesView";
            dataGridClientesView.ReadOnly = true;
            dataGridClientesView.RowHeadersWidth = 62;
            dataGridClientesView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridClientesView.Size = new Size(736, 346);
            dataGridClientesView.TabIndex = 0;
            // 
            // tabPageAgregarEditar
            // 
            tabPageAgregarEditar.Controls.Add(dateTimeFechaNacimiento);
            tabPageAgregarEditar.Controls.Add(label7);
            tabPageAgregarEditar.Controls.Add(comboLocalidades);
            tabPageAgregarEditar.Controls.Add(label6);
            tabPageAgregarEditar.Controls.Add(txtTelefonos);
            tabPageAgregarEditar.Controls.Add(label5);
            tabPageAgregarEditar.Controls.Add(txtDireccion);
            tabPageAgregarEditar.Controls.Add(label4);
            tabPageAgregarEditar.Controls.Add(btnCancelar);
            tabPageAgregarEditar.Controls.Add(btnGuardar);
            tabPageAgregarEditar.Controls.Add(txtNombre);
            tabPageAgregarEditar.Controls.Add(label2);
            tabPageAgregarEditar.Location = new Point(4, 24);
            tabPageAgregarEditar.Name = "tabPageAgregarEditar";
            tabPageAgregarEditar.Padding = new Padding(3, 3, 3, 3);
            tabPageAgregarEditar.Size = new Size(896, 425);
            tabPageAgregarEditar.TabIndex = 1;
            tabPageAgregarEditar.Text = "Agregar/Editar";
            tabPageAgregarEditar.UseVisualStyleBackColor = true;
            // 
            // dateTimeFechaNacimiento
            // 
            dateTimeFechaNacimiento.Format = DateTimePickerFormat.Short;
            dateTimeFechaNacimiento.Location = new Point(386, 197);
            dateTimeFechaNacimiento.Margin = new Padding(2, 2, 2, 2);
            dateTimeFechaNacimiento.Name = "dateTimeFechaNacimiento";
            dateTimeFechaNacimiento.Size = new Size(110, 23);
            dateTimeFechaNacimiento.TabIndex = 4;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(234, 196);
            label7.Name = "label7";
            label7.Size = new Size(104, 15);
            label7.TabIndex = 17;
            label7.Text = "Fecha nacimiento:";
            // 
            // comboLocalidades
            // 
            comboLocalidades.DropDownStyle = ComboBoxStyle.DropDownList;
            comboLocalidades.FormattingEnabled = true;
            comboLocalidades.Location = new Point(386, 148);
            comboLocalidades.Margin = new Padding(2, 2, 2, 2);
            comboLocalidades.Name = "comboLocalidades";
            comboLocalidades.Size = new Size(196, 23);
            comboLocalidades.TabIndex = 3;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(276, 150);
            label6.Name = "label6";
            label6.Size = new Size(61, 15);
            label6.TabIndex = 16;
            label6.Text = "Localidad:";
            // 
            // txtTelefonos
            // 
            txtTelefonos.Location = new Point(386, 106);
            txtTelefonos.Name = "txtTelefonos";
            txtTelefonos.Size = new Size(197, 23);
            txtTelefonos.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(277, 109);
            label5.Name = "label5";
            label5.Size = new Size(60, 15);
            label5.TabIndex = 14;
            label5.Text = "Telefonos:";
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(386, 66);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(197, 23);
            txtDireccion.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(277, 69);
            label4.Name = "label4";
            label4.Size = new Size(60, 15);
            label4.TabIndex = 12;
            label4.Text = "Direccion:";
            // 
            // btnCancelar
            // 
            btnCancelar.IconChar = FontAwesome.Sharp.IconChar.Cancel;
            btnCancelar.IconColor = Color.Black;
            btnCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCancelar.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancelar.Location = new Point(514, 275);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(100, 60);
            btnCancelar.TabIndex = 6;
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
            btnGuardar.Location = new Point(277, 275);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(100, 60);
            btnGuardar.TabIndex = 5;
            btnGuardar.Text = "&Guardar";
            btnGuardar.TextAlign = ContentAlignment.MiddleRight;
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(386, 32);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(197, 23);
            txtNombre.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(277, 35);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 8;
            label2.Text = "Nombre:";
            // 
            // clienteBindingSource
            // 
            clienteBindingSource.DataSource = typeof(Cliente);
            // 
            // ClientesView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(901, 449);
            Controls.Add(tabControl);
            Controls.Add(panel1);
            Name = "ClientesView";
            StartPosition = FormStartPosition.CenterParent;
            Text = "ClientesView";
            
            
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabControl.ResumeLayout(false);
            tabPageLista.ResumeLayout(false);
            tabPageLista.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridClientesView).EndInit();
            tabPageAgregarEditar.ResumeLayout(false);
            tabPageAgregarEditar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)clienteBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private TabControl tabControl;
        private TabPage tabPageLista;
        private TextBox txtFiltro;
        private Label label3;
        private DataGridView dataGridClientesView;
        private TabPage tabPageAgregarEditar;
        private FontAwesome.Sharp.IconButton btnCancelar;
        private FontAwesome.Sharp.IconButton btnGuardar;
        private TextBox txtNombre;
        private Label label2;
        private TextBox txtDireccion;
        private Label label4;
        private TextBox txtTelefonos;
        private Label label5;
        private FontAwesome.Sharp.IconButton btnBuscar;
        private FontAwesome.Sharp.IconButton iconButtonAgregar;
        private FontAwesome.Sharp.IconButton iconButtonEditar;
        private FontAwesome.Sharp.IconButton iconButtonEliminar;
        private Label label6;
        private ComboBox comboLocalidades;
        private DateTimePicker dateTimeFechaNacimiento;
        private Label label7;
        private BindingSource clienteBindingSource;
    }
}