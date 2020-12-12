using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiPos.Models
{
    public class Usuario
    {
        private int id;
        private string nombre;
        private string email;
        private string usuario;
        private string password; 
        private int tipoUsuarioId;
        private bool activo;

        public Usuario(int id, string nombre, string email, string usuario, string password, int tipoUsuarioId, bool activo)
        {
            this.id = id;
            this.nombre = nombre;
            this.email = email;
            this.usuario = usuario;
            this.password = password;
            this.tipoUsuarioId = tipoUsuarioId;
            this.activo = activo;
        }

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Email { get => email; set => email = value; }
        public string NombreUsuario { get => usuario; set => usuario = value; }
        public string Password { get => password; set => password = value; }
        public int TipoUsuarioId { get => tipoUsuarioId; set => tipoUsuarioId = value; }
        public bool Activo { get => activo; set => activo = value; }
    }
}
