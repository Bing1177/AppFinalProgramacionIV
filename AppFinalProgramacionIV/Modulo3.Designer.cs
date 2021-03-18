
namespace AppFinalProgramacionIV
{
    partial class Modulo3
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtfrase = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtletra = new System.Windows.Forms.TextBox();
            this.btningresar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Frase:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(120, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "CONTAR UNA LETRA ";
            // 
            // txtfrase
            // 
            this.txtfrase.Location = new System.Drawing.Point(114, 76);
            this.txtfrase.Name = "txtfrase";
            this.txtfrase.Size = new System.Drawing.Size(182, 20);
            this.txtfrase.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Letra a contar:";
            // 
            // txtletra
            // 
            this.txtletra.Location = new System.Drawing.Point(114, 106);
            this.txtletra.Name = "txtletra";
            this.txtletra.Size = new System.Drawing.Size(182, 20);
            this.txtletra.TabIndex = 4;
            // 
            // btningresar
            // 
            this.btningresar.Location = new System.Drawing.Point(75, 162);
            this.btningresar.Name = "btningresar";
            this.btningresar.Size = new System.Drawing.Size(75, 23);
            this.btningresar.TabIndex = 5;
            this.btningresar.Text = "INGRESAR";
            this.btningresar.UseVisualStyleBackColor = true;
            this.btningresar.Click += new System.EventHandler(this.btningresar_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(191, 162);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "REGRESAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Modulo3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(362, 209);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btningresar);
            this.Controls.Add(this.txtletra);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtfrase);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Modulo3";
            this.Text = "Modulo3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtfrase;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtletra;
        private System.Windows.Forms.Button btningresar;
        private System.Windows.Forms.Button button1;
    }
}