﻿using Application.Dtos.Request;
using Application.Dtos.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces.Service
{
    public interface IRefreshTokenService
    {
        Task<LoginResponse> RefreshAccessToken(RefreshTokenRequest request);
    }
}
