using System.Threading;
using System.Threading.Tasks;

using Lago.NET.Client.DTOs.Inputs;
using Lago.NET.Client.Models;

using Refit;

namespace Lago.NET.Client.Clients
{
    public interface IOrganizationsClient : IFluentInterface
    {
        async Task<Organization> UpdateOrganizationAsync(
            UpdateOrganizationInput updateOrganizationInput,
            CancellationToken cancellationToken = default)
        {
            var result = await UpdateOrganizationAsyncInternal(
                new UpdateOrganizationInputWrapper(updateOrganizationInput),
                cancellationToken);

            return result?.Organization;
        }

        #region Internal
        [Put("/organizations")]
        internal Task<OrganizationWrapper> UpdateOrganizationAsyncInternal(
            UpdateOrganizationInputWrapper updateOrganizationInputWrapper,
            CancellationToken cancellationToken);
        #endregion
    }
}