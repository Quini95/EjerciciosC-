
Cliente cliente = new Cliente("Fran", 666555444, "C/ Larga", "email@gmail.com", true);
Console.WriteLine("Los datos son: " + cliente);


Cliente cliente2 = cliente with { nombre = "Manuel" };
//Console.WriteLine("El nombre es " + cliente2.nombre);


public struct Cliente
{
    public Cliente(String nombre, int telefono, String direccion, String email, Boolean nuevocliente)
    {
        this.nombre = nombre;
        this.telefono = telefono;
        this.direccion = direccion;
        this.email = email;
        this.nuevocliente = nuevocliente;
    }


    public String nombre { get; set; }
    public int telefono { get; set; }
    public String direccion { get; set; }
    public String email { get; set; }
    public Boolean nuevocliente { get; set; }

    public override string ToString() => $"{nombre}, {telefono}, {direccion}, {email}, {nuevocliente}";










}