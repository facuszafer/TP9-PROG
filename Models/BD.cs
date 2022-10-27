using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using Dapper;

namespace TP9
{
    
    public static class BD
    {
<<<<<<< HEAD
        private static string _connectionString = @"Server=A-PHZ2-CIDI-042;DataBase=TP9;Trusted_Connection=True;";
=======
        private static string _connectionString = @"Server=A-PHZ2-CIDI-041;DataBase=TP9;Trusted_Connection=True;";
>>>>>>> f7038532a244f376d21ce8dc2a749f8150fd09d1

        public static int agregarRopa(ropa rop)
        {
            int nuevaRopa = 0;
            
            using(SqlConnection DB = new SqlConnection(_connectionString))
            {
                string sql = "INSERT INTO ropa(Nombre, precio, descripcion, Foto, IdMarca) values(pNombre, pprecio, pdescripcion, pFoto, pIdMarca)";
                nuevaRopa=DB.Execute(sql, new {pNombre = rop.Nombre, pprecio = rop.precio, pdescripcion = rop.descripcion, pFoto = rop.Foto, pIdMarca = rop.IdMarca});
            }
            return nuevaRopa;
            
        }

        
        public static int EliminarPrenda(int IdRop)
        {
            int ropaEliminada = 0;
            
            using(SqlConnection DB = new SqlConnection(_connectionString))
            {
                string sql = "DELETE from ropa WHERE IdRopa = pIdRop";
                ropaEliminada = DB.Execute(sql, new {pIdRop = IdRop});
            }
            return ropaEliminada;
        }

         private static List<marca>_ListadoMarcas = new List<marca>();

        public static List<marca> ListarMarcas()
        {

            
             using(SqlConnection DB = new SqlConnection(_connectionString))
             {
                 string sql = "SELECT * FROM marca";
                 _ListadoMarcas = DB.Query<marca>(sql).ToList();
             }
             return _ListadoMarcas;
        }

        public static marca ListarMarca(int IdMarca)
        {

            marca UnaMarca=null;
             using(SqlConnection DB = new SqlConnection(_connectionString))
             {
                 string sql = "SELECT * FROM marca WHERE IdMarca=@pMarca";
                 UnaMarca = DB.QueryFirstOrDefault<marca>(sql,new {pMarca = IdMarca});
             }
             return UnaMarca;
        }
        
        private static List<ropa>_ListadoRopa = new List<ropa>();    
         public static List<ropa> ListarRopar( int IdMarca) 
        {
            
             using(SqlConnection DB = new SqlConnection(_connectionString))
             {
                 string sql = "SELECT * FROM ropa WHERE IdMarca = @pIdMarca";
                 _ListadoRopa = DB.Query<ropa>(sql, new {pIdMarca = IdMarca}).ToList();
             }
             return _ListadoRopa;
        }
    


    
    
    }
}
