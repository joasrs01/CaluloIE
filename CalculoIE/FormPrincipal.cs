using System;
using System.Drawing;
using System.Windows.Forms;

namespace CalculoIE
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Validacao();
        }

        public void Validacao()
        {
            try
            {
                int IE = int.Parse(tbIE.Text);

                CalcularIE cIE = new CalcularIE();

                int situacao = cIE.Calculo(tbIE.Text);

                switch (situacao)
                {
                    case 1:

                        tbSituacao.Text = "IE não pertencente a UF do Amapá";
                        tbSituacao.ForeColor = Color.Red;

                        break;
                    case 2:

                        tbSituacao.Text = "IE válida";
                        tbSituacao.ForeColor = Color.Green;

                        break;
                    case 3:

                        tbSituacao.Text = "IE inválida";
                        tbSituacao.ForeColor = Color.Red;

                        break;
                }

            }catch(Exception e)
            {
                MessageBox.Show("Numero inválido", "Numero inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
