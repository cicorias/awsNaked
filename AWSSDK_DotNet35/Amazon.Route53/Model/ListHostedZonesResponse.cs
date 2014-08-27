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

using Amazon.Runtime;

namespace Amazon.Route53.Model
{
    /// <summary>
    /// Returns information about the  ListHostedZones response and response metadata.
    /// </summary>
    public partial class ListHostedZonesResponse : ListHostedZonesResult
    {
        /// <summary>
        /// Gets and sets the ListHostedZonesResult property.
        /// A complex type that contains the response for the request.
        /// </summary>
        [Obsolete(@"This property has been deprecated. All properties of the ListHostedZonesResult class are now available on the ListHostedZonesResponse class. You should use the properties on ListHostedZonesResponse instead of accessing them through ListHostedZonesResult.")]
        public ListHostedZonesResult ListHostedZonesResult
        {
            get
            {
                return this;
            }
        }
    }
}
    
