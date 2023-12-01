using Colchoneria.Dtos;
using Colchoneria.Servicios;
namespace Colchoneria.Controladores
{
    class Program
    {
        static void Main(string[] args)
        {
            List<ColchonDto> listaColchones = new List<ColchonDto>();
            MenuInterfaz mi =new MenuImplementacion();
            ColchonInterfaz ci=new ColchonImplementacion();
            bool cerrarMenu = false;
            int opcionSelec;


            while (!cerrarMenu)
            {
                mi.mensajeBienvenida();

                opcionSelec=mi.mostrarMenuYSeleccion();

                switch (opcionSelec)
                {
                    case 0:
                        Console.WriteLine("[INFO] Se cerrará el menú");
                        cerrarMenu=true;
                        break;

                    case 1:
                        Console.WriteLine("[INFO] Se añadira un colchon");
                        Console.WriteLine("-----------------------------");

                        ci.añadirColchon(listaColchones);

                        foreach(ColchonDto colchon in listaColchones)
                        {
                            Console.WriteLine(colchon.ToString());
                        }
                        break;

                    case 2:
                        /*
                       foreach()
                      {
                          if(idColchon.Equals(idC))
                          {
                              hacer menu con los campos a cambiar.
                              hacer un switch con los campos y dentro de los casos pedir el valor a cambiar.
                              modifical el valor.
                          }
                      }
                      */
                        break;

                    case 3:
                        break;

                    case 4:
                        break;

                    default:
                        break;
                }
            }
        }
    }
}
