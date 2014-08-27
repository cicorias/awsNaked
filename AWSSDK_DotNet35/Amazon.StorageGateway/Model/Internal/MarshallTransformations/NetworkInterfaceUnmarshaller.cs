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
    using System.IO;
    using ThirdParty.Json.LitJson;
    using Amazon.StorageGateway.Model;
    using Amazon.Runtime.Internal.Transform;

    namespace Amazon.StorageGateway.Model.Internal.MarshallTransformations
    {
      /// <summary>
      /// NetworkInterfaceUnmarshaller
      /// </summary>
      internal class NetworkInterfaceUnmarshaller : IUnmarshaller<NetworkInterface, XmlUnmarshallerContext>, IUnmarshaller<NetworkInterface, JsonUnmarshallerContext>
      {
        NetworkInterface IUnmarshaller<NetworkInterface, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
          throw new NotImplementedException();
        }

        public NetworkInterface Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) return null;
            NetworkInterface networkInterface = new NetworkInterface();
        
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
              
              if (context.TestExpression("Ipv4Address", targetDepth))
              {
                networkInterface.Ipv4Address = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("MacAddress", targetDepth))
              {
                networkInterface.MacAddress = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("Ipv6Address", targetDepth))
              {
                networkInterface.Ipv6Address = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
            }
          
            return networkInterface;
        }

        private static NetworkInterfaceUnmarshaller instance;
        public static NetworkInterfaceUnmarshaller GetInstance()
        {
            if (instance == null)
                instance = new NetworkInterfaceUnmarshaller();
            return instance;
        }
    }
}
  
