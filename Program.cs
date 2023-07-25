using System;
using log4net;
using log4net.Config;

public class Program
{
    private static readonly ILog Logger = LogManager.GetLogger(typeof(Program));
    static void Main()
    {
        // Konfigurasi log4net dari file eksternal
        XmlConfigurator.Configure(new System.IO.FileInfo("log4net.config"));
        Logger.Info("Aplikasi telah dimulai.");
        // Logging pesan dengan tingkatan yang berbeda
        Logger.Debug("Ini adalah pesan tingkatan Debug");
        Logger.Info("Ini adalah pesan tingkatan Info");
        Logger.Warn("Ini adalah pesan tingkatan Warning");
        Logger.Error("Ini adalah pesan tingkatan Error");
        Logger.Fatal("Ini adalah pesan tingkatan Fatal");
    }
}