class PlanInternet
{

    private string _nombrePlan = null!;
    private int _velocidad;
    private decimal _precioMensual;

    public PlanInternet(string nombrePlan, int velocidad, decimal precioMensual)
    {

        NombrePlan = nombrePlan;
        Velocidad = velocidad;
        PrecioMensual = precioMensual;
}

    public string NombrePlan
    {

        get { return _nombrePlan; }
        set
        {
            /*
            if(value !== null || value != "")
            {


            }
            */

            if (!string.IsNullOrEmpty(value))
            {

                _nombrePlan = value;
            }
            else
            {

                Console.WriteLine("El nombre del plan no puede estar vacío.");
            }

        }
    }

    public int Velocidad
    {

        get{return _velocidad;}

        set
        {

            if(value > 0)
            {

                _velocidad = value;
            }
            else
            {

                Console.WriteLine("La velocidad debe ser mayor a 0(cero.)");
            }
        }
    }

    public decimal PrecioMensual
    {

        get { return _precioMensual; }

        set
        {

            if (value > 0)
            {

                _precioMensual = value;
            }
            else
            {

                Console.WriteLine("El precio mensual debe ser mayor a 0(cero.)");
            }
        }
    }

    public virtual void MostrarDetalles() //'void' siempre va acompañado del ident. de la función
    {

        Console.WriteLine($"Plan de Internet\n" +
            $"Nombre: {NombrePlan}\n " +
            $"Velocidad: {Velocidad} Mbps\n" +
            $"Precio Mensual: {PrecioMensual}");
    }
}

class PlanResidencial : PlanInternet
{

    public PlanResidencial(string nombrePlan, int velocidad, decimal planMensual) : base (nombrePlan, velocidad, planMensual) {  }

    public virtual void MostrarDetalles()
    {

        Console.WriteLine($"Plan residencial\n" +
            $"Nombre: {NombrePlan}\n " +
            $"Velocidad: {Velocidad} Mbps\n" +
            $"Precio Mensual: {PrecioMensual}");
    }
}

class PlanEmpresarial : PlanInternet
{

    public PlanEmpresarial(string nombrePlan, int velocidad, decimal planMensual) : base(nombrePlan, velocidad, planMensual) { }

    public virtual void MostrarDetalles()
    {

        Console.WriteLine($"Plan empresarial\n" +
            $"Nombre: {NombrePlan}\n " +
            $"Velocidad: {Velocidad} Mbps\n" +
            $"Precio Mensual: {PrecioMensual}");
    }
}

class PlanMovil : PlanInternet
{

    public PlanMovil(string nombrePlan, int velocidad, decimal planMensual) : base(nombrePlan, velocidad, planMensual) { }

    public virtual void MostrarDetalles()
    {

        Console.WriteLine($"Plan móvil\n" +
            $"Nombre: {NombrePlan}\n " +
            $"Velocidad: {Velocidad} Mbps\n" +
            $"Precio Mensual: {PrecioMensual}");
    }
}

class MyProgram
{

    static void Main(string[] args)
    {

        Console.WriteLine("Seleccione el tipo de plan que desea crear: ");
        Console.WriteLine("1- Plan Residencial");
        Console.WriteLine("2- Plan Empresarial");
        Console.WriteLine("3- Plan Movil\n");

        Console.Write("Ingrese; el número correspondiente al tipo de plan: ");
        int tipoPlan;
        int.TryParse(Console.ReadLine(), out tipoPlan);

        Console.Write("Ingrese el nombre del plan: ");
        string nombrePlan = Console.ReadLine();

        Console.Write("Ingrese la velocidad del plan: ");
        int velocidad;
        int.TryParse(Console.ReadLine(), out velocidad);

        Console.Write("Ingrese la velocidad del plan: ");
        decimal precioMensual;
        decimal.TryParse(Console.ReadLine(), out precioMensual);

        PlanInternet planInternet;

        switch (tipoPlan)
        {

            case 1:
                planInternet = new PlanResidencial(nombrePlan, velocidad, precioMensual); break;
            case 2:
                planInternet = new PlanEmpresarial(nombrePlan, velocidad, precioMensual); break;
            case 3:
                planInternet = new PlanMovil(nombrePlan, velocidad, precioMensual); break;
            default:
                Console.WriteLine("Opción no válida. Creando plan residencial por defecto.");
                planInternet = new PlanResidencial(nombrePlan, velocidad, precioMensual); break;
        }

        planInternet.MostrarDetalles();
    }

}
