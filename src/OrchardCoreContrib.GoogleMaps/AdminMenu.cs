﻿using Microsoft.Extensions.Localization;
using OrchardCore.Navigation;
using OrchardCoreContrib.GoogleMaps.Drivers;
using System;
using System.Threading.Tasks;

namespace OrchardCoreContrib.GoogleMaps
{
    /// <summary>
    /// Represents an admin menu for GoogleMaps module.
    /// </summary>
    public class AdminMenu : INavigationProvider
    {
        private readonly IStringLocalizer S;

        /// <summary>
        /// Initializes a new instance of <see cref="AdminMenu"/>.
        /// </summary>
        /// <param name="stringLocalizer"></param>
        public AdminMenu(IStringLocalizer<AdminMenu> stringLocalizer)
        {
            S = stringLocalizer;
        }

        /// <inheritdoc/>
        public Task BuildNavigationAsync(string name, NavigationBuilder builder)
        {
            if (!string.Equals(name, "admin", StringComparison.OrdinalIgnoreCase))
            {
                return Task.CompletedTask;
            }

            builder
                .Add(S["Configuration"], configuration => configuration
                    .Add(S["Settings"], settings => settings
                       .Add(S["Google Maps"], S["Google Maps"].PrefixPosition(), entry => entry
                       .AddClass("googlemaps").Id("googlemaps")
                          .Action("Index", "Admin", new { area = "OrchardCore.Settings", groupId = GoogleMapsSettingsDisplayDriver.GroupId })
                          .Permission(Permissions.ManageGoogleMapsSettings)
                          .LocalNav()
                )));

            return Task.CompletedTask;
        }
    }
}