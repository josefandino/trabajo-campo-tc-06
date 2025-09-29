namespace trabajo_campo_tc_06 {
  partial class CalculoIngresos {
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
      lbl_calculadora = new Label();
      label1 = new Label();
      label2 = new Label();
      label3 = new Label();
      txt_nombre = new TextBox();
      txt_salario_mensual = new TextBox();
      txt_apellido = new TextBox();
      btn_procesar = new Button();
      lst_calculo = new ListBox();
      lbl_mensaje = new Label();
      btn_longitud = new Button();
      btn_conversion = new Button();
      btn_indice = new Button();
      btn_substring = new Button();
      btn_index_of = new Button();
      btn_replace = new Button();
      lst_resultados = new ListBox();
      cmb_ordenar = new ComboBox();
      btn_ordenar = new Button();
      btn_split = new Button();
      btn_buscar = new Button();
      txt_buscar = new TextBox();
      SuspendLayout();
      // 
      // lbl_calculadora
      // 
      lbl_calculadora.AutoSize = true;
      lbl_calculadora.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
      lbl_calculadora.ForeColor = Color.Navy;
      lbl_calculadora.Location = new Point(233, 33);
      lbl_calculadora.Name = "lbl_calculadora";
      lbl_calculadora.Size = new Size(288, 32);
      lbl_calculadora.TabIndex = 0;
      lbl_calculadora.Text = "Calculadora de ingresos";
      // 
      // label1
      // 
      label1.AutoSize = true;
      label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point,  0);
      label1.Location = new Point(77, 83);
      label1.Name = "label1";
      label1.Size = new Size(71, 21);
      label1.TabIndex = 10;
      label1.Text = "Nombre";
      // 
      // label2
      // 
      label2.AutoSize = true;
      label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point,  0);
      label2.Location = new Point(77, 145);
      label2.Name = "label2";
      label2.Size = new Size(79, 21);
      label2.TabIndex = 11;
      label2.Text = "Apellidos";
      // 
      // label3
      // 
      label3.AutoSize = true;
      label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point,  0);
      label3.Location = new Point(77, 207);
      label3.Name = "label3";
      label3.Size = new Size(123, 21);
      label3.TabIndex = 12;
      label3.Text = "Salario mensual";
      // 
      // txt_nombre
      // 
      txt_nombre.Location = new Point(77, 109);
      txt_nombre.MaxLength = 20;
      txt_nombre.Name = "txt_nombre";
      txt_nombre.Size = new Size(278, 23);
      txt_nombre.TabIndex = 0;
      // 
      // txt_salario_mensual
      // 
      txt_salario_mensual.Location = new Point(77, 233);
      txt_salario_mensual.MaxLength = 20;
      txt_salario_mensual.Name = "txt_salario_mensual";
      txt_salario_mensual.Size = new Size(278, 23);
      txt_salario_mensual.TabIndex = 2;
      // 
      // txt_apellido
      // 
      txt_apellido.Location = new Point(77, 171);
      txt_apellido.MaxLength = 20;
      txt_apellido.Name = "txt_apellido";
      txt_apellido.Size = new Size(278, 23);
      txt_apellido.TabIndex = 1;
      // 
      // btn_procesar
      // 
      btn_procesar.BackColor = Color.FromArgb(  0,   0,   192);
      btn_procesar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point,  0);
      btn_procesar.ForeColor = SystemColors.ButtonFace;
      btn_procesar.Location = new Point(70, 277);
      btn_procesar.Name = "btn_procesar";
      btn_procesar.Size = new Size(285, 39);
      btn_procesar.TabIndex = 3;
      btn_procesar.Text = "Procesar";
      btn_procesar.UseVisualStyleBackColor = false;
      btn_procesar.Click += btn_procesar_Click;
      // 
      // lst_calculo
      // 
      lst_calculo.FormattingEnabled = true;
      lst_calculo.ItemHeight = 15;
      lst_calculo.Location = new Point(70, 350);
      lst_calculo.Name = "lst_calculo";
      lst_calculo.Size = new Size(285, 124);
      lst_calculo.TabIndex = 35;
      // 
      // lbl_mensaje
      // 
      lbl_mensaje.AutoSize = true;
      lbl_mensaje.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point,  0);
      lbl_mensaje.ForeColor = Color.FromArgb(  192,   0,   0);
      lbl_mensaje.Location = new Point(70, 319);
      lbl_mensaje.Name = "lbl_mensaje";
      lbl_mensaje.Size = new Size(0, 21);
      lbl_mensaje.TabIndex = 36;
      // 
      // btn_longitud
      // 
      btn_longitud.BackColor = Color.Purple;
      btn_longitud.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point,  0);
      btn_longitud.ForeColor = SystemColors.ButtonFace;
      btn_longitud.Location = new Point(446, 93);
      btn_longitud.Name = "btn_longitud";
      btn_longitud.Size = new Size(285, 39);
      btn_longitud.TabIndex = 37;
      btn_longitud.Text = "Longitud nombre y apellido";
      btn_longitud.UseVisualStyleBackColor = false;
      btn_longitud.Click += btn_longitud_Click;
      // 
      // btn_conversion
      // 
      btn_conversion.BackColor = Color.Purple;
      btn_conversion.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point,  0);
      btn_conversion.ForeColor = SystemColors.ButtonFace;
      btn_conversion.Location = new Point(446, 139);
      btn_conversion.Name = "btn_conversion";
      btn_conversion.Size = new Size(130, 39);
      btn_conversion.TabIndex = 38;
      btn_conversion.Text = "Conversión";
      btn_conversion.UseVisualStyleBackColor = false;
      btn_conversion.Click += btn_conversion_Click;
      // 
      // btn_indice
      // 
      btn_indice.BackColor = Color.Purple;
      btn_indice.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point,  0);
      btn_indice.ForeColor = SystemColors.ButtonFace;
      btn_indice.Location = new Point(446, 185);
      btn_indice.Name = "btn_indice";
      btn_indice.Size = new Size(130, 39);
      btn_indice.TabIndex = 39;
      btn_indice.Text = "Por índice";
      btn_indice.UseVisualStyleBackColor = false;
      btn_indice.Click += btn_indice_Click;
      // 
      // btn_substring
      // 
      btn_substring.BackColor = Color.Purple;
      btn_substring.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point,  0);
      btn_substring.ForeColor = SystemColors.ButtonFace;
      btn_substring.Location = new Point(582, 185);
      btn_substring.Name = "btn_substring";
      btn_substring.Size = new Size(149, 39);
      btn_substring.TabIndex = 40;
      btn_substring.Text = "Substring";
      btn_substring.UseVisualStyleBackColor = false;
      btn_substring.Click += btn_substring_Click;
      // 
      // btn_index_of
      // 
      btn_index_of.BackColor = Color.Purple;
      btn_index_of.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point,  0);
      btn_index_of.ForeColor = SystemColors.ButtonFace;
      btn_index_of.Location = new Point(446, 231);
      btn_index_of.Name = "btn_index_of";
      btn_index_of.Size = new Size(130, 39);
      btn_index_of.TabIndex = 41;
      btn_index_of.Text = "IndexOf";
      btn_index_of.UseVisualStyleBackColor = false;
      btn_index_of.Click += btn_index_of_Click;
      // 
      // btn_replace
      // 
      btn_replace.BackColor = Color.Purple;
      btn_replace.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point,  0);
      btn_replace.ForeColor = SystemColors.ButtonFace;
      btn_replace.Location = new Point(582, 231);
      btn_replace.Name = "btn_replace";
      btn_replace.Size = new Size(149, 39);
      btn_replace.TabIndex = 42;
      btn_replace.Text = "Replace";
      btn_replace.UseVisualStyleBackColor = false;
      btn_replace.Click += btn_replace_Click;
      // 
      // lst_resultados
      // 
      lst_resultados.FormattingEnabled = true;
      lst_resultados.ItemHeight = 15;
      lst_resultados.Location = new Point(380, 379);
      lst_resultados.Name = "lst_resultados";
      lst_resultados.Size = new Size(351, 94);
      lst_resultados.TabIndex = 43;
      // 
      // cmb_ordenar
      // 
      cmb_ordenar.FormattingEnabled = true;
      cmb_ordenar.Location = new Point(446, 286);
      cmb_ordenar.Name = "cmb_ordenar";
      cmb_ordenar.Size = new Size(168, 23);
      cmb_ordenar.TabIndex = 44;
      // 
      // btn_ordenar
      // 
      btn_ordenar.BackColor = Color.Purple;
      btn_ordenar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point,  0);
      btn_ordenar.ForeColor = SystemColors.ButtonFace;
      btn_ordenar.Location = new Point(620, 277);
      btn_ordenar.Name = "btn_ordenar";
      btn_ordenar.Size = new Size(111, 39);
      btn_ordenar.TabIndex = 45;
      btn_ordenar.Text = "Ordenar";
      btn_ordenar.UseVisualStyleBackColor = false;
      btn_ordenar.Click += btn_ordenar_Click;
      // 
      // btn_split
      // 
      btn_split.BackColor = Color.Purple;
      btn_split.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point,  0);
      btn_split.ForeColor = SystemColors.ButtonFace;
      btn_split.Location = new Point(582, 139);
      btn_split.Name = "btn_split";
      btn_split.Size = new Size(149, 39);
      btn_split.TabIndex = 46;
      btn_split.Text = "Split";
      btn_split.UseVisualStyleBackColor = false;
      btn_split.Click += btn_split_Click;
      // 
      // btn_buscar
      // 
      btn_buscar.BackColor = Color.Purple;
      btn_buscar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point,  0);
      btn_buscar.ForeColor = SystemColors.ButtonFace;
      btn_buscar.Location = new Point(620, 323);
      btn_buscar.Name = "btn_buscar";
      btn_buscar.Size = new Size(111, 39);
      btn_buscar.TabIndex = 47;
      btn_buscar.Text = "Buscar";
      btn_buscar.UseVisualStyleBackColor = false;
      btn_buscar.Click += btn_buscar_Click;
      // 
      // txt_buscar
      // 
      txt_buscar.Location = new Point(446, 336);
      txt_buscar.MaxLength = 6;
      txt_buscar.Name = "txt_buscar";
      txt_buscar.Size = new Size(168, 23);
      txt_buscar.TabIndex = 48;
      // 
      // CalculoIngresos
      // 
      AutoScaleDimensions = new SizeF(7F, 15F);
      AutoScaleMode = AutoScaleMode.Font;
      BackColor = Color.FromArgb(  192,   192,   255);
      ClientSize = new Size(800, 579);
      Controls.Add(txt_buscar);
      Controls.Add(btn_buscar);
      Controls.Add(btn_split);
      Controls.Add(btn_ordenar);
      Controls.Add(cmb_ordenar);
      Controls.Add(lst_resultados);
      Controls.Add(btn_replace);
      Controls.Add(btn_index_of);
      Controls.Add(btn_substring);
      Controls.Add(btn_indice);
      Controls.Add(btn_conversion);
      Controls.Add(btn_longitud);
      Controls.Add(lbl_mensaje);
      Controls.Add(lst_calculo);
      Controls.Add(btn_procesar);
      Controls.Add(txt_apellido);
      Controls.Add(txt_salario_mensual);
      Controls.Add(txt_nombre);
      Controls.Add(label3);
      Controls.Add(label2);
      Controls.Add(label1);
      Controls.Add(lbl_calculadora);
      Name = "CalculoIngresos";
      Text = "Cálculo ingresos personales";
      ResumeLayout(false);
      PerformLayout();
    }

    #endregion

    private Label lbl_calculadora;
    private Label label1;
    private Label label2;
    private Label label3;
    private TextBox txt_nombre;
    private TextBox txt_salario_mensual;
    private TextBox txt_apellido;
    private Button btn_procesar;
    private ListBox lst_calculo;
    private Label lbl_mensaje;
    private Button btn_longitud;
    private Button btn_conversion;
    private Button btn_indice;
    private Button btn_substring;
    private Button btn_index_of;
    private Button btn_replace;
    private ListBox lst_resultados;
    private ComboBox cmb_ordenar;
    private Button btn_ordenar;
    private Button btn_split;
    private Button btn_buscar;
    private TextBox txt_buscar;
  }
}