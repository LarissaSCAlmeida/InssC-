namespace ProjetoINSS.Services
{
    public static class INSSService
    {
        public static double CalcularINSS(double salario)
        {
            double inss = 0;
            
            if (salario <= 1412.00)
                inss = salario * 0.075;
            else if (salario <= 2666.68)
                inss = (1412.00 * 0.075) + ((salario - 1412.00) * 0.09);
            else if (salario <= 4000.03)
                inss = (1412.00 * 0.075) + ((2666.68 - 1412.00) * 0.09) + ((salario - 2666.68) * 0.12);
            else if (salario <= 7786.02)
                inss = (1412.00 * 0.075) + ((2666.68 - 1412.00) * 0.09) + ((4000.03 - 2666.68) * 0.12) + ((salario - 4000.03) * 0.14);
            else
                inss = (1412.00 * 0.075) + ((2666.68 - 1412.00) * 0.09) + ((4000.03 - 2666.68) * 0.12) + ((7786.02 - 4000.03) * 0.14);

            return inss;
        }
    }
}
