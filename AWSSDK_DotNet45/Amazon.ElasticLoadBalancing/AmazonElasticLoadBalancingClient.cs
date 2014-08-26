/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */
using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;

using Amazon.ElasticLoadBalancing.Model;
using Amazon.ElasticLoadBalancing.Model.Internal.MarshallTransformations;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.ElasticLoadBalancing
{
    /// <summary>
    /// Implementation for accessing ElasticLoadBalancing
    /// 
    /// Elastic Load Balancing
    /// <para>
    /// Elastic Load Balancing is a way to automatically distribute incoming web traffic across
    /// applications that run on multiple Amazon Elastic Compute Cloud (Amazon EC2) instances.
    /// 
    /// </para>
    /// 
    /// <para>
    /// You can create, access, and manage Elastic Load Balancing using the AWS Management
    /// Console or the Elastic Load Balancing API. For more information about Elastic Load
    /// Balancing interfaces, see <a href="http://docs.aws.amazon.com/ElasticLoadBalancing/latest/DeveloperGuide/SvcIntro_Interfaces.html">Accessing
    /// Elastic Load Balancing</a>.
    /// </para>
    /// 
    /// <para>
    /// This reference guide contains documentation for the Query API and the AWS command
    /// line interface commands, to manage Elastic Load Balancing.
    /// </para>
    /// 
    /// <para>
    /// For detailed information about Elastic Load Balancing features and their associated
    /// actions or commands, go to <a href="http://docs.aws.amazon.com/ElasticLoadBalancing/latest/DeveloperGuide/UserScenarios.html">Managing
    /// Load Balancers</a> in the <i>Elastic Load Balancing Developer Guide</i>.
    /// </para>
    /// 
    /// <para>
    /// This reference guide is based on the current WSDL, which is available at: <a href="http://ec2-downloads.s3.amazonaws.com/ElasticLoadBalancing.wsdl"></a>.
    /// 
    /// </para>
    /// 
    /// <para>
    /// <b>Endpoints</b>
    /// </para>
    /// 
    /// <para>
    /// The examples in this guide assume that your load balancers are created in the US East
    /// (Northern Virginia) region and use us-east-1 as the endpoint.
    /// </para>
    /// 
    /// <para>
    /// You can create your load balancers in other AWS regions. For information about regions
    /// and endpoints supported by Elastic Load Balancing, see <a href="http://docs.aws.amazon.com/general/latest/gr/index.html?rande.html">Regions
    /// and Endpoints</a> in the Amazon Web Services General Reference.
    /// </para>
    /// </summary>
    /// <summary>
    /// Implementation for accessing AmazonElasticLoadBalancing.
    /// 
    /// Elastic Load Balancing <para> Elastic Load Balancing is a cost-effective and easy to use web service to help you improve the availability
    /// and scalability of your application running on Amazon Elastic Cloud Compute (Amazon EC2). It makes it easy for you to distribute application
    /// loads between two or more EC2 instances. Elastic Load Balancing supports the growth in traffic of your application by enabling availability
    /// through redundancy. </para> <para>This guide provides detailed information about Elastic Load Balancing actions, data types, and parameters
    /// that can be used for sending a query request. Query requests are HTTP or HTTPS requests that use the HTTP verb GET or POST and a query
    /// parameter named Action or Operation. Action is used throughout this documentation, although Operation is supported for backward
    /// compatibility with other AWS Query APIs.</para> <para>For detailed information on constructing a query request using the actions, data
    /// types, and parameters mentioned in this guide, go to Using the Query API in the <i>Elastic Load Balancing Developer Guide</i> .</para>
    /// <para>For detailed information about Elastic Load Balancing features and their associated actions, go to Using Elastic Load Balancing in the
    /// <i>Elastic Load Balancing Developer Guide</i> .</para> <para>This reference guide is based on the current WSDL, which is available at:
    /// </para>
    /// </summary>
	public partial class AmazonElasticLoadBalancingClient : AmazonWebServiceClient, Amazon.ElasticLoadBalancing.IAmazonElasticLoadBalancing
    {

        AWS4Signer signer = new AWS4Signer();

        #region Dispose

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Constructs AmazonElasticLoadBalancingClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        public AmazonElasticLoadBalancingClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonElasticLoadBalancingConfig(), AuthenticationTypes.User | AuthenticationTypes.Session) { }

        /// <summary>
        /// Constructs AmazonElasticLoadBalancingClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        /// <param name="region">The region to connect.</param>
        public AmazonElasticLoadBalancingClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonElasticLoadBalancingConfig(){RegionEndpoint = region}, AuthenticationTypes.User | AuthenticationTypes.Session) { }

        /// <summary>
        /// Constructs AmazonElasticLoadBalancingClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        /// <param name="config">The AmazonElasticLoadBalancing Configuration Object</param>
        public AmazonElasticLoadBalancingClient(AmazonElasticLoadBalancingConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config, AuthenticationTypes.User | AuthenticationTypes.Session) { }

        /// <summary>
        /// Constructs AmazonElasticLoadBalancingClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonElasticLoadBalancingClient(AWSCredentials credentials)
            : this(credentials, new AmazonElasticLoadBalancingConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonElasticLoadBalancingClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonElasticLoadBalancingClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonElasticLoadBalancingConfig(){RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonElasticLoadBalancingClient with AWS Credentials and an
        /// AmazonElasticLoadBalancingClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonElasticLoadBalancingClient Configuration Object</param>
        public AmazonElasticLoadBalancingClient(AWSCredentials credentials, AmazonElasticLoadBalancingConfig clientConfig)
            : base(credentials, clientConfig, AuthenticationTypes.User | AuthenticationTypes.Session)
        {
        }

        /// <summary>
        /// Constructs AmazonElasticLoadBalancingClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonElasticLoadBalancingClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonElasticLoadBalancingConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonElasticLoadBalancingClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonElasticLoadBalancingClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonElasticLoadBalancingConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonElasticLoadBalancingClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonElasticLoadBalancingClient Configuration object.
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonElasticLoadBalancingClient Configuration Object</param>
        public AmazonElasticLoadBalancingClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonElasticLoadBalancingConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig, AuthenticationTypes.User | AuthenticationTypes.Session)
        {
        }

        /// <summary>
        /// Constructs AmazonElasticLoadBalancingClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonElasticLoadBalancingClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonElasticLoadBalancingConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonElasticLoadBalancingClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonElasticLoadBalancingClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonElasticLoadBalancingConfig(){RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonElasticLoadBalancingClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonElasticLoadBalancingClient Configuration object.
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonElasticLoadBalancingClient Configuration Object</param>
        public AmazonElasticLoadBalancingClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonElasticLoadBalancingConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig, AuthenticationTypes.User | AuthenticationTypes.Session)
        {
        }

        #endregion

 
        /// <summary>
        /// Adds one or more tags for the specified load balancer. Each load balancer can have
        /// a maximum of 10 tags. Each tag consists of a key and an optional value.
        /// 
        /// 
        /// <para>
        /// Tag keys must be unique for each load balancer. If a tag with the same key is already
        /// associated with the load balancer, this action will update the value of the key.
        /// </para>
        /// 
        /// <para>
        /// For more information, see <a href="http://docs.aws.amazon.com/ElasticLoadBalancing/latest/DeveloperGuide/TerminologyandKeyConcepts.html#tagging-elb">Tagging</a>
        /// in the <i>Elastic Load Balancing Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddTags service method.</param>
        /// 
        /// <returns>The response from the AddTags service method, as returned by ElasticLoadBalancing.</returns>
        /// <exception cref="T:Amazon.ElasticLoadBalancing.Model.AccessPointNotFoundException">
        /// The specified load balancer could not be found.
        /// </exception>
        /// <exception cref="T:Amazon.ElasticLoadBalancing.Model.DuplicateTagKeysException">
        /// The same tag key specified multiple times.
        /// </exception>
        /// <exception cref="T:Amazon.ElasticLoadBalancing.Model.TooManyTagsException">
        /// The quota for the number of tags that can be assigned to a load balancer has been
        /// reached.
        /// </exception>
		public AddTagsResponse AddTags(AddTagsRequest request)
        {
            var task = AddTagsAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }
          
        /// <summary>
        /// Initiates the asynchronous execution of the AddTags operation.
        /// <seealso cref="Amazon.ElasticLoadBalancing.IAmazonElasticLoadBalancing.AddTags"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AddTags operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public Task<AddTagsResponse> AddTagsAsync(AddTagsRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new AddTagsRequestMarshaller();
            var unmarshaller = AddTagsResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, AddTagsRequest, AddTagsResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
        }
 
        /// <summary>
        /// Associates one or more security groups with your load balancer in Amazon Virtual
        /// Private Cloud (Amazon VPC). The provided security group IDs will override any currently
        /// applied security groups.
        /// 
        /// 
        /// <para>
        /// For more information, see <a href="http://docs.aws.amazon.com/ElasticLoadBalancing/latest/DeveloperGuide/USVPC_ApplySG.html">Manage
        /// Security Groups in Amazon VPC</a> in the <i>Elastic Load Balancing Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ApplySecurityGroupsToLoadBalancer service method.</param>
        /// 
        /// <returns>The response from the ApplySecurityGroupsToLoadBalancer service method, as returned by ElasticLoadBalancing.</returns>
        /// <exception cref="T:Amazon.ElasticLoadBalancing.Model.AccessPointNotFoundException">
        /// The specified load balancer could not be found.
        /// </exception>
        /// <exception cref="T:Amazon.ElasticLoadBalancing.Model.InvalidConfigurationRequestException">
        /// Requested configuration change is invalid.
        /// </exception>
        /// <exception cref="T:Amazon.ElasticLoadBalancing.Model.InvalidSecurityGroupException">
        /// One or more specified security groups do not exist.
        /// </exception>
		public ApplySecurityGroupsToLoadBalancerResponse ApplySecurityGroupsToLoadBalancer(ApplySecurityGroupsToLoadBalancerRequest request)
        {
            var task = ApplySecurityGroupsToLoadBalancerAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }
          
        /// <summary>
        /// Initiates the asynchronous execution of the ApplySecurityGroupsToLoadBalancer operation.
        /// <seealso cref="Amazon.ElasticLoadBalancing.IAmazonElasticLoadBalancing.ApplySecurityGroupsToLoadBalancer"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ApplySecurityGroupsToLoadBalancer operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public Task<ApplySecurityGroupsToLoadBalancerResponse> ApplySecurityGroupsToLoadBalancerAsync(ApplySecurityGroupsToLoadBalancerRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ApplySecurityGroupsToLoadBalancerRequestMarshaller();
            var unmarshaller = ApplySecurityGroupsToLoadBalancerResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, ApplySecurityGroupsToLoadBalancerRequest, ApplySecurityGroupsToLoadBalancerResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
        }
 
        /// <summary>
        /// Adds one or more subnets to the set of configured subnets in the Amazon Virtual Private
        /// Cloud (Amazon VPC) for the load balancer.
        /// 
        /// 
        /// <para>
        /// The load balancers evenly distribute requests across all of the registered subnets.
        /// For more information, see <a href="http://docs.aws.amazon.com/ElasticLoadBalancing/latest/DeveloperGuide/UserScenariosForVPC.html">Deploy
        /// Elastic Load Balancing in Amazon VPC</a> in the <i>Elastic Load Balancing Developer
        /// Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AttachLoadBalancerToSubnets service method.</param>
        /// 
        /// <returns>The response from the AttachLoadBalancerToSubnets service method, as returned by ElasticLoadBalancing.</returns>
        /// <exception cref="T:Amazon.ElasticLoadBalancing.Model.AccessPointNotFoundException">
        /// The specified load balancer could not be found.
        /// </exception>
        /// <exception cref="T:Amazon.ElasticLoadBalancing.Model.InvalidConfigurationRequestException">
        /// Requested configuration change is invalid.
        /// </exception>
        /// <exception cref="T:Amazon.ElasticLoadBalancing.Model.InvalidSubnetException">
        /// The VPC has no Internet gateway.
        /// </exception>
        /// <exception cref="T:Amazon.ElasticLoadBalancing.Model.SubnetNotFoundException">
        /// One or more subnets were not found.
        /// </exception>
		public AttachLoadBalancerToSubnetsResponse AttachLoadBalancerToSubnets(AttachLoadBalancerToSubnetsRequest request)
        {
            var task = AttachLoadBalancerToSubnetsAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }
          
        /// <summary>
        /// Initiates the asynchronous execution of the AttachLoadBalancerToSubnets operation.
        /// <seealso cref="Amazon.ElasticLoadBalancing.IAmazonElasticLoadBalancing.AttachLoadBalancerToSubnets"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AttachLoadBalancerToSubnets operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public Task<AttachLoadBalancerToSubnetsResponse> AttachLoadBalancerToSubnetsAsync(AttachLoadBalancerToSubnetsRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new AttachLoadBalancerToSubnetsRequestMarshaller();
            var unmarshaller = AttachLoadBalancerToSubnetsResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, AttachLoadBalancerToSubnetsRequest, AttachLoadBalancerToSubnetsResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
        }
 
        /// <summary>
        /// Specifies the health check settings to use for evaluating the health state of your
        /// back-end instances.
        /// 
        /// 
        /// <para>
        /// For more information, see <a href="http://docs.aws.amazon.com/ElasticLoadBalancing/latest/DeveloperGuide/TerminologyandKeyConcepts.html#healthcheck">Health
        /// Check</a> in the <i>Elastic Load Balancing Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ConfigureHealthCheck service method.</param>
        /// 
        /// <returns>The response from the ConfigureHealthCheck service method, as returned by ElasticLoadBalancing.</returns>
        /// <exception cref="T:Amazon.ElasticLoadBalancing.Model.AccessPointNotFoundException">
        /// The specified load balancer could not be found.
        /// </exception>
		public ConfigureHealthCheckResponse ConfigureHealthCheck(ConfigureHealthCheckRequest request)
        {
            var task = ConfigureHealthCheckAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }
          
        /// <summary>
        /// Initiates the asynchronous execution of the ConfigureHealthCheck operation.
        /// <seealso cref="Amazon.ElasticLoadBalancing.IAmazonElasticLoadBalancing.ConfigureHealthCheck"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ConfigureHealthCheck operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public Task<ConfigureHealthCheckResponse> ConfigureHealthCheckAsync(ConfigureHealthCheckRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ConfigureHealthCheckRequestMarshaller();
            var unmarshaller = ConfigureHealthCheckResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, ConfigureHealthCheckRequest, ConfigureHealthCheckResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
        }
 
        /// <summary>
        /// Generates a stickiness policy with sticky session lifetimes that follow that of an
        /// application-generated cookie. This policy can be associated only with HTTP/HTTPS listeners.
        /// 
        /// 
        /// 
        /// <para>
        /// This policy is similar to the policy created by <a>CreateLBCookieStickinessPolicy</a>,
        /// except that the lifetime of the special Elastic Load Balancing cookie follows the
        /// lifetime of the application-generated cookie specified in the policy configuration.
        /// The load balancer only inserts a new stickiness cookie when the application response
        /// includes a new application cookie.
        /// </para>
        /// 
        /// <para>
        /// If the application cookie is explicitly removed or expires, the session stops being
        /// sticky until a new application cookie is issued.
        /// </para>
        /// 
        /// <para>
        /// For more information, see <a href="http://docs.aws.amazon.com/ElasticLoadBalancing/latest/DeveloperGuide/US_StickySessions.html#US_EnableStickySessionsAppCookies">Enabling
        /// Application-Controlled Session Stickiness</a> in the <i>Elastic Load Balancing Developer
        /// Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAppCookieStickinessPolicy service method.</param>
        /// 
        /// <returns>The response from the CreateAppCookieStickinessPolicy service method, as returned by ElasticLoadBalancing.</returns>
        /// <exception cref="T:Amazon.ElasticLoadBalancing.Model.AccessPointNotFoundException">
        /// The specified load balancer could not be found.
        /// </exception>
        /// <exception cref="T:Amazon.ElasticLoadBalancing.Model.DuplicatePolicyNameException">
        /// Policy with the same name exists for this load balancer. Please choose another name.
        /// </exception>
        /// <exception cref="T:Amazon.ElasticLoadBalancing.Model.InvalidConfigurationRequestException">
        /// Requested configuration change is invalid.
        /// </exception>
        /// <exception cref="T:Amazon.ElasticLoadBalancing.Model.TooManyPoliciesException">
        /// Quota for number of policies for this load balancer has already been reached.
        /// </exception>
		public CreateAppCookieStickinessPolicyResponse CreateAppCookieStickinessPolicy(CreateAppCookieStickinessPolicyRequest request)
        {
            var task = CreateAppCookieStickinessPolicyAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }
          
        /// <summary>
        /// Initiates the asynchronous execution of the CreateAppCookieStickinessPolicy operation.
        /// <seealso cref="Amazon.ElasticLoadBalancing.IAmazonElasticLoadBalancing.CreateAppCookieStickinessPolicy"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateAppCookieStickinessPolicy operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public Task<CreateAppCookieStickinessPolicyResponse> CreateAppCookieStickinessPolicyAsync(CreateAppCookieStickinessPolicyRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateAppCookieStickinessPolicyRequestMarshaller();
            var unmarshaller = CreateAppCookieStickinessPolicyResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, CreateAppCookieStickinessPolicyRequest, CreateAppCookieStickinessPolicyResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
        }
 
        /// <summary>
        /// Generates a stickiness policy with sticky session lifetimes controlled by the lifetime
        /// of the browser (user-agent) or a specified expiration period. This policy can be associated
        /// only with HTTP/HTTPS listeners.
        /// 
        /// 
        /// <para>
        /// When a load balancer implements this policy, the load balancer uses a special cookie
        /// to track the backend server instance for each request. When the load balancer receives
        /// a request, it first checks to see if this cookie is present in the request. If so,
        /// the load balancer sends the request to the application server specified in the cookie.
        /// If not, the load balancer sends the request to a server that is chosen based on the
        /// existing load balancing algorithm.
        /// </para>
        /// 
        /// <para>
        /// A cookie is inserted into the response for binding subsequent requests from the same
        /// user to that server. The validity of the cookie is based on the cookie expiration
        /// time, which is specified in the policy configuration.
        /// </para>
        /// 
        /// <para>
        /// For more information, see <a href="http://docs.aws.amazon.com/ElasticLoadBalancing/latest/DeveloperGuide/US_StickySessions.html#US_EnableStickySessionsLBCookies">Enabling
        /// Duration-Based Session Stickiness</a> in the <i>Elastic Load Balancing Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateLBCookieStickinessPolicy service method.</param>
        /// 
        /// <returns>The response from the CreateLBCookieStickinessPolicy service method, as returned by ElasticLoadBalancing.</returns>
        /// <exception cref="T:Amazon.ElasticLoadBalancing.Model.AccessPointNotFoundException">
        /// The specified load balancer could not be found.
        /// </exception>
        /// <exception cref="T:Amazon.ElasticLoadBalancing.Model.DuplicatePolicyNameException">
        /// Policy with the same name exists for this load balancer. Please choose another name.
        /// </exception>
        /// <exception cref="T:Amazon.ElasticLoadBalancing.Model.InvalidConfigurationRequestException">
        /// Requested configuration change is invalid.
        /// </exception>
        /// <exception cref="T:Amazon.ElasticLoadBalancing.Model.TooManyPoliciesException">
        /// Quota for number of policies for this load balancer has already been reached.
        /// </exception>
		public CreateLBCookieStickinessPolicyResponse CreateLBCookieStickinessPolicy(CreateLBCookieStickinessPolicyRequest request)
        {
            var task = CreateLBCookieStickinessPolicyAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }
          
        /// <summary>
        /// Initiates the asynchronous execution of the CreateLBCookieStickinessPolicy operation.
        /// <seealso cref="Amazon.ElasticLoadBalancing.IAmazonElasticLoadBalancing.CreateLBCookieStickinessPolicy"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateLBCookieStickinessPolicy operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public Task<CreateLBCookieStickinessPolicyResponse> CreateLBCookieStickinessPolicyAsync(CreateLBCookieStickinessPolicyRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateLBCookieStickinessPolicyRequestMarshaller();
            var unmarshaller = CreateLBCookieStickinessPolicyResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, CreateLBCookieStickinessPolicyRequest, CreateLBCookieStickinessPolicyResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
        }
 
        /// <summary>
        /// Creates a new load balancer.
        /// 
        /// 
        /// <para>
        /// After the call has completed successfully, a new load balancer is created with a
        /// unique Domain Name Service (DNS) name. The DNS name includes the name of the AWS region
        /// in which the load balance was created. For example, if your load balancer was created
        /// in the United States, the DNS name might end with either of the following:
        /// </para>
        /// <ul> <li> <i>us-east-1.elb.amazonaws.com</i> (for the Northern Virginia region) </li>
        /// <li> <i>us-west-1.elb.amazonaws.com</i> (for the Northern California region) </li>
        /// </ul>
        /// <para>
        /// For information about the AWS regions supported by Elastic Load Balancing, see <a href="http://docs.aws.amazon.com/general/latest/gr/rande.html#elb_region">Regions
        /// and Endpoints</a>.
        /// </para>
        /// 
        /// <para>
        /// You can create up to 20 load balancers per region per account.
        /// </para>
        /// 
        /// <para>
        /// Elastic Load Balancing supports load balancing your Amazon EC2 instances launched
        /// within any one of the following platforms:
        /// </para>
        /// <ul> <li> <i>EC2-Classic</i>
        /// <para>
        /// For information on creating and managing your load balancers in EC2-Classic, see <a href="http://docs.aws.amazon.com/ElasticLoadBalancing/latest/DeveloperGuide/UserScenariosForEC2.html">Deploy
        /// Elastic Load Balancing in Amazon EC2-Classic</a>.
        /// </para>
        /// </li> <li> <i>EC2-VPC</i>
        /// <para>
        /// For information on creating and managing your load balancers in EC2-VPC, see <a href="http://docs.aws.amazon.com/ElasticLoadBalancing/latest/DeveloperGuide/UserScenariosForVPC.html">Deploy
        /// Elastic Load Balancing in Amazon VPC</a>.
        /// </para>
        /// </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateLoadBalancer service method.</param>
        /// 
        /// <returns>The response from the CreateLoadBalancer service method, as returned by ElasticLoadBalancing.</returns>
        /// <exception cref="T:Amazon.ElasticLoadBalancing.Model.CertificateNotFoundException">
        /// The specified SSL ID does not refer to a valid SSL certificate in the AWS Identity
        /// and Access Management Service.
        /// </exception>
        /// <exception cref="T:Amazon.ElasticLoadBalancing.Model.DuplicateAccessPointNameException">
        /// The load balancer name already exists for this account. Please choose another name.
        /// </exception>
        /// <exception cref="T:Amazon.ElasticLoadBalancing.Model.DuplicateTagKeysException">
        /// The same tag key specified multiple times.
        /// </exception>
        /// <exception cref="T:Amazon.ElasticLoadBalancing.Model.InvalidConfigurationRequestException">
        /// Requested configuration change is invalid.
        /// </exception>
        /// <exception cref="T:Amazon.ElasticLoadBalancing.Model.InvalidSchemeException">
        /// Invalid value for scheme. Scheme can only be specified for load balancers in VPC.
        /// </exception>
        /// <exception cref="T:Amazon.ElasticLoadBalancing.Model.InvalidSecurityGroupException">
        /// One or more specified security groups do not exist.
        /// </exception>
        /// <exception cref="T:Amazon.ElasticLoadBalancing.Model.InvalidSubnetException">
        /// The VPC has no Internet gateway.
        /// </exception>
        /// <exception cref="T:Amazon.ElasticLoadBalancing.Model.SubnetNotFoundException">
        /// One or more subnets were not found.
        /// </exception>
        /// <exception cref="T:Amazon.ElasticLoadBalancing.Model.TooManyAccessPointsException">
        /// The quota for the number of load balancers has already been reached.
        /// </exception>
        /// <exception cref="T:Amazon.ElasticLoadBalancing.Model.TooManyTagsException">
        /// The quota for the number of tags that can be assigned to a load balancer has been
        /// reached.
        /// </exception>
		public CreateLoadBalancerResponse CreateLoadBalancer(CreateLoadBalancerRequest request)
        {
            var task = CreateLoadBalancerAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }
          
        /// <summary>
        /// Initiates the asynchronous execution of the CreateLoadBalancer operation.
        /// <seealso cref="Amazon.ElasticLoadBalancing.IAmazonElasticLoadBalancing.CreateLoadBalancer"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateLoadBalancer operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public Task<CreateLoadBalancerResponse> CreateLoadBalancerAsync(CreateLoadBalancerRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateLoadBalancerRequestMarshaller();
            var unmarshaller = CreateLoadBalancerResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, CreateLoadBalancerRequest, CreateLoadBalancerResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
        }
 
        /// <summary>
        /// Creates one or more listeners on a load balancer for the specified port. If a listener
        /// with the given port does not already exist, it will be created; otherwise, the properties
        /// of the new listener must match the properties of the existing listener.
        /// 
        /// 
        /// <para>
        /// For more information, see <a href="http://docs.aws.amazon.com/ElasticLoadBalancing/latest/DeveloperGuide/us-add-listener.html">Add
        /// a Listener to Your Load Balancer</a> in the <i>Elastic Load Balancing Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateLoadBalancerListeners service method.</param>
        /// 
        /// <returns>The response from the CreateLoadBalancerListeners service method, as returned by ElasticLoadBalancing.</returns>
        /// <exception cref="T:Amazon.ElasticLoadBalancing.Model.AccessPointNotFoundException">
        /// The specified load balancer could not be found.
        /// </exception>
        /// <exception cref="T:Amazon.ElasticLoadBalancing.Model.CertificateNotFoundException">
        /// The specified SSL ID does not refer to a valid SSL certificate in the AWS Identity
        /// and Access Management Service.
        /// </exception>
        /// <exception cref="T:Amazon.ElasticLoadBalancing.Model.DuplicateListenerException">
        /// A <code>Listener</code> already exists for the given <code>LoadBalancerName</code>
        /// and <code>LoadBalancerPort</code>, but with a different <code>InstancePort</code>,
        /// <code>Protocol</code>, or <code>SSLCertificateId</code>.
        /// </exception>
        /// <exception cref="T:Amazon.ElasticLoadBalancing.Model.InvalidConfigurationRequestException">
        /// Requested configuration change is invalid.
        /// </exception>
		public CreateLoadBalancerListenersResponse CreateLoadBalancerListeners(CreateLoadBalancerListenersRequest request)
        {
            var task = CreateLoadBalancerListenersAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }
          
        /// <summary>
        /// Initiates the asynchronous execution of the CreateLoadBalancerListeners operation.
        /// <seealso cref="Amazon.ElasticLoadBalancing.IAmazonElasticLoadBalancing.CreateLoadBalancerListeners"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateLoadBalancerListeners operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public Task<CreateLoadBalancerListenersResponse> CreateLoadBalancerListenersAsync(CreateLoadBalancerListenersRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateLoadBalancerListenersRequestMarshaller();
            var unmarshaller = CreateLoadBalancerListenersResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, CreateLoadBalancerListenersRequest, CreateLoadBalancerListenersResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
        }
 
        /// <summary>
        /// Creates a new policy that contains the necessary attributes depending on the policy
        /// type. Policies are settings that are saved for your load balancer and that can be
        /// applied to the front-end listener, or the back-end application server, depending on
        /// your policy type.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateLoadBalancerPolicy service method.</param>
        /// 
        /// <returns>The response from the CreateLoadBalancerPolicy service method, as returned by ElasticLoadBalancing.</returns>
        /// <exception cref="T:Amazon.ElasticLoadBalancing.Model.AccessPointNotFoundException">
        /// The specified load balancer could not be found.
        /// </exception>
        /// <exception cref="T:Amazon.ElasticLoadBalancing.Model.DuplicatePolicyNameException">
        /// Policy with the same name exists for this load balancer. Please choose another name.
        /// </exception>
        /// <exception cref="T:Amazon.ElasticLoadBalancing.Model.InvalidConfigurationRequestException">
        /// Requested configuration change is invalid.
        /// </exception>
        /// <exception cref="T:Amazon.ElasticLoadBalancing.Model.PolicyTypeNotFoundException">
        /// One or more of the specified policy types do not exist.
        /// </exception>
        /// <exception cref="T:Amazon.ElasticLoadBalancing.Model.TooManyPoliciesException">
        /// Quota for number of policies for this load balancer has already been reached.
        /// </exception>
		public CreateLoadBalancerPolicyResponse CreateLoadBalancerPolicy(CreateLoadBalancerPolicyRequest request)
        {
            var task = CreateLoadBalancerPolicyAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }
          
        /// <summary>
        /// Initiates the asynchronous execution of the CreateLoadBalancerPolicy operation.
        /// <seealso cref="Amazon.ElasticLoadBalancing.IAmazonElasticLoadBalancing.CreateLoadBalancerPolicy"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateLoadBalancerPolicy operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public Task<CreateLoadBalancerPolicyResponse> CreateLoadBalancerPolicyAsync(CreateLoadBalancerPolicyRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateLoadBalancerPolicyRequestMarshaller();
            var unmarshaller = CreateLoadBalancerPolicyResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, CreateLoadBalancerPolicyRequest, CreateLoadBalancerPolicyResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
        }
 
        /// <summary>
        /// Deletes the specified load balancer.
        /// 
        /// 
        /// <para>
        /// If attempting to recreate the load balancer, you must reconfigure all the settings.
        /// The DNS name associated with a deleted load balancer will no longer be usable. Once
        /// deleted, the name and associated DNS record of the load balancer no longer exist and
        /// traffic sent to any of its IP addresses will no longer be delivered to back-end instances.
        /// 
        /// </para>
        /// 
        /// <para>
        /// To successfully call this API, you must provide the same account credentials as were
        /// used to create the load balancer.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteLoadBalancer service method.</param>
        /// 
        /// <returns>The response from the DeleteLoadBalancer service method, as returned by ElasticLoadBalancing.</returns>
		public DeleteLoadBalancerResponse DeleteLoadBalancer(DeleteLoadBalancerRequest request)
        {
            var task = DeleteLoadBalancerAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }
          
        /// <summary>
        /// Initiates the asynchronous execution of the DeleteLoadBalancer operation.
        /// <seealso cref="Amazon.ElasticLoadBalancing.IAmazonElasticLoadBalancing.DeleteLoadBalancer"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteLoadBalancer operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public Task<DeleteLoadBalancerResponse> DeleteLoadBalancerAsync(DeleteLoadBalancerRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteLoadBalancerRequestMarshaller();
            var unmarshaller = DeleteLoadBalancerResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, DeleteLoadBalancerRequest, DeleteLoadBalancerResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
        }
 
        /// <summary>
        /// Deletes listeners from the load balancer for the specified port.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteLoadBalancerListeners service method.</param>
        /// 
        /// <returns>The response from the DeleteLoadBalancerListeners service method, as returned by ElasticLoadBalancing.</returns>
        /// <exception cref="T:Amazon.ElasticLoadBalancing.Model.AccessPointNotFoundException">
        /// The specified load balancer could not be found.
        /// </exception>
		public DeleteLoadBalancerListenersResponse DeleteLoadBalancerListeners(DeleteLoadBalancerListenersRequest request)
        {
            var task = DeleteLoadBalancerListenersAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }
          
        /// <summary>
        /// Initiates the asynchronous execution of the DeleteLoadBalancerListeners operation.
        /// <seealso cref="Amazon.ElasticLoadBalancing.IAmazonElasticLoadBalancing.DeleteLoadBalancerListeners"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteLoadBalancerListeners operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public Task<DeleteLoadBalancerListenersResponse> DeleteLoadBalancerListenersAsync(DeleteLoadBalancerListenersRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteLoadBalancerListenersRequestMarshaller();
            var unmarshaller = DeleteLoadBalancerListenersResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, DeleteLoadBalancerListenersRequest, DeleteLoadBalancerListenersResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
        }
 
        /// <summary>
        /// Deletes a policy from the load balancer. The specified policy must not be enabled
        /// for any listeners.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteLoadBalancerPolicy service method.</param>
        /// 
        /// <returns>The response from the DeleteLoadBalancerPolicy service method, as returned by ElasticLoadBalancing.</returns>
        /// <exception cref="T:Amazon.ElasticLoadBalancing.Model.AccessPointNotFoundException">
        /// The specified load balancer could not be found.
        /// </exception>
        /// <exception cref="T:Amazon.ElasticLoadBalancing.Model.InvalidConfigurationRequestException">
        /// Requested configuration change is invalid.
        /// </exception>
		public DeleteLoadBalancerPolicyResponse DeleteLoadBalancerPolicy(DeleteLoadBalancerPolicyRequest request)
        {
            var task = DeleteLoadBalancerPolicyAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }
          
        /// <summary>
        /// Initiates the asynchronous execution of the DeleteLoadBalancerPolicy operation.
        /// <seealso cref="Amazon.ElasticLoadBalancing.IAmazonElasticLoadBalancing.DeleteLoadBalancerPolicy"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteLoadBalancerPolicy operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public Task<DeleteLoadBalancerPolicyResponse> DeleteLoadBalancerPolicyAsync(DeleteLoadBalancerPolicyRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteLoadBalancerPolicyRequestMarshaller();
            var unmarshaller = DeleteLoadBalancerPolicyResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, DeleteLoadBalancerPolicyRequest, DeleteLoadBalancerPolicyResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
        }
 
        /// <summary>
        /// Deregisters instances from the load balancer. Once the instance is deregistered,
        /// it will stop receiving traffic from the load balancer.
        /// 
        /// 
        /// <para>
        /// In order to successfully call this API, the same account credentials as those used
        /// to create the load balancer must be provided.
        /// </para>
        /// 
        /// <para>
        /// For more information, see <a href="http://docs.aws.amazon.com/ElasticLoadBalancing/latest/DeveloperGuide/US_DeReg_Reg_Instances.html">De-register
        /// and Register Amazon EC2 Instances</a> in the <i>Elastic Load Balancing Developer Guide</i>.
        /// </para>
        /// 
        /// <para>
        /// You can use <a>DescribeLoadBalancers</a> to verify if the instance is deregistered
        /// from the load balancer.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeregisterInstancesFromLoadBalancer service method.</param>
        /// 
        /// <returns>The response from the DeregisterInstancesFromLoadBalancer service method, as returned by ElasticLoadBalancing.</returns>
        /// <exception cref="T:Amazon.ElasticLoadBalancing.Model.AccessPointNotFoundException">
        /// The specified load balancer could not be found.
        /// </exception>
        /// <exception cref="T:Amazon.ElasticLoadBalancing.Model.InvalidEndPointException">
        /// The specified EndPoint is not valid.
        /// </exception>
		public DeregisterInstancesFromLoadBalancerResponse DeregisterInstancesFromLoadBalancer(DeregisterInstancesFromLoadBalancerRequest request)
        {
            var task = DeregisterInstancesFromLoadBalancerAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }
          
        /// <summary>
        /// Initiates the asynchronous execution of the DeregisterInstancesFromLoadBalancer operation.
        /// <seealso cref="Amazon.ElasticLoadBalancing.IAmazonElasticLoadBalancing.DeregisterInstancesFromLoadBalancer"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeregisterInstancesFromLoadBalancer operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public Task<DeregisterInstancesFromLoadBalancerResponse> DeregisterInstancesFromLoadBalancerAsync(DeregisterInstancesFromLoadBalancerRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeregisterInstancesFromLoadBalancerRequestMarshaller();
            var unmarshaller = DeregisterInstancesFromLoadBalancerResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, DeregisterInstancesFromLoadBalancerRequest, DeregisterInstancesFromLoadBalancerResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
        }
 
        /// <summary>
        /// Returns the current state of the specified instances registered with the specified
        /// load balancer. If no instances are specified, the state of all the instances registered
        /// with the load balancer is returned.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeInstanceHealth service method.</param>
        /// 
        /// <returns>The response from the DescribeInstanceHealth service method, as returned by ElasticLoadBalancing.</returns>
        /// <exception cref="T:Amazon.ElasticLoadBalancing.Model.AccessPointNotFoundException">
        /// The specified load balancer could not be found.
        /// </exception>
        /// <exception cref="T:Amazon.ElasticLoadBalancing.Model.InvalidEndPointException">
        /// The specified EndPoint is not valid.
        /// </exception>
		public DescribeInstanceHealthResponse DescribeInstanceHealth(DescribeInstanceHealthRequest request)
        {
            var task = DescribeInstanceHealthAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }
          
        /// <summary>
        /// Initiates the asynchronous execution of the DescribeInstanceHealth operation.
        /// <seealso cref="Amazon.ElasticLoadBalancing.IAmazonElasticLoadBalancing.DescribeInstanceHealth"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeInstanceHealth operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public Task<DescribeInstanceHealthResponse> DescribeInstanceHealthAsync(DescribeInstanceHealthRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeInstanceHealthRequestMarshaller();
            var unmarshaller = DescribeInstanceHealthResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, DescribeInstanceHealthRequest, DescribeInstanceHealthResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
        }
 
        /// <summary>
        /// Returns detailed information about all of the attributes associated with the specified
        /// load balancer.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeLoadBalancerAttributes service method.</param>
        /// 
        /// <returns>The response from the DescribeLoadBalancerAttributes service method, as returned by ElasticLoadBalancing.</returns>
        /// <exception cref="T:Amazon.ElasticLoadBalancing.Model.AccessPointNotFoundException">
        /// The specified load balancer could not be found.
        /// </exception>
        /// <exception cref="T:Amazon.ElasticLoadBalancing.Model.LoadBalancerAttributeNotFoundException">
        /// The specified load balancer attribute could not be found.
        /// </exception>
		public DescribeLoadBalancerAttributesResponse DescribeLoadBalancerAttributes(DescribeLoadBalancerAttributesRequest request)
        {
            var task = DescribeLoadBalancerAttributesAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }
          
        /// <summary>
        /// Initiates the asynchronous execution of the DescribeLoadBalancerAttributes operation.
        /// <seealso cref="Amazon.ElasticLoadBalancing.IAmazonElasticLoadBalancing.DescribeLoadBalancerAttributes"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeLoadBalancerAttributes operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public Task<DescribeLoadBalancerAttributesResponse> DescribeLoadBalancerAttributesAsync(DescribeLoadBalancerAttributesRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeLoadBalancerAttributesRequestMarshaller();
            var unmarshaller = DescribeLoadBalancerAttributesResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, DescribeLoadBalancerAttributesRequest, DescribeLoadBalancerAttributesResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
        }
 
        /// <summary>
        /// Returns detailed descriptions of the policies. If you specify a load balancer name,
        /// the action returns the descriptions of all the policies created for the load balancer.
        /// If you specify a policy name associated with your load balancer, the action returns
        /// the description of that policy. If you don't specify a load balancer name, the action
        /// returns descriptions of the specified sample policies, or descriptions of all the
        /// sample policies. The names of the sample policies have the <code>ELBSample-</code>
        /// prefix.
        /// </summary>
        /// 
        /// <returns>The response from the DescribeLoadBalancerPolicies service method, as returned by ElasticLoadBalancing.</returns>
        /// <exception cref="T:Amazon.ElasticLoadBalancing.Model.AccessPointNotFoundException">
        /// The specified load balancer could not be found.
        /// </exception>
        /// <exception cref="T:Amazon.ElasticLoadBalancing.Model.PolicyNotFoundException">
        /// One or more specified policies were not found.
        /// </exception>
		public DescribeLoadBalancerPoliciesResponse DescribeLoadBalancerPolicies()
        {
            return this.DescribeLoadBalancerPolicies(new DescribeLoadBalancerPoliciesRequest());
        }
 
        /// <summary>
        /// Returns detailed descriptions of the policies. If you specify a load balancer name,
        /// the action returns the descriptions of all the policies created for the load balancer.
        /// If you specify a policy name associated with your load balancer, the action returns
        /// the description of that policy. If you don't specify a load balancer name, the action
        /// returns descriptions of the specified sample policies, or descriptions of all the
        /// sample policies. The names of the sample policies have the <code>ELBSample-</code>
        /// prefix.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeLoadBalancerPolicies service method.</param>
        /// 
        /// <returns>The response from the DescribeLoadBalancerPolicies service method, as returned by ElasticLoadBalancing.</returns>
        /// <exception cref="T:Amazon.ElasticLoadBalancing.Model.AccessPointNotFoundException">
        /// The specified load balancer could not be found.
        /// </exception>
        /// <exception cref="T:Amazon.ElasticLoadBalancing.Model.PolicyNotFoundException">
        /// One or more specified policies were not found.
        /// </exception>
		public DescribeLoadBalancerPoliciesResponse DescribeLoadBalancerPolicies(DescribeLoadBalancerPoliciesRequest request)
        {
            var task = DescribeLoadBalancerPoliciesAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }
          
        /// <summary>
        /// Initiates the asynchronous execution of the DescribeLoadBalancerPolicies operation.
        /// <seealso cref="Amazon.ElasticLoadBalancing.IAmazonElasticLoadBalancing.DescribeLoadBalancerPolicies"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeLoadBalancerPolicies operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public Task<DescribeLoadBalancerPoliciesResponse> DescribeLoadBalancerPoliciesAsync(DescribeLoadBalancerPoliciesRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeLoadBalancerPoliciesRequestMarshaller();
            var unmarshaller = DescribeLoadBalancerPoliciesResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, DescribeLoadBalancerPoliciesRequest, DescribeLoadBalancerPoliciesResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
        }
 
        /// <summary>
        /// Returns meta-information on the specified load balancer policies defined by the Elastic
        /// Load Balancing service. The policy types that are returned from this action can be
        /// used in a <a>CreateLoadBalancerPolicy</a> action to instantiate specific policy configurations
        /// that will be applied to a load balancer.
        /// </summary>
        /// 
        /// <returns>The response from the DescribeLoadBalancerPolicyTypes service method, as returned by ElasticLoadBalancing.</returns>
        /// <exception cref="T:Amazon.ElasticLoadBalancing.Model.PolicyTypeNotFoundException">
        /// One or more of the specified policy types do not exist.
        /// </exception>
		public DescribeLoadBalancerPolicyTypesResponse DescribeLoadBalancerPolicyTypes()
        {
            return this.DescribeLoadBalancerPolicyTypes(new DescribeLoadBalancerPolicyTypesRequest());
        }
 
        /// <summary>
        /// Returns meta-information on the specified load balancer policies defined by the Elastic
        /// Load Balancing service. The policy types that are returned from this action can be
        /// used in a <a>CreateLoadBalancerPolicy</a> action to instantiate specific policy configurations
        /// that will be applied to a load balancer.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeLoadBalancerPolicyTypes service method.</param>
        /// 
        /// <returns>The response from the DescribeLoadBalancerPolicyTypes service method, as returned by ElasticLoadBalancing.</returns>
        /// <exception cref="T:Amazon.ElasticLoadBalancing.Model.PolicyTypeNotFoundException">
        /// One or more of the specified policy types do not exist.
        /// </exception>
		public DescribeLoadBalancerPolicyTypesResponse DescribeLoadBalancerPolicyTypes(DescribeLoadBalancerPolicyTypesRequest request)
        {
            var task = DescribeLoadBalancerPolicyTypesAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }
          
        /// <summary>
        /// Initiates the asynchronous execution of the DescribeLoadBalancerPolicyTypes operation.
        /// <seealso cref="Amazon.ElasticLoadBalancing.IAmazonElasticLoadBalancing.DescribeLoadBalancerPolicyTypes"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeLoadBalancerPolicyTypes operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public Task<DescribeLoadBalancerPolicyTypesResponse> DescribeLoadBalancerPolicyTypesAsync(DescribeLoadBalancerPolicyTypesRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeLoadBalancerPolicyTypesRequestMarshaller();
            var unmarshaller = DescribeLoadBalancerPolicyTypesResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, DescribeLoadBalancerPolicyTypesRequest, DescribeLoadBalancerPolicyTypesResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
        }
 
        /// <summary>
        /// Returns detailed configuration information for all the load balancers created for
        /// the account. If you specify load balancer names, the action returns configuration
        /// information of the specified load balancers.
        /// </summary>
        /// 
        /// <returns>The response from the DescribeLoadBalancers service method, as returned by ElasticLoadBalancing.</returns>
        /// <exception cref="T:Amazon.ElasticLoadBalancing.Model.AccessPointNotFoundException">
        /// The specified load balancer could not be found.
        /// </exception>
		public DescribeLoadBalancersResponse DescribeLoadBalancers()
        {
            return this.DescribeLoadBalancers(new DescribeLoadBalancersRequest());
        }
 
        /// <summary>
        /// Returns detailed configuration information for all the load balancers created for
        /// the account. If you specify load balancer names, the action returns configuration
        /// information of the specified load balancers.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeLoadBalancers service method.</param>
        /// 
        /// <returns>The response from the DescribeLoadBalancers service method, as returned by ElasticLoadBalancing.</returns>
        /// <exception cref="T:Amazon.ElasticLoadBalancing.Model.AccessPointNotFoundException">
        /// The specified load balancer could not be found.
        /// </exception>
		public DescribeLoadBalancersResponse DescribeLoadBalancers(DescribeLoadBalancersRequest request)
        {
            var task = DescribeLoadBalancersAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }
          
        /// <summary>
        /// Initiates the asynchronous execution of the DescribeLoadBalancers operation.
        /// <seealso cref="Amazon.ElasticLoadBalancing.IAmazonElasticLoadBalancing.DescribeLoadBalancers"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeLoadBalancers operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public Task<DescribeLoadBalancersResponse> DescribeLoadBalancersAsync(DescribeLoadBalancersRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeLoadBalancersRequestMarshaller();
            var unmarshaller = DescribeLoadBalancersResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, DescribeLoadBalancersRequest, DescribeLoadBalancersResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
        }
 
        /// <summary>
        /// Describes the tags associated with one or more load balancers.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeTags service method.</param>
        /// 
        /// <returns>The response from the DescribeTags service method, as returned by ElasticLoadBalancing.</returns>
        /// <exception cref="T:Amazon.ElasticLoadBalancing.Model.AccessPointNotFoundException">
        /// The specified load balancer could not be found.
        /// </exception>
		public DescribeTagsResponse DescribeTags(DescribeTagsRequest request)
        {
            var task = DescribeTagsAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }
          
        /// <summary>
        /// Initiates the asynchronous execution of the DescribeTags operation.
        /// <seealso cref="Amazon.ElasticLoadBalancing.IAmazonElasticLoadBalancing.DescribeTags"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeTags operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public Task<DescribeTagsResponse> DescribeTagsAsync(DescribeTagsRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeTagsRequestMarshaller();
            var unmarshaller = DescribeTagsResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, DescribeTagsRequest, DescribeTagsResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
        }
 
        /// <summary>
        /// Removes subnets from the set of configured subnets in the Amazon Virtual Private
        /// Cloud (Amazon VPC) for the load balancer.
        /// 
        /// 
        /// <para>
        /// After a subnet is removed all of the EC2 instances registered with the load balancer
        /// that are in the removed subnet will go into the <i>OutOfService</i> state. When a
        /// subnet is removed, the load balancer will balance the traffic among the remaining
        /// routable subnets for the load balancer.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DetachLoadBalancerFromSubnets service method.</param>
        /// 
        /// <returns>The response from the DetachLoadBalancerFromSubnets service method, as returned by ElasticLoadBalancing.</returns>
        /// <exception cref="T:Amazon.ElasticLoadBalancing.Model.AccessPointNotFoundException">
        /// The specified load balancer could not be found.
        /// </exception>
        /// <exception cref="T:Amazon.ElasticLoadBalancing.Model.InvalidConfigurationRequestException">
        /// Requested configuration change is invalid.
        /// </exception>
		public DetachLoadBalancerFromSubnetsResponse DetachLoadBalancerFromSubnets(DetachLoadBalancerFromSubnetsRequest request)
        {
            var task = DetachLoadBalancerFromSubnetsAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }
          
        /// <summary>
        /// Initiates the asynchronous execution of the DetachLoadBalancerFromSubnets operation.
        /// <seealso cref="Amazon.ElasticLoadBalancing.IAmazonElasticLoadBalancing.DetachLoadBalancerFromSubnets"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DetachLoadBalancerFromSubnets operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public Task<DetachLoadBalancerFromSubnetsResponse> DetachLoadBalancerFromSubnetsAsync(DetachLoadBalancerFromSubnetsRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DetachLoadBalancerFromSubnetsRequestMarshaller();
            var unmarshaller = DetachLoadBalancerFromSubnetsResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, DetachLoadBalancerFromSubnetsRequest, DetachLoadBalancerFromSubnetsResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
        }
 
        /// <summary>
        /// Removes the specified EC2 Availability Zones from the set of configured Availability
        /// Zones for the load balancer.
        /// 
        /// 
        /// <para>
        /// There must be at least one Availability Zone registered with a load balancer at all
        /// times. Once an Availability Zone is removed, all the instances registered with the
        /// load balancer that are in the removed Availability Zone go into the <i>OutOfService</i>
        /// state. Upon Availability Zone removal, the load balancer attempts to equally balance
        /// the traffic among its remaining usable Availability Zones. Trying to remove an Availability
        /// Zone that was not associated with the load balancer does nothing.
        /// </para>
        /// 
        /// <para>
        /// For more information, see <a href="http://docs.aws.amazon.com/ElasticLoadBalancing/latest/DeveloperGuide/US_ShrinkLBApp04.html">Disable
        /// an Availability Zone from a Load-Balanced Application</a> in the <i>Elastic Load Balancing
        /// Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisableAvailabilityZonesForLoadBalancer service method.</param>
        /// 
        /// <returns>The response from the DisableAvailabilityZonesForLoadBalancer service method, as returned by ElasticLoadBalancing.</returns>
        /// <exception cref="T:Amazon.ElasticLoadBalancing.Model.AccessPointNotFoundException">
        /// The specified load balancer could not be found.
        /// </exception>
        /// <exception cref="T:Amazon.ElasticLoadBalancing.Model.InvalidConfigurationRequestException">
        /// Requested configuration change is invalid.
        /// </exception>
		public DisableAvailabilityZonesForLoadBalancerResponse DisableAvailabilityZonesForLoadBalancer(DisableAvailabilityZonesForLoadBalancerRequest request)
        {
            var task = DisableAvailabilityZonesForLoadBalancerAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }
          
        /// <summary>
        /// Initiates the asynchronous execution of the DisableAvailabilityZonesForLoadBalancer operation.
        /// <seealso cref="Amazon.ElasticLoadBalancing.IAmazonElasticLoadBalancing.DisableAvailabilityZonesForLoadBalancer"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisableAvailabilityZonesForLoadBalancer operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public Task<DisableAvailabilityZonesForLoadBalancerResponse> DisableAvailabilityZonesForLoadBalancerAsync(DisableAvailabilityZonesForLoadBalancerRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DisableAvailabilityZonesForLoadBalancerRequestMarshaller();
            var unmarshaller = DisableAvailabilityZonesForLoadBalancerResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, DisableAvailabilityZonesForLoadBalancerRequest, DisableAvailabilityZonesForLoadBalancerResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
        }
 
        /// <summary>
        /// Adds one or more EC2 Availability Zones to the load balancer.
        /// 
        /// 
        /// <para>
        /// The load balancer evenly distributes requests across all its registered Availability
        /// Zones that contain instances.
        /// </para>
        /// 
        /// <para>
        /// For more information, see <a href="http://docs.aws.amazon.com/ElasticLoadBalancing/latest/DeveloperGuide/US_AddLBAvailabilityZone.html">Expand
        /// a Load Balanced Application to an Additional Availability Zone</a> in the <i>Elastic
        /// Load Balancing Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EnableAvailabilityZonesForLoadBalancer service method.</param>
        /// 
        /// <returns>The response from the EnableAvailabilityZonesForLoadBalancer service method, as returned by ElasticLoadBalancing.</returns>
        /// <exception cref="T:Amazon.ElasticLoadBalancing.Model.AccessPointNotFoundException">
        /// The specified load balancer could not be found.
        /// </exception>
		public EnableAvailabilityZonesForLoadBalancerResponse EnableAvailabilityZonesForLoadBalancer(EnableAvailabilityZonesForLoadBalancerRequest request)
        {
            var task = EnableAvailabilityZonesForLoadBalancerAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }
          
        /// <summary>
        /// Initiates the asynchronous execution of the EnableAvailabilityZonesForLoadBalancer operation.
        /// <seealso cref="Amazon.ElasticLoadBalancing.IAmazonElasticLoadBalancing.EnableAvailabilityZonesForLoadBalancer"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the EnableAvailabilityZonesForLoadBalancer operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public Task<EnableAvailabilityZonesForLoadBalancerResponse> EnableAvailabilityZonesForLoadBalancerAsync(EnableAvailabilityZonesForLoadBalancerRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new EnableAvailabilityZonesForLoadBalancerRequestMarshaller();
            var unmarshaller = EnableAvailabilityZonesForLoadBalancerResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, EnableAvailabilityZonesForLoadBalancerRequest, EnableAvailabilityZonesForLoadBalancerResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
        }
 
        /// <summary>
        /// Modifies the attributes of a specified load balancer.
        /// 
        /// 
        /// <para>
        /// You can modify the load balancer attributes, such as <code>AccessLogs</code>, <code>ConnectionDraining</code>,
        /// and <code>CrossZoneLoadBalancing</code> by either enabling or disabling them. Or,
        /// you can modify the load balancer attribute <code>ConnectionSettings</code> by specifying
        /// an idle connection timeout value for your load balancer.
        /// </para>
        /// 
        /// <para>
        /// For more information, see the following:
        /// </para>
        /// <ul> <li><a href="http://docs.aws.amazon.com/ElasticLoadBalancing/latest/DeveloperGuide/TerminologyandKeyConcepts.html#request-routing">Cross-Zone
        /// Load Balancing</a></li> <li><a href="http://docs.aws.amazon.com/ElasticLoadBalancing/latest/DeveloperGuide/TerminologyandKeyConcepts.html#conn-drain">Connection
        /// Draining</a></li> <li><a href="http://docs.aws.amazon.com/ElasticLoadBalancing/latest/DeveloperGuide/access-log-collection.html">Access
        /// Logs</a></li> <li><a href="http://docs.aws.amazon.com/ElasticLoadBalancing/latest/DeveloperGuide/TerminologyandKeyConcepts.html#idle-timeout">Idle
        /// Connection Timeout</a></li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyLoadBalancerAttributes service method.</param>
        /// 
        /// <returns>The response from the ModifyLoadBalancerAttributes service method, as returned by ElasticLoadBalancing.</returns>
        /// <exception cref="T:Amazon.ElasticLoadBalancing.Model.AccessPointNotFoundException">
        /// The specified load balancer could not be found.
        /// </exception>
        /// <exception cref="T:Amazon.ElasticLoadBalancing.Model.InvalidConfigurationRequestException">
        /// Requested configuration change is invalid.
        /// </exception>
        /// <exception cref="T:Amazon.ElasticLoadBalancing.Model.LoadBalancerAttributeNotFoundException">
        /// The specified load balancer attribute could not be found.
        /// </exception>
		public ModifyLoadBalancerAttributesResponse ModifyLoadBalancerAttributes(ModifyLoadBalancerAttributesRequest request)
        {
            var task = ModifyLoadBalancerAttributesAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }
          
        /// <summary>
        /// Initiates the asynchronous execution of the ModifyLoadBalancerAttributes operation.
        /// <seealso cref="Amazon.ElasticLoadBalancing.IAmazonElasticLoadBalancing.ModifyLoadBalancerAttributes"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyLoadBalancerAttributes operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public Task<ModifyLoadBalancerAttributesResponse> ModifyLoadBalancerAttributesAsync(ModifyLoadBalancerAttributesRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ModifyLoadBalancerAttributesRequestMarshaller();
            var unmarshaller = ModifyLoadBalancerAttributesResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, ModifyLoadBalancerAttributesRequest, ModifyLoadBalancerAttributesResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
        }
 
        /// <summary>
        /// Adds new instances to the load balancer.
        /// 
        /// 
        /// <para>
        /// Once the instance is registered, it starts receiving traffic and requests from the
        /// load balancer. Any instance that is not in any of the Availability Zones registered
        /// for the load balancer will be moved to the <i>OutOfService</i> state. It will move
        /// to the <i>InService</i> state when the Availability Zone is added to the load balancer.
        /// 
        /// </para>
        /// 
        /// <para>
        /// When an instance registered with a load balancer is stopped and then restarted, the
        /// IP addresses associated with the instance changes. Elastic Load Balancing cannot recognize
        /// the new IP address, which prevents it from routing traffic to the instances. We recommend
        /// that you de-register your Amazon EC2 instances from your load balancer after you stop
        /// your instance, and then register the load balancer with your instance after you've
        /// restarted. To de-register your instances from load balancer, use <a>DeregisterInstancesFromLoadBalancer</a>
        /// action.
        /// </para>
        /// 
        /// <para>
        /// For more information, see <a href="http://docs.aws.amazon.com/ElasticLoadBalancing/latest/DeveloperGuide/US_DeReg_Reg_Instances.html">De-register
        /// and Register Amazon EC2 Instances</a> in the <i>Elastic Load Balancing Developer Guide</i>.
        /// </para>
        /// 
        /// <para>
        /// You can use <a>DescribeLoadBalancers</a> or <a>DescribeInstanceHealth</a> action to
        /// check the state of the newly registered instances.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RegisterInstancesWithLoadBalancer service method.</param>
        /// 
        /// <returns>The response from the RegisterInstancesWithLoadBalancer service method, as returned by ElasticLoadBalancing.</returns>
        /// <exception cref="T:Amazon.ElasticLoadBalancing.Model.AccessPointNotFoundException">
        /// The specified load balancer could not be found.
        /// </exception>
        /// <exception cref="T:Amazon.ElasticLoadBalancing.Model.InvalidEndPointException">
        /// The specified EndPoint is not valid.
        /// </exception>
		public RegisterInstancesWithLoadBalancerResponse RegisterInstancesWithLoadBalancer(RegisterInstancesWithLoadBalancerRequest request)
        {
            var task = RegisterInstancesWithLoadBalancerAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }
          
        /// <summary>
        /// Initiates the asynchronous execution of the RegisterInstancesWithLoadBalancer operation.
        /// <seealso cref="Amazon.ElasticLoadBalancing.IAmazonElasticLoadBalancing.RegisterInstancesWithLoadBalancer"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RegisterInstancesWithLoadBalancer operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public Task<RegisterInstancesWithLoadBalancerResponse> RegisterInstancesWithLoadBalancerAsync(RegisterInstancesWithLoadBalancerRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new RegisterInstancesWithLoadBalancerRequestMarshaller();
            var unmarshaller = RegisterInstancesWithLoadBalancerResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, RegisterInstancesWithLoadBalancerRequest, RegisterInstancesWithLoadBalancerResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
        }
 
        /// <summary>
        /// Removes one or more tags from the specified load balancer.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RemoveTags service method.</param>
        /// 
        /// <returns>The response from the RemoveTags service method, as returned by ElasticLoadBalancing.</returns>
        /// <exception cref="T:Amazon.ElasticLoadBalancing.Model.AccessPointNotFoundException">
        /// The specified load balancer could not be found.
        /// </exception>
		public RemoveTagsResponse RemoveTags(RemoveTagsRequest request)
        {
            var task = RemoveTagsAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }
          
        /// <summary>
        /// Initiates the asynchronous execution of the RemoveTags operation.
        /// <seealso cref="Amazon.ElasticLoadBalancing.IAmazonElasticLoadBalancing.RemoveTags"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RemoveTags operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public Task<RemoveTagsResponse> RemoveTagsAsync(RemoveTagsRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new RemoveTagsRequestMarshaller();
            var unmarshaller = RemoveTagsResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, RemoveTagsRequest, RemoveTagsResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
        }
 
        /// <summary>
        /// Sets the certificate that terminates the specified listener's SSL connections. The
        /// specified certificate replaces any prior certificate that was used on the same load
        /// balancer and port.
        /// 
        /// 
        /// <para>
        /// For more information on updating your SSL certificate, see <a href="http://docs.aws.amazon.com/ElasticLoadBalancing/latest/DeveloperGuide/US_UpdatingLoadBalancerSSL.html">Updating
        /// an SSL Certificate for a Load Balancer</a> in the <i>Elastic Load Balancing Developer
        /// Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SetLoadBalancerListenerSSLCertificate service method.</param>
        /// 
        /// <returns>The response from the SetLoadBalancerListenerSSLCertificate service method, as returned by ElasticLoadBalancing.</returns>
        /// <exception cref="T:Amazon.ElasticLoadBalancing.Model.AccessPointNotFoundException">
        /// The specified load balancer could not be found.
        /// </exception>
        /// <exception cref="T:Amazon.ElasticLoadBalancing.Model.CertificateNotFoundException">
        /// The specified SSL ID does not refer to a valid SSL certificate in the AWS Identity
        /// and Access Management Service.
        /// </exception>
        /// <exception cref="T:Amazon.ElasticLoadBalancing.Model.InvalidConfigurationRequestException">
        /// Requested configuration change is invalid.
        /// </exception>
        /// <exception cref="T:Amazon.ElasticLoadBalancing.Model.ListenerNotFoundException">
        /// Load balancer does not have a listener configured at the given port.
        /// </exception>
		public SetLoadBalancerListenerSSLCertificateResponse SetLoadBalancerListenerSSLCertificate(SetLoadBalancerListenerSSLCertificateRequest request)
        {
            var task = SetLoadBalancerListenerSSLCertificateAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }
          
        /// <summary>
        /// Initiates the asynchronous execution of the SetLoadBalancerListenerSSLCertificate operation.
        /// <seealso cref="Amazon.ElasticLoadBalancing.IAmazonElasticLoadBalancing.SetLoadBalancerListenerSSLCertificate"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SetLoadBalancerListenerSSLCertificate operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public Task<SetLoadBalancerListenerSSLCertificateResponse> SetLoadBalancerListenerSSLCertificateAsync(SetLoadBalancerListenerSSLCertificateRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new SetLoadBalancerListenerSSLCertificateRequestMarshaller();
            var unmarshaller = SetLoadBalancerListenerSSLCertificateResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, SetLoadBalancerListenerSSLCertificateRequest, SetLoadBalancerListenerSSLCertificateResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
        }
 
        /// <summary>
        /// Replaces the current set of policies associated with a port on which the back-end
        /// server is listening with a new set of policies. After the policies have been created
        /// using <a>CreateLoadBalancerPolicy</a>, they can be applied here as a list. At this
        /// time, only the back-end server authentication policy type can be applied to the back-end
        /// ports; this policy type is composed of multiple public key policies.
        /// 
        /// 
        /// <para>
        /// You can use <a>DescribeLoadBalancers</a> or <a>DescribeLoadBalancerPolicies</a> action
        /// to verify that the policy has been associated with the back-end server.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SetLoadBalancerPoliciesForBackendServer service method.</param>
        /// 
        /// <returns>The response from the SetLoadBalancerPoliciesForBackendServer service method, as returned by ElasticLoadBalancing.</returns>
        /// <exception cref="T:Amazon.ElasticLoadBalancing.Model.AccessPointNotFoundException">
        /// The specified load balancer could not be found.
        /// </exception>
        /// <exception cref="T:Amazon.ElasticLoadBalancing.Model.InvalidConfigurationRequestException">
        /// Requested configuration change is invalid.
        /// </exception>
        /// <exception cref="T:Amazon.ElasticLoadBalancing.Model.PolicyNotFoundException">
        /// One or more specified policies were not found.
        /// </exception>
		public SetLoadBalancerPoliciesForBackendServerResponse SetLoadBalancerPoliciesForBackendServer(SetLoadBalancerPoliciesForBackendServerRequest request)
        {
            var task = SetLoadBalancerPoliciesForBackendServerAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }
          
        /// <summary>
        /// Initiates the asynchronous execution of the SetLoadBalancerPoliciesForBackendServer operation.
        /// <seealso cref="Amazon.ElasticLoadBalancing.IAmazonElasticLoadBalancing.SetLoadBalancerPoliciesForBackendServer"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SetLoadBalancerPoliciesForBackendServer operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public Task<SetLoadBalancerPoliciesForBackendServerResponse> SetLoadBalancerPoliciesForBackendServerAsync(SetLoadBalancerPoliciesForBackendServerRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new SetLoadBalancerPoliciesForBackendServerRequestMarshaller();
            var unmarshaller = SetLoadBalancerPoliciesForBackendServerResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, SetLoadBalancerPoliciesForBackendServerRequest, SetLoadBalancerPoliciesForBackendServerResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
        }
 
        /// <summary>
        /// Associates, updates, or disables a policy with a listener on the load balancer. You
        /// can associate multiple policies with a listener.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SetLoadBalancerPoliciesOfListener service method.</param>
        /// 
        /// <returns>The response from the SetLoadBalancerPoliciesOfListener service method, as returned by ElasticLoadBalancing.</returns>
        /// <exception cref="T:Amazon.ElasticLoadBalancing.Model.AccessPointNotFoundException">
        /// The specified load balancer could not be found.
        /// </exception>
        /// <exception cref="T:Amazon.ElasticLoadBalancing.Model.InvalidConfigurationRequestException">
        /// Requested configuration change is invalid.
        /// </exception>
        /// <exception cref="T:Amazon.ElasticLoadBalancing.Model.ListenerNotFoundException">
        /// Load balancer does not have a listener configured at the given port.
        /// </exception>
        /// <exception cref="T:Amazon.ElasticLoadBalancing.Model.PolicyNotFoundException">
        /// One or more specified policies were not found.
        /// </exception>
		public SetLoadBalancerPoliciesOfListenerResponse SetLoadBalancerPoliciesOfListener(SetLoadBalancerPoliciesOfListenerRequest request)
        {
            var task = SetLoadBalancerPoliciesOfListenerAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }
          
        /// <summary>
        /// Initiates the asynchronous execution of the SetLoadBalancerPoliciesOfListener operation.
        /// <seealso cref="Amazon.ElasticLoadBalancing.IAmazonElasticLoadBalancing.SetLoadBalancerPoliciesOfListener"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SetLoadBalancerPoliciesOfListener operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public Task<SetLoadBalancerPoliciesOfListenerResponse> SetLoadBalancerPoliciesOfListenerAsync(SetLoadBalancerPoliciesOfListenerRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new SetLoadBalancerPoliciesOfListenerRequestMarshaller();
            var unmarshaller = SetLoadBalancerPoliciesOfListenerResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, SetLoadBalancerPoliciesOfListenerRequest, SetLoadBalancerPoliciesOfListenerResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
        }
    }
}
