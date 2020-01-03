﻿using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Net;
using Abp.Domain.Entities.Auditing;

namespace Abp.WebHooks
{
    /// <summary>
    /// Table for store webhook work items. Each item stores web hook send attempt of <see cref="WebHookInfo"/> to subscribed users
    /// </summary>
    [Table("AbpWebHookWorkItems")]
    public class WebHookWorkItem : FullAuditedEntity<Guid>
    {
        /// <summary>
        /// <see cref="WebHookInfo"/> foreign id 
        /// </summary>
        public Guid WebHookId { get; set; }

        /// <summary>
        /// <see cref="WebHookSubscription"/> foreign id 
        /// </summary>
        public Guid WebHookSubscriptionId { get; set; }

        /// <summary>
        /// Webhook response content that webhook endpoint send back
        /// </summary>
        public string ResponseContent { get; set; }

        /// <summary>
        /// Webhook response status code that webhook endpoint send back
        /// </summary>
        public HttpStatusCode? ResponseStatusCode { get; set; }
    }
}
