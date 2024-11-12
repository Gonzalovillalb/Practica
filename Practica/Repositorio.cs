
using Practica.Entidades;

namespace Practica
{
    public class Repositorio
    {
        private readonly string _archivo = Environment.CurrentDirectory + "\\Circunferencia.txt";
        private readonly string _archivoCopia = Environment.CurrentDirectory + "\\Circunferencia.bak";
        private List<Figura> Lista;

        public Repositorio() 
        {
            Lista = new List<Figura>();
            LeerDatos();

        }
        public List<Figura> GetLista()
        {
            return Lista;
        }
        private void LeerDatos()
        {
            if (File.Exists(_archivo))
            {
                var lector = new StreamReader(_archivo);
                while (!lector.EndOfStream)
                {
                    string lineaLeida = lector.ReadLine();
                    Figura figura = Construir(lineaLeida);
                    Lista.Add(figura);
                }
                lector.Close();

            }
        }

        private Figura Construir(string? lineaLeida)
        {
            var campos = lineaLeida.Split('|');
            double Radio = int.Parse(campos[0]);
            Borde borde = (Borde)int.Parse(campos[1]);
            Relleno color = (Relleno)int.Parse(campos[2]);
            Figura c = new Figura(Radio, borde, color);
            return c;

        }
        public void Agregar(Figura figura)
        {
            var escritor = new StreamWriter(_archivo, true);

            string lineaEscribir = ConstruirLinea(figura);
            escritor.WriteLine(lineaEscribir);
            escritor.Close();


            Lista.Add(figura);

        }

        private string ConstruirLinea(Figura figura)
        {
            return $"{figura.GetRadio()}|{figura.Borde.GetHashCode()}|{figura.Relleno.GetHashCode()}";
        }

        public int GetCantidad(int valorFiltro=0)
        {
            if (valorFiltro > 0)
            {
                return Lista
                    .Count(c => c.GetRadio() >= valorFiltro);
            }
            return Lista.Count;
        }

        public bool Existe(Figura figura)
        {
            Lista.Clear();
            LeerDatos();
            foreach (var itemFigura in Lista)
            {
                if (itemFigura.GetRadio() == figura.GetRadio() &&
                    itemFigura.Relleno == figura.Relleno &&
                    itemFigura.Borde == figura.Borde)
                {
                    return true;
                }
            }
            return false;
        }
        public void Borrar(Figura figuraBorrar)
        {
            using (var lector = new StreamReader(_archivo))
            {
                using (var escritor = new StreamWriter(_archivoCopia))
                {
                    while (!lector.EndOfStream)
                    {
                        string lineaLeida = lector.ReadLine();
                        Figura figuraLeido = Construir(lineaLeida);
                        if (figuraBorrar.GetRadio() != figuraLeido.GetRadio())
                        {
                            escritor.WriteLine(lineaLeida);
                        }

                    }
                }

            }
            File.Delete(_archivo);
            File.Move(_archivoCopia, _archivo);
            Lista.Remove(figuraBorrar);
        }
        public List<Figura> OrdenarAsc()
        {
            return Lista.OrderBy(c => c.GetRadio()).ToList();
        }

        public List<Figura> OrdenarDesc()
        {
            return Lista.OrderByDescending(c => c.GetRadio()).ToList();

        }

        public void Editar(Figura figuraCopia, Figura figuraEditar)
        {
            using (var lector = new StreamReader(_archivo))
            {
                using (var escritor = new StreamWriter(_archivoCopia))
                {
                    while (!lector.EndOfStream)
                    {
                        string lineaLeida = lector.ReadLine();
                        Figura figura = Construir(lineaLeida);
                        if (figuraCopia.GetRadio() != figura.GetRadio())
                        {
                            escritor.WriteLine(lineaLeida);
                        }
                        else
                        {
                            lineaLeida = ConstruirLinea(figuraEditar);
                            escritor.WriteLine(lineaLeida);
                        }
                    }
                }
            }
            File.Delete(_archivo);
            File.Move(_archivoCopia, _archivo);

        }
    }
}
