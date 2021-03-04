
namespace ProyectoTarea7
{
  partial class FormActividad
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
      this.label3 = new System.Windows.Forms.Label();
      this.dtpFechaActividad = new System.Windows.Forms.DateTimePicker();
      this.label2 = new System.Windows.Forms.Label();
      this.cmbEstudiante = new System.Windows.Forms.ComboBox();
      this.label1 = new System.Windows.Forms.Label();
      this.cmbTutor = new System.Windows.Forms.ComboBox();
      this.txtDetalles = new System.Windows.Forms.TextBox();
      this.label4 = new System.Windows.Forms.Label();
      this.cmbActividad = new System.Windows.Forms.ComboBox();
      this.label5 = new System.Windows.Forms.Label();
      this.btnGuardar = new System.Windows.Forms.Button();
      this.label6 = new System.Windows.Forms.Label();
      this.cmbEstado = new System.Windows.Forms.ComboBox();
      this.SuspendLayout();
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(27, 85);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(114, 15);
      this.label3.TabIndex = 13;
      this.label3.Text = "Fecha  Actividad";
      // 
      // dtpFechaActividad
      // 
      this.dtpFechaActividad.Location = new System.Drawing.Point(149, 79);
      this.dtpFechaActividad.Name = "dtpFechaActividad";
      this.dtpFechaActividad.Size = new System.Drawing.Size(266, 23);
      this.dtpFechaActividad.TabIndex = 12;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(27, 53);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(77, 15);
      this.label2.TabIndex = 11;
      this.label2.Text = "Estudiante";
      // 
      // cmbEstudiante
      // 
      this.cmbEstudiante.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cmbEstudiante.FormattingEnabled = true;
      this.cmbEstudiante.Location = new System.Drawing.Point(110, 50);
      this.cmbEstudiante.Name = "cmbEstudiante";
      this.cmbEstudiante.Size = new System.Drawing.Size(305, 23);
      this.cmbEstudiante.TabIndex = 10;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(27, 24);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(42, 15);
      this.label1.TabIndex = 9;
      this.label1.Text = "Tutor";
      // 
      // cmbTutor
      // 
      this.cmbTutor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cmbTutor.FormattingEnabled = true;
      this.cmbTutor.Location = new System.Drawing.Point(110, 21);
      this.cmbTutor.Name = "cmbTutor";
      this.cmbTutor.Size = new System.Drawing.Size(305, 23);
      this.cmbTutor.TabIndex = 8;
      this.cmbTutor.SelectedIndexChanged += new System.EventHandler(this.cmbTutor_SelectedIndexChanged);
      // 
      // txtDetalles
      // 
      this.txtDetalles.Location = new System.Drawing.Point(110, 156);
      this.txtDetalles.Multiline = true;
      this.txtDetalles.Name = "txtDetalles";
      this.txtDetalles.Size = new System.Drawing.Size(305, 110);
      this.txtDetalles.TabIndex = 15;
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(27, 130);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(68, 15);
      this.label4.TabIndex = 16;
      this.label4.Text = "Actividad";
      // 
      // cmbActividad
      // 
      this.cmbActividad.FormattingEnabled = true;
      this.cmbActividad.Items.AddRange(new object[] {
            "Documentación",
            "Proyecto",
            "Asesoria"});
      this.cmbActividad.Location = new System.Drawing.Point(110, 127);
      this.cmbActividad.Name = "cmbActividad";
      this.cmbActividad.Size = new System.Drawing.Size(305, 23);
      this.cmbActividad.TabIndex = 17;
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(27, 156);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(61, 15);
      this.label5.TabIndex = 18;
      this.label5.Text = "Detalles";
      // 
      // btnGuardar
      // 
      this.btnGuardar.BackColor = System.Drawing.Color.Black;
      this.btnGuardar.Location = new System.Drawing.Point(309, 311);
      this.btnGuardar.Name = "btnGuardar";
      this.btnGuardar.Size = new System.Drawing.Size(106, 36);
      this.btnGuardar.TabIndex = 19;
      this.btnGuardar.Text = "Guardar";
      this.btnGuardar.UseVisualStyleBackColor = false;
      this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Location = new System.Drawing.Point(27, 275);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(52, 15);
      this.label6.TabIndex = 21;
      this.label6.Text = "Estado";
      // 
      // cmbEstado
      // 
      this.cmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cmbEstado.FormattingEnabled = true;
      this.cmbEstado.Items.AddRange(new object[] {
            "ASIGNADO",
            "TERMINADO"});
      this.cmbEstado.Location = new System.Drawing.Point(110, 272);
      this.cmbEstado.Name = "cmbEstado";
      this.cmbEstado.Size = new System.Drawing.Size(305, 23);
      this.cmbEstado.TabIndex = 20;
      // 
      // FormActividad
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(442, 358);
      this.Controls.Add(this.label6);
      this.Controls.Add(this.cmbEstado);
      this.Controls.Add(this.btnGuardar);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.cmbActividad);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.txtDetalles);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.dtpFechaActividad);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.cmbEstudiante);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.cmbTutor);
      this.Name = "FormActividad";
      this.Text = "FormActividad";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.DateTimePicker dtpFechaActividad;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.ComboBox cmbEstudiante;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.ComboBox cmbTutor;
    private System.Windows.Forms.TextBox txtDetalles;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.ComboBox cmbActividad;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Button btnGuardar;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.ComboBox cmbEstado;
  }
}