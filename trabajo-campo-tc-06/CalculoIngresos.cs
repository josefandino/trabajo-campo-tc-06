using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace trabajo_campo_tc_06
{
  public partial class CalculoIngresos : Form
  {
    public CalculoIngresos()
    {
      InitializeComponent();
      this.Load += new System.EventHandler(Up_Load);
    }

    private void Up_Load(object? sender, EventArgs e)
    {
      cmb_ordenar.Items.Add("Por nombre");
      cmb_ordenar.Items.Add("Por Apellido");
      cmb_ordenar.SelectedIndex = 0;
    }

    // ---- MÉTODOS DE VALIDACIÓN ----
    private string ValidarNombre()
    {
      string nombre = txt_nombre.Text.Trim();

      if (string.IsNullOrWhiteSpace(nombre))
        throw new Exception("El campo nombre es requerido.");

      if (nombre.Length < 3)
        throw new Exception("El nombre debe tener al menos 3 caracteres.");

      return nombre;
    }

    private string ValidarApellido()
    {
      string apellido = txt_apellido.Text.Trim();

      if (string.IsNullOrWhiteSpace(apellido))
        throw new Exception("El campo apellido es requerido.");

      if (apellido.Length < 3)
        throw new Exception("El apellido debe tener al menos 3 caracteres.");

      return apellido;
    }


    private double ValidarSalario()
    {
      if (!double.TryParse(txt_salario_mensual.Text, out double salario) || salario <= 0)
        throw new Exception("Ingrese un salario mensual válido mayor a 0.");
      return salario;
    }

    // ---- MÉTODO AUXILIAR ----
    private string ObtenerNombreCompleto()
    {
      string nombre = ValidarNombre();
      string apellido = ValidarApellido();

      string nombreFormateado = char.ToUpper(nombre[0]) + nombre.Substring(1).ToLower();
      string apellidoFormateado = char.ToUpper(apellido[0]) + apellido.Substring(1).ToLower();

      return $"{nombreFormateado} {apellidoFormateado}";
    }

    // Procesar (empleado, salario mensual y anual)
    private void btn_procesar_Click(object sender, EventArgs e)
    {
      try
      {
        string nombreCompleto = ObtenerNombreCompleto();
        double salario_mensual = ValidarSalario();
        double salario_anual = salario_mensual * 12;

        lst_calculo.Items.Clear();
        lst_calculo.Items.Add($"Empleado: {nombreCompleto}");
        lst_calculo.Items.Add($"Salario mensual: {salario_mensual:C}");
        lst_calculo.Items.Add($"Salario anual: {salario_anual:C}");
        lbl_mensaje.Text = "";
      }
      catch (Exception ex)
      {
        lbl_mensaje.Text = ex.Message;
      }
    }


    // ---- BOTONES DE OPERACIONES ----

    // Longitud
    private void btn_longitud_Click(object sender, EventArgs e)
    {
      lst_resultados.Items.Clear();
      try
      {
        string nombre = ValidarNombre();
        string apellido = ValidarApellido();
        double salario_mensual = ValidarSalario();
        double salario_anual = salario_mensual * 12;

        lst_resultados.Items.Add($"Longitud del nombre: {nombre.Length}");
        lst_resultados.Items.Add($"Longitud del apellido: {apellido.Length}");

        lbl_mensaje.Text = "";
      }
      catch (Exception ex)
      {
        lbl_mensaje.Text = ex.Message;
      }
    }

    // Conversión a mayúsculas/minúsculas
    private bool enMayusculas = false;

    private void btn_conversion_Click(object sender, EventArgs e)
    {
      lst_resultados.Items.Clear();
      try
      {
        string nombreCompleto = ObtenerNombreCompleto();
        double salario_mensual = ValidarSalario();

        if (enMayusculas)
        {
          lst_resultados.Items.Add($"Minúsculas: {nombreCompleto.ToLower()}");
          enMayusculas = false;
        }
        else
        {
          lst_resultados.Items.Add($"Mayúsculas: {nombreCompleto.ToUpper()}");
          enMayusculas = true;
        }

        lbl_mensaje.Text = "";
      }
      catch (Exception ex)
      {
        lbl_mensaje.Text = ex.Message;
      }
    }

    // Split: dividir el nombre completo en palabras
    private void btn_split_Click(object sender, EventArgs e)
    {
      lst_resultados.Items.Clear();
      try
      {
        string nombreCompleto = ObtenerNombreCompleto();
        double salario_mensual = ValidarSalario();
        string[] partes = nombreCompleto.Split(' ');

        lst_resultados.Items.Add("Palabras separadas  por: - ");
        foreach (string parte in partes)
        {
          lst_resultados.Items.Add($" - {parte}");
        }

        lbl_mensaje.Text = "";
      }
      catch (Exception ex)
      {
        lbl_mensaje.Text = ex.Message;
      }
    }

    // Acceso por índice (primer carácter del nombre)
    private void btn_indice_Click(object sender, EventArgs e)
    {
      lst_resultados.Items.Clear();
      try
      {
        string nombre = ValidarNombre();
        string apellido = ValidarApellido();
        double salario_mensual = ValidarSalario();

        lst_resultados.Items.Add($"Primer carácter del nombre: {char.ToUpper(nombre[0])}");
        lst_resultados.Items.Add($"Primer carácter del apellido: {char.ToUpper(apellido[0])}");

        lbl_mensaje.Text = "";
      }
      catch (Exception ex)
      {
        lbl_mensaje.Text = ex.Message;
      }
    }

    private void btn_index_of_Click(object sender, EventArgs e)
    {
      lst_resultados.Items.Clear();
      try
      {
        string nombre = ValidarNombre();
        string apellido = ValidarApellido();
        double salario_mensual = ValidarSalario();

        // Buscar en el nombre
        int posNombre = nombre.IndexOf('a');
        if (posNombre >= 0)
          lst_resultados.Items.Add($"La primera 'a' en el nombre se encuentra en la posición: {posNombre}");
        else
          lst_resultados.Items.Add("No se encontró la letra 'a' en el nombre.");

        // Buscar en el apellido
        int posApellido = apellido.IndexOf('a');
        if (posApellido >= 0)
          lst_resultados.Items.Add($"La primera 'a' en el apellido se encuentra en la posición: {posApellido}");
        else
          lst_resultados.Items.Add("No se encontró la letra 'a' en el apellido.");

        lbl_mensaje.Text = "";
      }
      catch (Exception ex)
      {
        lbl_mensaje.Text = ex.Message;
      }
    }

    // Substring
    private void btn_substring_Click(object sender, EventArgs e)
    {
      lst_resultados.Items.Clear();
      try
      {
        string nombre = ValidarNombre();
        string apellido = ValidarApellido();
        double salario_mensual = ValidarSalario();

        // Substring de los 3 primeros caracteres del nombre y apellido
        string primerosNombre = nombre.Substring(0, Math.Min(3, nombre.Length));
        string primerosApellido = apellido.Substring(0, Math.Min(3, apellido.Length));

        lst_resultados.Items.Add($"Primeros 3 caracteres del nombre: {primerosNombre.ToUpper()}");
        lst_resultados.Items.Add($"Primeros 3 caracteres del apellido: {primerosApellido.ToUpper()}");

        lbl_mensaje.Text = "";
      }
      catch (Exception ex)
      {
        lbl_mensaje.Text = ex.Message;
      }
    }

    // Replace
    private void btn_replace_Click(object sender, EventArgs e)
    {
      lst_resultados.Items.Clear();
      try
      {
        string nombre = ValidarNombre();
        string apellido = ValidarApellido();
        double salario_mensual = ValidarSalario();

        string nombreReemplazado = nombre.Replace("a", "@").Replace("A", "@");
        string apellidoReemplazado = apellido.Replace("a", "@").Replace("A", "@");

        lst_resultados.Items.Add($"Nombre con reemplazo: {nombreReemplazado}");
        lst_resultados.Items.Add($"Apellido con reemplazo: {apellidoReemplazado}");

        lbl_mensaje.Text = "";
      }
      catch (Exception ex)
      {
        lbl_mensaje.Text = ex.Message;
      }
    }

    // Ordenar nombres (según lo que seleccione el combo)
    private void btn_ordenar_Click(object sender, EventArgs e)
    {
      lst_resultados.Items.Clear();
      try
      {
        string nombre = ValidarNombre();
        string apellido = ValidarApellido();
        double salario_mensual = ValidarSalario();

        lst_resultados.Items.Add("Ordenado alfabéticamente:");

        if (cmb_ordenar.SelectedIndex == 0) // Por nombre
        {
          lst_resultados.Items.Add($" - {nombre}");
          lst_resultados.Items.Add($" - {apellido}");
        }
        else // Por apellido
        {
          lst_resultados.Items.Add($" - {apellido}");
          lst_resultados.Items.Add($" - {nombre}");
        }

        lbl_mensaje.Text = "";
      }
      catch (Exception ex)
      {
        lbl_mensaje.Text = ex.Message;
      }
    }

    // Buscar coincidencia dentro del nombre completo
    private void btn_buscar_Click(object sender, EventArgs e)
    {
      lst_resultados.Items.Clear();
      try
      {
        string nombreCompleto = ObtenerNombreCompleto();
        double salario_mensual = ValidarSalario();
        double salario_anual = salario_mensual * 12;
        string buscar = txt_buscar.Text.Trim();

        if (string.IsNullOrWhiteSpace(buscar))
        {
          lbl_mensaje.Text = "Ingrese la letra por la que desea buscar ";
          return;
        }

        // Buscar coincidencia en el nombre completo
        bool encontrado = nombreCompleto.IndexOf(
            buscar, StringComparison.InvariantCultureIgnoreCase) >= 0;

        if (encontrado)
        {
          // Mostrar toda la info solo si existe coincidencia
          lst_resultados.Items.Add($"Empleado: {nombreCompleto}");
          lst_resultados.Items.Add($"Salario mensual: {salario_mensual:C}");
          lst_resultados.Items.Add($"Salario anual: {salario_anual:C}");
        }
        else
        {
          // Solo mostrar mensaje de no encontrado
          lst_resultados.Items.Add($"No se encontraron coincidencias con '{buscar}'.");
        }

        lbl_mensaje.Text = "";
      }
      catch (Exception ex)
      {
        lbl_mensaje.Text = ex.Message;
      }
    }

    // Concatenar nombre y apellido
    private void btn_concatenar_Click(object sender, EventArgs e)
    {
      lst_resultados.Items.Clear();
      try
      {
        string nombre = ValidarNombre();
        string apellido = ValidarApellido();
        double salario_mensual = ValidarSalario();
        double salario_anual = salario_mensual * 12;

        string nombreCompleto = $"{nombre} {apellido}";

        lst_resultados.Items.Add($"Nombre completo: {nombreCompleto.ToUpper()}");

        lbl_mensaje.Text = "";
      }
      catch (Exception ex)
      {
        lbl_mensaje.Text = ex.Message;
      }
    }

  }
}