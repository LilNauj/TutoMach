using System;

public class Usuario
{
    //Atributos 
    public int idUsuario { get; set; }
    public string nombreUsuario { get; set; }
    public string emailUsuario { get; set; }
    public string rolUsuario { get; set; }
    public int passwordUsuario { get; set; }

    //Constructor
    public Usuario(){}

    //Constructor con parámetros
    public Usuario (int idUsuario, string nombreUsuario, string emailUsuario, string rolUsuario, int passwordUsuario)
    {
        this.idUsuario = idUsuario;
        this.nombreUsuario = nombreUsuario;
        this.emailUsuario = emailUsuario;
        this.rolUsuario = rolUsuario;
        this.passwordUsuario = passwordUsuario;
    }
      
    // Métodos


}
