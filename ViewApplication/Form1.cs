﻿using Biblioteca.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ViewApplication
{
    public partial class Form1 : Form
    {
        public ConexaoSQL conn;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ConexaoSQL conn = new ConexaoSQL();
                conn.abrirConexao();
                MessageBox.Show("Conectado!");
                conn.fecharConexao();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

        }
    }
}
