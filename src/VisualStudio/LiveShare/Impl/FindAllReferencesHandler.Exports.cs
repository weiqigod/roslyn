﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.ComponentModel.Composition;
using Microsoft.CodeAnalysis.Editor.Shared.Utilities;
using Microsoft.CodeAnalysis.Host.Mef;
using Microsoft.VisualStudio.LanguageServer.Protocol;
using Microsoft.VisualStudio.LiveShare.LanguageServices;

namespace Microsoft.VisualStudio.LanguageServices.LiveShare
{
    [ExportLspRequestHandler(LiveShareConstants.RoslynContractName, Methods.TextDocumentReferencesName)]
    [Obsolete("Used for backwards compatibility with old liveshare clients.")]
    internal class RoslynFindAllReferencesHandler : FindAllReferencesHandler
    {
        [ImportingConstructor]
        [Obsolete(MefConstruction.ImportingConstructorMessage, error: true)]
        public RoslynFindAllReferencesHandler(IThreadingContext threadingContext) : base(threadingContext)
        {
        }
    }

    [ExportLspRequestHandler(LiveShareConstants.CSharpContractName, Methods.TextDocumentReferencesName)]
    internal class CSharpFindAllReferencesHandler : FindAllReferencesHandler
    {
        [ImportingConstructor]
        [Obsolete(MefConstruction.ImportingConstructorMessage, error: true)]
        public CSharpFindAllReferencesHandler(IThreadingContext threadingContext) : base(threadingContext)
        {
        }
    }

    [ExportLspRequestHandler(LiveShareConstants.VisualBasicContractName, Methods.TextDocumentReferencesName)]
    internal class VisualBasicFindAllReferencesHandler : FindAllReferencesHandler
    {
        [ImportingConstructor]
        [Obsolete(MefConstruction.ImportingConstructorMessage, error: true)]
        public VisualBasicFindAllReferencesHandler(IThreadingContext threadingContext) : base(threadingContext)
        {
        }
    }

    [ExportLspRequestHandler(LiveShareConstants.TypeScriptContractName, Methods.TextDocumentReferencesName)]
    internal class TypeScriptFindAllReferencesHandler : FindAllReferencesHandler
    {
        [ImportingConstructor]
        [Obsolete(MefConstruction.ImportingConstructorMessage, error: true)]
        public TypeScriptFindAllReferencesHandler(IThreadingContext threadingContext) : base(threadingContext)
        {
        }
    }
}
