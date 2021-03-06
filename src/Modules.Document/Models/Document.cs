﻿// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="Document.cs" company="BaerDev">
// // Copyright (c) BaerDev. All rights reserved.
// // </copyright>
// // <summary>
// // The file 'Document.cs'.
// // </summary>
// // --------------------------------------------------------------------------------------------------------------------

namespace Modules.Document.Models
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.Serialization;
    using System.Xml.Serialization;

    using Documentania.Infrastructure.Interfaces;

    public class Document : IStorable
    {
        public virtual DateTime DateReceived { get; set; } = DateTime.Now;

        public virtual DateTime Imported { get; set; }

        public virtual string Name { get; set; }

        [XmlIgnore]
        public virtual string Path { get; set; }

        public List<string> Tags { get; set; } = new List<string>();

        public virtual string Id { get; set; } = string.Empty;
    }
}