using NSE.Core.DomainObjects;
using NSE.Core.Mediator;
using System;

namespace Cliente.API.Application.Events
{
    public class ClienteRegistradoEvent : Event
    {
        public Guid Id { get; set; }
        public string Nome { get; private set; }
        public Email Email { get; private set; }
        public Cpf Cpf { get; private set; }

        public ClienteRegistradoEvent(Guid id, string nome, string email, string cpf)
        {
            AggregateId = id;
            Id = id;
            Nome = nome;
            Email = new Email(email);
            Cpf = new Cpf(cpf);
        }
    }
}
