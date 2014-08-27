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
    /// Container for the parameters to the DeleteLaunchConfiguration operation.
    /// Deletes the specified <a>LaunchConfiguration</a>. 
    /// 
    ///  
    /// <para>
    ///  The specified launch configuration must not be attached to an Auto Scaling group.
    /// When this call completes, the launch configuration is no longer available for use.
    /// 
    /// </para>
    /// </summary>
    public partial class DeleteLaunchConfigurationRequest : AmazonAutoScalingRequest
    {
        private string _launchConfigurationName;


        /// <summary>
        /// Gets and sets the property LaunchConfigurationName. 
        /// <para>
        ///  The name of the launch configuration. 
        /// </para>
        /// </summary>
        public string LaunchConfigurationName
        {
            get { return this._launchConfigurationName; }
            set { this._launchConfigurationName = value; }
        }

        // Check to see if LaunchConfigurationName property is set
        internal bool IsSetLaunchConfigurationName()
        {
            return this._launchConfigurationName != null;
        }

    }
}