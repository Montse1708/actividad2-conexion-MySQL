using MySql.Data.MySqlClient;
using System.Data;

namespace MySQLConexion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Función para que al dar clic al botón se realice la conexión
        //con la base de datos de MySQL
        private void btnConectar_Click(object sender, EventArgs e)
        {
            //Se declararán las varables necesarias
            string host = txtHost.Text;             //Ingresar el nombre del host 
            string user = txtUsuario.Text;          //Ingresar el nombre del usuario
            string password = txtContrasena.Text;   //Ingresar la contraseña
            string puerto = txtPuerto.Text;         //Ingresar el puerto
            string database = txtBaseDeDatos.Text;  //Ingresar el nombre de la base de datos

            //Permite realizar la conexión
            string connectionString = BuildConnectionString(host, user, password, puerto, database);
            //Realizar la conexión con MySQL
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                //Exception
                //En caso de que los datos ingresados sean corrctos 
                //se realiza la conexión y muestra los datos correspondientes
                try
                {
                    //Se realiza la conexión
                    con.Open();
                    //Se especifica el nombre de la tabla que mostrará los datos
                    MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM CatPersonal", con);
                    //Se obtiene los datos de la tabla en MySQL
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    //Los datos obtenidos se muestran en el datagridView
                    dgvDatos.DataSource = dt;

                }
                //En caso que los datos ingresados sean incorrectos
                catch (Exception ex)
                {
                    //Muestra un mensaje en pantalla con el error que ocurre
                    MessageBox.Show("Ha ocurrido un error: " + ex.Message);
                }
            }
        }
        //Obtiene los datos correspondientes para realizar la conexión
        private string BuildConnectionString(string host, string user, string password, string port, string database)
        {
            //Trae los datos que coninciden con los datos ingresados y
            //los de la base de datos en MySQL
            return $"SERVER={host};PORT={port};DATABASE={database};USER ID={user};PASSWORD={password};";
        }
    }
}