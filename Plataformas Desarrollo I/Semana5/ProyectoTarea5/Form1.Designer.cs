
namespace ProyectoTarea5
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
      this.richTextBox1 = new System.Windows.Forms.RichTextBox();
      this.panel2 = new System.Windows.Forms.Panel();
      this.panel3 = new System.Windows.Forms.Panel();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.panel1 = new System.Windows.Forms.Panel();
      this.button1 = new System.Windows.Forms.Button();
      this.button2 = new System.Windows.Forms.Button();
      this.button3 = new System.Windows.Forms.Button();
      this.tableLayoutPanel1.SuspendLayout();
      this.panel1.SuspendLayout();
      this.SuspendLayout();
      // 
      // tableLayoutPanel1
      // 
      this.tableLayoutPanel1.ColumnCount = 2;
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanel1.Controls.Add(this.richTextBox1, 1, 0);
      this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 2);
      this.tableLayoutPanel1.Controls.Add(this.panel3, 1, 2);
      this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
      this.tableLayoutPanel1.Controls.Add(this.label2, 1, 1);
      this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
      this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
      this.tableLayoutPanel1.Name = "tableLayoutPanel1";
      this.tableLayoutPanel1.RowCount = 3;
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel1.Size = new System.Drawing.Size(798, 446);
      this.tableLayoutPanel1.TabIndex = 0;
      // 
      // richTextBox1
      // 
      this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.richTextBox1.Location = new System.Drawing.Point(402, 3);
      this.richTextBox1.Name = "richTextBox1";
      this.richTextBox1.Size = new System.Drawing.Size(393, 94);
      this.richTextBox1.TabIndex = 0;
      this.richTextBox1.Text = "";
      // 
      // panel2
      // 
      this.panel2.BackColor = System.Drawing.Color.White;
      this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
      this.panel2.Location = new System.Drawing.Point(3, 138);
      this.panel2.Name = "panel2";
      this.panel2.Size = new System.Drawing.Size(393, 305);
      this.panel2.TabIndex = 1;
      this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
      // 
      // panel3
      // 
      this.panel3.BackColor = System.Drawing.Color.White;
      this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
      this.panel3.Location = new System.Drawing.Point(402, 138);
      this.panel3.Name = "panel3";
      this.panel3.Size = new System.Drawing.Size(393, 305);
      this.panel3.TabIndex = 2;
      this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
      // 
      // label1
      // 
      this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.label1.Location = new System.Drawing.Point(3, 100);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(393, 35);
      this.label1.TabIndex = 3;
      this.label1.Text = "Diagrama de Barras";
      this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // label2
      // 
      this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
      this.label2.Location = new System.Drawing.Point(402, 100);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(393, 35);
      this.label2.TabIndex = 4;
      this.label2.Text = "Diagrama de Pastel";
      this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.button3);
      this.panel1.Controls.Add(this.button2);
      this.panel1.Controls.Add(this.button1);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.panel1.Location = new System.Drawing.Point(3, 3);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(393, 94);
      this.panel1.TabIndex = 5;
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(107, 7);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(145, 23);
      this.button1.TabIndex = 0;
      this.button1.Text = "Venta Computadores";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // button2
      // 
      this.button2.Location = new System.Drawing.Point(107, 36);
      this.button2.Name = "button2";
      this.button2.Size = new System.Drawing.Size(145, 23);
      this.button2.TabIndex = 1;
      this.button2.Text = "Limpiar Contenido";
      this.button2.UseVisualStyleBackColor = true;
      // 
      // button3
      // 
      this.button3.Location = new System.Drawing.Point(107, 65);
      this.button3.Name = "button3";
      this.button3.Size = new System.Drawing.Size(145, 23);
      this.button3.TabIndex = 2;
      this.button3.Text = "Graficar";
      this.button3.UseVisualStyleBackColor = true;
      this.button3.Click += new System.EventHandler(this.button3_Click);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(798, 446);
      this.Controls.Add(this.tableLayoutPanel1);
      this.Name = "Form1";
      this.Text = "Form1";
      this.Load += new System.EventHandler(this.Form1_Load);
      this.tableLayoutPanel1.ResumeLayout(false);
      this.panel1.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    private System.Windows.Forms.RichTextBox richTextBox1;
    private System.Windows.Forms.Panel panel2;
    private System.Windows.Forms.Panel panel3;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Button button3;
    private System.Windows.Forms.Button button2;
    private System.Windows.Forms.Button button1;
  }
}

