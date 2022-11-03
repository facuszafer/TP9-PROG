using System;

namespace TP9
{
    public class ropa
    {
        private int _IdMarca;
        private int _IdRopa;
        private string _Nombre;
        private float _precio;
        private string _Foto;
        private string _descripcion;
        private int _cantLikes;


         public ropa(int IdMarca, int IdRopa, string Nombre, float precio, string Foto, string descripcion, int cantLikes)
        {
           _IdMarca = IdMarca;
           _IdRopa = IdRopa;
            _Nombre = Nombre;
            _precio = precio;
            _Foto = Foto;
            _descripcion = descripcion;
            _cantLikes = cantLikes;
        }
        public ropa(){}
        public string Nombre
        {
            get{return _Nombre;}
            set{_Nombre = value;}
        }
        public int IdRopa
        {
            get{return _IdRopa;}
            set{_IdRopa = value;}
        }
        public int IdMarca
        {
            get{return _IdMarca;}
            set{_IdMarca= value;}
        }
        public float precio
        {
            get{return _precio;}
            set{_precio = value;}
        }
        public string Foto 
        {
            get{return _Foto;}
            set{_Foto = value;}
        }
        public string descripcion
        {
            get{return _descripcion;}
            set{_descripcion = value;}
        }
        public int cantLikes
        {
            get{return _cantLikes;}
            set{_cantLikes = value;}
        }
    
    }

}