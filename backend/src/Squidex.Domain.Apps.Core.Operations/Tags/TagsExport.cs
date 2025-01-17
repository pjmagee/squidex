﻿// ==========================================================================
//  Squidex Headless CMS
// ==========================================================================
//  Copyright (c) Squidex UG (haftungsbeschraenkt)
//  All rights reserved. Licensed under the MIT license.
// ==========================================================================

using System.Collections.Generic;

namespace Squidex.Domain.Apps.Core.Tags
{
    public class TagsExport
    {
        public Dictionary<string, Tag> Tags { get; set; }

        public Dictionary<string, string>? Alias { get; set; }

        public TagsExport Clone()
        {
            var alias = (Dictionary<string, string>?)null;

            if (Alias != null)
            {
                alias = new Dictionary<string, string>(Alias);
            }

            var tags = new Dictionary<string, Tag>(Tags);

            return new TagsExport { Alias = alias, Tags = tags };
        }
    }
}
