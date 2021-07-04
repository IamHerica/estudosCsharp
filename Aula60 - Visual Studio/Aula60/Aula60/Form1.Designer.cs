
namespace Aula60
{
    partial class Iniciando
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
            this.btn_teste = new System.Windows.Forms.Button();
            this.lbl_youtube = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_teste
            // 
            this.btn_teste.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_teste.Font = new System.Drawing.Font("Mongolian Baiti", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_teste.ForeColor = System.Drawing.Color.Maroon;
            this.btn_teste.Location = new System.Drawing.Point(312, 382);
            this.btn_teste.Name = "btn_teste";
            this.btn_teste.Size = new System.Drawing.Size(119, 23);
            this.btn_teste.TabIndex = 0;
            this.btn_teste.Text = "opa, to testando";
            this.btn_teste.UseVisualStyleBackColor = false;
            this.btn_teste.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_youtube
            // 
            this.lbl_youtube.AutoSize = true;
            this.lbl_youtube.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_youtube.ForeColor = System.Drawing.Color.DarkRed;
            this.lbl_youtube.Location = new System.Drawing.Point(308, 33);
            this.lbl_youtube.Name = "lbl_youtube";
            this.lbl_youtube.Size = new System.Drawing.Size(100, 20);
            this.lbl_youtube.TabIndex = 1;
            this.lbl_youtube.Text = "youtube.com";
            this.lbl_youtube.Click += new System.EventHandler(this.label1_Click);
            // 
            // Iniciando
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_youtube);
            this.Controls.Add(this.btn_teste);
            this.Name = "Iniciando";
            this.Text = "Curso C# (CFB cursos)";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_teste;
        private System.Windows.Forms.Label lbl_youtube;
    }
}

