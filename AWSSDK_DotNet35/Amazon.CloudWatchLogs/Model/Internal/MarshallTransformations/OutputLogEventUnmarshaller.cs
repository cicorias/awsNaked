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
    /// Response Unmarshaller for OutputLogEvent Object
    /// </summary>  
    public class OutputLogEventUnmarshaller : IUnmarshaller<OutputLogEvent, XmlUnmarshallerContext>, IUnmarshaller<OutputLogEvent, JsonUnmarshallerContext>
    {
        OutputLogEvent IUnmarshaller<OutputLogEvent, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        public OutputLogEvent Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            OutputLogEvent unmarshalledObject = new OutputLogEvent();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("ingestionTime", targetDepth))
                {
                    var unmarshaller = DateTimeEpochLongMillisecondsUnmarshaller.Instance;
                    unmarshalledObject.IngestionTime = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("message", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Message = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("timestamp", targetDepth))
                {
                    var unmarshaller = DateTimeEpochLongMillisecondsUnmarshaller.Instance;
                    unmarshalledObject.Timestamp = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static OutputLogEventUnmarshaller _instance = new OutputLogEventUnmarshaller();        

        public static OutputLogEventUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}