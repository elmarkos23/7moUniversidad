
namespace ProyectoTarea6
{
  partial class FormRegistroAsistencia
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
      this.dataGridView1 = new System.Windows.Forms.DataGridView();
      this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
      this.label1 = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
      this.SuspendLayout();
      // 
      // button1
      // 
      this.button1.BackColor = System.Drawing.Color.White;
      this.button1.Location = new System.Drawing.Point(225, 332);
      this.button1.Margin = new System.Windows.Forms.Padding(5);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(168, 40);
      this.button1.TabIndex = 8;
      this.button1.Text = "Grabar";
      this.button1.UseVisualStyleBackColor = false;
      // 
      // dataGridView1
      // 
      this.dataGridView1.AllowUserToAddRows = false;
      this.dataGridView1.AllowUserToDeleteRows = false;
      this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView1.Location = new System.Drawing.Point(12, 76);
      this.dataGridView1.Name = "dataGridView1";
      this.dataGridView1.Size = new System.Drawing.Size(640, 212);
      this.dataGridView1.TabIndex = 12;
      // 
      // dateTimePicker1
      // 
      this.dateTimePicker1.Location = new System.Drawing.Point(100, 27);
      this.dateTimePicker1.Name = "dateTimePicker1";
      this.dateTimePicker1.Size = new System.Drawing.Size(319, 27);
      this.dateTimePicker1.TabIndex = 13;
      this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(21, 27);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(59, 21);
      this.label1.TabIndex = 14;
      this.label1.Text = "Fecha";
      // 
      // FormRegistroAsistencia
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.SkyBlue;
      this.ClientSize = new System.Drawing.Size(673, 386);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.dateTimePicker1);
      this.Controls.Add(this.dataGridView1);
      this.Controls.Add(this.button1);
      this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Margin = new System.Windows.Forms.Padding(5);
      this.Name = "FormRegistroAsistencia";
      this.Text = "RegistroAsistencia";
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.DataGridView dataGridView1;
    private System.Windows.Forms.DateTimePicker dateTimePicker1;
    private System.Windows.Forms.Label label1;
  }
}