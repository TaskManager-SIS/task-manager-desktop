using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaskManager.Entidades;
using static System.Net.WebRequestMethods;

namespace TaskManager.Forms
{
    public partial class FrmCadUsuario : Form
    {

        public FrmCadUsuario()
        {
            InitializeComponent();
        }

        private void FrmCadUsuario_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void lblLoginExistente_Click(object sender, EventArgs e)
        {
            this.Hide();
            var frm = new FrmLogin();
            frm.Closed += (s, args) => this.Close();
            frm.Show();
        }

        private async void AddUsuario()
        {
            var URI = "https://www.taskmanager.targetbr.biz/index.php/usuario";
            var usuario = new Usuarios();
            usuario.nome = "Thiago";
            usuario.email = "thiago@email.com";
            usuario.senha = "Notebooks";
            using (var client = new HttpClient())
            {
                var serializedProduto = JsonConvert.SerializeObject(usuario);
                var content = new StringContent(serializedProduto, Encoding.UTF8, "application/json");
                var result = await client.PostAsync(URI, content);
            }
            //GetAllProdutos();
        }

        private void btnCriarConta_Click(object sender, EventArgs e)
        {
            AddUsuario();
        }
    }
}
