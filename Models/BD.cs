using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using Dapper;

namespace TP9
{
    
    public static class BD
    {
        private static string _connectionString = @"Server=A-PHZ2-CIDI-019;DataBase=TP9;Trusted_Connection=True;";

        public static int agregarRopa(ropa rop)
        {
            int nuevaRopa = 0;
            
            using(SqlConnection DB = new SqlConnection(_connectionString))
            {
                string sql = "INSERT INTO ropa(Nombre, precio, Foto, IdMarca) values(pNombre, pprecio, Foto, pIdMarca)";
                nuevaRopa=DB.Execute(sql, new {pNombre = rop.Nombre, pPrecio = rop.precio, pFoto = rop.Foto, pIdMarca = rop.IdMarca});
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
