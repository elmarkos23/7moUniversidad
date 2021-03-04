
namespace ProyectoTarea7
{
  partial class FormEstudiante
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
      this.btnGuardar = new System.Windows.Forms.Button();
      this.label5 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.cmbNivel = new System.Windows.Forms.ComboBox();
      this.cmbCarrera = new System.Windows.Forms.ComboBox();
      this.dgvDatos = new System.Windows.Forms.DataGridView();
      this.txtApellidos = new System.Windows.Forms.TextBox();
      this.label3 = new System.Windows.Forms.Label();
      this.txtNombres = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.txtIdentificacion = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
      this.SuspendLayout();
      // 
      // btnGuardar
      // 
      this.btnGuardar.BackColor = System.Drawing.Color.Black;
      this.btnGuardar.Location = new System.Drawing.Point(598, 113);
      this.btnGuardar.Name = "btnGuardar";
      this.btnGuardar.Size = new System.Drawing.Size(103, 35);
      this.btnGuardar.TabIndex = 11;
      this.btnGuardar.Text = "Guardar";
      this.btnGuardar.UseVisualStyleBackColor = false;
      this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(361, 48);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(40, 15);
      this.label5.TabIndex = 10;
      this.label5.Text = "Nivel";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(361, 16);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(59, 15);
      this.label4.TabIndex = 9;
      this.label4.Text = "Carrera";
      // 
      // cmbNivel
      // 
      this.cmbNivel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cmbNivel.FormattingEnabled = true;
      this.cmbNivel.Items.AddRange(new object[] {
            "Primero",
            "Segundo",
            "Tercero",
            "Cuarto",
            "Quinto",
            "Sexto",
            "Septimo",
            "Octavo",
            "Noveno"});
      this.cmbNivel.Location = new System.Drawing.Point(434, 45);
      this.cmbNivel.Name = "cmbNivel";
      this.cmbNivel.Size = new System.Drawing.Size(267, 23);
      this.cmbNivel.TabIndex = 8;
      // 
      // cmbCarrera
      // 
      this.cmbCarrera.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cmbCarrera.FormattingEnabled = true;
      this.cmbCarrera.Items.AddRange(new object[] {
            "Ingenieria en Sistema",
            "Ingenieria en Telecomunicaciones",
            "Ingenieria en Administracion de Empresas"});
      this.cmbCarrera.Location = new System.Drawing.Point(434, 13);
      this.cmbCarrera.Name = "cmbCarrera";
      this.cmbCarrera.Size = new System.Drawing.Size(267, 23);
      this.cmbCarrera.TabIndex = 7;
      // 
      // dgvDatos
      // 
      this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgvDatos.GridColor = System.Drawing.Color.Black;
      this.dgvDatos.Location = new System.Drawing.Point(21, 154);
      this.dgvDatos.Name = "dgvDatos";
      dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
      this.dgvDatos.RowsDefaultCellStyle = dataGridViewCellStyle1;
      this.dgvDatos.Size = new System.Drawing.Size(680, 165);
      this.dgvDatos.TabIndex = 6;
      // 
      // txtApellidos
      // 
      this.txtApellidos.Location = new System.Drawing.Point(120, 81);
      this.txtApellidos.Name = "txtApellidos";
      this.txtApellidos.Size = new System.Drawing.Size(219, 23);
      this.txtApellidos.TabIndex = 5;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(18, 84);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(67, 15);
      this.label3.TabIndex = 4;
      this.label3.Text = "Apellidos";
      // 
      // txtNombres
      // 
      this.txtNombres.Location = new System.Drawing.Point(120, 45);
      this.txtNombres.Name = "txtNombres";
      this.txtNombres.Size = new System.Drawing.Size(219, 23);
      this.txtNombres.TabIndex = 3;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(18, 48);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(66, 15);
      this.label2.TabIndex = 2;
      this.label2.Text = "Nombres";
      // 
      // txtIdentificacion
      // 
      this.txtIdentificacion.Location = new System.Drawing.Point(120, 13);
      this.txtIdentificacion.Name = "txtIdentificacion";
      this.txtIdentificacion.Size = new System.Drawing.Size(219, 23);
      this.txtIdentificacion.TabIndex = 1;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(18, 16);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(96, 15);
      this.label1.TabIndex = 0;
      this.label1.Text = "Identificación";
      // 
      // FormEstudiante
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(734, 342);
      this.Controls.Add(this.btnGuardar);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.cmbNivel);
      this.Controls.Add(this.cmbCarrera);
      this.Controls.Add(this.dgvDatos);
      this.Controls.Add(this.txtApellidos);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.txtNombres);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.txtIdentificacion);
      this.Controls.Add(this.label1);
      this.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
      this.Name = "FormEstudiante";
      this.Text = "s";
      this.Load += new System.EventHandler(this.FormEstudiante_Load);
      ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox txtIdentificacion;
    private System.Windows.Forms.TextBox txtNombres;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox txtApellidos;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.DataGridView dgvDatos;
    private System.Windows.Forms.ComboBox cmbCarrera;
    private System.Windows.Forms.ComboBox cmbNivel;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Button btnGuardar;
  }
}