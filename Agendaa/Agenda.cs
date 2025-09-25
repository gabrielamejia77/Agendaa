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

        // Ruta fija para guardar en Mis Documentos
        private string rutaArchivo = Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
            "agenda.json"
        );

        public Agenda()
        {
            InitializeComponent();

            // Guardar al editar celdas
            dgvAgenda.CellValueChanged += dgvAgenda_CellValueChanged;

            // Detectar cuando termina de editar una celda (importante para combos o checks)
            dgvAgenda.CurrentCellDirtyStateChanged += (s, e) =>
            {
                if (dgvAgenda.IsCurrentCellDirty)
                    dgvAgenda.CommitEdit(DataGridViewDataErrorContexts.Commit);
            };

            // Guardar al agregar o quitar filas
            dgvAgenda.RowsAdded += dgvAgenda_RowsChanged;
            dgvAgenda.RowsRemoved += dgvAgenda_RowsChanged;

            // Guardar al cerrar el formulario
            this.FormClosing += Agenda_FormClosing;
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
            File.WriteAllText(rutaArchivo, json);
        }

        private void CargarRegistros(BaseDatosJson registros)
        {
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
            if (File.Exists(rutaArchivo))
            {
                try
                {
                    string json = File.ReadAllText(rutaArchivo);
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
            else
            {
                MessageBox.Show("No existe un archivo de agenda aún.", "Sistema",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // 🔹 Guardado automático centralizado
        private void GuardarAutomatico()
        {
            try
            {
                var baseDatos = CargarDatos();
                GuardarJson(baseDatos);
                ActualizarStatus(baseDatos);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Sistema",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 🔹 Cuando cambie una celda
        private void dgvAgenda_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            GuardarAutomatico();
        }

        // 🔹 Cuando agregues o borres filas
        private void dgvAgenda_RowsChanged(object sender, EventArgs e)
        {
            GuardarAutomatico();
        }

        // 🔹 Cuando cierres el formulario
        private void Agenda_FormClosing(object sender, FormClosingEventArgs e)
        {
            GuardarAutomatico();
        }
    }
}
