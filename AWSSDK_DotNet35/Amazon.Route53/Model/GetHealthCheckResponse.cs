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
    /// Returns information about the  GetHealthCheck response and response metadata.
    /// </summary>
    public partial class GetHealthCheckResponse : GetHealthCheckResult
    {
        /// <summary>
        /// Gets and sets the GetHealthCheckResult property.
        /// A complex type containing information about the specified health check.
        /// </summary>
        [Obsolete(@"This property has been deprecated. All properties of the GetHealthCheckResult class are now available on the GetHealthCheckResponse class. You should use the properties on GetHealthCheckResponse instead of accessing them through GetHealthCheckResult.")]
        public GetHealthCheckResult GetHealthCheckResult
        {
            get
            {
                return this;
            }
        }
    }
}
    
