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

namespace Amazon.ElasticLoadBalancing.Model
{
    /// <summary>
    /// The <a>PolicyTypeDescription</a> data type.
    /// </summary>
    public partial class PolicyTypeDescription
    {
        private string _description;
        private List<PolicyAttributeTypeDescription> _policyAttributeTypeDescriptions = new List<PolicyAttributeTypeDescription>();
        private string _policyTypeName;


        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        ///  A human-readable description of the policy type. 
        /// </para>
        /// </summary>
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }


        /// <summary>
        /// Gets and sets the property PolicyAttributeTypeDescriptions. 
        /// <para>
        ///  The description of the policy attributes associated with the load balancer policies
        /// defined by the Elastic Load Balancing service. 
        /// </para>
        /// </summary>
        public List<PolicyAttributeTypeDescription> PolicyAttributeTypeDescriptions
        {
            get { return this._policyAttributeTypeDescriptions; }
            set { this._policyAttributeTypeDescriptions = value; }
        }

        // Check to see if PolicyAttributeTypeDescriptions property is set
        internal bool IsSetPolicyAttributeTypeDescriptions()
        {
            return this._policyAttributeTypeDescriptions != null && this._policyAttributeTypeDescriptions.Count > 0; 
        }


        /// <summary>
        /// Gets and sets the property PolicyTypeName. 
        /// <para>
        ///  The name of the policy type. 
        /// </para>
        /// </summary>
        public string PolicyTypeName
        {
            get { return this._policyTypeName; }
            set { this._policyTypeName = value; }
        }

        // Check to see if PolicyTypeName property is set
        internal bool IsSetPolicyTypeName()
        {
            return this._policyTypeName != null;
        }

    }
}