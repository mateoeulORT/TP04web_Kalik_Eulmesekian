class OrtWorld{
    public static List <string> ListaDestinos {get; private set;} = new List<string>{"Paris", "Roma", "Brujas", "San Luis", "Catamarca", "Barcelona", "Zenon Pereyra","Monaco", "Dubai", "Moron"};
    public static List <string> ListaHoteles {get; private set;} = new List<string>{"imagen1.jpg", "imagen2.jpg", "imagen3.jpg", "imagen4.jpg", "imagen5.jpg", "imagen6.jpg", "imagen7.jpg","imagen8.jpg", "imagen9.jpg", "imagen10.jpg"};
    public static List<string> ListaAereos {get; private set;} = new List<string>{"flybondi.jpg", "lufthansa.jpg", "Aereolineas Argentinas.jpg", "LAN.jpg", "Qatar airways.jpg", "Fly emirates.jpg", "iberia.jpg","BOA.jpg", "Air France.jpg", "air belgium.jpg"};
    public static List<string> ListaExcursiones {get; private set;} = new List<string>{"excu1.jpg", "excu2.jpg", "excu3.jpg", "excu4.jpg", "excu5.jpg", "excu6.jpg", "excu7.jpg","excu8.jpg", "excu9.jpg", "excu10.jpg"};
    public static Dictionary<string, Paquete> DicPaquetes {get; private set;}

   public static bool IngresarPaquete(string destinoSeleccionado, Paquete paquete){
    
        bool sePudo = false;
        if (ListaDestinos.Contains(destinoSeleccionado))
        {
            DicPaquetes.Add(destinoSeleccionado, paquete);
            sePudo = true;
        }
        return sePudo;
   }
    




}