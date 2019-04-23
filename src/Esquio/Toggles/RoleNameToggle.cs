﻿using Esquio.Abstractions;
using Esquio.Abstractions.Providers;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Esquio.Toggles
{
    [DesignTypeParameter(ParameterName = Roles, ParameterType = "System.String", ParameterDescription = "The collection of rol(es) to activate this toggle separated by ';' character")]
    public class RoleNameToggle
       : IToggle
    {
        const string SPLIT_SEPARATOR = ";";
        const string Roles = nameof(Roles);
        private readonly IRoleNameProviderService _roleNameProviderService;
        private readonly IFeatureStore _featureStore;

        public RoleNameToggle(IRoleNameProviderService roleNameProviderService, IFeatureStore featureStore)
        {
            _roleNameProviderService = roleNameProviderService ?? throw new ArgumentNullException(nameof(roleNameProviderService));
            _featureStore = featureStore ?? throw new ArgumentNullException(nameof(featureStore));
        }

        public async Task<bool> IsActiveAsync(IFeatureContext context)
        {
            var currentRole = await _roleNameProviderService
                .GetCurrentRoleNameAsync();

            if (currentRole != null)
            {
                var activeRoles = (string)await _featureStore
                    .GetToggleParameterValueAsync<UserNameToggle>(context.ApplicationName, context.FeatureName, Roles);

                if (activeRoles != null &&
                    activeRoles.Split(SPLIT_SEPARATOR).Contains(currentRole, StringComparer.InvariantCultureIgnoreCase))
                {
                    return true;
                }
            }

            return false;
        }
    }
}
