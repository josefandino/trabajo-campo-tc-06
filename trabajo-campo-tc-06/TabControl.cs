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


  public partial class tb_control : Form {

    public class Cliente {
      public string Nombre { get; set; }
      public string DNI { get; set; }
      public double MontoPrestamo { get; set; }
      public DateTime Fecha { get; set; }
      public int Periodo { get; set; }
      public string Categoria { get; set; }
    }

    public tb_control() {
      InitializeComponent();
      this.Load += new System.EventHandler(Data_Load);
    }

    private void Data_Load(object? sender, EventArgs e) {
      // Cargar los períodos en el ComboBox
      cmb_periodo.Items.Add("3 meses");
      cmb_periodo.Items.Add("6 meses");
      cmb_periodo.Items.Add("9 meses");
      cmb_periodo.Items.Add("12 meses");
      cmb_periodo.Items.Add("15 meses");
      cmb_periodo.Items.Add("18 meses");
      cmb_periodo.Items.Add("21 meses");
      cmb_periodo.Items.Add("24 meses");

      cmb_periodo.SelectedIndex = 0;

      // Seleccionar la tasa media por defecto
      rtb_tasa_baja.Checked = true;

      // Cargar la fecha de hoy por defecto
      DateTime hoy = DateTime.Today;
      txt_fecha.Text = hoy.ToString("dd/MM/yyyy");

      // Configurar el ordenamiento
      cmb_ordenar.Items.Add("Monto ↑");
      cmb_ordenar.Items.Add("Monto ↓");
      cmb_ordenar.Items.Add("Fecha ↑");
      cmb_ordenar.Items.Add("Fecha ↓");
      cmb_ordenar.SelectedIndex = 0;
    }

    Cliente[ ] clientes = new Cliente[ 0 ];

    private void date_picker_ValueChanged(object sender, EventArgs e) {
      var datePicker = (DateTimePicker) sender;
      txt_fecha.Text = datePicker.Value.ToString("dd/MM/yyyy");
      date_picker.MinDate = DateTime.Today;

      // Validar contra la fecha de hoy (sin hora)
      if(datePicker.Value.Date < DateTime.Today) {
        lbl_error_fecha.Text = "La fecha no puede ser anterior al día de hoy.";
        lbl_error_fecha.Visible = true;
      } else {
        lbl_error_fecha.Visible = false;
      }
    }

    private void btn_register_Click(object sender, EventArgs e) {
      // 1) Validación de campos vacíos
      if(string.IsNullOrWhiteSpace(txt_nombre.Text) ||
          string.IsNullOrWhiteSpace(txt_dni.Text) ||
          string.IsNullOrWhiteSpace(txt_monto.Text) ||
          cmb_periodo.SelectedIndex == -1) {
        lbl_mensaje.Text = "Por favor, complete todos los campos obligatorios.";
        return;
      }

      // 2) Validación de monto
      if(!double.TryParse(txt_monto.Text, out double monto) || monto <= 0) {
        lbl_mensaje.Text = "El monto debe ser un número positivo.";
        return;
      }

      // 3) Determinar categoría de tasa
      string categoria = "";
      if(rtb_tasa_baja.Checked) categoria = "Baja";
      else if(rtb_tasa_media.Checked) categoria = "Media";
      else if(rtb_tasa_alta.Checked) categoria = "Alta";

      // 4) Convertir periodo (quita la palabra "meses")
      string periodoTexto = cmb_periodo.SelectedItem.ToString();
      int periodo = int.Parse(periodoTexto.Split(' ')[ 0 ]);

      // 5) Crear objeto cliente
      Cliente nuevoCliente = new Cliente {
        Nombre = txt_nombre.Text,
        DNI = txt_dni.Text,
        MontoPrestamo = monto,
        Fecha = date_picker.Value,
        Periodo = periodo,
        Categoria = categoria
      };

      // 6) Guardar en el arreglo unidimensional
      int longitudActual = clientes.Length;
      Array.Resize(ref clientes, longitudActual + 1);
      clientes[ longitudActual ] = nuevoCliente;

      string nombreFormateado = char.ToUpper(nuevoCliente.Nombre[ 0 ]) + nuevoCliente.Nombre.Substring(1);


      // 7) Mostrar en ListBox
      lst_clientes.Items.Add(
        $"{nombreFormateado} | " +
        $"{nuevoCliente.DNI} | " +
        $"{nuevoCliente.MontoPrestamo:C} | " +
        $"{nuevoCliente.Periodo} meses | " +
        $"{nuevoCliente.Categoria} | " +
        $"{nuevoCliente.Fecha:dd/MM/yyyy}");

      lbl_mensaje.Text = "Cliente registrado exitosamente.";

      // 8) Limpiar campos de entrada
      txt_nombre.Clear();
      txt_dni.Clear();
      txt_monto.Clear();
    }

    private void btn_ordenar_Click(object sender, EventArgs e) {
      cmb_ordenar_SelectedIndexChanged(sender, e);
    }

    private void cmb_ordenar_SelectedIndexChanged(object sender, EventArgs e) {
      if(clientes == null || clientes.Length == 0) {
        lbl_mensaje.Text = "No hay clientes registrados.";
        return;
      }

      IEnumerable<Cliente> ordenados = clientes;

      switch(cmb_ordenar.SelectedItem.ToString()) {
        case "Monto ↑":
          ordenados = clientes.OrderBy(c => c.MontoPrestamo);
          break;
        case "Monto ↓":
          ordenados = clientes.OrderByDescending(c => c.MontoPrestamo);
          break;
        case "Fecha ↑":
          ordenados = clientes.OrderBy(c => c.Fecha);
          break;
        case "Fecha ↓":
          ordenados = clientes.OrderByDescending(c => c.Fecha);
          break;
      }

      // Refrescar el ListBox
      lst_clientes.Items.Clear();
      foreach(var cliente in ordenados) {
        lst_clientes.Items.Add(
            $"{cliente.Nombre} | " +
            $"{cliente.DNI} | " +
            $"{cliente.MontoPrestamo:C} | " +
            $"{cliente.Periodo} meses | " +
            $"{cliente.Categoria} | " +
            $"{cliente.Fecha:dd/MM/yyyy}"
        );
      }

      lbl_mensaje.Text = "Clientes ordenados correctamente.";
    }

    private Cliente BuscarClientePorDni(string dni) {
      return clientes.FirstOrDefault(c => c != null && c.DNI == dni);
    }

    // Fila: categoría (0=baja, 1=media, 2=alta)
    // Columna: periodo (6,12,24) => ajusta según tus valores
    double[ , ] tasas = {
    { 5.0, 5.5, 6.0 },  // Baja
    { 7.0, 7.5, 8.0 },  // Media
    { 9.0, 9.5, 10.0 }  // Alta
};

    private double ObtenerTasa(string categoria, int periodo) {
      int fila = categoria == "Baja" ? 0 : categoria == "Media" ? 1 : 2;
      int col = periodo == 6 ? 0 : periodo == 12 ? 1 : 2;
      return tasas[ fila, col ];
    }

    private void GenerarCronograma(Cliente cliente) {
      lst_cronograma.Items.Clear();

      double tasa = ObtenerTasa(cliente.Categoria, cliente.Periodo);
      double montoTotal = cliente.MontoPrestamo + (cliente.MontoPrestamo * tasa / 100);
      double cuotaMensual = montoTotal / cliente.Periodo;

      for(int mes = 1; mes <= cliente.Periodo; mes++) {
        lst_cronograma.Items.Add($"Mes {mes}: {cuotaMensual:C}");
      }

      lbl_monto_total.Text = $"Monto Total: {montoTotal:C}";
      lbl_tasa_aplicada.Text = $"Tasa: {tasa}%";
    }

    private void btn_buscar_Click(object sender, EventArgs e) {
      if(string.IsNullOrWhiteSpace(txt_buscar_dni.Text)) {
        lbl_resultado_busqueda.Text = "Ingrese un DNI válido.";
        return;
      }

      Cliente encontrado = BuscarClientePorDni(txt_buscar_dni.Text);

      if(encontrado == null) {
        lbl_resultado_busqueda.Text = "Cliente no encontrado.";
        lst_cronograma.Items.Clear();
        return;
      }

      lbl_resultado_busqueda.Text = $"Cliente encontrado: {encontrado.Nombre.ToUpper()}";
      GenerarCronograma(encontrado);
    }

    }
}
