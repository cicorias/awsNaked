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
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.AutoScaling.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
namespace Amazon.AutoScaling.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DescribeNotificationConfigurations Request Marshaller
    /// </summary>       
    public class DescribeNotificationConfigurationsRequestMarshaller : IMarshaller<IRequest, DescribeNotificationConfigurationsRequest>
    {
        public IRequest Marshall(DescribeNotificationConfigurationsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.AutoScaling");
            request.Parameters.Add("Action", "DescribeNotificationConfigurations");
            request.Parameters.Add("Version", "2011-01-01");

            if(publicRequest != null)
            {
                if(publicRequest.IsSetAutoScalingGroupNames())
                {
                    int publicRequestlistValueIndex = 1;
                    foreach(var publicRequestlistValue in publicRequest.AutoScalingGroupNames)
                    {
                        request.Parameters.Add("AutoScalingGroupNames" + "." + "member" + "." + publicRequestlistValueIndex, StringUtils.FromString(publicRequestlistValue));
                        publicRequestlistValueIndex++;
                    }
                }
                if(publicRequest.IsSetMaxRecords())
                {
                    request.Parameters.Add("MaxRecords", StringUtils.FromInt(publicRequest.MaxRecords));
                }
                if(publicRequest.IsSetNextToken())
                {
                    request.Parameters.Add("NextToken", StringUtils.FromString(publicRequest.NextToken));
                }
            }
            return request;
        }
    }
}