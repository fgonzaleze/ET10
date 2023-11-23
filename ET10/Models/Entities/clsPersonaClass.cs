﻿namespace ET10.Models.Entities
{
        internal class clsPersona
        {
        #region atributos
        private int id;
        private string nombre;
        private string apellidos;
        private string telefono;
        private string direccion;
        private string foto;
        private DateTime fechaNac;
        private int idDepartamento;
            
            #endregion

            #region constructores
            public clsPersona() { }

            public clsPersona(int id, string nombre, string apellidos, string telefono, string foto, DateTime fechaNac, int idDepartamento)
            {
                this.id = id;
                this.nombre = nombre;
                this.apellidos = apellidos;
                this.telefono = telefono;
                this.foto = foto;
                this.fechaNac = fechaNac;
                this.idDepartamento = idDepartamento;
            }
            #endregion

            #region propiedades
            public int Id
            {
                get { return id; }
                set { id = value; }
            }
            public string Nombre
            {
                get { return nombre; }
                set { nombre = value; }
            }
            public string Apellidos
            {
                get { return apellidos; }
                set { apellidos = value; }
            }
            public string Telefono
                


            
            #endregion

        }
    }

