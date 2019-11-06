﻿using System;
using System.IO;
using System.Reflection;
using System.Xml;

namespace Log4Net.ConsoleApp
{
    class Program
    {
        private static readonly log4net.ILog log =
        log4net.LogManager.GetLogger(typeof(Program));
        static void Main(string[] args)
        {
            XmlDocument log4netConfig = new XmlDocument();
            log4netConfig.Load(File.OpenRead("log4net.config"));

            var repo = log4net.LogManager.CreateRepository(
                Assembly.GetEntryAssembly(), typeof(log4net.Repository.Hierarchy.Hierarchy));

            log4net.Config.XmlConfigurator.Configure(repo, log4netConfig["log4net"]);

            log.Info("Application - Main is invoked");
            

            Console.WriteLine("Hello World!");
        }
    }
}
