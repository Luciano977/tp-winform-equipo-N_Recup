using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
//using System.Windows.Forms;
using dominio;
using System.Net;
using System.ComponentModel;


namespace negocio
{
    public class ArticulosNegocio
    {
        public List<Articulos> listar()

        {
            List<Articulos> lista = new List<Articulos>();
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader Lector;

            try
            {
                conexion.ConnectionString = @"Server=.\SQLEXPRESS;Database=CATALOGO_P3_DB;Integrated Security=True;";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "select A.Codigo, A.Nombre, A.Descripcion, M.Descripcion AS Marca, C.Descripcion as Categoria, A.Precio from ARTICULOS A INNER JOIN MARCAS M ON A.IdMarca = M.Id INNER JOIN CATEGORIAS C ON A.IdCategoria = C.Id;";// la consulta que hago a la base de datos
                comando.Connection = conexion;

                conexion.Open();
                Lector = comando.ExecuteReader();


                while (Lector.Read())
                { 
                    Articulos aux = new Articulos();
                    aux.Codigo = (string)Lector["Codigo"] ;//esta es una forma
                    aux.Nombre = (string)Lector["Nombre"];
                    aux.Descripcion = (string)Lector["Descripcion"];
                    aux.Precio = (decimal)Lector["Precio"];
                    aux.DescMarca = new Marcas();
                    aux.DescMarca.Descripcion = (string)Lector["Marca"];
                    aux.DescCategoria = new Categoria();
                    aux.DescCategoria.Descripcion = (string)Lector["Categoria"];

                                        
                    lista.Add(aux);
                }
                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally {conexion.Close(); }
        }
        public List<Marcas> listarMarcas()
        {
            List<Marcas> Marcas = new List<Marcas>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("SELECT Id, Descripcion FROM MARCAS");
                datos.ejecutarLectura();
                while (datos.Lector.Read())
                {
                    Marcas m = new Marcas();
                    m.Id = (int)datos.Lector["Id"];
                    m.Descripcion = (string)datos.Lector["Descripcion"];
                    Marcas.Add(m);
                }
                return Marcas;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }
        public List<Categoria> listarCategorias()
        {
            List<Categoria> categorias = new List<Categoria>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("SELECT Id, Descripcion FROM CATEGORIAS");
                datos.ejecutarLectura();
                while (datos.Lector.Read())
                {
                    Categoria c = new Categoria();
                    c.Id = (int)datos.Lector["Id"];
                    c.Descripcion = (string)datos.Lector["Descripcion"];
                    categorias.Add(c);
                }
                return categorias;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }
        public void AgregarArt(Articulos nuevo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("insert into ARTICULOS(Codigo, Nombre, Descripcion, Precio, IdMarca, IdCategoria) values('" + nuevo.Codigo + "', '"+nuevo.Nombre+"', '"+nuevo.Descripcion+"', "+nuevo.Precio+", @IdMarca, @IdCategoria)");
                datos.setearParametro("@IdMarca", nuevo.DescMarca.Id);
                datos.setearParametro("@IdCategoria", nuevo.DescCategoria.Id);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

        public void ModifArt(Articulos modificar){


        }

        public void ElimArt(Articulos eliminar)
        {

        }
    }
}
