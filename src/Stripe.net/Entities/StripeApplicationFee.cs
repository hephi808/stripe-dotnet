﻿namespace Stripe
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class StripeApplicationFee : StripeEntityWithId
    {
        [JsonProperty("object")]
        public string Object { get; set; }

        #region Expandable Account
        public string AccountId { get; set; }

        [JsonIgnore]
        public Account Account { get; set; }

        [JsonProperty("account")]
        internal object InternalAccount
        {
            set
            {
                StringOrObject<Account>.Map(value, s => this.AccountId = s, o => this.Account = o);
            }
        }
        #endregion

        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("amount_refunded")]
        public int AmountRefunded { get; set; }

        #region Expandable Application
        public string ApplicationId { get; set; }

        [JsonIgnore]
        public StripeApplication Application { get; set; }

        [JsonProperty("application")]
        internal object InternalApplication
        {
            set
            {
                StringOrObject<StripeApplication>.Map(value, s => this.ApplicationId = s, o => this.Application = o);
            }
        }
        #endregion

        #region Expandable Balance Transaction
        public string BalanceTransactionId { get; set; }

        [JsonIgnore]
        public StripeBalanceTransaction BalanceTransaction { get; set; }

        [JsonProperty("balance_transaction")]
        internal object InternalBalanceTransaction
        {
            set
            {
                StringOrObject<StripeBalanceTransaction>.Map(value, s => this.BalanceTransactionId = s, o => this.BalanceTransaction = o);
            }
        }
        #endregion

        #region Expandable Charge
        public string ChargeId { get; set; }

        [JsonIgnore]
        public StripeCharge Charge { get; set; }

        [JsonProperty("charge")]
        internal object InternalCharge
        {
            set
            {
                StringOrObject<StripeCharge>.Map(value, s => this.ChargeId = s, o => this.Charge = o);
            }
        }
        #endregion

        [JsonProperty("created")]
        [JsonConverter(typeof(StripeDateTimeConverter))]
        public DateTime Created { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("livemode")]
        public bool LiveMode { get; set; }

        #region Expandable Originating Transaction
        public string OriginatingTransactionId { get; set; }

        [JsonIgnore]
        public StripeCharge OriginatingTransaction { get; set; }

        [JsonProperty("originating_transaction")]
        internal object InternalOriginatingTransaction
        {
            set
            {
                StringOrObject<StripeCharge>.Map(value, s => this.OriginatingTransactionId = s, o => this.OriginatingTransaction = o);
            }
        }
        #endregion

        [JsonProperty("refunded")]
        public bool Refunded { get; set; }

        [JsonProperty("refunds")]
        public StripeList<StripeApplicationFeeRefund> StripeApplicationFeeRefundList { get; set; }
    }
}