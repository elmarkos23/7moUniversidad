
namespace ProyectoTarea7
{
  partial class FormMenu
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
      this.button1 = new System.Windows.Forms.Button();
      this.button2 = new System.Windows.Forms.Button();
      this.button3 = new System.Windows.Forms.Button();
      this.button4 = new System.Windows.Forms.Button();
      this.label1 = new System.Windows.Forms.Label();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
      this.panel1 = new System.Windows.Forms.Panel();
      this.panel2 = new System.Windows.Forms.Panel();
      this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
      this.label2 = new System.Windows.Forms.Label();
      this.cmbEstudiante = new System.Windows.Forms.ComboBox();
      this.btnGraficar = new System.Windows.Forms.Button();
      this.groupBox1.SuspendLayout();
      this.tableLayoutPanel1.SuspendLayout();
      this.tableLayoutPanel2.SuspendLayout();
      this.SuspendLayout();
      // 
      // button1
      // 
      this.button1.BackColor = System.Drawing.Color.Black;
      this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.button1.Location = new System.Drawing.Point(3, 3);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(124, 24);
      this.button1.TabIndex = 0;
      this.button1.Text = "Estudiantes";
      this.button1.UseVisualStyleBackColor = false;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // button2
      // 
      this.button2.BackColor = System.Drawing.Color.Black;
      this.button2.Dock = System.Windows.Forms.DockStyle.Fill;
      this.button2.Location = new System.Drawing.Point(133, 3);
      this.button2.Name = "button2";
      this.button2.Size = new System.Drawing.Size(124, 24);
      this.button2.TabIndex = 1;
      this.button2.Text = "Tutores";
      this.button2.UseVisualStyleBackColor = false;
      this.button2.Click += new System.EventHandler(this.button2_Click);
      // 
      // button3
      // 
      this.button3.BackColor = System.Drawing.Color.Black;
      this.button3.Dock = System.Windows.Forms.DockStyle.Fill;
      this.button3.Location = new System.Drawing.Point(263, 3);
      this.button3.Name = "button3";
      this.button3.Size = new System.Drawing.Size(124, 24);
      this.button3.TabIndex = 2;
      this.button3.Text = "Asignación";
      this.button3.UseVisualStyleBackColor = false;
      this.button3.Click += new System.EventHandler(this.button3_Click);
      // 
      // button4
      // 
      this.button4.BackColor = System.Drawing.Color.Black;
      this.button4.Dock = System.Windows.Forms.DockStyle.Fill;
      this.button4.Location = new System.Drawing.Point(393, 3);
      this.button4.Name = "button4";
      this.button4.Size = new System.Drawing.Size(124, 24);
      this.button4.TabIndex = 3;
      this.button4.Text = "Actividades";
      this.button4.UseVisualStyleBackColor = false;
      this.button4.Click += new System.EventHandler(this.button4_Click);
      // 
      // label1
      // 
      this.label1.Dock = System.Windows.Forms.DockStyle.Right;
      this.label1.Location = new System.Drawing.Point(704, 0);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(85, 30);
      this.label1.TabIndex = 4;
      this.label1.Text = "Por Marco Ayala";
      this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // groupBox1
      // 
      this.tableLayoutPanel2.SetColumnSpan(this.groupBox1, 5);
      this.groupBox1.Controls.Add(this.tableLayoutPanel1);
      this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.groupBox1.Location = new System.Drawing.Point(3, 33);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(786, 389);
      this.groupBox1.TabIndex = 5;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Gráficos Estadisticos";
      // 
      // tableLayoutPanel1
      // 
      this.tableLayoutPanel1.ColumnCount = 2;
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
      this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 0);
      this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 19);
      this.tableLayoutPanel1.Name = "tableLayoutPanel1";
      this.tableLayoutPanel1.RowCount = 1;
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanel1.Size = new System.Drawing.Size(780, 367);
      this.tableLayoutPanel1.TabIndex = 0;
      // 
      // panel1
      // 
      this.panel1.BackColor = System.Drawing.Color.White;
      this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.panel1.Location = new System.Drawing.Point(3, 3);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(384, 361);
      this.panel1.TabIndex = 0;
      this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
      // 
      // panel2
      // 
      this.panel2.BackColor = System.Drawing.Color.White;
      this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
      this.panel2.Location = new System.Drawing.Point(393, 3);
      this.panel2.Name = "panel2";
      this.panel2.Size = new System.Drawing.Size(384, 361);
      this.panel2.TabIndex = 1;
      this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
      // 
      // tableLayoutPanel2
      // 
      this.tableLayoutPanel2.ColumnCount = 5;
      this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130F));
      this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130F));
      this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130F));
      this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130F));
      this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel2.Controls.Add(this.groupBox1, 0, 1);
      this.tableLayoutPanel2.Controls.Add(this.button1, 0, 0);
      this.tableLayoutPanel2.Controls.Add(this.button2, 1, 0);
      this.tableLayoutPanel2.Controls.Add(this.label1, 4, 0);
      this.tableLayoutPanel2.Controls.Add(this.button3, 2, 0);
      this.tableLayoutPanel2.Controls.Add(this.button4, 3, 0);
      this.tableLayoutPanel2.Controls.Add(this.label2, 0, 2);
      this.tableLayoutPanel2.Controls.Add(this.cmbEstudiante, 1, 2);
      this.tableLayoutPanel2.Controls.Add(this.btnGraficar, 3, 2);
      this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
      this.tableLayoutPanel2.Name = "tableLayoutPanel2";
      this.tableLayoutPanel2.RowCount = 3;
      this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
      this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
      this.tableLayoutPanel2.Size = new System.Drawing.Size(792, 455);
      this.tableLayoutPanel2.TabIndex = 6;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(3, 425);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(83, 30);
      this.label2.TabIndex = 6;
      this.label2.Text = "Seleccione Estudiante";
      // 
      // cmbEstudiante
      // 
      this.tableLayoutPanel2.SetColumnSpan(this.cmbEstudiante, 2);
      this.cmbEstudiante.Dock = System.Windows.Forms.DockStyle.Top;
      this.cmbEstudiante.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cmbEstudiante.FormattingEnabled = true;
      this.cmbEstudiante.Location = new System.Drawing.Point(133, 428);
      this.cmbEstudiante.Name = "cmbEstudiante";
      this.cmbEstudiante.Size = new System.Drawing.Size(254, 23);
      this.cmbEstudiante.TabIndex = 7;
      // 
      // btnGraficar
      // 
      this.btnGraficar.BackColor = System.Drawing.Color.Black;
      this.btnGraficar.Dock = System.Windows.Forms.DockStyle.Fill;
      this.btnGraficar.Location = new System.Drawing.Point(393, 428);
      this.btnGraficar.Name = "btnGraficar";
      this.btnGraficar.Size = new System.Drawing.Size(124, 24);
      this.btnGraficar.TabIndex = 8;
      this.btnGraficar.Text = "Graficar";
      this.btnGraficar.UseVisualStyleBackColor = false;
      this.btnGraficar.Click += new System.EventHandler(this.btnGraficar_Click);
      // 
      // FormMenu
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(792, 455);
      this.Controls.Add(this.tableLayoutPanel2);
      this.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
      this.Name = "FormMenu";
      this.Text = "Sistema de Tutorias - Menu";
      this.groupBox1.ResumeLayout(false);
      this.tableLayoutPanel1.ResumeLayout(false);
      this.tableLayoutPanel2.ResumeLayout(false);
      this.tableLayoutPanel2.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Button button2;
    private System.Windows.Forms.Button button3;
    private System.Windows.Forms.Button button4;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Panel panel2;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.ComboBox cmbEstudiante;
    private System.Windows.Forms.Button btnGraficar;
  }
}