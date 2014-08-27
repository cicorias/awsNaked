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
      /// DecisionTaskUnmarshaller
      /// </summary>
      internal class DecisionTaskUnmarshaller : IUnmarshaller<DecisionTask, XmlUnmarshallerContext>, IUnmarshaller<DecisionTask, JsonUnmarshallerContext>
      {
        DecisionTask IUnmarshaller<DecisionTask, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
          throw new NotImplementedException();
        }

        public DecisionTask Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) return null;
            DecisionTask decisionTask = new DecisionTask();
        
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
              
              if (context.TestExpression("taskToken", targetDepth))
              {
                decisionTask.TaskToken = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("startedEventId", targetDepth))
              {
                decisionTask.StartedEventId = LongUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("workflowExecution", targetDepth))
              {
                decisionTask.WorkflowExecution = WorkflowExecutionUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("workflowType", targetDepth))
              {
                decisionTask.WorkflowType = WorkflowTypeUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("events", targetDepth))
              {
                
                var unmarshaller = new ListUnmarshaller<HistoryEvent,HistoryEventUnmarshaller>(
                    HistoryEventUnmarshaller.GetInstance());                  
                decisionTask.Events = unmarshaller.Unmarshall(context);
                
                continue;
              }
  
              if (context.TestExpression("nextPageToken", targetDepth))
              {
                decisionTask.NextPageToken = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("previousStartedEventId", targetDepth))
              {
                decisionTask.PreviousStartedEventId = LongUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
            }
          
            return decisionTask;
        }

        private static DecisionTaskUnmarshaller instance;
        public static DecisionTaskUnmarshaller GetInstance()
        {
            if (instance == null)
                instance = new DecisionTaskUnmarshaller();
            return instance;
        }
    }
}
  
