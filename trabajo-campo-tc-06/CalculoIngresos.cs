using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace trabajo_campo_tc_06 {
  public partial class CalculoIngresos : Form {
    public CalculoIngresos() {
      InitializeComponent();
      this.Load += new System.EventHandler(Up_Load);
    }

    private void Up_Load(object? sender, EventArgs e) {
      cmb_ordenar.Items.Add("Por nombre");
      cmb_ordenar.Items.Add("Por Apellido");
      cmb_ordenar.SelectedIndex = 0;
    }

    // ---- MÉTODOS DE VALIDACIÓN ----
    private string ValidarNombre() {
      string nombre = txt_nombre.Text.Trim();
      if(string.IsNullOrWhiteSpace(nombre))
        throw new Exception("El campo nombre es requerido");
      return nombre;
    }

    private string ValidarApellido() {
      string apellido = txt_apellido.Text.Trim();
      if(string.IsNullOrWhiteSpace(apellido))
        throw new Exception("El campo apellido es requerido.");
      return apellido;
    }

    private double ValidarSalario() {
      if(!double.TryParse(txt_salario_mensual.Text, out double salario) || salario <= 0)
        throw new Exception("Ingrese un salario mensual válido mayor a 0.");
      return salario;
    }



    // ---- MÉTODO AUXILIAR ----
    private string ObtenerNombreCompleto() {
      string nombre = ValidarNombre();
      string apellido = ValidarApellido();

      string nombreFormateado = char.ToUpper(nombre[ 0 ]) + nombre.Substring(1).ToLower();
      string apellidoFormateado = char.ToUpper(apellido[ 0 ]) + apellido.Substring(1).ToLower();

      return $"{nombreFormateado} {apellidoFormateado}";
    }

    // Procesar (empleado, salario mensual y anual)
    private void btn_procesar_Click(object sender, EventArgs e) {
      try {
        string nombreCompleto = ObtenerNombreCompleto();
        double salario_mensual = ValidarSalario();
        double salario_anual = salario_mensual * 12;

        lst_calculo.Items.Clear();
        lst_calculo.Items.Add($"Empleado: {nombreCompleto}");
        lst_calculo.Items.Add($"Salario mensual: {salario_mensual:C}");
        lst_calculo.Items.Add($"Salario anual: {salario_anual:C}");
        lbl_mensaje.Text = "";
      } catch(Exception ex) {
        lbl_mensaje.Text = ex.Message;
      }
    }


    // Longitud
    private void btn_longitud_Click(object sender, EventArgs e) {
      try {
        string nombreCompleto = ObtenerNombreCompleto();
        lst_resultados.Text = $"Longitud: {nombreCompleto.Length}";
      } catch(Exception ex) {
        lbl_mensaje.Text = ex.Message;
      }
    }


    // Conversión a mayúsculas/minúsculas
    private void btn_conversion_Click(object sender, EventArgs e) {
      try {
        string nombreCompleto = ObtenerNombreCompleto();
        lst_resultados.Text =
            $"Mayúsculas: {nombreCompleto.ToUpper()}\r\n" +
            $"Minúsculas: {nombreCompleto.ToLower()}";
      } catch(Exception ex) {
        lbl_mensaje.Text = ex.Message;
      }
    }

    // Substring
    private void btn_substring_Click(object sender, EventArgs e) {
      try {
        string nombre = ValidarNombre();
        lst_resultados.Text = $"Primeros 3 caracteres: {nombre.Substring(0, Math.Min(3, nombre.Length))}";
      } catch(Exception ex) {
        lbl_mensaje.Text = ex.Message;
      }
    }

    // IndexOf
    private void btn_index_of_Click(object sender, EventArgs e) {
      try {
        string nombre = ValidarNombre();
        int pos = nombre.IndexOf('a');
        lst_resultados.Text = pos >= 0 ? $"Posición de 'a': {pos}" : "No se encontró la letra 'a'";
      } catch(Exception ex) {
        lbl_mensaje.Text = ex.Message;
      }
    }

    // Replace
    private void btn_replace_Click(object sender, EventArgs e) {
      try {
        string nombre = ValidarNombre();
        lst_resultados.Text = nombre.Replace("a", "@");
      } catch(Exception ex) {
        lbl_mensaje.Text = ex.Message;
      }
    }

    // Acceso por índice (primer carácter del nombre)
    private void btn_indice_Click(object sender, EventArgs e) {
      try {
        string nombre = ValidarNombre();
        lst_resultados.Text = $"Primer carácter del nombre: {nombre[ 0 ]}";
      } catch(Exception ex) {
        lbl_mensaje.Text = ex.Message;
      }
    }

    // Split: dividir el nombre completo en palabras
    private void btn_split_Click(object sender, EventArgs e) {
      try {
        string nombreCompleto = ObtenerNombreCompleto();
        string[ ] partes = nombreCompleto.Split(' ');

        lst_resultados.Text = "Palabras separadas:\r\n";
        foreach(string parte in partes)
          lst_resultados.Text += $" - {parte}\r\n";
      } catch(Exception ex) {
        lbl_mensaje.Text = ex.Message;
      }
    }

    // Ordenar nombres (según lo que seleccione el combo)
    private void btn_ordenar_Click(object sender, EventArgs e) {
      try {
        string nombre = ValidarNombre();
        string apellido = ValidarApellido();

        string[ ] partes = { nombre, apellido };

        if(cmb_ordenar.SelectedIndex == 0) // Por nombre
          Array.Sort(partes, StringComparer.InvariantCultureIgnoreCase);
        else // Por apellido
          Array.Sort(partes, StringComparer.InvariantCultureIgnoreCase);

        lst_resultados.Text = "Ordenado alfabéticamente:\r\n";
        foreach(string parte in partes)
          lst_resultados.Text += $" - {parte}\r\n";
      } catch(Exception ex) {
        lbl_mensaje.Text = ex.Message;
      }
    }

    // Buscar coincidencia dentro del nombre completo
    private void btn_buscar_Click(object sender, EventArgs e) {
      lst_resultados.Items.Clear();
      try {
        string nombreCompleto = ObtenerNombreCompleto();
        double salario_mensual = ValidarSalario();
        double salario_anual = salario_mensual * 12;
        string buscar = txt_buscar.Text.Trim();

        if(string.IsNullOrWhiteSpace(buscar)) {
          lbl_mensaje.Text = "Ingrese la letra por la que desea buscar ";
          return;
        }

        // Buscar coincidencia en el nombre completo
        bool encontrado = nombreCompleto.IndexOf(
            buscar, StringComparison.InvariantCultureIgnoreCase) >= 0;

        if(encontrado) {
          // Mostrar toda la info solo si existe coincidencia
          lst_resultados.Items.Add($"Empleado: {nombreCompleto}");
          lst_resultados.Items.Add($"Salario mensual: {salario_mensual:C}");
          lst_resultados.Items.Add($"Salario anual: {salario_anual:C}");
        } else {
          // Solo mostrar mensaje de no encontrado
          lst_resultados.Items.Add($"No se encontraron coincidencias con '{buscar}'.");
        }

        lbl_mensaje.Text = "";
      } catch(Exception ex) {
        lbl_mensaje.Text = ex.Message;
      }
    }



  }
}