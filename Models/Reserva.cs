using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hotel.Models;

namespace Hotel.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva () {}

        public Reserva(int diasReservados) 
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes (List<Pessoa> hospedes)
        {
            
            if (hospedes.Count <= Suite.Capacidade)
            {
                Hospedes = hospedes;
            }
            else
            {
                throw new Exception("A quantidade de hóspedes excede a capacidade da suíte");
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            int quantidadeHospedes = Hospedes.Count;
            return quantidadeHospedes;
        }

        public decimal CalcularValorDiaria()
        {
            decimal valorDiaria = Suite.ValorDiaria;
            decimal valor = valorDiaria * DiasReservados;

            decimal desconto = 0.10m; 
        
            decimal valorComDesconto = valor; 

            if (DiasReservados >= 10)
                {
                    valorComDesconto -= valorDiaria * desconto; 
                }

            return valorComDesconto;
        }

    }
}