﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjAcademiaTB
{
    public partial class formFichaAluno : Form
    {
        internal Aluno Registro { get; set; }
        
        public formFichaAluno()
        {
            InitializeComponent();
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            if (Registro == null) novo();
            else editar();
            this.Dispose();
        }

        private void editar()
        {
            Registro.id = Int32.Parse(txtId.Text);
            Registro.Nome = txtNome.Text;
            Registro.Idade = Int16.Parse(txtIdade.Text);
            Registro.Peso = Double.Parse(txtPeso.Text);
            Registro.Altura = Double.Parse(txtAltura.Text);
            MessageBox.Show("Cadastrado com sucesso");
        }

        private void novo()
        {
            Registro = new Aluno(
               Int32.Parse(txtId.Text),
               txtNome.Text,
               Int16.Parse(txtIdade.Text),
               Double.Parse(txtPeso.Text),
               Double.Parse(txtAltura.Text));
            MessageBox.Show("Cadastrado com sucesso");     
        }

        private void formFichaAluno_Load(object sender, EventArgs e)
        {
            if (Registro != null)
            {
                txtId.Text = Registro.id.ToString();
                txtNome.Text = Registro.Nome;
                txtIdade.Text = Registro.Idade.ToString();
                txtPeso.Text = Registro.Peso.ToString();
                txtAltura.Text = Registro.Altura.ToString();
                txtId.ReadOnly = true;
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Registro = null;
            this.Dispose();
        }

 
        }

}
