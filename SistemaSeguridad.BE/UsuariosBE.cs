using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SistemaSeguridad.BE
{
   public class UsuariosBE
    {
        public int CodUsuario { get; set; }
        public string Cedula { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string TelCasa { get; set; }
        public string DirCasa { get; set; }
        public Nullable<int> GrupoSanguineo { get; set; }
        public int CodCargo { get; set; }
        public int CodArea { get; set; }
        public Nullable<int> Extension { get; set; }
        public Nullable<System.DateTime> FechaNacimiento { get; set; }
        public System.DateTime FechaIngreso { get; set; }
        public int CodTipoContrato { get; set; }
        public string EMail { get; set; }
        public string Celular { get; set; }
        public string CodEstado { get; set; }
        public string userNT { get; set; }
        public bool IsLockedOut { get; set; }
        public Nullable<System.DateTime> LastLockedOutDate { get; set; }
        public Nullable<int> FailedPasswordAttemptCount { get; set; }
        public Nullable<System.DateTime> FailedPasswordAttemptWindowStart { get; set; }
        public string PasswordQuestion { get; set; }
        public string PasswordAnswer { get; set; }
        public Nullable<int> FailedPasswordAnswerAttemptCount { get; set; }
        public Nullable<System.DateTime> FailedPasswordAnswerAttemptWindowStart { get; set; }
        public Nullable<int> CodCompania { get; set; }
        public byte[] Foto { get; set; }
        public Nullable<int> idUsuarioIBS { get; set; }
        public virtual ICollection<AplicacionesUsuarioBE> tbAplicacionesUsuario { get; set; }
    }
}
