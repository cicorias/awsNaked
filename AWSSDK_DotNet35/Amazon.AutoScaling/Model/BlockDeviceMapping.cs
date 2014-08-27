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
    /// The <code>BlockDeviceMapping</code> data type.
    /// </summary>
    public partial class BlockDeviceMapping
    {
        private string _deviceName;
        private Ebs _ebs;
        private bool? _noDevice;
        private string _virtualName;


        /// <summary>
        /// Gets and sets the property DeviceName. 
        /// <para>
        ///  The name of the device within Amazon EC2 (for example, /dev/sdh or xvdh). 
        /// </para>
        /// </summary>
        public string DeviceName
        {
            get { return this._deviceName; }
            set { this._deviceName = value; }
        }

        // Check to see if DeviceName property is set
        internal bool IsSetDeviceName()
        {
            return this._deviceName != null;
        }


        /// <summary>
        /// Gets and sets the property Ebs. 
        /// <para>
        ///  The Elastic Block Storage volume information. 
        /// </para>
        /// </summary>
        public Ebs Ebs
        {
            get { return this._ebs; }
            set { this._ebs = value; }
        }

        // Check to see if Ebs property is set
        internal bool IsSetEbs()
        {
            return this._ebs != null;
        }


        /// <summary>
        /// Gets and sets the property NoDevice. 
        /// <para>
        ///  Suppresses the device mapping. 
        /// </para>
        /// </summary>
        public bool NoDevice
        {
            get { return this._noDevice.GetValueOrDefault(); }
            set { this._noDevice = value; }
        }

        // Check to see if NoDevice property is set
        internal bool IsSetNoDevice()
        {
            return this._noDevice.HasValue; 
        }


        /// <summary>
        /// Gets and sets the property VirtualName. 
        /// <para>
        /// The virtual name associated with the device. 
        /// </para>
        /// </summary>
        public string VirtualName
        {
            get { return this._virtualName; }
            set { this._virtualName = value; }
        }

        // Check to see if VirtualName property is set
        internal bool IsSetVirtualName()
        {
            return this._virtualName != null;
        }

    }
}