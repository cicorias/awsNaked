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

namespace Amazon.ElastiCache.Model
{
    /// <summary>
    /// Configuration for accessing Amazon CreateCacheSubnetGroup service
    /// </summary>
    public partial class CreateCacheSubnetGroupResponse : CreateCacheSubnetGroupResult
    {
        /// <summary>
        /// Gets and sets the CreateCacheSubnetGroupResult property.
        /// Represents the output of a CreateCacheSubnetGroup operation.
        /// </summary>
        [Obsolete(@"This property has been deprecated. All properties of the CreateCacheSubnetGroupResult class are now available on the CreateCacheSubnetGroupResponse class. You should use the properties on CreateCacheSubnetGroupResponse instead of accessing them through CreateCacheSubnetGroupResult.")]
        public CreateCacheSubnetGroupResult CreateCacheSubnetGroupResult
        {
            get
            {
                return this;
            }
        }
    }
}