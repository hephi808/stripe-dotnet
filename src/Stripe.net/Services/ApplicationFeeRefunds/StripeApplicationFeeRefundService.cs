namespace Stripe
{
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    using Stripe.Infrastructure;

    public class StripeApplicationFeeRefundService : StripeBasicService<StripeApplicationFeeRefund>
    {
        public StripeApplicationFeeRefundService()
            : base(null)
        {
        }

        public StripeApplicationFeeRefundService(string apiKey)
            : base(apiKey)
        {
        }

        public bool ExpandBalanceTransaction { get; set; }

        public bool ExpandFee { get; set; }

        public virtual StripeApplicationFeeRefund Create(string applicationFeeId, StripeApplicationFeeRefundCreateOptions createOptions = null, StripeRequestOptions requestOptions = null)
        {
            return this.Post($"{Urls.BaseUrl}/application_fees/{applicationFeeId}/refunds", requestOptions, createOptions);
        }

        public virtual StripeApplicationFeeRefund Get(string applicationFeeId, string refundId, StripeRequestOptions requestOptions = null)
        {
            return this.GetEntity($"{Urls.BaseUrl}/application_fees/{applicationFeeId}/refunds/{refundId}", requestOptions);
        }

        public virtual StripeApplicationFeeRefund Update(string applicationFeeId, string refundId, StripeApplicationFeeRefundUpdateOptions updateOptions, StripeRequestOptions requestOptions = null)
        {
            return this.Post($"{Urls.BaseUrl}/application_fees/{applicationFeeId}/refunds/{refundId}", requestOptions, updateOptions);
        }

        public virtual StripeList<StripeApplicationFeeRefund> List(string applicationFeeId, StripeApplicationFeeRefundListOptions listOptions = null, StripeRequestOptions requestOptions = null)
        {
            return this.GetEntityList($"{Urls.BaseUrl}/application_fees/{applicationFeeId}/refunds", requestOptions, listOptions);
        }

        public virtual Task<StripeApplicationFeeRefund> CreateAsync(string applicationFeeId, StripeApplicationFeeRefundCreateOptions createOptions = null, StripeRequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.PostAsync($"{Urls.BaseUrl}/application_fees/{applicationFeeId}/refunds", requestOptions, cancellationToken, createOptions);
        }

        public virtual Task<StripeApplicationFeeRefund> GetAsync(string applicationFeeId, string refundId, StripeRequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.GetEntityAsync($"{Urls.BaseUrl}/application_fees/{applicationFeeId}/refunds/{refundId}", requestOptions, cancellationToken);
        }

        public virtual Task<StripeApplicationFeeRefund> UpdateAsync(string applicationFeeId, string refundId, StripeApplicationFeeRefundUpdateOptions updateOptions, StripeRequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.PostAsync($"{Urls.BaseUrl}/application_fees/{applicationFeeId}/refunds/{refundId}", requestOptions, cancellationToken, updateOptions);
        }

        public virtual Task<StripeList<StripeApplicationFeeRefund>> ListAsync(string applicationFeeId, StripeApplicationFeeRefundListOptions listOptions = null, StripeRequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.GetEntityListAsync($"{Urls.BaseUrl}/application_fees/{applicationFeeId}/refunds", requestOptions, cancellationToken, listOptions);
        }
    }
}
