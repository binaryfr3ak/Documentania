﻿// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="DocumentaniaDocumentStoreTests.cs" company="BaerDev">
// // Copyright (c) BaerDev. All rights reserved.
// // </copyright>
// // <summary>
// // The file 'DocumentaniaDocumentStoreTests.cs'.
// // </summary>
// // --------------------------------------------------------------------------------------------------------------------

namespace DataAccess.RavenDB.Tests
{
    using ExAs;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    /// <summary>
    ///     Summary description for DocumentaniaDocumentStoreTests
    /// </summary>
    [TestClass]
    public class DocumentaniaDocumentStoreTests
    {
        [TestMethod]
        [TestCategory("RavenDb")]
        public void ConstructorPassingParameterTest()
        {
            const string dataDirectory = @"C:\Documentania\";

            DocumentaniaDocumentStore store = new DocumentaniaDocumentStore();
            store.DataDirectory = dataDirectory;
            store.ExAssert(x => x.Member(m => m.DataDirectory).IsEqualTo(dataDirectory));
        }

        [TestMethod]
        [TestCategory("RavenDb")]
        public void ConstructorDefaultParameterTest()
        {
            const string defaultDataDirectory = @"C:\Documentania\Data\";

            DocumentaniaDocumentStore store = new DocumentaniaDocumentStore();
            store.ExAssert(x => x.Member(m => m.DataDirectory).IsEqualTo(defaultDataDirectory));
        }
    }
}