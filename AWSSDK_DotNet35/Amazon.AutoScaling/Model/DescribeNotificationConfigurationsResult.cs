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
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.AutoScaling.Model
{
    /// <summary>
    /// The output of the <a>DescribeNotificationConfigurations</a> action.
    /// </summary>
    public partial class DescribeNotificationConfigurationsResult : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<NotificationConfiguration> _notificationConfigurations = new List<NotificationConfiguration>();


        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// A string that is used to mark the start of the next batch of returned results for
        /// pagination.
        /// </para>
        /// </summary>
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }


        /// <summary>
        /// Gets and sets the property NotificationConfigurations. 
        /// <para>
        /// The list of notification configurations.
        /// </para>
        /// </summary>
        public List<NotificationConfiguration> NotificationConfigurations
        {
            get { return this._notificationConfigurations; }
            set { this._notificationConfigurations = value; }
        }

        // Check to see if NotificationConfigurations property is set
        internal bool IsSetNotificationConfigurations()
        {
            return this._notificationConfigurations != null && this._notificationConfigurations.Count > 0; 
        }

    }
}