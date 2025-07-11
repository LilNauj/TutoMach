using System.Text.RegularExpressions;
using MySql.Data.MySqlClient;

namespace TutoMatch
{
    public partial class Form1 : Form
    {
        //la conexion a la base datos 
        string connectionString = "server=localhost;port=3306;user=root;password=;database=db_tutomatch";
        public Form1()
        {
            InitializeComponent();
            //Llamar al metodo para mostrar los roles en el combobox
            mostrarRol();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Control o manejo de errrores 

            /*
             try catch (Exception ex){}
            */

            try
            {
                //Utilizar la conexion   
                using (MySqlConnection conexion = new MySqlConnection(connectionString))
                {
                    conexion.Open();
                    MessageBox.Show("Conexión exitosa a la base de datos");
                    conexion.Close();

                }

            }
            catch (Exception ex)
            {
                //Mostrar el mensaje de error
                MessageBox.Show("Error al conectar a la base de datos: " + ex.Message);
            }
        }
        //Metodo para mostrar enum en un combobox

        private void mostrarRol()
        {
            //Sentencia query
            string query = "SHOW COLUMNS FROM tbl_usuario LIKE 'rol_usuario'";

            //Hago lista para recibir el query

            List<string> listaRoles = new List<string>();

            //Usar la conexión y el query de la base de datos

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {

                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, conn)) //nueva conexión según query
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        string type = reader["Type"].ToString(); // ejemplo: enum('Administrador','Secretaria')

                        // Extraer los valores usando Regex
                        MatchCollection matches = Regex.Matches(type, @"'([^']*)'");
                        foreach (Match match in matches)
                        {
                            listaRoles.Add(match.Groups[1].Value);
                        }
                    }
                }

            }
            //Llenar el ComboBox
            cboRoldeUsuario.DataSource = listaRoles;


        }

        private void btnIniciarSesíon_Click(object sender, EventArgs e)
        {
            string nombreUsuario = txtNombredeUsuario.Text;
            string PasswordUsuario = txtPasswordUsuario.Text;
            string rolUsuario = cboRoldeUsuario.Text;

            MessageBox.Show($"Nombre de Usuario: {nombreUsuario}\nContraseña:"
                + $" {PasswordUsuario}\nRol: " + $"{rolUsuario}");


            //Ahora si voy a utilizar using para usar la conexión a BD y manejo de errores
            /*using ()
            {
            try
            { }
            catch (Exception ex) { }
            }*/
            //Realizo el SQL
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM tbl_usuario WHERE nombre_usuario = @nombreUsuario" +
                        " AND password_usuario = @PasswordUsuario AND rol_usuario = @rolUsuario";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@nombreUsuario", nombreUsuario);
                    cmd.Parameters.AddWithValue("@PasswordUsuario", PasswordUsuario);
                    cmd.Parameters.AddWithValue("@rolUsuario", rolUsuario);

                    MySqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        string rol = reader["rol_usuario"].ToString();
                        MessageBox.Show("Inicio de sesión exitoso. Rol: " + rol);

                        // Aquí puedes abrir otro formulario según el rol

                        FrmFormulariodeUsuario formulariodeUsuario = new FrmFormulariodeUsuario();
                        formulariodeUsuario.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Usuario, contraseña o rol incorrectos.");
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error de conexión",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void cboRoldeUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

