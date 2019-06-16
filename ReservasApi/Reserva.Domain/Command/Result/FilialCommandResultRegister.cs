﻿using Reserva.Shared.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace Reserva.Domain.Command.Result
{
    public class FilialCommandResultRegister: ICommadResult
    {
        public FilialCommandResultRegister(int filialId, string nome)
        {
            FilialId = filialId;
            Nome = nome;
        }

        public int FilialId { get; set; }
        public string Nome { get; set; }
    }
}
