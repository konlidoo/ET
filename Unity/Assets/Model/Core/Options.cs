using CommandLine;
using System;
using System.Collections.Generic;

namespace ET
{
    public enum AppType
    {
        Server,
        Robot,
        Watcher,
    }
    
    public class Options
    {
        [Option("ServerType", Required = false, Default = AppType.Server, HelpText = "serverType enum")]
        public AppType AppType { get; set; }

        [Option("Process", Required = false, Default = 1)]
        public int Process { get; set; } = 1;
        
        [Option("Develop", Required = false, Default = 0, HelpText = "develop mode, 0正式 1开发 2压测")]
        public int Develop { get; set; } = 0;

        [Option("LogLevel", Required = false, Default = 2)]
        public int LogLevel { get; set; } = 2;
        
        [Option("Console", Required = false, Default = 0)]
        public int Console { get; set; } = 0;
    }
}