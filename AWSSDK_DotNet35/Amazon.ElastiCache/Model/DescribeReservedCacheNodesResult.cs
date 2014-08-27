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

namespace Amazon.ElastiCache.Model
{
    /// <summary>
    /// Represents the output of a <i>DescribeReservedCacheNodes</i> operation.
    /// </summary>
    public partial class DescribeReservedCacheNodesResult : AmazonWebServiceResponse
    {
        private string _marker;
        private List<ReservedCacheNode> _reservedCacheNodes = new List<ReservedCacheNode>();


        /// <summary>
        /// Gets and sets the property Marker. 
        /// <para>
        /// Provides an identifier to allow retrieval of paginated results.
        /// </para>
        /// </summary>
        public string Marker
        {
            get { return this._marker; }
            set { this._marker = value; }
        }

        // Check to see if Marker property is set
        internal bool IsSetMarker()
        {
            return this._marker != null;
        }


        /// <summary>
        /// Gets and sets the property ReservedCacheNodes. 
        /// <para>
        /// A list of reserved cache nodes. Each element in the list contains detailed information
        /// about one node.
        /// </para>
        /// </summary>
        public List<ReservedCacheNode> ReservedCacheNodes
        {
            get { return this._reservedCacheNodes; }
            set { this._reservedCacheNodes = value; }
        }

        // Check to see if ReservedCacheNodes property is set
        internal bool IsSetReservedCacheNodes()
        {
            return this._reservedCacheNodes != null && this._reservedCacheNodes.Count > 0; 
        }

    }
}