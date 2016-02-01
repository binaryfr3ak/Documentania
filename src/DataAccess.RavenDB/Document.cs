﻿// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="Document.cs" company="BaerDev">
// // Copyright (c) BaerDev. All rights reserved.
// // </copyright>
// // <summary>
// // The file 'Document.cs'.
// // </summary>
// // --------------------------------------------------------------------------------------------------------------------

namespace DataAccess.RavenDB
{
    using System;
    using System.Collections.Generic;

    public class Document
    {
        public virtual DateTime DateReceived { get; set; }

        public virtual string Id { get; set; }

        public virtual DateTime Imported { get; set; }

        public virtual string Path { get; set; }

        public List<Tag> Tags { get; set; } = new List<Tag>();
    }
}