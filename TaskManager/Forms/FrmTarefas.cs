using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
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

namespace TaskManager.Forms
{
    public partial class FrmTarefas : Form
    {
        private Form activeForm;
        public FrmTarefas()
        {
            InitializeComponent();
        }

        private async void FrmTarefas_Load(object sender, EventArgs e)
        {
            string URI = "https://www.taskmanager.targetbr.biz/index.php/tarefa";
            using (var client = new HttpClient())
            {
                using (var response = await client.GetAsync(URI))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        var ProdutoJsonString = await response.Content.ReadAsStringAsync();
                        JObject json = JObject.Parse(ProdutoJsonString);
                        JArray tarefas = (JArray)json["dados"];
                        dgvTarefas.DataSource = tarefas.ToObject<List<Tarefas>>();
                    }
                    else
                    {
                        MessageBox.Show("Não foi possível obter o produto : " + response.StatusCode);
                    }
                }
            }
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FrmAddTarefa(), sender);
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            var frmMenu = this.ParentForm;
            if (activeForm != null)
                activeForm.Close();
            //ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            frmMenu.Controls.Add(childForm);
            frmMenu.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            //lblTitle.Text = childForm.Text;
        }

        private void dgvTarefas_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                dgvTarefas.Rows[e.RowIndex].DefaultCellStyle.BackColor = SystemColors.InactiveCaption;
            }

        }

        private void dgvTarefas_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                dgvTarefas.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
            }
                
        }

        private void dgvTarefas_SelectionChanged(object sender, EventArgs e)
        {
            dgvTarefas.ClearSelection();
        }

        private void dgvTarefas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvTarefas.CurrentRow.Cells["completed"].Value = !Convert.ToBoolean(dgvTarefas.CurrentRow.Cells["completed"].Value);
        }
    }
}
