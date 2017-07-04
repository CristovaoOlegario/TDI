﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio3._3
{
    public partial class FormSaque : Form
    {

        public FormSaque()
        {
            InitializeComponent();
        }

        private void btnSacar_Click(object sender, EventArgs e)
        {
            if (txtSaque.Text == "")
            {
                MessageBox.Show("Digite um valor antes de sacar!", "OPA!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                double valor = double.Parse(txtSaque.Text);
                if (Form1.saldo >= valor)
                {
                    Form1.saldo -= valor;
                    MessageBox.Show("Saque realizado com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Saldo indisponível!", "OPA!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                this.Close();
            }
        }
    }
}
