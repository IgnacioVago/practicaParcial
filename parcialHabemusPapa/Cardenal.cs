﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parcialHabemusPapa
{
    public class Cardenal
    {
        private int _cantVotosRecibidos;
        private ENacionalidades _nacionalidad;
        private string _nombre;
        private string _nombrePapal;

        public Cardenal()
        {
            this._cantVotosRecibidos = 0;
        }

        public Cardenal(string nombre, string nombrePapal)
            : this()
        {
            this._nombre = nombre;
            this._nombrePapal = nombrePapal;
        }

        public Cardenal(string nombre, string nombrePapal, ENacionalidades nacionalidad)
            : this(nombre, nombrePapal)
        {
            this._nacionalidad = nacionalidad;
        }

        public static bool operator ==(Cardenal c1, Cardenal c2)
        {
            if (String.Compare(c1._nombre, c2._nombre) == 0)
            {
                if (String.Compare(c1._nombrePapal, c2._nombrePapal) == 0)
                {
                    if (c1._nacionalidad == c2._nacionalidad)
                        return true;
                }
            }
            return false;
        }

        public static bool operator !=(Cardenal c1, Cardenal c2)
        {
            return !(c1 == c2);
        }

        public static Cardenal operator ++(Cardenal c)
        {
            c._cantVotosRecibidos++;
            return c;
        }

        public int getCantidadVotosRecibidos()
        {
            return this._cantVotosRecibidos;
        }

        public string ObtenerNombreYNombrePapal()
        {
            return ("El cardenal " + this._nombre + " se llamará “Papa " + this._nombrePapal + "”");
        }

        private string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(this.ObtenerNombreYNombrePapal());
            sb.AppendLine("Nacionalidad: " + this._nacionalidad.ToString());
            sb.AppendLine("Votos recibidos: " + this.getCantidadVotosRecibidos());

            return sb.ToString();
        }

        public static string Mostrar(Cardenal c)
        {
            return c.Mostrar();
        }

    }
}
