
namespace ProyectoTarea6
{
  partial class Form1
  {
    /// <summary>
    /// Variable del diseñador necesaria.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Limpiar los recursos que se estén usando.
    /// </summary>
    /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Código generado por el Diseñador de Windows Forms

    /// <summary>
    /// Método necesario para admitir el Diseñador. No se puede modificar
    /// el contenido de este método con el editor de código.
    /// </summary>
    private void InitializeComponent()
    {
      this.menuStrip1 = new System.Windows.Forms.MenuStrip();
      this.registroEstudiantesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.registroDeAsistenciaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.resumenDeAsistenciaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.asignarHorarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.menuStrip1.SuspendLayout();
      this.SuspendLayout();
      // 
      // menuStrip1
      // 
      this.menuStrip1.BackColor = System.Drawing.Color.SkyBlue;
      this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registroEstudiantesToolStripMenuItem,
            this.registroDeAsistenciaToolStripMenuItem,
            this.resumenDeAsistenciaToolStripMenuItem,
            this.asignarHorarioToolStripMenuItem});
      this.menuStrip1.Location = new System.Drawing.Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
      this.menuStrip1.Size = new System.Drawing.Size(784, 24);
      this.menuStrip1.TabIndex = 1;
      this.menuStrip1.Text = "menuStrip1";
      // 
      // registroEstudiantesToolStripMenuItem
      // 
      this.registroEstudiantesToolStripMenuItem.ForeColor = System.Drawing.Color.White;
      this.registroEstudiantesToolStripMenuItem.Name = "registroEstudiantesToolStripMenuItem";
      this.registroEstudiantesToolStripMenuItem.Size = new System.Drawing.Size(125, 20);
      this.registroEstudiantesToolStripMenuItem.Text = "Registro Estudiantes";
      this.registroEstudiantesToolStripMenuItem.Click += new System.EventHandler(this.registroEstudiantesToolStripMenuItem_Click);
      // 
      // registroDeAsistenciaToolStripMenuItem
      // 
      this.registroDeAsistenciaToolStripMenuItem.ForeColor = System.Drawing.Color.White;
      this.registroDeAsistenciaToolStripMenuItem.Name = "registroDeAsistenciaToolStripMenuItem";
      this.registroDeAsistenciaToolStripMenuItem.Size = new System.Drawing.Size(134, 20);
      this.registroDeAsistenciaToolStripMenuItem.Text = "Registro de Asistencia";
      this.registroDeAsistenciaToolStripMenuItem.Click += new System.EventHandler(this.registroDeAsistenciaToolStripMenuItem_Click);
      // 
      // resumenDeAsistenciaToolStripMenuItem
      // 
      this.resumenDeAsistenciaToolStripMenuItem.ForeColor = System.Drawing.Color.White;
      this.resumenDeAsistenciaToolStripMenuItem.Name = "resumenDeAsistenciaToolStripMenuItem";
      this.resumenDeAsistenciaToolStripMenuItem.Size = new System.Drawing.Size(140, 20);
      this.resumenDeAsistenciaToolStripMenuItem.Text = "Resumen de Asistencia";
      this.resumenDeAsistenciaToolStripMenuItem.Click += new System.EventHandler(this.resumenDeAsistenciaToolStripMenuItem_Click);
      // 
      // asignarHorarioToolStripMenuItem
      // 
      this.asignarHorarioToolStripMenuItem.Name = "asignarHorarioToolStripMenuItem";
      this.asignarHorarioToolStripMenuItem.Size = new System.Drawing.Size(102, 20);
      this.asignarHorarioToolStripMenuItem.Text = "Asignar Horario";
      this.asignarHorarioToolStripMenuItem.Click += new System.EventHandler(this.asignarHorarioToolStripMenuItem_Click);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(784, 362);
      this.Controls.Add(this.menuStrip1);
      this.IsMdiContainer = true;
      this.Name = "Form1";
      this.Text = "LTIC- Laboratorio de Tecnologías de la Información";
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion
    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem registroEstudiantesToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem registroDeAsistenciaToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem resumenDeAsistenciaToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem asignarHorarioToolStripMenuItem;
  }
}

