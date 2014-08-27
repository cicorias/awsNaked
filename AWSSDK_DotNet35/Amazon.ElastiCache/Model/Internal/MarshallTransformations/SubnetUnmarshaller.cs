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
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.ElastiCache.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
namespace Amazon.ElastiCache.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for Subnet Object
    /// </summary>  
    public class SubnetUnmarshaller : IUnmarshaller<Subnet, XmlUnmarshallerContext>, IUnmarshaller<Subnet, JsonUnmarshallerContext>
    {
        public Subnet Unmarshall(XmlUnmarshallerContext context)
        {
            Subnet unmarshalledObject = new Subnet();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.ReadAtDepth(originalDepth))
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("SubnetAvailabilityZone", targetDepth))
                    {
                        var unmarshaller = AvailabilityZoneUnmarshaller.Instance;
                        unmarshalledObject.SubnetAvailabilityZone = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("SubnetIdentifier", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.SubnetIdentifier = unmarshaller.Unmarshall(context);
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return unmarshalledObject;
                }
            }

            return unmarshalledObject;
        }

        public Subnet Unmarshall(JsonUnmarshallerContext context)
        {
            return null;
        }


        private static SubnetUnmarshaller _instance = new SubnetUnmarshaller();        

        public static SubnetUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}