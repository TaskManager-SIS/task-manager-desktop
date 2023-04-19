using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TaskManager.Entidades
{
    public class Tarefas
    {
        public int id { get; set; }
        public string titulo { get; set; }
        public string descricao { get; set; }
        public DateTime dataCadastro { get; set; }
        public string status { get; set; }
        public bool concluido
        {
            get
            {
                return status == "Concluido";
            }
        }
    }
}
