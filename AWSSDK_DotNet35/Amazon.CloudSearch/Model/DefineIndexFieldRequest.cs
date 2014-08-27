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

namespace Amazon.CloudSearch.Model
{
    /// <summary>
    /// Container for the parameters to the DefineIndexField operation.
    /// <para>Configures an <c> IndexField </c> for the search domain. Used to create new fields and modify existing ones. You must specify the name
    /// of the domain you are configuring and an index field configuration. The index field configuration specifies a unique name, the index field
    /// type, and the options you want to configure for the field. The options you can specify depend on the <c> IndexFieldType </c> . If the field
    /// exists, the new configuration replaces the old one. For more information, see <a
    /// href="http://docs.aws.amazon.com/cloudsearch/latest/developerguide/configuring-index-fields.html" >Configuring Index Fields</a> in the
    /// <i>Amazon CloudSearch Developer Guide</i> . </para>
    /// </summary>
    public partial class DefineIndexFieldRequest : AmazonCloudSearchRequest
    {
        private string domainName;
        private IndexField indexField;


        /// <summary>
        /// A string that represents the name of a domain. Domain names are unique across the domains owned by an account within an AWS region. Domain
        /// names start with a letter or number and can contain the following characters: a-z (lowercase), 0-9, and - (hyphen).
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>3 - 28</description>
        ///     </item>
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>[a-z][a-z0-9\-]+</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string DomainName
        {
            get { return this.domainName; }
            set { this.domainName = value; }
        }

        // Check to see if DomainName property is set
        internal bool IsSetDomainName()
        {
            return this.domainName != null;
        }

        /// <summary>
        /// The index field and field options you want to configure.
        ///  
        /// </summary>
        public IndexField IndexField
        {
            get { return this.indexField; }
            set { this.indexField = value; }
        }

        // Check to see if IndexField property is set
        internal bool IsSetIndexField()
        {
            return this.indexField != null;
        }

    }
}
    
