using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace check_in_WinForms
{
    public class Paciente
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Especialidade { get; set; }
        public string Medico { get; set; }
        public DateTime DataCheckin { get; set; }
        public string status { get; set; }

    }


}
