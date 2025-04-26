using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MinecraftSP.Services;
using MinecraftSP.Utils;
using MinecraftSP.Models;

namespace MinecraftSP
{
    public partial class Form1 : Form
    {
        private readonly JugadorService _jugadorService;
        private readonly BloqueService _bloqueService;
        private readonly InventarioService _inventarioService;
        public Form1()
        {
            // Inicializar servicios
            var dbManager = new DatabaseManager();
            _jugadorService = new JugadorService(dbManager);
            _bloqueService = new BloqueService(dbManager);
            _inventarioService = new InventarioService(dbManager, _jugadorService, _bloqueService);

            InitializeComponent();
        }

        private void CargarJugadores()
        {
            // Obtener la lista de jugadores desde el servicio
            var jugadores = _jugadorService.ObtenerTodos();

            // Asignar los datos al DataGridView
            Mostrar_Informacion.DataSource = jugadores.Select(j => new
            {
                j.Id,
                j.Nombre,
                j.Nivel,
                j.FechaCreacion
            }).ToList();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CargarJugadores();
            CargarFiltros();
            Imagen_Bloques.Image = Image.FromFile("C:\\Minecraft SP\\MinecraftSP\\IMG\\Logo Minecraf.jpg");
        }

        private void Agregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Nombre_Jugador.Text))
            {
                MessageBox.Show("El nombre del jugador no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var jugador = new Jugador
            {
                Nombre = Nombre_Jugador.Text,
                Nivel = (int)Nivel_Jugador.Value
            };

            _jugadorService.Crear(jugador);
            MessageBox.Show("Jugador agregado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;


            // Actualizar la lista de jugadores
            CargarJugadores();
        }

        private void Actualizar_Click(object sender, EventArgs e)
        {
            if (Mostrar_Informacion.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un jugador para actualizar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var id = (int)Mostrar_Informacion.SelectedRows[0].Cells["Id"].Value;
            var jugador = _jugadorService.ObtenerPorId(id);

            if (jugador != null)
            {
                jugador.Nombre = Nombre_Jugador.Text;
                jugador.Nivel = (int)Nivel_Jugador.Value;

                _jugadorService.Actualizar(jugador);
                MessageBox.Show("Jugador actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Actualizar la lista de jugadores
                CargarJugadores();
            }
        }

        private void Eliminar_Click(object sender, EventArgs e)
        {
            if (Mostrar_Informacion.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un jugador para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var id = (int)Mostrar_Informacion.SelectedRows[0].Cells["Id"].Value;

            var confirmResult = MessageBox.Show("¿Está seguro de eliminar este jugador?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirmResult == DialogResult.Yes)
            {
                _jugadorService.Eliminar(id);
                MessageBox.Show("Jugador eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Actualizar la lista de jugadores
                CargarJugadores();
            }
        }

        private void CargarFiltros()
        {
            try
            {
                // Obtener todos los bloques desde el servicio
                var bloques = _bloqueService.ObtenerTodos();

                // Verificar si hay datos
                if (bloques == null || !bloques.Any())
                {
                    MessageBox.Show("No se encontraron bloques en la base de datos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Asignar los tipos de bloque al ComboBox Tipos_Bloque
                var tipos = bloques.Select(b => b.Tipo).Distinct().ToList();
                Tipos_Bloque.DataSource = tipos;

                // Asignar las rarezas de bloque al ComboBox Rareza_Bloques
                var rarezas = bloques.Select(b => b.Rareza).Distinct().ToList();
                Rareza_Bloques.DataSource = rarezas;

                // Depuración: Imprimir los datos en la consola
                Console.WriteLine("Tipos de Bloque: " + string.Join(", ", tipos));
                Console.WriteLine("Rarezas de Bloque: " + string.Join(", ", rarezas));
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los filtros: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Filtro_Click(object sender, EventArgs e)
        {
            var tipo = Tipos_Bloque.SelectedItem?.ToString();
            var rareza = Rareza_Bloques.SelectedItem?.ToString();

            var bloques = _bloqueService.ObtenerTodos()
                .Where(b => (string.IsNullOrEmpty(tipo) || b.Tipo == tipo) &&
                            (string.IsNullOrEmpty(rareza) || b.Rareza == rareza))
                .ToList();

            Mostrar_Informacion.DataSource = bloques.Select(b => new
            {
                b.Id,
                b.Nombre,
                b.Tipo,
                b.Rareza
            }).ToList();

            if (string.IsNullOrWhiteSpace(Nombre_Jugador.Text))
            {
                MessageBox.Show("El nombre del jugador no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }




        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Tipos_Bloque_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Rareza_Bloques_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Mostrar_Informacion_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Seleccion_RarezaBloque_Click(object sender, EventArgs e)
        {

        }
        private void ExportarInventarioACSV()
        {
            try
            {
                // Obtener los datos del inventario
                var inventarios = _inventarioService.ObtenerTodos();

                if (inventarios == null || !inventarios.Any())
                {
                    MessageBox.Show("No hay datos en el inventario para exportar.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Mostrar un cuadro de diálogo para guardar el archivo
                using (var saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "Archivos CSV (*.csv)|*.csv";
                    saveFileDialog.Title = "Guardar Inventario como CSV";

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        // Crear el archivo CSV
                        using (var writer = new StreamWriter(saveFileDialog.FileName))
                        {
                            // Escribir encabezados
                            writer.WriteLine("Id,JugadorId,BloqueId,Cantidad,NombreJugador,NombreBloque");

                            // Escribir datos
                            foreach (var inventario in inventarios)
                            {
                                writer.WriteLine($"{inventario.Id},{inventario.JugadorId},{inventario.BloqueId},{inventario.Cantidad},{inventario.NombreJugador},{inventario.NombreBloque}");
                            }
                        }

                        MessageBox.Show("Inventario exportado correctamente a CSV.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al exportar el inventario a CSV: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ExportarInventarioAExcel()
        {
            try
            {
                // Obtener los datos del inventario
                var inventarios = _inventarioService.ObtenerTodos();

                if (inventarios == null || !inventarios.Any())
                {
                    MessageBox.Show("No hay datos en el inventario para exportar.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Mostrar un cuadro de diálogo para guardar el archivo
                using (var saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "Archivos Excel (*.xlsx)|*.xlsx";
                    saveFileDialog.Title = "Guardar Inventario como Excel";

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        // Crear el archivo Excel
                        using (var package = new OfficeOpenXml.ExcelPackage())
                        {
                            var worksheet = package.Workbook.Worksheets.Add("Inventario");

                            // Escribir encabezados
                            worksheet.Cells[1, 1].Value = "Id";
                            worksheet.Cells[1, 2].Value = "JugadorId";
                            worksheet.Cells[1, 3].Value = "BloqueId";
                            worksheet.Cells[1, 4].Value = "Cantidad";
                            worksheet.Cells[1, 5].Value = "NombreJugador";
                            worksheet.Cells[1, 6].Value = "NombreBloque";

                            // Escribir datos
                            int row = 2;
                            foreach (var inventario in inventarios)
                            {
                                worksheet.Cells[row, 1].Value = inventario.Id;
                                worksheet.Cells[row, 2].Value = inventario.JugadorId;
                                worksheet.Cells[row, 3].Value = inventario.BloqueId;
                                worksheet.Cells[row, 4].Value = inventario.Cantidad;
                                worksheet.Cells[row, 5].Value = inventario.NombreJugador;
                                worksheet.Cells[row, 6].Value = inventario.NombreBloque;
                                row++;
                            }

                            // Guardar el archivo
                            package.SaveAs(new FileInfo(saveFileDialog.FileName));
                        }

                        MessageBox.Show("Inventario exportado correctamente a Excel.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al exportar el inventario a Excel: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
