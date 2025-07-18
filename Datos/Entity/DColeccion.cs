﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Datos.Entity
{
    public class DColeccion
    {
        public String Registrar(Coleccion coleccion)
        {
            try
            {
                using (var context = new BDFEntities())
                {
                    context.Coleccion.Add(coleccion);
                    context.SaveChanges();
                }
                return "Registrado correctamente";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public String Modificar(Coleccion coleccion)
        {
            try
            {
                using (var context = new BDFEntities())
                {
                    Coleccion coleccionTemp = context.Coleccion.FirstOrDefault(c=>c.Codigo.Equals(coleccion.Codigo));
                    coleccionTemp.Nombre = coleccion.Nombre;
                    coleccionTemp.Descripcion = coleccion.Descripcion;
                    context.SaveChanges();
                }
                return "Modificado correctamente";
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }
        public String EliminarFisico(string codigoColeccion)
        {
            try
            {
                using (var context = new BDFEntities())
                {
                    Coleccion coleccionTemp = context.Coleccion.FirstOrDefault(c => c.Codigo.Equals(codigoColeccion));
                    context.Coleccion.Remove(coleccionTemp);
                    context.SaveChanges();
                }
                return "Colección eliminada físicamente";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public String EliminarLogico(string codigoColeccion)
        {
            try
            {
                using (var context = new BDFEntities())
                {
                    Coleccion coleccionTemp = context.Coleccion.FirstOrDefault(c => c.Codigo.Equals(codigoColeccion));
                    coleccionTemp.Estado = 0;
                    context.SaveChanges();
                }
                return "Colección eliminada lógicamente";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public List<Coleccion> ListarColecciones()
        {
            List<Coleccion> colecciones = new List<Coleccion>();
            try
            {
                using (var context = new BDFEntities())
                {
                    return context.Coleccion.Include(c => c.Usuario).ToList();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        public bool ExisteColeccion(string codigoColeccion)
        {
            try
            {
                using (var context = new BDFEntities())
                {
                    return context.Coleccion.Any(u => u.Codigo.Equals(codigoColeccion));

                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
