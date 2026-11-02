using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace GestorTareasApp
{
    public class Tarea 
    {
        private string _titulo;
        private bool _completada;

        public string Titulo
        {
            get => _titulo;
            set
            {
                _titulo = value;
                
            }
        }

        public bool Completada
        {
            get => _completada;
            set
            {
                _completada = value;
                
            }
        }


    }
}
