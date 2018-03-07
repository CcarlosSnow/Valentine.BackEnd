﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valentine.Application.T_Archivo.Queries.GetByCodigoSolCredito
{
    public interface IGetArchivoByCodigoSolCreditoQuery
    {
        List<Data.T_Archivo> Execute(int CodigoSolCredito);
    }
}
