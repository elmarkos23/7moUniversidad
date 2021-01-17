
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
      this.panel1 = new System.Windows.Forms.Panel();
      this.panel2 = new System.Windows.Forms.Panel();
      this.panel3 = new System.Windows.Forms.Panel();
      this.richTextBox1 = new System.Windows.Forms.RichTextBox();
      this.btnPacientes = new System.Windows.Forms.Button();
      this.button2 = new System.Windows.Forms.Button();
      this.button3 = new System.Windows.Forms.Button();
      this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
      this.panel1.SuspendLayout();
      this.tableLayoutPanel1.SuspendLayout();
      this.SuspendLayout();
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.button3);
      this.panel1.Controls.Add(this.button2);
      this.panel1.Controls.Add(this.btnPacientes);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.panel1.Location = new System.Drawing.Point(3, 3);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(406, 77);
      this.panel1.TabIndex = 0;
      // 
      // panel2
      // 
      this.panel2.AutoScroll = true;
      this.panel2.BackColor = System.Drawing.Color.White;
      this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
      this.panel2.Location = new System.Drawing.Point(3, 86);
      this.panel2.Name = "panel2";
      this.panel2.Size = new System.Drawing.Size(406, 402);
      this.panel2.TabIndex = 1;
      this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
      // 
      // panel3
      // 
      this.panel3.AutoScroll = true;
      this.panel3.BackColor = System.Drawing.Color.White;
      this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
      this.panel3.Location = new System.Drawing.Point(415, 86);
      this.panel3.Name = "panel3";
      this.panel3.Size = new System.Drawing.Size(407, 402);
      this.panel3.TabIndex = 2;
      this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
      // 
      // richTextBox1
      // 
      this.richTextBox1.Location = new System.Drawing.Point(415, 3);
      this.richTextBox1.Name = "richTextBox1";
      this.richTextBox1.Size = new System.Drawing.Size(356, 77);
      this.richTextBox1.TabIndex = 3;
      this.richTextBox1.Text = "";
      // 
      // btnPacientes
      // 
      this.btnPacientes.Location = new System.Drawing.Point(33, 30);
      this.btnPacientes.Name = "btnPacientes";
      this.btnPacientes.Size = new System.Drawing.Size(89, 23);
      this.btnPacientes.TabIndex = 0;
      this.btnPacientes.Text = "Pacientes";
      this.btnPacientes.UseVisualStyleBackColor = true;
      this.btnPacientes.Click += new System.EventHandler(this.btnPacientes_Click);
      // 
      // button2
      // 
      this.button2.Location = new System.Drawing.Point(139, 30);
      this.button2.Name = "button2";
      this.button2.Size = new System.Drawing.Size(112, 23);
      this.button2.TabIndex = 1;
      this.button2.Text = "Limpiar";
      this.button2.UseVisualStyleBackColor = true;
      this.button2.Click += new System.EventHandler(this.button2_Click);
      // 
      // button3
      // 
      this.button3.Location = new System.Drawing.Point(271, 30);
      this.button3.Name = "button3";
      this.button3.Size = new System.Drawing.Size(89, 23);
      this.button3.TabIndex = 2;
      this.button3.Text = "Diagramas";
      this.button3.UseVisualStyleBackColor = true;
      this.button3.Click += new System.EventHandler(this.button3_Click);
      // 
      // tableLayoutPanel1
      // 
      this.tableLayoutPanel1.ColumnCount = 2;
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 1);
      this.tableLayoutPanel1.Controls.Add(this.richTextBox1, 1, 0);
      this.tableLayoutPanel1.Controls.Add(this.panel3, 1, 1);
      this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
      this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
      this.tableLayoutPanel1.Name = "tableLayoutPanel1";
      this.tableLayoutPanel1.RowCount = 2;
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.10794F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 82.89206F));
      this.tableLayoutPanel1.Size = new System.Drawing.Size(825, 491);
      this.tableLayoutPanel1.TabIndex = 4;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(825, 491);
      this.Controls.Add(this.tableLayoutPanel1);
      this.Name = "Form1";
      this.Text = "Form1";
      this.Load += new System.EventHandler(this.Form1_Load);
      this.panel1.ResumeLayout(false);
      this.tableLayoutPanel1.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Button button3;
    private System.Windows.Forms.Button button2;
    private System.Windows.Forms.Button btnPacientes;
    private System.Windows.Forms.Panel panel2;
    private System.Windows.Forms.Panel panel3;
    private System.Windows.Forms.RichTextBox richTextBox1;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
  }
}

