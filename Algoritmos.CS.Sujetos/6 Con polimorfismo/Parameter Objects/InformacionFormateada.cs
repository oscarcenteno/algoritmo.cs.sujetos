﻿namespace ConPolimorfismo
{
    public abstract class InformacionFormateada : InformacionDelSolicitante
    {
        public string ApellidosFormateados
        {
            get
            {
                return new ApellidosFormateados(this).ComoTexto();
            }
        }

        public abstract string Proposito { get; }

        public abstract string OU { get; }

        public abstract string SerialNumber { get; }

        public string GivenName
        {
            get
            {
                return $"GivenName={NombreEnMayuscula}";
            }
        }

        public string SurName
        {
            get
            {
                return $"Surname={ApellidosFormateados}";
            }
        }
    }
}