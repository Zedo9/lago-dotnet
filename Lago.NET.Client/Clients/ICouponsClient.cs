using System.Threading;
using System.Threading.Tasks;

using Lago.NET.Client.DTOs.Filters;
using Lago.NET.Client.DTOs.Inputs;
using Lago.NET.Client.DTOs.ListResults;
using Lago.NET.Client.Models;

using Refit;

namespace Lago.NET.Client.Clients
{
    public interface ICouponsClient
    {
        async Task<Coupon> CreateAsync(
            CreateOrUpdateCouponInput createOrUpdateCouponInput,
            CancellationToken cancellationToken = default)
        {
            var result = await CreateAsyncInternal(
                new CreateOrUpdateCouponInputWrapper(createOrUpdateCouponInput),
                cancellationToken);

            return result?.Coupon;
        }

        async Task<Coupon> UpdateAsync(
            string code,
            CreateOrUpdateCouponInput createOrUpdateCouponInput,
            CancellationToken cancellationToken = default)
        {
            var result = await UpdateAsyncInternal(
                code,
                new CreateOrUpdateCouponInputWrapper(createOrUpdateCouponInput),
                cancellationToken);

            return result?.Coupon;
        }

        async Task<Coupon> DestroyAsync(
            string code,
            CancellationToken cancellationToken = default)
        {
            var result = await DeleteAsyncInternal(code, cancellationToken);

            return result?.Coupon;
        }

        async Task<Coupon> FindOneAsync(
            string code,
            CancellationToken cancellationToken = default)
        {
            var result = await FindOneAsyncInternal(code, cancellationToken);

            return result?.Coupon;
        }

        [Get("/coupons")]
        Task<CouponsResult> FindAllAsync(
             [Query] PageFilter pageFilter = null,
             CancellationToken cancellationToken = default);

        #region Internal
        [Post("/coupons")]
        internal Task<CouponWrapper> CreateAsyncInternal(
            [Body] CreateOrUpdateCouponInputWrapper createOrUpdateCouponInputWrapper,
            CancellationToken cancellationToken);

        [Put("/coupons/{code}")]
        internal Task<CouponWrapper> UpdateAsyncInternal(
            string code,
            [Body] CreateOrUpdateCouponInputWrapper createOrUpdateCouponInputWrapper,
            CancellationToken cancellationToken);

        [Delete("/coupons/{code}")]
        internal Task<CouponWrapper> DeleteAsyncInternal(
            string code,
            CancellationToken cancellationToken);

        [Get("/coupons/{code}")]
        internal Task<CouponWrapper> FindOneAsyncInternal(
            string code,
            CancellationToken cancellationToken);
        #endregion
    }
}