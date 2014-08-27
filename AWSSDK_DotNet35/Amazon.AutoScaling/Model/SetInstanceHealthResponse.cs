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

namespace Amazon.AutoScaling.Model
{
    /// <summary>
    /// Configuration for accessing Amazon SetInstanceHealth service
    /// </summary>
    public partial class SetInstanceHealthResponse : SetInstanceHealthResult
    {
        /// <summary>
        /// Gets and sets the SetInstanceHealthResult property.
        /// Represents the output of a SetInstanceHealth operation.
        /// </summary>
        [Obsolete(@"This property has been deprecated. All properties of the SetInstanceHealthResult class are now available on the SetInstanceHealthResponse class. You should use the properties on SetInstanceHealthResponse instead of accessing them through SetInstanceHealthResult.")]
        public SetInstanceHealthResult SetInstanceHealthResult
        {
            get
            {
                return this;
            }
        }
    }
}