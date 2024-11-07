namespace KioscoInformaticoDesktop.Views
{
    partial class HistoricoVentasView
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            panel1 = new Panel();
            label1 = new Label();
            dataGridVentas = new DataGridView();
            panelFiltrado = new Panel();
            BtnFiltrar = new Button();
            dateTimeHasta = new DateTimePicker();
            label3 = new Label();
            dateTimeDesde = new DateTimePicker();
            label2 = new Label();
            checkFiltrado = new CheckBox();
            label8 = new Label();
            numericTotalFacturado = new NumericUpDown();
            btnImprimir = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridVentas).BeginInit();
            panelFiltrado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericTotalFacturado).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.DeepSkyBlue;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(13, 14);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(868, 87);
            panel1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(14, 15);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(388, 50);
            label1.TabIndex = 0;
            label1.Text = "Histórico Ventas";
            // 
            // dataGridVentas
            // 
            dataGridVentas.AllowUserToAddRows = false;
            dataGridVentas.AllowUserToDeleteRows = false;
            dataGridVentas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridVentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.NullValue = null;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dataGridVentas.DefaultCellStyle = dataGridViewCellStyle1;
            dataGridVentas.Location = new Point(27, 205);
            dataGridVentas.Name = "dataGridVentas";
            dataGridVentas.ReadOnly = true;
            dataGridVentas.RowHeadersWidth = 62;
            dataGridVentas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridVentas.Size = new Size(825, 243);
            dataGridVentas.TabIndex = 3;
            // 
            // panelFiltrado
            // 
            panelFiltrado.Controls.Add(BtnFiltrar);
            panelFiltrado.Controls.Add(dateTimeHasta);
            panelFiltrado.Controls.Add(label3);
            panelFiltrado.Controls.Add(dateTimeDesde);
            panelFiltrado.Controls.Add(label2);
            panelFiltrado.Enabled = false;
            panelFiltrado.Location = new Point(187, 109);
            panelFiltrado.Name = "panelFiltrado";
            panelFiltrado.Size = new Size(665, 90);
            panelFiltrado.TabIndex = 4;
            // 
            // BtnFiltrar
            // 
            BtnFiltrar.Location = new Point(535, 28);
            BtnFiltrar.Name = "BtnFiltrar";
            BtnFiltrar.Size = new Size(112, 34);
            BtnFiltrar.TabIndex = 4;
            BtnFiltrar.Text = "Filtrar";
            BtnFiltrar.UseVisualStyleBackColor = true;
            BtnFiltrar.Click += BtnFiltrar_Click;
            // 
            // dateTimeHasta
            // 
            dateTimeHasta.Format = DateTimePickerFormat.Short;
            dateTimeHasta.Location = new Point(337, 28);
            dateTimeHasta.Name = "dateTimeHasta";
            dateTimeHasta.Size = new Size(170, 31);
            dateTimeHasta.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(270, 27);
            label3.Name = "label3";
            label3.Size = new Size(61, 25);
            label3.TabIndex = 2;
            label3.Text = "Hasta:";
            // 
            // dateTimeDesde
            // 
            dateTimeDesde.Format = DateTimePickerFormat.Short;
            dateTimeDesde.Location = new Point(94, 27);
            dateTimeDesde.Name = "dateTimeDesde";
            dateTimeDesde.Size = new Size(170, 31);
            dateTimeDesde.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 26);
            label2.Name = "label2";
            label2.Size = new Size(66, 25);
            label2.TabIndex = 0;
            label2.Text = "Desde:";
            // 
            // checkFiltrado
            // 
            checkFiltrado.AutoSize = true;
            checkFiltrado.Location = new Point(27, 112);
            checkFiltrado.Name = "checkFiltrado";
            checkFiltrado.Size = new Size(154, 29);
            checkFiltrado.TabIndex = 0;
            checkFiltrado.Text = "Activar filtrado";
            checkFiltrado.UseVisualStyleBackColor = true;
            checkFiltrado.CheckedChanged += checkFiltrado_CheckedChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(330, 483);
            label8.Name = "label8";
            label8.Size = new Size(134, 25);
            label8.TabIndex = 17;
            label8.Text = "Total facturado:";
            // 
            // numericTotalFacturado
            // 
            numericTotalFacturado.DecimalPlaces = 2;
            numericTotalFacturado.Enabled = false;
            numericTotalFacturado.Location = new Point(470, 481);
            numericTotalFacturado.Maximum = new decimal(new int[] { 1410065407, 2, 0, 0 });
            numericTotalFacturado.Name = "numericTotalFacturado";
            numericTotalFacturado.Size = new Size(160, 31);
            numericTotalFacturado.TabIndex = 16;
            numericTotalFacturado.TextAlign = HorizontalAlignment.Right;
            // 
            // btnImprimir
            // 
            btnImprimir.Location = new Point(702, 478);
            btnImprimir.Name = "btnImprimir";
            btnImprimir.Size = new Size(112, 34);
            btnImprimir.TabIndex = 18;
            btnImprimir.Text = "Imprimir";
            btnImprimir.UseVisualStyleBackColor = true;
            btnImprimir.Click += btnImprimir_Click;
            // 
            // HistoricoVentasView
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(894, 553);
            Controls.Add(btnImprimir);
            Controls.Add(label8);
            Controls.Add(numericTotalFacturado);
            Controls.Add(checkFiltrado);
            Controls.Add(panelFiltrado);
            Controls.Add(dataGridVentas);
            Controls.Add(panel1);
            Name = "HistoricoVentasView";
            StartPosition = FormStartPosition.CenterParent;
            Text = "HistoricoVentasView";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridVentas).EndInit();
            panelFiltrado.ResumeLayout(false);
            panelFiltrado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericTotalFacturado).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private DataGridView dataGridVentas;
        private Panel panelFiltrado;
        private DateTimePicker dateTimeDesde;
        private Label label2;
        private CheckBox checkFiltrado;
        private DateTimePicker dateTimeHasta;
        private Label label3;
        private Button BtnFiltrar;
        private Label label8;
        private NumericUpDown numericTotalFacturado;
        private Button btnImprimir;
    }
}