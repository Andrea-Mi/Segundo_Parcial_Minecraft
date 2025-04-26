using System;
using MinecraftSP.Models;
using MinecraftSP.Services;
using MinecraftSP.Utils;
using MinecraftSP.UI;
using MinecraftSP;
using System.Windows.Forms;

namespace MinecraftManager;
    static class Program
{
    [STAThread]
    static void Main()
    {
        // Configuración de Windows Forms
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);

        // Inicializar servicios
        var dbManager = new DatabaseManager();
        var jugadorService = new JugadorService(dbManager);
        var bloqueService = new BloqueService(dbManager);
        var inventarioService = new InventarioService(dbManager, jugadorService, bloqueService);

        // Verificar conexión a la base de datos
        if (!dbManager.TestConnection())
        {
            MessageBox.Show("No se pudo conectar a la base de datos. Verifique la conexión e intente nuevamente.",
                            "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        // Iniciar el formulario principal
        Application.Run(new Form1()); // Cambia "Form1" por el nombre de tu formulario
    }
}
