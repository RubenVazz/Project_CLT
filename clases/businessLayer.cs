using System;
using System.Data;
using Oracle.DataAccess.Client;

namespace f2
{
    /// <summary>
    /// aqui va todo el codigo del developer
    /// que relaciona formulario con el mundo exterior
    /// </summary>
    public class businessLayer
    {
        public readonly string[] ticketSb = new string[2];
        public string[] idInstanciaSb = new string[2];
        private string[] noise = new string[2];
        private string[] ticketResult = new string[2];

        #region interno
        //COMENTADO AL AGREGAR LA NUEVA FORMA DE CONECTAR EN LA REGION STANDAR
        //public businessLayer() { }
        public void agregarConexion(int posicion,string i_ticketSb, string i_idInstanacia)
        {
            ticketSb[posicion] = i_ticketSb;
            idInstanciaSb[posicion] = i_idInstanacia;
        }

        /// <summary>
        /// generar token de conexion sl SB
        /// </summary>
        private void generar() { generar(0); }
        /// <summary>
        /// generar token de conexion sl SB
        /// </summary>
        /// <param name="posicion"></param>
        private void generar(int posicion)
        {
            noise[posicion] = DateTime.Now.Ticks.ToString();
            ticketResult[posicion] = utiles.GetMD5(ticketSb[posicion] + noise[posicion]);
        }        
        /// <summary>
        /// devuelve ticket de conexion actual al SB
        /// </summary>
        /// <returns></returns>
        private string elTicket() { return elTicket(0); }
        /// devuelve ticket de conexion actual al SB
        private string elTicket(int posicion)
        {
            return ticketResult[posicion];
        }
        /// <summary>
        /// la semilla para ocultar el ticket de sesion en la comunicacion
        /// </summary>
        /// <returns></returns>
        private string elNoise() { return elNoise(0); }
        /// <summary>
        /// la semilla para ocultar el ticket de sesion en la comunicacion
        /// </summary>
        /// <param name="posicion"></param>
        /// <returns></returns>
        private string elNoise(int posicion)
        {
            return noise[posicion];
        }
        /// <summary>
        /// devuelve la instanacia de conexion a la BD
        /// </summary>
        /// <returns></returns>
        private string laInstanacia() { return laInstanacia(0); }
        /// <summary>
        /// devuelve la instanacia de conexion a la BD
        /// </summary>
        /// <param name="posicion"></param>
        /// <returns></returns>
        private string laInstanacia(int posicion)
        {
            return idInstanciaSb[posicion];
        }
        #endregion

        #region  standar
        /// <summary>
        /// cadena de coneccion del ensamblado
        /// </summary>
        private string cadenaCone = "User Id=AAA111;Password=BBB222;Data Source=CCC333;Connection Timeout=60; Pooling=false";
        /// <summary>
        /// devuelve la cadena de conexion para oracle
        /// </summary>
        public string cadenaDeConeccion { get { return this.cadenaCone; } }
        /// <summary>
        /// constructor simple
        /// </summary>
        public businessLayer() { }
        /// <summary>
        /// contruye la clase de negocios 
        /// con datos de la BD
        /// </summary>
        /// <param name="usuario">usuario de oracle</param>
        /// <param name="passWord">password de oracle</param>
        /// <param name="dataSource">el TND a donde apuntar</param>
        public businessLayer(string usuario, string passWord, string dataSource)
        {
            cadenaCone = cadenaCone.Replace("AAA111", usuario).Replace("BBB222", passWord).Replace("CCC333", dataSource);
        }
        #endregion

        public OracleConnection AbrirConexion()
        {
            OracleConnection cone = new OracleConnection(cadenaDeConeccion);
            return cone;
        }


        #region c o d i g o -- d e v e l o p e r

        /// <summary>
        /// Ejemplo - DataTable.
        /// </summary>
        /// <returns></returns>
        public DataTable sp_lista_clientes_clt()
        {
            /* --
            --
            -- procedimiento para consultar los clientes de CLT
            --

                clt.pkg_abm_clientes_contabilidad.sp_lista_clientes_clt(po_retorno => :po_retorno); */

            System.Data.DataTable clienteLista = new DataTable();
            OracleConnection cone = new OracleConnection(this.cadenaCone);
            OracleCommand coman = new OracleCommand("clt.pkg_abm_clientes_contabilidad.sp_lista_clientes_clt", cone);
            coman.CommandType = CommandType.StoredProcedure;

            coman.Parameters.Add("PO_CURSOR", OracleDbType.RefCursor);
            coman.Parameters["PO_CURSOR"].Direction = ParameterDirection.Output;
            OracleDataAdapter adap = new OracleDataAdapter(coman);
            try
            {
                coman.Connection.Open();
                adap.Fill(clienteLista);
                coman.Connection.Close();
                coman.Connection.Dispose();
            }
            catch
            {
                throw;

            }
            return clienteLista;

        }

        
        public DataTable SP_LISTAR_CLIENTES()
        {
            System.Data.DataTable ListaCliente = new DataTable();
            OracleConnection cone = new OracleConnection(this.cadenaCone);
            OracleCommand coman = new OracleCommand("USER_ORA.PKG_ABM.SP_LISTAR_CLIENTES", cone);
            coman.CommandType = CommandType.StoredProcedure;

            coman.Parameters.Add("PO_CURSOR", OracleDbType.RefCursor);
            coman.Parameters["PO_CURSOR"].Direction = ParameterDirection.Output;
            OracleDataAdapter adap = new OracleDataAdapter(coman);
            try
            {
                coman.Connection.Open();
                adap.Fill(ListaCliente);
                coman.Connection.Close();
                coman.Connection.Dispose();

                
            }
            catch
            {
                throw;

            }
            return ListaCliente;

        }
        public DataTable SP_LISTAR_PRODUCTOS()
        {
            System.Data.DataTable ListaProductos = new DataTable();
            OracleConnection cone = new OracleConnection(this.cadenaCone);
            OracleCommand coman = new OracleCommand("USER_ORA.PKG_ABM_PRODUCTOS.SP_LISTAR_PRODUCTOS", cone);
            coman.CommandType = CommandType.StoredProcedure;

            coman.Parameters.Add("PO_CURSOR", OracleDbType.RefCursor);
            coman.Parameters["PO_CURSOR"].Direction = ParameterDirection.Output;
            OracleDataAdapter adap = new OracleDataAdapter(coman);
            try
            {
                coman.Connection.Open();
                adap.Fill(ListaProductos);
                coman.Connection.Close();
                coman.Connection.Dispose();


            }
            catch
            {
                throw;

            }
            return ListaProductos;

        }
        public DataTable SP_LISTAR_VENTAS()
        {
            System.Data.DataTable ListaVentas = new DataTable();
            OracleConnection cone = new OracleConnection(this.cadenaCone);
            OracleCommand coman = new OracleCommand("USER_ORA.PKG_VENTAS.SP_LISTAR_VENTAS", cone);
            coman.CommandType = CommandType.StoredProcedure;

            coman.Parameters.Add("PO_CURSOR", OracleDbType.RefCursor);
            coman.Parameters["PO_CURSOR"].Direction = ParameterDirection.Output;
            OracleDataAdapter adap = new OracleDataAdapter(coman);
            try
            {
                coman.Connection.Open();
                adap.Fill(ListaVentas);
                coman.Connection.Close();
                coman.Connection.Dispose();
            }
            catch
            {
                throw;

            }
            return ListaVentas;

        }
        public string sp_insertar_cliente(string PI_NOMBRE,
                                          string PI_APELLIDO)
        {
            string datos = "";
            OracleConnection cone = new OracleConnection(cadenaDeConeccion);
            OracleCommand coman = new OracleCommand("USER_ORA.PKG_ABM.SP_INSERT_CLIENTES", cone);
            coman.CommandType = CommandType.StoredProcedure;

            coman.Parameters.Add("PI_NOMBRE", PI_NOMBRE.Trim());
            coman.Parameters.Add("PI_APELLIDO", PI_APELLIDO.Trim());

            coman.Parameters.Add("po_retorno", OracleDbType.NVarchar2, 500);
            coman.Parameters["po_retorno"].Direction = ParameterDirection.Output;
            try
            {
                cone.Open();
                coman.ExecuteNonQuery();
                cone.Close();
                datos = coman.Parameters["po_retorno"].Value.ToString();
            }
            catch
            {
                throw;

            }
            return datos;

        }
        public string sp_insertar_producto(string PI_PRODUCTO,
                                          double PI_PRECIO,
                                          string PI_CANTIDAD)
        {
            string datos = "";
            OracleConnection cone = new OracleConnection(cadenaDeConeccion);
            OracleCommand coman = new OracleCommand("USER_ORA.PKG_ABM_PRODUCTOS.SP_INSERT_PRODUCTOS", cone);
            coman.CommandType = CommandType.StoredProcedure;

            coman.Parameters.Add("PI_PRODUCTO", PI_PRODUCTO.Trim());
            coman.Parameters.Add("PI_PRECIO", PI_PRECIO);
            coman.Parameters.Add("PI_CANTIDAD", PI_CANTIDAD.Trim());

            coman.Parameters.Add("po_retorno", OracleDbType.NVarchar2, 500);
            coman.Parameters["po_retorno"].Direction = ParameterDirection.Output;
            try
            {
                cone.Open();
                coman.ExecuteNonQuery();
                cone.Close();
                datos = coman.Parameters["po_retorno"].Value.ToString();
            }
            catch
            {
                throw;

            }
            return datos;

        }

        public string sp_insertar_ventas(string PI_CANTIDAD,
                                          int PI_CODIGO_PRODUCTO,
                                          string PI_NOMBRE_PRODUCTO,
                                          int PI_CODIGO_CLIENTE)
        {
            string datos = "";
            OracleConnection cone = new OracleConnection(cadenaDeConeccion);
            OracleCommand coman = new OracleCommand("USER_ORA.PKG_VENTAS.SP_INSERT_VENTAS", cone);
            coman.CommandType = CommandType.StoredProcedure;

            coman.Parameters.Add("PI_CANTIDAD", PI_CANTIDAD.Trim());
            coman.Parameters.Add("PI_CODIGO_PRODUCTO", PI_CODIGO_PRODUCTO);
            coman.Parameters.Add("PI_NOMBRE_PRODUCTO", PI_NOMBRE_PRODUCTO.Trim());
            coman.Parameters.Add("PI_CODIGO_CLIENTE", PI_CODIGO_CLIENTE);

            coman.Parameters.Add("po_retorno", OracleDbType.NVarchar2, 500);
            coman.Parameters["po_retorno"].Direction = ParameterDirection.Output;
            try
            {
                cone.Open(); 
                coman.ExecuteNonQuery();
                cone.Close();
                datos = coman.Parameters["po_retorno"].Value.ToString();
            }
            catch
            {
                throw;

            }
            return datos;

        }

        public string sp_eliminar_cliente(int pi_codigo_cliente)
        {
            string datos = "";

            OracleConnection cone = new OracleConnection(cadenaDeConeccion);
            OracleCommand coman = new OracleCommand("USER_ORA.PKG_ABM.SP_DELETE_CLIENTES", cone);
            coman.CommandType = CommandType.StoredProcedure;

            coman.Parameters.Add("CODIGO_CLIENTE",pi_codigo_cliente);
            coman.Parameters.Add("po_retorno", OracleDbType.NVarchar2, 500);
            coman.Parameters["po_retorno"].Direction = ParameterDirection.Output;

            try
            {
                cone.Open();
                coman.ExecuteNonQuery();
                cone.Close();
                datos = coman.Parameters["po_retorno"].Value.ToString();

            }
            catch
            {
                throw;

            }
            return datos;
        }
        public string sp_eliminar_producto(int pi_codigo_producto)
        {
            string datos = "";

            OracleConnection cone = new OracleConnection(cadenaDeConeccion);
            OracleCommand coman = new OracleCommand("USER_ORA.PKG_ABM_PRODUCTOS.SP_DELETE_PRODUCTOS", cone);
            coman.CommandType = CommandType.StoredProcedure;

            coman.Parameters.Add("CODIGO_PRODUCTO", pi_codigo_producto);
            coman.Parameters.Add("po_retorno", OracleDbType.NVarchar2, 500);
            coman.Parameters["po_retorno"].Direction = ParameterDirection.Output;

            try
            {
                cone.Open();
                coman.ExecuteNonQuery();
                cone.Close();
                datos = coman.Parameters["po_retorno"].Value.ToString();
            }
            catch
            {
                throw;

            }
            return datos;
        }

        public string sp_eliminar_ventas(int PI_CODIGO_VENTAS)
        {
            string datos = "";

            OracleConnection cone = new OracleConnection(cadenaDeConeccion);
            OracleCommand coman = new OracleCommand("USER_ORA.PKG_VENTAS.SP_DELETE_VENTAS", cone);
            coman.CommandType = CommandType.StoredProcedure;

            coman.Parameters.Add("CODIGO_VENTA", PI_CODIGO_VENTAS);
            coman.Parameters.Add("po_retorno", OracleDbType.NVarchar2, 500);
            coman.Parameters["po_retorno"].Direction = ParameterDirection.Output;

            try
            {
                cone.Open();
                coman.ExecuteNonQuery();
                cone.Close();
                datos = coman.Parameters["po_retorno"].Value.ToString();

            }
            catch
            {
                throw;

            }
            return datos;
        }

        public string SP_UPDATE_CLIENTES(int PI_CODIGO_CLIENTE,
                                          string PI_NOMBRE,
                                          string PI_APELLIDO)
        {
            string datos = "";
            OracleConnection cone = new OracleConnection(cadenaDeConeccion);
            OracleCommand coman = new OracleCommand("USER_ORA.PKG_ABM.SP_UPDATE_CLIENTES", cone);
            coman.CommandType = CommandType.StoredProcedure;

            coman.Parameters.Add("PI_CODIGO_CLIENTE", PI_CODIGO_CLIENTE);
            coman.Parameters.Add("PI_NOMBRE", PI_NOMBRE.Trim());
            coman.Parameters.Add("PI_APELLIDO", PI_APELLIDO.Trim());

            coman.Parameters.Add("po_retorno", OracleDbType.NVarchar2, 500);
            coman.Parameters["po_retorno"].Direction = ParameterDirection.Output;


            try
            {
                cone.Open();
                coman.ExecuteNonQuery();
                cone.Close();
                datos = coman.Parameters["po_retorno"].Value.ToString();

            }
            catch
            {
                throw;

            }
            return datos;

        }
        public string SP_UPDATE_PRODUCTOS(string PI_PRODUCTO,
                                          double PI_PRECIO,
                                          string PI_CANTIDAD,
                                          int PI_CODIGO_PRODUCTO)
        {
            string datos = "";
            OracleConnection cone = new OracleConnection(cadenaDeConeccion);
            OracleCommand coman = new OracleCommand("USER_ORA.PKG_ABM_PRODUCTOS.SP_UPDATE_PRODUCTOS", cone);
            coman.CommandType = CommandType.StoredProcedure;

            coman.Parameters.Add("PI_PRODUCTO", PI_PRODUCTO.Trim());
            coman.Parameters.Add("PI_PRECIO", PI_PRECIO);
            coman.Parameters.Add("PI_CANTIDAD", PI_CANTIDAD.Trim());
            coman.Parameters.Add("PI_CODIGO_PRODUCTO", PI_CODIGO_PRODUCTO);

            coman.Parameters.Add("po_retorno", OracleDbType.NVarchar2, 500);
            coman.Parameters["po_retorno"].Direction = ParameterDirection.Output;


            try
            {
                cone.Open();
                coman.ExecuteNonQuery();
                cone.Close();
                datos = coman.Parameters["po_retorno"].Value.ToString();

            }
            catch
            {
                throw;

            }
            return datos;

        }
        public string SP_UPDATE_VENTAS(string PI_CANTIDAD,
                                          int PI_CODIGO_PRODUCTO,
                                          string PI_NOMBRE_PRODUCTO,
                                          int PI_PRECIO_VENTA,
                                          int PI_CODIGO_CLIENTE,
                                          int PI_CODIGO_VENTA)
        {
            string datos = "";
            OracleConnection cone = new OracleConnection(cadenaDeConeccion);
            OracleCommand coman = new OracleCommand("USER_ORA.PKG_VENTAS.SP_UPDATE_VENTAS", cone);
            coman.CommandType = CommandType.StoredProcedure;

            coman.Parameters.Add("PI_CANTIDAD", PI_CANTIDAD.Trim());
            coman.Parameters.Add("PI_CODIGO_PRODUCTO", PI_CODIGO_PRODUCTO);
            coman.Parameters.Add("PI_NOMBRE_PRODUCTO", PI_NOMBRE_PRODUCTO.Trim());
            coman.Parameters.Add("PI_PRECIO_VENTA", PI_PRECIO_VENTA);
            coman.Parameters.Add("PI_CODIGO_CLIENTE", PI_CODIGO_CLIENTE);
            coman.Parameters.Add("PI_CODIGO_VENTA", PI_CODIGO_VENTA);

            coman.Parameters.Add("po_retorno", OracleDbType.NVarchar2, 500);
            coman.Parameters["po_retorno"].Direction = ParameterDirection.Output;



            try
            {
                cone.Open();
                coman.ExecuteNonQuery();
                cone.Close();
                datos = coman.Parameters["po_retorno"].Value.ToString();
            }
            catch
            {
                throw;

            }
            return datos;

        }
        #endregion 

    }
}
