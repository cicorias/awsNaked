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
    public partial class LogGroup
    {
        private string _arn;
        private DateTime? _creationTime;
        private string _logGroupName;
        private int? _metricFilterCount;
        private int? _retentionInDays;
        private long? _storedBytes;


        /// <summary>
        /// Gets and sets the property Arn.
        /// </summary>
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }


        /// <summary>
        /// Gets and sets the property CreationTime.
        /// </summary>
        public DateTime CreationTime
        {
            get { return this._creationTime.GetValueOrDefault(); }
            set { this._creationTime = value; }
        }

        // Check to see if CreationTime property is set
        internal bool IsSetCreationTime()
        {
            return this._creationTime.HasValue; 
        }


        /// <summary>
        /// Gets and sets the property LogGroupName.
        /// </summary>
        public string LogGroupName
        {
            get { return this._logGroupName; }
            set { this._logGroupName = value; }
        }

        // Check to see if LogGroupName property is set
        internal bool IsSetLogGroupName()
        {
            return this._logGroupName != null;
        }


        /// <summary>
        /// Gets and sets the property MetricFilterCount.
        /// </summary>
        public int MetricFilterCount
        {
            get { return this._metricFilterCount.GetValueOrDefault(); }
            set { this._metricFilterCount = value; }
        }

        // Check to see if MetricFilterCount property is set
        internal bool IsSetMetricFilterCount()
        {
            return this._metricFilterCount.HasValue; 
        }


        /// <summary>
        /// Gets and sets the property RetentionInDays.
        /// </summary>
        public int? RetentionInDays
        {
            get { return this._retentionInDays; }
            set { this._retentionInDays = value; }
        }

        // Check to see if RetentionInDays property is set
        internal bool IsSetRetentionInDays()
        {
            return this._retentionInDays.HasValue; 
        }


        /// <summary>
        /// Gets and sets the property StoredBytes.
        /// </summary>
        public long StoredBytes
        {
            get { return this._storedBytes.GetValueOrDefault(); }
            set { this._storedBytes = value; }
        }

        // Check to see if StoredBytes property is set
        internal bool IsSetStoredBytes()
        {
            return this._storedBytes.HasValue; 
        }

    }
}