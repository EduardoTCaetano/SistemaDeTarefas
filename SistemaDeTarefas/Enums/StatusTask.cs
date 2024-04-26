﻿using System.ComponentModel;

namespace SistemaDeTarefas.Enums
{
    public enum StatusTask
    {
        [Description("A fazer")]
        AFazer = 1,
        [Description("Em andamento")]
        EmAndamento = 2,
        [Description("Concluido")]
        Concluido = 3,
    }
}
