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
    using Amazon.SimpleWorkflow.Model;
    using Amazon.Runtime.Internal.Transform;

    namespace Amazon.SimpleWorkflow.Model.Internal.MarshallTransformations
    {
      /// <summary>
      /// WorkflowExecutionInfosUnmarshaller
      /// </summary>
      internal class WorkflowExecutionInfosUnmarshaller : IUnmarshaller<WorkflowExecutionInfos, XmlUnmarshallerContext>, IUnmarshaller<WorkflowExecutionInfos, JsonUnmarshallerContext>
      {
        WorkflowExecutionInfos IUnmarshaller<WorkflowExecutionInfos, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
          throw new NotImplementedException();
        }

        public WorkflowExecutionInfos Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) return null;
            WorkflowExecutionInfos workflowExecutionInfos = new WorkflowExecutionInfos();
        
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
              
              if (context.TestExpression("executionInfos", targetDepth))
              {
                
                var unmarshaller = new ListUnmarshaller<WorkflowExecutionInfo,WorkflowExecutionInfoUnmarshaller>(
                    WorkflowExecutionInfoUnmarshaller.GetInstance());                  
                workflowExecutionInfos.ExecutionInfos = unmarshaller.Unmarshall(context);
                
                continue;
              }
  
              if (context.TestExpression("nextPageToken", targetDepth))
              {
                workflowExecutionInfos.NextPageToken = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
            }
          
            return workflowExecutionInfos;
        }

        private static WorkflowExecutionInfosUnmarshaller instance;
        public static WorkflowExecutionInfosUnmarshaller GetInstance()
        {
            if (instance == null)
                instance = new WorkflowExecutionInfosUnmarshaller();
            return instance;
        }
    }
}
  
