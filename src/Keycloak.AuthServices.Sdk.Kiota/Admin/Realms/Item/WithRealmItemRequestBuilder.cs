// <auto-generated/>
using Keycloak.AuthServices.Sdk.Kiota.Admin.Admin.Realms.Item.AdminEvents;
using Keycloak.AuthServices.Sdk.Kiota.Admin.Admin.Realms.Item.AttackDetection;
using Keycloak.AuthServices.Sdk.Kiota.Admin.Admin.Realms.Item.Authentication;
using Keycloak.AuthServices.Sdk.Kiota.Admin.Admin.Realms.Item.ClientDescriptionConverter;
using Keycloak.AuthServices.Sdk.Kiota.Admin.Admin.Realms.Item.ClientPolicies;
using Keycloak.AuthServices.Sdk.Kiota.Admin.Admin.Realms.Item.ClientRegistrationPolicy;
using Keycloak.AuthServices.Sdk.Kiota.Admin.Admin.Realms.Item.ClientScopes;
using Keycloak.AuthServices.Sdk.Kiota.Admin.Admin.Realms.Item.ClientSessionStats;
using Keycloak.AuthServices.Sdk.Kiota.Admin.Admin.Realms.Item.ClientTemplates;
using Keycloak.AuthServices.Sdk.Kiota.Admin.Admin.Realms.Item.Clients;
using Keycloak.AuthServices.Sdk.Kiota.Admin.Admin.Realms.Item.ClientsInitialAccess;
using Keycloak.AuthServices.Sdk.Kiota.Admin.Admin.Realms.Item.Components;
using Keycloak.AuthServices.Sdk.Kiota.Admin.Admin.Realms.Item.CredentialRegistrators;
using Keycloak.AuthServices.Sdk.Kiota.Admin.Admin.Realms.Item.DefaultDefaultClientScopes;
using Keycloak.AuthServices.Sdk.Kiota.Admin.Admin.Realms.Item.DefaultGroups;
using Keycloak.AuthServices.Sdk.Kiota.Admin.Admin.Realms.Item.DefaultOptionalClientScopes;
using Keycloak.AuthServices.Sdk.Kiota.Admin.Admin.Realms.Item.Events;
using Keycloak.AuthServices.Sdk.Kiota.Admin.Admin.Realms.Item.GroupByPath;
using Keycloak.AuthServices.Sdk.Kiota.Admin.Admin.Realms.Item.Groups;
using Keycloak.AuthServices.Sdk.Kiota.Admin.Admin.Realms.Item.IdentityProvider;
using Keycloak.AuthServices.Sdk.Kiota.Admin.Admin.Realms.Item.Keys;
using Keycloak.AuthServices.Sdk.Kiota.Admin.Admin.Realms.Item.Localization;
using Keycloak.AuthServices.Sdk.Kiota.Admin.Admin.Realms.Item.LogoutAll;
using Keycloak.AuthServices.Sdk.Kiota.Admin.Admin.Realms.Item.PartialExport;
using Keycloak.AuthServices.Sdk.Kiota.Admin.Admin.Realms.Item.PartialImport;
using Keycloak.AuthServices.Sdk.Kiota.Admin.Admin.Realms.Item.PushRevocation;
using Keycloak.AuthServices.Sdk.Kiota.Admin.Admin.Realms.Item.Roles;
using Keycloak.AuthServices.Sdk.Kiota.Admin.Admin.Realms.Item.RolesById;
using Keycloak.AuthServices.Sdk.Kiota.Admin.Admin.Realms.Item.Sessions;
using Keycloak.AuthServices.Sdk.Kiota.Admin.Admin.Realms.Item.TestSMTPConnection;
using Keycloak.AuthServices.Sdk.Kiota.Admin.Admin.Realms.Item.Users;
using Keycloak.AuthServices.Sdk.Kiota.Admin.Admin.Realms.Item.UsersManagementPermissions;
using Keycloak.AuthServices.Sdk.Kiota.Admin.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Keycloak.AuthServices.Sdk.Kiota.Admin.Admin.Realms.Item {
    /// <summary>
    /// Builds and executes requests for operations under \admin\realms\{realm}
    /// </summary>
    public class WithRealmItemRequestBuilder : BaseRequestBuilder 
    {
        /// <summary>The adminEvents property</summary>
        public AdminEventsRequestBuilder AdminEvents
        {
            get => new AdminEventsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The attackDetection property</summary>
        public AttackDetectionRequestBuilder AttackDetection
        {
            get => new AttackDetectionRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The authentication property</summary>
        public AuthenticationRequestBuilder Authentication
        {
            get => new AuthenticationRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The clientDescriptionConverter property</summary>
        public ClientDescriptionConverterRequestBuilder ClientDescriptionConverter
        {
            get => new ClientDescriptionConverterRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The clientPolicies property</summary>
        public ClientPoliciesRequestBuilder ClientPolicies
        {
            get => new ClientPoliciesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The clientRegistrationPolicy property</summary>
        public ClientRegistrationPolicyRequestBuilder ClientRegistrationPolicy
        {
            get => new ClientRegistrationPolicyRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The clients property</summary>
        public ClientsRequestBuilder Clients
        {
            get => new ClientsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The clientScopes property</summary>
        public ClientScopesRequestBuilder ClientScopes
        {
            get => new ClientScopesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The clientSessionStats property</summary>
        public ClientSessionStatsRequestBuilder ClientSessionStats
        {
            get => new ClientSessionStatsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The clientsInitialAccess property</summary>
        public ClientsInitialAccessRequestBuilder ClientsInitialAccess
        {
            get => new ClientsInitialAccessRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The clientTemplates property</summary>
        public ClientTemplatesRequestBuilder ClientTemplates
        {
            get => new ClientTemplatesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The components property</summary>
        public ComponentsRequestBuilder Components
        {
            get => new ComponentsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The credentialRegistrators property</summary>
        public CredentialRegistratorsRequestBuilder CredentialRegistrators
        {
            get => new CredentialRegistratorsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The defaultDefaultClientScopes property</summary>
        public DefaultDefaultClientScopesRequestBuilder DefaultDefaultClientScopes
        {
            get => new DefaultDefaultClientScopesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The defaultGroups property</summary>
        public DefaultGroupsRequestBuilder DefaultGroups
        {
            get => new DefaultGroupsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The defaultOptionalClientScopes property</summary>
        public DefaultOptionalClientScopesRequestBuilder DefaultOptionalClientScopes
        {
            get => new DefaultOptionalClientScopesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The events property</summary>
        public EventsRequestBuilder Events
        {
            get => new EventsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The groupByPath property</summary>
        public GroupByPathRequestBuilder GroupByPath
        {
            get => new GroupByPathRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The groups property</summary>
        public GroupsRequestBuilder Groups
        {
            get => new GroupsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The identityProvider property</summary>
        public IdentityProviderRequestBuilder IdentityProvider
        {
            get => new IdentityProviderRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The keys property</summary>
        public KeysRequestBuilder Keys
        {
            get => new KeysRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The localization property</summary>
        public LocalizationRequestBuilder Localization
        {
            get => new LocalizationRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The logoutAll property</summary>
        public LogoutAllRequestBuilder LogoutAll
        {
            get => new LogoutAllRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The partialExport property</summary>
        public PartialExportRequestBuilder PartialExport
        {
            get => new PartialExportRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The partialImport property</summary>
        public PartialImportRequestBuilder PartialImport
        {
            get => new PartialImportRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The pushRevocation property</summary>
        public PushRevocationRequestBuilder PushRevocation
        {
            get => new PushRevocationRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The roles property</summary>
        public RolesRequestBuilder Roles
        {
            get => new RolesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The rolesById property</summary>
        public RolesByIdRequestBuilder RolesById
        {
            get => new RolesByIdRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The sessions property</summary>
        public SessionsRequestBuilder Sessions
        {
            get => new SessionsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The testSMTPConnection property</summary>
        public TestSMTPConnectionRequestBuilder TestSMTPConnection
        {
            get => new TestSMTPConnectionRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The users property</summary>
        public UsersRequestBuilder Users
        {
            get => new UsersRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The usersManagementPermissions property</summary>
        public UsersManagementPermissionsRequestBuilder UsersManagementPermissions
        {
            get => new UsersManagementPermissionsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="WithRealmItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithRealmItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/admin/realms/{realm}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="WithRealmItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithRealmItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/admin/realms/{realm}", rawUrl)
        {
        }
        /// <summary>
        /// Delete the realm
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task DeleteAsync(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task DeleteAsync(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToDeleteRequestInformation(requestConfiguration);
            await RequestAdapter.SendNoContentAsync(requestInfo, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Get the top-level representation of the realm It will not include nested information like User and Client representations.
        /// </summary>
        /// <returns>A <see cref="RealmRepresentation"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<RealmRepresentation?> GetAsync(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<RealmRepresentation> GetAsync(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            return await RequestAdapter.SendAsync<RealmRepresentation>(requestInfo, RealmRepresentation.CreateFromDiscriminatorValue, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// This will only update top-level attributes of the realm.
        /// </summary>
        /// <returns>A <see cref="Stream"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<Stream?> PutAsync(RealmRepresentation body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<Stream> PutAsync(RealmRepresentation body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPutRequestInformation(body, requestConfiguration);
            return await RequestAdapter.SendPrimitiveAsync<Stream>(requestInfo, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Delete the realm
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToDeleteRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToDeleteRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.DELETE, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            return requestInfo;
        }
        /// <summary>
        /// Get the top-level representation of the realm It will not include nested information like User and Client representations.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// This will only update top-level attributes of the realm.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPutRequestInformation(RealmRepresentation body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPutRequestInformation(RealmRepresentation body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation(Method.PUT, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="WithRealmItemRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public WithRealmItemRequestBuilder WithUrl(string rawUrl)
        {
            return new WithRealmItemRequestBuilder(rawUrl, RequestAdapter);
        }
    }
}
