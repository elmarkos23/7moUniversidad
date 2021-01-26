
namespace ProyectoTarea6
{
  partial class FormEstudiantes
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
      this.txtNombres = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.button1 = new System.Windows.Forms.Button();
      this.label2 = new System.Windows.Forms.Label();
      this.txtApelidos = new System.Windows.Forms.TextBox();
      this.cmbTipoEstudiante = new System.Windows.Forms.ComboBox();
      this.label3 = new System.Windows.Forms.Label();
      this.button2 = new System.Windows.Forms.Button();
      this.label4 = new System.Windows.Forms.Label();
      this.txtIdentificacion = new System.Windows.Forms.TextBox();
      this.SuspendLayout();
      // 
      // txtNombres
      // 
      this.txtNombres.Location = new System.Drawing.Point(170, 60);
      this.txtNombres.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.txtNombres.Name = "txtNombres";
      this.txtNombres.Size = new System.Drawing.Size(388, 27);
      this.txtNombres.TabIndex = 0;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(14, 60);
      this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(79, 21);
      this.label1.TabIndex = 1;
      this.label1.Text = "Nombres";
      // 
      // button1
      // 
      this.button1.BackColor = System.Drawing.Color.White;
      this.button1.Location = new System.Drawing.Point(434, 196);
      this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(124, 37);
      this.button1.TabIndex = 2;
      this.button1.Text = "Grabar";
      this.button1.UseVisualStyleBackColor = false;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(14, 98);
      this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(80, 21);
      this.label2.TabIndex = 4;
      this.label2.Text = "Apellidos";
      // 
      // txtApelidos
      // 
      this.txtApelidos.Location = new System.Drawing.Point(170, 98);
      this.txtApelidos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.txtApelidos.Name = "txtApelidos";
      this.txtApelidos.Size = new System.Drawing.Size(388, 27);
      this.txtApelidos.TabIndex = 3;
      // 
      // cmbTipoEstudiante
      // 
      this.cmbTipoEstudiante.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cmbTipoEstudiante.FormattingEnabled = true;
      this.cmbTipoEstudiante.Items.AddRange(new object[] {
            "Ayudante",
            "Becario"});
      this.cmbTipoEstudiante.Location = new System.Drawing.Point(170, 135);
      this.cmbTipoEstudiante.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.cmbTipoEstudiante.Name = "cmbTipoEstudiante";
      this.cmbTipoEstudiante.Size = new System.Drawing.Size(388, 29);
      this.cmbTipoEstudiante.TabIndex = 5;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(14, 135);
      this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(130, 21);
      this.label3.TabIndex = 6;
      this.label3.Text = "Tipo Estudiante";
      // 
      // button2
      // 
      this.button2.BackColor = System.Drawing.Color.White;
      this.button2.Location = new System.Drawing.Point(302, 196);
      this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.button2.Name = "button2";
      this.button2.Size = new System.Drawing.Size(124, 37);
      this.button2.TabIndex = 9;
      this.button2.Text = "Limpiar";
      this.button2.UseVisualStyleBackColor = false;
      this.button2.Click += new System.EventHandler(this.button2_Click);
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(14, 23);
      this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(118, 21);
      this.label4.TabIndex = 11;
      this.label4.Text = "Identificación";
      // 
      // txtIdentificacion
      // 
      this.txtIdentificacion.Location = new System.Drawing.Point(170, 23);
      this.txtIdentificacion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.txtIdentificacion.Name = "txtIdentificacion";
      this.txtIdentificacion.Size = new System.Drawing.Size(388, 27);
      this.txtIdentificacion.TabIndex = 10;
      // 
      // FormEstudiantes
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.SkyBlue;
      this.ClientSize = new System.Drawing.Size(579, 238);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.txtIdentificacion);
      this.Controls.Add(this.button2);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.cmbTipoEstudiante);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.txtApelidos);
      this.Controls.Add(this.button1);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.txtNombres);
      this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.Name = "FormEstudiantes";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Estudiantes";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox txtNombres;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox txtApelidos;
    private System.Windows.Forms.ComboBox cmbTipoEstudiante;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Button button2;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.TextBox txtIdentificacion;
  }
}