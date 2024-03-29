﻿using NLog.Config;
using NLog.Targets;
using Playnite.SDK;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Playnite.Common
{
    public class NLogLogger : ILogger
    {
        public static bool IsTraceEnabled { get; set; } = false;
        private NLog.Logger logger;

        public NLogLogger(string loggerName)
        {
            logger = NLog.LogManager.GetLogger(loggerName);
        }

        public void Debug(string message)
        {
            logger.Debug(message);
        }

        public void Debug(Exception exception, string message)
        {
            logger.Debug(exception, message);
        }

        public void Error(string message)
        {
            logger.Error(message);
        }

        public void Error(Exception exception, string message)
        {
            logger.Error(exception, message);
        }

        public void Info(string message)
        {
            logger.Info(message);
        }

        public void Info(Exception exception, string message)
        {
            logger.Info(exception, message);
        }

        public void Warn(string message)
        {
            logger.Warn(message);
        }

        public void Warn(Exception exception, string message)
        {
            logger.Warn(exception, message);
        }

        public void Trace(string message)
        {
            if (IsTraceEnabled)
            {
                logger.Trace(message);
            }
        }

        public void Trace(Exception exception, string message)
        {
            if (IsTraceEnabled)
            {
                logger.Trace(exception, message);
            }
        }
    }

    public class NLogLogProvider : ILogProvider
    {
        public NLogLogProvider()
        {
            if (NLog.LogManager.Configuration != null)
            {
                return;
            }

            var config = new LoggingConfiguration();
#if DEBUG
            var consoleTarget = new ColoredConsoleTarget()
            {
                Layout = @"${level:uppercase=true}|${logger}:${message}${exception}"
            };

            config.AddTarget("console", consoleTarget);
            var rule1 = new LoggingRule("*", NLog.LogLevel.Trace, consoleTarget);
            config.LoggingRules.Add(rule1);
#endif

            var loggerDir = Path.GetDirectoryName(Assembly.GetCallingAssembly().Location);
            var fileTarget = new FileTarget()
            {
                FileName = Path.Combine(loggerDir, "nlog.log"),
                Layout = "${longdate}|${level:uppercase=true}:${message}${exception:format=toString}",
                KeepFileOpen = false,
                ArchiveFileName = Path.Combine(loggerDir, "nlog.{#####}.log"),
                ArchiveAboveSize = 4096000,
                ArchiveNumbering = ArchiveNumberingMode.Sequence,
                MaxArchiveFiles = 2,
                Encoding = Encoding.UTF8
            };

            config.AddTarget("file", fileTarget);
            var rule2 = new LoggingRule("*", NLog.LogLevel.Trace, fileTarget);
            config.LoggingRules.Add(rule2);
            NLog.LogManager.Configuration = config;
        }

        public ILogger GetLogger(string loggerName)
        {
            return new NLogLogger(loggerName);
        }
    }
}
