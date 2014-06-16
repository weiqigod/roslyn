﻿// Copyright (c) Microsoft Open Technologies, Inc.  All Rights Reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.

using System;
using System.ComponentModel.Composition;

namespace Microsoft.CodeAnalysis.MSBuild
{
    [MetadataAttribute]
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
    internal class ProjectTypeGuidAttribute : Attribute
    {
        public ProjectTypeGuidAttribute(string guid)
        {
            this.ProjectTypeGuid = guid;
        }

        public string ProjectTypeGuid { get; set; }
    }
}