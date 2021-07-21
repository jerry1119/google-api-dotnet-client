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

namespace Google.Apis.Datastore.v1beta3
{
    /// <summary>The Datastore Service.</summary>
    public class DatastoreService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1beta3";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public DatastoreService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public DatastoreService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            Projects = new ProjectsResource(this);
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "datastore";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri =>
        #if NETSTANDARD1_3 || NETSTANDARD2_0 || NET45
            BaseUriOverride ?? "https://datastore.googleapis.com/";
        #else
            "https://datastore.googleapis.com/";
        #endif

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        #if !NET40
        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri => "https://datastore.googleapis.com/batch";

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";
        #endif

        /// <summary>Available OAuth 2.0 scopes for use with the Cloud Datastore API.</summary>
        public class Scope
        {
            /// <summary>See, edit, configure, and delete your Google Cloud Platform data</summary>
            public static string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";

            /// <summary>View and manage your Google Cloud Datastore data</summary>
            public static string Datastore = "https://www.googleapis.com/auth/datastore";
        }

        /// <summary>Available OAuth 2.0 scope constants for use with the Cloud Datastore API.</summary>
        public static class ScopeConstants
        {
            /// <summary>See, edit, configure, and delete your Google Cloud Platform data</summary>
            public const string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";

            /// <summary>View and manage your Google Cloud Datastore data</summary>
            public const string Datastore = "https://www.googleapis.com/auth/datastore";
        }

        /// <summary>Gets the Projects resource.</summary>
        public virtual ProjectsResource Projects { get; }
    }

    /// <summary>A base abstract class for Datastore requests.</summary>
    public abstract class DatastoreBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new DatastoreBaseServiceRequest instance.</summary>
        protected DatastoreBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
        {
        }

        /// <summary>V1 error format.</summary>
        [Google.Apis.Util.RequestParameterAttribute("$.xgafv", Google.Apis.Util.RequestParameterType.Query)]
        public virtual System.Nullable<XgafvEnum> Xgafv { get; set; }

        /// <summary>V1 error format.</summary>
        public enum XgafvEnum
        {
            /// <summary>v1 error format</summary>
            [Google.Apis.Util.StringValueAttribute("1")]
            Value1 = 0,

            /// <summary>v2 error format</summary>
            [Google.Apis.Util.StringValueAttribute("2")]
            Value2 = 1,
        }

        /// <summary>OAuth access token.</summary>
        [Google.Apis.Util.RequestParameterAttribute("access_token", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string AccessToken { get; set; }

        /// <summary>Data format for response.</summary>
        [Google.Apis.Util.RequestParameterAttribute("alt", Google.Apis.Util.RequestParameterType.Query)]
        public virtual System.Nullable<AltEnum> Alt { get; set; }

        /// <summary>Data format for response.</summary>
        public enum AltEnum
        {
            /// <summary>Responses with Content-Type of application/json</summary>
            [Google.Apis.Util.StringValueAttribute("json")]
            Json = 0,

            /// <summary>Media download with context-dependent Content-Type</summary>
            [Google.Apis.Util.StringValueAttribute("media")]
            Media = 1,

            /// <summary>Responses with Content-Type of application/x-protobuf</summary>
            [Google.Apis.Util.StringValueAttribute("proto")]
            Proto = 2,
        }

        /// <summary>JSONP</summary>
        [Google.Apis.Util.RequestParameterAttribute("callback", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string Callback { get; set; }

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
        /// Available to use for quota purposes for server-side applications. Can be any arbitrary string assigned to a
        /// user, but should not exceed 40 characters.
        /// </summary>
        [Google.Apis.Util.RequestParameterAttribute("quotaUser", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string QuotaUser { get; set; }

        /// <summary>Legacy upload protocol for media (e.g. "media", "multipart").</summary>
        [Google.Apis.Util.RequestParameterAttribute("uploadType", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string UploadType { get; set; }

        /// <summary>Upload protocol for media (e.g. "raw", "multipart").</summary>
        [Google.Apis.Util.RequestParameterAttribute("upload_protocol", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string UploadProtocol { get; set; }

        /// <summary>Initializes Datastore parameter list.</summary>
        protected override void InitParameters()
        {
            base.InitParameters();
            RequestParameters.Add("$.xgafv", new Google.Apis.Discovery.Parameter
            {
                Name = "$.xgafv",
                IsRequired = false,
                ParameterType = "query",
                DefaultValue = null,
                Pattern = null,
            });
            RequestParameters.Add("access_token", new Google.Apis.Discovery.Parameter
            {
                Name = "access_token",
                IsRequired = false,
                ParameterType = "query",
                DefaultValue = null,
                Pattern = null,
            });
            RequestParameters.Add("alt", new Google.Apis.Discovery.Parameter
            {
                Name = "alt",
                IsRequired = false,
                ParameterType = "query",
                DefaultValue = "json",
                Pattern = null,
            });
            RequestParameters.Add("callback", new Google.Apis.Discovery.Parameter
            {
                Name = "callback",
                IsRequired = false,
                ParameterType = "query",
                DefaultValue = null,
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
            RequestParameters.Add("uploadType", new Google.Apis.Discovery.Parameter
            {
                Name = "uploadType",
                IsRequired = false,
                ParameterType = "query",
                DefaultValue = null,
                Pattern = null,
            });
            RequestParameters.Add("upload_protocol", new Google.Apis.Discovery.Parameter
            {
                Name = "upload_protocol",
                IsRequired = false,
                ParameterType = "query",
                DefaultValue = null,
                Pattern = null,
            });
        }
    }

    /// <summary>The "projects" collection of methods.</summary>
    public class ProjectsResource
    {
        private const string Resource = "projects";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public ProjectsResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>
        /// Allocates IDs for the given keys, which is useful for referencing an entity before it is inserted.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="projectId">Required. The ID of the project against which to make the request.</param>
        public virtual AllocateIdsRequest AllocateIds(Google.Apis.Datastore.v1beta3.Data.AllocateIdsRequest body, string projectId)
        {
            return new AllocateIdsRequest(service, body, projectId);
        }

        /// <summary>
        /// Allocates IDs for the given keys, which is useful for referencing an entity before it is inserted.
        /// </summary>
        public class AllocateIdsRequest : DatastoreBaseServiceRequest<Google.Apis.Datastore.v1beta3.Data.AllocateIdsResponse>
        {
            /// <summary>Constructs a new AllocateIds request.</summary>
            public AllocateIdsRequest(Google.Apis.Services.IClientService service, Google.Apis.Datastore.v1beta3.Data.AllocateIdsRequest body, string projectId) : base(service)
            {
                ProjectId = projectId;
                Body = body;
                InitParameters();
            }

            /// <summary>Required. The ID of the project against which to make the request.</summary>
            [Google.Apis.Util.RequestParameterAttribute("projectId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ProjectId { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Datastore.v1beta3.Data.AllocateIdsRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "allocateIds";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1beta3/projects/{projectId}:allocateIds";

            /// <summary>Initializes AllocateIds parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("projectId", new Google.Apis.Discovery.Parameter
                {
                    Name = "projectId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Begins a new transaction.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="projectId">Required. The ID of the project against which to make the request.</param>
        public virtual BeginTransactionRequest BeginTransaction(Google.Apis.Datastore.v1beta3.Data.BeginTransactionRequest body, string projectId)
        {
            return new BeginTransactionRequest(service, body, projectId);
        }

        /// <summary>Begins a new transaction.</summary>
        public class BeginTransactionRequest : DatastoreBaseServiceRequest<Google.Apis.Datastore.v1beta3.Data.BeginTransactionResponse>
        {
            /// <summary>Constructs a new BeginTransaction request.</summary>
            public BeginTransactionRequest(Google.Apis.Services.IClientService service, Google.Apis.Datastore.v1beta3.Data.BeginTransactionRequest body, string projectId) : base(service)
            {
                ProjectId = projectId;
                Body = body;
                InitParameters();
            }

            /// <summary>Required. The ID of the project against which to make the request.</summary>
            [Google.Apis.Util.RequestParameterAttribute("projectId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ProjectId { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Datastore.v1beta3.Data.BeginTransactionRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "beginTransaction";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1beta3/projects/{projectId}:beginTransaction";

            /// <summary>Initializes BeginTransaction parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("projectId", new Google.Apis.Discovery.Parameter
                {
                    Name = "projectId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Commits a transaction, optionally creating, deleting or modifying some entities.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="projectId">Required. The ID of the project against which to make the request.</param>
        public virtual CommitRequest Commit(Google.Apis.Datastore.v1beta3.Data.CommitRequest body, string projectId)
        {
            return new CommitRequest(service, body, projectId);
        }

        /// <summary>Commits a transaction, optionally creating, deleting or modifying some entities.</summary>
        public class CommitRequest : DatastoreBaseServiceRequest<Google.Apis.Datastore.v1beta3.Data.CommitResponse>
        {
            /// <summary>Constructs a new Commit request.</summary>
            public CommitRequest(Google.Apis.Services.IClientService service, Google.Apis.Datastore.v1beta3.Data.CommitRequest body, string projectId) : base(service)
            {
                ProjectId = projectId;
                Body = body;
                InitParameters();
            }

            /// <summary>Required. The ID of the project against which to make the request.</summary>
            [Google.Apis.Util.RequestParameterAttribute("projectId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ProjectId { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Datastore.v1beta3.Data.CommitRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "commit";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1beta3/projects/{projectId}:commit";

            /// <summary>Initializes Commit parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("projectId", new Google.Apis.Discovery.Parameter
                {
                    Name = "projectId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Looks up entities by key.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="projectId">Required. The ID of the project against which to make the request.</param>
        public virtual LookupRequest Lookup(Google.Apis.Datastore.v1beta3.Data.LookupRequest body, string projectId)
        {
            return new LookupRequest(service, body, projectId);
        }

        /// <summary>Looks up entities by key.</summary>
        public class LookupRequest : DatastoreBaseServiceRequest<Google.Apis.Datastore.v1beta3.Data.LookupResponse>
        {
            /// <summary>Constructs a new Lookup request.</summary>
            public LookupRequest(Google.Apis.Services.IClientService service, Google.Apis.Datastore.v1beta3.Data.LookupRequest body, string projectId) : base(service)
            {
                ProjectId = projectId;
                Body = body;
                InitParameters();
            }

            /// <summary>Required. The ID of the project against which to make the request.</summary>
            [Google.Apis.Util.RequestParameterAttribute("projectId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ProjectId { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Datastore.v1beta3.Data.LookupRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "lookup";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1beta3/projects/{projectId}:lookup";

            /// <summary>Initializes Lookup parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("projectId", new Google.Apis.Discovery.Parameter
                {
                    Name = "projectId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Prevents the supplied keys' IDs from being auto-allocated by Cloud Datastore.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="projectId">Required. The ID of the project against which to make the request.</param>
        public virtual ReserveIdsRequest ReserveIds(Google.Apis.Datastore.v1beta3.Data.ReserveIdsRequest body, string projectId)
        {
            return new ReserveIdsRequest(service, body, projectId);
        }

        /// <summary>Prevents the supplied keys' IDs from being auto-allocated by Cloud Datastore.</summary>
        public class ReserveIdsRequest : DatastoreBaseServiceRequest<Google.Apis.Datastore.v1beta3.Data.ReserveIdsResponse>
        {
            /// <summary>Constructs a new ReserveIds request.</summary>
            public ReserveIdsRequest(Google.Apis.Services.IClientService service, Google.Apis.Datastore.v1beta3.Data.ReserveIdsRequest body, string projectId) : base(service)
            {
                ProjectId = projectId;
                Body = body;
                InitParameters();
            }

            /// <summary>Required. The ID of the project against which to make the request.</summary>
            [Google.Apis.Util.RequestParameterAttribute("projectId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ProjectId { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Datastore.v1beta3.Data.ReserveIdsRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "reserveIds";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1beta3/projects/{projectId}:reserveIds";

            /// <summary>Initializes ReserveIds parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("projectId", new Google.Apis.Discovery.Parameter
                {
                    Name = "projectId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Rolls back a transaction.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="projectId">Required. The ID of the project against which to make the request.</param>
        public virtual RollbackRequest Rollback(Google.Apis.Datastore.v1beta3.Data.RollbackRequest body, string projectId)
        {
            return new RollbackRequest(service, body, projectId);
        }

        /// <summary>Rolls back a transaction.</summary>
        public class RollbackRequest : DatastoreBaseServiceRequest<Google.Apis.Datastore.v1beta3.Data.RollbackResponse>
        {
            /// <summary>Constructs a new Rollback request.</summary>
            public RollbackRequest(Google.Apis.Services.IClientService service, Google.Apis.Datastore.v1beta3.Data.RollbackRequest body, string projectId) : base(service)
            {
                ProjectId = projectId;
                Body = body;
                InitParameters();
            }

            /// <summary>Required. The ID of the project against which to make the request.</summary>
            [Google.Apis.Util.RequestParameterAttribute("projectId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ProjectId { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Datastore.v1beta3.Data.RollbackRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "rollback";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1beta3/projects/{projectId}:rollback";

            /// <summary>Initializes Rollback parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("projectId", new Google.Apis.Discovery.Parameter
                {
                    Name = "projectId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Queries for entities.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="projectId">Required. The ID of the project against which to make the request.</param>
        public virtual RunQueryRequest RunQuery(Google.Apis.Datastore.v1beta3.Data.RunQueryRequest body, string projectId)
        {
            return new RunQueryRequest(service, body, projectId);
        }

        /// <summary>Queries for entities.</summary>
        public class RunQueryRequest : DatastoreBaseServiceRequest<Google.Apis.Datastore.v1beta3.Data.RunQueryResponse>
        {
            /// <summary>Constructs a new RunQuery request.</summary>
            public RunQueryRequest(Google.Apis.Services.IClientService service, Google.Apis.Datastore.v1beta3.Data.RunQueryRequest body, string projectId) : base(service)
            {
                ProjectId = projectId;
                Body = body;
                InitParameters();
            }

            /// <summary>Required. The ID of the project against which to make the request.</summary>
            [Google.Apis.Util.RequestParameterAttribute("projectId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ProjectId { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Datastore.v1beta3.Data.RunQueryRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "runQuery";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1beta3/projects/{projectId}:runQuery";

            /// <summary>Initializes RunQuery parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("projectId", new Google.Apis.Discovery.Parameter
                {
                    Name = "projectId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }
    }
}
namespace Google.Apis.Datastore.v1beta3.Data
{
    /// <summary>The request for Datastore.AllocateIds.</summary>
    public class AllocateIdsRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. A list of keys with incomplete key paths for which to allocate IDs. No key may be
        /// reserved/read-only.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("keys")]
        public virtual System.Collections.Generic.IList<Key> Keys { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response for Datastore.AllocateIds.</summary>
    public class AllocateIdsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The keys specified in the request (in the same order), each with its key path completed with a newly
        /// allocated ID.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("keys")]
        public virtual System.Collections.Generic.IList<Key> Keys { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>An array value.</summary>
    public class ArrayValue : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Values in the array. The order of values in an array is preserved as long as all values have identical
        /// settings for 'exclude_from_indexes'.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("values")]
        public virtual System.Collections.Generic.IList<Value> Values { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The request for Datastore.BeginTransaction.</summary>
    public class BeginTransactionRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Options for a new transaction.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("transactionOptions")]
        public virtual TransactionOptions TransactionOptions { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response for Datastore.BeginTransaction.</summary>
    public class BeginTransactionResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The transaction identifier (always present).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("transaction")]
        public virtual string Transaction { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The request for Datastore.Commit.</summary>
    public class CommitRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The type of commit to perform. Defaults to `TRANSACTIONAL`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mode")]
        public virtual string Mode { get; set; }

        /// <summary>
        /// The mutations to perform. When mode is `TRANSACTIONAL`, mutations affecting a single entity are applied in
        /// order. The following sequences of mutations affecting a single entity are not permitted in a single `Commit`
        /// request: - `insert` followed by `insert` - `update` followed by `insert` - `upsert` followed by `insert` -
        /// `delete` followed by `update` When mode is `NON_TRANSACTIONAL`, no two mutations may affect a single entity.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mutations")]
        public virtual System.Collections.Generic.IList<Mutation> Mutations { get; set; }

        /// <summary>
        /// The identifier of the transaction associated with the commit. A transaction identifier is returned by a call
        /// to Datastore.BeginTransaction.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("transaction")]
        public virtual string Transaction { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response for Datastore.Commit.</summary>
    public class CommitResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The number of index entries updated during the commit, or zero if none were updated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("indexUpdates")]
        public virtual System.Nullable<int> IndexUpdates { get; set; }

        /// <summary>
        /// The result of performing the mutations. The i-th mutation result corresponds to the i-th mutation in the
        /// request.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mutationResults")]
        public virtual System.Collections.Generic.IList<MutationResult> MutationResults { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A filter that merges multiple other filters using the given operator.</summary>
    public class CompositeFilter : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The list of filters to combine. Must contain at least one filter.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("filters")]
        public virtual System.Collections.Generic.IList<Filter> Filters { get; set; }

        /// <summary>The operator for combining multiple filters.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("op")]
        public virtual string Op { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A Datastore data object. An entity is limited to 1 megabyte when stored. That _roughly_ corresponds to a limit
    /// of 1 megabyte for the serialized form of this message.
    /// </summary>
    public class Entity : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The entity's key. An entity must have a key, unless otherwise documented (for example, an entity in
        /// `Value.entity_value` may have no key). An entity's kind is its key path's last element's kind, or null if it
        /// has no key.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("key")]
        public virtual Key Key { get; set; }

        /// <summary>
        /// The entity's properties. The map's keys are property names. A property name matching regex `__.*__` is
        /// reserved. A reserved property name is forbidden in certain documented contexts. The name must not contain
        /// more than 500 characters. The name cannot be `""`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("properties")]
        public virtual System.Collections.Generic.IDictionary<string, Value> Properties { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The result of fetching an entity from Datastore.</summary>
    public class EntityResult : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A cursor that points to the position after the result entity. Set only when the `EntityResult` is part of a
        /// `QueryResultBatch` message.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cursor")]
        public virtual string Cursor { get; set; }

        /// <summary>The resulting entity.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("entity")]
        public virtual Entity Entity { get; set; }

        /// <summary>
        /// The version of the entity, a strictly positive number that monotonically increases with changes to the
        /// entity. This field is set for `FULL` entity results. For missing entities in `LookupResponse`, this is the
        /// version of the snapshot that was used to look up the entity, and it is always set except for eventually
        /// consistent reads.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("version")]
        public virtual System.Nullable<long> Version { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A holder for any type of filter.</summary>
    public class Filter : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A composite filter.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("compositeFilter")]
        public virtual CompositeFilter CompositeFilter { get; set; }

        /// <summary>A filter on a property.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("propertyFilter")]
        public virtual PropertyFilter PropertyFilter { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Metadata common to all Datastore Admin operations.</summary>
    public class GoogleDatastoreAdminV1CommonMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The time the operation ended, either successfully or otherwise.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endTime")]
        public virtual object EndTime { get; set; }

        /// <summary>
        /// The client-assigned labels which were provided when the operation was created. May also include additional
        /// labels.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>The type of the operation. Can be used as a filter in ListOperationsRequest.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("operationType")]
        public virtual string OperationType { get; set; }

        /// <summary>The time that work began on the operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startTime")]
        public virtual object StartTime { get; set; }

        /// <summary>The current state of the Operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Identifies a subset of entities in a project. This is specified as combinations of kinds and namespaces (either
    /// or both of which may be all, as described in the following examples). Example usage: Entire project: kinds=[],
    /// namespace_ids=[] Kinds Foo and Bar in all namespaces: kinds=['Foo', 'Bar'], namespace_ids=[] Kinds Foo and Bar
    /// only in the default namespace: kinds=['Foo', 'Bar'], namespace_ids=[''] Kinds Foo and Bar in both the default
    /// and Baz namespaces: kinds=['Foo', 'Bar'], namespace_ids=['', 'Baz'] The entire Baz namespace: kinds=[],
    /// namespace_ids=['Baz']
    /// </summary>
    public class GoogleDatastoreAdminV1EntityFilter : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>If empty, then this represents all kinds.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kinds")]
        public virtual System.Collections.Generic.IList<string> Kinds { get; set; }

        /// <summary>
        /// An empty list represents all namespaces. This is the preferred usage for projects that don't use namespaces.
        /// An empty string element represents the default namespace. This should be used if the project has data in
        /// non-default namespaces, but doesn't want to include them. Each namespace in this list must be unique.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("namespaceIds")]
        public virtual System.Collections.Generic.IList<string> NamespaceIds { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Metadata for ExportEntities operations.</summary>
    public class GoogleDatastoreAdminV1ExportEntitiesMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Metadata common to all Datastore Admin operations.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("common")]
        public virtual GoogleDatastoreAdminV1CommonMetadata Common { get; set; }

        /// <summary>Description of which entities are being exported.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("entityFilter")]
        public virtual GoogleDatastoreAdminV1EntityFilter EntityFilter { get; set; }

        /// <summary>
        /// Location for the export metadata and data files. This will be the same value as the
        /// google.datastore.admin.v1.ExportEntitiesRequest.output_url_prefix field. The final output location is
        /// provided in google.datastore.admin.v1.ExportEntitiesResponse.output_url.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("outputUrlPrefix")]
        public virtual string OutputUrlPrefix { get; set; }

        /// <summary>An estimate of the number of bytes processed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("progressBytes")]
        public virtual GoogleDatastoreAdminV1Progress ProgressBytes { get; set; }

        /// <summary>An estimate of the number of entities processed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("progressEntities")]
        public virtual GoogleDatastoreAdminV1Progress ProgressEntities { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response for google.datastore.admin.v1.DatastoreAdmin.ExportEntities.</summary>
    public class GoogleDatastoreAdminV1ExportEntitiesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Location of the output metadata file. This can be used to begin an import into Cloud Datastore (this project
        /// or another project). See google.datastore.admin.v1.ImportEntitiesRequest.input_url. Only present if the
        /// operation completed successfully.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("outputUrl")]
        public virtual string OutputUrl { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Metadata for ImportEntities operations.</summary>
    public class GoogleDatastoreAdminV1ImportEntitiesMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Metadata common to all Datastore Admin operations.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("common")]
        public virtual GoogleDatastoreAdminV1CommonMetadata Common { get; set; }

        /// <summary>Description of which entities are being imported.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("entityFilter")]
        public virtual GoogleDatastoreAdminV1EntityFilter EntityFilter { get; set; }

        /// <summary>
        /// The location of the import metadata file. This will be the same value as the
        /// google.datastore.admin.v1.ExportEntitiesResponse.output_url field.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inputUrl")]
        public virtual string InputUrl { get; set; }

        /// <summary>An estimate of the number of bytes processed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("progressBytes")]
        public virtual GoogleDatastoreAdminV1Progress ProgressBytes { get; set; }

        /// <summary>An estimate of the number of entities processed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("progressEntities")]
        public virtual GoogleDatastoreAdminV1Progress ProgressEntities { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Metadata for Index operations.</summary>
    public class GoogleDatastoreAdminV1IndexOperationMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Metadata common to all Datastore Admin operations.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("common")]
        public virtual GoogleDatastoreAdminV1CommonMetadata Common { get; set; }

        /// <summary>The index resource ID that this operation is acting on.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("indexId")]
        public virtual string IndexId { get; set; }

        /// <summary>An estimate of the number of entities processed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("progressEntities")]
        public virtual GoogleDatastoreAdminV1Progress ProgressEntities { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Measures the progress of a particular metric.</summary>
    public class GoogleDatastoreAdminV1Progress : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The amount of work that has been completed. Note that this may be greater than work_estimated.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("workCompleted")]
        public virtual System.Nullable<long> WorkCompleted { get; set; }

        /// <summary>
        /// An estimate of how much work needs to be performed. May be zero if the work estimate is unavailable.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("workEstimated")]
        public virtual System.Nullable<long> WorkEstimated { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Metadata common to all Datastore Admin operations.</summary>
    public class GoogleDatastoreAdminV1beta1CommonMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The time the operation ended, either successfully or otherwise.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endTime")]
        public virtual object EndTime { get; set; }

        /// <summary>
        /// The client-assigned labels which were provided when the operation was created. May also include additional
        /// labels.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>The type of the operation. Can be used as a filter in ListOperationsRequest.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("operationType")]
        public virtual string OperationType { get; set; }

        /// <summary>The time that work began on the operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startTime")]
        public virtual object StartTime { get; set; }

        /// <summary>The current state of the Operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Identifies a subset of entities in a project. This is specified as combinations of kinds and namespaces (either
    /// or both of which may be all, as described in the following examples). Example usage: Entire project: kinds=[],
    /// namespace_ids=[] Kinds Foo and Bar in all namespaces: kinds=['Foo', 'Bar'], namespace_ids=[] Kinds Foo and Bar
    /// only in the default namespace: kinds=['Foo', 'Bar'], namespace_ids=[''] Kinds Foo and Bar in both the default
    /// and Baz namespaces: kinds=['Foo', 'Bar'], namespace_ids=['', 'Baz'] The entire Baz namespace: kinds=[],
    /// namespace_ids=['Baz']
    /// </summary>
    public class GoogleDatastoreAdminV1beta1EntityFilter : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>If empty, then this represents all kinds.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kinds")]
        public virtual System.Collections.Generic.IList<string> Kinds { get; set; }

        /// <summary>
        /// An empty list represents all namespaces. This is the preferred usage for projects that don't use namespaces.
        /// An empty string element represents the default namespace. This should be used if the project has data in
        /// non-default namespaces, but doesn't want to include them. Each namespace in this list must be unique.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("namespaceIds")]
        public virtual System.Collections.Generic.IList<string> NamespaceIds { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Metadata for ExportEntities operations.</summary>
    public class GoogleDatastoreAdminV1beta1ExportEntitiesMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Metadata common to all Datastore Admin operations.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("common")]
        public virtual GoogleDatastoreAdminV1beta1CommonMetadata Common { get; set; }

        /// <summary>Description of which entities are being exported.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("entityFilter")]
        public virtual GoogleDatastoreAdminV1beta1EntityFilter EntityFilter { get; set; }

        /// <summary>
        /// Location for the export metadata and data files. This will be the same value as the
        /// google.datastore.admin.v1beta1.ExportEntitiesRequest.output_url_prefix field. The final output location is
        /// provided in google.datastore.admin.v1beta1.ExportEntitiesResponse.output_url.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("outputUrlPrefix")]
        public virtual string OutputUrlPrefix { get; set; }

        /// <summary>An estimate of the number of bytes processed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("progressBytes")]
        public virtual GoogleDatastoreAdminV1beta1Progress ProgressBytes { get; set; }

        /// <summary>An estimate of the number of entities processed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("progressEntities")]
        public virtual GoogleDatastoreAdminV1beta1Progress ProgressEntities { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response for google.datastore.admin.v1beta1.DatastoreAdmin.ExportEntities.</summary>
    public class GoogleDatastoreAdminV1beta1ExportEntitiesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Location of the output metadata file. This can be used to begin an import into Cloud Datastore (this project
        /// or another project). See google.datastore.admin.v1beta1.ImportEntitiesRequest.input_url. Only present if the
        /// operation completed successfully.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("outputUrl")]
        public virtual string OutputUrl { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Metadata for ImportEntities operations.</summary>
    public class GoogleDatastoreAdminV1beta1ImportEntitiesMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Metadata common to all Datastore Admin operations.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("common")]
        public virtual GoogleDatastoreAdminV1beta1CommonMetadata Common { get; set; }

        /// <summary>Description of which entities are being imported.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("entityFilter")]
        public virtual GoogleDatastoreAdminV1beta1EntityFilter EntityFilter { get; set; }

        /// <summary>
        /// The location of the import metadata file. This will be the same value as the
        /// google.datastore.admin.v1beta1.ExportEntitiesResponse.output_url field.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inputUrl")]
        public virtual string InputUrl { get; set; }

        /// <summary>An estimate of the number of bytes processed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("progressBytes")]
        public virtual GoogleDatastoreAdminV1beta1Progress ProgressBytes { get; set; }

        /// <summary>An estimate of the number of entities processed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("progressEntities")]
        public virtual GoogleDatastoreAdminV1beta1Progress ProgressEntities { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Measures the progress of a particular metric.</summary>
    public class GoogleDatastoreAdminV1beta1Progress : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The amount of work that has been completed. Note that this may be greater than work_estimated.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("workCompleted")]
        public virtual System.Nullable<long> WorkCompleted { get; set; }

        /// <summary>
        /// An estimate of how much work needs to be performed. May be zero if the work estimate is unavailable.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("workEstimated")]
        public virtual System.Nullable<long> WorkEstimated { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A [GQL query](https://cloud.google.com/datastore/docs/apis/gql/gql_reference).</summary>
    public class GqlQuery : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// When false, the query string must not contain any literals and instead must bind all values. For example,
        /// `SELECT * FROM Kind WHERE a = 'string literal'` is not allowed, while `SELECT * FROM Kind WHERE a = @value`
        /// is.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allowLiterals")]
        public virtual System.Nullable<bool> AllowLiterals { get; set; }

        /// <summary>
        /// For each non-reserved named binding site in the query string, there must be a named parameter with that
        /// name, but not necessarily the inverse. Key must match regex `A-Za-z_$*`, must not match regex `__.*__`, and
        /// must not be `""`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("namedBindings")]
        public virtual System.Collections.Generic.IDictionary<string, GqlQueryParameter> NamedBindings { get; set; }

        /// <summary>
        /// Numbered binding site @1 references the first numbered parameter, effectively using 1-based indexing, rather
        /// than the usual 0. For each binding site numbered i in `query_string`, there must be an i-th numbered
        /// parameter. The inverse must also be true.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("positionalBindings")]
        public virtual System.Collections.Generic.IList<GqlQueryParameter> PositionalBindings { get; set; }

        /// <summary>
        /// A string of the format described [here](https://cloud.google.com/datastore/docs/apis/gql/gql_reference).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("queryString")]
        public virtual string QueryString { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A binding parameter for a GQL query.</summary>
    public class GqlQueryParameter : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A query cursor. Query cursors are returned in query result batches.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cursor")]
        public virtual string Cursor { get; set; }

        /// <summary>A value parameter.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual Value Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A unique identifier for an entity. If a key's partition ID or any of its path kinds or names are
    /// reserved/read-only, the key is reserved/read-only. A reserved/read-only key is forbidden in certain documented
    /// contexts.
    /// </summary>
    public class Key : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Entities are partitioned into subsets, currently identified by a project ID and namespace ID. Queries are
        /// scoped to a single partition.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("partitionId")]
        public virtual PartitionId PartitionId { get; set; }

        /// <summary>
        /// The entity path. An entity path consists of one or more elements composed of a kind and a string or
        /// numerical identifier, which identify entities. The first element identifies a _root entity_, the second
        /// element identifies a _child_ of the root entity, the third element identifies a child of the second entity,
        /// and so forth. The entities identified by all prefixes of the path are called the element's _ancestors_. An
        /// entity path is always fully complete: *all* of the entity's ancestors are required to be in the path along
        /// with the entity identifier itself. The only exception is that in some documented cases, the identifier in
        /// the last path element (for the entity) itself may be omitted. For example, the last path element of the key
        /// of `Mutation.insert` may have no identifier. A path can never be empty, and a path can have at most 100
        /// elements.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("path")]
        public virtual System.Collections.Generic.IList<PathElement> Path { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A representation of a kind.</summary>
    public class KindExpression : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The name of the kind.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// An object that represents a latitude/longitude pair. This is expressed as a pair of doubles to represent degrees
    /// latitude and degrees longitude. Unless specified otherwise, this object must conform to the WGS84 standard.
    /// Values must be within normalized ranges.
    /// </summary>
    public class LatLng : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The latitude in degrees. It must be in the range [-90.0, +90.0].</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("latitude")]
        public virtual System.Nullable<double> Latitude { get; set; }

        /// <summary>The longitude in degrees. It must be in the range [-180.0, +180.0].</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("longitude")]
        public virtual System.Nullable<double> Longitude { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The request for Datastore.Lookup.</summary>
    public class LookupRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Keys of entities to look up.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("keys")]
        public virtual System.Collections.Generic.IList<Key> Keys { get; set; }

        /// <summary>The options for this lookup request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("readOptions")]
        public virtual ReadOptions ReadOptions { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response for Datastore.Lookup.</summary>
    public class LookupResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A list of keys that were not looked up due to resource constraints. The order of results in this field is
        /// undefined and has no relation to the order of the keys in the input.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deferred")]
        public virtual System.Collections.Generic.IList<Key> Deferred { get; set; }

        /// <summary>
        /// Entities found as `ResultType.FULL` entities. The order of results in this field is undefined and has no
        /// relation to the order of the keys in the input.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("found")]
        public virtual System.Collections.Generic.IList<EntityResult> Found { get; set; }

        /// <summary>
        /// Entities not found as `ResultType.KEY_ONLY` entities. The order of results in this field is undefined and
        /// has no relation to the order of the keys in the input.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("missing")]
        public virtual System.Collections.Generic.IList<EntityResult> Missing { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A mutation to apply to an entity.</summary>
    public class Mutation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The version of the entity that this mutation is being applied to. If this does not match the current version
        /// on the server, the mutation conflicts.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("baseVersion")]
        public virtual System.Nullable<long> BaseVersion { get; set; }

        /// <summary>
        /// The key of the entity to delete. The entity may or may not already exist. Must have a complete key path and
        /// must not be reserved/read-only.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("delete")]
        public virtual Key Delete { get; set; }

        /// <summary>
        /// The entity to insert. The entity must not already exist. The entity key's final path element may be
        /// incomplete.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("insert")]
        public virtual Entity Insert { get; set; }

        /// <summary>The entity to update. The entity must already exist. Must have a complete key path.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("update")]
        public virtual Entity Update { get; set; }

        /// <summary>
        /// The entity to upsert. The entity may or may not already exist. The entity key's final path element may be
        /// incomplete.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("upsert")]
        public virtual Entity Upsert { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The result of applying a mutation.</summary>
    public class MutationResult : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Whether a conflict was detected for this mutation. Always false when a conflict detection strategy field is
        /// not set in the mutation.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("conflictDetected")]
        public virtual System.Nullable<bool> ConflictDetected { get; set; }

        /// <summary>The automatically allocated key. Set only when the mutation allocated a key.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("key")]
        public virtual Key Key { get; set; }

        /// <summary>
        /// The version of the entity on the server after processing the mutation. If the mutation doesn't change
        /// anything on the server, then the version will be the version of the current entity or, if no entity is
        /// present, a version that is strictly greater than the version of any previous entity and less than the
        /// version of any possible future entity.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("version")]
        public virtual System.Nullable<long> Version { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A partition ID identifies a grouping of entities. The grouping is always by project and namespace, however the
    /// namespace ID may be empty. A partition ID contains several dimensions: project ID and namespace ID. Partition
    /// dimensions: - May be `""`. - Must be valid UTF-8 bytes. - Must have values that match regex
    /// `[A-Za-z\d\.\-_]{1,100}` If the value of any dimension matches regex `__.*__`, the partition is
    /// reserved/read-only. A reserved/read-only partition ID is forbidden in certain documented contexts. Foreign
    /// partition IDs (in which the project ID does not match the context project ID ) are discouraged. Reads and writes
    /// of foreign partition IDs may fail if the project is not in an active state.
    /// </summary>
    public class PartitionId : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>If not empty, the ID of the namespace to which the entities belong.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("namespaceId")]
        public virtual string NamespaceId { get; set; }

        /// <summary>The ID of the project to which the entities belong.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("projectId")]
        public virtual string ProjectId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A (kind, ID/name) pair used to construct a key path. If either name or ID is set, the element is complete. If
    /// neither is set, the element is incomplete.
    /// </summary>
    public class PathElement : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The auto-allocated ID of the entity. Never equal to zero. Values less than zero are discouraged and may not
        /// be supported in the future.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual System.Nullable<long> Id { get; set; }

        /// <summary>
        /// The kind of the entity. A kind matching regex `__.*__` is reserved/read-only. A kind must not contain more
        /// than 1500 bytes when UTF-8 encoded. Cannot be `""`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>
        /// The name of the entity. A name matching regex `__.*__` is reserved/read-only. A name must not be more than
        /// 1500 bytes when UTF-8 encoded. Cannot be `""`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A representation of a property in a projection.</summary>
    public class Projection : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The property to project.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("property")]
        public virtual PropertyReference Property { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A filter on a specific property.</summary>
    public class PropertyFilter : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The operator to filter by.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("op")]
        public virtual string Op { get; set; }

        /// <summary>The property to filter by.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("property")]
        public virtual PropertyReference Property { get; set; }

        /// <summary>The value to compare the property to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual Value Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The desired order for a specific property.</summary>
    public class PropertyOrder : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The direction to order by. Defaults to `ASCENDING`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("direction")]
        public virtual string Direction { get; set; }

        /// <summary>The property to order by.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("property")]
        public virtual PropertyReference Property { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A reference to a property relative to the kind expressions.</summary>
    public class PropertyReference : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The name of the property. If name includes "."s, it may be interpreted as a property name path.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A query for entities.</summary>
    public class Query : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The properties to make distinct. The query results will contain the first result for each distinct
        /// combination of values for the given properties (if empty, all results are returned).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("distinctOn")]
        public virtual System.Collections.Generic.IList<PropertyReference> DistinctOn { get; set; }

        /// <summary>
        /// An ending point for the query results. Query cursors are returned in query result batches and [can only be
        /// used to limit the same
        /// query](https://cloud.google.com/datastore/docs/concepts/queries#cursors_limits_and_offsets).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endCursor")]
        public virtual string EndCursor { get; set; }

        /// <summary>The filter to apply.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("filter")]
        public virtual Filter Filter { get; set; }

        /// <summary>
        /// The kinds to query (if empty, returns entities of all kinds). Currently at most 1 kind may be specified.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual System.Collections.Generic.IList<KindExpression> Kind { get; set; }

        /// <summary>
        /// The maximum number of results to return. Applies after all other constraints. Optional. Unspecified is
        /// interpreted as no limit. Must be &amp;gt;= 0 if specified.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("limit")]
        public virtual System.Nullable<int> Limit { get; set; }

        /// <summary>
        /// The number of results to skip. Applies before limit, but after all other constraints. Optional. Must be
        /// &amp;gt;= 0 if specified.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("offset")]
        public virtual System.Nullable<int> Offset { get; set; }

        /// <summary>The order to apply to the query results (if empty, order is unspecified).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("order")]
        public virtual System.Collections.Generic.IList<PropertyOrder> Order { get; set; }

        /// <summary>The projection to return. Defaults to returning all properties.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("projection")]
        public virtual System.Collections.Generic.IList<Projection> Projection { get; set; }

        /// <summary>
        /// A starting point for the query results. Query cursors are returned in query result batches and [can only be
        /// used to continue the same
        /// query](https://cloud.google.com/datastore/docs/concepts/queries#cursors_limits_and_offsets).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startCursor")]
        public virtual string StartCursor { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A batch of results produced by a query.</summary>
    public class QueryResultBatch : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A cursor that points to the position after the last result in the batch.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endCursor")]
        public virtual string EndCursor { get; set; }

        /// <summary>The result type for every entity in `entity_results`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("entityResultType")]
        public virtual string EntityResultType { get; set; }

        /// <summary>The results for this batch.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("entityResults")]
        public virtual System.Collections.Generic.IList<EntityResult> EntityResults { get; set; }

        /// <summary>The state of the query after the current batch.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("moreResults")]
        public virtual string MoreResults { get; set; }

        /// <summary>
        /// A cursor that points to the position after the last skipped result. Will be set when `skipped_results` != 0.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("skippedCursor")]
        public virtual string SkippedCursor { get; set; }

        /// <summary>The number of results skipped, typically because of an offset.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("skippedResults")]
        public virtual System.Nullable<int> SkippedResults { get; set; }

        /// <summary>
        /// The version number of the snapshot this batch was returned from. This applies to the range of results from
        /// the query's `start_cursor` (or the beginning of the query if no cursor was given) to this batch's
        /// `end_cursor` (not the query's `end_cursor`). In a single transaction, subsequent query result batches for
        /// the same query can have a greater snapshot version number. Each batch's snapshot version is valid for all
        /// preceding batches. The value will be zero for eventually consistent queries.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("snapshotVersion")]
        public virtual System.Nullable<long> SnapshotVersion { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Options specific to read-only transactions.</summary>
    public class ReadOnly : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The options shared by read requests.</summary>
    public class ReadOptions : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The non-transactional read consistency to use. Cannot be set to `STRONG` for global queries.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("readConsistency")]
        public virtual string ReadConsistency { get; set; }

        /// <summary>
        /// The identifier of the transaction in which to read. A transaction identifier is returned by a call to
        /// Datastore.BeginTransaction.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("transaction")]
        public virtual string Transaction { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Options specific to read / write transactions.</summary>
    public class ReadWrite : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The transaction identifier of the transaction being retried.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("previousTransaction")]
        public virtual string PreviousTransaction { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The request for Datastore.ReserveIds.</summary>
    public class ReserveIdsRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>If not empty, the ID of the database against which to make the request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("databaseId")]
        public virtual string DatabaseId { get; set; }

        /// <summary>
        /// Required. A list of keys with complete key paths whose numeric IDs should not be auto-allocated.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("keys")]
        public virtual System.Collections.Generic.IList<Key> Keys { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response for Datastore.ReserveIds.</summary>
    public class ReserveIdsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The request for Datastore.Rollback.</summary>
    public class RollbackRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The transaction identifier, returned by a call to Datastore.BeginTransaction.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("transaction")]
        public virtual string Transaction { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response for Datastore.Rollback. (an empty message).</summary>
    public class RollbackResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The request for Datastore.RunQuery.</summary>
    public class RunQueryRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The GQL query to run.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gqlQuery")]
        public virtual GqlQuery GqlQuery { get; set; }

        /// <summary>
        /// Entities are partitioned into subsets, identified by a partition ID. Queries are scoped to a single
        /// partition. This partition ID is normalized with the standard default context partition ID.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("partitionId")]
        public virtual PartitionId PartitionId { get; set; }

        /// <summary>The query to run.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("query")]
        public virtual Query Query { get; set; }

        /// <summary>The options for this query.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("readOptions")]
        public virtual ReadOptions ReadOptions { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response for Datastore.RunQuery.</summary>
    public class RunQueryResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A batch of query results (always present).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("batch")]
        public virtual QueryResultBatch Batch { get; set; }

        /// <summary>The parsed form of the `GqlQuery` from the request, if it was set.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("query")]
        public virtual Query Query { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Options for beginning a new transaction. Transactions can be created explicitly with calls to
    /// Datastore.BeginTransaction or implicitly by setting ReadOptions.new_transaction in read requests.
    /// </summary>
    public class TransactionOptions : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The transaction should only allow reads.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("readOnly")]
        public virtual ReadOnly ReadOnly__ { get; set; }

        /// <summary>The transaction should allow both reads and writes.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("readWrite")]
        public virtual ReadWrite ReadWrite { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A message that can hold any of the supported value types and associated metadata.</summary>
    public class Value : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// An array value. Cannot contain another array value. A `Value` instance that sets field `array_value` must
        /// not set fields `meaning` or `exclude_from_indexes`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("arrayValue")]
        public virtual ArrayValue ArrayValue { get; set; }

        /// <summary>
        /// A blob value. May have at most 1,000,000 bytes. When `exclude_from_indexes` is false, may have at most 1500
        /// bytes. In JSON requests, must be base64-encoded.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("blobValue")]
        public virtual string BlobValue { get; set; }

        /// <summary>A boolean value.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("booleanValue")]
        public virtual System.Nullable<bool> BooleanValue { get; set; }

        /// <summary>A double value.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("doubleValue")]
        public virtual System.Nullable<double> DoubleValue { get; set; }

        /// <summary>
        /// An entity value. - May have no key. - May have a key with an incomplete key path. - May have a
        /// reserved/read-only key.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("entityValue")]
        public virtual Entity EntityValue { get; set; }

        /// <summary>If the value should be excluded from all indexes including those defined explicitly.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("excludeFromIndexes")]
        public virtual System.Nullable<bool> ExcludeFromIndexes { get; set; }

        /// <summary>A geo point value representing a point on the surface of Earth.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("geoPointValue")]
        public virtual LatLng GeoPointValue { get; set; }

        /// <summary>An integer value.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("integerValue")]
        public virtual System.Nullable<long> IntegerValue { get; set; }

        /// <summary>A key value.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("keyValue")]
        public virtual Key KeyValue { get; set; }

        /// <summary>The `meaning` field should only be populated for backwards compatibility.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("meaning")]
        public virtual System.Nullable<int> Meaning { get; set; }

        /// <summary>A null value.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nullValue")]
        public virtual string NullValue { get; set; }

        /// <summary>
        /// A UTF-8 encoded string value. When `exclude_from_indexes` is false (it is indexed) , may have at most 1500
        /// bytes. Otherwise, may be set to at most 1,000,000 bytes.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stringValue")]
        public virtual string StringValue { get; set; }

        /// <summary>
        /// A timestamp value. When stored in the Datastore, precise only to microseconds; any additional precision is
        /// rounded down.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timestampValue")]
        public virtual object TimestampValue { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
