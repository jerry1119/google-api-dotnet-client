// Copyright 2021 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     https://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

// Generated code. DO NOT EDIT!

namespace Google.Apis.AdExchangeBuyer.v1_4
{
    /// <summary>The AdExchangeBuyer Service.</summary>
    public class AdExchangeBuyerService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1.4";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public AdExchangeBuyerService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public AdExchangeBuyerService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            Accounts = new AccountsResource(this);
            BillingInfo = new BillingInfoResource(this);
            Budget = new BudgetResource(this);
            Creatives = new CreativesResource(this);
            Marketplacedeals = new MarketplacedealsResource(this);
            Marketplacenotes = new MarketplacenotesResource(this);
            Marketplaceprivateauction = new MarketplaceprivateauctionResource(this);
            PerformanceReport = new PerformanceReportResource(this);
            PretargetingConfig = new PretargetingConfigResource(this);
            Products = new ProductsResource(this);
            Proposals = new ProposalsResource(this);
            Pubprofiles = new PubprofilesResource(this);
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "adexchangebuyer";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri =>
        #if NETSTANDARD1_3 || NETSTANDARD2_0 || NET45
            BaseUriOverride ?? "https://www.googleapis.com/adexchangebuyer/v1.4/";
        #else
            "https://www.googleapis.com/adexchangebuyer/v1.4/";
        #endif

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "adexchangebuyer/v1.4/";

        #if !NET40
        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri => "https://www.googleapis.com/batch/adexchangebuyer/v1.4";

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch/adexchangebuyer/v1.4";
        #endif

        /// <summary>Available OAuth 2.0 scopes for use with the Ad Exchange Buyer API.</summary>
        public class Scope
        {
            /// <summary>Manage your Ad Exchange buyer account configuration</summary>
            public static string AdexchangeBuyer = "https://www.googleapis.com/auth/adexchange.buyer";
        }

        /// <summary>Available OAuth 2.0 scope constants for use with the Ad Exchange Buyer API.</summary>
        public static class ScopeConstants
        {
            /// <summary>Manage your Ad Exchange buyer account configuration</summary>
            public const string AdexchangeBuyer = "https://www.googleapis.com/auth/adexchange.buyer";
        }

        /// <summary>Gets the Accounts resource.</summary>
        public virtual AccountsResource Accounts { get; }

        /// <summary>Gets the BillingInfo resource.</summary>
        public virtual BillingInfoResource BillingInfo { get; }

        /// <summary>Gets the Budget resource.</summary>
        public virtual BudgetResource Budget { get; }

        /// <summary>Gets the Creatives resource.</summary>
        public virtual CreativesResource Creatives { get; }

        /// <summary>Gets the Marketplacedeals resource.</summary>
        public virtual MarketplacedealsResource Marketplacedeals { get; }

        /// <summary>Gets the Marketplacenotes resource.</summary>
        public virtual MarketplacenotesResource Marketplacenotes { get; }

        /// <summary>Gets the Marketplaceprivateauction resource.</summary>
        public virtual MarketplaceprivateauctionResource Marketplaceprivateauction { get; }

        /// <summary>Gets the PerformanceReport resource.</summary>
        public virtual PerformanceReportResource PerformanceReport { get; }

        /// <summary>Gets the PretargetingConfig resource.</summary>
        public virtual PretargetingConfigResource PretargetingConfig { get; }

        /// <summary>Gets the Products resource.</summary>
        public virtual ProductsResource Products { get; }

        /// <summary>Gets the Proposals resource.</summary>
        public virtual ProposalsResource Proposals { get; }

        /// <summary>Gets the Pubprofiles resource.</summary>
        public virtual PubprofilesResource Pubprofiles { get; }
    }

    /// <summary>A base abstract class for AdExchangeBuyer requests.</summary>
    public abstract class AdExchangeBuyerBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new AdExchangeBuyerBaseServiceRequest instance.</summary>
        protected AdExchangeBuyerBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
        {
        }

        /// <summary>Data format for the response.</summary>
        [Google.Apis.Util.RequestParameterAttribute("alt", Google.Apis.Util.RequestParameterType.Query)]
        public virtual System.Nullable<AltEnum> Alt { get; set; }

        /// <summary>Data format for the response.</summary>
        public enum AltEnum
        {
            /// <summary>Responses with Content-Type of application/json</summary>
            [Google.Apis.Util.StringValueAttribute("json")]
            Json = 0,
        }

        /// <summary>Selector specifying which fields to include in a partial response.</summary>
        [Google.Apis.Util.RequestParameterAttribute("fields", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string Fields { get; set; }

        /// <summary>
        /// API key. Your API key identifies your project and provides you with API access, quota, and reports. Required
        /// unless you provide an OAuth 2.0 token.
        /// </summary>
        [Google.Apis.Util.RequestParameterAttribute("key", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string Key { get; set; }

        /// <summary>OAuth 2.0 token for the current user.</summary>
        [Google.Apis.Util.RequestParameterAttribute("oauth_token", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string OauthToken { get; set; }

        /// <summary>Returns response with indentations and line breaks.</summary>
        [Google.Apis.Util.RequestParameterAttribute("prettyPrint", Google.Apis.Util.RequestParameterType.Query)]
        public virtual System.Nullable<bool> PrettyPrint { get; set; }

        /// <summary>
        /// An opaque string that represents a user for quota purposes. Must not exceed 40 characters.
        /// </summary>
        [Google.Apis.Util.RequestParameterAttribute("quotaUser", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string QuotaUser { get; set; }

        /// <summary>Deprecated. Please use quotaUser instead.</summary>
        [Google.Apis.Util.RequestParameterAttribute("userIp", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string UserIp { get; set; }

        /// <summary>Initializes AdExchangeBuyer parameter list.</summary>
        protected override void InitParameters()
        {
            base.InitParameters();
            RequestParameters.Add("alt", new Google.Apis.Discovery.Parameter
            {
                Name = "alt",
                IsRequired = false,
                ParameterType = "query",
                DefaultValue = "json",
                Pattern = null,
            });
            RequestParameters.Add("fields", new Google.Apis.Discovery.Parameter
            {
                Name = "fields",
                IsRequired = false,
                ParameterType = "query",
                DefaultValue = null,
                Pattern = null,
            });
            RequestParameters.Add("key", new Google.Apis.Discovery.Parameter
            {
                Name = "key",
                IsRequired = false,
                ParameterType = "query",
                DefaultValue = null,
                Pattern = null,
            });
            RequestParameters.Add("oauth_token", new Google.Apis.Discovery.Parameter
            {
                Name = "oauth_token",
                IsRequired = false,
                ParameterType = "query",
                DefaultValue = null,
                Pattern = null,
            });
            RequestParameters.Add("prettyPrint", new Google.Apis.Discovery.Parameter
            {
                Name = "prettyPrint",
                IsRequired = false,
                ParameterType = "query",
                DefaultValue = "true",
                Pattern = null,
            });
            RequestParameters.Add("quotaUser", new Google.Apis.Discovery.Parameter
            {
                Name = "quotaUser",
                IsRequired = false,
                ParameterType = "query",
                DefaultValue = null,
                Pattern = null,
            });
            RequestParameters.Add("userIp", new Google.Apis.Discovery.Parameter
            {
                Name = "userIp",
                IsRequired = false,
                ParameterType = "query",
                DefaultValue = null,
                Pattern = null,
            });
        }
    }

    /// <summary>The "accounts" collection of methods.</summary>
    public class AccountsResource
    {
        private const string Resource = "accounts";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public AccountsResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>Gets one account by ID.</summary>
        /// <param name="id">The account id</param>
        public virtual GetRequest Get(int id)
        {
            return new GetRequest(service, id);
        }

        /// <summary>Gets one account by ID.</summary>
        public class GetRequest : AdExchangeBuyerBaseServiceRequest<Google.Apis.AdExchangeBuyer.v1_4.Data.Account>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, int id) : base(service)
            {
                Id = id;
                InitParameters();
            }

            /// <summary>The account id</summary>
            [Google.Apis.Util.RequestParameterAttribute("id", Google.Apis.Util.RequestParameterType.Path)]
            public virtual int Id { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "get";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "accounts/{id}";

            /// <summary>Initializes Get parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("id", new Google.Apis.Discovery.Parameter
                {
                    Name = "id",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Retrieves the authenticated user's list of accounts.</summary>
        public virtual ListRequest List()
        {
            return new ListRequest(service);
        }

        /// <summary>Retrieves the authenticated user's list of accounts.</summary>
        public class ListRequest : AdExchangeBuyerBaseServiceRequest<Google.Apis.AdExchangeBuyer.v1_4.Data.AccountsList>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service) : base(service)
            {
                InitParameters();
            }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "list";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "accounts";

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
            }
        }

        /// <summary>Updates an existing account. This method supports patch semantics.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="id">The account id</param>
        public virtual PatchRequest Patch(Google.Apis.AdExchangeBuyer.v1_4.Data.Account body, int id)
        {
            return new PatchRequest(service, body, id);
        }

        /// <summary>Updates an existing account. This method supports patch semantics.</summary>
        public class PatchRequest : AdExchangeBuyerBaseServiceRequest<Google.Apis.AdExchangeBuyer.v1_4.Data.Account>
        {
            /// <summary>Constructs a new Patch request.</summary>
            public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.AdExchangeBuyer.v1_4.Data.Account body, int id) : base(service)
            {
                Id = id;
                Body = body;
                InitParameters();
            }

            /// <summary>The account id</summary>
            [Google.Apis.Util.RequestParameterAttribute("id", Google.Apis.Util.RequestParameterType.Path)]
            public virtual int Id { get; private set; }

            /// <summary>Confirmation for erasing bidder and cookie matching urls.</summary>
            [Google.Apis.Util.RequestParameterAttribute("confirmUnsafeAccountChange", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> ConfirmUnsafeAccountChange { get; set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.AdExchangeBuyer.v1_4.Data.Account Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "patch";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PATCH";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "accounts/{id}";

            /// <summary>Initializes Patch parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("id", new Google.Apis.Discovery.Parameter
                {
                    Name = "id",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("confirmUnsafeAccountChange", new Google.Apis.Discovery.Parameter
                {
                    Name = "confirmUnsafeAccountChange",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Updates an existing account.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="id">The account id</param>
        public virtual UpdateRequest Update(Google.Apis.AdExchangeBuyer.v1_4.Data.Account body, int id)
        {
            return new UpdateRequest(service, body, id);
        }

        /// <summary>Updates an existing account.</summary>
        public class UpdateRequest : AdExchangeBuyerBaseServiceRequest<Google.Apis.AdExchangeBuyer.v1_4.Data.Account>
        {
            /// <summary>Constructs a new Update request.</summary>
            public UpdateRequest(Google.Apis.Services.IClientService service, Google.Apis.AdExchangeBuyer.v1_4.Data.Account body, int id) : base(service)
            {
                Id = id;
                Body = body;
                InitParameters();
            }

            /// <summary>The account id</summary>
            [Google.Apis.Util.RequestParameterAttribute("id", Google.Apis.Util.RequestParameterType.Path)]
            public virtual int Id { get; private set; }

            /// <summary>Confirmation for erasing bidder and cookie matching urls.</summary>
            [Google.Apis.Util.RequestParameterAttribute("confirmUnsafeAccountChange", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> ConfirmUnsafeAccountChange { get; set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.AdExchangeBuyer.v1_4.Data.Account Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "update";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PUT";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "accounts/{id}";

            /// <summary>Initializes Update parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("id", new Google.Apis.Discovery.Parameter
                {
                    Name = "id",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("confirmUnsafeAccountChange", new Google.Apis.Discovery.Parameter
                {
                    Name = "confirmUnsafeAccountChange",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }
    }

    /// <summary>The "billingInfo" collection of methods.</summary>
    public class BillingInfoResource
    {
        private const string Resource = "billingInfo";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public BillingInfoResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>Returns the billing information for one account specified by account ID.</summary>
        /// <param name="accountId">The account id.</param>
        public virtual GetRequest Get(int accountId)
        {
            return new GetRequest(service, accountId);
        }

        /// <summary>Returns the billing information for one account specified by account ID.</summary>
        public class GetRequest : AdExchangeBuyerBaseServiceRequest<Google.Apis.AdExchangeBuyer.v1_4.Data.BillingInfo>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, int accountId) : base(service)
            {
                AccountId = accountId;
                InitParameters();
            }

            /// <summary>The account id.</summary>
            [Google.Apis.Util.RequestParameterAttribute("accountId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual int AccountId { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "get";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "billinginfo/{accountId}";

            /// <summary>Initializes Get parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("accountId", new Google.Apis.Discovery.Parameter
                {
                    Name = "accountId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Retrieves a list of billing information for all accounts of the authenticated user.</summary>
        public virtual ListRequest List()
        {
            return new ListRequest(service);
        }

        /// <summary>Retrieves a list of billing information for all accounts of the authenticated user.</summary>
        public class ListRequest : AdExchangeBuyerBaseServiceRequest<Google.Apis.AdExchangeBuyer.v1_4.Data.BillingInfoList>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service) : base(service)
            {
                InitParameters();
            }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "list";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "billinginfo";

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
            }
        }
    }

    /// <summary>The "budget" collection of methods.</summary>
    public class BudgetResource
    {
        private const string Resource = "budget";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public BudgetResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>Returns the budget information for the adgroup specified by the accountId and billingId.</summary>
        /// <param name="accountId">The account id to get the budget information for.</param>
        /// <param name="billingId">The billing id to get the budget information for.</param>
        public virtual GetRequest Get(long accountId, long billingId)
        {
            return new GetRequest(service, accountId, billingId);
        }

        /// <summary>Returns the budget information for the adgroup specified by the accountId and billingId.</summary>
        public class GetRequest : AdExchangeBuyerBaseServiceRequest<Google.Apis.AdExchangeBuyer.v1_4.Data.Budget>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, long accountId, long billingId) : base(service)
            {
                AccountId = accountId;
                BillingId = billingId;
                InitParameters();
            }

            /// <summary>The account id to get the budget information for.</summary>
            [Google.Apis.Util.RequestParameterAttribute("accountId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual long AccountId { get; private set; }

            /// <summary>The billing id to get the budget information for.</summary>
            [Google.Apis.Util.RequestParameterAttribute("billingId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual long BillingId { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "get";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "billinginfo/{accountId}/{billingId}";

            /// <summary>Initializes Get parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("accountId", new Google.Apis.Discovery.Parameter
                {
                    Name = "accountId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("billingId", new Google.Apis.Discovery.Parameter
                {
                    Name = "billingId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>
        /// Updates the budget amount for the budget of the adgroup specified by the accountId and billingId, with the
        /// budget amount in the request. This method supports patch semantics.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="accountId">The account id associated with the budget being updated.</param>
        /// <param name="billingId">The billing id associated with the budget being updated.</param>
        public virtual PatchRequest Patch(Google.Apis.AdExchangeBuyer.v1_4.Data.Budget body, long accountId, long billingId)
        {
            return new PatchRequest(service, body, accountId, billingId);
        }

        /// <summary>
        /// Updates the budget amount for the budget of the adgroup specified by the accountId and billingId, with the
        /// budget amount in the request. This method supports patch semantics.
        /// </summary>
        public class PatchRequest : AdExchangeBuyerBaseServiceRequest<Google.Apis.AdExchangeBuyer.v1_4.Data.Budget>
        {
            /// <summary>Constructs a new Patch request.</summary>
            public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.AdExchangeBuyer.v1_4.Data.Budget body, long accountId, long billingId) : base(service)
            {
                AccountId = accountId;
                BillingId = billingId;
                Body = body;
                InitParameters();
            }

            /// <summary>The account id associated with the budget being updated.</summary>
            [Google.Apis.Util.RequestParameterAttribute("accountId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual long AccountId { get; private set; }

            /// <summary>The billing id associated with the budget being updated.</summary>
            [Google.Apis.Util.RequestParameterAttribute("billingId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual long BillingId { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.AdExchangeBuyer.v1_4.Data.Budget Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "patch";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PATCH";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "billinginfo/{accountId}/{billingId}";

            /// <summary>Initializes Patch parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("accountId", new Google.Apis.Discovery.Parameter
                {
                    Name = "accountId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("billingId", new Google.Apis.Discovery.Parameter
                {
                    Name = "billingId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>
        /// Updates the budget amount for the budget of the adgroup specified by the accountId and billingId, with the
        /// budget amount in the request.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="accountId">The account id associated with the budget being updated.</param>
        /// <param name="billingId">The billing id associated with the budget being updated.</param>
        public virtual UpdateRequest Update(Google.Apis.AdExchangeBuyer.v1_4.Data.Budget body, long accountId, long billingId)
        {
            return new UpdateRequest(service, body, accountId, billingId);
        }

        /// <summary>
        /// Updates the budget amount for the budget of the adgroup specified by the accountId and billingId, with the
        /// budget amount in the request.
        /// </summary>
        public class UpdateRequest : AdExchangeBuyerBaseServiceRequest<Google.Apis.AdExchangeBuyer.v1_4.Data.Budget>
        {
            /// <summary>Constructs a new Update request.</summary>
            public UpdateRequest(Google.Apis.Services.IClientService service, Google.Apis.AdExchangeBuyer.v1_4.Data.Budget body, long accountId, long billingId) : base(service)
            {
                AccountId = accountId;
                BillingId = billingId;
                Body = body;
                InitParameters();
            }

            /// <summary>The account id associated with the budget being updated.</summary>
            [Google.Apis.Util.RequestParameterAttribute("accountId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual long AccountId { get; private set; }

            /// <summary>The billing id associated with the budget being updated.</summary>
            [Google.Apis.Util.RequestParameterAttribute("billingId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual long BillingId { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.AdExchangeBuyer.v1_4.Data.Budget Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "update";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PUT";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "billinginfo/{accountId}/{billingId}";

            /// <summary>Initializes Update parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("accountId", new Google.Apis.Discovery.Parameter
                {
                    Name = "accountId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("billingId", new Google.Apis.Discovery.Parameter
                {
                    Name = "billingId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }
    }

    /// <summary>The "creatives" collection of methods.</summary>
    public class CreativesResource
    {
        private const string Resource = "creatives";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public CreativesResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>Add a deal id association for the creative.</summary>
        /// <param name="accountId">The id for the account that will serve this creative.</param>
        /// <param name="buyerCreativeId">The buyer-specific id for this creative.</param>
        /// <param name="dealId">The id of the deal id to associate with this creative.</param>
        public virtual AddDealRequest AddDeal(int accountId, string buyerCreativeId, long dealId)
        {
            return new AddDealRequest(service, accountId, buyerCreativeId, dealId);
        }

        /// <summary>Add a deal id association for the creative.</summary>
        public class AddDealRequest : AdExchangeBuyerBaseServiceRequest<string>
        {
            /// <summary>Constructs a new AddDeal request.</summary>
            public AddDealRequest(Google.Apis.Services.IClientService service, int accountId, string buyerCreativeId, long dealId) : base(service)
            {
                AccountId = accountId;
                BuyerCreativeId = buyerCreativeId;
                DealId = dealId;
                InitParameters();
            }

            /// <summary>The id for the account that will serve this creative.</summary>
            [Google.Apis.Util.RequestParameterAttribute("accountId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual int AccountId { get; private set; }

            /// <summary>The buyer-specific id for this creative.</summary>
            [Google.Apis.Util.RequestParameterAttribute("buyerCreativeId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string BuyerCreativeId { get; private set; }

            /// <summary>The id of the deal id to associate with this creative.</summary>
            [Google.Apis.Util.RequestParameterAttribute("dealId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual long DealId { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "addDeal";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "creatives/{accountId}/{buyerCreativeId}/addDeal/{dealId}";

            /// <summary>Initializes AddDeal parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("accountId", new Google.Apis.Discovery.Parameter
                {
                    Name = "accountId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("buyerCreativeId", new Google.Apis.Discovery.Parameter
                {
                    Name = "buyerCreativeId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("dealId", new Google.Apis.Discovery.Parameter
                {
                    Name = "dealId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>
        /// Gets the status for a single creative. A creative will be available 30-40 minutes after submission.
        /// </summary>
        /// <param name="accountId">The id for the account that will serve this creative.</param>
        /// <param name="buyerCreativeId">The buyer-specific id for this creative.</param>
        public virtual GetRequest Get(int accountId, string buyerCreativeId)
        {
            return new GetRequest(service, accountId, buyerCreativeId);
        }

        /// <summary>
        /// Gets the status for a single creative. A creative will be available 30-40 minutes after submission.
        /// </summary>
        public class GetRequest : AdExchangeBuyerBaseServiceRequest<Google.Apis.AdExchangeBuyer.v1_4.Data.Creative>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, int accountId, string buyerCreativeId) : base(service)
            {
                AccountId = accountId;
                BuyerCreativeId = buyerCreativeId;
                InitParameters();
            }

            /// <summary>The id for the account that will serve this creative.</summary>
            [Google.Apis.Util.RequestParameterAttribute("accountId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual int AccountId { get; private set; }

            /// <summary>The buyer-specific id for this creative.</summary>
            [Google.Apis.Util.RequestParameterAttribute("buyerCreativeId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string BuyerCreativeId { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "get";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "creatives/{accountId}/{buyerCreativeId}";

            /// <summary>Initializes Get parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("accountId", new Google.Apis.Discovery.Parameter
                {
                    Name = "accountId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("buyerCreativeId", new Google.Apis.Discovery.Parameter
                {
                    Name = "buyerCreativeId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Submit a new creative.</summary>
        /// <param name="body">The body of the request.</param>
        public virtual InsertRequest Insert(Google.Apis.AdExchangeBuyer.v1_4.Data.Creative body)
        {
            return new InsertRequest(service, body);
        }

        /// <summary>Submit a new creative.</summary>
        public class InsertRequest : AdExchangeBuyerBaseServiceRequest<Google.Apis.AdExchangeBuyer.v1_4.Data.Creative>
        {
            /// <summary>Constructs a new Insert request.</summary>
            public InsertRequest(Google.Apis.Services.IClientService service, Google.Apis.AdExchangeBuyer.v1_4.Data.Creative body) : base(service)
            {
                Body = body;
                InitParameters();
            }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.AdExchangeBuyer.v1_4.Data.Creative Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "insert";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "creatives";

            /// <summary>Initializes Insert parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
            }
        }

        /// <summary>
        /// Retrieves a list of the authenticated user's active creatives. A creative will be available 30-40 minutes
        /// after submission.
        /// </summary>
        public virtual ListRequest List()
        {
            return new ListRequest(service);
        }

        /// <summary>
        /// Retrieves a list of the authenticated user's active creatives. A creative will be available 30-40 minutes
        /// after submission.
        /// </summary>
        public class ListRequest : AdExchangeBuyerBaseServiceRequest<Google.Apis.AdExchangeBuyer.v1_4.Data.CreativesList>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service) : base(service)
            {
                InitParameters();
            }

            /// <summary>When specified, only creatives for the given account ids are returned.</summary>
            [Google.Apis.Util.RequestParameterAttribute("accountId", Google.Apis.Util.RequestParameterType.Query)]
            public virtual Google.Apis.Util.Repeatable<string> AccountId { get; set; }

            /// <summary>When specified, only creatives for the given buyer creative ids are returned.</summary>
            [Google.Apis.Util.RequestParameterAttribute("buyerCreativeId", Google.Apis.Util.RequestParameterType.Query)]
            public virtual Google.Apis.Util.Repeatable<string> BuyerCreativeId { get; set; }

            /// <summary>When specified, only creatives having the given deals status are returned.</summary>
            [Google.Apis.Util.RequestParameterAttribute("dealsStatusFilter", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<DealsStatusFilterEnum> DealsStatusFilter { get; set; }

            /// <summary>When specified, only creatives having the given deals status are returned.</summary>
            public enum DealsStatusFilterEnum
            {
                /// <summary>Creatives which have been approved for serving on deals.</summary>
                [Google.Apis.Util.StringValueAttribute("approved")]
                Approved = 0,

                /// <summary>Creatives which have been conditionally approved for serving on deals.</summary>
                [Google.Apis.Util.StringValueAttribute("conditionally_approved")]
                ConditionallyApproved = 1,

                /// <summary>Creatives which have been disapproved for serving on deals.</summary>
                [Google.Apis.Util.StringValueAttribute("disapproved")]
                Disapproved = 2,

                /// <summary>Creatives whose deals status is not yet checked.</summary>
                [Google.Apis.Util.StringValueAttribute("not_checked")]
                NotChecked = 3,
            }

            /// <summary>
            /// Maximum number of entries returned on one result page. If not set, the default is 100. Optional.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("maxResults", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<long> MaxResults { get; set; }

            /// <summary>When specified, only creatives having the given open auction status are returned.</summary>
            [Google.Apis.Util.RequestParameterAttribute("openAuctionStatusFilter", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<OpenAuctionStatusFilterEnum> OpenAuctionStatusFilter { get; set; }

            /// <summary>When specified, only creatives having the given open auction status are returned.</summary>
            public enum OpenAuctionStatusFilterEnum
            {
                /// <summary>Creatives which have been approved for serving on the open auction.</summary>
                [Google.Apis.Util.StringValueAttribute("approved")]
                Approved = 0,

                /// <summary>Creatives which have been conditionally approved for serving on the open auction.</summary>
                [Google.Apis.Util.StringValueAttribute("conditionally_approved")]
                ConditionallyApproved = 1,

                /// <summary>Creatives which have been disapproved for serving on the open auction.</summary>
                [Google.Apis.Util.StringValueAttribute("disapproved")]
                Disapproved = 2,

                /// <summary>Creatives whose open auction status is not yet checked.</summary>
                [Google.Apis.Util.StringValueAttribute("not_checked")]
                NotChecked = 3,
            }

            /// <summary>
            /// A continuation token, used to page through ad clients. To retrieve the next page, set this parameter to
            /// the value of "nextPageToken" from the previous response. Optional.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PageToken { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "list";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "creatives";

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("accountId", new Google.Apis.Discovery.Parameter
                {
                    Name = "accountId",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("buyerCreativeId", new Google.Apis.Discovery.Parameter
                {
                    Name = "buyerCreativeId",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("dealsStatusFilter", new Google.Apis.Discovery.Parameter
                {
                    Name = "dealsStatusFilter",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("maxResults", new Google.Apis.Discovery.Parameter
                {
                    Name = "maxResults",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("openAuctionStatusFilter", new Google.Apis.Discovery.Parameter
                {
                    Name = "openAuctionStatusFilter",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("pageToken", new Google.Apis.Discovery.Parameter
                {
                    Name = "pageToken",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Lists the external deal ids associated with the creative.</summary>
        /// <param name="accountId">The id for the account that will serve this creative.</param>
        /// <param name="buyerCreativeId">The buyer-specific id for this creative.</param>
        public virtual ListDealsRequest ListDeals(int accountId, string buyerCreativeId)
        {
            return new ListDealsRequest(service, accountId, buyerCreativeId);
        }

        /// <summary>Lists the external deal ids associated with the creative.</summary>
        public class ListDealsRequest : AdExchangeBuyerBaseServiceRequest<Google.Apis.AdExchangeBuyer.v1_4.Data.CreativeDealIds>
        {
            /// <summary>Constructs a new ListDeals request.</summary>
            public ListDealsRequest(Google.Apis.Services.IClientService service, int accountId, string buyerCreativeId) : base(service)
            {
                AccountId = accountId;
                BuyerCreativeId = buyerCreativeId;
                InitParameters();
            }

            /// <summary>The id for the account that will serve this creative.</summary>
            [Google.Apis.Util.RequestParameterAttribute("accountId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual int AccountId { get; private set; }

            /// <summary>The buyer-specific id for this creative.</summary>
            [Google.Apis.Util.RequestParameterAttribute("buyerCreativeId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string BuyerCreativeId { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "listDeals";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "creatives/{accountId}/{buyerCreativeId}/listDeals";

            /// <summary>Initializes ListDeals parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("accountId", new Google.Apis.Discovery.Parameter
                {
                    Name = "accountId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("buyerCreativeId", new Google.Apis.Discovery.Parameter
                {
                    Name = "buyerCreativeId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Remove a deal id associated with the creative.</summary>
        /// <param name="accountId">The id for the account that will serve this creative.</param>
        /// <param name="buyerCreativeId">The buyer-specific id for this creative.</param>
        /// <param name="dealId">The id of the deal id to disassociate with this creative.</param>
        public virtual RemoveDealRequest RemoveDeal(int accountId, string buyerCreativeId, long dealId)
        {
            return new RemoveDealRequest(service, accountId, buyerCreativeId, dealId);
        }

        /// <summary>Remove a deal id associated with the creative.</summary>
        public class RemoveDealRequest : AdExchangeBuyerBaseServiceRequest<string>
        {
            /// <summary>Constructs a new RemoveDeal request.</summary>
            public RemoveDealRequest(Google.Apis.Services.IClientService service, int accountId, string buyerCreativeId, long dealId) : base(service)
            {
                AccountId = accountId;
                BuyerCreativeId = buyerCreativeId;
                DealId = dealId;
                InitParameters();
            }

            /// <summary>The id for the account that will serve this creative.</summary>
            [Google.Apis.Util.RequestParameterAttribute("accountId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual int AccountId { get; private set; }

            /// <summary>The buyer-specific id for this creative.</summary>
            [Google.Apis.Util.RequestParameterAttribute("buyerCreativeId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string BuyerCreativeId { get; private set; }

            /// <summary>The id of the deal id to disassociate with this creative.</summary>
            [Google.Apis.Util.RequestParameterAttribute("dealId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual long DealId { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "removeDeal";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "creatives/{accountId}/{buyerCreativeId}/removeDeal/{dealId}";

            /// <summary>Initializes RemoveDeal parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("accountId", new Google.Apis.Discovery.Parameter
                {
                    Name = "accountId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("buyerCreativeId", new Google.Apis.Discovery.Parameter
                {
                    Name = "buyerCreativeId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("dealId", new Google.Apis.Discovery.Parameter
                {
                    Name = "dealId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }
    }

    /// <summary>The "marketplacedeals" collection of methods.</summary>
    public class MarketplacedealsResource
    {
        private const string Resource = "marketplacedeals";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public MarketplacedealsResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>Delete the specified deals from the proposal</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="proposalId">The proposalId to delete deals from.</param>
        public virtual DeleteRequest Delete(Google.Apis.AdExchangeBuyer.v1_4.Data.DeleteOrderDealsRequest body, string proposalId)
        {
            return new DeleteRequest(service, body, proposalId);
        }

        /// <summary>Delete the specified deals from the proposal</summary>
        public class DeleteRequest : AdExchangeBuyerBaseServiceRequest<Google.Apis.AdExchangeBuyer.v1_4.Data.DeleteOrderDealsResponse>
        {
            /// <summary>Constructs a new Delete request.</summary>
            public DeleteRequest(Google.Apis.Services.IClientService service, Google.Apis.AdExchangeBuyer.v1_4.Data.DeleteOrderDealsRequest body, string proposalId) : base(service)
            {
                ProposalId = proposalId;
                Body = body;
                InitParameters();
            }

            /// <summary>The proposalId to delete deals from.</summary>
            [Google.Apis.Util.RequestParameterAttribute("proposalId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ProposalId { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.AdExchangeBuyer.v1_4.Data.DeleteOrderDealsRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "delete";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "proposals/{proposalId}/deals/delete";

            /// <summary>Initializes Delete parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("proposalId", new Google.Apis.Discovery.Parameter
                {
                    Name = "proposalId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Add new deals for the specified proposal</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="proposalId">proposalId for which deals need to be added.</param>
        public virtual InsertRequest Insert(Google.Apis.AdExchangeBuyer.v1_4.Data.AddOrderDealsRequest body, string proposalId)
        {
            return new InsertRequest(service, body, proposalId);
        }

        /// <summary>Add new deals for the specified proposal</summary>
        public class InsertRequest : AdExchangeBuyerBaseServiceRequest<Google.Apis.AdExchangeBuyer.v1_4.Data.AddOrderDealsResponse>
        {
            /// <summary>Constructs a new Insert request.</summary>
            public InsertRequest(Google.Apis.Services.IClientService service, Google.Apis.AdExchangeBuyer.v1_4.Data.AddOrderDealsRequest body, string proposalId) : base(service)
            {
                ProposalId = proposalId;
                Body = body;
                InitParameters();
            }

            /// <summary>proposalId for which deals need to be added.</summary>
            [Google.Apis.Util.RequestParameterAttribute("proposalId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ProposalId { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.AdExchangeBuyer.v1_4.Data.AddOrderDealsRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "insert";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "proposals/{proposalId}/deals/insert";

            /// <summary>Initializes Insert parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("proposalId", new Google.Apis.Discovery.Parameter
                {
                    Name = "proposalId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>List all the deals for a given proposal</summary>
        /// <param name="proposalId">
        /// The proposalId to get deals for. To search across all proposals specify order_id = '-' as part of the URL.
        /// </param>
        public virtual ListRequest List(string proposalId)
        {
            return new ListRequest(service, proposalId);
        }

        /// <summary>List all the deals for a given proposal</summary>
        public class ListRequest : AdExchangeBuyerBaseServiceRequest<Google.Apis.AdExchangeBuyer.v1_4.Data.GetOrderDealsResponse>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service, string proposalId) : base(service)
            {
                ProposalId = proposalId;
                InitParameters();
            }

            /// <summary>
            /// The proposalId to get deals for. To search across all proposals specify order_id = '-' as part of the
            /// URL.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("proposalId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ProposalId { get; private set; }

            /// <summary>Query string to retrieve specific deals.</summary>
            [Google.Apis.Util.RequestParameterAttribute("pqlQuery", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PqlQuery { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "list";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "proposals/{proposalId}/deals";

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("proposalId", new Google.Apis.Discovery.Parameter
                {
                    Name = "proposalId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("pqlQuery", new Google.Apis.Discovery.Parameter
                {
                    Name = "pqlQuery",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Replaces all the deals in the proposal with the passed in deals</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="proposalId">The proposalId to edit deals on.</param>
        public virtual UpdateRequest Update(Google.Apis.AdExchangeBuyer.v1_4.Data.EditAllOrderDealsRequest body, string proposalId)
        {
            return new UpdateRequest(service, body, proposalId);
        }

        /// <summary>Replaces all the deals in the proposal with the passed in deals</summary>
        public class UpdateRequest : AdExchangeBuyerBaseServiceRequest<Google.Apis.AdExchangeBuyer.v1_4.Data.EditAllOrderDealsResponse>
        {
            /// <summary>Constructs a new Update request.</summary>
            public UpdateRequest(Google.Apis.Services.IClientService service, Google.Apis.AdExchangeBuyer.v1_4.Data.EditAllOrderDealsRequest body, string proposalId) : base(service)
            {
                ProposalId = proposalId;
                Body = body;
                InitParameters();
            }

            /// <summary>The proposalId to edit deals on.</summary>
            [Google.Apis.Util.RequestParameterAttribute("proposalId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ProposalId { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.AdExchangeBuyer.v1_4.Data.EditAllOrderDealsRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "update";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "proposals/{proposalId}/deals/update";

            /// <summary>Initializes Update parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("proposalId", new Google.Apis.Discovery.Parameter
                {
                    Name = "proposalId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }
    }

    /// <summary>The "marketplacenotes" collection of methods.</summary>
    public class MarketplacenotesResource
    {
        private const string Resource = "marketplacenotes";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public MarketplacenotesResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>Add notes to the proposal</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="proposalId">The proposalId to add notes for.</param>
        public virtual InsertRequest Insert(Google.Apis.AdExchangeBuyer.v1_4.Data.AddOrderNotesRequest body, string proposalId)
        {
            return new InsertRequest(service, body, proposalId);
        }

        /// <summary>Add notes to the proposal</summary>
        public class InsertRequest : AdExchangeBuyerBaseServiceRequest<Google.Apis.AdExchangeBuyer.v1_4.Data.AddOrderNotesResponse>
        {
            /// <summary>Constructs a new Insert request.</summary>
            public InsertRequest(Google.Apis.Services.IClientService service, Google.Apis.AdExchangeBuyer.v1_4.Data.AddOrderNotesRequest body, string proposalId) : base(service)
            {
                ProposalId = proposalId;
                Body = body;
                InitParameters();
            }

            /// <summary>The proposalId to add notes for.</summary>
            [Google.Apis.Util.RequestParameterAttribute("proposalId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ProposalId { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.AdExchangeBuyer.v1_4.Data.AddOrderNotesRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "insert";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "proposals/{proposalId}/notes/insert";

            /// <summary>Initializes Insert parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("proposalId", new Google.Apis.Discovery.Parameter
                {
                    Name = "proposalId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Get all the notes associated with a proposal</summary>
        /// <param name="proposalId">
        /// The proposalId to get notes for. To search across all proposals specify order_id = '-' as part of the URL.
        /// </param>
        public virtual ListRequest List(string proposalId)
        {
            return new ListRequest(service, proposalId);
        }

        /// <summary>Get all the notes associated with a proposal</summary>
        public class ListRequest : AdExchangeBuyerBaseServiceRequest<Google.Apis.AdExchangeBuyer.v1_4.Data.GetOrderNotesResponse>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service, string proposalId) : base(service)
            {
                ProposalId = proposalId;
                InitParameters();
            }

            /// <summary>
            /// The proposalId to get notes for. To search across all proposals specify order_id = '-' as part of the
            /// URL.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("proposalId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ProposalId { get; private set; }

            /// <summary>
            /// Query string to retrieve specific notes. To search the text contents of notes, please use syntax like
            /// "WHERE note.note = "foo" or "WHERE note.note LIKE "%bar%"
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("pqlQuery", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PqlQuery { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "list";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "proposals/{proposalId}/notes";

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("proposalId", new Google.Apis.Discovery.Parameter
                {
                    Name = "proposalId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("pqlQuery", new Google.Apis.Discovery.Parameter
                {
                    Name = "pqlQuery",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }
    }

    /// <summary>The "marketplaceprivateauction" collection of methods.</summary>
    public class MarketplaceprivateauctionResource
    {
        private const string Resource = "marketplaceprivateauction";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public MarketplaceprivateauctionResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>Update a given private auction proposal</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="privateAuctionId">The private auction id to be updated.</param>
        public virtual UpdateproposalRequest Updateproposal(Google.Apis.AdExchangeBuyer.v1_4.Data.UpdatePrivateAuctionProposalRequest body, string privateAuctionId)
        {
            return new UpdateproposalRequest(service, body, privateAuctionId);
        }

        /// <summary>Update a given private auction proposal</summary>
        public class UpdateproposalRequest : AdExchangeBuyerBaseServiceRequest<string>
        {
            /// <summary>Constructs a new Updateproposal request.</summary>
            public UpdateproposalRequest(Google.Apis.Services.IClientService service, Google.Apis.AdExchangeBuyer.v1_4.Data.UpdatePrivateAuctionProposalRequest body, string privateAuctionId) : base(service)
            {
                PrivateAuctionId = privateAuctionId;
                Body = body;
                InitParameters();
            }

            /// <summary>The private auction id to be updated.</summary>
            [Google.Apis.Util.RequestParameterAttribute("privateAuctionId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string PrivateAuctionId { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.AdExchangeBuyer.v1_4.Data.UpdatePrivateAuctionProposalRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "updateproposal";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "privateauction/{privateAuctionId}/updateproposal";

            /// <summary>Initializes Updateproposal parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("privateAuctionId", new Google.Apis.Discovery.Parameter
                {
                    Name = "privateAuctionId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }
    }

    /// <summary>The "performanceReport" collection of methods.</summary>
    public class PerformanceReportResource
    {
        private const string Resource = "performanceReport";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public PerformanceReportResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>Retrieves the authenticated user's list of performance metrics.</summary>
        /// <param name="accountId">The account id to get the reports.</param>
        /// <param name="endDateTime">The end time of the report in ISO 8601 timestamp format using UTC.</param>
        /// <param name="startDateTime">The start time of the report in ISO 8601 timestamp format using UTC.</param>
        public virtual ListRequest List(long accountId, string endDateTime, string startDateTime)
        {
            return new ListRequest(service, accountId, endDateTime, startDateTime);
        }

        /// <summary>Retrieves the authenticated user's list of performance metrics.</summary>
        public class ListRequest : AdExchangeBuyerBaseServiceRequest<Google.Apis.AdExchangeBuyer.v1_4.Data.PerformanceReportList>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service, long accountId, string endDateTime, string startDateTime) : base(service)
            {
                AccountId = accountId;
                EndDateTime = endDateTime;
                StartDateTime = startDateTime;
                InitParameters();
            }

            /// <summary>The account id to get the reports.</summary>
            [Google.Apis.Util.RequestParameterAttribute("accountId", Google.Apis.Util.RequestParameterType.Query)]
            public virtual long AccountId { get; private set; }

            /// <summary>The end time of the report in ISO 8601 timestamp format using UTC.</summary>
            [Google.Apis.Util.RequestParameterAttribute("endDateTime", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string EndDateTime { get; private set; }

            /// <summary>The start time of the report in ISO 8601 timestamp format using UTC.</summary>
            [Google.Apis.Util.RequestParameterAttribute("startDateTime", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string StartDateTime { get; private set; }

            /// <summary>
            /// Maximum number of entries returned on one result page. If not set, the default is 100. Optional.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("maxResults", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<long> MaxResults { get; set; }

            /// <summary>
            /// A continuation token, used to page through performance reports. To retrieve the next page, set this
            /// parameter to the value of "nextPageToken" from the previous response. Optional.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PageToken { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "list";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "performancereport";

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("accountId", new Google.Apis.Discovery.Parameter
                {
                    Name = "accountId",
                    IsRequired = true,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("endDateTime", new Google.Apis.Discovery.Parameter
                {
                    Name = "endDateTime",
                    IsRequired = true,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("startDateTime", new Google.Apis.Discovery.Parameter
                {
                    Name = "startDateTime",
                    IsRequired = true,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("maxResults", new Google.Apis.Discovery.Parameter
                {
                    Name = "maxResults",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("pageToken", new Google.Apis.Discovery.Parameter
                {
                    Name = "pageToken",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }
    }

    /// <summary>The "pretargetingConfig" collection of methods.</summary>
    public class PretargetingConfigResource
    {
        private const string Resource = "pretargetingConfig";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public PretargetingConfigResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>Deletes an existing pretargeting config.</summary>
        /// <param name="accountId">The account id to delete the pretargeting config for.</param>
        /// <param name="configId">The specific id of the configuration to delete.</param>
        public virtual DeleteRequest Delete(long accountId, long configId)
        {
            return new DeleteRequest(service, accountId, configId);
        }

        /// <summary>Deletes an existing pretargeting config.</summary>
        public class DeleteRequest : AdExchangeBuyerBaseServiceRequest<string>
        {
            /// <summary>Constructs a new Delete request.</summary>
            public DeleteRequest(Google.Apis.Services.IClientService service, long accountId, long configId) : base(service)
            {
                AccountId = accountId;
                ConfigId = configId;
                InitParameters();
            }

            /// <summary>The account id to delete the pretargeting config for.</summary>
            [Google.Apis.Util.RequestParameterAttribute("accountId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual long AccountId { get; private set; }

            /// <summary>The specific id of the configuration to delete.</summary>
            [Google.Apis.Util.RequestParameterAttribute("configId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual long ConfigId { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "delete";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "DELETE";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "pretargetingconfigs/{accountId}/{configId}";

            /// <summary>Initializes Delete parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("accountId", new Google.Apis.Discovery.Parameter
                {
                    Name = "accountId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("configId", new Google.Apis.Discovery.Parameter
                {
                    Name = "configId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Gets a specific pretargeting configuration</summary>
        /// <param name="accountId">The account id to get the pretargeting config for.</param>
        /// <param name="configId">The specific id of the configuration to retrieve.</param>
        public virtual GetRequest Get(long accountId, long configId)
        {
            return new GetRequest(service, accountId, configId);
        }

        /// <summary>Gets a specific pretargeting configuration</summary>
        public class GetRequest : AdExchangeBuyerBaseServiceRequest<Google.Apis.AdExchangeBuyer.v1_4.Data.PretargetingConfig>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, long accountId, long configId) : base(service)
            {
                AccountId = accountId;
                ConfigId = configId;
                InitParameters();
            }

            /// <summary>The account id to get the pretargeting config for.</summary>
            [Google.Apis.Util.RequestParameterAttribute("accountId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual long AccountId { get; private set; }

            /// <summary>The specific id of the configuration to retrieve.</summary>
            [Google.Apis.Util.RequestParameterAttribute("configId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual long ConfigId { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "get";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "pretargetingconfigs/{accountId}/{configId}";

            /// <summary>Initializes Get parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("accountId", new Google.Apis.Discovery.Parameter
                {
                    Name = "accountId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("configId", new Google.Apis.Discovery.Parameter
                {
                    Name = "configId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Inserts a new pretargeting configuration.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="accountId">The account id to insert the pretargeting config for.</param>
        public virtual InsertRequest Insert(Google.Apis.AdExchangeBuyer.v1_4.Data.PretargetingConfig body, long accountId)
        {
            return new InsertRequest(service, body, accountId);
        }

        /// <summary>Inserts a new pretargeting configuration.</summary>
        public class InsertRequest : AdExchangeBuyerBaseServiceRequest<Google.Apis.AdExchangeBuyer.v1_4.Data.PretargetingConfig>
        {
            /// <summary>Constructs a new Insert request.</summary>
            public InsertRequest(Google.Apis.Services.IClientService service, Google.Apis.AdExchangeBuyer.v1_4.Data.PretargetingConfig body, long accountId) : base(service)
            {
                AccountId = accountId;
                Body = body;
                InitParameters();
            }

            /// <summary>The account id to insert the pretargeting config for.</summary>
            [Google.Apis.Util.RequestParameterAttribute("accountId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual long AccountId { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.AdExchangeBuyer.v1_4.Data.PretargetingConfig Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "insert";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "pretargetingconfigs/{accountId}";

            /// <summary>Initializes Insert parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("accountId", new Google.Apis.Discovery.Parameter
                {
                    Name = "accountId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Retrieves a list of the authenticated user's pretargeting configurations.</summary>
        /// <param name="accountId">The account id to get the pretargeting configs for.</param>
        public virtual ListRequest List(long accountId)
        {
            return new ListRequest(service, accountId);
        }

        /// <summary>Retrieves a list of the authenticated user's pretargeting configurations.</summary>
        public class ListRequest : AdExchangeBuyerBaseServiceRequest<Google.Apis.AdExchangeBuyer.v1_4.Data.PretargetingConfigList>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service, long accountId) : base(service)
            {
                AccountId = accountId;
                InitParameters();
            }

            /// <summary>The account id to get the pretargeting configs for.</summary>
            [Google.Apis.Util.RequestParameterAttribute("accountId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual long AccountId { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "list";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "pretargetingconfigs/{accountId}";

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("accountId", new Google.Apis.Discovery.Parameter
                {
                    Name = "accountId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Updates an existing pretargeting config. This method supports patch semantics.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="accountId">The account id to update the pretargeting config for.</param>
        /// <param name="configId">The specific id of the configuration to update.</param>
        public virtual PatchRequest Patch(Google.Apis.AdExchangeBuyer.v1_4.Data.PretargetingConfig body, long accountId, long configId)
        {
            return new PatchRequest(service, body, accountId, configId);
        }

        /// <summary>Updates an existing pretargeting config. This method supports patch semantics.</summary>
        public class PatchRequest : AdExchangeBuyerBaseServiceRequest<Google.Apis.AdExchangeBuyer.v1_4.Data.PretargetingConfig>
        {
            /// <summary>Constructs a new Patch request.</summary>
            public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.AdExchangeBuyer.v1_4.Data.PretargetingConfig body, long accountId, long configId) : base(service)
            {
                AccountId = accountId;
                ConfigId = configId;
                Body = body;
                InitParameters();
            }

            /// <summary>The account id to update the pretargeting config for.</summary>
            [Google.Apis.Util.RequestParameterAttribute("accountId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual long AccountId { get; private set; }

            /// <summary>The specific id of the configuration to update.</summary>
            [Google.Apis.Util.RequestParameterAttribute("configId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual long ConfigId { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.AdExchangeBuyer.v1_4.Data.PretargetingConfig Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "patch";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PATCH";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "pretargetingconfigs/{accountId}/{configId}";

            /// <summary>Initializes Patch parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("accountId", new Google.Apis.Discovery.Parameter
                {
                    Name = "accountId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("configId", new Google.Apis.Discovery.Parameter
                {
                    Name = "configId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Updates an existing pretargeting config.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="accountId">The account id to update the pretargeting config for.</param>
        /// <param name="configId">The specific id of the configuration to update.</param>
        public virtual UpdateRequest Update(Google.Apis.AdExchangeBuyer.v1_4.Data.PretargetingConfig body, long accountId, long configId)
        {
            return new UpdateRequest(service, body, accountId, configId);
        }

        /// <summary>Updates an existing pretargeting config.</summary>
        public class UpdateRequest : AdExchangeBuyerBaseServiceRequest<Google.Apis.AdExchangeBuyer.v1_4.Data.PretargetingConfig>
        {
            /// <summary>Constructs a new Update request.</summary>
            public UpdateRequest(Google.Apis.Services.IClientService service, Google.Apis.AdExchangeBuyer.v1_4.Data.PretargetingConfig body, long accountId, long configId) : base(service)
            {
                AccountId = accountId;
                ConfigId = configId;
                Body = body;
                InitParameters();
            }

            /// <summary>The account id to update the pretargeting config for.</summary>
            [Google.Apis.Util.RequestParameterAttribute("accountId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual long AccountId { get; private set; }

            /// <summary>The specific id of the configuration to update.</summary>
            [Google.Apis.Util.RequestParameterAttribute("configId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual long ConfigId { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.AdExchangeBuyer.v1_4.Data.PretargetingConfig Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "update";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PUT";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "pretargetingconfigs/{accountId}/{configId}";

            /// <summary>Initializes Update parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("accountId", new Google.Apis.Discovery.Parameter
                {
                    Name = "accountId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("configId", new Google.Apis.Discovery.Parameter
                {
                    Name = "configId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }
    }

    /// <summary>The "products" collection of methods.</summary>
    public class ProductsResource
    {
        private const string Resource = "products";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public ProductsResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>Gets the requested product by id.</summary>
        /// <param name="productId">The id for the product to get the head revision for.</param>
        public virtual GetRequest Get(string productId)
        {
            return new GetRequest(service, productId);
        }

        /// <summary>Gets the requested product by id.</summary>
        public class GetRequest : AdExchangeBuyerBaseServiceRequest<Google.Apis.AdExchangeBuyer.v1_4.Data.Product>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, string productId) : base(service)
            {
                ProductId = productId;
                InitParameters();
            }

            /// <summary>The id for the product to get the head revision for.</summary>
            [Google.Apis.Util.RequestParameterAttribute("productId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ProductId { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "get";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "products/{productId}";

            /// <summary>Initializes Get parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("productId", new Google.Apis.Discovery.Parameter
                {
                    Name = "productId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Gets the requested product.</summary>
        public virtual SearchRequest Search()
        {
            return new SearchRequest(service);
        }

        /// <summary>Gets the requested product.</summary>
        public class SearchRequest : AdExchangeBuyerBaseServiceRequest<Google.Apis.AdExchangeBuyer.v1_4.Data.GetOffersResponse>
        {
            /// <summary>Constructs a new Search request.</summary>
            public SearchRequest(Google.Apis.Services.IClientService service) : base(service)
            {
                InitParameters();
            }

            /// <summary>The pql query used to query for products.</summary>
            [Google.Apis.Util.RequestParameterAttribute("pqlQuery", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PqlQuery { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "search";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "products/search";

            /// <summary>Initializes Search parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("pqlQuery", new Google.Apis.Discovery.Parameter
                {
                    Name = "pqlQuery",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }
    }

    /// <summary>The "proposals" collection of methods.</summary>
    public class ProposalsResource
    {
        private const string Resource = "proposals";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public ProposalsResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>Get a proposal given its id</summary>
        /// <param name="proposalId">Id of the proposal to retrieve.</param>
        public virtual GetRequest Get(string proposalId)
        {
            return new GetRequest(service, proposalId);
        }

        /// <summary>Get a proposal given its id</summary>
        public class GetRequest : AdExchangeBuyerBaseServiceRequest<Google.Apis.AdExchangeBuyer.v1_4.Data.Proposal>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, string proposalId) : base(service)
            {
                ProposalId = proposalId;
                InitParameters();
            }

            /// <summary>Id of the proposal to retrieve.</summary>
            [Google.Apis.Util.RequestParameterAttribute("proposalId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ProposalId { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "get";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "proposals/{proposalId}";

            /// <summary>Initializes Get parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("proposalId", new Google.Apis.Discovery.Parameter
                {
                    Name = "proposalId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Create the given list of proposals</summary>
        /// <param name="body">The body of the request.</param>
        public virtual InsertRequest Insert(Google.Apis.AdExchangeBuyer.v1_4.Data.CreateOrdersRequest body)
        {
            return new InsertRequest(service, body);
        }

        /// <summary>Create the given list of proposals</summary>
        public class InsertRequest : AdExchangeBuyerBaseServiceRequest<Google.Apis.AdExchangeBuyer.v1_4.Data.CreateOrdersResponse>
        {
            /// <summary>Constructs a new Insert request.</summary>
            public InsertRequest(Google.Apis.Services.IClientService service, Google.Apis.AdExchangeBuyer.v1_4.Data.CreateOrdersRequest body) : base(service)
            {
                Body = body;
                InitParameters();
            }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.AdExchangeBuyer.v1_4.Data.CreateOrdersRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "insert";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "proposals/insert";

            /// <summary>Initializes Insert parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
            }
        }

        /// <summary>Update the given proposal. This method supports patch semantics.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="proposalId">The proposal id to update.</param>
        /// <param name="revisionNumber">
        /// The last known revision number to update. If the head revision in the marketplace database has since
        /// changed, an error will be thrown. The caller should then fetch the latest proposal at head revision and
        /// retry the update at that revision.
        /// </param>
        /// <param name="updateAction">
        /// The proposed action to take on the proposal. This field is required and it must be set when updating a
        /// proposal.
        /// </param>
        public virtual PatchRequest Patch(Google.Apis.AdExchangeBuyer.v1_4.Data.Proposal body, string proposalId, long revisionNumber, PatchRequest.UpdateActionEnum updateAction)
        {
            return new PatchRequest(service, body, proposalId, revisionNumber, updateAction);
        }

        /// <summary>Update the given proposal. This method supports patch semantics.</summary>
        public class PatchRequest : AdExchangeBuyerBaseServiceRequest<Google.Apis.AdExchangeBuyer.v1_4.Data.Proposal>
        {
            /// <summary>Constructs a new Patch request.</summary>
            public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.AdExchangeBuyer.v1_4.Data.Proposal body, string proposalId, long revisionNumber, UpdateActionEnum updateAction) : base(service)
            {
                ProposalId = proposalId;
                RevisionNumber = revisionNumber;
                UpdateAction = updateAction;
                Body = body;
                InitParameters();
            }

            /// <summary>The proposal id to update.</summary>
            [Google.Apis.Util.RequestParameterAttribute("proposalId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ProposalId { get; private set; }

            /// <summary>
            /// The last known revision number to update. If the head revision in the marketplace database has since
            /// changed, an error will be thrown. The caller should then fetch the latest proposal at head revision and
            /// retry the update at that revision.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("revisionNumber", Google.Apis.Util.RequestParameterType.Path)]
            public virtual long RevisionNumber { get; private set; }

            /// <summary>
            /// The proposed action to take on the proposal. This field is required and it must be set when updating a
            /// proposal.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("updateAction", Google.Apis.Util.RequestParameterType.Path)]
            public virtual UpdateActionEnum UpdateAction { get; private set; }

            /// <summary>
            /// The proposed action to take on the proposal. This field is required and it must be set when updating a
            /// proposal.
            /// </summary>
            public enum UpdateActionEnum
            {
                /// <summary></summary>
                [Google.Apis.Util.StringValueAttribute("accept")]
                Accept = 0,

                /// <summary></summary>
                [Google.Apis.Util.StringValueAttribute("cancel")]
                Cancel = 1,

                /// <summary></summary>
                [Google.Apis.Util.StringValueAttribute("propose")]
                Propose = 2,

                /// <summary></summary>
                [Google.Apis.Util.StringValueAttribute("proposeAndAccept")]
                ProposeAndAccept = 3,

                /// <summary></summary>
                [Google.Apis.Util.StringValueAttribute("unknownAction")]
                UnknownAction = 4,

                /// <summary></summary>
                [Google.Apis.Util.StringValueAttribute("updateNonTerms")]
                UpdateNonTerms = 5,
            }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.AdExchangeBuyer.v1_4.Data.Proposal Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "patch";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PATCH";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "proposals/{proposalId}/{revisionNumber}/{updateAction}";

            /// <summary>Initializes Patch parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("proposalId", new Google.Apis.Discovery.Parameter
                {
                    Name = "proposalId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("revisionNumber", new Google.Apis.Discovery.Parameter
                {
                    Name = "revisionNumber",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("updateAction", new Google.Apis.Discovery.Parameter
                {
                    Name = "updateAction",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Search for proposals using pql query</summary>
        public virtual SearchRequest Search()
        {
            return new SearchRequest(service);
        }

        /// <summary>Search for proposals using pql query</summary>
        public class SearchRequest : AdExchangeBuyerBaseServiceRequest<Google.Apis.AdExchangeBuyer.v1_4.Data.GetOrdersResponse>
        {
            /// <summary>Constructs a new Search request.</summary>
            public SearchRequest(Google.Apis.Services.IClientService service) : base(service)
            {
                InitParameters();
            }

            /// <summary>Query string to retrieve specific proposals.</summary>
            [Google.Apis.Util.RequestParameterAttribute("pqlQuery", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PqlQuery { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "search";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "proposals/search";

            /// <summary>Initializes Search parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("pqlQuery", new Google.Apis.Discovery.Parameter
                {
                    Name = "pqlQuery",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Update the given proposal to indicate that setup has been completed.</summary>
        /// <param name="proposalId">The proposal id for which the setup is complete</param>
        public virtual SetupcompleteRequest Setupcomplete(string proposalId)
        {
            return new SetupcompleteRequest(service, proposalId);
        }

        /// <summary>Update the given proposal to indicate that setup has been completed.</summary>
        public class SetupcompleteRequest : AdExchangeBuyerBaseServiceRequest<string>
        {
            /// <summary>Constructs a new Setupcomplete request.</summary>
            public SetupcompleteRequest(Google.Apis.Services.IClientService service, string proposalId) : base(service)
            {
                ProposalId = proposalId;
                InitParameters();
            }

            /// <summary>The proposal id for which the setup is complete</summary>
            [Google.Apis.Util.RequestParameterAttribute("proposalId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ProposalId { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "setupcomplete";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "proposals/{proposalId}/setupcomplete";

            /// <summary>Initializes Setupcomplete parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("proposalId", new Google.Apis.Discovery.Parameter
                {
                    Name = "proposalId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Update the given proposal</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="proposalId">The proposal id to update.</param>
        /// <param name="revisionNumber">
        /// The last known revision number to update. If the head revision in the marketplace database has since
        /// changed, an error will be thrown. The caller should then fetch the latest proposal at head revision and
        /// retry the update at that revision.
        /// </param>
        /// <param name="updateAction">
        /// The proposed action to take on the proposal. This field is required and it must be set when updating a
        /// proposal.
        /// </param>
        public virtual UpdateRequest Update(Google.Apis.AdExchangeBuyer.v1_4.Data.Proposal body, string proposalId, long revisionNumber, UpdateRequest.UpdateActionEnum updateAction)
        {
            return new UpdateRequest(service, body, proposalId, revisionNumber, updateAction);
        }

        /// <summary>Update the given proposal</summary>
        public class UpdateRequest : AdExchangeBuyerBaseServiceRequest<Google.Apis.AdExchangeBuyer.v1_4.Data.Proposal>
        {
            /// <summary>Constructs a new Update request.</summary>
            public UpdateRequest(Google.Apis.Services.IClientService service, Google.Apis.AdExchangeBuyer.v1_4.Data.Proposal body, string proposalId, long revisionNumber, UpdateActionEnum updateAction) : base(service)
            {
                ProposalId = proposalId;
                RevisionNumber = revisionNumber;
                UpdateAction = updateAction;
                Body = body;
                InitParameters();
            }

            /// <summary>The proposal id to update.</summary>
            [Google.Apis.Util.RequestParameterAttribute("proposalId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ProposalId { get; private set; }

            /// <summary>
            /// The last known revision number to update. If the head revision in the marketplace database has since
            /// changed, an error will be thrown. The caller should then fetch the latest proposal at head revision and
            /// retry the update at that revision.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("revisionNumber", Google.Apis.Util.RequestParameterType.Path)]
            public virtual long RevisionNumber { get; private set; }

            /// <summary>
            /// The proposed action to take on the proposal. This field is required and it must be set when updating a
            /// proposal.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("updateAction", Google.Apis.Util.RequestParameterType.Path)]
            public virtual UpdateActionEnum UpdateAction { get; private set; }

            /// <summary>
            /// The proposed action to take on the proposal. This field is required and it must be set when updating a
            /// proposal.
            /// </summary>
            public enum UpdateActionEnum
            {
                /// <summary></summary>
                [Google.Apis.Util.StringValueAttribute("accept")]
                Accept = 0,

                /// <summary></summary>
                [Google.Apis.Util.StringValueAttribute("cancel")]
                Cancel = 1,

                /// <summary></summary>
                [Google.Apis.Util.StringValueAttribute("propose")]
                Propose = 2,

                /// <summary></summary>
                [Google.Apis.Util.StringValueAttribute("proposeAndAccept")]
                ProposeAndAccept = 3,

                /// <summary></summary>
                [Google.Apis.Util.StringValueAttribute("unknownAction")]
                UnknownAction = 4,

                /// <summary></summary>
                [Google.Apis.Util.StringValueAttribute("updateNonTerms")]
                UpdateNonTerms = 5,
            }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.AdExchangeBuyer.v1_4.Data.Proposal Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "update";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PUT";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "proposals/{proposalId}/{revisionNumber}/{updateAction}";

            /// <summary>Initializes Update parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("proposalId", new Google.Apis.Discovery.Parameter
                {
                    Name = "proposalId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("revisionNumber", new Google.Apis.Discovery.Parameter
                {
                    Name = "revisionNumber",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("updateAction", new Google.Apis.Discovery.Parameter
                {
                    Name = "updateAction",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }
    }

    /// <summary>The "pubprofiles" collection of methods.</summary>
    public class PubprofilesResource
    {
        private const string Resource = "pubprofiles";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public PubprofilesResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>Gets the requested publisher profile(s) by publisher accountId.</summary>
        /// <param name="accountId">The accountId of the publisher to get profiles for.</param>
        public virtual ListRequest List(int accountId)
        {
            return new ListRequest(service, accountId);
        }

        /// <summary>Gets the requested publisher profile(s) by publisher accountId.</summary>
        public class ListRequest : AdExchangeBuyerBaseServiceRequest<Google.Apis.AdExchangeBuyer.v1_4.Data.GetPublisherProfilesByAccountIdResponse>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service, int accountId) : base(service)
            {
                AccountId = accountId;
                InitParameters();
            }

            /// <summary>The accountId of the publisher to get profiles for.</summary>
            [Google.Apis.Util.RequestParameterAttribute("accountId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual int AccountId { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "list";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "publisher/{accountId}/profiles";

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("accountId", new Google.Apis.Discovery.Parameter
                {
                    Name = "accountId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }
    }
}
namespace Google.Apis.AdExchangeBuyer.v1_4.Data
{
    /// <summary>Configuration data for an Ad Exchange buyer account.</summary>
    public class Account : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// When this is false, bid requests that include a deal ID for a private auction or preferred deal are always
        /// sent to your bidder. When true, all active pretargeting configs will be applied to private auctions and
        /// preferred deals. Programmatic Guaranteed deals (when enabled) are always sent to your bidder.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("applyPretargetingToNonGuaranteedDeals")]
        public virtual System.Nullable<bool> ApplyPretargetingToNonGuaranteedDeals { get; set; }

        /// <summary>Your bidder locations that have distinct URLs.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bidderLocation")]
        public virtual System.Collections.Generic.IList<BidderLocationData> BidderLocation { get; set; }

        /// <summary>
        /// The nid parameter value used in cookie match requests. Please contact your technical account manager if you
        /// need to change this.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cookieMatchingNid")]
        public virtual string CookieMatchingNid { get; set; }

        /// <summary>The base URL used in cookie match requests.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cookieMatchingUrl")]
        public virtual string CookieMatchingUrl { get; set; }

        /// <summary>Account id.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual System.Nullable<int> Id { get; set; }

        /// <summary>Resource type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>
        /// The maximum number of active creatives that an account can have, where a creative is active if it was
        /// inserted or bid with in the last 30 days. Please contact your technical account manager if you need to
        /// change this.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maximumActiveCreatives")]
        public virtual System.Nullable<int> MaximumActiveCreatives { get; set; }

        /// <summary>
        /// The sum of all bidderLocation.maximumQps values cannot exceed this. Please contact your technical account
        /// manager if you need to change this.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maximumTotalQps")]
        public virtual System.Nullable<int> MaximumTotalQps { get; set; }

        /// <summary>The number of creatives that this account inserted or bid with in the last 30 days.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("numberActiveCreatives")]
        public virtual System.Nullable<int> NumberActiveCreatives { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }

        /// <summary>Your bidder locations that have distinct URLs.</summary>
        public class BidderLocationData
        {
            /// <summary>
            /// The protocol that the bidder endpoint is using. OpenRTB protocols with prefix PROTOCOL_OPENRTB_PROTOBUF
            /// use proto buffer, otherwise use JSON.  Allowed values:   - PROTOCOL_ADX  - PROTOCOL_OPENRTB_2_2  -
            /// PROTOCOL_OPENRTB_2_3  - PROTOCOL_OPENRTB_2_4  - PROTOCOL_OPENRTB_2_5  - PROTOCOL_OPENRTB_PROTOBUF_2_3  -
            /// PROTOCOL_OPENRTB_PROTOBUF_2_4  - PROTOCOL_OPENRTB_PROTOBUF_2_5
            /// </summary>
            [Newtonsoft.Json.JsonPropertyAttribute("bidProtocol")]
            public virtual string BidProtocol { get; set; }

            /// <summary>The maximum queries per second the Ad Exchange will send.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("maximumQps")]
            public virtual System.Nullable<int> MaximumQps { get; set; }

            /// <summary>
            /// The geographical region the Ad Exchange should send requests from. Only used by some quota systems, but
            /// always setting the value is recommended. Allowed values:   - ASIA  - EUROPE  - US_EAST  - US_WEST
            /// </summary>
            [Newtonsoft.Json.JsonPropertyAttribute("region")]
            public virtual string Region { get; set; }

            /// <summary>The URL to which the Ad Exchange will send bid requests.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("url")]
            public virtual string Url { get; set; }
        }
    }

    /// <summary>
    /// An account feed lists Ad Exchange buyer accounts that the user has access to. Each entry in the feed corresponds
    /// to a single buyer account.
    /// </summary>
    public class AccountsList : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A list of accounts.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("items")]
        public virtual System.Collections.Generic.IList<Account> Items { get; set; }

        /// <summary>Resource type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class AddOrderDealsRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The list of deals to add</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deals")]
        public virtual System.Collections.Generic.IList<MarketplaceDeal> Deals { get; set; }

        /// <summary>The last known proposal revision number.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("proposalRevisionNumber")]
        public virtual System.Nullable<long> ProposalRevisionNumber { get; set; }

        /// <summary>Indicates an optional action to take on the proposal</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateAction")]
        public virtual string UpdateAction { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class AddOrderDealsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>List of deals added (in the same proposal as passed in the request)</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deals")]
        public virtual System.Collections.Generic.IList<MarketplaceDeal> Deals { get; set; }

        /// <summary>The updated revision number for the proposal.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("proposalRevisionNumber")]
        public virtual System.Nullable<long> ProposalRevisionNumber { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class AddOrderNotesRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The list of notes to add.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("notes")]
        public virtual System.Collections.Generic.IList<MarketplaceNote> Notes { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class AddOrderNotesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("notes")]
        public virtual System.Collections.Generic.IList<MarketplaceNote> Notes { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The configuration data for an Ad Exchange billing info.</summary>
    public class BillingInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Account id.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accountId")]
        public virtual System.Nullable<int> AccountId { get; set; }

        /// <summary>Account name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accountName")]
        public virtual string AccountName { get; set; }

        /// <summary>
        /// A list of adgroup IDs associated with this particular account. These IDs may show up as part of a realtime
        /// bidding BidRequest, which indicates a bid request for this account.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("billingId")]
        public virtual System.Collections.Generic.IList<string> BillingId { get; set; }

        /// <summary>Resource type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A billing info feed lists Billing Info the Ad Exchange buyer account has access to. Each entry in the feed
    /// corresponds to a single billing info.
    /// </summary>
    public class BillingInfoList : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A list of billing info relevant for your account.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("items")]
        public virtual System.Collections.Generic.IList<BillingInfo> Items { get; set; }

        /// <summary>Resource type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The configuration data for Ad Exchange RTB - Budget API.</summary>
    public class Budget : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The id of the account. This is required for get and update requests.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accountId")]
        public virtual System.Nullable<long> AccountId { get; set; }

        /// <summary>
        /// The billing id to determine which adgroup to provide budget information for. This is required for get and
        /// update requests.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("billingId")]
        public virtual System.Nullable<long> BillingId { get; set; }

        /// <summary>
        /// The daily budget amount in unit amount of the account currency to apply for the billingId provided. This is
        /// required for update requests.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("budgetAmount")]
        public virtual System.Nullable<long> BudgetAmount { get; set; }

        /// <summary>The currency code for the buyer. This cannot be altered here.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("currencyCode")]
        public virtual string CurrencyCode { get; set; }

        /// <summary>The unique id that describes this item.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>The kind of the resource, i.e. "adexchangebuyer#budget".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class Buyer : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Adx account id of the buyer.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accountId")]
        public virtual string AccountId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class ContactInformation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Email address of the contact.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("email")]
        public virtual string Email { get; set; }

        /// <summary>The name of the contact.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class CreateOrdersRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The list of proposals to create.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("proposals")]
        public virtual System.Collections.Generic.IList<Proposal> Proposals { get; set; }

        /// <summary>Web property id of the seller creating these orders</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("webPropertyCode")]
        public virtual string WebPropertyCode { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class CreateOrdersResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The list of proposals successfully created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("proposals")]
        public virtual System.Collections.Generic.IList<Proposal> Proposals { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A creative and its classification data.</summary>
    public class Creative : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The HTML snippet that displays the ad when inserted in the web page. If set, videoURL, videoVastXML, and
        /// nativeAd should not be set.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("HTMLSnippet")]
        public virtual string HTMLSnippet { get; set; }

        /// <summary>Account id.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accountId")]
        public virtual System.Nullable<int> AccountId { get; set; }

        /// <summary>The link to the Ad Preferences page. This is only supported for native ads.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("adChoicesDestinationUrl")]
        public virtual string AdChoicesDestinationUrl { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("adTechnologyProviders")]
        public virtual AdTechnologyProvidersData AdTechnologyProviders { get; set; }

        /// <summary>Detected advertiser id, if any. Read-only. This field should not be set in requests.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("advertiserId")]
        public virtual System.Collections.Generic.IList<System.Nullable<long>> AdvertiserId { get; set; }

        /// <summary>
        /// The name of the company being advertised in the creative. A list of advertisers is provided in the
        /// advertisers.txt file.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("advertiserName")]
        public virtual string AdvertiserName { get; set; }

        /// <summary>The agency id for this creative.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("agencyId")]
        public virtual System.Nullable<long> AgencyId { get; set; }

        /// <summary>
        /// The last upload timestamp of this creative if it was uploaded via API. Read-only. The value of this field is
        /// generated, and will be ignored for uploads. (formatted RFC 3339 timestamp).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("apiUploadTimestamp")]
        public virtual string ApiUploadTimestampRaw { get; set; }

        /// <summary><seealso cref="System.DateTime"/> representation of <see cref="ApiUploadTimestampRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.Nullable<System.DateTime> ApiUploadTimestamp
        {
            get => Google.Apis.Util.Utilities.GetDateTimeFromString(ApiUploadTimestampRaw);
            set => ApiUploadTimestampRaw = Google.Apis.Util.Utilities.GetStringFromDateTime(value);
        }

        /// <summary>
        /// List of buyer selectable attributes for the ads that may be shown from this snippet. Each attribute is
        /// represented by an integer as defined in  buyer-declarable-creative-attributes.txt.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("attribute")]
        public virtual System.Collections.Generic.IList<System.Nullable<int>> Attribute { get; set; }

        /// <summary>A buyer-specific id identifying the creative in this ad.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("buyerCreativeId")]
        public virtual string BuyerCreativeId { get; set; }

        /// <summary>The set of destination urls for the snippet.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clickThroughUrl")]
        public virtual System.Collections.Generic.IList<string> ClickThroughUrl { get; set; }

        /// <summary>
        /// Shows any corrections that were applied to this creative. Read-only. This field should not be set in
        /// requests.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("corrections")]
        public virtual System.Collections.Generic.IList<CorrectionsData> Corrections { get; set; }

        /// <summary>
        /// Creative status identity type that the creative item applies to. Ad Exchange real-time bidding is migrating
        /// to the sizeless creative verification. Originally, Ad Exchange assigned creative verification status to a
        /// unique combination of a buyer creative ID and creative dimensions. Post-migration, a single verification
        /// status will be assigned at the buyer creative ID level. This field allows to distinguish whether a given
        /// creative status applies to a unique combination of a buyer creative ID and creative dimensions, or to a
        /// buyer creative ID as a whole.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("creativeStatusIdentityType")]
        public virtual string CreativeStatusIdentityType { get; set; }

        /// <summary>
        /// Top-level deals status. Read-only. This field should not be set in requests. If disapproved, an entry for
        /// auctionType=DIRECT_DEALS (or ALL) in servingRestrictions will also exist. Note that this may be nuanced with
        /// other contextual restrictions, in which case it may be preferable to read from servingRestrictions directly.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dealsStatus")]
        public virtual string DealsStatus { get; set; }

        /// <summary>Detected domains for this creative. Read-only. This field should not be set in requests.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("detectedDomains")]
        public virtual System.Collections.Generic.IList<string> DetectedDomains { get; set; }

        /// <summary>
        /// The filtering reasons for the creative. Read-only. This field should not be set in requests.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("filteringReasons")]
        public virtual FilteringReasonsData FilteringReasons { get; set; }

        /// <summary>Ad height.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("height")]
        public virtual System.Nullable<int> Height { get; set; }

        /// <summary>The set of urls to be called to record an impression.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("impressionTrackingUrl")]
        public virtual System.Collections.Generic.IList<string> ImpressionTrackingUrl { get; set; }

        /// <summary>Resource type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>
        /// Detected languages for this creative. Read-only. This field should not be set in requests.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("languages")]
        public virtual System.Collections.Generic.IList<string> Languages { get; set; }

        /// <summary>
        /// If nativeAd is set, HTMLSnippet, videoVastXML, and the videoURL outside of nativeAd should not be set. (The
        /// videoURL inside nativeAd can be set.)
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nativeAd")]
        public virtual NativeAdData NativeAd { get; set; }

        /// <summary>
        /// Top-level open auction status. Read-only. This field should not be set in requests. If disapproved, an entry
        /// for auctionType=OPEN_AUCTION (or ALL) in servingRestrictions will also exist. Note that this may be nuanced
        /// with other contextual restrictions, in which case it may be preferable to read from ServingRestrictions
        /// directly.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("openAuctionStatus")]
        public virtual string OpenAuctionStatus { get; set; }

        /// <summary>
        /// Detected product categories, if any. Each category is represented by an integer as defined in
        /// ad-product-categories.txt. Read-only. This field should not be set in requests.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("productCategories")]
        public virtual System.Collections.Generic.IList<System.Nullable<int>> ProductCategories { get; set; }

        /// <summary>
        /// All restricted categories for the ads that may be shown from this snippet. Each category is represented by
        /// an integer as defined in the  ad-restricted-categories.txt.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("restrictedCategories")]
        public virtual System.Collections.Generic.IList<System.Nullable<int>> RestrictedCategories { get; set; }

        /// <summary>
        /// Detected sensitive categories, if any. Each category is represented by an integer as defined in
        /// ad-sensitive-categories.txt. Read-only. This field should not be set in requests.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sensitiveCategories")]
        public virtual System.Collections.Generic.IList<System.Nullable<int>> SensitiveCategories { get; set; }

        /// <summary>
        /// The granular status of this ad in specific contexts. A context here relates to where something ultimately
        /// serves (for example, a physical location, a platform, an HTTPS vs HTTP request, or the type of auction).
        /// Read-only. This field should not be set in requests. See the examples in the Creatives guide for more
        /// details.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("servingRestrictions")]
        public virtual System.Collections.Generic.IList<ServingRestrictionsData> ServingRestrictions { get; set; }

        /// <summary>
        /// List of vendor types for the ads that may be shown from this snippet. Each vendor type is represented by an
        /// integer as defined in vendors.txt.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("vendorType")]
        public virtual System.Collections.Generic.IList<System.Nullable<int>> VendorType { get; set; }

        /// <summary>The version for this creative. Read-only. This field should not be set in requests.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("version")]
        public virtual System.Nullable<int> Version { get; set; }

        /// <summary>
        /// The URL to fetch a video ad. If set, HTMLSnippet, videoVastXML, and nativeAd should not be set. Note, this
        /// is different from resource.native_ad.video_url above.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("videoURL")]
        public virtual string VideoURL { get; set; }

        /// <summary>
        /// The contents of a VAST document for a video ad. This document should conform to the VAST 2.0 or 3.0
        /// standard. If set, HTMLSnippet, videoURL, and nativeAd and should not be set.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("videoVastXML")]
        public virtual string VideoVastXML { get; set; }

        /// <summary>Ad width.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("width")]
        public virtual System.Nullable<int> Width { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }

        public class AdTechnologyProvidersData
        {
            /// <summary>
            /// The detected ad technology provider IDs for this creative. See
            /// https://storage.googleapis.com/adx-rtb-dictionaries/providers.csv for mapping of provider ID to provided
            /// name, a privacy policy URL, and a list of domains which can be attributed to the provider. If this
            /// creative contains provider IDs that are outside of those listed in the
            /// `BidRequest.adslot.consented_providers_settings.consented_providers` field on the  Authorized Buyers
            /// Real-Time Bidding protocol or the `BidRequest.user.ext.consented_providers_settings.consented_providers`
            /// field on the OpenRTB protocol, a bid submitted for a European Economic Area (EEA) user with this
            /// creative is not compliant with the GDPR policies as mentioned in the "Third-party Ad Technology Vendors"
            /// section of Authorized Buyers Program Guidelines.
            /// </summary>
            [Newtonsoft.Json.JsonPropertyAttribute("detectedProviderIds")]
            public virtual System.Collections.Generic.IList<System.Nullable<long>> DetectedProviderIds { get; set; }

            /// <summary>
            /// Whether the creative contains an unidentified ad technology provider. If true, a bid submitted for a
            /// European Economic Area (EEA) user with this creative is not compliant with the GDPR policies as
            /// mentioned in the "Third-party Ad Technology Vendors" section of Authorized Buyers Program Guidelines.
            /// </summary>
            [Newtonsoft.Json.JsonPropertyAttribute("hasUnidentifiedProvider")]
            public virtual System.Nullable<bool> HasUnidentifiedProvider { get; set; }
        }

        /// <summary>
        /// Shows any corrections that were applied to this creative. Read-only. This field should not be set in
        /// requests.
        /// </summary>
        public class CorrectionsData
        {
            /// <summary>All known serving contexts containing serving status information.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("contexts")]
            public virtual System.Collections.Generic.IList<ContextsData> Contexts { get; set; }

            /// <summary>Additional details about the correction.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("details")]
            public virtual System.Collections.Generic.IList<string> Details { get; set; }

            /// <summary>The type of correction that was applied to the creative.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("reason")]
            public virtual string Reason { get; set; }

            /// <summary>All known serving contexts containing serving status information.</summary>
            public class ContextsData
            {
                /// <summary>
                /// Only set when contextType=AUCTION_TYPE. Represents the auction types this correction applies to.
                /// </summary>
                [Newtonsoft.Json.JsonPropertyAttribute("auctionType")]
                public virtual System.Collections.Generic.IList<string> AuctionType { get; set; }

                /// <summary>The type of context (e.g., location, platform, auction type, SSL-ness).</summary>
                [Newtonsoft.Json.JsonPropertyAttribute("contextType")]
                public virtual string ContextType { get; set; }

                /// <summary>
                /// Only set when contextType=LOCATION. Represents the geo criterias this correction applies to.
                /// </summary>
                [Newtonsoft.Json.JsonPropertyAttribute("geoCriteriaId")]
                public virtual System.Collections.Generic.IList<System.Nullable<int>> GeoCriteriaId { get; set; }

                /// <summary>
                /// Only set when contextType=PLATFORM. Represents the platforms this correction applies to.
                /// </summary>
                [Newtonsoft.Json.JsonPropertyAttribute("platform")]
                public virtual System.Collections.Generic.IList<string> Platform { get; set; }
            }
        }

        /// <summary>
        /// The filtering reasons for the creative. Read-only. This field should not be set in requests.
        /// </summary>
        public class FilteringReasonsData
        {
            /// <summary>
            /// The date in ISO 8601 format for the data. The data is collected from 00:00:00 to 23:59:59 in PST.
            /// </summary>
            [Newtonsoft.Json.JsonPropertyAttribute("date")]
            public virtual string Date { get; set; }

            /// <summary>The filtering reasons.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("reasons")]
            public virtual System.Collections.Generic.IList<ReasonsData> Reasons { get; set; }

            /// <summary>The filtering reasons.</summary>
            public class ReasonsData
            {
                /// <summary>
                /// The number of times the creative was filtered for the status. The count is aggregated across all
                /// publishers on the exchange.
                /// </summary>
                [Newtonsoft.Json.JsonPropertyAttribute("filteringCount")]
                public virtual System.Nullable<long> FilteringCount { get; set; }

                /// <summary>The filtering status code as defined in  creative-status-codes.txt.</summary>
                [Newtonsoft.Json.JsonPropertyAttribute("filteringStatus")]
                public virtual System.Nullable<int> FilteringStatus { get; set; }
            }
        }

        /// <summary>
        /// If nativeAd is set, HTMLSnippet, videoVastXML, and the videoURL outside of nativeAd should not be set. (The
        /// videoURL inside nativeAd can be set.)
        /// </summary>
        public class NativeAdData
        {
            [Newtonsoft.Json.JsonPropertyAttribute("advertiser")]
            public virtual string Advertiser { get; set; }

            /// <summary>The app icon, for app download ads.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("appIcon")]
            public virtual AppIconData AppIcon { get; set; }

            /// <summary>A long description of the ad.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("body")]
            public virtual string Body { get; set; }

            /// <summary>A label for the button that the user is supposed to click.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("callToAction")]
            public virtual string CallToAction { get; set; }

            /// <summary>The URL that the browser/SDK will load when the user clicks the ad.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("clickLinkUrl")]
            public virtual string ClickLinkUrl { get; set; }

            /// <summary>The URL to use for click tracking.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("clickTrackingUrl")]
            public virtual string ClickTrackingUrl { get; set; }

            /// <summary>A short title for the ad.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("headline")]
            public virtual string Headline { get; set; }

            /// <summary>A large image.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("image")]
            public virtual ImageData Image { get; set; }

            /// <summary>The URLs are called when the impression is rendered.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("impressionTrackingUrl")]
            public virtual System.Collections.Generic.IList<string> ImpressionTrackingUrl { get; set; }

            /// <summary>A smaller image, for the advertiser logo.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("logo")]
            public virtual LogoData Logo { get; set; }

            /// <summary>The price of the promoted app including the currency info.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("price")]
            public virtual string Price { get; set; }

            /// <summary>The app rating in the app store. Must be in the range [0-5].</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("starRating")]
            public virtual System.Nullable<double> StarRating { get; set; }

            /// <summary>
            /// The URL of the XML VAST for a native ad. Note this is a separate field from resource.video_url.
            /// </summary>
            [Newtonsoft.Json.JsonPropertyAttribute("videoURL")]
            public virtual string VideoURL { get; set; }

            /// <summary>The app icon, for app download ads.</summary>
            public class AppIconData
            {
                [Newtonsoft.Json.JsonPropertyAttribute("height")]
                public virtual System.Nullable<int> Height { get; set; }

                [Newtonsoft.Json.JsonPropertyAttribute("url")]
                public virtual string Url { get; set; }

                [Newtonsoft.Json.JsonPropertyAttribute("width")]
                public virtual System.Nullable<int> Width { get; set; }
            }

            /// <summary>A large image.</summary>
            public class ImageData
            {
                [Newtonsoft.Json.JsonPropertyAttribute("height")]
                public virtual System.Nullable<int> Height { get; set; }

                [Newtonsoft.Json.JsonPropertyAttribute("url")]
                public virtual string Url { get; set; }

                [Newtonsoft.Json.JsonPropertyAttribute("width")]
                public virtual System.Nullable<int> Width { get; set; }
            }

            /// <summary>A smaller image, for the advertiser logo.</summary>
            public class LogoData
            {
                [Newtonsoft.Json.JsonPropertyAttribute("height")]
                public virtual System.Nullable<int> Height { get; set; }

                [Newtonsoft.Json.JsonPropertyAttribute("url")]
                public virtual string Url { get; set; }

                [Newtonsoft.Json.JsonPropertyAttribute("width")]
                public virtual System.Nullable<int> Width { get; set; }
            }
        }

        /// <summary>
        /// The granular status of this ad in specific contexts. A context here relates to where something ultimately
        /// serves (for example, a physical location, a platform, an HTTPS vs HTTP request, or the type of auction).
        /// Read-only. This field should not be set in requests. See the examples in the Creatives guide for more
        /// details.
        /// </summary>
        public class ServingRestrictionsData
        {
            /// <summary>All known contexts/restrictions.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("contexts")]
            public virtual System.Collections.Generic.IList<ContextsData> Contexts { get; set; }

            /// <summary>
            /// The reasons for disapproval within this restriction, if any. Note that not all disapproval reasons may
            /// be categorized, so it is possible for the creative to have a status of DISAPPROVED or
            /// CONDITIONALLY_APPROVED with an empty list for disapproval_reasons. In this case, please reach out to
            /// your TAM to help debug the issue.
            /// </summary>
            [Newtonsoft.Json.JsonPropertyAttribute("disapprovalReasons")]
            public virtual System.Collections.Generic.IList<DisapprovalReasonsData> DisapprovalReasons { get; set; }

            /// <summary>
            /// Why the creative is ineligible to serve in this context (e.g., it has been explicitly disapproved or is
            /// pending review).
            /// </summary>
            [Newtonsoft.Json.JsonPropertyAttribute("reason")]
            public virtual string Reason { get; set; }

            /// <summary>All known contexts/restrictions.</summary>
            public class ContextsData
            {
                /// <summary>
                /// Only set when contextType=AUCTION_TYPE. Represents the auction types this restriction applies to.
                /// </summary>
                [Newtonsoft.Json.JsonPropertyAttribute("auctionType")]
                public virtual System.Collections.Generic.IList<string> AuctionType { get; set; }

                /// <summary>The type of context (e.g., location, platform, auction type, SSL-ness).</summary>
                [Newtonsoft.Json.JsonPropertyAttribute("contextType")]
                public virtual string ContextType { get; set; }

                /// <summary>
                /// Only set when contextType=LOCATION. Represents the geo criterias this restriction applies to.
                /// Impressions are considered to match a context if either the user location or publisher location
                /// matches a given geoCriteriaId.
                /// </summary>
                [Newtonsoft.Json.JsonPropertyAttribute("geoCriteriaId")]
                public virtual System.Collections.Generic.IList<System.Nullable<int>> GeoCriteriaId { get; set; }

                /// <summary>
                /// Only set when contextType=PLATFORM. Represents the platforms this restriction applies to.
                /// </summary>
                [Newtonsoft.Json.JsonPropertyAttribute("platform")]
                public virtual System.Collections.Generic.IList<string> Platform { get; set; }
            }

            /// <summary>
            /// The reasons for disapproval within this restriction, if any. Note that not all disapproval reasons may
            /// be categorized, so it is possible for the creative to have a status of DISAPPROVED or
            /// CONDITIONALLY_APPROVED with an empty list for disapproval_reasons. In this case, please reach out to
            /// your TAM to help debug the issue.
            /// </summary>
            public class DisapprovalReasonsData
            {
                /// <summary>Additional details about the reason for disapproval.</summary>
                [Newtonsoft.Json.JsonPropertyAttribute("details")]
                public virtual System.Collections.Generic.IList<string> Details { get; set; }

                /// <summary>The categorized reason for disapproval.</summary>
                [Newtonsoft.Json.JsonPropertyAttribute("reason")]
                public virtual string Reason { get; set; }
            }
        }
    }

    /// <summary>The external deal ids associated with a creative.</summary>
    public class CreativeDealIds : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A list of external deal ids and ARC approval status.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dealStatuses")]
        public virtual System.Collections.Generic.IList<DealStatusesData> DealStatuses { get; set; }

        /// <summary>Resource type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }

        /// <summary>A list of external deal ids and ARC approval status.</summary>
        public class DealStatusesData
        {
            /// <summary>ARC approval status.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("arcStatus")]
            public virtual string ArcStatus { get; set; }

            /// <summary>External deal ID.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("dealId")]
            public virtual System.Nullable<long> DealId { get; set; }

            /// <summary>Publisher ID.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("webPropertyId")]
            public virtual System.Nullable<int> WebPropertyId { get; set; }
        }
    }

    /// <summary>
    /// The creatives feed lists the active creatives for the Ad Exchange buyer accounts that the user has access to.
    /// Each entry in the feed corresponds to a single creative.
    /// </summary>
    public class CreativesList : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A list of creatives.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("items")]
        public virtual System.Collections.Generic.IList<Creative> Items { get; set; }

        /// <summary>Resource type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>
        /// Continuation token used to page through creatives. To retrieve the next page of results, set the next
        /// request's "pageToken" value to this.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class DealServingMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// True if alcohol ads are allowed for this deal (read-only). This field is only populated when querying for
        /// finalized orders using the method GetFinalizedOrderDeals
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("alcoholAdsAllowed")]
        public virtual System.Nullable<bool> AlcoholAdsAllowed { get; set; }

        /// <summary>
        /// Tracks which parties (if any) have paused a deal. (readonly, except via PauseResumeOrderDeals action)
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dealPauseStatus")]
        public virtual DealServingMetadataDealPauseStatus DealPauseStatus { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Tracks which parties (if any) have paused a deal. The deal is considered paused if has_buyer_paused ||
    /// has_seller_paused. Each of the has_buyer_paused or the has_seller_paused bits can be set independently.
    /// </summary>
    public class DealServingMetadataDealPauseStatus : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("buyerPauseReason")]
        public virtual string BuyerPauseReason { get; set; }

        /// <summary>If the deal is paused, records which party paused the deal first.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("firstPausedBy")]
        public virtual string FirstPausedBy { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("hasBuyerPaused")]
        public virtual System.Nullable<bool> HasBuyerPaused { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("hasSellerPaused")]
        public virtual System.Nullable<bool> HasSellerPaused { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("sellerPauseReason")]
        public virtual string SellerPauseReason { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class DealTerms : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Visibility of the URL in bid requests.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("brandingType")]
        public virtual string BrandingType { get; set; }

        /// <summary>
        /// Indicates that this ExternalDealId exists under at least two different AdxInventoryDeals. Currently, the
        /// only case that the same ExternalDealId will exist is programmatic cross sell case.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("crossListedExternalDealIdType")]
        public virtual string CrossListedExternalDealIdType { get; set; }

        /// <summary>Description for the proposed terms of the deal.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>
        /// Non-binding estimate of the estimated gross spend for this deal Can be set by buyer or seller.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("estimatedGrossSpend")]
        public virtual Price EstimatedGrossSpend { get; set; }

        /// <summary>Non-binding estimate of the impressions served per day Can be set by buyer or seller.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("estimatedImpressionsPerDay")]
        public virtual System.Nullable<long> EstimatedImpressionsPerDay { get; set; }

        /// <summary>The terms for guaranteed fixed price deals.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("guaranteedFixedPriceTerms")]
        public virtual DealTermsGuaranteedFixedPriceTerms GuaranteedFixedPriceTerms { get; set; }

        /// <summary>The terms for non-guaranteed auction deals.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nonGuaranteedAuctionTerms")]
        public virtual DealTermsNonGuaranteedAuctionTerms NonGuaranteedAuctionTerms { get; set; }

        /// <summary>The terms for non-guaranteed fixed price deals.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nonGuaranteedFixedPriceTerms")]
        public virtual DealTermsNonGuaranteedFixedPriceTerms NonGuaranteedFixedPriceTerms { get; set; }

        /// <summary>The terms for rubicon non-guaranteed deals.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rubiconNonGuaranteedTerms")]
        public virtual DealTermsRubiconNonGuaranteedTerms RubiconNonGuaranteedTerms { get; set; }

        /// <summary>
        /// For deals with Cost Per Day billing, defines the timezone used to mark the boundaries of a day
        /// (buyer-readonly)
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sellerTimeZone")]
        public virtual string SellerTimeZone { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class DealTermsGuaranteedFixedPriceTerms : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// External billing info for this Deal. This field is relevant when external billing info such as price has a
        /// different currency code than DFP/AdX.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("billingInfo")]
        public virtual DealTermsGuaranteedFixedPriceTermsBillingInfo BillingInfo { get; set; }

        /// <summary>Fixed price for the specified buyer.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fixedPrices")]
        public virtual System.Collections.Generic.IList<PricePerBuyer> FixedPrices { get; set; }

        /// <summary>
        /// Guaranteed impressions as a percentage. This is the percentage of guaranteed looks that the buyer is
        /// guaranteeing to buy.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("guaranteedImpressions")]
        public virtual System.Nullable<long> GuaranteedImpressions { get; set; }

        /// <summary>
        /// Count of guaranteed looks. Required for deal, optional for product. For CPD deals, buyer changes to
        /// guaranteed_looks will be ignored.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("guaranteedLooks")]
        public virtual System.Nullable<long> GuaranteedLooks { get; set; }

        /// <summary>
        /// Count of minimum daily looks for a CPD deal. For CPD deals, buyer should negotiate on this field instead of
        /// guaranteed_looks.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("minimumDailyLooks")]
        public virtual System.Nullable<long> MinimumDailyLooks { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class DealTermsGuaranteedFixedPriceTermsBillingInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The timestamp (in ms since epoch) when the original reservation price for the deal was first converted to
        /// DFP currency. This is used to convert the contracted price into buyer's currency without discrepancy.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("currencyConversionTimeMs")]
        public virtual System.Nullable<long> CurrencyConversionTimeMs { get; set; }

        /// <summary>
        /// The DFP line item id associated with this deal. For features like CPD, buyers can retrieve the DFP line item
        /// for billing reconciliation.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dfpLineItemId")]
        public virtual System.Nullable<long> DfpLineItemId { get; set; }

        /// <summary>
        /// The original contracted quantity (# impressions) for this deal. To ensure delivery, sometimes the publisher
        /// will book the deal with a impression buffer, such that guaranteed_looks is greater than the contracted
        /// quantity. However clients are billed using the original contracted quantity.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("originalContractedQuantity")]
        public virtual System.Nullable<long> OriginalContractedQuantity { get; set; }

        /// <summary>
        /// The original reservation price for the deal, if the currency code is different from the one used in
        /// negotiation.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("price")]
        public virtual Price Price { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class DealTermsNonGuaranteedAuctionTerms : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// True if open auction buyers are allowed to compete with invited buyers in this private auction
        /// (buyer-readonly).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("autoOptimizePrivateAuction")]
        public virtual System.Nullable<bool> AutoOptimizePrivateAuction { get; set; }

        /// <summary>Reserve price for the specified buyer.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reservePricePerBuyers")]
        public virtual System.Collections.Generic.IList<PricePerBuyer> ReservePricePerBuyers { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class DealTermsNonGuaranteedFixedPriceTerms : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Fixed price for the specified buyer.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fixedPrices")]
        public virtual System.Collections.Generic.IList<PricePerBuyer> FixedPrices { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class DealTermsRubiconNonGuaranteedTerms : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional price for Rubicon priority access in the auction.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("priorityPrice")]
        public virtual Price PriorityPrice { get; set; }

        /// <summary>Optional price for Rubicon standard access in the auction.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("standardPrice")]
        public virtual Price StandardPrice { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class DeleteOrderDealsRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>List of deals to delete for a given proposal</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dealIds")]
        public virtual System.Collections.Generic.IList<string> DealIds { get; set; }

        /// <summary>The last known proposal revision number.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("proposalRevisionNumber")]
        public virtual System.Nullable<long> ProposalRevisionNumber { get; set; }

        /// <summary>Indicates an optional action to take on the proposal</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateAction")]
        public virtual string UpdateAction { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class DeleteOrderDealsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>List of deals deleted (in the same proposal as passed in the request)</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deals")]
        public virtual System.Collections.Generic.IList<MarketplaceDeal> Deals { get; set; }

        /// <summary>The updated revision number for the proposal.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("proposalRevisionNumber")]
        public virtual System.Nullable<long> ProposalRevisionNumber { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class DeliveryControl : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("creativeBlockingLevel")]
        public virtual string CreativeBlockingLevel { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("deliveryRateType")]
        public virtual string DeliveryRateType { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("frequencyCaps")]
        public virtual System.Collections.Generic.IList<DeliveryControlFrequencyCap> FrequencyCaps { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class DeliveryControlFrequencyCap : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("maxImpressions")]
        public virtual System.Nullable<int> MaxImpressions { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("numTimeUnits")]
        public virtual System.Nullable<int> NumTimeUnits { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("timeUnitType")]
        public virtual string TimeUnitType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// This message carries publisher provided breakdown. E.g. {dimension_type: 'COUNTRY', [{dimension_value: {id: 1,
    /// name: 'US'}}, {dimension_value: {id: 2, name: 'UK'}}]}
    /// </summary>
    public class Dimension : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("dimensionType")]
        public virtual string DimensionType { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("dimensionValues")]
        public virtual System.Collections.Generic.IList<DimensionDimensionValue> DimensionValues { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Value of the dimension.</summary>
    public class DimensionDimensionValue : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Id of the dimension.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual System.Nullable<int> Id { get; set; }

        /// <summary>
        /// Name of the dimension mainly for debugging purposes, except for the case of CREATIVE_SIZE. For
        /// CREATIVE_SIZE, strings are used instead of ids.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Percent of total impressions for a dimension type. e.g. {dimension_type: 'GENDER', [{dimension_value: {id:
        /// 1, name: 'MALE', percentage: 60}}]} Gender MALE is 60% of all impressions which have gender.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("percentage")]
        public virtual System.Nullable<int> Percentage { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class EditAllOrderDealsRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// List of deals to edit. Service may perform 3 different operations based on comparison of deals in this list
        /// vs deals already persisted in database: 1. Add new deal to proposal If a deal in this list does not exist in
        /// the proposal, the service will create a new deal and add it to the proposal. Validation will follow
        /// AddOrderDealsRequest. 2. Update existing deal in the proposal If a deal in this list already exist in the
        /// proposal, the service will update that existing deal to this new deal in the request. Validation will follow
        /// UpdateOrderDealsRequest. 3. Delete deals from the proposal (just need the id) If a existing deal in the
        /// proposal is not present in this list, the service will delete that deal from the proposal. Validation will
        /// follow DeleteOrderDealsRequest.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deals")]
        public virtual System.Collections.Generic.IList<MarketplaceDeal> Deals { get; set; }

        /// <summary>
        /// If specified, also updates the proposal in the batch transaction. This is useful when the proposal and the
        /// deals need to be updated in one transaction.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("proposal")]
        public virtual Proposal Proposal { get; set; }

        /// <summary>The last known revision number for the proposal.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("proposalRevisionNumber")]
        public virtual System.Nullable<long> ProposalRevisionNumber { get; set; }

        /// <summary>Indicates an optional action to take on the proposal</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateAction")]
        public virtual string UpdateAction { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class EditAllOrderDealsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>List of all deals in the proposal after edit.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deals")]
        public virtual System.Collections.Generic.IList<MarketplaceDeal> Deals { get; set; }

        /// <summary>The latest revision number after the update has been applied.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("orderRevisionNumber")]
        public virtual System.Nullable<long> OrderRevisionNumber { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class GetOffersResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The returned list of products.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("products")]
        public virtual System.Collections.Generic.IList<Product> Products { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class GetOrderDealsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>List of deals for the proposal</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deals")]
        public virtual System.Collections.Generic.IList<MarketplaceDeal> Deals { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class GetOrderNotesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The list of matching notes. The notes for a proposal are ordered from oldest to newest. If the notes span
        /// multiple proposals, they will be grouped by proposal, with the notes for the most recently modified proposal
        /// appearing first.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("notes")]
        public virtual System.Collections.Generic.IList<MarketplaceNote> Notes { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class GetOrdersResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The list of matching proposals.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("proposals")]
        public virtual System.Collections.Generic.IList<Proposal> Proposals { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class GetPublisherProfilesByAccountIdResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Profiles for the requested publisher</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("profiles")]
        public virtual System.Collections.Generic.IList<PublisherProfileApiProto> Profiles { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A proposal can contain multiple deals. A deal contains the terms and targeting information that is used for
    /// serving.
    /// </summary>
    public class MarketplaceDeal : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Buyer private data (hidden from seller).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("buyerPrivateData")]
        public virtual PrivateData BuyerPrivateData { get; set; }

        /// <summary>The time (ms since epoch) of the deal creation. (readonly)</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("creationTimeMs")]
        public virtual System.Nullable<long> CreationTimeMs { get; set; }

        /// <summary>Specifies the creative pre-approval policy (buyer-readonly)</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("creativePreApprovalPolicy")]
        public virtual string CreativePreApprovalPolicy { get; set; }

        /// <summary>Specifies whether the creative is safeFrame compatible (buyer-readonly)</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("creativeSafeFrameCompatibility")]
        public virtual string CreativeSafeFrameCompatibility { get; set; }

        /// <summary>A unique deal-id for the deal (readonly).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dealId")]
        public virtual string DealId { get; set; }

        /// <summary>Metadata about the serving status of this deal (readonly, writes via custom actions)</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dealServingMetadata")]
        public virtual DealServingMetadata DealServingMetadata { get; set; }

        /// <summary>
        /// The set of fields around delivery control that are interesting for a buyer to see but are non-negotiable.
        /// These are set by the publisher. This message is assigned an id of 100 since some day we would want to model
        /// this as a protobuf extension.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deliveryControl")]
        public virtual DeliveryControl DeliveryControl { get; set; }

        /// <summary>
        /// The external deal id assigned to this deal once the deal is finalized. This is the deal-id that shows up in
        /// serving/reporting etc. (readonly)
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("externalDealId")]
        public virtual string ExternalDealId { get; set; }

        /// <summary>
        /// Proposed flight end time of the deal (ms since epoch) This will generally be stored in a granularity of a
        /// second. (updatable)
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("flightEndTimeMs")]
        public virtual System.Nullable<long> FlightEndTimeMs { get; set; }

        /// <summary>
        /// Proposed flight start time of the deal (ms since epoch) This will generally be stored in a granularity of a
        /// second. (updatable)
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("flightStartTimeMs")]
        public virtual System.Nullable<long> FlightStartTimeMs { get; set; }

        /// <summary>Description for the deal terms. (buyer-readonly)</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inventoryDescription")]
        public virtual string InventoryDescription { get; set; }

        /// <summary>
        /// Indicates whether the current deal is a RFP template. RFP template is created by buyer and not based on
        /// seller created products.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("isRfpTemplate")]
        public virtual System.Nullable<bool> IsRfpTemplate { get; set; }

        /// <summary>
        /// True, if the buyside inventory setup is complete for this deal. (readonly, except via OrderSetupCompleted
        /// action)
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("isSetupComplete")]
        public virtual System.Nullable<bool> IsSetupComplete { get; set; }

        /// <summary>
        /// Identifies what kind of resource this is. Value: the fixed string "adexchangebuyer#marketplaceDeal".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>The time (ms since epoch) when the deal was last updated. (readonly)</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lastUpdateTimeMs")]
        public virtual System.Nullable<long> LastUpdateTimeMs { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("makegoodRequestedReason")]
        public virtual string MakegoodRequestedReason { get; set; }

        /// <summary>The name of the deal. (updatable)</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The product-id from which this deal was created. (readonly, except on create)</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("productId")]
        public virtual string ProductId { get; set; }

        /// <summary>
        /// The revision number of the product that the deal was created from (readonly, except on create)
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("productRevisionNumber")]
        public virtual System.Nullable<long> ProductRevisionNumber { get; set; }

        /// <summary>
        /// Specifies the creative source for programmatic deals, PUBLISHER means creative is provided by seller and
        /// ADVERTISR means creative is provided by buyer. (buyer-readonly)
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("programmaticCreativeSource")]
        public virtual string ProgrammaticCreativeSource { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("proposalId")]
        public virtual string ProposalId { get; set; }

        /// <summary>Optional Seller contact information for the deal (buyer-readonly)</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sellerContacts")]
        public virtual System.Collections.Generic.IList<ContactInformation> SellerContacts { get; set; }

        /// <summary>
        /// The shared targeting visible to buyers and sellers. Each shared targeting entity is AND'd together.
        /// (updatable)
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sharedTargetings")]
        public virtual System.Collections.Generic.IList<SharedTargeting> SharedTargetings { get; set; }

        /// <summary>The syndication product associated with the deal. (readonly, except on create)</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("syndicationProduct")]
        public virtual string SyndicationProduct { get; set; }

        /// <summary>The negotiable terms of the deal. (updatable)</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("terms")]
        public virtual DealTerms Terms { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("webPropertyCode")]
        public virtual string WebPropertyCode { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class MarketplaceDealParty : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The buyer/seller associated with the deal. One of buyer/seller is specified for a deal-party.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("buyer")]
        public virtual Buyer Buyer { get; set; }

        /// <summary>
        /// The buyer/seller associated with the deal. One of buyer/seller is specified for a deal party.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("seller")]
        public virtual Seller Seller { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class MarketplaceLabel : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The accountId of the party that created the label.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accountId")]
        public virtual string AccountId { get; set; }

        /// <summary>The creation time (in ms since epoch) for the label.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTimeMs")]
        public virtual System.Nullable<long> CreateTimeMs { get; set; }

        /// <summary>Information about the party that created the label.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deprecatedMarketplaceDealParty")]
        public virtual MarketplaceDealParty DeprecatedMarketplaceDealParty { get; set; }

        /// <summary>The label to use.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("label")]
        public virtual string Label { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A proposal is associated with a bunch of notes which may optionally be associated with a deal and/or revision
    /// number.
    /// </summary>
    public class MarketplaceNote : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The role of the person (buyer/seller) creating the note. (readonly)</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("creatorRole")]
        public virtual string CreatorRole { get; set; }

        /// <summary>Notes can optionally be associated with a deal. (readonly, except on create)</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dealId")]
        public virtual string DealId { get; set; }

        /// <summary>
        /// Identifies what kind of resource this is. Value: the fixed string "adexchangebuyer#marketplaceNote".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>The actual note to attach. (readonly, except on create)</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("note")]
        public virtual string Note { get; set; }

        /// <summary>The unique id for the note. (readonly)</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("noteId")]
        public virtual string NoteId { get; set; }

        /// <summary>The proposalId that a note is attached to. (readonly)</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("proposalId")]
        public virtual string ProposalId { get; set; }

        /// <summary>
        /// If the note is associated with a proposal revision number, then store that here. (readonly, except on
        /// create)
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("proposalRevisionNumber")]
        public virtual System.Nullable<long> ProposalRevisionNumber { get; set; }

        /// <summary>The timestamp (ms since epoch) that this note was created. (readonly)</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timestampMs")]
        public virtual System.Nullable<long> TimestampMs { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class MobileApplication : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("appStore")]
        public virtual string AppStore { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("externalAppId")]
        public virtual string ExternalAppId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The configuration data for an Ad Exchange performance report list.</summary>
    public class PerformanceReport : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The number of bid responses with an ad.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bidRate")]
        public virtual System.Nullable<double> BidRate { get; set; }

        /// <summary>The number of bid requests sent to your bidder.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bidRequestRate")]
        public virtual System.Nullable<double> BidRequestRate { get; set; }

        /// <summary>
        /// Rate of various prefiltering statuses per match. Please refer to the callout-status-codes.txt file for
        /// different statuses.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("calloutStatusRate")]
        public virtual System.Collections.Generic.IList<object> CalloutStatusRate { get; set; }

        /// <summary>Average QPS for cookie matcher operations.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cookieMatcherStatusRate")]
        public virtual System.Collections.Generic.IList<object> CookieMatcherStatusRate { get; set; }

        /// <summary>
        /// Rate of ads with a given status. Please refer to the creative-status-codes.txt file for different statuses.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("creativeStatusRate")]
        public virtual System.Collections.Generic.IList<object> CreativeStatusRate { get; set; }

        /// <summary>The number of bid responses that were filtered due to a policy violation or other errors.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("filteredBidRate")]
        public virtual System.Nullable<double> FilteredBidRate { get; set; }

        /// <summary>Average QPS for hosted match operations.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hostedMatchStatusRate")]
        public virtual System.Collections.Generic.IList<object> HostedMatchStatusRate { get; set; }

        /// <summary>The number of potential queries based on your pretargeting settings.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inventoryMatchRate")]
        public virtual System.Nullable<double> InventoryMatchRate { get; set; }

        /// <summary>Resource type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>
        /// The 50th percentile round trip latency(ms) as perceived from Google servers for the duration period covered
        /// by the report.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("latency50thPercentile")]
        public virtual System.Nullable<double> Latency50thPercentile { get; set; }

        /// <summary>
        /// The 85th percentile round trip latency(ms) as perceived from Google servers for the duration period covered
        /// by the report.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("latency85thPercentile")]
        public virtual System.Nullable<double> Latency85thPercentile { get; set; }

        /// <summary>
        /// The 95th percentile round trip latency(ms) as perceived from Google servers for the duration period covered
        /// by the report.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("latency95thPercentile")]
        public virtual System.Nullable<double> Latency95thPercentile { get; set; }

        /// <summary>Rate of various quota account statuses per quota check.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("noQuotaInRegion")]
        public virtual System.Nullable<double> NoQuotaInRegion { get; set; }

        /// <summary>Rate of various quota account statuses per quota check.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("outOfQuota")]
        public virtual System.Nullable<double> OutOfQuota { get; set; }

        /// <summary>Average QPS for pixel match requests from clients.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pixelMatchRequests")]
        public virtual System.Nullable<double> PixelMatchRequests { get; set; }

        /// <summary>Average QPS for pixel match responses from clients.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pixelMatchResponses")]
        public virtual System.Nullable<double> PixelMatchResponses { get; set; }

        /// <summary>The configured quota limits for this account.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("quotaConfiguredLimit")]
        public virtual System.Nullable<double> QuotaConfiguredLimit { get; set; }

        /// <summary>The throttled quota limits for this account.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("quotaThrottledLimit")]
        public virtual System.Nullable<double> QuotaThrottledLimit { get; set; }

        /// <summary>The trading location of this data.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("region")]
        public virtual string Region { get; set; }

        /// <summary>The number of properly formed bid responses received by our servers within the deadline.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("successfulRequestRate")]
        public virtual System.Nullable<double> SuccessfulRequestRate { get; set; }

        /// <summary>The unix timestamp of the starting time of this performance data.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timestamp")]
        public virtual System.Nullable<long> Timestamp { get; set; }

        /// <summary>
        /// The number of bid responses that were unsuccessful due to timeouts, incorrect formatting, etc.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unsuccessfulRequestRate")]
        public virtual System.Nullable<double> UnsuccessfulRequestRate { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The configuration data for an Ad Exchange performance report list.</summary>
    public class PerformanceReportList : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Resource type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>A list of performance reports relevant for the account.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("performanceReport")]
        public virtual System.Collections.Generic.IList<PerformanceReport> PerformanceReport { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class PretargetingConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The id for billing purposes, provided for reference. Leave this field blank for insert requests; the id will
        /// be generated automatically.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("billingId")]
        public virtual System.Nullable<long> BillingId { get; set; }

        /// <summary>The config id; generated automatically. Leave this field blank for insert requests.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("configId")]
        public virtual System.Nullable<long> ConfigId { get; set; }

        /// <summary>The name of the config. Must be unique. Required for all requests.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("configName")]
        public virtual string ConfigName { get; set; }

        /// <summary>
        /// List must contain exactly one of PRETARGETING_CREATIVE_TYPE_HTML or PRETARGETING_CREATIVE_TYPE_VIDEO.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("creativeType")]
        public virtual System.Collections.Generic.IList<string> CreativeType { get; set; }

        /// <summary>
        /// Requests which allow one of these (width, height) pairs will match. All pairs must be supported ad
        /// dimensions.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dimensions")]
        public virtual System.Collections.Generic.IList<DimensionsData> Dimensions { get; set; }

        /// <summary>
        /// Requests with any of these content labels will not match. Values are from content-labels.txt in the
        /// downloadable files section.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("excludedContentLabels")]
        public virtual System.Collections.Generic.IList<System.Nullable<long>> ExcludedContentLabels { get; set; }

        /// <summary>Requests containing any of these geo criteria ids will not match.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("excludedGeoCriteriaIds")]
        public virtual System.Collections.Generic.IList<System.Nullable<long>> ExcludedGeoCriteriaIds { get; set; }

        /// <summary>Requests containing any of these placements will not match.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("excludedPlacements")]
        public virtual System.Collections.Generic.IList<ExcludedPlacementsData> ExcludedPlacements { get; set; }

        /// <summary>Requests containing any of these users list ids will not match.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("excludedUserLists")]
        public virtual System.Collections.Generic.IList<System.Nullable<long>> ExcludedUserLists { get; set; }

        /// <summary>
        /// Requests containing any of these vertical ids will not match. Values are from the publisher-verticals.txt
        /// file in the downloadable files section.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("excludedVerticals")]
        public virtual System.Collections.Generic.IList<System.Nullable<long>> ExcludedVerticals { get; set; }

        /// <summary>Requests containing any of these geo criteria ids will match.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("geoCriteriaIds")]
        public virtual System.Collections.Generic.IList<System.Nullable<long>> GeoCriteriaIds { get; set; }

        /// <summary>Whether this config is active. Required for all requests.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("isActive")]
        public virtual System.Nullable<bool> IsActive { get; set; }

        /// <summary>The kind of the resource, i.e. "adexchangebuyer#pretargetingConfig".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>Request containing any of these language codes will match.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("languages")]
        public virtual System.Collections.Generic.IList<string> Languages { get; set; }

        /// <summary>
        /// The maximum QPS allocated to this pretargeting configuration, used for pretargeting-level QPS limits. By
        /// default, this is not set, which indicates that there is no QPS limit at the configuration level (a global or
        /// account-level limit may still be imposed).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maximumQps")]
        public virtual System.Nullable<long> MaximumQps { get; set; }

        /// <summary>
        /// Requests where the predicted viewability is below the specified decile will not match. E.g. if the buyer
        /// sets this value to 5, requests from slots where the predicted viewability is below 50% will not match. If
        /// the predicted viewability is unknown this field will be ignored.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("minimumViewabilityDecile")]
        public virtual System.Nullable<int> MinimumViewabilityDecile { get; set; }

        /// <summary>
        /// Requests containing any of these mobile carrier ids will match. Values are from mobile-carriers.csv in the
        /// downloadable files section.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mobileCarriers")]
        public virtual System.Collections.Generic.IList<System.Nullable<long>> MobileCarriers { get; set; }

        /// <summary>
        /// Requests containing any of these mobile device ids will match. Values are from mobile-devices.csv in the
        /// downloadable files section.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mobileDevices")]
        public virtual System.Collections.Generic.IList<System.Nullable<long>> MobileDevices { get; set; }

        /// <summary>
        /// Requests containing any of these mobile operating system version ids will match. Values are from
        /// mobile-os.csv in the downloadable files section.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mobileOperatingSystemVersions")]
        public virtual System.Collections.Generic.IList<System.Nullable<long>> MobileOperatingSystemVersions { get; set; }

        /// <summary>Requests containing any of these placements will match.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("placements")]
        public virtual System.Collections.Generic.IList<PlacementsData> Placements { get; set; }

        /// <summary>
        /// Requests matching any of these platforms will match. Possible values are PRETARGETING_PLATFORM_MOBILE,
        /// PRETARGETING_PLATFORM_DESKTOP, and PRETARGETING_PLATFORM_TABLET.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("platforms")]
        public virtual System.Collections.Generic.IList<string> Platforms { get; set; }

        /// <summary>
        /// Creative attributes should be declared here if all creatives corresponding to this pretargeting
        /// configuration have that creative attribute. Values are from pretargetable-creative-attributes.txt in the
        /// downloadable files section.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("supportedCreativeAttributes")]
        public virtual System.Collections.Generic.IList<System.Nullable<long>> SupportedCreativeAttributes { get; set; }

        /// <summary>
        /// Requests containing the specified type of user data will match. Possible values are HOSTED_MATCH_DATA, which
        /// means the request is cookie-targetable and has a match in the buyer's hosted match table, and
        /// COOKIE_OR_IDFA, which means the request has either a targetable cookie or an iOS IDFA.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userIdentifierDataRequired")]
        public virtual System.Collections.Generic.IList<string> UserIdentifierDataRequired { get; set; }

        /// <summary>Requests containing any of these user list ids will match.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userLists")]
        public virtual System.Collections.Generic.IList<System.Nullable<long>> UserLists { get; set; }

        /// <summary>
        /// Requests that allow any of these vendor ids will match. Values are from vendors.txt in the downloadable
        /// files section.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("vendorTypes")]
        public virtual System.Collections.Generic.IList<System.Nullable<long>> VendorTypes { get; set; }

        /// <summary>Requests containing any of these vertical ids will match.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("verticals")]
        public virtual System.Collections.Generic.IList<System.Nullable<long>> Verticals { get; set; }

        /// <summary>Video requests satisfying any of these player size constraints will match.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("videoPlayerSizes")]
        public virtual System.Collections.Generic.IList<VideoPlayerSizesData> VideoPlayerSizes { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }

        /// <summary>
        /// Requests which allow one of these (width, height) pairs will match. All pairs must be supported ad
        /// dimensions.
        /// </summary>
        public class DimensionsData
        {
            /// <summary>Height in pixels.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("height")]
            public virtual System.Nullable<long> Height { get; set; }

            /// <summary>Width in pixels.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("width")]
            public virtual System.Nullable<long> Width { get; set; }
        }

        /// <summary>Requests containing any of these placements will not match.</summary>
        public class ExcludedPlacementsData
        {
            /// <summary>
            /// The value of the placement. Interpretation depends on the placement type, e.g. URL for a site placement,
            /// channel name for a channel placement, app id for a mobile app placement.
            /// </summary>
            [Newtonsoft.Json.JsonPropertyAttribute("token")]
            public virtual string Token { get; set; }

            /// <summary>The type of the placement.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("type")]
            public virtual string Type { get; set; }
        }

        /// <summary>Requests containing any of these placements will match.</summary>
        public class PlacementsData
        {
            /// <summary>
            /// The value of the placement. Interpretation depends on the placement type, e.g. URL for a site placement,
            /// channel name for a channel placement, app id for a mobile app placement.
            /// </summary>
            [Newtonsoft.Json.JsonPropertyAttribute("token")]
            public virtual string Token { get; set; }

            /// <summary>The type of the placement.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("type")]
            public virtual string Type { get; set; }
        }

        /// <summary>Video requests satisfying any of these player size constraints will match.</summary>
        public class VideoPlayerSizesData
        {
            /// <summary>The type of aspect ratio. Leave this field blank to match all aspect ratios.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("aspectRatio")]
            public virtual string AspectRatio { get; set; }

            /// <summary>
            /// The minimum player height in pixels. Leave this field blank to match any player height.
            /// </summary>
            [Newtonsoft.Json.JsonPropertyAttribute("minHeight")]
            public virtual System.Nullable<long> MinHeight { get; set; }

            /// <summary>The minimum player width in pixels. Leave this field blank to match any player width.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("minWidth")]
            public virtual System.Nullable<long> MinWidth { get; set; }
        }
    }

    public class PretargetingConfigList : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A list of pretargeting configs</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("items")]
        public virtual System.Collections.Generic.IList<PretargetingConfig> Items { get; set; }

        /// <summary>Resource type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class Price : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The price value in micros.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("amountMicros")]
        public virtual System.Nullable<double> AmountMicros { get; set; }

        /// <summary>The currency code for the price.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("currencyCode")]
        public virtual string CurrencyCode { get; set; }

        /// <summary>In case of CPD deals, the expected CPM in micros.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("expectedCpmMicros")]
        public virtual System.Nullable<double> ExpectedCpmMicros { get; set; }

        /// <summary>The pricing type for the deal/product.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pricingType")]
        public virtual string PricingType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Used to specify pricing rules for buyers. Each PricePerBuyer in a product can become [0,1] deals. To check if
    /// there is a PricePerBuyer for a particular buyer we look for the most specific matching rule - we first look for
    /// a rule matching the buyer and otherwise look for a matching rule where no buyer is set.
    /// </summary>
    public class PricePerBuyer : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional access type for this buyer.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("auctionTier")]
        public virtual string AuctionTier { get; set; }

        /// <summary>Reference to the buyer that will get billed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("billedBuyer")]
        public virtual Buyer BilledBuyer { get; set; }

        /// <summary>
        /// The buyer who will pay this price. If unset, all buyers can pay this price (if the advertisers match, and
        /// there's no more specific rule matching the buyer).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("buyer")]
        public virtual Buyer Buyer { get; set; }

        /// <summary>The specified price</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("price")]
        public virtual Price Price { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class PrivateData : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("referenceId")]
        public virtual string ReferenceId { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("referencePayload")]
        public virtual string ReferencePayload { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A product is segment of inventory that a seller wishes to sell. It is associated with certain terms and
    /// targeting information which helps buyer know more about the inventory. Each field in a product can have one of
    /// the following setting:  (readonly) - It is an error to try and set this field. (buyer-readonly) - Only the
    /// seller can set this field. (seller-readonly) - Only the buyer can set this field. (updatable) - The field is
    /// updatable at all times by either buyer or the seller.
    /// </summary>
    public class Product : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The billed buyer corresponding to the buyer that created the offer. (readonly, except on create)
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("billedBuyer")]
        public virtual Buyer BilledBuyer { get; set; }

        /// <summary>
        /// The buyer that created the offer if this is a buyer initiated offer (readonly, except on create)
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("buyer")]
        public virtual Buyer Buyer { get; set; }

        /// <summary>Creation time in ms. since epoch (readonly)</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("creationTimeMs")]
        public virtual System.Nullable<long> CreationTimeMs { get; set; }

        /// <summary>Optional contact information for the creator of this product. (buyer-readonly)</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("creatorContacts")]
        public virtual System.Collections.Generic.IList<ContactInformation> CreatorContacts { get; set; }

        /// <summary>The role that created the offer. Set to BUYER for buyer initiated offers.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("creatorRole")]
        public virtual string CreatorRole { get; set; }

        /// <summary>
        /// The set of fields around delivery control that are interesting for a buyer to see but are non-negotiable.
        /// These are set by the publisher. This message is assigned an id of 100 since some day we would want to model
        /// this as a protobuf extension.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deliveryControl")]
        public virtual DeliveryControl DeliveryControl { get; set; }

        /// <summary>The proposed end time for the deal (ms since epoch) (buyer-readonly)</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("flightEndTimeMs")]
        public virtual System.Nullable<long> FlightEndTimeMs { get; set; }

        /// <summary>
        /// Inventory availability dates. (times are in ms since epoch) The granularity is generally in the order of
        /// seconds. (buyer-readonly)
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("flightStartTimeMs")]
        public virtual System.Nullable<long> FlightStartTimeMs { get; set; }

        /// <summary>
        /// If the creator has already signed off on the product, then the buyer can finalize the deal by accepting the
        /// product as is. When copying to a proposal, if any of the terms are changed, then auto_finalize is
        /// automatically set to false.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hasCreatorSignedOff")]
        public virtual System.Nullable<bool> HasCreatorSignedOff { get; set; }

        /// <summary>What exchange will provide this inventory (readonly, except on create).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inventorySource")]
        public virtual string InventorySource { get; set; }

        /// <summary>
        /// Identifies what kind of resource this is. Value: the fixed string "adexchangebuyer#product".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>Optional List of labels for the product (optional, buyer-readonly).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IList<MarketplaceLabel> Labels { get; set; }

        /// <summary>Time of last update in ms. since epoch (readonly)</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lastUpdateTimeMs")]
        public virtual System.Nullable<long> LastUpdateTimeMs { get; set; }

        /// <summary>Optional legacy offer id if this offer is a preferred deal offer.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("legacyOfferId")]
        public virtual string LegacyOfferId { get; set; }

        /// <summary>
        /// Marketplace publisher profile Id. This Id differs from the regular publisher_profile_id in that 1. This is a
        /// new id, the old Id will be deprecated in 2017. 2. This id uniquely identifies a publisher profile by itself.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("marketplacePublisherProfileId")]
        public virtual string MarketplacePublisherProfileId { get; set; }

        /// <summary>The name for this product as set by the seller. (buyer-readonly)</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Optional private auction id if this offer is a private auction offer.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("privateAuctionId")]
        public virtual string PrivateAuctionId { get; set; }

        /// <summary>The unique id for the product (readonly)</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("productId")]
        public virtual string ProductId { get; set; }

        /// <summary>
        /// Id of the publisher profile for a given seller. A (seller.account_id, publisher_profile_id) pair uniquely
        /// identifies a publisher profile. Buyers can call the PublisherProfiles::List endpoint to get a list of
        /// publisher profiles for a given seller.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("publisherProfileId")]
        public virtual string PublisherProfileId { get; set; }

        /// <summary>Publisher self-provided forecast information.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("publisherProvidedForecast")]
        public virtual PublisherProvidedForecast PublisherProvidedForecast { get; set; }

        /// <summary>The revision number of the product. (readonly)</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("revisionNumber")]
        public virtual System.Nullable<long> RevisionNumber { get; set; }

        /// <summary>Information about the seller that created this product (readonly, except on create)</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("seller")]
        public virtual Seller Seller { get; set; }

        /// <summary>
        /// Targeting that is shared between the buyer and the seller. Each targeting criteria has a specified key and
        /// for each key there is a list of inclusion value or exclusion values. (buyer-readonly)
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sharedTargetings")]
        public virtual System.Collections.Generic.IList<SharedTargeting> SharedTargetings { get; set; }

        /// <summary>The state of the product. (buyer-readonly)</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>The syndication product associated with the deal. (readonly, except on create)</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("syndicationProduct")]
        public virtual string SyndicationProduct { get; set; }

        /// <summary>The negotiable terms of the deal (buyer-readonly)</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("terms")]
        public virtual DealTerms Terms { get; set; }

        /// <summary>
        /// The web property code for the seller. This field is meant to be copied over as is when creating deals.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("webPropertyCode")]
        public virtual string WebPropertyCode { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Represents a proposal in the marketplace. A proposal is the unit of negotiation between a seller and a buyer and
    /// contains deals which are served. Each field in a proposal can have one of the following setting:  (readonly) -
    /// It is an error to try and set this field. (buyer-readonly) - Only the seller can set this field.
    /// (seller-readonly) - Only the buyer can set this field. (updatable) - The field is updatable at all times by
    /// either buyer or the seller.
    /// </summary>
    public class Proposal : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Reference to the buyer that will get billed for this proposal. (readonly)</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("billedBuyer")]
        public virtual Buyer BilledBuyer { get; set; }

        /// <summary>Reference to the buyer on the proposal. (readonly, except on create)</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("buyer")]
        public virtual Buyer Buyer { get; set; }

        /// <summary>Optional contact information of the buyer. (seller-readonly)</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("buyerContacts")]
        public virtual System.Collections.Generic.IList<ContactInformation> BuyerContacts { get; set; }

        /// <summary>Private data for buyer. (hidden from seller).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("buyerPrivateData")]
        public virtual PrivateData BuyerPrivateData { get; set; }

        /// <summary>IDs of DBM advertisers permission to this proposal.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dbmAdvertiserIds")]
        public virtual System.Collections.Generic.IList<string> DbmAdvertiserIds { get; set; }

        /// <summary>
        /// When an proposal is in an accepted state, indicates whether the buyer has signed off. Once both sides have
        /// signed off on a deal, the proposal can be finalized by the seller. (seller-readonly)
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hasBuyerSignedOff")]
        public virtual System.Nullable<bool> HasBuyerSignedOff { get; set; }

        /// <summary>
        /// When an proposal is in an accepted state, indicates whether the buyer has signed off Once both sides have
        /// signed off on a deal, the proposal can be finalized by the seller. (buyer-readonly)
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hasSellerSignedOff")]
        public virtual System.Nullable<bool> HasSellerSignedOff { get; set; }

        /// <summary>What exchange will provide this inventory (readonly, except on create).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inventorySource")]
        public virtual string InventorySource { get; set; }

        /// <summary>True if the proposal is being renegotiated (readonly).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("isRenegotiating")]
        public virtual System.Nullable<bool> IsRenegotiating { get; set; }

        /// <summary>
        /// True, if the buyside inventory setup is complete for this proposal. (readonly, except via
        /// OrderSetupCompleted action) Deprecated in favor of deal level setup complete flag.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("isSetupComplete")]
        public virtual System.Nullable<bool> IsSetupComplete { get; set; }

        /// <summary>
        /// Identifies what kind of resource this is. Value: the fixed string "adexchangebuyer#proposal".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>List of labels associated with the proposal. (readonly)</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IList<MarketplaceLabel> Labels { get; set; }

        /// <summary>The role of the last user that either updated the proposal or left a comment. (readonly)</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lastUpdaterOrCommentorRole")]
        public virtual string LastUpdaterOrCommentorRole { get; set; }

        /// <summary>The name for the proposal (updatable)</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Optional negotiation id if this proposal is a preferred deal proposal.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("negotiationId")]
        public virtual string NegotiationId { get; set; }

        /// <summary>Indicates whether the buyer/seller created the proposal.(readonly)</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("originatorRole")]
        public virtual string OriginatorRole { get; set; }

        /// <summary>Optional private auction id if this proposal is a private auction proposal.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("privateAuctionId")]
        public virtual string PrivateAuctionId { get; set; }

        /// <summary>The unique id of the proposal. (readonly).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("proposalId")]
        public virtual string ProposalId { get; set; }

        /// <summary>The current state of the proposal. (readonly)</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("proposalState")]
        public virtual string ProposalState { get; set; }

        /// <summary>The revision number for the proposal (readonly).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("revisionNumber")]
        public virtual System.Nullable<long> RevisionNumber { get; set; }

        /// <summary>The time (ms since epoch) when the proposal was last revised (readonly).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("revisionTimeMs")]
        public virtual System.Nullable<long> RevisionTimeMs { get; set; }

        /// <summary>Reference to the seller on the proposal. (readonly, except on create)</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("seller")]
        public virtual Seller Seller { get; set; }

        /// <summary>Optional contact information of the seller (buyer-readonly).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sellerContacts")]
        public virtual System.Collections.Generic.IList<ContactInformation> SellerContacts { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class PublisherProfileApiProto : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Publisher provided info on its audience.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("audience")]
        public virtual string Audience { get; set; }

        /// <summary>A pitch statement for the buyer</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("buyerPitchStatement")]
        public virtual string BuyerPitchStatement { get; set; }

        /// <summary>Direct contact for the publisher profile.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("directContact")]
        public virtual string DirectContact { get; set; }

        /// <summary>Exchange where this publisher profile is from. E.g. AdX, Rubicon etc...</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("exchange")]
        public virtual string Exchange { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("forecastInventory")]
        public virtual string ForecastInventory { get; set; }

        /// <summary>Link to publisher's Google+ page.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("googlePlusLink")]
        public virtual string GooglePlusLink { get; set; }

        /// <summary>True, if this is the parent profile, which represents all domains owned by the publisher.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("isParent")]
        public virtual System.Nullable<bool> IsParent { get; set; }

        /// <summary>True, if this profile is published. Deprecated for state.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("isPublished")]
        public virtual System.Nullable<bool> IsPublished { get; set; }

        /// <summary>
        /// Identifies what kind of resource this is. Value: the fixed string
        /// "adexchangebuyer#publisherProfileApiProto".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>The url to the logo for the publisher.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("logoUrl")]
        public virtual string LogoUrl { get; set; }

        /// <summary>The url for additional marketing and sales materials.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mediaKitLink")]
        public virtual string MediaKitLink { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Publisher provided overview.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("overview")]
        public virtual string Overview { get; set; }

        /// <summary>
        /// The pair of (seller.account_id, profile_id) uniquely identifies a publisher profile for a given publisher.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("profileId")]
        public virtual System.Nullable<int> ProfileId { get; set; }

        /// <summary>Programmatic contact for the publisher profile.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("programmaticContact")]
        public virtual string ProgrammaticContact { get; set; }

        /// <summary>
        /// The list of app IDs represented in this publisher profile. Empty if this is a parent profile. Deprecated in
        /// favor of publisher_app.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("publisherAppIds")]
        public virtual System.Collections.Generic.IList<System.Nullable<long>> PublisherAppIds { get; set; }

        /// <summary>
        /// The list of apps represented in this publisher profile. Empty if this is a parent profile.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("publisherApps")]
        public virtual System.Collections.Generic.IList<MobileApplication> PublisherApps { get; set; }

        /// <summary>
        /// The list of domains represented in this publisher profile. Empty if this is a parent profile.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("publisherDomains")]
        public virtual System.Collections.Generic.IList<string> PublisherDomains { get; set; }

        /// <summary>Unique Id for publisher profile.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("publisherProfileId")]
        public virtual string PublisherProfileId { get; set; }

        /// <summary>Publisher provided forecasting information.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("publisherProvidedForecast")]
        public virtual PublisherProvidedForecast PublisherProvidedForecast { get; set; }

        /// <summary>Link to publisher rate card</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rateCardInfoLink")]
        public virtual string RateCardInfoLink { get; set; }

        /// <summary>Link for a sample content page.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("samplePageLink")]
        public virtual string SamplePageLink { get; set; }

        /// <summary>Seller of the publisher profile.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("seller")]
        public virtual Seller Seller { get; set; }

        /// <summary>State of the publisher profile.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>Publisher provided key metrics and rankings.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("topHeadlines")]
        public virtual System.Collections.Generic.IList<string> TopHeadlines { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>This message carries publisher provided forecasting information.</summary>
    public class PublisherProvidedForecast : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Publisher provided dimensions. E.g. geo, sizes etc...</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dimensions")]
        public virtual System.Collections.Generic.IList<Dimension> Dimensions { get; set; }

        /// <summary>Publisher provided weekly impressions.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("weeklyImpressions")]
        public virtual System.Nullable<long> WeeklyImpressions { get; set; }

        /// <summary>Publisher provided weekly uniques.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("weeklyUniques")]
        public virtual System.Nullable<long> WeeklyUniques { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class Seller : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The unique id for the seller. The seller fills in this field. The seller account id is then available to
        /// buyer in the product.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accountId")]
        public virtual string AccountId { get; set; }

        /// <summary>Optional sub-account id for the seller.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("subAccountId")]
        public virtual string SubAccountId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class SharedTargeting : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The list of values to exclude from targeting. Each value is AND'd together.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("exclusions")]
        public virtual System.Collections.Generic.IList<TargetingValue> Exclusions { get; set; }

        /// <summary>The list of value to include as part of the targeting. Each value is OR'd together.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inclusions")]
        public virtual System.Collections.Generic.IList<TargetingValue> Inclusions { get; set; }

        /// <summary>The key representing the shared targeting criterion.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("key")]
        public virtual string Key { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class TargetingValue : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The creative size value to exclude/include.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("creativeSizeValue")]
        public virtual TargetingValueCreativeSize CreativeSizeValue { get; set; }

        /// <summary>
        /// The daypart targeting to include / exclude. Filled in when the key is GOOG_DAYPART_TARGETING.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dayPartTargetingValue")]
        public virtual TargetingValueDayPartTargeting DayPartTargetingValue { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("demogAgeCriteriaValue")]
        public virtual TargetingValueDemogAgeCriteria DemogAgeCriteriaValue { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("demogGenderCriteriaValue")]
        public virtual TargetingValueDemogGenderCriteria DemogGenderCriteriaValue { get; set; }

        /// <summary>The long value to exclude/include.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("longValue")]
        public virtual System.Nullable<long> LongValue { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("requestPlatformTargetingValue")]
        public virtual TargetingValueRequestPlatformTargeting RequestPlatformTargetingValue { get; set; }

        /// <summary>The string value to exclude/include.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stringValue")]
        public virtual string StringValue { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Next Id: 7</summary>
    public class TargetingValueCreativeSize : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The formats allowed by the publisher.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allowedFormats")]
        public virtual System.Collections.Generic.IList<string> AllowedFormats { get; set; }

        /// <summary>For video size type, the list of companion sizes.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("companionSizes")]
        public virtual System.Collections.Generic.IList<TargetingValueSize> CompanionSizes { get; set; }

        /// <summary>The Creative size type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("creativeSizeType")]
        public virtual string CreativeSizeType { get; set; }

        /// <summary>The native template for native ad.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nativeTemplate")]
        public virtual string NativeTemplate { get; set; }

        /// <summary>For regular or video creative size type, specifies the size of the creative.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("size")]
        public virtual TargetingValueSize Size { get; set; }

        /// <summary>The skippable ad type for video size.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("skippableAdType")]
        public virtual string SkippableAdType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class TargetingValueDayPartTargeting : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("dayParts")]
        public virtual System.Collections.Generic.IList<TargetingValueDayPartTargetingDayPart> DayParts { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("timeZoneType")]
        public virtual string TimeZoneType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class TargetingValueDayPartTargetingDayPart : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("dayOfWeek")]
        public virtual string DayOfWeek { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("endHour")]
        public virtual System.Nullable<int> EndHour { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("endMinute")]
        public virtual System.Nullable<int> EndMinute { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("startHour")]
        public virtual System.Nullable<int> StartHour { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("startMinute")]
        public virtual System.Nullable<int> StartMinute { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class TargetingValueDemogAgeCriteria : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("demogAgeCriteriaIds")]
        public virtual System.Collections.Generic.IList<string> DemogAgeCriteriaIds { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class TargetingValueDemogGenderCriteria : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("demogGenderCriteriaIds")]
        public virtual System.Collections.Generic.IList<string> DemogGenderCriteriaIds { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class TargetingValueRequestPlatformTargeting : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("requestPlatforms")]
        public virtual System.Collections.Generic.IList<string> RequestPlatforms { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class TargetingValueSize : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The height of the creative.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("height")]
        public virtual System.Nullable<int> Height { get; set; }

        /// <summary>The width of the creative.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("width")]
        public virtual System.Nullable<int> Width { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class UpdatePrivateAuctionProposalRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The externalDealId of the deal to be updated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("externalDealId")]
        public virtual string ExternalDealId { get; set; }

        /// <summary>Optional note to be added.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("note")]
        public virtual MarketplaceNote Note { get; set; }

        /// <summary>The current revision number of the proposal to be updated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("proposalRevisionNumber")]
        public virtual System.Nullable<long> ProposalRevisionNumber { get; set; }

        /// <summary>The proposed action on the private auction proposal.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateAction")]
        public virtual string UpdateAction { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
