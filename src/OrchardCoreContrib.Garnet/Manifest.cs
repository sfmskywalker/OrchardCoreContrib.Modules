﻿using OrchardCore.Modules.Manifest;
using ManifestConstants = OrchardCoreContrib.Modules.Manifest.ManifestConstants;

[assembly: Module(
    Name = "Garnet",
    Author = ManifestConstants.Author,
    Website = ManifestConstants.Website,
    Version = "1.3.0"
)]

[assembly: Feature(
    Id = "OrchardCoreContrib.Garnet",
    Name = "Garnet",
    Description = "Garnet configuration support.",
    Category = "Distributed Caching"
)]

[assembly: Feature(
    Id = "OrchardCoreContrib.Garnet.Cache",
    Name = "Garnet Cache",
    Description = "Distributed cache using Garnet.",
    Dependencies = ["OrchardCoreContrib.Garnet"],
    Category = "Distributed Caching"
)]

[assembly: Feature(
    Id = "OrchardCoreContrib.Garnet.Bus",
    Name = "Garnet Bus",
    Description = "Makes the Signal service distributed though Garnet.",
    Dependencies = ["OrchardCoreContrib.Garnet"],
    Category = "Distributed Caching"
)]

[assembly: Feature(
    Id = "OrchardCoreContrib.Garnet.DataProtection",
    Name = "Garnet DataProtection",
    Description = "Distributed DataProtection using Garnet.",
    Dependencies = ["OrchardCoreContrib.Garnet"],
    Category = "Distributed Caching"
)]
