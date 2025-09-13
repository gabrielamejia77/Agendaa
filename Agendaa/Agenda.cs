using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agendaa
{
    public partial class Agenda : Form
    {

        private BaseDatosJson baseDatos;

        public Agenda()
        {
            InitializeComponent();
        }

        private BaseDatosJson CargarDatos()
        {
            var registros = new BaseDatosJson();
            foreach (DataGridViewRow fila in dgvAgenda.Rows)
            {
                if (fila.IsNewRow) continue;

                var contacto = new Contactos
                {
                    nombre = fila.Cells[0].Value?.ToString() ?? "",
                    app = fila.Cells[1].Value?.ToString() ?? "",
                    apm = fila.Cells[2].Value?.ToString() ?? "",
                    direccion = fila.Cells[3].Value?.ToString() ?? "",
                    telefono = fila.Cells[4].Value?.ToString() ?? "",
                    correo = fila.Cells[5].Value?.ToString() ?? ""
                };

                registros.Contactos.Add(contacto);
            }

            registros.TotalRegistros = registros.Contactos.Count;
            registros.Actualizacion = DateTime.Now;
            return registros;
        }

        private void GuardarJson(BaseDatosJson lista)
        {
            var opciones = new JsonSerializerSettings
            {
                Formatting = Formatting.Indented,
                DateFormatHandling = DateFormatHandling.IsoDateFormat,
                NullValueHandling = NullValueHandling.Ignore,
            };

            string json = JsonConvert.SerializeObject(lista, opciones);
            File.WriteAllText(sfdJson.FileName, json);
        }

        private void CargarRegistros(BaseDatosJson registros)
        {
            dgvAgenda.Rows.Clear();
            foreach (var contacto in registros.Contactos)
            {
                dgvAgenda.Rows.Add(new object[]
                { contacto.nombre, contacto.app, contacto.apm, contacto.direccion, contacto.telefono, contacto.correo });
            }

            dgvAgenda.Rows.Clear();
            foreach (var contacto in registros.Contactos)
            {
                dgvAgenda.Rows.Add(new object[]
                { contacto.nombre, contacto.app, contacto.apm, contacto.direccion, contacto.telefono, contacto.correo });
            }


        }
        private void ActualizarStatus(BaseDatosJson registros)
        {
            lblRegistros.Text = $"Registros: {registros.TotalRegistros}";
            lblActualizacion.Text = $"Última actualización: {registros.Actualizacion:dd/MM/yyyy HH:mm:ss}";
        }


        private void cargar_Click(object sender, EventArgs e)
        {

            if (ofdJson.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string json = File.ReadAllText(ofdJson.FileName);
                    var registros = JsonConvert.DeserializeObject<BaseDatosJson>(json);
                    CargarRegistros(registros);
                    ActualizarStatus(registros);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Sistema",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
        }

        private void guardar_Click(object sender, EventArgs e)
        {

            try
            {
                var baseDatos = CargarDatos();
                if (sfdJson.ShowDialog() == DialogResult.OK)
                {
                    GuardarJson(baseDatos);
                    ActualizarStatus(baseDatos);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Sistema",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
