﻿using System;

namespace Reserva.Domain.Entities
{
    public class Reservas
    {
        public Reservas(
            int reservaId, 
            DateTime dataInicio,
            DateTime horaInicio, 
            DateTime dataFim,
            DateTime horaFim, 
            bool café, 
            int quantidadePessoa,
            int usuarioId ,
            int salaId
            )
        {
            ReservaId = reservaId;
            DataInicio = dataInicio;
            HoraInicio = horaInicio;
            DataFim = dataFim;
            HoraFim = horaFim;
            Café = café;
            QuantidadePessoa = quantidadePessoa;
            UsuarioId = usuarioId;
            SalaId = salaId;
        }

        public int ReservaId { get; private set; }
        public DateTime DataInicio { get; private set; }
        public DateTime HoraInicio { get; private set; }
        public DateTime DataFim { get; private set; }
        public DateTime HoraFim { get; private set; }
        public bool Café { get; private set; }
        public int QuantidadePessoa { get; private set; }
        public int UsuarioId { get; private set; }
        public int SalaId { get; private set; }


    }
}
