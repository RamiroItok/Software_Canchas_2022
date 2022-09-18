using BE.Observer;
using Interfaces.Observer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Servicios
{
    public class Traductor
    {
        public static void TraducirMenu(ITraductor traductorService, IIdioma idioma, MenuStrip menu)
        {
            IDictionary<string, ITraduccion> traducciones = traductorService.ObtenerTraducciones(idioma);
            IDictionary<string, ITraduccion> traduccionesDefault = traductorService.ObtenerTraducciones(traductorService.ObtenerIdiomaDefault());

            foreach (ToolStripMenuItem item in menu.Items)
            {
                if (item.Tag != null && traducciones.ContainsKey(item.Tag.ToString()))
                    item.Text = traducciones[item.Tag.ToString()].Texto;
                else if (item.Tag != null && traduccionesDefault.ContainsKey(item.Tag.ToString()))
                    item.Text = traduccionesDefault[item.Tag.ToString()].Texto;
                else item.Text = item.Tag.ToString();

                //else item.Text = $"{item.Tag}_NO_TRADUCTION";

                foreach (ToolStripMenuItem subItem in item.DropDownItems)
                {
                    if (subItem.Tag != null && traducciones.ContainsKey(subItem.Tag.ToString()))
                        subItem.Text = traducciones[subItem.Tag.ToString()].Texto;
                    else if (subItem.AccessibleDescription != null && subItem.AccessibleDescription.ToString() == "idioma_agregado" && !traducciones.ContainsKey(subItem.Tag.ToString()))
                        subItem.Text = $"{subItem.Text}";
                    else if (subItem.Tag != null && traduccionesDefault.ContainsKey(subItem.Tag.ToString()))
                        subItem.Text = traduccionesDefault[subItem.Tag.ToString()].Texto;
                    else subItem.Text = subItem.Tag.ToString();

                    //else subItem.Text = $"{subItem.Tag}_NO_TRADUCTION";

                    foreach (ToolStripItem subSubItem in subItem.DropDownItems)
                    {
                        if (subSubItem.Tag != null && traducciones.ContainsKey(subSubItem.Tag.ToString()))
                            subSubItem.Text = traducciones[subSubItem.Tag.ToString()].Texto;
                        else if (subSubItem.Tag != null && traduccionesDefault.ContainsKey(subSubItem.Tag.ToString()))
                            subSubItem.Text = traduccionesDefault[subSubItem.Tag.ToString()].Texto;
                        else subSubItem.Text = subSubItem.Tag.ToString();

                        //else subSubItem.Text = $"{subSubItem.Tag}_NO_TRADUCTION";
                    }
                }
            }
        }

        public static void Traducir(ITraductor traductorService, IIdioma idioma, Control.ControlCollection controls)
        {
            IDictionary<string, ITraduccion> traducciones = traductorService.ObtenerTraducciones(idioma);
            IDictionary<string, ITraduccion> traduccionesDefault = traductorService.ObtenerTraducciones(traductorService.ObtenerIdiomaDefault());

            foreach (Control ctrl in controls)
            {
                if (ctrl.Tag != null && traducciones.ContainsKey(ctrl.Tag.ToString()))
                    ctrl.Text = traducciones[ctrl.Tag.ToString()].Texto;
                else if (ctrl.Tag != null && traduccionesDefault.ContainsKey(ctrl.Tag.ToString()))
                    ctrl.Text = traduccionesDefault[ctrl.Tag.ToString()].Texto;
                else if (ctrl.Tag != null && !traduccionesDefault.ContainsKey(ctrl.Tag.ToString()))
                    ctrl.Text = ctrl.Tag.ToString();

                //else if (ctrl.Tag != null && !traducciones.ContainsKey(ctrl.Tag.ToString()))
                //ctrl.Text = ctrl.Tag.ToString();

                //else if (ctrl.Tag != null && !traducciones.ContainsKey(ctrl.Tag.ToString()))
                //  ctrl.Text = ctrl.Text = $"PLACEHOLDER_{ctrl.Tag}_NO_TRADUCTION";

                //else ctrl.Text = ctrl.Text = "PLACEHOLDER_TAG_NOT_ASSIGNED";

                if (ctrl.GetType() == typeof(TextBox) || ctrl.GetType() == typeof(ComboBox) || ctrl.GetType() == typeof(RichTextBox) || ctrl.GetType() == typeof(DateTimePicker))
                {
                    ctrl.Text = "";
                }
            }
        }

        public static string TraducirMensaje(ITraductor traductorService, string msgTag)
        {
            IDictionary<string, ITraduccion> traducciones = traductorService.ObtenerTraducciones(Sesion.GetInstance().Idioma);
            IDictionary<string, ITraduccion> traduccionesDefault = traductorService.ObtenerTraducciones(traductorService.ObtenerIdiomaDefault());

            if (traducciones.ContainsKey(msgTag)) msgTag = traducciones[msgTag].Texto;
            else if (traduccionesDefault.ContainsKey(msgTag)) msgTag = traduccionesDefault[msgTag].Texto;
            else msgTag = $"{msgTag} sin traducción";

            //else msgTag = $"PLACEHOLDER_{msgTag}_NO_TRADUCTION";

            return msgTag;
        }

        public static ToolStripMenuItem AgregarIdiomaMenu(IIdioma idioma)
        {
            ToolStripMenuItem idiomaMenu = new ToolStripMenuItem();
            idiomaMenu.Text = idioma.Nombre;
            idiomaMenu.Tag = idioma;
            idiomaMenu.AccessibleDescription = "idioma_agregado";

            return idiomaMenu;
        }
    }
}
