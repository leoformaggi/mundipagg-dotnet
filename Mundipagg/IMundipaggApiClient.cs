﻿using Mundipagg.Resources.Interface;

namespace Mundipagg
{
    /// <summary>
    /// Mundipagg Api Client
    /// </summary>
    public interface IMundipaggApiClient
    {
        /// <summary>
        /// Accounts resource
        /// </summary>
        IAccountResource Account { get; }

        /// <summary>
        /// Merchants resource
        /// </summary>
        IMerchantResource Merchant { get; }

        /// <summary>
        /// Customers resource
        /// </summary>
        ICustomerResource Customer { get; }

        /// <summary>
        /// Webhook resource
        /// </summary>
        IWebhookResource Webhook { get; }

        /// <summary>
        /// Charges resource
        /// </summary>
        IChargeResource Charge { get; }

        /// <summary>
        /// Invoices resource
        /// </summary>
        IInvoiceResource Invoice { get; }

        /// <summary>
        /// Orders resource
        /// </summary>
        IOrderResource Order { get; }

        /// <summary>
        /// Subscriptions resource
        /// </summary>
        ISubscriptionResource Subscription { get; }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="secretKey"></param>
        /// <param name="requestKey"></param>
        /// <param name="apiUrl"></param>
        /// <param name="timeout"></param>
        /// <param name="mpToken"></param>
        /// <param name="accountManagementKey"></param>
        /// <param name="merchantId"></param>
        /// <param name="accountId"></param>
        void UpdateConfiguration(string secretKey = null,
            string requestKey = null,
            string apiUrl = null,
            int? timeout = null,
            string mpToken = null,
            string accountManagementKey = null,
            string merchantId = null,
            string accountId = null);
    }
}