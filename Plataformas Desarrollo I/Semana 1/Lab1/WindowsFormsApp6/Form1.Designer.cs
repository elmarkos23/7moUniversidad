namespace WindowsFormsApp6
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
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.btnPares = new System.Windows.Forms.Button();
      this.btnImpares = new System.Windows.Forms.Button();
      this.btnFibonaci = new System.Windows.Forms.Button();
      this.richTextBox1 = new System.Windows.Forms.RichTextBox();
      this.richTextBox2 = new System.Windows.Forms.RichTextBox();
      this.richTextBox3 = new System.Windows.Forms.RichTextBox();
      this.label4 = new System.Windows.Forms.Label();
      this.richTextBox4 = new System.Windows.Forms.RichTextBox();
      this.btnPrimos = new System.Windows.Forms.Button();
      this.tableLayoutPanel1.SuspendLayout();
      this.SuspendLayout();
      // 
      // tableLayoutPanel1
      // 
      this.tableLayoutPanel1.ColumnCount = 4;
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.00062F));
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.00063F));
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.00063F));
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.99813F));
      this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
      this.tableLayoutPanel1.Controls.Add(this.label2, 1, 0);
      this.tableLayoutPanel1.Controls.Add(this.label3, 2, 0);
      this.tableLayoutPanel1.Controls.Add(this.btnPares, 0, 2);
      this.tableLayoutPanel1.Controls.Add(this.btnImpares, 1, 2);
      this.tableLayoutPanel1.Controls.Add(this.btnFibonaci, 2, 2);
      this.tableLayoutPanel1.Controls.Add(this.richTextBox1, 0, 1);
      this.tableLayoutPanel1.Controls.Add(this.richTextBox2, 1, 1);
      this.tableLayoutPanel1.Controls.Add(this.richTextBox3, 2, 1);
      this.tableLayoutPanel1.Controls.Add(this.label4, 3, 0);
      this.tableLayoutPanel1.Controls.Add(this.richTextBox4, 3, 1);
      this.tableLayoutPanel1.Controls.Add(this.btnPrimos, 3, 2);
      this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
      this.tableLayoutPanel1.Name = "tableLayoutPanel1";
      this.tableLayoutPanel1.RowCount = 3;
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
      this.tableLayoutPanel1.Size = new System.Drawing.Size(654, 260);
      this.tableLayoutPanel1.TabIndex = 0;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.label1.Location = new System.Drawing.Point(3, 0);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(157, 30);
      this.label1.TabIndex = 0;
      this.label1.Text = "Pares";
      this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
      this.label2.Location = new System.Drawing.Point(166, 0);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(157, 30);
      this.label2.TabIndex = 1;
      this.label2.Text = "Impares";
      this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
      this.label3.Location = new System.Drawing.Point(329, 0);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(157, 30);
      this.label3.TabIndex = 2;
      this.label3.Text = "Fibonacci";
      this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // btnPares
      // 
      this.btnPares.Dock = System.Windows.Forms.DockStyle.Fill;
      this.btnPares.Location = new System.Drawing.Point(3, 233);
      this.btnPares.Name = "btnPares";
      this.btnPares.Size = new System.Drawing.Size(157, 24);
      this.btnPares.TabIndex = 3;
      this.btnPares.Text = "Ver";
      this.btnPares.UseVisualStyleBackColor = true;
      this.btnPares.Click += new System.EventHandler(this.btnPares_Click);
      // 
      // btnImpares
      // 
      this.btnImpares.Dock = System.Windows.Forms.DockStyle.Fill;
      this.btnImpares.Location = new System.Drawing.Point(166, 233);
      this.btnImpares.Name = "btnImpares";
      this.btnImpares.Size = new System.Drawing.Size(157, 24);
      this.btnImpares.TabIndex = 4;
      this.btnImpares.Text = "Ver";
      this.btnImpares.UseVisualStyleBackColor = true;
      this.btnImpares.Click += new System.EventHandler(this.btnImpares_Click);
      // 
      // btnFibonaci
      // 
      this.btnFibonaci.Dock = System.Windows.Forms.DockStyle.Fill;
      this.btnFibonaci.Location = new System.Drawing.Point(329, 233);
      this.btnFibonaci.Name = "btnFibonaci";
      this.btnFibonaci.Size = new System.Drawing.Size(157, 24);
      this.btnFibonaci.TabIndex = 5;
      this.btnFibonaci.Text = "Ver";
      this.btnFibonaci.UseVisualStyleBackColor = true;
      this.btnFibonaci.Click += new System.EventHandler(this.btnFibonaci_Click);
      // 
      // richTextBox1
      // 
      this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.richTextBox1.Location = new System.Drawing.Point(3, 33);
      this.richTextBox1.Name = "richTextBox1";
      this.richTextBox1.Size = new System.Drawing.Size(157, 194);
      this.richTextBox1.TabIndex = 6;
      this.richTextBox1.Text = "";
      // 
      // richTextBox2
      // 
      this.richTextBox2.Dock = System.Windows.Forms.DockStyle.Fill;
      this.richTextBox2.Location = new System.Drawing.Point(166, 33);
      this.richTextBox2.Name = "richTextBox2";
      this.richTextBox2.Size = new System.Drawing.Size(157, 194);
      this.richTextBox2.TabIndex = 7;
      this.richTextBox2.Text = "";
      // 
      // richTextBox3
      // 
      this.richTextBox3.Dock = System.Windows.Forms.DockStyle.Fill;
      this.richTextBox3.Location = new System.Drawing.Point(329, 33);
      this.richTextBox3.Name = "richTextBox3";
      this.richTextBox3.Size = new System.Drawing.Size(157, 194);
      this.richTextBox3.TabIndex = 8;
      this.richTextBox3.Text = "";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
      this.label4.Location = new System.Drawing.Point(492, 0);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(159, 30);
      this.label4.TabIndex = 9;
      this.label4.Text = "Primos";
      this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // richTextBox4
      // 
      this.richTextBox4.Dock = System.Windows.Forms.DockStyle.Fill;
      this.richTextBox4.Location = new System.Drawing.Point(492, 33);
      this.richTextBox4.Name = "richTextBox4";
      this.richTextBox4.Size = new System.Drawing.Size(159, 194);
      this.richTextBox4.TabIndex = 10;
      this.richTextBox4.Text = "";
      // 
      // btnPrimos
      // 
      this.btnPrimos.Dock = System.Windows.Forms.DockStyle.Fill;
      this.btnPrimos.Location = new System.Drawing.Point(492, 233);
      this.btnPrimos.Name = "btnPrimos";
      this.btnPrimos.Size = new System.Drawing.Size(159, 24);
      this.btnPrimos.TabIndex = 11;
      this.btnPrimos.Text = "Ver";
      this.btnPrimos.UseVisualStyleBackColor = true;
      this.btnPrimos.Click += new System.EventHandler(this.btnPrimos_Click);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(654, 260);
      this.Controls.Add(this.tableLayoutPanel1);
      this.Name = "Form1";
      this.Text = "Series";
      this.tableLayoutPanel1.ResumeLayout(false);
      this.tableLayoutPanel1.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Button btnPares;
    private System.Windows.Forms.Button btnImpares;
    private System.Windows.Forms.Button btnFibonaci;
    private System.Windows.Forms.RichTextBox richTextBox1;
    private System.Windows.Forms.RichTextBox richTextBox2;
    private System.Windows.Forms.RichTextBox richTextBox3;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.RichTextBox richTextBox4;
    private System.Windows.Forms.Button btnPrimos;
  }
}

