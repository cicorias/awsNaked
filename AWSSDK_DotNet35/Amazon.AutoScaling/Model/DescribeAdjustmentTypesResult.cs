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
    /// The output of the <a>DescribeAdjustmentTypes</a> action.
    /// </summary>
    public partial class DescribeAdjustmentTypesResult : AmazonWebServiceResponse
    {
        private List<AdjustmentType> _adjustmentTypes = new List<AdjustmentType>();


        /// <summary>
        /// Gets and sets the property AdjustmentTypes. 
        /// <para>
        ///  A list of specific policy adjustment types. 
        /// </para>
        /// </summary>
        public List<AdjustmentType> AdjustmentTypes
        {
            get { return this._adjustmentTypes; }
            set { this._adjustmentTypes = value; }
        }

        // Check to see if AdjustmentTypes property is set
        internal bool IsSetAdjustmentTypes()
        {
            return this._adjustmentTypes != null && this._adjustmentTypes.Count > 0; 
        }

    }
}