Console.Clear();

    Console.BackgroundColor = ConsoleColor.DarkRed;

Console.WriteLine("---Super calculo de horas trabalhadas!!!---");

    Console.ResetColor();

Console.Write("Digite o valor da hora-base (R$): ");
    decimal valorHora = Convert.ToDecimal(Console.ReadLine()!);

Console.Write("Digite o total de horas normais trabalhadas: ");
    decimal horasNormais = Convert.ToDecimal(Console.ReadLine()!);

Console.Write("Digite o valor de horas extras trabalhadas: ");
    decimal horasExtras = Convert.ToDecimal(Console.ReadLine()!);

    decimal salarioTotal = CalcularSalario(valorHora, horasNormais, horasExtras);

Console.WriteLine($"\nSalário total com horas extras: R$ {salarioTotal:F1}");

decimal CalcularSalario(decimal valorHora, decimal horasNormais, decimal horasExtras)
{
    decimal salarioHorasNormais = valorHora * horasNormais;
    decimal valorHoraExtra = valorHora * 1.4m;
    decimal SalarioHorasExtra = valorHoraExtra * horasExtras;

    return salarioHorasNormais + SalarioHorasExtra;
}
