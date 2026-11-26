using check_in_WinForms;
using System;
using System.Collections.Generic;
using System.IO;
using System.Web.Script.Serialization;

namespace check_in_Winforms
{
    public class PacienteRepositorio
    {
        private readonly string caminhoArquivo =
            Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "pacientes.json");

        public List<Paciente> Listar()
        {
            if (!File.Exists(caminhoArquivo))
            {
                return new List<Paciente>();
            }

            string json = File.ReadAllText(caminhoArquivo);

            JavaScriptSerializer serializer = new JavaScriptSerializer();

            return serializer.Deserialize<List<Paciente>>(json)
                   ?? new List<Paciente>();
        }

        public void Salvar(List<Paciente> pacientes)
        {
            JavaScriptSerializer serializer = new JavaScriptSerializer();

            string json = serializer.Serialize(pacientes);

            File.WriteAllText(caminhoArquivo, json);
        }

        public void Adicionar(Paciente paciente)
        {
            List<Paciente> pacientes = Listar();

            pacientes.Add(paciente);

            Salvar(pacientes);
        }

        public void Excluir(int codigo)
        {
            List<Paciente> pacientes = Listar();

            pacientes.RemoveAll(p => p.Codigo == codigo);

            Salvar(pacientes);
        }
    }
}