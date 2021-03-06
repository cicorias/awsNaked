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

using Amazon.ElasticLoadBalancing.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
namespace Amazon.ElasticLoadBalancing.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for EnableAvailabilityZonesForLoadBalancer operation
    /// </summary>  
    public class EnableAvailabilityZonesForLoadBalancerResponseUnmarshaller : XmlResponseUnmarshaller
    {
        public override AmazonWebServiceResponse Unmarshall(XmlUnmarshallerContext context)
        {
            EnableAvailabilityZonesForLoadBalancerResponse response = new EnableAvailabilityZonesForLoadBalancerResponse();

            context.Read();
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.IsStartElement)
                {                    
                    if(context.TestExpression("EnableAvailabilityZonesForLoadBalancerResult", 2))
                    {
                        UnmarshallResult(context, response);                        
                        continue;
                    }
                    
                    if (context.TestExpression("ResponseMetadata", 2))
                    {
                        response.ResponseMetadata = ResponseMetadataUnmarshaller.Instance.Unmarshall(context);
                    }
                }
            }

            return response;
        }

        private static void UnmarshallResult(XmlUnmarshallerContext context, EnableAvailabilityZonesForLoadBalancerResponse response)
        {
            
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.ReadAtDepth(originalDepth))
            {
                if (context.IsStartElement || context.IsAttribute)
                {

                    if (context.TestExpression("AvailabilityZones/member", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        var item = unmarshaller.Unmarshall(context);
                        response.AvailabilityZones.Add(item);
                        continue;
                    }
                } 
           }

            return;
        }


        public override AmazonServiceException UnmarshallException(XmlUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
        {
            ErrorResponse errorResponse = ErrorResponseUnmarshaller.GetInstance().Unmarshall(context);
            if (errorResponse.Code != null && errorResponse.Code.Equals("LoadBalancerNotFound"))
            {
                return new AccessPointNotFoundException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
            }
            return new AmazonElasticLoadBalancingException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
        }

        private static EnableAvailabilityZonesForLoadBalancerResponseUnmarshaller _instance = new EnableAvailabilityZonesForLoadBalancerResponseUnmarshaller();        

        internal static EnableAvailabilityZonesForLoadBalancerResponseUnmarshaller GetInstance()
        {
            return _instance;
        }
        public static EnableAvailabilityZonesForLoadBalancerResponseUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}