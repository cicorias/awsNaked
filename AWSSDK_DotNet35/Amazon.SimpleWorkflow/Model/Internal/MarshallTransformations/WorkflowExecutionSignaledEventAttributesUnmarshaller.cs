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
      /// WorkflowExecutionSignaledEventAttributesUnmarshaller
      /// </summary>
      internal class WorkflowExecutionSignaledEventAttributesUnmarshaller : IUnmarshaller<WorkflowExecutionSignaledEventAttributes, XmlUnmarshallerContext>, IUnmarshaller<WorkflowExecutionSignaledEventAttributes, JsonUnmarshallerContext>
      {
        WorkflowExecutionSignaledEventAttributes IUnmarshaller<WorkflowExecutionSignaledEventAttributes, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
          throw new NotImplementedException();
        }

        public WorkflowExecutionSignaledEventAttributes Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) return null;
            WorkflowExecutionSignaledEventAttributes workflowExecutionSignaledEventAttributes = new WorkflowExecutionSignaledEventAttributes();
        
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
              
              if (context.TestExpression("signalName", targetDepth))
              {
                workflowExecutionSignaledEventAttributes.SignalName = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("input", targetDepth))
              {
                workflowExecutionSignaledEventAttributes.Input = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("externalWorkflowExecution", targetDepth))
              {
                workflowExecutionSignaledEventAttributes.ExternalWorkflowExecution = WorkflowExecutionUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("externalInitiatedEventId", targetDepth))
              {
                workflowExecutionSignaledEventAttributes.ExternalInitiatedEventId = LongUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
            }
          
            return workflowExecutionSignaledEventAttributes;
        }

        private static WorkflowExecutionSignaledEventAttributesUnmarshaller instance;
        public static WorkflowExecutionSignaledEventAttributesUnmarshaller GetInstance()
        {
            if (instance == null)
                instance = new WorkflowExecutionSignaledEventAttributesUnmarshaller();
            return instance;
        }
    }
}
  
