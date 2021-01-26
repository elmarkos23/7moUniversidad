
namespace ProyectoTarea6
{
  partial class FormResumenAsistencia
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
      this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
      this.panel1 = new System.Windows.Forms.Panel();
      this.panel2 = new System.Windows.Forms.Panel();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.label3 = new System.Windows.Forms.Label();
      this.cmbEstudiante = new System.Windows.Forms.ComboBox();
      this.tableLayoutPanel1.SuspendLayout();
      this.groupBox1.SuspendLayout();
      this.SuspendLayout();
      // 
      // tableLayoutPanel1
      // 
      this.tableLayoutPanel1.ColumnCount = 2;
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 1);
      this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 1);
      this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
      this.tableLayoutPanel1.Controls.Add(this.label2, 1, 0);
      this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 59);
      this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(5);
      this.tableLayoutPanel1.Name = "tableLayoutPanel1";
      this.tableLayoutPanel1.RowCount = 3;
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.428571F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 92.57143F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
      this.tableLayoutPanel1.Size = new System.Drawing.Size(791, 332);
      this.tableLayoutPanel1.TabIndex = 0;
      // 
      // panel1
      // 
      this.panel1.BackColor = System.Drawing.Color.White;
      this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.panel1.Location = new System.Drawing.Point(5, 28);
      this.panel1.Margin = new System.Windows.Forms.Padding(5);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(385, 278);
      this.panel1.TabIndex = 0;
      this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
      // 
      // panel2
      // 
      this.panel2.BackColor = System.Drawing.Color.White;
      this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
      this.panel2.Location = new System.Drawing.Point(400, 28);
      this.panel2.Margin = new System.Windows.Forms.Padding(5);
      this.panel2.Name = "panel2";
      this.panel2.Size = new System.Drawing.Size(386, 278);
      this.panel2.TabIndex = 1;
      this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
      // 
      // label1
      // 
      this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.label1.Location = new System.Drawing.Point(5, 0);
      this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(385, 23);
      this.label1.TabIndex = 2;
      this.label1.Text = "Diagrama de Barras";
      this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // label2
      // 
      this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
      this.label2.Location = new System.Drawing.Point(398, 0);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(390, 23);
      this.label2.TabIndex = 3;
      this.label2.Text = "Diagrama de Barras";
      this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.cmbEstudiante);
      this.groupBox1.Controls.Add(this.label3);
      this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
      this.groupBox1.Location = new System.Drawing.Point(0, 0);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(791, 59);
      this.groupBox1.TabIndex = 1;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Alumno";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Dock = System.Windows.Forms.DockStyle.Left;
      this.label3.Location = new System.Drawing.Point(3, 23);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(100, 21);
      this.label3.TabIndex = 0;
      this.label3.Text = "Seleccionar";
      // 
      // cmbEstudiante
      // 
      this.cmbEstudiante.Dock = System.Windows.Forms.DockStyle.Left;
      this.cmbEstudiante.FormattingEnabled = true;
      this.cmbEstudiante.Location = new System.Drawing.Point(103, 23);
      this.cmbEstudiante.Name = "cmbEstudiante";
      this.cmbEstudiante.Size = new System.Drawing.Size(365, 29);
      this.cmbEstudiante.TabIndex = 1;
      this.cmbEstudiante.SelectionChangeCommitted += new System.EventHandler(this.cmbEstudiante_SelectionChangeCommitted);
      // 
      // FormResumenAsistencia
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(791, 391);
      this.Controls.Add(this.tableLayoutPanel1);
      this.Controls.Add(this.groupBox1);
      this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Margin = new System.Windows.Forms.Padding(5);
      this.Name = "FormResumenAsistencia";
      this.Text = "ResumenAsistencia";
      this.Load += new System.EventHandler(this.FormResumenAsistencia_Load);
      this.tableLayoutPanel1.ResumeLayout(false);
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Panel panel2;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.ComboBox cmbEstudiante;
    private System.Windows.Forms.Label label3;
  }
}