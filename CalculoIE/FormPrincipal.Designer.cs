
namespace CalculoIE
{
    partial class FormPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtInf = new System.Windows.Forms.Label();
            this.txtIE = new System.Windows.Forms.Label();
            this.tbIE = new System.Windows.Forms.TextBox();
            this.txtREsult = new System.Windows.Forms.Label();
            this.tbSituacao = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtInf
            // 
            this.txtInf.AutoSize = true;
            this.txtInf.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtInf.Location = new System.Drawing.Point(255, 52);
            this.txtInf.Name = "txtInf";
            this.txtInf.Size = new System.Drawing.Size(334, 25);
            this.txtInf.TabIndex = 0;
            this.txtInf.Text = "Validação de IE do estado do Amapá";
            // 
            // txtIE
            // 
            this.txtIE.AutoSize = true;
            this.txtIE.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtIE.Location = new System.Drawing.Point(104, 194);
            this.txtIE.Name = "txtIE";
            this.txtIE.Size = new System.Drawing.Size(96, 21);
            this.txtIE.TabIndex = 1;
            this.txtIE.Text = "Informe a IE:";
            // 
            // tbIE
            // 
            this.tbIE.Location = new System.Drawing.Point(238, 192);
            this.tbIE.MaxLength = 9;
            this.tbIE.Name = "tbIE";
            this.tbIE.Size = new System.Drawing.Size(332, 23);
            this.tbIE.TabIndex = 2;
            // 
            // txtREsult
            // 
            this.txtREsult.AutoSize = true;
            this.txtREsult.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtREsult.Location = new System.Drawing.Point(28, 283);
            this.txtREsult.Name = "txtREsult";
            this.txtREsult.Size = new System.Drawing.Size(172, 21);
            this.txtREsult.TabIndex = 3;
            this.txtREsult.Text = "Resultado da validação:";
            // 
            // tbSituacao
            // 
            this.tbSituacao.BackColor = System.Drawing.SystemColors.MenuBar;
            this.tbSituacao.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbSituacao.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbSituacao.Location = new System.Drawing.Point(238, 283);
            this.tbSituacao.Name = "tbSituacao";
            this.tbSituacao.ReadOnly = true;
            this.tbSituacao.Size = new System.Drawing.Size(332, 22);
            this.tbSituacao.TabIndex = 4;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCalcular.Location = new System.Drawing.Point(562, 390);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(214, 38);
            this.btnCalcular.TabIndex = 5;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.tbSituacao);
            this.Controls.Add(this.txtREsult);
            this.Controls.Add(this.tbIE);
            this.Controls.Add(this.txtIE);
            this.Controls.Add(this.txtInf);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtInf;
        private System.Windows.Forms.Label txtIE;
        private System.Windows.Forms.TextBox tbIE;
        private System.Windows.Forms.Label txtREsult;
        private System.Windows.Forms.TextBox tbSituacao;
        private System.Windows.Forms.Button btnCalcular;
    }
}

