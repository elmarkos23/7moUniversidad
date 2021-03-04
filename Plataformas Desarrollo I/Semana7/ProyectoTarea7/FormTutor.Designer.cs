
namespace ProyectoTarea7
{
  partial class FormTutor
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
      this.cmbDisponibilidad = new System.Windows.Forms.ComboBox();
      this.cmbFacultad = new System.Windows.Forms.ComboBox();
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
      this.btnGuardar.Location = new System.Drawing.Point(668, 135);
      this.btnGuardar.Name = "btnGuardar";
      this.btnGuardar.Size = new System.Drawing.Size(103, 35);
      this.btnGuardar.TabIndex = 23;
      this.btnGuardar.Text = "Guardar";
      this.btnGuardar.UseVisualStyleBackColor = false;
      this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(375, 73);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(100, 15);
      this.label5.TabIndex = 22;
      this.label5.Text = "Disponibilidad";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(416, 41);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(64, 15);
      this.label4.TabIndex = 21;
      this.label4.Text = "Facultad";
      // 
      // cmbDisponibilidad
      // 
      this.cmbDisponibilidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cmbDisponibilidad.FormattingEnabled = true;
      this.cmbDisponibilidad.Items.AddRange(new object[] {
            "Presencial",
            "Virtual"});
      this.cmbDisponibilidad.Location = new System.Drawing.Point(481, 70);
      this.cmbDisponibilidad.Name = "cmbDisponibilidad";
      this.cmbDisponibilidad.Size = new System.Drawing.Size(290, 23);
      this.cmbDisponibilidad.TabIndex = 20;
      // 
      // cmbFacultad
      // 
      this.cmbFacultad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cmbFacultad.FormattingEnabled = true;
      this.cmbFacultad.Items.AddRange(new object[] {
            "Ingenierias",
            "Licenciaturas"});
      this.cmbFacultad.Location = new System.Drawing.Point(481, 38);
      this.cmbFacultad.Name = "cmbFacultad";
      this.cmbFacultad.Size = new System.Drawing.Size(290, 23);
      this.cmbFacultad.TabIndex = 19;
      // 
      // dgvDatos
      // 
      this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgvDatos.Location = new System.Drawing.Point(27, 176);
      this.dgvDatos.Name = "dgvDatos";
      dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
      this.dgvDatos.RowsDefaultCellStyle = dataGridViewCellStyle1;
      this.dgvDatos.Size = new System.Drawing.Size(744, 165);
      this.dgvDatos.TabIndex = 18;
      // 
      // txtApellidos
      // 
      this.txtApellidos.Location = new System.Drawing.Point(126, 103);
      this.txtApellidos.Name = "txtApellidos";
      this.txtApellidos.Size = new System.Drawing.Size(219, 23);
      this.txtApellidos.TabIndex = 17;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(24, 106);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(67, 15);
      this.label3.TabIndex = 16;
      this.label3.Text = "Apellidos";
      // 
      // txtNombres
      // 
      this.txtNombres.Location = new System.Drawing.Point(126, 67);
      this.txtNombres.Name = "txtNombres";
      this.txtNombres.Size = new System.Drawing.Size(219, 23);
      this.txtNombres.TabIndex = 15;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(24, 70);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(66, 15);
      this.label2.TabIndex = 14;
      this.label2.Text = "Nombres";
      // 
      // txtIdentificacion
      // 
      this.txtIdentificacion.Location = new System.Drawing.Point(126, 35);
      this.txtIdentificacion.Name = "txtIdentificacion";
      this.txtIdentificacion.Size = new System.Drawing.Size(219, 23);
      this.txtIdentificacion.TabIndex = 13;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(24, 38);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(96, 15);
      this.label1.TabIndex = 12;
      this.label1.Text = "Identificación";
      // 
      // FormTutor
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(783, 376);
      this.Controls.Add(this.btnGuardar);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.cmbDisponibilidad);
      this.Controls.Add(this.cmbFacultad);
      this.Controls.Add(this.dgvDatos);
      this.Controls.Add(this.txtApellidos);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.txtNombres);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.txtIdentificacion);
      this.Controls.Add(this.label1);
      this.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
      this.Name = "FormTutor";
      this.Text = "FormTutor";
      this.Load += new System.EventHandler(this.FormTutor_Load);
      ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button btnGuardar;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.ComboBox cmbDisponibilidad;
    private System.Windows.Forms.ComboBox cmbFacultad;
    private System.Windows.Forms.DataGridView dgvDatos;
    private System.Windows.Forms.TextBox txtApellidos;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox txtNombres;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox txtIdentificacion;
    private System.Windows.Forms.Label label1;
  }
}