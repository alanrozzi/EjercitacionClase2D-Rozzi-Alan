namespace Aerolineas
{
    public static class Mock
    {
        public static List<Administrador> Administradores()
        {
            //hardcode de lista de admin
            List<Administrador> listaAdmins = new List<Administrador>();

            listaAdmins.Add(new Administrador("Usuario1", "Contrasenia1", "Don1"));
            listaAdmins.Add(new Administrador("Usuario2", "Contrasenia2", "Don2"));
            listaAdmins.Add(new Administrador("Usuario3", "Contrasenia3", "Don3"));
            listaAdmins.Add(new Administrador("Usuario4", "Contrasenia4", "Don4"));

            return listaAdmins;
        }
    }
}