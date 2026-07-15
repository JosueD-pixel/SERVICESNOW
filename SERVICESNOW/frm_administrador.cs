using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Security.Permissions;
using System.Text;
using System.Windows.Forms;

namespace SERVICESNOW
{
    public partial class frm_administrador : Form
    {
        private bool cerrarSesion = false;
        private bool menuAbierto = true;
        public frm_administrador()
        {
            InitializeComponent();
            OcultarSubMenus();
            AsignarEventos(pnl_menu);
        }


        private void PictureBox_MouseEnter(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            pb.BackColor = Color.FromArgb(180, 120, 90);
        }

        private void PictureBox_MouseLeave(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            pb.BackColor = Color.Transparent;
        }

        private void AsignarEventos(Control contenedor)
        {
            foreach (Control control in contenedor.Controls)
            {
                if (control is PictureBox pbc)
                {
                    pbc.MouseEnter += PictureBox_MouseEnter;
                    pbc.MouseLeave += PictureBox_MouseLeave;
                }

                if (control.HasChildren)
                {
                    AsignarEventos(control);
                }
            }
        }

        private void OcultarSubMenus()
        {
            pnl_salones.Visible = false;
            pnl_trabajadores.Visible = false;
            pnl_consultas.Visible = false;
            pnl_funciones.Visible = false;
        }

        private void MostrarSubMenu(Panel subMenu)
        {
            if (!subMenu.Visible)
            {
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        private void pbc_salones_Click(object sender, EventArgs e)
        {
            MostrarSubMenu(pnl_salones);
        }


        private void pbc_Trabajadores_Click(object sender, EventArgs e)
        {
            MostrarSubMenu(pnl_trabajadores);
        }



        private void btn_menu_Click(object sender, EventArgs e)
        {
            if (menuAbierto)
            {
                pnl_menu.Width = 0;
                menuAbierto = false;
            }
            else
            {
                pnl_menu.Width = 250;
                menuAbierto = true;
            }
        }

        private void pbc_boton_Click(object sender, EventArgs e)
        {
            if (cerrarSesion)
            {
                pbc_cerrarsesion.Visible = true;
                cerrarSesion = false;
            }
            else
            {
                pbc_cerrarsesion.Visible = false;
                cerrarSesion = true;
            }
        }

        private void pbc_cerrarsesion_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pbc_funciones_Click(object sender, EventArgs e)
        {
            MostrarSubMenu(pnl_funciones);
        }

        private void pbc_consultas_Click(object sender, EventArgs e)
        {
            MostrarSubMenu(pnl_consultas);
        }

        private void pbc_horarios_Click(object sender, EventArgs e)
        {
          
        }
    }
}
