using System.Text;
using DesafioProjetoHospedagem.Models;

Console.OutputEncoding = Encoding.UTF8;


// Cria os modelos de hóspedes e cadastra na lista de hóspedes
Console.Write("\nQuantidade de hóspedes: ");
int quantidadeDeHospedes = int.Parse(Console.ReadLine());

List<Pessoa> hospedes = new List<Pessoa>();
for (int i = 1; i <= quantidadeDeHospedes; i++)
{
    Console.Write($"Nome do {i}º hóspede: ");
    Pessoa pessoa = new Pessoa(nome: Console.ReadLine());
    hospedes.Add(pessoa);
}

// Recebe as características da suíte
Console.Write("\nTipo da suíte: ");
string suiteTipo = Console.ReadLine();
Console.Write("Capacidade da suíte: ");
int suiteCapacidade = int.Parse(Console.ReadLine());
Console.Write("Valor da diária da suíte: ");
decimal suiteValorDiaria = decimal.Parse(Console.ReadLine());

// Cria a suíte com os parâmetros recebidos
Suite suite = new Suite(tipoSuite: suiteTipo, capacidade: suiteCapacidade, valorDiaria: suiteValorDiaria);

// Cria uma nova reserva, passando a suíte e os hóspedes
Console.Write("\nDias reservados: ");
Reserva reserva = new Reserva(diasReservados: int.Parse(Console.ReadLine()));
reserva.CadastrarSuite(suite);
reserva.CadastrarHospedes(hospedes);

// Exibe a quantidade de hóspedes e o valor total da reserva
Console.WriteLine("\n---------------------RESULTADO---------------------");
Console.WriteLine($"Quantidade de hóspedes: {reserva.ObterQuantidadeHospedes()}");
Console.WriteLine($"Valor total da reserva: {reserva.CalcularValorDiaria():C}");
Console.WriteLine("---------------------------------------------------\n");