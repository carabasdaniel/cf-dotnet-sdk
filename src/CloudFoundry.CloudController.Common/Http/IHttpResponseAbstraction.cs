﻿using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace CloudFoundry.CloudController.Common.Http
{
    public interface IHttpResponseAbstraction
    {
        HttpContent Content { get; }

        IHttpHeadersCollection Headers { get; }

        bool IsSuccessStatusCode { get; }

        HttpRequestMessage RequestMessage { get; set; }

        HttpStatusCode StatusCode { get; }

        Task<string> ReadContentAsStringAsync();
    }
}