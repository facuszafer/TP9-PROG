using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using Dapper;

namespace TP9
{

    public static class BD
    {
        private static string _connectionString = @"Server=A-PHZ2-CIDI-007;DataBase=TP9;Trusted_Connection=True;";

        public static int agregarRopa(ropa rop)
        {
            int nuevaRopa = 0;

            using (SqlConnection DB = new SqlConnection(_connectionString))
            {
                string sql = "INSERT INTO ropa(Nombre, precio, descripcion, Foto, IdMarca) values(@pNombre, @pprecio, @pdescripcion, @pFoto, @pIdMarca)";
                nuevaRopa = DB.Execute(sql, new { pNombre = rop.Nombre, pprecio = rop.precio, pdescripcion = rop.descripcion, pFoto = rop.Foto, pIdMarca = rop.IdMarca });
            }
            return nuevaRopa;

        }

        public static int AgregarMeGusta(int IdRopa)
        {
            int nuevaRopa = 0;
            using (SqlConnection DB = new SqlConnection(_connectionString))
            {
                string sql = "UPDATE ropa SET CantLikes=CantLikes+1 WHERE IdRopa=@pIdRopa";
                nuevaRopa = DB.Execute(sql, new { pIdRopa = IdRopa });
            }
            ropa UnaRopa = ListarRopa(IdRopa);
            return UnaRopa.cantLikes;
        }

        public static ropa ListarRopa(int IdRopa)
        {

            ropa UnaRopa = null;
            using (SqlConnection DB = new SqlConnection(_connectionString))
            {
                string sql = "SELECT * FROM ropa WHERE IdRopa=@pRopa";
                UnaRopa = DB.QueryFirstOrDefault<ropa>(sql, new { pRopa = IdRopa });
            }
            return UnaRopa;
        }


        public static int EliminarPrenda(int IdRop)
        {
            int ropaEliminada = 0;

            using (SqlConnection DB = new SqlConnection(_connectionString))
            {
                string sql = "DELETE from ropa WHERE IdRopa = pIdRop";
                ropaEliminada = DB.Execute(sql, new { pIdRop = IdRop });
            }
            return ropaEliminada;
        }

        private static List<marca> _ListadoMarcas = new List<marca>();

        public static List<marca> ListarMarcas()
        {


            using (SqlConnection DB = new SqlConnection(_connectionString))
            {
                string sql = "SELECT * FROM marca";
                _ListadoMarcas = DB.Query<marca>(sql).ToList();
            }
            return _ListadoMarcas;
        }

        public static marca ListarMarca(int IdMarca)
        {

            marca UnaMarca = null;
            using (SqlConnection DB = new SqlConnection(_connectionString))
            {
                string sql = "SELECT * FROM marca WHERE IdMarca=@pMarca";
                UnaMarca = DB.QueryFirstOrDefault<marca>(sql, new { pMarca = IdMarca });
            }
            return UnaMarca;
        }

        private static List<ropa> _ListadoRopa = new List<ropa>();
        public static List<ropa> ListarRopar(int IdMarca)
        {

            using (SqlConnection DB = new SqlConnection(_connectionString))
            {
                string sql = "SELECT * FROM ropa WHERE IdMarca = @pIdMarca";
                _ListadoRopa = DB.Query<ropa>(sql, new { pIdMarca = IdMarca }).ToList();
            }
            return _ListadoRopa;
        }

        public static ropa VerInfoDesc(string descripcion)
        {
            ropa desc = null;
            using (SqlConnection DB = new SqlConnection(_connectionString))
            {
                string sql = "SELECT * FROM ropa WHERE descripcion = @pdescripcion";
                desc = DB.QueryFirstOrDefault<ropa>(sql, new { pdescripcion = descripcion });
            }
            return desc;
        }




    }
}
