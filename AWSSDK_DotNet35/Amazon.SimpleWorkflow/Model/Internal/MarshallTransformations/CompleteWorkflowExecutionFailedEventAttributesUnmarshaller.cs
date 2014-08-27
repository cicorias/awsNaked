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
      /// CompleteWorkflowExecutionFailedEventAttributesUnmarshaller
      /// </summary>
      internal class CompleteWorkflowExecutionFailedEventAttributesUnmarshaller : IUnmarshaller<CompleteWorkflowExecutionFailedEventAttributes, XmlUnmarshallerContext>, IUnmarshaller<CompleteWorkflowExecutionFailedEventAttributes, JsonUnmarshallerContext>
      {
        CompleteWorkflowExecutionFailedEventAttributes IUnmarshaller<CompleteWorkflowExecutionFailedEventAttributes, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
          throw new NotImplementedException();
        }

        public CompleteWorkflowExecutionFailedEventAttributes Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) return null;
            CompleteWorkflowExecutionFailedEventAttributes completeWorkflowExecutionFailedEventAttributes = new CompleteWorkflowExecutionFailedEventAttributes();
        
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
              
              if (context.TestExpression("cause", targetDepth))
              {
                completeWorkflowExecutionFailedEventAttributes.Cause = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("decisionTaskCompletedEventId", targetDepth))
              {
                completeWorkflowExecutionFailedEventAttributes.DecisionTaskCompletedEventId = LongUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
            }
          
            return completeWorkflowExecutionFailedEventAttributes;
        }

        private static CompleteWorkflowExecutionFailedEventAttributesUnmarshaller instance;
        public static CompleteWorkflowExecutionFailedEventAttributesUnmarshaller GetInstance()
        {
            if (instance == null)
                instance = new CompleteWorkflowExecutionFailedEventAttributesUnmarshaller();
            return instance;
        }
    }
}
  
