using Microsoft.EntityFrameworkCore;
using System;
using Microsoft.EntityFrameworkCore.SqlServer;

namespace LeerData
{
    class Program
    {
        static void Main(string[] args)
        {
            //Leyendo todos los libros
            /*using(var db = new AppVentaLibrosContext())
            {
                var libros = db.Libro.AsNoTracking();

                foreach (var libro in libros)
                {
                    Console.WriteLine(libro.Titulo + " --- "+ libro.Descripcion);
                }
            }*/

            //Leyendo todos los libros y su relación con Precio
            /*using (var db = new AppVentaLibrosContext())
            {
                var libros = db.Libro.Include(x => x.PrecioPromocion).AsNoTracking();

                foreach (var libro in libros)
                {
                    Console.WriteLine(libro.Titulo + " --- " + libro.PrecioPromocion.PrecioActual);
                }
            }*/


            //Leyendo libros y revisando comentarios
            /*using (var db = new AppVentaLibrosContext())
            {
                var libros = db.Libro.Include(x => x.ComentarioLista).AsNoTracking();

                foreach (var libro in libros)
                {
                    Console.WriteLine(libro.Titulo);
                    foreach (var comentario in libro.ComentarioLista)
                    {
                        Console.WriteLine("-----" + comentario.ComentarioTexto);
                    }
                }
            }*/

            //Mostrar Libro y sus autores
            /*using (var db = new AppVentaLibrosContext())
            {
                var libros = db.Libro.Include(x => x.AutorLink).ThenInclude(xi => xi.Autor);

                foreach (var libro in libros)
                {
                    Console.WriteLine(libro.Titulo + " --- " + libro.Descripcion);
                    foreach (var autLink in libro.AutorLink)
                    {
                        Console.WriteLine("----" + autLink.Autor.Nombre + " " + autLink.Autor.Apellidos);
                    }
                }
            }*/

            //INSERTAR UN NUEVO REGISTRO
            /*using (var db = new AppVentaLibrosContext())
            {
                var nuevoAutor = new Autor
                {
                    Nombre = "Lorenzo",
                    Apellidos = "Lopez",
                    Grado = "Master"
                };

                db.Add(nuevoAutor);
                var estadoTransaccion = db.SaveChanges();
                Console.WriteLine("Estado de Transaccion ===> " + estadoTransaccion);//Debería devolver 1 ya que solo inserta un autor
            }*/

            //ACTUALIZAR UN REGISTRO 
            /*using (var db = new AppVentaLibrosContext())
            {
                var autor = db.Autor.Single(p => p.Nombre == "Lorenzo");
                if(autor != null)
                {
                    autor.Apellidos = "Villar";
                    autor.Grado = "Científico";
                }
                var estado=db.SaveChanges();
                Console.WriteLine("Estado de Transaccion ===> " + estado);
            }*/

            //ELIMINAR UN REGISTRO 
            using (var db = new AppVentaLibrosContext())
            {
                var autor = db.Autor.Single(p => p.Apellidos == "Villar");
                if(autor != null)
                {
                    db.Remove(autor);
                    var estado = db.SaveChanges();
                    Console.WriteLine("Estado de Transaccion ===> " + estado);
                }
                
            }

        }
    }
}