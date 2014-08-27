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
    using Amazon.DirectConnect.Model;
    using Amazon.Runtime.Internal.Transform;

    namespace Amazon.DirectConnect.Model.Internal.MarshallTransformations
    {
      /// <summary>
      /// VirtualInterfaceUnmarshaller
      /// </summary>
      internal class VirtualInterfaceUnmarshaller : IUnmarshaller<VirtualInterface, XmlUnmarshallerContext>, IUnmarshaller<VirtualInterface, JsonUnmarshallerContext>
      {
        VirtualInterface IUnmarshaller<VirtualInterface, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
          throw new NotImplementedException();
        }

        public VirtualInterface Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) return null;
            VirtualInterface virtualInterface = new VirtualInterface();
        
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
              
              if (context.TestExpression("ownerAccount", targetDepth))
              {
                virtualInterface.OwnerAccount = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("virtualInterfaceId", targetDepth))
              {
                virtualInterface.VirtualInterfaceId = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("location", targetDepth))
              {
                virtualInterface.Location = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("connectionId", targetDepth))
              {
                virtualInterface.ConnectionId = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("virtualInterfaceType", targetDepth))
              {
                virtualInterface.VirtualInterfaceType = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("virtualInterfaceName", targetDepth))
              {
                virtualInterface.VirtualInterfaceName = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("vlan", targetDepth))
              {
                virtualInterface.Vlan = IntUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("asn", targetDepth))
              {
                virtualInterface.Asn = IntUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("authKey", targetDepth))
              {
                virtualInterface.AuthKey = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("amazonAddress", targetDepth))
              {
                virtualInterface.AmazonAddress = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("customerAddress", targetDepth))
              {
                virtualInterface.CustomerAddress = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("virtualInterfaceState", targetDepth))
              {
                virtualInterface.VirtualInterfaceState = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("customerRouterConfig", targetDepth))
              {
                virtualInterface.CustomerRouterConfig = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("virtualGatewayId", targetDepth))
              {
                virtualInterface.VirtualGatewayId = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("routeFilterPrefixes", targetDepth))
              {
                
                var unmarshaller = new ListUnmarshaller<RouteFilterPrefix,RouteFilterPrefixUnmarshaller>(
                    RouteFilterPrefixUnmarshaller.GetInstance());                  
                virtualInterface.RouteFilterPrefixes = unmarshaller.Unmarshall(context);
                
                continue;
              }
  
            }
          
            return virtualInterface;
        }

        private static VirtualInterfaceUnmarshaller instance;
        public static VirtualInterfaceUnmarshaller GetInstance()
        {
            if (instance == null)
                instance = new VirtualInterfaceUnmarshaller();
            return instance;
        }
    }
}
  
