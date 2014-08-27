/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

namespace Amazon.CloudSearch_2011_02_01.Model
{
    /// <summary>
    /// Returns information about the  DescribeRankExpressions response and response metadata.
    /// </summary>
    public class DescribeRankExpressionsResponse : DescribeRankExpressionsResult
    {
        /// <summary>
        /// Gets and sets the DescribeRankExpressionsResult property.
        /// A response message that contains the rank expressions for a search domain.
        /// </summary>
        [Obsolete(@"This property has been deprecated. All properties of the DescribeRankExpressionsResult class are now available on the DescribeRankExpressionsResponse class. You should use the properties on DescribeRankExpressionsResponse instead of accessing them through DescribeRankExpressionsResult.")]
        public DescribeRankExpressionsResult DescribeRankExpressionsResult
        {
            get
            {
                return this;
            }
        }
    }
}
    
