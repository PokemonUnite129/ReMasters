using System;
using ReMastersLib;

namespace ReMastersConsole
{
    public static class Program
    {
        private static void Main(string[] args)
        {
            if (args.Length > 1)
            {
                Console.WriteLine("Not a console app, really. Don't do that!");
                Console.ReadLine();
            }

            var paths = new GameDataPaths
            {
                // Default locations for a typical workflow. Adjust these
                // if your files live elsewhere.
                UnpackedAPKPath = @"E:\ReallyNeedHelp\PkmMaster\MastersEX",
                DownloadPath = @"E:\ReallyNeedHelp\PkmMaster\Datamine256\Datamine",
                ShardPath = @"E:\ReallyNeedHelp\PkmMaster\Datamine256\Datamine\assetdb_shard",

                OutputPath = @"E:\ReallyNeedHelp\PkmMaster\Datamine25600",
            };

            var settings = new DumpSettings(paths)
            {
                DumpStringsDL = true,
                DumpStringsAPK = true,

                DumpResources = true,
                DumpSound = true,
                DumpVideo = true,
                DumpProto = false,
            };

            settings.DumpGameData();
        }
    }
}
