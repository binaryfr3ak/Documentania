﻿// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="DocumentaniaLogger.cs" company="BaerDev">
// // Copyright (c) BaerDev. All rights reserved.
// // </copyright>
// // <summary>
// // The file 'DocumentaniaLogger.cs'.
// // </summary>
// // --------------------------------------------------------------------------------------------------------------------

using log4net;

namespace Documentania.Common
{
    using Prism.Logging;
    
    public class DocumentaniaLogger : ILoggerFacade
    {
        private readonly ILog logger;

        public DocumentaniaLogger()
        {
            this.logger = LogManager.GetLogger(this.GetType());
        }

        /// <summary>
        /// Writes a log message.
        /// </summary>
        /// <param name="message">The message to write.</param>
        /// <param name="category">The message category.</param>
        /// <param name="priority">Not used by Log4Net; pass Priority.None.</param>
        public void Log(string message, Category category, Priority priority)
        {
            switch (category)
            {
                case Category.Debug:
                    this.logger.Debug(message);
                    break;
                case Category.Warn:
                    this.logger.Warn(message);
                    break;
                case Category.Exception:
                    this.logger.Error(message);
                    break;
                case Category.Info:
                    this.logger.Info(message);
                    break;
            }
        }
    }
}