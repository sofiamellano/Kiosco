namespace KioscoInformaticoDesktop.Views
{
    partial class VentasView
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            dateTimeFecha = new DateTimePicker();
            label1 = new Label();
            comboBoxFormasDePago = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            comboBoxClientes = new ComboBox();
            label4 = new Label();
            comboBoxProductos = new ComboBox();
            panel1 = new Panel();
            BtnAgregar = new FontAwesome.Sharp.IconButton();
            label7 = new Label();
            numericSubtotal = new NumericUpDown();
            label6 = new Label();
            numericCantidad = new NumericUpDown();
            label5 = new Label();
            numericPrecio = new NumericUpDown();
            gridDetallesVenta = new DataGridView();
            BtnQuitar = new FontAwesome.Sharp.IconButton();
            label8 = new Label();
            numericTotal = new NumericUpDown();
            BtnFinalizarVenta = new FontAwesome.Sharp.IconButton();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericSubtotal).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericCantidad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericPrecio).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridDetallesVenta).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericTotal).BeginInit();
            SuspendLayout();
            // 
            // dateTimeFecha
            // 
            dateTimeFecha.Enabled = false;
            dateTimeFecha.Format = DateTimePickerFormat.Short;
            dateTimeFecha.Location = new Point(940, 51);
            dateTimeFecha.Name = "dateTimeFecha";
            dateTimeFecha.Size = new Size(149, 31);
            dateTimeFecha.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(853, 56);
            label1.Name = "label1";
            label1.Size = new Size(61, 25);
            label1.TabIndex = 1;
            label1.Text = "Fecha:";
            // 
            // comboBoxFormasDePago
            // 
            comboBoxFormasDePago.FormattingEnabled = true;
            comboBoxFormasDePago.Location = new Point(165, 90);
            comboBoxFormasDePago.Name = "comboBoxFormasDePago";
            comboBoxFormasDePago.Size = new Size(182, 33);
            comboBoxFormasDePago.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 93);
            label2.Name = "label2";
            label2.Size = new Size(139, 25);
            label2.TabIndex = 3;
            label2.Text = "Forma de pago:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(369, 98);
            label3.Name = "label3";
            label3.Size = new Size(69, 25);
            label3.TabIndex = 5;
            label3.Text = "Cliente:";
            // 
            // comboBoxClientes
            // 
            comboBoxClientes.FormattingEnabled = true;
            comboBoxClientes.Location = new Point(444, 95);
            comboBoxClientes.Name = "comboBoxClientes";
            comboBoxClientes.Size = new Size(392, 33);
            comboBoxClientes.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(17, 10);
            label4.Name = "label4";
            label4.Size = new Size(89, 25);
            label4.TabIndex = 7;
            label4.Text = "Producto:";
            // 
            // comboBoxProductos
            // 
            comboBoxProductos.FormattingEnabled = true;
            comboBoxProductos.Location = new Point(8, 44);
            comboBoxProductos.Name = "comboBoxProductos";
            comboBoxProductos.Size = new Size(362, 33);
            comboBoxProductos.TabIndex = 6;
            comboBoxProductos.SelectedIndexChanged += comboBoxProductos_SelectedIndexChanged;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(BtnAgregar);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(numericSubtotal);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(numericCantidad);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(numericPrecio);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(comboBoxProductos);
            panel1.Location = new Point(12, 170);
            panel1.Name = "panel1";
            panel1.Size = new Size(1094, 102);
            panel1.TabIndex = 8;
            // 
            // BtnAgregar
            // 
            BtnAgregar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnAgregar.BackColor = Color.OrangeRed;
            BtnAgregar.ForeColor = Color.White;
            BtnAgregar.IconChar = FontAwesome.Sharp.IconChar.FileCirclePlus;
            BtnAgregar.IconColor = Color.White;
            BtnAgregar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnAgregar.ImageAlign = ContentAlignment.MiddleLeft;
            BtnAgregar.Location = new Point(951, 15);
            BtnAgregar.Margin = new Padding(4, 5, 4, 5);
            BtnAgregar.Name = "BtnAgregar";
            BtnAgregar.Size = new Size(124, 62);
            BtnAgregar.TabIndex = 14;
            BtnAgregar.Text = "&Agregar";
            BtnAgregar.TextAlign = ContentAlignment.MiddleRight;
            BtnAgregar.UseVisualStyleBackColor = false;
            BtnAgregar.Click += BtnAgregar_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(786, 9);
            label7.Name = "label7";
            label7.Size = new Size(79, 25);
            label7.TabIndex = 13;
            label7.Text = "Subtotal";
            // 
            // numericSubtotal
            // 
            numericSubtotal.DecimalPlaces = 2;
            numericSubtotal.Enabled = false;
            numericSubtotal.Location = new Point(739, 46);
            numericSubtotal.Maximum = new decimal(new int[] { 1410065407, 2, 0, 0 });
            numericSubtotal.Name = "numericSubtotal";
            numericSubtotal.Size = new Size(151, 31);
            numericSubtotal.TabIndex = 12;
            numericSubtotal.TextAlign = HorizontalAlignment.Right;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(604, 9);
            label6.Name = "label6";
            label6.Size = new Size(87, 25);
            label6.TabIndex = 11;
            label6.Text = "Cantidad:";
            // 
            // numericCantidad
            // 
            numericCantidad.DecimalPlaces = 2;
            numericCantidad.Location = new Point(574, 46);
            numericCantidad.Maximum = new decimal(new int[] { 1410065407, 2, 0, 0 });
            numericCantidad.Name = "numericCantidad";
            numericCantidad.Size = new Size(151, 31);
            numericCantidad.TabIndex = 10;
            numericCantidad.TextAlign = HorizontalAlignment.Right;
            numericCantidad.ValueChanged += numericCantidad_ValueChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(449, 9);
            label5.Name = "label5";
            label5.Size = new Size(64, 25);
            label5.TabIndex = 9;
            label5.Text = "Precio:";
            // 
            // numericPrecio
            // 
            numericPrecio.DecimalPlaces = 2;
            numericPrecio.Enabled = false;
            numericPrecio.Location = new Point(402, 46);
            numericPrecio.Maximum = new decimal(new int[] { 1410065407, 2, 0, 0 });
            numericPrecio.Name = "numericPrecio";
            numericPrecio.Size = new Size(151, 31);
            numericPrecio.TabIndex = 8;
            numericPrecio.TextAlign = HorizontalAlignment.Right;
            numericPrecio.ValueChanged += numericPrecio_ValueChanged;
            // 
            // gridDetallesVenta
            // 
            gridDetallesVenta.AllowUserToAddRows = false;
            gridDetallesVenta.AllowUserToDeleteRows = false;
            gridDetallesVenta.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridDetallesVenta.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = null;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            gridDetallesVenta.DefaultCellStyle = dataGridViewCellStyle2;
            gridDetallesVenta.Location = new Point(20, 297);
            gridDetallesVenta.Name = "gridDetallesVenta";
            gridDetallesVenta.ReadOnly = true;
            gridDetallesVenta.RowHeadersWidth = 62;
            gridDetallesVenta.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridDetallesVenta.Size = new Size(924, 225);
            gridDetallesVenta.TabIndex = 9;
            gridDetallesVenta.DataBindingComplete += gridDetallesVenta_DataBindingComplete;
            // 
            // BtnQuitar
            // 
            BtnQuitar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnQuitar.BackColor = Color.OrangeRed;
            BtnQuitar.ForeColor = Color.White;
            BtnQuitar.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            BtnQuitar.IconColor = Color.White;
            BtnQuitar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnQuitar.IconSize = 44;
            BtnQuitar.ImageAlign = ContentAlignment.MiddleLeft;
            BtnQuitar.Location = new Point(965, 366);
            BtnQuitar.Margin = new Padding(4, 5, 4, 5);
            BtnQuitar.Name = "BtnQuitar";
            BtnQuitar.Size = new Size(120, 57);
            BtnQuitar.TabIndex = 11;
            BtnQuitar.Text = "&Quitar";
            BtnQuitar.TextAlign = ContentAlignment.MiddleRight;
            BtnQuitar.UseVisualStyleBackColor = false;
            BtnQuitar.Click += BtnQuitar_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(785, 539);
            label8.Name = "label8";
            label8.Size = new Size(108, 25);
            label8.TabIndex = 15;
            label8.Text = "Total factura";
            // 
            // numericTotal
            // 
            numericTotal.DecimalPlaces = 2;
            numericTotal.Enabled = false;
            numericTotal.Location = new Point(753, 576);
            numericTotal.Maximum = new decimal(new int[] { 1410065407, 2, 0, 0 });
            numericTotal.Name = "numericTotal";
            numericTotal.Size = new Size(151, 31);
            numericTotal.TabIndex = 14;
            numericTotal.TextAlign = HorizontalAlignment.Right;
            // 
            // BtnFinalizarVenta
            // 
            BtnFinalizarVenta.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnFinalizarVenta.BackColor = Color.OrangeRed;
            BtnFinalizarVenta.ForeColor = Color.White;
            BtnFinalizarVenta.IconChar = FontAwesome.Sharp.IconChar.CheckCircle;
            BtnFinalizarVenta.IconColor = Color.White;
            BtnFinalizarVenta.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnFinalizarVenta.ImageAlign = ContentAlignment.MiddleLeft;
            BtnFinalizarVenta.Location = new Point(961, 545);
            BtnFinalizarVenta.Margin = new Padding(4, 5, 4, 5);
            BtnFinalizarVenta.Name = "BtnFinalizarVenta";
            BtnFinalizarVenta.Size = new Size(124, 62);
            BtnFinalizarVenta.TabIndex = 15;
            BtnFinalizarVenta.Text = "&Finalizar Venta";
            BtnFinalizarVenta.TextAlign = ContentAlignment.MiddleRight;
            BtnFinalizarVenta.UseVisualStyleBackColor = false;
            BtnFinalizarVenta.Click += iconButton1_Click;
            // 
            // VentasView
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1118, 619);
            Controls.Add(BtnFinalizarVenta);
            Controls.Add(label8);
            Controls.Add(numericTotal);
            Controls.Add(BtnQuitar);
            Controls.Add(gridDetallesVenta);
            Controls.Add(label3);
            Controls.Add(comboBoxClientes);
            Controls.Add(label2);
            Controls.Add(comboBoxFormasDePago);
            Controls.Add(label1);
            Controls.Add(dateTimeFecha);
            Controls.Add(panel1);
            Name = "VentasView";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Ventas";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericSubtotal).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericCantidad).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericPrecio).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridDetallesVenta).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericTotal).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dateTimeFecha;
        private Label label1;
        private ComboBox comboBoxFormasDePago;
        private Label label2;
        private Label label3;
        private ComboBox comboBoxClientes;
        private Label label4;
        private ComboBox comboBoxProductos;
        private Panel panel1;
        private Label label5;
        private NumericUpDown numericPrecio;
        private Label label7;
        private NumericUpDown numericSubtotal;
        private Label label6;
        private NumericUpDown numericCantidad;
        private FontAwesome.Sharp.IconButton BtnAgregar;
        private DataGridView gridDetallesVenta;
        private FontAwesome.Sharp.IconButton BtnQuitar;
        private Label label8;
        private NumericUpDown numericTotal;
        private FontAwesome.Sharp.IconButton BtnFinalizarVenta;
    }
}