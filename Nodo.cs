﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaUnimar
{
    public class Nodo
    {
        // Atributos de la clase Nodo 
        private Estudiante valorEs;
        private Libro valorLib;
        private Prestamo valorPr;
        private Nodo siguiente;

        // Método Constructor para usar con la lista de estudiantes
        public Nodo(Estudiante valorEs)
        {
            this.valorEs = valorEs;
            this.valorLib = null;
            this.valorPr = null;
            this.siguiente = null;
        }

        // Método Constructor para usar con la lista de libros
        public Nodo(Libro valorLib)
        {
            this.valorLib = valorLib;
            this.valorEs = null;
            this.valorPr = null;
            this.siguiente = null;
        }

        // Método Constructor para usar con la lista de préstamos
        public Nodo(Prestamo valorPr)
        {
            this.valorPr = valorPr;
            this.valorEs = null;
            this.valorLib = null;
            this.siguiente = null;
        }

        // Métodos Getters
        public Estudiante getValor()
        {
            return valorEs;
        }

        public Libro getValorLib()
        {
            return valorLib;
        }

        public Prestamo getValorPr()
        {
            return valorPr;
        }

        public Nodo getSiguiente()
        {
            return siguiente;
        }

        // Métodos Setters
        public void setValor(Estudiante valorEs)
        {
            this.valorEs = valorEs;
        }

        public void setValorLib(Libro valorLib)
        {
            this.valorLib = valorLib;
        }

        public void setValorPr(Prestamo valorPr)
        {
            this.valorPr = valorPr;
        }

        public void setSiguiente(Nodo siguiente)
        {
            this.siguiente = siguiente;
        }
    }
}
