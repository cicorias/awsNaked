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
    using System.Net;
    using System.Collections.Generic;
    using ThirdParty.Json.LitJson;
    using Amazon.Glacier.Model;
    using Amazon.Runtime;
    using Amazon.Runtime.Internal;
    using Amazon.Runtime.Internal.Transform;

    namespace Amazon.Glacier.Model.Internal.MarshallTransformations
    {
      /// <summary>
      /// Response Unmarshaller for DescribeJob operation
      /// </summary>
      internal class DescribeJobResponseUnmarshaller : JsonResponseUnmarshaller
      {
        public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
        {
            DescribeJobResponse response = new DescribeJobResponse();       
          
            context.Read();
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
              
              if (context.TestExpression("JobId", targetDepth))
              {
                response.JobId = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("JobDescription", targetDepth))
              {
                response.JobDescription = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("Action", targetDepth))
              {
                response.Action = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("ArchiveId", targetDepth))
              {
                response.ArchiveId = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("VaultARN", targetDepth))
              {
                response.VaultARN = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("CreationDate", targetDepth))
              {
                response.CreationDate = DateTimeUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("Completed", targetDepth))
              {
                response.Completed = BoolUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("StatusCode", targetDepth))
              {
                response.StatusCode = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("StatusMessage", targetDepth))
              {
                response.StatusMessage = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("ArchiveSizeInBytes", targetDepth))
              {
                response.ArchiveSizeInBytes = LongUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("InventorySizeInBytes", targetDepth))
              {
                response.InventorySizeInBytes = LongUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("SNSTopic", targetDepth))
              {
                response.SNSTopic = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("CompletionDate", targetDepth))
              {
                response.CompletionDate = DateTimeUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("SHA256TreeHash", targetDepth))
              {
                response.SHA256TreeHash = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("ArchiveSHA256TreeHash", targetDepth))
              {
                response.ArchiveSHA256TreeHash = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("RetrievalByteRange", targetDepth))
              {
                response.RetrievalByteRange = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("InventoryRetrievalParameters", targetDepth))
              {
                response.InventoryRetrievalParameters = InventoryRetrievalJobDescriptionUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
            }
                        
            return response;
        }                        
        
        public override AmazonServiceException UnmarshallException(JsonUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
        {
          ErrorResponse errorResponse = JsonErrorResponseUnmarshaller.GetInstance().Unmarshall(context);                    
          
          if (errorResponse.Code != null && errorResponse.Code.Equals("ResourceNotFoundException"))
          {
            return new ResourceNotFoundException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
          }
  
          if (errorResponse.Code != null && errorResponse.Code.Equals("MissingParameterValueException"))
          {
            return new MissingParameterValueException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
          }
  
          if (errorResponse.Code != null && errorResponse.Code.Equals("ServiceUnavailableException"))
          {
            return new ServiceUnavailableException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
          }
  
          if (errorResponse.Code != null && errorResponse.Code.Equals("InvalidParameterValueException"))
          {
            return new InvalidParameterValueException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
          }
  
          return new AmazonGlacierException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
        }

        private static DescribeJobResponseUnmarshaller instance;
        public static DescribeJobResponseUnmarshaller GetInstance()
        {
          if (instance == null)
          {
            instance = new DescribeJobResponseUnmarshaller();
          }
          return instance;
        }
  
      }
    }
  
