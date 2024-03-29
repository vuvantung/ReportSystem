﻿using NewBalance.Application.Interfaces.Services;
using System;

namespace NewBalance.Infrastructure.Shared.Services
{
    public class SystemDateTimeService : IDateTimeService
    {
        public DateTime NowUtc => DateTime.UtcNow;
    }
}