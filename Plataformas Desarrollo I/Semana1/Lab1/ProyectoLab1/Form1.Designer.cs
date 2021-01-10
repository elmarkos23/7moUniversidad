namespace ProyectoLab1
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
      this.rtPares = new System.Windows.Forms.RichTextBox();
      this.rtImpares = new System.Windows.Forms.RichTextBox();
      this.rtFibonaci = new System.Windows.Forms.RichTextBox();
      this.rtPrimos = new System.Windows.Forms.RichTextBox();
      this.btnPares = new System.Windows.Forms.Button();
      this.btnImpares = new System.Windows.Forms.Button();
      this.btnFibonaci = new System.Windows.Forms.Button();
      this.btnPrimos = new System.Windows.Forms.Button();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.tableLayoutPanel1.SuspendLayout();
      this.SuspendLayout();
      // 
      // tableLayoutPanel1
      // 
      this.tableLayoutPanel1.ColumnCount = 4;
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
      this.tableLayoutPanel1.Controls.Add(this.label4, 3, 0);
      this.tableLayoutPanel1.Controls.Add(this.label3, 2, 0);
      this.tableLayoutPanel1.Controls.Add(this.label2, 1, 0);
      this.tableLayoutPanel1.Controls.Add(this.rtPares, 0, 1);
      this.tableLayoutPanel1.Controls.Add(this.rtImpares, 1, 1);
      this.tableLayoutPanel1.Controls.Add(this.rtFibonaci, 2, 1);
      this.tableLayoutPanel1.Controls.Add(this.rtPrimos, 3, 1);
      this.tableLayoutPanel1.Controls.Add(this.btnPares, 0, 2);
      this.tableLayoutPanel1.Controls.Add(this.btnImpares, 1, 2);
      this.tableLayoutPanel1.Controls.Add(this.btnFibonaci, 2, 2);
      this.tableLayoutPanel1.Controls.Add(this.btnPrimos, 3, 2);
      this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
      this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
      this.tableLayoutPanel1.Name = "tableLayoutPanel1";
      this.tableLayoutPanel1.RowCount = 3;
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
      this.tableLayoutPanel1.Size = new System.Drawing.Size(650, 416);
      this.tableLayoutPanel1.TabIndex = 0;
      // 
      // rtPares
      // 
      this.rtPares.Dock = System.Windows.Forms.DockStyle.Fill;
      this.rtPares.Location = new System.Drawing.Point(3, 38);
      this.rtPares.Name = "rtPares";
      this.rtPares.Size = new System.Drawing.Size(156, 340);
      this.rtPares.TabIndex = 0;
      this.rtPares.Text = "";
      // 
      // rtImpares
      // 
      this.rtImpares.Dock = System.Windows.Forms.DockStyle.Fill;
      this.rtImpares.Location = new System.Drawing.Point(165, 38);
      this.rtImpares.Name = "rtImpares";
      this.rtImpares.Size = new System.Drawing.Size(156, 340);
      this.rtImpares.TabIndex = 1;
      this.rtImpares.Text = "";
      // 
      // rtFibonaci
      // 
      this.rtFibonaci.Dock = System.Windows.Forms.DockStyle.Fill;
      this.rtFibonaci.Location = new System.Drawing.Point(327, 38);
      this.rtFibonaci.Name = "rtFibonaci";
      this.rtFibonaci.Size = new System.Drawing.Size(156, 340);
      this.rtFibonaci.TabIndex = 2;
      this.rtFibonaci.Text = "";
      // 
      // rtPrimos
      // 
      this.rtPrimos.Dock = System.Windows.Forms.DockStyle.Fill;
      this.rtPrimos.Location = new System.Drawing.Point(489, 38);
      this.rtPrimos.Name = "rtPrimos";
      this.rtPrimos.Size = new System.Drawing.Size(158, 340);
      this.rtPrimos.TabIndex = 3;
      this.rtPrimos.Text = "";
      // 
      // btnPares
      // 
      this.btnPares.Dock = System.Windows.Forms.DockStyle.Fill;
      this.btnPares.Location = new System.Drawing.Point(3, 384);
      this.btnPares.Name = "btnPares";
      this.btnPares.Size = new System.Drawing.Size(156, 29);
      this.btnPares.TabIndex = 4;
      this.btnPares.Text = "Visualizar";
      this.btnPares.UseVisualStyleBackColor = true;
      this.btnPares.Click += new System.EventHandler(this.btnPares_Click);
      // 
      // btnImpares
      // 
      this.btnImpares.Dock = System.Windows.Forms.DockStyle.Fill;
      this.btnImpares.Location = new System.Drawing.Point(165, 384);
      this.btnImpares.Name = "btnImpares";
      this.btnImpares.Size = new System.Drawing.Size(156, 29);
      this.btnImpares.TabIndex = 5;
      this.btnImpares.Text = "Visualizar";
      this.btnImpares.UseVisualStyleBackColor = true;
      this.btnImpares.Click += new System.EventHandler(this.btnImpares_Click);
      // 
      // btnFibonaci
      // 
      this.btnFibonaci.Dock = System.Windows.Forms.DockStyle.Fill;
      this.btnFibonaci.Location = new System.Drawing.Point(327, 384);
      this.btnFibonaci.Name = "btnFibonaci";
      this.btnFibonaci.Size = new System.Drawing.Size(156, 29);
      this.btnFibonaci.TabIndex = 6;
      this.btnFibonaci.Text = "Visualizar";
      this.btnFibonaci.UseVisualStyleBackColor = true;
      this.btnFibonaci.Click += new System.EventHandler(this.btnFibonaci_Click);
      // 
      // btnPrimos
      // 
      this.btnPrimos.Dock = System.Windows.Forms.DockStyle.Fill;
      this.btnPrimos.Location = new System.Drawing.Point(489, 384);
      this.btnPrimos.Name = "btnPrimos";
      this.btnPrimos.Size = new System.Drawing.Size(158, 29);
      this.btnPrimos.TabIndex = 7;
      this.btnPrimos.Text = "Visualizar";
      this.btnPrimos.UseVisualStyleBackColor = true;
      this.btnPrimos.Click += new System.EventHandler(this.btnPrimos_Click);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.label1.Location = new System.Drawing.Point(3, 0);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(156, 35);
      this.label1.TabIndex = 8;
      this.label1.Text = "Pares";
      this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
      this.label2.Location = new System.Drawing.Point(165, 0);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(156, 35);
      this.label2.TabIndex = 9;
      this.label2.Text = "Impares";
      this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
      this.label3.Location = new System.Drawing.Point(327, 0);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(156, 35);
      this.label3.TabIndex = 10;
      this.label3.Text = "Fibonaci";
      this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
      this.label4.Location = new System.Drawing.Point(489, 0);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(158, 35);
      this.label4.TabIndex = 11;
      this.label4.Text = "Primos";
      this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(650, 416);
      this.Controls.Add(this.tableLayoutPanel1);
      this.Name = "Form1";
      this.Text = "Series";
      this.tableLayoutPanel1.ResumeLayout(false);
      this.tableLayoutPanel1.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.RichTextBox rtPares;
    private System.Windows.Forms.RichTextBox rtImpares;
    private System.Windows.Forms.RichTextBox rtFibonaci;
    private System.Windows.Forms.RichTextBox rtPrimos;
    private System.Windows.Forms.Button btnPares;
    private System.Windows.Forms.Button btnImpares;
    private System.Windows.Forms.Button btnFibonaci;
    private System.Windows.Forms.Button btnPrimos;
    private System.Windows.Forms.Label label1;
  }
}

