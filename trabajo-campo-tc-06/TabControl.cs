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
    public tb_control() {
      InitializeComponent();
      this.Load += new System.EventHandler(Periodo_Load);
    }

    private void Periodo_Load(object? sender, EventArgs e) {
      cmb_periodo.Items.Add("3 meses");
      cmb_periodo.Items.Add("6 meses");
      cmb_periodo.Items.Add("9 meses");
      cmb_periodo.Items.Add("12 meses");
      cmb_periodo.Items.Add("15 meses");
      cmb_periodo.Items.Add("18 meses");
      cmb_periodo.Items.Add("21 meses");
      cmb_periodo.Items.Add("24 meses");

      cmb_periodo.SelectedIndex = 0;
    }

    private void date_picker_ValueChanged(object sender, EventArgs e) {
      var datePicker = (DateTimePicker) sender;
      txt_fecha.Text = datePicker.Value.ToString("dd/MM/yyyy");
      date_picker.MinDate = DateTime.Today;
      // Cargar la fecha de hoy por defecto
      date_picker.Value = DateTime.Today;


      // Validar contra la fecha de hoy (sin hora)
      if(datePicker.Value.Date < DateTime.Today) {
        lbl_error_fecha.Text = "La fecha no puede ser anterior al día de hoy.";
        lbl_error_fecha.Visible = true; 
      } else {
        lbl_error_fecha.Visible = false;
      }
    }
  }
}
