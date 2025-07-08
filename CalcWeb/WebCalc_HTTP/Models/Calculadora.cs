// Models/Calculadora.cs
namespace CalculadoraWeb.Models
{
    public class Calculadora
    {
        public int Numero1 { get; set; }
        public int Numero2 { get; set; }
        public int Operacao { get; set; } // 1:+, 2:-, 3:*, 4:/
        public int Resultado { get; private set; }

        public void Calcular()
        {
            switch (Operacao)
            {
                case 1:
                    Resultado = Numero1 + Numero2;
                    break;
                case 2:
                    Resultado = Numero1 - Numero2;
                    break;
                case 3:
                    Resultado = Numero1 * Numero2;
                    break;
                case 4:
                    if (Numero2 != 0) // Previne divisão por zero
                    {
                        Resultado = Numero1 / Numero2;
                    }
                    else
                    {
                        // Você pode adicionar uma lógica para erro aqui, talvez lançar uma exceção
                        // ou definir Resultado para um valor específico de erro.
                        // Por simplicidade, vamos deixar como está para este exemplo.
                    }
                    break;
                default:
                    // Operação Inválida - você pode lidar com isso na View ou Controller
                    break;
            }
        }
    }
}