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

namespace Amazon.SecurityToken.Model
{
    /// <summary>
    /// Configuration for accessing Amazon AssumeRole service
    /// </summary>
    public partial class AssumeRoleResponse : AssumeRoleResult
    {
        /// <summary>
        /// Gets and sets the AssumeRoleResult property.
        /// Represents the output of a AssumeRole operation.
        /// </summary>
        [Obsolete(@"This property has been deprecated. All properties of the AssumeRoleResult class are now available on the AssumeRoleResponse class. You should use the properties on AssumeRoleResponse instead of accessing them through AssumeRoleResult.")]
        public AssumeRoleResult AssumeRoleResult
        {
            get
            {
                return this;
            }
        }
    }
}