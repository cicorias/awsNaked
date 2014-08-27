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

using Amazon.AWSSupport.Model;

namespace Amazon.AWSSupport
{
    /// <summary>
    /// Implementation for accessing AWSSupport
    ///
    /// AWS Support            
    /// <para>
    /// The AWS Support API reference is intended for programmers who need detailed information
    /// about the AWS Support operations and data types. This service enables you to manage
    /// your AWS Support cases programmatically. It uses HTTP methods that return results
    /// in JSON format.
    /// </para>
    ///         
    /// <para>
    /// The AWS Support service also exposes a set of <a href="https://aws.amazon.com/support/trustedadvisor">Trusted
    /// Advisor</a> features. You can retrieve a list of checks and their descriptions, get
    /// check results, specify checks to refresh, and get the refresh status of checks. 
    /// </para>
    ///          
    /// <para>
    /// The following list describes the AWS Support case management operations: 
    /// </para>
    ///     <ul>      <li><b>Service names, issue categories, and available severity levels.
    /// </b>The <a>DescribeServices</a> and <a>DescribeSeverityLevels</a> operations return
    /// AWS service names, service codes, service categories, and problem severity levels.
    /// You use these values when you call the <a>CreateCase</a> operation. </li>      <li><b>Case
    /// creation, case details, and case resolution.</b> The <a>CreateCase</a>, <a>DescribeCases</a>,
    /// <a>DescribeAttachment</a>, and <a>ResolveCase</a> operations create AWS Support cases,
    /// retrieve information about cases, and resolve cases.</li>      <li><b>Case communication.</b>
    /// The <a>DescribeCommunications</a>, <a>AddCommunicationToCase</a>, and <a>AddAttachmentsToSet</a>
    /// operations retrieve and add communications and attachments to AWS Support cases. </li>
    ///    </ul>        
    /// <para>
    /// The following list describes the operations available from the AWS Support service
    /// for  Trusted Advisor:
    /// </para>
    ///     <ul>      <li><a>DescribeTrustedAdvisorChecks</a> returns the list of checks that
    /// run against your AWS resources.</li>       <li>Using the <code>CheckId</code> for
    /// a specific check returned by <a>DescribeTrustedAdvisorChecks</a>, you can call <a>DescribeTrustedAdvisorCheckResult</a>
    /// to obtain the results for the check you specified.</li>       <li><a>DescribeTrustedAdvisorCheckSummaries</a>
    /// returns summarized results for one or more Trusted Advisor checks.</li>      <li><a>RefreshTrustedAdvisorCheck</a>
    /// requests that Trusted Advisor rerun a specified check. </li>      <li><a>DescribeTrustedAdvisorCheckRefreshStatuses</a>
    /// reports the refresh status of one or more checks.  </li>    </ul>            
    /// <para>
    /// For authentication of requests, AWS Support uses <a href="http://docs.aws.amazon.com/general/latest/gr/signature-version-4.html">Signature
    /// Version 4 Signing Process</a>.
    /// </para>
    ///         
    /// <para>
    /// See <a href="http://docs.aws.amazon.com/awssupport/latest/user/Welcome.html">About
    /// the AWS Support API</a> in the <i>AWS Support User Guide</i> for information about
    /// how to use this service to create and manage your support cases, and how to call Trusted
    /// Advisor for results of checks on your resources. 
    /// </para>
    /// </summary>
    public partial interface IAmazonAWSSupport : IDisposable
    {

        
        #region  AddAttachmentsToSet


        /// <summary>
        /// Adds one or more attachments to an attachment set. If an <code>AttachmentSetId</code>
        /// is not specified, a new attachment set is created, and the ID of the set is returned
        /// in the response. If an <code>AttachmentSetId</code> is specified, the attachments
        /// are added to the specified set, if it exists.
        /// 
        ///     
        /// <para>
        /// An attachment set is a temporary container for attachments that are to be added to
        /// a case or case communication. The set is available for one hour after it is created;
        /// the <code>ExpiryTime</code> returned in the response indicates when the set expires.
        /// The maximum number of attachments in a set is 3, and the maximum size of any attachment
        /// in the set is 5 MB.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddAttachmentsToSet service method.</param>
        /// 
        /// <returns>The response from the AddAttachmentsToSet service method, as returned by AWSSupport.</returns>
        /// <exception cref="AttachmentLimitExceededException">
        /// The limit for the number of attachment sets created in a short period of time has
        /// been exceeded.
        /// </exception>
        /// <exception cref="AttachmentSetExpiredException">
        /// The expiration time of the attachment set has passed. The set expires 1 hour after
        /// it is created.
        /// </exception>
        /// <exception cref="AttachmentSetIdNotFoundException">
        /// An attachment set with the specified ID could not be found.
        /// </exception>
        /// <exception cref="AttachmentSetSizeLimitExceededException">
        /// A limit for the size of an attachment set has been exceeded. The limits are 3 attachments
        /// and 5 MB per attachment.
        /// </exception>
        /// <exception cref="InternalServerErrorException">
        /// An internal server error occurred.
        /// </exception>
        AddAttachmentsToSetResponse AddAttachmentsToSet(AddAttachmentsToSetRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the AddAttachmentsToSet operation.
        /// <seealso cref="Amazon.AWSSupport.IAmazonAWSSupport"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AddAttachmentsToSet operation on AmazonAWSSupportClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAddAttachmentsToSet
        ///         operation.</returns>
        IAsyncResult BeginAddAttachmentsToSet(AddAttachmentsToSetRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  AddAttachmentsToSet operation.
        /// <seealso cref="Amazon.AWSSupport.IAmazonAWSSupport"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAddAttachmentsToSet.</param>
        /// 
        /// <returns>Returns a  AddAttachmentsToSetResult from AWSSupport.</returns>
        AddAttachmentsToSetResponse EndAddAttachmentsToSet(IAsyncResult asyncResult);

        #endregion
        
        #region  AddCommunicationToCase


        /// <summary>
        /// Adds additional customer communication to an AWS Support case. You use the <code>CaseId</code>
        /// value to identify the case to add communication to. You can list a set of email addresses
        /// to copy on the communication using the <code>CcEmailAddresses</code> value. The <code>CommunicationBody</code>
        /// value contains the text of the communication.
        /// 
        ///     
        /// <para>
        /// The response indicates the success or failure of the request.
        /// </para>
        ///     
        /// <para>
        /// This operation implements a subset of the behavior on the AWS Support <a href="https://aws.amazon.com/support">Your
        /// Support Cases</a> web form.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddCommunicationToCase service method.</param>
        /// 
        /// <returns>The response from the AddCommunicationToCase service method, as returned by AWSSupport.</returns>
        /// <exception cref="AttachmentSetExpiredException">
        /// The expiration time of the attachment set has passed. The set expires 1 hour after
        /// it is created.
        /// </exception>
        /// <exception cref="AttachmentSetIdNotFoundException">
        /// An attachment set with the specified ID could not be found.
        /// </exception>
        /// <exception cref="CaseIdNotFoundException">
        /// The requested <code>CaseId</code> could not be located.
        /// </exception>
        /// <exception cref="InternalServerErrorException">
        /// An internal server error occurred.
        /// </exception>
        AddCommunicationToCaseResponse AddCommunicationToCase(AddCommunicationToCaseRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the AddCommunicationToCase operation.
        /// <seealso cref="Amazon.AWSSupport.IAmazonAWSSupport"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AddCommunicationToCase operation on AmazonAWSSupportClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAddCommunicationToCase
        ///         operation.</returns>
        IAsyncResult BeginAddCommunicationToCase(AddCommunicationToCaseRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  AddCommunicationToCase operation.
        /// <seealso cref="Amazon.AWSSupport.IAmazonAWSSupport"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAddCommunicationToCase.</param>
        /// 
        /// <returns>Returns a  AddCommunicationToCaseResult from AWSSupport.</returns>
        AddCommunicationToCaseResponse EndAddCommunicationToCase(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateCase


        /// <summary>
        /// Creates a new case in the AWS Support Center. This operation is modeled on the behavior
        /// of the AWS Support Center <a href="https://aws.amazon.com/support/createCase">Open
        /// a new case</a> page. Its parameters require you to specify the following information:
        /// 
        /// 
        ///     <ol>      <li><b>IssueType.</b> The type of issue for the case. You can specify
        /// either "customer-service" or "technical." If you do not indicate a value, the default
        /// is "technical." </li>      <li><b>ServiceCode.</b> The code for an AWS service. You
        /// obtain the <code>ServiceCode</code> by calling <a>DescribeServices</a>. </li>    
        ///  <li><b>CategoryCode.</b> The category for the service defined for the <code>ServiceCode</code>
        /// value. You also obtain the category code for a service by calling <a>DescribeServices</a>.
        /// Each AWS service defines its own set of category codes. </li>      <li><b>SeverityCode.</b>
        /// A value that indicates the urgency of the case, which in turn determines the response
        /// time according to your service level agreement with AWS Support. You obtain the SeverityCode
        /// by calling <a>DescribeSeverityLevels</a>.</li>      <li><b>Subject.</b> The <b>Subject</b>
        /// field  on the AWS Support Center <a href="https://aws.amazon.com/support/createCase">Open
        /// a new case</a> page.</li>      <li><b>CommunicationBody.</b> The <b>Description</b>
        /// field on the AWS Support Center <a href="https://aws.amazon.com/support/createCase">Open
        /// a new case</a> page.</li>      <li><b>AttachmentSetId.</b> The ID of a set of attachments
        /// that has been created by using <a>AddAttachmentsToSet</a>.</li>      <li><b>Language.</b>
        /// The human language in which AWS Support handles the case. English and Japanese are
        /// currently supported.</li>      <li><b>CcEmailAddresses.</b> The  AWS Support Center
        /// <b>CC</b> field on the <a href="https://aws.amazon.com/support/createCase">Open a
        /// new case</a> page. You can list email addresses to be copied on any correspondence
        /// about the case. The account that opens the case is already identified by passing the
        /// AWS Credentials in the HTTP POST method or in a method or function call from one of
        /// the programming languages supported by an <a href="http://aws.amazon.com/tools/">AWS
        /// SDK</a>. </li>    </ol>        <note>
        /// <para>
        /// To add additional communication or attachments to an existing case, use <a>AddCommunicationToCase</a>.
        /// </para>
        ///  </note>        
        /// <para>
        /// A successful <a>CreateCase</a> request returns an AWS Support case number. Case numbers
        /// are used by the <a>DescribeCases</a> operation to retrieve existing AWS Support cases.
        /// 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCase service method.</param>
        /// 
        /// <returns>The response from the CreateCase service method, as returned by AWSSupport.</returns>
        /// <exception cref="AttachmentSetExpiredException">
        /// The expiration time of the attachment set has passed. The set expires 1 hour after
        /// it is created.
        /// </exception>
        /// <exception cref="AttachmentSetIdNotFoundException">
        /// An attachment set with the specified ID could not be found.
        /// </exception>
        /// <exception cref="CaseCreationLimitExceededException">
        /// The case creation limit for the account has been exceeded.
        /// </exception>
        /// <exception cref="InternalServerErrorException">
        /// An internal server error occurred.
        /// </exception>
        CreateCaseResponse CreateCase(CreateCaseRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateCase operation.
        /// <seealso cref="Amazon.AWSSupport.IAmazonAWSSupport"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateCase operation on AmazonAWSSupportClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateCase
        ///         operation.</returns>
        IAsyncResult BeginCreateCase(CreateCaseRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateCase operation.
        /// <seealso cref="Amazon.AWSSupport.IAmazonAWSSupport"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateCase.</param>
        /// 
        /// <returns>Returns a  CreateCaseResult from AWSSupport.</returns>
        CreateCaseResponse EndCreateCase(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeAttachment


        /// <summary>
        /// Returns the attachment that has the specified ID. Attachment IDs are generated by
        /// the case management system when you add an attachment to a case or case communication.
        /// Attachment IDs are returned in the <a>AttachmentDetails</a> objects that are returned
        /// by the <a>DescribeCommunications</a> operation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAttachment service method.</param>
        /// 
        /// <returns>The response from the DescribeAttachment service method, as returned by AWSSupport.</returns>
        /// <exception cref="AttachmentIdNotFoundException">
        /// An attachment with the specified ID could not be found.
        /// </exception>
        /// <exception cref="DescribeAttachmentLimitExceededException">
        /// The limit for the number of <a>DescribeAttachment</a> requests in a short period of
        /// time has been exceeded.
        /// </exception>
        /// <exception cref="InternalServerErrorException">
        /// An internal server error occurred.
        /// </exception>
        DescribeAttachmentResponse DescribeAttachment(DescribeAttachmentRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeAttachment operation.
        /// <seealso cref="Amazon.AWSSupport.IAmazonAWSSupport"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeAttachment operation on AmazonAWSSupportClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeAttachment
        ///         operation.</returns>
        IAsyncResult BeginDescribeAttachment(DescribeAttachmentRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeAttachment operation.
        /// <seealso cref="Amazon.AWSSupport.IAmazonAWSSupport"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeAttachment.</param>
        /// 
        /// <returns>Returns a  DescribeAttachmentResult from AWSSupport.</returns>
        DescribeAttachmentResponse EndDescribeAttachment(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeCases


        /// <summary>
        /// Returns a list of cases that you specify by passing one or more case IDs. In addition,
        /// you can filter the cases by date by setting values for the <code>AfterTime</code>
        /// and <code>BeforeTime</code> request parameters. 
        /// 
        ///     
        /// <para>
        /// Case data is available for 12 months after creation. If a case was created more than
        /// 12 months ago, a request for data might cause an error. 
        /// </para>
        ///         
        /// <para>
        /// The response returns the following in JSON format:
        /// </para>
        ///      <ol>      <li>One or more <a>CaseDetails</a> data types. </li>      <li>One or
        /// more <code>NextToken</code> values, which specify where to paginate the returned records
        /// represented by the <code>CaseDetails</code> objects.</li>    </ol>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeCases service method.</param>
        /// 
        /// <returns>The response from the DescribeCases service method, as returned by AWSSupport.</returns>
        /// <exception cref="CaseIdNotFoundException">
        /// The requested <code>CaseId</code> could not be located.
        /// </exception>
        /// <exception cref="InternalServerErrorException">
        /// An internal server error occurred.
        /// </exception>
        DescribeCasesResponse DescribeCases(DescribeCasesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeCases operation.
        /// <seealso cref="Amazon.AWSSupport.IAmazonAWSSupport"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeCases operation on AmazonAWSSupportClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeCases
        ///         operation.</returns>
        IAsyncResult BeginDescribeCases(DescribeCasesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeCases operation.
        /// <seealso cref="Amazon.AWSSupport.IAmazonAWSSupport"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeCases.</param>
        /// 
        /// <returns>Returns a  DescribeCasesResult from AWSSupport.</returns>
        DescribeCasesResponse EndDescribeCases(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeCommunications


        /// <summary>
        /// Returns communications (and attachments) for one or more support cases. You can use
        /// the <code>AfterTime</code> and <code>BeforeTime</code> parameters to filter by date.
        /// You can use the <code>CaseId</code> parameter to restrict the results to a particular
        /// case.
        /// 
        ///     
        /// <para>
        /// Case data is available for 12 months after creation. If a case was created more than
        /// 12 months ago, a request for data might cause an error. 
        /// </para>
        ///     
        /// <para>
        /// You can use the <code>MaxResults</code> and <code>NextToken</code> parameters to control
        /// the pagination of the result set. Set <code>MaxResults</code> to the number of cases
        /// you want displayed on each page, and use  <code>NextToken</code> to specify the resumption
        /// of pagination.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeCommunications service method.</param>
        /// 
        /// <returns>The response from the DescribeCommunications service method, as returned by AWSSupport.</returns>
        /// <exception cref="CaseIdNotFoundException">
        /// The requested <code>CaseId</code> could not be located.
        /// </exception>
        /// <exception cref="InternalServerErrorException">
        /// An internal server error occurred.
        /// </exception>
        DescribeCommunicationsResponse DescribeCommunications(DescribeCommunicationsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeCommunications operation.
        /// <seealso cref="Amazon.AWSSupport.IAmazonAWSSupport"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeCommunications operation on AmazonAWSSupportClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeCommunications
        ///         operation.</returns>
        IAsyncResult BeginDescribeCommunications(DescribeCommunicationsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeCommunications operation.
        /// <seealso cref="Amazon.AWSSupport.IAmazonAWSSupport"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeCommunications.</param>
        /// 
        /// <returns>Returns a  DescribeCommunicationsResult from AWSSupport.</returns>
        DescribeCommunicationsResponse EndDescribeCommunications(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeServices

        /// <summary>
        /// Returns the current list of AWS services and a list of service categories that applies
        /// to each one. You then use service names and categories in your <a>CreateCase</a> requests.
        /// Each AWS service has its own set of categories.
        /// 
        ///     
        /// <para>
        /// The service codes and category codes correspond to the values that are displayed in
        /// the <b>Service</b> and <b>Category</b> drop-down lists on the AWS Support Center <a
        /// href="https://aws.amazon.com/support/createCase">Open a new case</a> page. The values
        /// in those      fields, however, do not necessarily match the service codes and categories
        /// returned by the        <code>DescribeServices</code> request. Always use the service
        /// codes and categories obtained      programmatically. This practice ensures that you
        /// always have the most recent set of service and category codes.
        /// </para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeServices service method, as returned by AWSSupport.</returns>
        /// <exception cref="InternalServerErrorException">
        /// An internal server error occurred.
        /// </exception>
        DescribeServicesResponse DescribeServices();

        /// <summary>
        /// Returns the current list of AWS services and a list of service categories that applies
        /// to each one. You then use service names and categories in your <a>CreateCase</a> requests.
        /// Each AWS service has its own set of categories.
        /// 
        ///     
        /// <para>
        /// The service codes and category codes correspond to the values that are displayed in
        /// the <b>Service</b> and <b>Category</b> drop-down lists on the AWS Support Center <a
        /// href="https://aws.amazon.com/support/createCase">Open a new case</a> page. The values
        /// in those      fields, however, do not necessarily match the service codes and categories
        /// returned by the        <code>DescribeServices</code> request. Always use the service
        /// codes and categories obtained      programmatically. This practice ensures that you
        /// always have the most recent set of service and category codes.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeServices service method.</param>
        /// 
        /// <returns>The response from the DescribeServices service method, as returned by AWSSupport.</returns>
        /// <exception cref="InternalServerErrorException">
        /// An internal server error occurred.
        /// </exception>
        DescribeServicesResponse DescribeServices(DescribeServicesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeServices operation.
        /// <seealso cref="Amazon.AWSSupport.IAmazonAWSSupport"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeServices operation on AmazonAWSSupportClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeServices
        ///         operation.</returns>
        IAsyncResult BeginDescribeServices(DescribeServicesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeServices operation.
        /// <seealso cref="Amazon.AWSSupport.IAmazonAWSSupport"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeServices.</param>
        /// 
        /// <returns>Returns a  DescribeServicesResult from AWSSupport.</returns>
        DescribeServicesResponse EndDescribeServices(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeSeverityLevels

        /// <summary>
        /// Returns the list of severity levels that you can assign to an AWS Support case. The
        /// severity level for a case is also a field in the <a>CaseDetails</a> data type included
        /// in any <a>CreateCase</a> request.
        /// </summary>
        /// 
        /// <returns>The response from the DescribeSeverityLevels service method, as returned by AWSSupport.</returns>
        /// <exception cref="InternalServerErrorException">
        /// An internal server error occurred.
        /// </exception>
        DescribeSeverityLevelsResponse DescribeSeverityLevels();

        /// <summary>
        /// Returns the list of severity levels that you can assign to an AWS Support case. The
        /// severity level for a case is also a field in the <a>CaseDetails</a> data type included
        /// in any <a>CreateCase</a> request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeSeverityLevels service method.</param>
        /// 
        /// <returns>The response from the DescribeSeverityLevels service method, as returned by AWSSupport.</returns>
        /// <exception cref="InternalServerErrorException">
        /// An internal server error occurred.
        /// </exception>
        DescribeSeverityLevelsResponse DescribeSeverityLevels(DescribeSeverityLevelsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeSeverityLevels operation.
        /// <seealso cref="Amazon.AWSSupport.IAmazonAWSSupport"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeSeverityLevels operation on AmazonAWSSupportClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeSeverityLevels
        ///         operation.</returns>
        IAsyncResult BeginDescribeSeverityLevels(DescribeSeverityLevelsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeSeverityLevels operation.
        /// <seealso cref="Amazon.AWSSupport.IAmazonAWSSupport"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeSeverityLevels.</param>
        /// 
        /// <returns>Returns a  DescribeSeverityLevelsResult from AWSSupport.</returns>
        DescribeSeverityLevelsResponse EndDescribeSeverityLevels(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeTrustedAdvisorCheckRefreshStatuses


        /// <summary>
        /// Returns the refresh status of the Trusted Advisor checks that have the specified check
        /// IDs. Check IDs can be obtained by calling <a>DescribeTrustedAdvisorChecks</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeTrustedAdvisorCheckRefreshStatuses service method.</param>
        /// 
        /// <returns>The response from the DescribeTrustedAdvisorCheckRefreshStatuses service method, as returned by AWSSupport.</returns>
        /// <exception cref="InternalServerErrorException">
        /// An internal server error occurred.
        /// </exception>
        DescribeTrustedAdvisorCheckRefreshStatusesResponse DescribeTrustedAdvisorCheckRefreshStatuses(DescribeTrustedAdvisorCheckRefreshStatusesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeTrustedAdvisorCheckRefreshStatuses operation.
        /// <seealso cref="Amazon.AWSSupport.IAmazonAWSSupport"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeTrustedAdvisorCheckRefreshStatuses operation on AmazonAWSSupportClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeTrustedAdvisorCheckRefreshStatuses
        ///         operation.</returns>
        IAsyncResult BeginDescribeTrustedAdvisorCheckRefreshStatuses(DescribeTrustedAdvisorCheckRefreshStatusesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeTrustedAdvisorCheckRefreshStatuses operation.
        /// <seealso cref="Amazon.AWSSupport.IAmazonAWSSupport"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeTrustedAdvisorCheckRefreshStatuses.</param>
        /// 
        /// <returns>Returns a  DescribeTrustedAdvisorCheckRefreshStatusesResult from AWSSupport.</returns>
        DescribeTrustedAdvisorCheckRefreshStatusesResponse EndDescribeTrustedAdvisorCheckRefreshStatuses(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeTrustedAdvisorCheckResult


        /// <summary>
        /// Returns the results of the Trusted Advisor check that has the specified check ID.
        /// Check IDs can be obtained by calling <a>DescribeTrustedAdvisorChecks</a>.
        /// 
        ///     
        /// <para>
        /// The response contains a <a>TrustedAdvisorCheckResult</a> object, which contains these
        /// three objects:
        /// </para>
        ///     <ul>      <li><a>TrustedAdvisorCategorySpecificSummary</a></li>      <li><a>TrustedAdvisorResourceDetail</a></li>
        ///      <li><a>TrustedAdvisorResourcesSummary</a></li>    </ul>
        /// <para>
        /// In addition, the response contains these fields:
        /// </para>
        ///     <ul>      <li><b>Status.</b> The alert status of the check: "ok" (green), "warning"
        /// (yellow), "error" (red), or "not_available".</li>      <li><b>Timestamp.</b> The time
        /// of the last refresh of the check.</li>      <li><b>CheckId.</b> The unique identifier
        /// for the check.</li>    </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeTrustedAdvisorCheckResult service method.</param>
        /// 
        /// <returns>The response from the DescribeTrustedAdvisorCheckResult service method, as returned by AWSSupport.</returns>
        /// <exception cref="InternalServerErrorException">
        /// An internal server error occurred.
        /// </exception>
        DescribeTrustedAdvisorCheckResultResponse DescribeTrustedAdvisorCheckResult(DescribeTrustedAdvisorCheckResultRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeTrustedAdvisorCheckResult operation.
        /// <seealso cref="Amazon.AWSSupport.IAmazonAWSSupport"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeTrustedAdvisorCheckResult operation on AmazonAWSSupportClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeTrustedAdvisorCheckResult
        ///         operation.</returns>
        IAsyncResult BeginDescribeTrustedAdvisorCheckResult(DescribeTrustedAdvisorCheckResultRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeTrustedAdvisorCheckResult operation.
        /// <seealso cref="Amazon.AWSSupport.IAmazonAWSSupport"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeTrustedAdvisorCheckResult.</param>
        /// 
        /// <returns>Returns a  DescribeTrustedAdvisorCheckResultResult from AWSSupport.</returns>
        DescribeTrustedAdvisorCheckResultResponse EndDescribeTrustedAdvisorCheckResult(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeTrustedAdvisorChecks


        /// <summary>
        /// Returns information about all available Trusted Advisor checks, including name, ID,
        /// category, description, and metadata. You must specify a language code; English ("en")
        /// and Japanese ("ja") are currently supported. The response contains a <a>TrustedAdvisorCheckDescription</a>
        /// for each check.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeTrustedAdvisorChecks service method.</param>
        /// 
        /// <returns>The response from the DescribeTrustedAdvisorChecks service method, as returned by AWSSupport.</returns>
        /// <exception cref="InternalServerErrorException">
        /// An internal server error occurred.
        /// </exception>
        DescribeTrustedAdvisorChecksResponse DescribeTrustedAdvisorChecks(DescribeTrustedAdvisorChecksRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeTrustedAdvisorChecks operation.
        /// <seealso cref="Amazon.AWSSupport.IAmazonAWSSupport"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeTrustedAdvisorChecks operation on AmazonAWSSupportClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeTrustedAdvisorChecks
        ///         operation.</returns>
        IAsyncResult BeginDescribeTrustedAdvisorChecks(DescribeTrustedAdvisorChecksRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeTrustedAdvisorChecks operation.
        /// <seealso cref="Amazon.AWSSupport.IAmazonAWSSupport"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeTrustedAdvisorChecks.</param>
        /// 
        /// <returns>Returns a  DescribeTrustedAdvisorChecksResult from AWSSupport.</returns>
        DescribeTrustedAdvisorChecksResponse EndDescribeTrustedAdvisorChecks(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeTrustedAdvisorCheckSummaries


        /// <summary>
        /// Returns the summaries of the results of the Trusted Advisor checks that have the specified
        /// check IDs. Check IDs can be obtained by calling <a>DescribeTrustedAdvisorChecks</a>.
        /// 
        ///         
        /// <para>
        /// The response contains an array of <a>TrustedAdvisorCheckSummary</a> objects.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeTrustedAdvisorCheckSummaries service method.</param>
        /// 
        /// <returns>The response from the DescribeTrustedAdvisorCheckSummaries service method, as returned by AWSSupport.</returns>
        /// <exception cref="InternalServerErrorException">
        /// An internal server error occurred.
        /// </exception>
        DescribeTrustedAdvisorCheckSummariesResponse DescribeTrustedAdvisorCheckSummaries(DescribeTrustedAdvisorCheckSummariesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeTrustedAdvisorCheckSummaries operation.
        /// <seealso cref="Amazon.AWSSupport.IAmazonAWSSupport"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeTrustedAdvisorCheckSummaries operation on AmazonAWSSupportClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeTrustedAdvisorCheckSummaries
        ///         operation.</returns>
        IAsyncResult BeginDescribeTrustedAdvisorCheckSummaries(DescribeTrustedAdvisorCheckSummariesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeTrustedAdvisorCheckSummaries operation.
        /// <seealso cref="Amazon.AWSSupport.IAmazonAWSSupport"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeTrustedAdvisorCheckSummaries.</param>
        /// 
        /// <returns>Returns a  DescribeTrustedAdvisorCheckSummariesResult from AWSSupport.</returns>
        DescribeTrustedAdvisorCheckSummariesResponse EndDescribeTrustedAdvisorCheckSummaries(IAsyncResult asyncResult);

        #endregion
        
        #region  RefreshTrustedAdvisorCheck


        /// <summary>
        /// Requests a refresh of the Trusted Advisor check that has the specified check ID. Check
        /// IDs can be obtained by calling <a>DescribeTrustedAdvisorChecks</a>.
        /// 
        ///       
        /// <para>
        /// The response contains a <a>RefreshTrustedAdvisorCheckResult</a> object, which contains
        /// these fields:
        /// </para>
        ///     <ul>      <li><b>Status.</b> The refresh status of the check: "none", "enqueued",
        /// "processing", "success", or "abandoned".</li>      <li><b>MillisUntilNextRefreshable.</b>
        /// The amount of time, in milliseconds, until the check is eligible for refresh.</li>
        ///      <li><b>CheckId.</b> The unique identifier for the check.</li>    </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RefreshTrustedAdvisorCheck service method.</param>
        /// 
        /// <returns>The response from the RefreshTrustedAdvisorCheck service method, as returned by AWSSupport.</returns>
        /// <exception cref="InternalServerErrorException">
        /// An internal server error occurred.
        /// </exception>
        RefreshTrustedAdvisorCheckResponse RefreshTrustedAdvisorCheck(RefreshTrustedAdvisorCheckRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the RefreshTrustedAdvisorCheck operation.
        /// <seealso cref="Amazon.AWSSupport.IAmazonAWSSupport"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RefreshTrustedAdvisorCheck operation on AmazonAWSSupportClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRefreshTrustedAdvisorCheck
        ///         operation.</returns>
        IAsyncResult BeginRefreshTrustedAdvisorCheck(RefreshTrustedAdvisorCheckRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  RefreshTrustedAdvisorCheck operation.
        /// <seealso cref="Amazon.AWSSupport.IAmazonAWSSupport"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRefreshTrustedAdvisorCheck.</param>
        /// 
        /// <returns>Returns a  RefreshTrustedAdvisorCheckResult from AWSSupport.</returns>
        RefreshTrustedAdvisorCheckResponse EndRefreshTrustedAdvisorCheck(IAsyncResult asyncResult);

        #endregion
        
        #region  ResolveCase


        /// <summary>
        /// Takes a <code>CaseId</code> and returns the initial state of the case along with the
        /// state of the case after the call to <a>ResolveCase</a> completed.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ResolveCase service method.</param>
        /// 
        /// <returns>The response from the ResolveCase service method, as returned by AWSSupport.</returns>
        /// <exception cref="CaseIdNotFoundException">
        /// The requested <code>CaseId</code> could not be located.
        /// </exception>
        /// <exception cref="InternalServerErrorException">
        /// An internal server error occurred.
        /// </exception>
        ResolveCaseResponse ResolveCase(ResolveCaseRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ResolveCase operation.
        /// <seealso cref="Amazon.AWSSupport.IAmazonAWSSupport"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ResolveCase operation on AmazonAWSSupportClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndResolveCase
        ///         operation.</returns>
        IAsyncResult BeginResolveCase(ResolveCaseRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ResolveCase operation.
        /// <seealso cref="Amazon.AWSSupport.IAmazonAWSSupport"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginResolveCase.</param>
        /// 
        /// <returns>Returns a  ResolveCaseResult from AWSSupport.</returns>
        ResolveCaseResponse EndResolveCase(IAsyncResult asyncResult);

        #endregion
        
    }
}