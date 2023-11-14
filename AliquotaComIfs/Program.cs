namespace AliquotaComIfs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double salario = 3300.0;

            if (salario > 1900.0 && salario <= 2800.0)
            {
                double impostoRenda = 7.5;
                double valorDeclarar = 142;
                Console.WriteLine("O IR que será pago é de " + impostoRenda + "% ao ano, no valor de " + valorDeclarar);

            }         

            if (salario >= 2800.01 && salario <= 3751.0)
            {
                int impostoRenda = 15;
                double valorDeclarar = 350;
                Console.WriteLine("O IR que será pago é de " + impostoRenda + "% ao ano, no valor de " + valorDeclarar);
            } 
            if (salario >= 3751.00 && salario <= 4664.00)
            {
                double impostoRenda = 22.5;
                int valorDeclarar = 636;
                Console.WriteLine("O IR que será pago é de " + impostoRenda + "% ao ano, no valor de " + valorDeclarar);
            } 
        }
    }
}