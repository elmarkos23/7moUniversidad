
namespace ProyectoTarea6
{
  partial class FromHorario
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
      this.cmbDia = new System.Windows.Forms.ComboBox();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.cmbTarea = new System.Windows.Forms.ComboBox();
      this.btnGrabar = new System.Windows.Forms.Button();
      this.Estudiante = new System.Windows.Forms.Label();
      this.cmbEstudiante = new System.Windows.Forms.ComboBox();
      this.dataGridView2 = new System.Windows.Forms.DataGridView();
      this.richTextBox1 = new System.Windows.Forms.RichTextBox();
      this.label3 = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
      this.SuspendLayout();
      // 
      // cmbDia
      // 
      this.cmbDia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cmbDia.FormattingEnabled = true;
      this.cmbDia.Items.AddRange(new object[] {
            "Lunes",
            "Martes",
            "Miercoles",
            "Jueves",
            "Viernes",
            "Sabado",
            "Domingo"});
      this.cmbDia.Location = new System.Drawing.Point(147, 61);
      this.cmbDia.Margin = new System.Windows.Forms.Padding(5);
      this.cmbDia.Name = "cmbDia";
      this.cmbDia.Size = new System.Drawing.Size(248, 29);
      this.cmbDia.TabIndex = 0;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(35, 70);
      this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(36, 21);
      this.label1.TabIndex = 1;
      this.label1.Text = "Dia";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(35, 114);
      this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(55, 21);
      this.label2.TabIndex = 3;
      this.label2.Text = "Tarea";
      // 
      // cmbTarea
      // 
      this.cmbTarea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cmbTarea.FormattingEnabled = true;
      this.cmbTarea.Location = new System.Drawing.Point(147, 100);
      this.cmbTarea.Margin = new System.Windows.Forms.Padding(5);
      this.cmbTarea.Name = "cmbTarea";
      this.cmbTarea.Size = new System.Drawing.Size(335, 29);
      this.cmbTarea.TabIndex = 2;
      // 
      // btnGrabar
      // 
      this.btnGrabar.BackColor = System.Drawing.Color.White;
      this.btnGrabar.Location = new System.Drawing.Point(357, 139);
      this.btnGrabar.Margin = new System.Windows.Forms.Padding(5);
      this.btnGrabar.Name = "btnGrabar";
      this.btnGrabar.Size = new System.Drawing.Size(125, 37);
      this.btnGrabar.TabIndex = 4;
      this.btnGrabar.Text = "Grabar";
      this.btnGrabar.UseVisualStyleBackColor = false;
      this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
      // 
      // Estudiante
      // 
      this.Estudiante.AutoSize = true;
      this.Estudiante.Location = new System.Drawing.Point(35, 27);
      this.Estudiante.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
      this.Estudiante.Name = "Estudiante";
      this.Estudiante.Size = new System.Drawing.Size(94, 21);
      this.Estudiante.TabIndex = 7;
      this.Estudiante.Text = "Estudiante";
      // 
      // cmbEstudiante
      // 
      this.cmbEstudiante.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cmbEstudiante.FormattingEnabled = true;
      this.cmbEstudiante.Items.AddRange(new object[] {
            "Lunes",
            "Martes",
            "Miércoles",
            "Jueves",
            "Viernes",
            "Sábado",
            "Domingo"});
      this.cmbEstudiante.Location = new System.Drawing.Point(147, 22);
      this.cmbEstudiante.Margin = new System.Windows.Forms.Padding(5);
      this.cmbEstudiante.Name = "cmbEstudiante";
      this.cmbEstudiante.Size = new System.Drawing.Size(248, 29);
      this.cmbEstudiante.TabIndex = 6;
      this.cmbEstudiante.SelectionChangeCommitted += new System.EventHandler(this.cmbEstudiante_SelectionChangeCommitted);
      // 
      // dataGridView2
      // 
      this.dataGridView2.AllowUserToAddRows = false;
      this.dataGridView2.AllowUserToDeleteRows = false;
      this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView2.Location = new System.Drawing.Point(14, 186);
      this.dataGridView2.Margin = new System.Windows.Forms.Padding(5);
      this.dataGridView2.Name = "dataGridView2";
      this.dataGridView2.ReadOnly = true;
      this.dataGridView2.Size = new System.Drawing.Size(594, 279);
      this.dataGridView2.TabIndex = 8;
      // 
      // richTextBox1
      // 
      this.richTextBox1.Location = new System.Drawing.Point(633, 33);
      this.richTextBox1.Name = "richTextBox1";
      this.richTextBox1.Size = new System.Drawing.Size(269, 431);
      this.richTextBox1.TabIndex = 9;
      this.richTextBox1.Text = "";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(629, 9);
      this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(121, 21);
      this.label3.TabIndex = 10;
      this.label3.Text = "Horario Global";
      // 
      // FromHorario
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.SkyBlue;
      this.ClientSize = new System.Drawing.Size(914, 476);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.richTextBox1);
      this.Controls.Add(this.dataGridView2);
      this.Controls.Add(this.Estudiante);
      this.Controls.Add(this.cmbEstudiante);
      this.Controls.Add(this.btnGrabar);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.cmbTarea);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.cmbDia);
      this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Margin = new System.Windows.Forms.Padding(5);
      this.Name = "FromHorario";
      this.Text = "FromHorario";
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.ComboBox cmbDia;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.ComboBox cmbTarea;
    private System.Windows.Forms.Button btnGrabar;
    private System.Windows.Forms.Label Estudiante;
    private System.Windows.Forms.ComboBox cmbEstudiante;
    private System.Windows.Forms.DataGridView dataGridView2;
    private System.Windows.Forms.RichTextBox richTextBox1;
    private System.Windows.Forms.Label label3;
  }
}