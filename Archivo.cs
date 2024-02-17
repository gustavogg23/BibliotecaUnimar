using System;
using System.IO;
using System.Windows.Forms;

public class Archivo
{
    public static string Leer(string ruta)
    {
        if (File.Exists(ruta))
        {
            return File.ReadAllText(ruta);
        }
        else
        {
            return "El archivo no existe";
        }
    }

    public static void Escribir(string ruta, string informacion)
    {
        try
        {
            using (var sw = new StreamWriter(ruta, true))
            {
                sw.WriteLine(informacion);
            }
        }
        catch (Exception e)
        {
            MessageBox.Show("Error: " + e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
