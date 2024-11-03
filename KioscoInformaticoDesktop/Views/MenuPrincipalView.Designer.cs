namespace KioscoInformaticoDesktop
{
    partial class MenuPrincipalView
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
            menuStrip1 = new MenuStrip();
            iconMenuItem1 = new FontAwesome.Sharp.IconMenuItem();
            iconMenuVentas = new FontAwesome.Sharp.IconMenuItem();
            iconMenuItem3 = new FontAwesome.Sharp.IconMenuItem();
            ItemMenuLocalidades = new FontAwesome.Sharp.IconMenuItem();
            iconMenuItem4 = new FontAwesome.Sharp.IconMenuItem();
            iconMenuItem5 = new FontAwesome.Sharp.IconMenuItem();
            iconMenuItem7 = new FontAwesome.Sharp.IconMenuItem();
            iconMenuItem6 = new FontAwesome.Sharp.IconMenuItem();
            localidadesToolStripMenuItem = new ToolStripMenuItem();
            iconMenuItem2 = new FontAwesome.Sharp.IconMenuItem();
            ItemMenuSalirDelSistema = new FontAwesome.Sharp.IconMenuItem();
            toolStrip1 = new ToolStrip();
            iconToolHistoricoVentas = new FontAwesome.Sharp.IconToolStripButton();
            menuStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { iconMenuItem1, iconMenuItem3, iconMenuItem6, iconMenuItem2 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 33);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // iconMenuItem1
            // 
            iconMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { iconMenuVentas });
            iconMenuItem1.IconChar = FontAwesome.Sharp.IconChar.House;
            iconMenuItem1.IconColor = Color.Black;
            iconMenuItem1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconMenuItem1.IconSize = 32;
            iconMenuItem1.Name = "iconMenuItem1";
            iconMenuItem1.Size = new Size(118, 29);
            iconMenuItem1.Text = "Principal";
            // 
            // iconMenuVentas
            // 
            iconMenuVentas.IconChar = FontAwesome.Sharp.IconChar.MoneyBills;
            iconMenuVentas.IconColor = Color.Black;
            iconMenuVentas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconMenuVentas.Name = "iconMenuVentas";
            iconMenuVentas.Size = new Size(270, 34);
            iconMenuVentas.Text = "Ventas";
            iconMenuVentas.Click += iconMenuItem8_Click;
            // 
            // iconMenuItem3
            // 
            iconMenuItem3.DropDownItems.AddRange(new ToolStripItem[] { ItemMenuLocalidades, iconMenuItem4, iconMenuItem5, iconMenuItem7 });
            iconMenuItem3.IconChar = FontAwesome.Sharp.IconChar.Database;
            iconMenuItem3.IconColor = Color.Black;
            iconMenuItem3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconMenuItem3.Name = "iconMenuItem3";
            iconMenuItem3.Size = new Size(96, 29);
            iconMenuItem3.Text = "Bases";
            // 
            // ItemMenuLocalidades
            // 
            ItemMenuLocalidades.IconChar = FontAwesome.Sharp.IconChar.None;
            ItemMenuLocalidades.IconColor = Color.Black;
            ItemMenuLocalidades.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ItemMenuLocalidades.Name = "ItemMenuLocalidades";
            ItemMenuLocalidades.Size = new Size(213, 34);
            ItemMenuLocalidades.Text = "Localidades";
            ItemMenuLocalidades.Click += ItemMenuLocalidades_Click;
            // 
            // iconMenuItem4
            // 
            iconMenuItem4.IconChar = FontAwesome.Sharp.IconChar.None;
            iconMenuItem4.IconColor = Color.Black;
            iconMenuItem4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconMenuItem4.Name = "iconMenuItem4";
            iconMenuItem4.Size = new Size(213, 34);
            iconMenuItem4.Text = "Productos";
            iconMenuItem4.Click += iconMenuItem4_Click;
            // 
            // iconMenuItem5
            // 
            iconMenuItem5.IconChar = FontAwesome.Sharp.IconChar.None;
            iconMenuItem5.IconColor = Color.Black;
            iconMenuItem5.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconMenuItem5.Name = "iconMenuItem5";
            iconMenuItem5.Size = new Size(213, 34);
            iconMenuItem5.Text = "Clientes";
            iconMenuItem5.Click += iconMenuItem5_Click;
            // 
            // iconMenuItem7
            // 
            iconMenuItem7.IconChar = FontAwesome.Sharp.IconChar.None;
            iconMenuItem7.IconColor = Color.Black;
            iconMenuItem7.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconMenuItem7.Name = "iconMenuItem7";
            iconMenuItem7.Size = new Size(213, 34);
            iconMenuItem7.Text = "Proveedores";
            iconMenuItem7.Click += iconMenuItem7_Click;
            // 
            // iconMenuItem6
            // 
            iconMenuItem6.DropDownItems.AddRange(new ToolStripItem[] { localidadesToolStripMenuItem });
            iconMenuItem6.IconChar = FontAwesome.Sharp.IconChar.None;
            iconMenuItem6.IconColor = Color.Black;
            iconMenuItem6.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconMenuItem6.Name = "iconMenuItem6";
            iconMenuItem6.Size = new Size(117, 29);
            iconMenuItem6.Text = "Listados";
            // 
            // localidadesToolStripMenuItem
            // 
            localidadesToolStripMenuItem.Name = "localidadesToolStripMenuItem";
            localidadesToolStripMenuItem.Size = new Size(206, 34);
            localidadesToolStripMenuItem.Text = "Localidades";
            localidadesToolStripMenuItem.Click += localidadesToolStripMenuItem_Click;
            // 
            // iconMenuItem2
            // 
            iconMenuItem2.DropDownItems.AddRange(new ToolStripItem[] { ItemMenuSalirDelSistema });
            iconMenuItem2.IconChar = FontAwesome.Sharp.IconChar.DoorClosed;
            iconMenuItem2.IconColor = Color.Black;
            iconMenuItem2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconMenuItem2.Name = "iconMenuItem2";
            iconMenuItem2.Size = new Size(85, 29);
            iconMenuItem2.Text = "Salir";
            // 
            // ItemMenuSalirDelSistema
            // 
            ItemMenuSalirDelSistema.IconChar = FontAwesome.Sharp.IconChar.DoorOpen;
            ItemMenuSalirDelSistema.IconColor = Color.Black;
            ItemMenuSalirDelSistema.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ItemMenuSalirDelSistema.Name = "ItemMenuSalirDelSistema";
            ItemMenuSalirDelSistema.Size = new Size(241, 34);
            ItemMenuSalirDelSistema.Text = "Salir del sistema";
            ItemMenuSalirDelSistema.Click += ItemMenuSalirDelSistema_Click;
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(24, 24);
            toolStrip1.Items.AddRange(new ToolStripItem[] { iconToolHistoricoVentas });
            toolStrip1.Location = new Point(0, 33);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 72);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // iconToolHistoricoVentas
            // 
            iconToolHistoricoVentas.Font = new Font("Segoe UI", 6F, FontStyle.Regular, GraphicsUnit.Point, 0);
            iconToolHistoricoVentas.IconChar = FontAwesome.Sharp.IconChar.Print;
            iconToolHistoricoVentas.IconColor = Color.Black;
            iconToolHistoricoVentas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconToolHistoricoVentas.ImageScaling = ToolStripItemImageScaling.None;
            iconToolHistoricoVentas.ImageTransparentColor = Color.Magenta;
            iconToolHistoricoVentas.Name = "iconToolHistoricoVentas";
            iconToolHistoricoVentas.Size = new Size(96, 67);
            iconToolHistoricoVentas.Text = "Histórico Ventas";
            iconToolHistoricoVentas.TextImageRelation = TextImageRelation.ImageAboveText;
            iconToolHistoricoVentas.Click += iconToolHistoricoVentas_Click;
            // 
            // MenuPrincipalView
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(toolStrip1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(2);
            MaximizeBox = false;
            Name = "MenuPrincipalView";
            Text = "KioscoInformáticoDesktop";
            WindowState = FormWindowState.Maximized;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem1;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem2;
        private FontAwesome.Sharp.IconMenuItem ItemMenuSalirDelSistema;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem3;
        private FontAwesome.Sharp.IconMenuItem ItemMenuLocalidades;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem4;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem5;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem6;
        private ToolStripMenuItem localidadesToolStripMenuItem;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem7;
        private FontAwesome.Sharp.IconMenuItem iconMenuVentas;
        private ToolStrip toolStrip1;
        private FontAwesome.Sharp.IconToolStripButton iconToolHistoricoVentas;
    }
}
