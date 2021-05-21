﻿using System;
using BasicHTTPServer;
using BasicHTTPServer.Response;

namespace TestProject
{
    class Program
    {
        static void Main(string[] args)
        {
            BasicHTTPServer.HTTPServer server = new BasicHTTPServer.HTTPServer(8080);
            server.AddHandler("/hallowelt", halloweltRequest);
            server.StartListening();
            Console.ReadKey();
        }

        private static BasicHTTPResponse halloweltRequest(HTTPRequest request)
        {
            Console.WriteLine("Hallo Welt Request Received!");
            return new BasicHTTPTextResponse("Hallo Welt");
        }
    }
}