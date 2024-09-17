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
            iconMenuItem2 = new FontAwesome.Sharp.IconMenuItem();
            ItemMenuSalirDelSistema = new FontAwesome.Sharp.IconMenuItem();
            iconMenuItem3 = new FontAwesome.Sharp.IconMenuItem();
            ItemMenuLocalidades = new FontAwesome.Sharp.IconMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { iconMenuItem1, iconMenuItem3, iconMenuItem2 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 33);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // iconMenuItem1
            // 
            iconMenuItem1.IconChar = FontAwesome.Sharp.IconChar.House;
            iconMenuItem1.IconColor = Color.Black;
            iconMenuItem1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconMenuItem1.IconSize = 32;
            iconMenuItem1.Name = "iconMenuItem1";
            iconMenuItem1.Size = new Size(118, 29);
            iconMenuItem1.Text = "Principal";
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
            ItemMenuSalirDelSistema.Size = new Size(270, 34);
            ItemMenuSalirDelSistema.Text = "Salir del sistema";
            ItemMenuSalirDelSistema.Click += ItemMenuSalirDelSistema_Click;
            // 
            // iconMenuItem3
            // 
            iconMenuItem3.DropDownItems.AddRange(new ToolStripItem[] { ItemMenuLocalidades });
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
            ItemMenuLocalidades.Size = new Size(270, 34);
            ItemMenuLocalidades.Text = "Localidades";
            ItemMenuLocalidades.Click += ItemMenuLocalidades_Click;
            // 
            // MenuPrincipalView
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            Name = "MenuPrincipalView";
            Text = "KioscoInformáticoDesktop";
            WindowState = FormWindowState.Maximized;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
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
    }
}
