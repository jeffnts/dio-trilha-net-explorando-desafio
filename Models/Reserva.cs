namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva() { }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
           if (hospedes.Count <= Suite.Capacidade)
            {
                Hospedes = hospedes;
            }
            else
            {
                // Lançar uma exceção caso a capacidade seja excedida
                throw new ArgumentException("Número de hóspedes excede a capacidade da suíte.");
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            return Hospedes.Count;
        }

        public decimal CalcularValorDiaria()
        {
        // Cálculo: DiasReservados X Suite.ValorDiaria
        decimal valor = DiasReservados * Suite.ValorDiaria;

        // Regra: Caso os dias reservados forem maior ou igual a 10, conceder um desconto de 10%
        if (DiasReservados >= 10)
        {
            valor *= 0.9m; // Aplicar desconto de 10%
        }

        return valor;
        }   
    }
}