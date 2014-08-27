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

using Amazon.CloudWatchLogs.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.CloudWatchLogs.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for MetricFilterMatchRecord Object
    /// </summary>  
    public class MetricFilterMatchRecordUnmarshaller : IUnmarshaller<MetricFilterMatchRecord, XmlUnmarshallerContext>, IUnmarshaller<MetricFilterMatchRecord, JsonUnmarshallerContext>
    {
        MetricFilterMatchRecord IUnmarshaller<MetricFilterMatchRecord, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        public MetricFilterMatchRecord Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            MetricFilterMatchRecord unmarshalledObject = new MetricFilterMatchRecord();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("eventMessage", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.EventMessage = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("eventNumber", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    unmarshalledObject.EventNumber = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("extractedValues", targetDepth))
                {
                    var unmarshaller = new DictionaryUnmarshaller<string, string, StringUnmarshaller, StringUnmarshaller>(StringUnmarshaller.Instance, StringUnmarshaller.Instance);
                    unmarshalledObject.ExtractedValues = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static MetricFilterMatchRecordUnmarshaller _instance = new MetricFilterMatchRecordUnmarshaller();        

        public static MetricFilterMatchRecordUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}