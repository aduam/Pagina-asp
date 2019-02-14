using ProgramaAcademico.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProgramaAcademico.Data
{
    public class DbInitializer
    {
        public static void Initialize(ProgramaAcademicoContext context)
        {
            context.Database.EnsureCreated();

            //Buscar si existen registros en la tabla categoría
            if(context.Categoria.Any())
            {
                return;
            }
            else
            {
                var categorias = new Categoria[]
                {
                    new Categoria{ Nombres="Alan Jackson", Apellidos="Duarte Marroquín", Descripcion="The Father", Estado=true },
                    new Categoria{ Nombres="Denise Asunción", Apellidos="Duarte Castro", Descripcion="The daugther", Estado=true }
                };

                foreach(Categoria c in categorias)
                {
                    context.Categoria.Add(c);
                }
                context.SaveChanges();
            }
        }
    }
}
