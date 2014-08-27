/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using System.IO;
using System.Xml;
using System.Text;
using Amazon.S3.Util;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Util;

namespace Amazon.S3.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Put Bucket Notification Request Marshaller
    /// </summary>       
    public class PutBucketNotificationRequestMarshaller : IMarshaller<IRequest, PutBucketNotificationRequest>
    {
        public IRequest Marshall(PutBucketNotificationRequest putBucketNotificationRequest)
        {
            IRequest request = new DefaultRequest(putBucketNotificationRequest, "AmazonS3");

            request.HttpMethod = "PUT";

            request.ResourcePath = string.Concat("/", S3Transforms.ToStringValue(putBucketNotificationRequest.BucketName));

            request.AddSubResource("notification");

            var stringWriter = new StringWriter(System.Globalization.CultureInfo.InvariantCulture);
            using (var xmlWriter = XmlWriter.Create(stringWriter, new XmlWriterSettings() { Encoding = System.Text.Encoding.UTF8, OmitXmlDeclaration = true }))
            {
                xmlWriter.WriteStartElement("NotificationConfiguration", "");

                if (putBucketNotificationRequest.IsSetTopicConfigurations())
                {
                    foreach (var topicConfiguartion in putBucketNotificationRequest.TopicConfigurations)
                    {
                        if (topicConfiguartion != null)
                        {
                            xmlWriter.WriteStartElement("TopicConfiguration", "");
                            if (topicConfiguartion.IsSetEvent())
                            {
                                xmlWriter.WriteElementString("Event", "", S3Transforms.ToXmlStringValue(topicConfiguartion.Event));
                            }
                            if (topicConfiguartion.IsSetTopic())
                            {
                                xmlWriter.WriteElementString("Topic", "", S3Transforms.ToXmlStringValue(topicConfiguartion.Topic));
                            }
                            xmlWriter.WriteEndElement();
                        }
                    }
                }

                xmlWriter.WriteEndElement();
            }
    
            try 
            {
                var content = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(content);
                request.Headers[HeaderKeys.ContentTypeHeader] = "application/xml";
                
                var checksum = AmazonS3Util.GenerateChecksumForContent(content, true);
                request.Headers[HeaderKeys.ContentMD5Header] = checksum;
                
            } 
            catch (EncoderFallbackException e) 
            {
                throw new AmazonServiceException("Unable to marshall request to XML", e);
            }
        
            return request;
        }
    }
}
    
