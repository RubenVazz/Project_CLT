using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net;

namespace f2
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// la capa de negocios
        /// </summary>
        private businessLayer capaNegocios = new businessLayer();

        #region SETEOS DE BASE          
        /// <summary>
        /// estable si el form esta en produccion
        /// </summary>
        private bool esProduccion;
        /// <summary>
        /// url del webService del serviceBus
        /// </summary>
        private string urlServiceBus = "";
        /// <summary>
        /// tns del server de oracle es ip + pipe + serviceName, default dbitacua
        /// </summary>
        private string tnsOracle = "";
        /// <summary>
        /// el usuario de oracle que viene de finansys
        /// </summary>
        private string usuarioOracle = "";
        /// <summary>
        /// el password de oracle
        /// </summary>
        private string passOracle = "";
        /// <summary>
        /// los parametro recibidos desde finansys
        /// </summary>
        private string parametros = "";
        /// <summary>
        /// determina si se puede cerrar el formulario
        /// </summary>
        private bool sePuedeCerrar = true;
        /// <summary>
        /// el nombre de la aplicacion
        /// </summary>
        private string nombreAplicacion = "Finansys 2";
        /// <summary>
        /// seteos de formularios
        /// </summary>
        #endregion

        #region SETEOS VARIABLES
        private double id_cliente = 0;
        private double v_realizo_modi = 0;
        DataTable dt_Cbclientes = new DataTable();
        DataTable dt_detalleVenta = new DataTable();
        private string condicionVenta;
        #endregion

        /// <summary>
        /// constructor del formulario
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            //seteos standart de clase
            iniciosVarios();
            //establecer la version del archivo
            f2.objFinanasys2 laSesion = new objFinanasys2();
            laSesion.version = "AAAAABBBBCCCCDDD00009";
            this.Tag = (Object)laSesion;
        }         

        /// <summary>
        /// Ocurre antes de cerrar el formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (sePuedeCerrar)
            {
                this.DialogResult = MessageBox.Show("Cerrar "+this.Text.Trim()+" ?",
                    this.nombreAplicacion,
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button1);
                if (this.DialogResult != DialogResult.Yes)
                    e.Cancel = true;
            }
            else { e.Cancel = true; }            
        }

        /// <summary>
        /// Ocurre cuando el formulario de muestra
        /// por primera vez
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Shown(object sender, EventArgs e)
        {

            #region P R I M E R A - - C O N E X I O N (1)
            esProduccion = false;
            if (esProduccion)
            {
                //recupero los parametros recibidos desde finansys            
                f2.objFinanasys2 laSesion = (f2.objFinanasys2)this.Tag;
                usuarioOracle = laSesion.usuario;
                passOracle = laSesion.userPassword;
                parametros = laSesion.parametros;
                tnsOracle = "ipServerOracle|dbitacua";
            }
            else
            {
                //aqui podemos colocar los datos para trabajar en un sandBox
                /*usuarioOracle = "BLE";
                passOracle = "12345678";
                parametros = "";
                tnsOracle = "192.6.2.148|dbitades";*/
                /*usuarioOracle = "RNB";
                passOracle = "a.123456";
                parametros = "";
                tnsOracle = "192.168.121.21/XE";*/
                usuarioOracle = "USER_ORA";
                passOracle = "1234";
                parametros = "";
                tnsOracle = "localhost:1521/xe";
            }

            //aqui se estable la capa de negocios            
            capaNegocios = new businessLayer(usuarioOracle, passOracle, tnsOracle);
            UsuarioActual.oraPassword = passOracle;
            UsuarioActual.oraTNS = tnsOracle;
            UsuarioActual.oraUsuario = usuarioOracle;

            #endregion            
        }

        private void iniciosVarios()
        {
            //Inicializaciones de base
            this.Icon = f2.Properties.Resources.pyg;
            this.Text = "Finansys 2";
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        }

        private void btn_Hijo_Click(object sender, EventArgs e)
        {
            hijo nuevoForm = new hijo(capaNegocios);
            nuevoForm.ShowDialog();
        }

        private void btn_productos_Click(object sender, EventArgs e)
        {
            frm_productos nuevoForm = new frm_productos(capaNegocios);
            nuevoForm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm_ventas nuevoForm = new  frm_ventas(capaNegocios);
            nuevoForm.ShowDialog();
        }
    }

    #region VALIDACION CERTIFICADO SSL
    /// <summary>
    /// clase para confiar en cualquier certificado
    /// </summary>
    public class MyPolicy : ICertificatePolicy
    {
        public bool CheckValidationResult(ServicePoint srvPoint,
            System.Security.Cryptography.X509Certificates.X509Certificate certificate,
            WebRequest request, Int32 certificateProblem)
        {
            return true;
        }
    }
#endregion
}