﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFInicial
{
    public partial class FormEx4 : Form
    {
        public FormEx4()
        {
            InitializeComponent();
        }

        private void btnMaior_Click(object sender, EventArgs e)
        {

            int num1 = int.Parse(txtNum1.Text);
            int num2 = int.Parse(txtNum2.Text);
            int num3 = int.Parse(txtNum3.Text);

            int maior = Math.Max(Math.Max(num1, num2),num3);

            string mensagem = $"O número {maior} é o maior número.";

            MessageBox.Show(mensagem, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
