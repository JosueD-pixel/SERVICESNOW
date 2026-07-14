using System;
using System.Collections.Generic;
using System.Text;

namespace SERVICESNOW
{
    internal class clsMenu
    {
        private Form formularioActivo;

        public void AgregarAlContenedor(Form formulario, Panel panel)
        {
            if (formularioActivo != null)
            {
                formularioActivo.Close();
            }

            formularioActivo = formulario;

            panel.Controls.Clear();

            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;

            panel.Controls.Add(formulario);
            panel.Tag = formulario;

            formulario.BringToFront();
            formulario.Show();
        }
    }


}
