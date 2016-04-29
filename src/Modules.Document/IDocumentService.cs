﻿// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="IStorableService.cs" company="BaerDev">
// // Copyright (c) BaerDev. All rights reserved.
// // </copyright>
// // <summary>
// // The file 'IStorableService.cs'.
// // </summary>
// // --------------------------------------------------------------------------------------------------------------------

namespace Modules.Document
{
    using System;
    using System.Collections.Generic;

    using Documentania.Infrastructure.Models;

    public interface IDocumentService : IDisposable
    {
        void AddDocument(Document document);

        Document GetDocumentById(string id);

        Document GetDocumentByName(string name);

        ICollection<Document> GetAll();

        ICollection<Document> SearchByTag(Tag tag);

        ICollection<Document> SearchByName(string name);
    }
}