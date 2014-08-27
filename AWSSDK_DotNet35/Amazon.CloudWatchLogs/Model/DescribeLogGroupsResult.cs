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

namespace Amazon.CloudWatchLogs.Model
{
    /// <summary>
    /// 
    /// </summary>
    public partial class DescribeLogGroupsResult : AmazonWebServiceResponse
    {
        private List<LogGroup> _logGroups = new List<LogGroup>();
        private string _nextToken;


        /// <summary>
        /// Gets and sets the property LogGroups.
        /// </summary>
        public List<LogGroup> LogGroups
        {
            get { return this._logGroups; }
            set { this._logGroups = value; }
        }

        // Check to see if LogGroups property is set
        internal bool IsSetLogGroups()
        {
            return this._logGroups != null && this._logGroups.Count > 0; 
        }


        /// <summary>
        /// Gets and sets the property NextToken.
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

    }
}