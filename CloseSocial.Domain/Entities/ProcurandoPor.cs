﻿using CloseSocial.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace CloseSocial.Domain.Entities
{
    public class ProcurandoPor
    {
        public int Id  { get; set; }        
        public string Descricao { get; set; }        
        public bool NaoEspecificado { get { return Id == (int)ProcurandoPorEnum.NaoEspecificado; } }
        public bool Namoro { get { return Id == (int)ProcurandoPorEnum.Namoro; } }
        public bool Amizade { get { return Id == (int)ProcurandoPorEnum.Amizade; } }
        public bool RelacionamentoSerio { get { return Id == (int)ProcurandoPorEnum.RelacionamentoSerio; } }
    }
}
