
namespace ProyectoTarea7
{
  partial class FormAsignacionEstudiante
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
      this.btnAsignar = new System.Windows.Forms.Button();
      this.cmbTutor = new System.Windows.Forms.ComboBox();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.cmbEstudiante = new System.Windows.Forms.ComboBox();
      this.dataGridView1 = new System.Windows.Forms.DataGridView();
      this.dtpFecha = new System.Windows.Forms.DateTimePicker();
      this.label3 = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
      this.SuspendLayout();
      // 
      // btnAsignar
      // 
      this.btnAsignar.BackColor = System.Drawing.Color.Black;
      this.btnAsignar.Location = new System.Drawing.Point(575, 109);
      this.btnAsignar.Name = "btnAsignar";
      this.btnAsignar.Size = new System.Drawing.Size(111, 29);
      this.btnAsignar.TabIndex = 0;
      this.btnAsignar.Text = "Asignar";
      this.btnAsignar.UseVisualStyleBackColor = false;
      this.btnAsignar.Click += new System.EventHandler(this.btnAsignar_Click);
      // 
      // cmbTutor
      // 
      this.cmbTutor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cmbTutor.FormattingEnabled = true;
      this.cmbTutor.Location = new System.Drawing.Point(109, 19);
      this.cmbTutor.Name = "cmbTutor";
      this.cmbTutor.Size = new System.Drawing.Size(305, 23);
      this.cmbTutor.TabIndex = 1;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(26, 22);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(42, 15);
      this.label1.TabIndex = 2;
      this.label1.Text = "Tutor";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(26, 51);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(77, 15);
      this.label2.TabIndex = 4;
      this.label2.Text = "Estudiante";
      // 
      // cmbEstudiante
      // 
      this.cmbEstudiante.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cmbEstudiante.FormattingEnabled = true;
      this.cmbEstudiante.Location = new System.Drawing.Point(109, 48);
      this.cmbEstudiante.Name = "cmbEstudiante";
      this.cmbEstudiante.Size = new System.Drawing.Size(305, 23);
      this.cmbEstudiante.TabIndex = 3;
      // 
      // dataGridView1
      // 
      this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView1.Location = new System.Drawing.Point(12, 144);
      this.dataGridView1.Name = "dataGridView1";
      dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
      this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle1;
      this.dataGridView1.Size = new System.Drawing.Size(690, 193);
      this.dataGridView1.TabIndex = 5;
      // 
      // dtpFecha
      // 
      this.dtpFecha.Location = new System.Drawing.Point(148, 77);
      this.dtpFecha.Name = "dtpFecha";
      this.dtpFecha.Size = new System.Drawing.Size(266, 23);
      this.dtpFecha.TabIndex = 6;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(26, 83);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(116, 15);
      this.label3.TabIndex = 7;
      this.label3.Text = "Fecha  signación";
      // 
      // FormAsignacionEstudiante
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(714, 349);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.dtpFecha);
      this.Controls.Add(this.dataGridView1);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.cmbEstudiante);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.cmbTutor);
      this.Controls.Add(this.btnAsignar);
      this.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
      this.Name = "FormAsignacionEstudiante";
      this.Text = "FormAsignacionEstudiante";
      this.Load += new System.EventHandler(this.FormAsignacionEstudiante_Load);
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button btnAsignar;
    private System.Windows.Forms.ComboBox cmbTutor;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.ComboBox cmbEstudiante;
    private System.Windows.Forms.DataGridView dataGridView1;
    private System.Windows.Forms.DateTimePicker dtpFecha;
    private System.Windows.Forms.Label label3;
  }
}