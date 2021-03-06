﻿// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="DocumentTests.cs" company="BaerDev">
// // Copyright (c) BaerDev. All rights reserved.
// // </copyright>
// // <summary>
// // The file 'DocumentTests.cs'.
// // </summary>
// // --------------------------------------------------------------------------------------------------------------------

namespace DocumentModule.Tests
{
    using System;
    using System.Collections.Generic;
    using ExAs;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using Modules.Document;
    using Modules.Document.Models;

    [TestClass]
    public class DocumentTests
    {
        [TestMethod]
        [TestCategory("PropertyTests")]
        [TestCategory("DocumentModule")]
        [TestProperty("Created", "2016-03-17")]
        [TestProperty("Creator", "baerf")]
        [TestCategory("HappyCase")]
        public void PropertyTest()
        {
            string tagToAssert = "Tag";

            Document document = new Document
                                    {
                                        Path = "Path",
                                        Tags = new List<string> { tagToAssert },
                                        DateReceived = DateTime.Now,
                                        Id = "Document",
                                        Name = "MyDocument",
                                        Imported = new DateTime(2014, 03, 13, 19, 24, 00)
                                    };

            document.ExAssert(
                x =>
                x.Member(m => m.Id)
                    .IsEqualTo(document.Id)
                    .Member(m => m.Name)
                    .IsEqualTo(document.Name)
                    .Member(m => m.DateReceived)
                    .IsOnSameDayAs(document.DateReceived)
                    .Member(m => m.Imported)
                    .IsOnSameDayAs(document.Imported)
                    .Member(m => m.Path)
                    .IsEqualTo(document.Path)
                    .Member(m => m.Tags[0])
                    .IsEqualTo(tagToAssert));
        }
    }
}