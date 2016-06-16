﻿// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="DocumentServiceTests.cs" company="BaerDev">
// // Copyright (c) BaerDev. All rights reserved.
// // </copyright>
// // <summary>
// // The file 'DocumentServiceTests.cs'.
// // </summary>
// // --------------------------------------------------------------------------------------------------------------------

namespace Document.RavenDB.UnitTests
{
    using System;
    using System.Collections.Generic;
    using System.Linq.Expressions;

    using Document.Model.Interface;
    using Document.RavenRepository;

    using Documentania.Infrastructure.Interfaces;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using Moq;

    using Document = Document.Model.Models.Document;
    using Tag = Document.Model.Models.Tag;

    [TestClass]
    public class DocumentServiceTests
    {
        [TestMethod]
        [TestCategory("documentMetaDataService")]
        [TestCategory("DocumentModule")]
        [TestProperty("Created", "2016-03-17")]
        [TestProperty("Creator", "baerf")]
        [TestCategory("HappyCase")]
        public void AddDocumentTest()
        {
            Mock<IRepository> repositoryMock = new Mock<IRepository>();
            Mock<IDocumentStorage> storageMock = new Mock<IDocumentStorage>();

            Tag tagToAdd = new Tag() { Value = "Tag" };

            Document documentToAdd = new Document()
                                         {
                                             Imported = new DateTime(2013, 3, 20),
                                             Name = "DocumentName",
                                             DateReceived = new DateTime(2012, 1, 13),
                                             Path = "DocumentPath",
                                             Tags = new List<Tag>() { tagToAdd }
                                         };

            IDocumentMetaDataService documentMetaDataService = new DocumentMetaDataService(repositoryMock.Object, storageMock.Object);
            documentMetaDataService.AddDocument(documentToAdd);

            repositoryMock.Verify(x => x.Add(documentToAdd));
        }

        [TestMethod]
        [TestCategory("documentMetaDataService")]
        [TestCategory("DocumentModule")]
        [TestProperty("Created", "2016-03-17")]
        [TestProperty("Creator", "baerf")]
        [TestCategory("HappyCase")]
        public void GetDocumentByIdTest()
        {
            Mock<IRepository> repositoryMock = new Mock<IRepository>();
            Mock<IDocumentStorage> storageMock = new Mock<IDocumentStorage>();

            Tag tagToAdd = new Tag() {Value = "Tag" };

            Document documentToFind = new Document()
                                          {
                                              Id = "ID",
                                              Imported = new DateTime(2013, 3, 20),
                                              Name = "DocumentName",
                                              DateReceived = new DateTime(2012, 1, 13),
                                              Path = "DocumentPath",
                                              Tags = new List<Tag>() { tagToAdd }
                                          };

            repositoryMock.Setup(x => x.Single<Document>(It.IsAny<Expression<Func<Document, bool>>>()));

            IDocumentMetaDataService documentMetaDataService = new DocumentMetaDataService(repositoryMock.Object, storageMock.Object);
            documentMetaDataService.GetDocumentById(documentToFind.Id);

            repositoryMock.Verify(x => x.Single<Document>(It.IsAny<Expression<Func<Document, bool>>>()));
        }

        [TestMethod]
        [TestCategory("documentMetaDataService")]
        [TestCategory("DocumentModule")]
        [TestProperty("Created", "2016-03-17")]
        [TestProperty("Creator", "baerf")]
        [TestCategory("HappyCase")]
        public void GetDocumentByNameTest()
        {
            Mock<IRepository> repositoryMock = new Mock<IRepository>();
            Mock<IDocumentStorage> storageMock = new Mock<IDocumentStorage>();

            Tag tagToAdd = new Tag() { Value = "Tag" };

            Document documentToFind = new Document()
                                          {
                                              Id = "ID",
                                              Imported = new DateTime(2013, 3, 20),
                                              Name = "DocumentName",
                                              DateReceived = new DateTime(2012, 1, 13),
                                              Path = "DocumentPath",
                                              Tags = new List<Tag>() { tagToAdd }
                                          };

            repositoryMock.Setup(x => x.Single<Document>(It.IsAny<Expression<Func<Document, bool>>>()));

            IDocumentMetaDataService documentMetaDataService = new DocumentMetaDataService(repositoryMock.Object, storageMock.Object);
            documentMetaDataService.GetDocumentByName(documentToFind.Name);

            repositoryMock.Verify(x => x.Single<Document>(It.IsAny<Expression<Func<Document, bool>>>()));
        }
    }
}