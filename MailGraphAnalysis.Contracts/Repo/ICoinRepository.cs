﻿using MailGraphAnalysis.Entity;
using MailGraphAnalysis.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailGraphAnalysis.Contracts.Repo
{
    public interface ICoinRepository : IBaseRepository<Coin, CoinDto, int>
    {
        Task<ICollection<CoinsWithPreviousInformationDto>> GetCoinsAllWithPreviousInformation();

    }
}