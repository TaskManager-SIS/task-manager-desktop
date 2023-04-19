using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using TaskManager.Entidades;
using Newtonsoft.Json.Linq;

namespace TaskManager.Forms
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
        }

        private void autenticar()
        {
            var url = "https://www.taskmanager.targetbr.biz/index.php/usuario/buscar-pelo-email-e-senha";
            var email = txtEmail.Text;
            var senha = txtSenha.Text;
            //var confirmPassword = password;
            //var urlbase = _urlBase + "autoriza/login";

            using (var client = new HttpClient())
            {
                string conteudo = "";

                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(
                    new MediaTypeWithQualityHeaderValue("application/json"));

                try
                {
                    HttpResponseMessage respToken =
                        client.PostAsync(url, new StringContent(
                            JsonConvert.SerializeObject(new
                            {
                                email,
                                senha,
                                //confirmPassword
                            }))).Result;

                    conteudo = respToken.Content.ReadAsStringAsync().Result;
                    //btnProdutos.Enabled = true;
                    //MessageBox.Show(conteudo.ToString());
                    if (respToken.StatusCode == HttpStatusCode.OK)
                    {
                        var usuario = JsonConvert.DeserializeObject<Usuarios>(conteudo);
                        MessageBox.Show(respToken.ToString());

                        JObject json = JObject.Parse(conteudo);
                        //MessageBox.Show(json["msg"].ToString());
                        JToken token = json["dados"];
                        if(token.Type != JTokenType.Null)
                        {
                            MessageBox.Show("entrou");

                            // abrir menu e fechar login
                            this.Hide();
                            var FrmMenu = new FrmMenu();
                            FrmMenu.Closed += (s, args) => this.Close();
                            FrmMenu.Show();
                        }
                        else
                        {
                            MessageBox.Show(json["msg"].ToString());
                            MessageBox.Show("else");
                        }
                        //var teste = (JArray)json["dados"].ToString();
                        //if (teste == null)
                        //    MessageBox.Show("null");
                        //else
                        //    MessageBox.Show("n null");
                        //dgvTarefas.DataSource = tarefas.ToObject<List<Tarefas>>();





                        //if (accessToken.Authenticated)
                        //{
                        //    Associar o token aos headers do objeto
                        //     do tipo HttpClient
                        //    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer",
                        //    accessToken.Token);

                        //    MessageBox.Show($"token JWT Autenticado ");
                        //}
                        //else
                        //{
                        //    MessageBox.Show("Falha na autenticação");
                        //}
                    }
                    else
                    {
                        MessageBox.Show(respToken.ToString());
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro " + ex.Message);
                }
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            autenticar();
        }

        private void txtEmail_Enter(object sender, EventArgs e)
        {
            if (txtEmail.Text == "Inserir seu e-mail")
                txtEmail.Text = "";
        }

        private void txtSenha_Enter(object sender, EventArgs e)
        {
            txtSenha.Text = "";
        }

        private void txtSenha_Leave(object sender, EventArgs e)
        {

        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (txtEmail.Text == "")
                txtEmail.Text = "Inserir seu e-mail";
        }

        private void lblLoginInexistente_Click(object sender, EventArgs e)
        {
            //var frm = new FrmCadUsuario();
            //frm.ShowDialog();
            this.Hide();
            var frm = new FrmCadUsuario();
            frm.Closed += (s, args) => this.Close();
            frm.Show();
        }
    }
}
