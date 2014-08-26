/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Route53Domains.Model;

namespace Amazon.Route53Domains
{
    /// <summary>
    /// Implementation for accessing Route53Domains
    ///
    /// 
    /// </summary>
    public partial interface IAmazonRoute53Domains : IDisposable
    {

        
        #region  CheckDomainAvailability


        /// <summary>
        /// This operation checks the availability of one domain name. You can access this API
        /// without authenticating. Note that if the availability status of a domain is pending,
        /// you must submit another request to determine the availability of the domain name.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CheckDomainAvailability service method.</param>
        /// 
        /// <returns>The response from the CheckDomainAvailability service method, as returned by Route53Domains.</returns>
        /// <exception cref="InvalidInputException">
        /// The requested item is not acceptable. For example, for an OperationId it may refer
        /// to the ID of an operation that is already completed. For a domain name, it may not
        /// be a valid domain name or belong to the requester account.
        /// </exception>
        /// <exception cref="UnsupportedTLDException">
        /// Amazon Route 53 does not support this top-level domain.
        /// </exception>
        CheckDomainAvailabilityResponse CheckDomainAvailability(CheckDomainAvailabilityRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CheckDomainAvailability operation.
        /// <seealso cref="Amazon.Route53Domains.IAmazonRoute53Domains"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CheckDomainAvailability operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<CheckDomainAvailabilityResponse> CheckDomainAvailabilityAsync(CheckDomainAvailabilityRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DisableDomainTransferLock


        /// <summary>
        /// This operation removes the transfer lock on the domain (specifically the <code>clientTransferProhibited</code>
        /// status) to allow domain transfers. We recommend you refrain from performing this action
        /// unless you intend to transfer the domain to a different registrar. Successful submission
        /// returns an operation ID that you can use to track the progress and completion of the
        /// action. If the request is not completed successfully, the domain registrant will be
        /// notified by email.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisableDomainTransferLock service method.</param>
        /// 
        /// <returns>The response from the DisableDomainTransferLock service method, as returned by Route53Domains.</returns>
        /// <exception cref="DuplicateRequestException">
        /// The request is already in progress for the domain.
        /// </exception>
        /// <exception cref="InvalidInputException">
        /// The requested item is not acceptable. For example, for an OperationId it may refer
        /// to the ID of an operation that is already completed. For a domain name, it may not
        /// be a valid domain name or belong to the requester account.
        /// </exception>
        /// <exception cref="OperationLimitExceededException">
        /// The number of operations or jobs running exceeded the allowed threshold for the account.
        /// </exception>
        /// <exception cref="TLDRulesViolationException">
        /// The top-level domain does not support this operation.
        /// </exception>
        DisableDomainTransferLockResponse DisableDomainTransferLock(DisableDomainTransferLockRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DisableDomainTransferLock operation.
        /// <seealso cref="Amazon.Route53Domains.IAmazonRoute53Domains"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisableDomainTransferLock operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DisableDomainTransferLockResponse> DisableDomainTransferLockAsync(DisableDomainTransferLockRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  EnableDomainTransferLock


        /// <summary>
        /// This operation sets the transfer lock on the domain (specifically the <code>clientTransferProhibited</code>
        /// status) to prevent domain transfers. Successful submission returns an operation ID
        /// that you can use to track the progress and completion of the action. If the request
        /// is not completed successfully, the domain registrant will be notified by email.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EnableDomainTransferLock service method.</param>
        /// 
        /// <returns>The response from the EnableDomainTransferLock service method, as returned by Route53Domains.</returns>
        /// <exception cref="DuplicateRequestException">
        /// The request is already in progress for the domain.
        /// </exception>
        /// <exception cref="InvalidInputException">
        /// The requested item is not acceptable. For example, for an OperationId it may refer
        /// to the ID of an operation that is already completed. For a domain name, it may not
        /// be a valid domain name or belong to the requester account.
        /// </exception>
        /// <exception cref="OperationLimitExceededException">
        /// The number of operations or jobs running exceeded the allowed threshold for the account.
        /// </exception>
        /// <exception cref="TLDRulesViolationException">
        /// The top-level domain does not support this operation.
        /// </exception>
        EnableDomainTransferLockResponse EnableDomainTransferLock(EnableDomainTransferLockRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the EnableDomainTransferLock operation.
        /// <seealso cref="Amazon.Route53Domains.IAmazonRoute53Domains"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the EnableDomainTransferLock operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<EnableDomainTransferLockResponse> EnableDomainTransferLockAsync(EnableDomainTransferLockRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetDomainDetail


        /// <summary>
        /// This operation returns detailed information about the domain. The domain's contact
        /// information is also returned as part of the output.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDomainDetail service method.</param>
        /// 
        /// <returns>The response from the GetDomainDetail service method, as returned by Route53Domains.</returns>
        /// <exception cref="InvalidInputException">
        /// The requested item is not acceptable. For example, for an OperationId it may refer
        /// to the ID of an operation that is already completed. For a domain name, it may not
        /// be a valid domain name or belong to the requester account.
        /// </exception>
        GetDomainDetailResponse GetDomainDetail(GetDomainDetailRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetDomainDetail operation.
        /// <seealso cref="Amazon.Route53Domains.IAmazonRoute53Domains"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDomainDetail operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<GetDomainDetailResponse> GetDomainDetailAsync(GetDomainDetailRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetOperationDetail


        /// <summary>
        /// This operation returns the current status of an operation that is not completed.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetOperationDetail service method.</param>
        /// 
        /// <returns>The response from the GetOperationDetail service method, as returned by Route53Domains.</returns>
        /// <exception cref="InvalidInputException">
        /// The requested item is not acceptable. For example, for an OperationId it may refer
        /// to the ID of an operation that is already completed. For a domain name, it may not
        /// be a valid domain name or belong to the requester account.
        /// </exception>
        GetOperationDetailResponse GetOperationDetail(GetOperationDetailRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetOperationDetail operation.
        /// <seealso cref="Amazon.Route53Domains.IAmazonRoute53Domains"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetOperationDetail operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<GetOperationDetailResponse> GetOperationDetailAsync(GetOperationDetailRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListDomains

        /// <summary>
        /// This operation returns all the domain names registered with Amazon Route 53 for the
        /// current AWS account.
        /// </summary>
        /// 
        /// <returns>The response from the ListDomains service method, as returned by Route53Domains.</returns>
        /// <exception cref="InvalidInputException">
        /// The requested item is not acceptable. For example, for an OperationId it may refer
        /// to the ID of an operation that is already completed. For a domain name, it may not
        /// be a valid domain name or belong to the requester account.
        /// </exception>
        ListDomainsResponse ListDomains();

        /// <summary>
        /// This operation returns all the domain names registered with Amazon Route 53 for the
        /// current AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDomains service method.</param>
        /// 
        /// <returns>The response from the ListDomains service method, as returned by Route53Domains.</returns>
        /// <exception cref="InvalidInputException">
        /// The requested item is not acceptable. For example, for an OperationId it may refer
        /// to the ID of an operation that is already completed. For a domain name, it may not
        /// be a valid domain name or belong to the requester account.
        /// </exception>
        ListDomainsResponse ListDomains(ListDomainsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListDomains operation.
        /// <seealso cref="Amazon.Route53Domains.IAmazonRoute53Domains"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDomains operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<ListDomainsResponse> ListDomainsAsync(ListDomainsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListOperations

        /// <summary>
        /// This operation returns the operation IDs of operations that are not yet complete.
        /// </summary>
        /// 
        /// <returns>The response from the ListOperations service method, as returned by Route53Domains.</returns>
        /// <exception cref="InvalidInputException">
        /// The requested item is not acceptable. For example, for an OperationId it may refer
        /// to the ID of an operation that is already completed. For a domain name, it may not
        /// be a valid domain name or belong to the requester account.
        /// </exception>
        ListOperationsResponse ListOperations();

        /// <summary>
        /// This operation returns the operation IDs of operations that are not yet complete.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListOperations service method.</param>
        /// 
        /// <returns>The response from the ListOperations service method, as returned by Route53Domains.</returns>
        /// <exception cref="InvalidInputException">
        /// The requested item is not acceptable. For example, for an OperationId it may refer
        /// to the ID of an operation that is already completed. For a domain name, it may not
        /// be a valid domain name or belong to the requester account.
        /// </exception>
        ListOperationsResponse ListOperations(ListOperationsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListOperations operation.
        /// <seealso cref="Amazon.Route53Domains.IAmazonRoute53Domains"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListOperations operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<ListOperationsResponse> ListOperationsAsync(ListOperationsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  RegisterDomain


        /// <summary>
        /// This operation registers a domain. Domains are registered by the AWS registrar partner,
        /// Gandi. For some top-level domains (TLDs), this operation requires extra parameters.
        /// 
        ///  
        /// <para>
        /// When you register a domain, Amazon Route 53 does the following:
        /// </para>
        ///  <ul> <li>Creates a Amazon Route 53 hosted zone that has the same name as the domain.
        /// Amazon Route 53 assigns four name servers to your hosted zone and automatically updates
        /// your domain registration with the names of these name servers.</li> <li>Enables autorenew,
        /// so your domain registration will renew automatically each year. We'll notify you in
        /// advance of the renewal date so you can choose whether to renew the registration.</li>
        /// <li>Optionally enables privacy protection, so WHOIS queries return contact information
        /// for our registrar partner, Gandi, instead of the information you entered for registrant,
        /// admin, and tech contacts.</li> <li>If registration is successful, returns an operation
        /// ID that you can use to track the progress and completion of the action. If the request
        /// is not completed successfully, the domain registrant is notified by email.</li> <li>Charges
        /// your AWS account an amount based on the top-level domain. For more information, see
        /// <a href="http://aws.amazon.com/route53/pricing/">Amazon Route 53 Pricing</a>.</li>
        /// </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RegisterDomain service method.</param>
        /// 
        /// <returns>The response from the RegisterDomain service method, as returned by Route53Domains.</returns>
        /// <exception cref="DomainLimitExceededException">
        /// The number of domains has exceeded the allowed threshold for the account.
        /// </exception>
        /// <exception cref="DuplicateRequestException">
        /// The request is already in progress for the domain.
        /// </exception>
        /// <exception cref="InvalidInputException">
        /// The requested item is not acceptable. For example, for an OperationId it may refer
        /// to the ID of an operation that is already completed. For a domain name, it may not
        /// be a valid domain name or belong to the requester account.
        /// </exception>
        /// <exception cref="OperationLimitExceededException">
        /// The number of operations or jobs running exceeded the allowed threshold for the account.
        /// </exception>
        /// <exception cref="TLDRulesViolationException">
        /// The top-level domain does not support this operation.
        /// </exception>
        /// <exception cref="UnsupportedTLDException">
        /// Amazon Route 53 does not support this top-level domain.
        /// </exception>
        RegisterDomainResponse RegisterDomain(RegisterDomainRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the RegisterDomain operation.
        /// <seealso cref="Amazon.Route53Domains.IAmazonRoute53Domains"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RegisterDomain operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<RegisterDomainResponse> RegisterDomainAsync(RegisterDomainRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  RetrieveDomainAuthCode


        /// <summary>
        /// This operation returns the AuthCode for the domain. To transfer a domain to another
        /// registrar, you provide this value to the new registrar.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RetrieveDomainAuthCode service method.</param>
        /// 
        /// <returns>The response from the RetrieveDomainAuthCode service method, as returned by Route53Domains.</returns>
        /// <exception cref="InvalidInputException">
        /// The requested item is not acceptable. For example, for an OperationId it may refer
        /// to the ID of an operation that is already completed. For a domain name, it may not
        /// be a valid domain name or belong to the requester account.
        /// </exception>
        RetrieveDomainAuthCodeResponse RetrieveDomainAuthCode(RetrieveDomainAuthCodeRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the RetrieveDomainAuthCode operation.
        /// <seealso cref="Amazon.Route53Domains.IAmazonRoute53Domains"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RetrieveDomainAuthCode operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<RetrieveDomainAuthCodeResponse> RetrieveDomainAuthCodeAsync(RetrieveDomainAuthCodeRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  TransferDomain


        /// <summary>
        /// This operation transfers a domain from another registrar to Amazon Route 53. Domains
        /// are registered by the AWS registrar, Gandi upon transfer.
        /// 
        ///  
        /// <para>
        /// To transfer a domain, you need to meet all the domain transfer criteria, including
        /// the following:
        /// </para>
        ///  <ul> <li>You must supply nameservers to transfer a domain.</li> <li>You must disable
        /// the domain transfer lock (if any) before transferring the domain.</li> <li>A minimum
        /// of 60 days must have elapsed since the domain's registration or last transfer.</li>
        /// </ul> 
        /// <para>
        /// We recommend you use the Amazon Route 53 as the DNS service for your domain. You can
        /// create a hosted zone in Amazon Route 53 for your current domain before transferring
        /// your domain.
        /// </para>
        ///  
        /// <para>
        /// Note that upon transfer, the domain duration is extended for a year if not otherwise
        /// specified. Autorenew is enabled by default.
        /// </para>
        ///  
        /// <para>
        /// If the transfer is successful, this method returns an operation ID that you can use
        /// to track the progress and completion of the action. If the request is not completed
        /// successfully, the domain registrant will be notified by email.
        /// </para>
        ///  
        /// <para>
        /// Transferring domains charges your AWS account an amount based on the top-level domain.
        /// For more information, see <a href="http://aws.amazon.com/route53/pricing/">Amazon
        /// Route 53 Pricing</a>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TransferDomain service method.</param>
        /// 
        /// <returns>The response from the TransferDomain service method, as returned by Route53Domains.</returns>
        /// <exception cref="DomainLimitExceededException">
        /// The number of domains has exceeded the allowed threshold for the account.
        /// </exception>
        /// <exception cref="DuplicateRequestException">
        /// The request is already in progress for the domain.
        /// </exception>
        /// <exception cref="InvalidInputException">
        /// The requested item is not acceptable. For example, for an OperationId it may refer
        /// to the ID of an operation that is already completed. For a domain name, it may not
        /// be a valid domain name or belong to the requester account.
        /// </exception>
        /// <exception cref="OperationLimitExceededException">
        /// The number of operations or jobs running exceeded the allowed threshold for the account.
        /// </exception>
        /// <exception cref="TLDRulesViolationException">
        /// The top-level domain does not support this operation.
        /// </exception>
        /// <exception cref="UnsupportedTLDException">
        /// Amazon Route 53 does not support this top-level domain.
        /// </exception>
        TransferDomainResponse TransferDomain(TransferDomainRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the TransferDomain operation.
        /// <seealso cref="Amazon.Route53Domains.IAmazonRoute53Domains"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TransferDomain operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<TransferDomainResponse> TransferDomainAsync(TransferDomainRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateDomainContact


        /// <summary>
        /// This operation updates the contact information for a particular domain. Information
        /// for at least one contact (registrant, administrator, or technical) must be supplied
        /// for update.
        /// 
        ///  
        /// <para>
        /// If the update is successful, this method returns an operation ID that you can use
        /// to track the progress and completion of the action. If the request is not completed
        /// successfully, the domain registrant will be notified by email.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDomainContact service method.</param>
        /// 
        /// <returns>The response from the UpdateDomainContact service method, as returned by Route53Domains.</returns>
        /// <exception cref="DuplicateRequestException">
        /// The request is already in progress for the domain.
        /// </exception>
        /// <exception cref="InvalidInputException">
        /// The requested item is not acceptable. For example, for an OperationId it may refer
        /// to the ID of an operation that is already completed. For a domain name, it may not
        /// be a valid domain name or belong to the requester account.
        /// </exception>
        /// <exception cref="OperationLimitExceededException">
        /// The number of operations or jobs running exceeded the allowed threshold for the account.
        /// </exception>
        /// <exception cref="TLDRulesViolationException">
        /// The top-level domain does not support this operation.
        /// </exception>
        UpdateDomainContactResponse UpdateDomainContact(UpdateDomainContactRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateDomainContact operation.
        /// <seealso cref="Amazon.Route53Domains.IAmazonRoute53Domains"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateDomainContact operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<UpdateDomainContactResponse> UpdateDomainContactAsync(UpdateDomainContactRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateDomainContactPrivacy


        /// <summary>
        /// This operation updates the specified domain contact's privacy setting. When the privacy
        /// option is enabled, personal information such as postal or email address is hidden
        /// from the results of a public WHOIS query. The privacy services are provided by the
        /// AWS registrar, Gandi. For more information, see the <a href="http://www.gandi.net/domain/whois/?currency=USD&amp;lang=en">Gandi
        /// privacy features</a>.
        /// 
        ///  
        /// <para>
        /// This operation only affects the privacy of the specified contact type (registrant,
        /// administrator, or tech). Successful acceptance returns an operation ID that you can
        /// use with GetOperationDetail to track the progress and completion of the action. If
        /// the request is not completed successfully, the domain registrant will be notified
        /// by email.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDomainContactPrivacy service method.</param>
        /// 
        /// <returns>The response from the UpdateDomainContactPrivacy service method, as returned by Route53Domains.</returns>
        /// <exception cref="DuplicateRequestException">
        /// The request is already in progress for the domain.
        /// </exception>
        /// <exception cref="InvalidInputException">
        /// The requested item is not acceptable. For example, for an OperationId it may refer
        /// to the ID of an operation that is already completed. For a domain name, it may not
        /// be a valid domain name or belong to the requester account.
        /// </exception>
        /// <exception cref="OperationLimitExceededException">
        /// The number of operations or jobs running exceeded the allowed threshold for the account.
        /// </exception>
        /// <exception cref="TLDRulesViolationException">
        /// The top-level domain does not support this operation.
        /// </exception>
        UpdateDomainContactPrivacyResponse UpdateDomainContactPrivacy(UpdateDomainContactPrivacyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateDomainContactPrivacy operation.
        /// <seealso cref="Amazon.Route53Domains.IAmazonRoute53Domains"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateDomainContactPrivacy operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<UpdateDomainContactPrivacyResponse> UpdateDomainContactPrivacyAsync(UpdateDomainContactPrivacyRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateDomainNameservers


        /// <summary>
        /// This operation replaces the current set of name servers for the domain with the specified
        /// set of name servers. If you use Amazon Route 53 as your DNS service, specify the four
        /// name servers in the delegation set for the hosted zone for the domain. 
        /// 
        ///  
        /// <para>
        /// If successful, this operation returns an operation ID that you can use to track the
        /// progress and completion of the action. If the request is not completed successfully,
        /// the domain registrant will be notified by email.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDomainNameservers service method.</param>
        /// 
        /// <returns>The response from the UpdateDomainNameservers service method, as returned by Route53Domains.</returns>
        /// <exception cref="DuplicateRequestException">
        /// The request is already in progress for the domain.
        /// </exception>
        /// <exception cref="InvalidInputException">
        /// The requested item is not acceptable. For example, for an OperationId it may refer
        /// to the ID of an operation that is already completed. For a domain name, it may not
        /// be a valid domain name or belong to the requester account.
        /// </exception>
        /// <exception cref="OperationLimitExceededException">
        /// The number of operations or jobs running exceeded the allowed threshold for the account.
        /// </exception>
        /// <exception cref="TLDRulesViolationException">
        /// The top-level domain does not support this operation.
        /// </exception>
        UpdateDomainNameserversResponse UpdateDomainNameservers(UpdateDomainNameserversRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateDomainNameservers operation.
        /// <seealso cref="Amazon.Route53Domains.IAmazonRoute53Domains"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateDomainNameservers operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<UpdateDomainNameserversResponse> UpdateDomainNameserversAsync(UpdateDomainNameserversRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}