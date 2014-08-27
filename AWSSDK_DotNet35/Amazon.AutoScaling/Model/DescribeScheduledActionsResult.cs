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
    /// A scaling action that is scheduled for a future time and date. An action can be scheduled
    /// up to thirty days in advance. 
    /// 
    ///  
    /// <para>
    ///  Starting with API version 2011-01-01, you can use <code>recurrence</code> to specify
    /// that a scaling action occurs regularly on a schedule. 
    /// </para>
    /// </summary>
    public partial class DescribeScheduledActionsResult : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<ScheduledUpdateGroupAction> _scheduledUpdateGroupActions = new List<ScheduledUpdateGroupAction>();


        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        ///  A string that marks the start of the next batch of returned results. 
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
        /// Gets and sets the property ScheduledUpdateGroupActions. 
        /// <para>
        ///  A list of scheduled actions designed to update an Auto Scaling group. 
        /// </para>
        /// </summary>
        public List<ScheduledUpdateGroupAction> ScheduledUpdateGroupActions
        {
            get { return this._scheduledUpdateGroupActions; }
            set { this._scheduledUpdateGroupActions = value; }
        }

        // Check to see if ScheduledUpdateGroupActions property is set
        internal bool IsSetScheduledUpdateGroupActions()
        {
            return this._scheduledUpdateGroupActions != null && this._scheduledUpdateGroupActions.Count > 0; 
        }

    }
}