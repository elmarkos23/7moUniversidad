
namespace ProyectoLab5
{
  partial class Form2
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
      this.richTextBox1 = new System.Windows.Forms.RichTextBox();
      this.richTextBox2 = new System.Windows.Forms.RichTextBox();
      this.richTextBox3 = new System.Windows.Forms.RichTextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // richTextBox1
      // 
      this.richTextBox1.Location = new System.Drawing.Point(32, 31);
      this.richTextBox1.Name = "richTextBox1";
      this.richTextBox1.Size = new System.Drawing.Size(176, 307);
      this.richTextBox1.TabIndex = 0;
      this.richTextBox1.Text = "";
      // 
      // richTextBox2
      // 
      this.richTextBox2.Location = new System.Drawing.Point(235, 31);
      this.richTextBox2.Name = "richTextBox2";
      this.richTextBox2.Size = new System.Drawing.Size(176, 307);
      this.richTextBox2.TabIndex = 1;
      this.richTextBox2.Text = "";
      // 
      // richTextBox3
      // 
      this.richTextBox3.Location = new System.Drawing.Point(433, 31);
      this.richTextBox3.Name = "richTextBox3";
      this.richTextBox3.Size = new System.Drawing.Size(176, 307);
      this.richTextBox3.TabIndex = 2;
      this.richTextBox3.Text = "";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(99, 3);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(25, 24);
      this.label1.TabIndex = 3;
      this.label1.Text = "X";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label2.Location = new System.Drawing.Point(311, 4);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(40, 24);
      this.label2.TabIndex = 4;
      this.label2.Text = "Y 1";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label3.Location = new System.Drawing.Point(522, 3);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(40, 24);
      this.label3.TabIndex = 5;
      this.label3.Text = "Y 2";
      // 
      // Form2
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(621, 368);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.richTextBox3);
      this.Controls.Add(this.richTextBox2);
      this.Controls.Add(this.richTextBox1);
      this.Name = "Form2";
      this.Text = "Form2";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    public System.Windows.Forms.RichTextBox richTextBox1;
    public System.Windows.Forms.RichTextBox richTextBox2;
    public System.Windows.Forms.RichTextBox richTextBox3;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
  }
}