
namespace ProyectoLab5
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
      this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
      this.pictureBox1 = new System.Windows.Forms.PictureBox();
      this.button1 = new System.Windows.Forms.Button();
      this.button2 = new System.Windows.Forms.Button();
      this.button3 = new System.Windows.Forms.Button();
      this.button4 = new System.Windows.Forms.Button();
      this.radioButton1 = new System.Windows.Forms.RadioButton();
      this.radioButton2 = new System.Windows.Forms.RadioButton();
      this.tableLayoutPanel1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
      this.SuspendLayout();
      // 
      // tableLayoutPanel1
      // 
      this.tableLayoutPanel1.ColumnCount = 6;
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
      this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 0);
      this.tableLayoutPanel1.Controls.Add(this.button1, 0, 1);
      this.tableLayoutPanel1.Controls.Add(this.button2, 3, 1);
      this.tableLayoutPanel1.Controls.Add(this.button3, 4, 1);
      this.tableLayoutPanel1.Controls.Add(this.button4, 5, 1);
      this.tableLayoutPanel1.Controls.Add(this.radioButton1, 1, 1);
      this.tableLayoutPanel1.Controls.Add(this.radioButton2, 2, 1);
      this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
      this.tableLayoutPanel1.Name = "tableLayoutPanel1";
      this.tableLayoutPanel1.RowCount = 2;
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 91.16883F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.831169F));
      this.tableLayoutPanel1.Size = new System.Drawing.Size(832, 385);
      this.tableLayoutPanel1.TabIndex = 0;
      // 
      // pictureBox1
      // 
      this.pictureBox1.BackColor = System.Drawing.Color.White;
      this.tableLayoutPanel1.SetColumnSpan(this.pictureBox1, 6);
      this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.pictureBox1.Location = new System.Drawing.Point(3, 3);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new System.Drawing.Size(826, 344);
      this.pictureBox1.TabIndex = 0;
      this.pictureBox1.TabStop = false;
      // 
      // button1
      // 
      this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.button1.Location = new System.Drawing.Point(3, 353);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(94, 29);
      this.button1.TabIndex = 1;
      this.button1.Text = "Tabla Valores";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // button2
      // 
      this.button2.Dock = System.Windows.Forms.DockStyle.Fill;
      this.button2.Location = new System.Drawing.Point(535, 353);
      this.button2.Name = "button2";
      this.button2.Size = new System.Drawing.Size(94, 29);
      this.button2.TabIndex = 2;
      this.button2.Text = "Dibujar";
      this.button2.UseVisualStyleBackColor = true;
      this.button2.Click += new System.EventHandler(this.button2_Click);
      // 
      // button3
      // 
      this.button3.Dock = System.Windows.Forms.DockStyle.Fill;
      this.button3.Location = new System.Drawing.Point(635, 353);
      this.button3.Name = "button3";
      this.button3.Size = new System.Drawing.Size(94, 29);
      this.button3.TabIndex = 3;
      this.button3.Text = "Limpiar";
      this.button3.UseVisualStyleBackColor = true;
      this.button3.Click += new System.EventHandler(this.button3_Click);
      // 
      // button4
      // 
      this.button4.Dock = System.Windows.Forms.DockStyle.Fill;
      this.button4.Location = new System.Drawing.Point(735, 353);
      this.button4.Name = "button4";
      this.button4.Size = new System.Drawing.Size(94, 29);
      this.button4.TabIndex = 4;
      this.button4.Text = "Salir";
      this.button4.UseVisualStyleBackColor = true;
      this.button4.Click += new System.EventHandler(this.button4_Click);
      // 
      // radioButton1
      // 
      this.radioButton1.AutoSize = true;
      this.radioButton1.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
      this.radioButton1.Dock = System.Windows.Forms.DockStyle.Right;
      this.radioButton1.Location = new System.Drawing.Point(361, 353);
      this.radioButton1.Name = "radioButton1";
      this.radioButton1.Size = new System.Drawing.Size(68, 29);
      this.radioButton1.TabIndex = 5;
      this.radioButton1.TabStop = true;
      this.radioButton1.Text = "Gráfica 1";
      this.radioButton1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      this.radioButton1.UseVisualStyleBackColor = true;
      // 
      // radioButton2
      // 
      this.radioButton2.AutoSize = true;
      this.radioButton2.Dock = System.Windows.Forms.DockStyle.Right;
      this.radioButton2.Location = new System.Drawing.Point(461, 353);
      this.radioButton2.Name = "radioButton2";
      this.radioButton2.Size = new System.Drawing.Size(68, 29);
      this.radioButton2.TabIndex = 6;
      this.radioButton2.TabStop = true;
      this.radioButton2.Text = "Gráfica 2";
      this.radioButton2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      this.radioButton2.UseVisualStyleBackColor = true;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(832, 385);
      this.Controls.Add(this.tableLayoutPanel1);
      this.Name = "Form1";
      this.Text = "Form1";
      this.tableLayoutPanel1.ResumeLayout(false);
      this.tableLayoutPanel1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    private System.Windows.Forms.PictureBox pictureBox1;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Button button2;
    private System.Windows.Forms.Button button3;
    private System.Windows.Forms.Button button4;
    private System.Windows.Forms.RadioButton radioButton1;
    private System.Windows.Forms.RadioButton radioButton2;
  }
}

