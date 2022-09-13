using BE.Composite;
using BE.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Servicios
{
    public class PermisoTool
    {
        public static bool TienePermiso(UsuarioDTO usuario, BE.Composite.Permiso permiso)
        {
            bool existePermiso = false;

            foreach (Componente item in usuario.Permisos)
            {
                if (item.Permiso.Equals(permiso)) return true;

                else
                {
                    existePermiso = EstaPermisoEnFamilia(item, permiso, existePermiso);
                    if (existePermiso) return true;
                }
            }

            return existePermiso;
        }

        private static bool EstaPermisoEnFamilia(Componente c, BE.Composite.Permiso permiso, bool existePermiso)
        {
            if (c.Permiso.Equals(permiso)) existePermiso = true;

            else
            {
                foreach (var item in c.Hijos)
                {
                    existePermiso = EstaPermisoEnFamilia(item, permiso, existePermiso);
                    if (existePermiso) return true;
                }
            }

            return existePermiso;
        }

        public static void HabilitarMenu(UsuarioDTO usuario, ToolStripMenuItem menu)
        {
            foreach (ToolStripMenuItem item in menu.DropDownItems)
            {
                string Nombre = item.Tag.ToString().Replace("menu_", "");
                BE.Composite.Permiso permiso = (BE.Composite.Permiso)Enum.Parse(typeof(BE.Composite.Permiso), Nombre);

                bool tienePermiso = TienePermiso(usuario, permiso);
                item.Enabled = tienePermiso;
                item.Visible = tienePermiso;
            }


        }

        public static void OcultarMenu(ToolStripMenuItem menu)
        {
            bool opcionHabilitada = false;

            foreach (ToolStripMenuItem item in menu.DropDownItems)
            {
                if (item.Enabled == true)
                {
                    opcionHabilitada = true;
                    break;
                }
            }

            if (opcionHabilitada == false)
            {
                menu.Enabled = false;
                menu.Visible = false;
            }
        }

        public static void OcultarMenuRaiz(ToolStripMenuItem menu)
        {
            bool opcionHabilitada = false;

            foreach (ToolStripMenuItem item in menu.DropDownItems)
            {
                if (item.Enabled == true)
                {
                    opcionHabilitada = true;
                    break;
                }
            }

            if (opcionHabilitada == false)
            {
                menu.Enabled = false;
                menu.Visible = false;
            }
        }
    }
}
