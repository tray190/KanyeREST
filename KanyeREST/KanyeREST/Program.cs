﻿using Newtonsoft.Json.Linq;
using System;
using System.Net.Http;

namespace KanyeREST
{
    public class Program
    {
        static void Main(string[] args)
        {
            QuoteGenerator.KanyeQuote();
            QuoteGenerator.RonQuote();

        }
    }
}
