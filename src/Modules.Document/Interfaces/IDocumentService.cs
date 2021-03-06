﻿// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="IDocumentService.cs" company="BaerDev">
// // Copyright (c) BaerDev. All rights reserved.
// // </copyright>
// // <summary>
// // The file 'IDocumentService.cs'.
// // </summary>
// // --------------------------------------------------------------------------------------------------------------------

namespace Modules.Document.Interfaces
{
    using System;
    using System.Collections.Generic;
    using Models;

    public interface IDocumentService : IDisposable
    {
        void AddDocument(Document document);

        void DeleteDocument(Document document);

        Document GetDocumentById(string id);

        Document GetDocumentByName(string name);

        ICollection<Document> GetAll();

        ICollection<Document> SearchByTag(string tag);

        ICollection<Document> SearchByName(string name);
    }
}