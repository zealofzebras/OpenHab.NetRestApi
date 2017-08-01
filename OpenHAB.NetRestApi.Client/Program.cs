﻿using System;
using System.Linq;
using OpenHAB.NetRestApi.RestApi;

namespace OpenHAB.NetRestApi.Client
{
    /// <summary>
    /// THIS IS A TEST ENVIRONMENT (can be ignored)
    /// </summary>
    class Program
    {
        //private const string Url = "http://localhost:8080/rest";
        private const string Url = "http://192.168.2.111:8080/rest";

        static void Main(string[] args)
        {
            var openHab = OpenHab.CreateRestClient(Url);

            var configDescriptors = openHab.ConfigDescriptionService.GetConfigDescriptors();
            var configDescriptor = openHab.ConfigDescriptionService.GetConfigDescriptor(configDescriptors.FirstOrDefault()?.Uri);

            Console.ReadLine();
        }
    }
}
