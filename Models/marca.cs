using System;

namespace TP9
{
    public class marca
    {
        private int _IdMarca;
        private string _Nombre;
        private string _Foto;
        private string _Logo;


         public marca(int IdMarca, string Nombre, string Foto, string Logo)
        {
           _IdMarca = IdMarca;
            _Nombre = Nombre;
            _Foto = Foto;
            _Logo = Logo;
        }
         public marca()
        {
           _IdMarca = 0;
            _Nombre = "";
            _Foto = "";
            _Logo = "";
        }        
        public string Nombre
        {
            get{return _Nombre;}
            set{_Nombre = value;}
        }
        public int IdMarca
        {
            get{return _IdMarca;}
            set{_IdMarca= value;}
        }
        public string Foto 
        {
            get{return _Foto;}
            set{_Foto = value;}
        }
        public string Logo
        {
            get{return _Logo;}
            set{_Logo = value;}
        }
    
    }

}