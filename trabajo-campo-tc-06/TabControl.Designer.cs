namespace trabajo_campo_tc_06 {
  partial class tb_control {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
      if(disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
      tb_control_1 = new TabControl();
      tabPage1 = new TabPage();
      btn_ordenar = new Button();
      lst_clientes = new ListBox();
      cmb_ordenar = new ComboBox();
      lbl_error_fecha = new Label();
      label14 = new Label();
      label13 = new Label();
      txt_fecha = new TextBox();
      label12 = new Label();
      label11 = new Label();
      label10 = new Label();
      label9 = new Label();
      label8 = new Label();
      label7 = new Label();
      label1 = new Label();
      date_picker = new DateTimePicker();
      rtb_tasa_media = new RadioButton();
      rtb_tasa_alta = new RadioButton();
      rtb_tasa_baja = new RadioButton();
      cmb_periodo = new ComboBox();
      txt_dni = new TextBox();
      txt_monto = new TextBox();
      lbl_mensaje = new TextBox();
      txt_nombre = new TextBox();
      btn_register = new Button();
      tabPage2 = new TabPage();
      lbl_resultado_busqueda = new Label();
      lbl_tasa_aplicada = new Label();
      lbl_monto_total = new Label();
      lst_cronograma = new ListBox();
      txt_buscar_dni = new TextBox();
      btn_buscar = new Button();
      label6 = new Label();
      tb_control_1.SuspendLayout();
      tabPage1.SuspendLayout();
      tabPage2.SuspendLayout();
      SuspendLayout();
      // 
      // tb_control_1
      // 
      tb_control_1.Appearance = TabAppearance.Buttons;
      tb_control_1.Controls.Add(tabPage1);
      tb_control_1.Controls.Add(tabPage2);
      tb_control_1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point,  0);
      tb_control_1.ImeMode = ImeMode.Katakana;
      tb_control_1.Location = new Point(35, 1);
      tb_control_1.Name = "tb_control_1";
      tb_control_1.SelectedIndex = 0;
      tb_control_1.Size = new Size(992, 772);
      tb_control_1.TabIndex = 0;
      // 
      // tabPage1
      // 
      tabPage1.BackColor = Color.LightGray;
      tabPage1.Controls.Add(btn_ordenar);
      tabPage1.Controls.Add(lst_clientes);
      tabPage1.Controls.Add(cmb_ordenar);
      tabPage1.Controls.Add(lbl_error_fecha);
      tabPage1.Controls.Add(label14);
      tabPage1.Controls.Add(label13);
      tabPage1.Controls.Add(txt_fecha);
      tabPage1.Controls.Add(label12);
      tabPage1.Controls.Add(label11);
      tabPage1.Controls.Add(label10);
      tabPage1.Controls.Add(label9);
      tabPage1.Controls.Add(label8);
      tabPage1.Controls.Add(label7);
      tabPage1.Controls.Add(label1);
      tabPage1.Controls.Add(date_picker);
      tabPage1.Controls.Add(rtb_tasa_media);
      tabPage1.Controls.Add(rtb_tasa_alta);
      tabPage1.Controls.Add(rtb_tasa_baja);
      tabPage1.Controls.Add(cmb_periodo);
      tabPage1.Controls.Add(txt_dni);
      tabPage1.Controls.Add(txt_monto);
      tabPage1.Controls.Add(lbl_mensaje);
      tabPage1.Controls.Add(txt_nombre);
      tabPage1.Controls.Add(btn_register);
      tabPage1.ForeColor = SystemColors.ControlText;
      tabPage1.Location = new Point(4, 33);
      tabPage1.Name = "tabPage1";
      tabPage1.Padding = new Padding(3);
      tabPage1.Size = new Size(984, 735);
      tabPage1.TabIndex = 0;
      tabPage1.Text = "Registro préstamo";
      // 
      // btn_ordenar
      // 
      btn_ordenar.BackColor = Color.Navy;
      btn_ordenar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point,  0);
      btn_ordenar.ForeColor = SystemColors.ButtonHighlight;
      btn_ordenar.Location = new Point(571, 434);
      btn_ordenar.Name = "btn_ordenar";
      btn_ordenar.Size = new Size(365, 48);
      btn_ordenar.TabIndex = 35;
      btn_ordenar.Text = "Ordenar";
      btn_ordenar.UseVisualStyleBackColor = false;
      btn_ordenar.Click += btn_ordenar_Click;
      // 
      // lst_clientes
      // 
      lst_clientes.FormattingEnabled = true;
      lst_clientes.ItemHeight = 21;
      lst_clientes.Location = new Point(197, 571);
      lst_clientes.Name = "lst_clientes";
      lst_clientes.Size = new Size(739, 130);
      lst_clientes.TabIndex = 34;
      // 
      // cmb_ordenar
      // 
      cmb_ordenar.FormattingEnabled = true;
      cmb_ordenar.Location = new Point(206, 445);
      cmb_ordenar.Name = "cmb_ordenar";
      cmb_ordenar.Size = new Size(347, 29);
      cmb_ordenar.TabIndex = 33;
      // 
      // lbl_error_fecha
      // 
      lbl_error_fecha.AutoSize = true;
      lbl_error_fecha.ForeColor = Color.Red;
      lbl_error_fecha.ImageAlign = ContentAlignment.BottomCenter;
      lbl_error_fecha.Location = new Point(589, 93);
      lbl_error_fecha.Name = "lbl_error_fecha";
      lbl_error_fecha.Size = new Size(0, 21);
      lbl_error_fecha.TabIndex = 32;
      // 
      // label14
      // 
      label14.AutoSize = true;
      label14.Location = new Point(90, 582);
      label14.Name = "label14";
      label14.Size = new Size(63, 21);
      label14.TabIndex = 31;
      label14.Text = "Listado";
      // 
      // label13
      // 
      label13.AutoSize = true;
      label13.Location = new Point(109, 328);
      label13.Name = "label13";
      label13.Size = new Size(52, 21);
      label13.TabIndex = 30;
      label13.Text = "Fecha";
      // 
      // txt_fecha
      // 
      txt_fecha.BackColor = Color.Gainsboro;
      txt_fecha.Location = new Point(203, 320);
      txt_fecha.Name = "txt_fecha";
      txt_fecha.ReadOnly = true;
      txt_fecha.Size = new Size(350, 29);
      txt_fecha.TabIndex = 29;
      // 
      // label12
      // 
      label12.AutoSize = true;
      label12.Location = new Point(141, 111);
      label12.Name = "label12";
      label12.Size = new Size(38, 21);
      label12.TabIndex = 28;
      label12.Text = "DNI";
      // 
      // label11
      // 
      label11.AutoSize = true;
      label11.Location = new Point(45, 165);
      label11.Name = "label11";
      label11.Size = new Size(134, 21);
      label11.TabIndex = 27;
      label11.Text = "Monto préstamo";
      // 
      // label10
      // 
      label10.AutoSize = true;
      label10.Location = new Point(94, 511);
      label10.Name = "label10";
      label10.Size = new Size(71, 21);
      label10.TabIndex = 26;
      label10.Text = "Mensaje";
      // 
      // label9
      // 
      label9.AutoSize = true;
      label9.Location = new Point(94, 453);
      label9.Name = "label9";
      label9.Size = new Size(70, 21);
      label9.TabIndex = 25;
      label9.Text = "Ordenar";
      // 
      // label8
      // 
      label8.AutoSize = true;
      label8.Location = new Point(94, 218);
      label8.Name = "label8";
      label8.Size = new Size(67, 21);
      label8.TabIndex = 24;
      label8.Text = "Periodo";
      // 
      // label7
      // 
      label7.AutoSize = true;
      label7.Location = new Point(94, 269);
      label7.Name = "label7";
      label7.Size = new Size(81, 21);
      label7.TabIndex = 23;
      label7.Text = "Categoría";
      // 
      // label1
      // 
      label1.AutoSize = true;
      label1.Location = new Point(108, 60);
      label1.Name = "label1";
      label1.Size = new Size(71, 21);
      label1.TabIndex = 22;
      label1.Text = "Nombre";
      // 
      // date_picker
      // 
      date_picker.Location = new Point(571, 322);
      date_picker.Name = "date_picker";
      date_picker.Size = new Size(347, 29);
      date_picker.TabIndex = 6;
      date_picker.ValueChanged += date_picker_ValueChanged;
      // 
      // rtb_tasa_media
      // 
      rtb_tasa_media.AutoSize = true;
      rtb_tasa_media.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point,  0);
      rtb_tasa_media.Location = new Point(312, 265);
      rtb_tasa_media.Name = "rtb_tasa_media";
      rtb_tasa_media.Size = new Size(74, 25);
      rtb_tasa_media.TabIndex = 20;
      rtb_tasa_media.TabStop = true;
      rtb_tasa_media.Text = "Media";
      rtb_tasa_media.UseVisualStyleBackColor = true;
      // 
      // rtb_tasa_alta
      // 
      rtb_tasa_alta.AutoSize = true;
      rtb_tasa_alta.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point,  0);
      rtb_tasa_alta.Location = new Point(485, 265);
      rtb_tasa_alta.Name = "rtb_tasa_alta";
      rtb_tasa_alta.Size = new Size(57, 25);
      rtb_tasa_alta.TabIndex = 19;
      rtb_tasa_alta.TabStop = true;
      rtb_tasa_alta.Text = "Alta";
      rtb_tasa_alta.UseVisualStyleBackColor = true;
      // 
      // rtb_tasa_baja
      // 
      rtb_tasa_baja.AutoSize = true;
      rtb_tasa_baja.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point,  0);
      rtb_tasa_baja.Location = new Point(203, 265);
      rtb_tasa_baja.Name = "rtb_tasa_baja";
      rtb_tasa_baja.Size = new Size(58, 25);
      rtb_tasa_baja.TabIndex = 5;
      rtb_tasa_baja.TabStop = true;
      rtb_tasa_baja.Text = "Baja";
      rtb_tasa_baja.UseVisualStyleBackColor = true;
      // 
      // cmb_periodo
      // 
      cmb_periodo.FormattingEnabled = true;
      cmb_periodo.Location = new Point(206, 210);
      cmb_periodo.Name = "cmb_periodo";
      cmb_periodo.Size = new Size(347, 29);
      cmb_periodo.TabIndex = 4;
      // 
      // txt_dni
      // 
      txt_dni.Location = new Point(203, 103);
      txt_dni.MaxLength = 6;
      txt_dni.Name = "txt_dni";
      txt_dni.Size = new Size(350, 29);
      txt_dni.TabIndex = 2;
      // 
      // txt_monto
      // 
      txt_monto.Location = new Point(203, 157);
      txt_monto.Name = "txt_monto";
      txt_monto.Size = new Size(350, 29);
      txt_monto.TabIndex = 3;
      // 
      // lbl_mensaje
      // 
      lbl_mensaje.BackColor = Color.FromArgb(  224,   224,   224);
      lbl_mensaje.ForeColor = Color.Navy;
      lbl_mensaje.Location = new Point(203, 508);
      lbl_mensaje.Multiline = true;
      lbl_mensaje.Name = "lbl_mensaje";
      lbl_mensaje.ReadOnly = true;
      lbl_mensaje.Size = new Size(733, 29);
      lbl_mensaje.TabIndex = 15;
      // 
      // txt_nombre
      // 
      txt_nombre.Location = new Point(203, 52);
      txt_nombre.Name = "txt_nombre";
      txt_nombre.Size = new Size(350, 29);
      txt_nombre.TabIndex = 0;
      // 
      // btn_register
      // 
      btn_register.BackColor = Color.ForestGreen;
      btn_register.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point,  0);
      btn_register.Location = new Point(206, 371);
      btn_register.Name = "btn_register";
      btn_register.Size = new Size(347, 48);
      btn_register.TabIndex = 7;
      btn_register.Text = "Registrar";
      btn_register.UseVisualStyleBackColor = false;
      btn_register.Click += btn_register_Click;
      // 
      // tabPage2
      // 
      tabPage2.BackColor = Color.FromArgb(  192,   255,   192);
      tabPage2.Controls.Add(lbl_resultado_busqueda);
      tabPage2.Controls.Add(lbl_tasa_aplicada);
      tabPage2.Controls.Add(lbl_monto_total);
      tabPage2.Controls.Add(lst_cronograma);
      tabPage2.Controls.Add(txt_buscar_dni);
      tabPage2.Controls.Add(btn_buscar);
      tabPage2.Controls.Add(label6);
      tabPage2.Location = new Point(4, 33);
      tabPage2.Name = "tabPage2";
      tabPage2.Padding = new Padding(3);
      tabPage2.Size = new Size(984, 735);
      tabPage2.TabIndex = 1;
      tabPage2.Text = "Búsqueda cliente";
      // 
      // lbl_resultado_busqueda
      // 
      lbl_resultado_busqueda.AutoSize = true;
      lbl_resultado_busqueda.Location = new Point(179, 314);
      lbl_resultado_busqueda.Name = "lbl_resultado_busqueda";
      lbl_resultado_busqueda.Size = new Size(0, 21);
      lbl_resultado_busqueda.TabIndex = 20;
      // 
      // lbl_tasa_aplicada
      // 
      lbl_tasa_aplicada.AutoSize = true;
      lbl_tasa_aplicada.Location = new Point(178, 269);
      lbl_tasa_aplicada.Name = "lbl_tasa_aplicada";
      lbl_tasa_aplicada.Size = new Size(0, 21);
      lbl_tasa_aplicada.TabIndex = 19;
      // 
      // lbl_monto_total
      // 
      lbl_monto_total.AutoSize = true;
      lbl_monto_total.Location = new Point(178, 233);
      lbl_monto_total.Name = "lbl_monto_total";
      lbl_monto_total.Size = new Size(0, 21);
      lbl_monto_total.TabIndex = 18;
      // 
      // lst_cronograma
      // 
      lst_cronograma.FormattingEnabled = true;
      lst_cronograma.ItemHeight = 21;
      lst_cronograma.Location = new Point(178, 75);
      lst_cronograma.Name = "lst_cronograma";
      lst_cronograma.Size = new Size(495, 151);
      lst_cronograma.TabIndex = 17;
      // 
      // txt_buscar_dni
      // 
      txt_buscar_dni.Location = new Point(179, 23);
      txt_buscar_dni.MaxLength = 6;
      txt_buscar_dni.Name = "txt_buscar_dni";
      txt_buscar_dni.Size = new Size(226, 29);
      txt_buscar_dni.TabIndex = 0;
      // 
      // btn_buscar
      // 
      btn_buscar.BackColor = Color.Teal;
      btn_buscar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point,  0);
      btn_buscar.ForeColor = SystemColors.ButtonFace;
      btn_buscar.Location = new Point(462, 19);
      btn_buscar.Name = "btn_buscar";
      btn_buscar.Size = new Size(211, 34);
      btn_buscar.TabIndex = 2;
      btn_buscar.Text = "Buscar cliente";
      btn_buscar.UseVisualStyleBackColor = false;
      btn_buscar.Click += btn_buscar_Click;
      // 
      // label6
      // 
      label6.AutoSize = true;
      label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point,  0);
      label6.Location = new Point(37, 31);
      label6.Name = "label6";
      label6.Size = new Size(120, 21);
      label6.TabIndex = 10;
      label6.Text = "Buscar por DNI";
      // 
      // tb_control
      // 
      AutoScaleDimensions = new SizeF(7F, 15F);
      AutoScaleMode = AutoScaleMode.Font;
      BackColor = Color.FromArgb(  192,   192,   255);
      ClientSize = new Size(1077, 785);
      Controls.Add(tb_control_1);
      Name = "tb_control";
      Text = "Tab Control TC-06";
      tb_control_1.ResumeLayout(false);
      tabPage1.ResumeLayout(false);
      tabPage1.PerformLayout();
      tabPage2.ResumeLayout(false);
      tabPage2.PerformLayout();
      ResumeLayout(false);
    }

    #endregion

    private TabControl tb_control_1;
    private TabPage tabPage2;
    private Label label6;
    private TabPage tabPage1;
    private DateTimePicker date_picker;
    private RadioButton rtb_tasa_media;
    private RadioButton rtb_tasa_alta;
    private RadioButton rtb_tasa_baja;
    private ComboBox cmb_periodo;
    private TextBox txt_dni;
    private TextBox txt_monto;
    private TextBox lbl_mensaje;
    private TextBox txt_nombre;
    private Button btn_register;
    private Label label1;
    private Label label13;
    private TextBox txt_fecha;
    private Label label12;
    private Label label11;
    private Label label10;
    private Label label9;
    private Label label8;
    private Label label7;
    private Label label14;
    private Label lbl_error_fecha;
    private ComboBox cmb_ordenar;
    private ListBox lst_clientes;
    private Button btn_buscar;
    private TextBox txt_buscar_dni;
    private ListBox lst_cronograma;
    private Label lbl_monto_total;
    private Label lbl_tasa_aplicada;
    private Label lbl_resultado_busqueda;
    private Button btn_ordenar;
  }
}