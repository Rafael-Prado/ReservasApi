﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Reserva.Shared.Commands
{
    public interface ICommandHandle<T> where T: ICommand
    {
        ICommadResult Handle(T commad);
    }
}
