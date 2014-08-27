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
      /// WorkflowExecutionStartedEventAttributesUnmarshaller
      /// </summary>
      internal class WorkflowExecutionStartedEventAttributesUnmarshaller : IUnmarshaller<WorkflowExecutionStartedEventAttributes, XmlUnmarshallerContext>, IUnmarshaller<WorkflowExecutionStartedEventAttributes, JsonUnmarshallerContext>
      {
        WorkflowExecutionStartedEventAttributes IUnmarshaller<WorkflowExecutionStartedEventAttributes, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
          throw new NotImplementedException();
        }

        public WorkflowExecutionStartedEventAttributes Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) return null;
            WorkflowExecutionStartedEventAttributes workflowExecutionStartedEventAttributes = new WorkflowExecutionStartedEventAttributes();
        
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
              
              if (context.TestExpression("input", targetDepth))
              {
                workflowExecutionStartedEventAttributes.Input = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("executionStartToCloseTimeout", targetDepth))
              {
                workflowExecutionStartedEventAttributes.ExecutionStartToCloseTimeout = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("taskStartToCloseTimeout", targetDepth))
              {
                workflowExecutionStartedEventAttributes.TaskStartToCloseTimeout = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("childPolicy", targetDepth))
              {
                workflowExecutionStartedEventAttributes.ChildPolicy = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("taskList", targetDepth))
              {
                workflowExecutionStartedEventAttributes.TaskList = TaskListUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("workflowType", targetDepth))
              {
                workflowExecutionStartedEventAttributes.WorkflowType = WorkflowTypeUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("tagList", targetDepth))
              {
                
                var unmarshaller = new ListUnmarshaller<String,StringUnmarshaller>(
                    StringUnmarshaller.GetInstance());                  
                workflowExecutionStartedEventAttributes.TagList = unmarshaller.Unmarshall(context);
                
                continue;
              }
  
              if (context.TestExpression("continuedExecutionRunId", targetDepth))
              {
                workflowExecutionStartedEventAttributes.ContinuedExecutionRunId = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("parentWorkflowExecution", targetDepth))
              {
                workflowExecutionStartedEventAttributes.ParentWorkflowExecution = WorkflowExecutionUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("parentInitiatedEventId", targetDepth))
              {
                workflowExecutionStartedEventAttributes.ParentInitiatedEventId = LongUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
            }
          
            return workflowExecutionStartedEventAttributes;
        }

        private static WorkflowExecutionStartedEventAttributesUnmarshaller instance;
        public static WorkflowExecutionStartedEventAttributesUnmarshaller GetInstance()
        {
            if (instance == null)
                instance = new WorkflowExecutionStartedEventAttributesUnmarshaller();
            return instance;
        }
    }
}
  
