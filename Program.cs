using Hotel.Models;

// Cria os modelos de hóspedes e cadastra na lista de hóspedes
List<Pessoa> hospedes = new List<Pessoa>();

Pessoa pessoa1 = new Pessoa(nome: "Nome", sobrenome: "Sobrenome");
Pessoa pessoa2 = new Pessoa(nome: "Nome", sobrenome: "Sobrenome");

hospedes.Add(pessoa1);
hospedes.Add(pessoa2);

// Cria a suíte
Suite suite = new Suite(tiposuite: "Classic", capacidade: 3, valordiaria: 30 );

// Cria uma nova reserva, passando a suíte e os hóspedes
Reserva reserva = new Reserva(diasReservados: 5);
reserva.CadastrarSuite(suite);
reserva.CadastrarHospedes(hospedes);

// Exibe a quantidade de hóspedes e o valor da diária
Console.WriteLine($"Hóspedes: {reserva.ObterQuantidadeHospedes()}");
Console.WriteLine($"Valor diária: {reserva.CalcularValorDiaria()}");