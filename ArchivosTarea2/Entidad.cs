﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArchivosTarea2
{
    public class Entidad
    {
        public char[] nombre = { '\0', '\0', '\0', '\0', '\0', '\0', '\0', '\0', '\0', '\0', '\0', '\0', '\0', '\0', '\0', '\0',  
                                    '\0', '\0', '\0', '\0', '\0', '\0', '\0', '\0', '\0', '\0', '\0', '\0' ,'\0' ,'\n'};
        public long apAtributos = -1;
        public long apDatos = -1;
        public long posEntidad = 0;
        public long apSigEntidad = -1;
        public List<Atributo> listaAtributos = new List<Atributo>();
        public List<Dato> listaDatos = new List<Dato>();

        public Entidad(String n)
        {
            for (int i = 0; i < n.Length; i++ )
            {
                nombre[i] = n[i];
            }
        }

        public Entidad(char[] n, long apAt, long apDat, long posIn, long posSigEnt)
        {
            nombre = n;
            apAtributos = apAt;
            apDatos = apDat;
            posEntidad = posIn;
            apSigEntidad = posSigEnt;
        }

        public Entidad()
        {

        }
    }
}