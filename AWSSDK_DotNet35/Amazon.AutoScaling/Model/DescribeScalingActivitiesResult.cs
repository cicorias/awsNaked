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
    /// The output for the <a>DescribeScalingActivities</a> action.
    /// </summary>
    public partial class DescribeScalingActivitiesResult : AmazonWebServiceResponse
    {
        private List<Activity> _activities = new List<Activity>();
        private string _nextToken;


        /// <summary>
        /// Gets and sets the property Activities. 
        /// <para>
        ///  A list of the requested scaling activities. 
        /// </para>
        /// </summary>
        public List<Activity> Activities
        {
            get { return this._activities; }
            set { this._activities = value; }
        }

        // Check to see if Activities property is set
        internal bool IsSetActivities()
        {
            return this._activities != null && this._activities.Count > 0; 
        }


        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        ///  Acts as a paging mechanism for large result sets. Set to a non-empty string if there
        /// are additional results waiting to be returned. Pass this in to subsequent calls to
        /// return additional results. 
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

    }
}