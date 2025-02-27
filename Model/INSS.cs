namespace DS.Model
{
    public class INSS
    {
        public static double CalcularDesconto(double salario)
        {
            if (salario <= 1412.00)
                return salario * 0.075;
            else if (salario <= 2666.68)
                return salario * 0.09;
            else if (salario <= 4000.03)
                return salario * 0.12;
            else
                return salario * 0.14;
        }
    }
}
