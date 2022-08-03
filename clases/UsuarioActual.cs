using System;
using System.Collections.Generic;
using System.Text;

namespace f2
{
    class UsuarioActual
    {
        private static int _usuario;
        private static string _oraTNS;
        private static string _oraUsuario;
        private static string _oraPassword;
        private static string _nombreUsuario;
        private static string _usuarioLogin;


        public static int usuario
        { 
            get 
            { 
                return _usuario; 
            } 
            set 
            { 
                _usuario = value; 
            } 
        }

        public static string oraTNS
        {
            get
            {
                return _oraTNS;
            }
            set
            {
                _oraTNS = value;
            }
        }

        public static string oraPassword
        {
            get
            {
                return _oraPassword;
            }
            set
            {
                _oraPassword = value;
            }
        }

        public static string oraUsuario
        {
            get
            {
                return _oraUsuario;
            }
            set
            {
                _oraUsuario = value;
            }
        }

        public static string nombreUsuario
        {
            get
            {
                return _nombreUsuario;
            }
            set
            {
                _nombreUsuario = value;
            }
        }

        public static string usuarioLogin
        {
            get
            {
                return _usuarioLogin;
            }
            set
            {
                _usuarioLogin = value;
            }
        }
    }
}
