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
using System.Text;
using System.Xml.Serialization;

using Amazon.DynamoDBv2.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.DynamoDBv2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Put Item Request Marshaller
    /// </summary>       
    internal class PutItemRequestMarshaller : IMarshaller<IRequest, PutItemRequest> 
    {
        

        public IRequest Marshall(PutItemRequest putItemRequest) 
        {

            IRequest request = new DefaultRequest(putItemRequest, "AmazonDynamoDBv2");
            string target = "DynamoDB_20120810.PutItem";
            request.Headers["X-Amz-Target"] = target;
            
            request.Headers["Content-Type"] = "application/x-amz-json-1.0";
            
            string uriResourcePath = ""; 
            request.ResourcePath = uriResourcePath;
            
             
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                
                if (putItemRequest != null && putItemRequest.IsSetTableName()) 
                {
                    writer.WritePropertyName("TableName");
                    writer.Write(putItemRequest.TableName);
                }
                if (putItemRequest != null) 
                {
                    if (putItemRequest.Item != null && putItemRequest.Item.Count > 0)
                    {
                        writer.WritePropertyName("Item");
                        writer.WriteObjectStart();
                        foreach (string putItemRequestItemKey in putItemRequest.Item.Keys)
                        {
                            AttributeValue itemListValue;
                            bool itemListValueHasValue = putItemRequest.Item.TryGetValue(putItemRequestItemKey, out itemListValue);
                            writer.WritePropertyName(putItemRequestItemKey);

                            writer.WriteObjectStart();
                            if (itemListValue != null && itemListValue.IsSetS()) 
                            {
                                writer.WritePropertyName("S");
                                writer.Write(itemListValue.S);
                            }
                            if (itemListValue != null && itemListValue.IsSetN()) 
                            {
                                writer.WritePropertyName("N");
                                writer.Write(itemListValue.N);
                            }
                            if (itemListValue != null && itemListValue.IsSetB()) 
                            {
                                writer.WritePropertyName("B");
                                writer.Write(StringUtils.FromMemoryStream(itemListValue.B));
                            }

                            if (itemListValue != null && itemListValue.SS != null && itemListValue.SS.Count > 0) 
                            {
                                List<string> sSList = itemListValue.SS;
                                writer.WritePropertyName("SS");
                                writer.WriteArrayStart();

                                foreach (string sSListValue in sSList) 
                                { 
                                    writer.Write(StringUtils.FromString(sSListValue));
                                }

                                writer.WriteArrayEnd();
                            }

                            if (itemListValue != null && itemListValue.NS != null && itemListValue.NS.Count > 0) 
                            {
                                List<string> nSList = itemListValue.NS;
                                writer.WritePropertyName("NS");
                                writer.WriteArrayStart();

                                foreach (string nSListValue in nSList) 
                                { 
                                    writer.Write(StringUtils.FromString(nSListValue));
                                }

                                writer.WriteArrayEnd();
                            }

                            if (itemListValue != null && itemListValue.BS != null && itemListValue.BS.Count > 0) 
                            {
                                List<MemoryStream> bSList = itemListValue.BS;
                                writer.WritePropertyName("BS");
                                writer.WriteArrayStart();

                                foreach (MemoryStream bSListValue in bSList) 
                                { 
                                    writer.Write(StringUtils.FromMemoryStream(bSListValue));
                                }

                                writer.WriteArrayEnd();
                            }
                            writer.WriteObjectEnd();
                        }
                        writer.WriteObjectEnd();
                    }
                }
                if (putItemRequest != null) 
                {
                    if (putItemRequest.Expected != null && putItemRequest.Expected.Count > 0)
                    {
                        writer.WritePropertyName("Expected");
                        writer.WriteObjectStart();
                        foreach (string putItemRequestExpectedKey in putItemRequest.Expected.Keys)
                        {
                            ExpectedAttributeValue expectedListValue;
                            bool expectedListValueHasValue = putItemRequest.Expected.TryGetValue(putItemRequestExpectedKey, out expectedListValue);
                            writer.WritePropertyName(putItemRequestExpectedKey);

                            writer.WriteObjectStart();

                            if (expectedListValue != null) 
                            {
                                AttributeValue value = expectedListValue.Value;
                                if (value != null)
                                {
                                    writer.WritePropertyName("Value");
                                    writer.WriteObjectStart();
                                    if (value != null && value.IsSetS()) 
                                    {
                                        writer.WritePropertyName("S");
                                        writer.Write(value.S);
                                    }
                                    if (value != null && value.IsSetN()) 
                                    {
                                        writer.WritePropertyName("N");
                                        writer.Write(value.N);
                                    }
                                    if (value != null && value.IsSetB()) 
                                    {
                                        writer.WritePropertyName("B");
                                        writer.Write(StringUtils.FromMemoryStream(value.B));
                                    }

                                    if (value != null && value.SS != null && value.SS.Count > 0) 
                                    {
                                        List<string> sSList = value.SS;
                                        writer.WritePropertyName("SS");
                                        writer.WriteArrayStart();

                                        foreach (string sSListValue in sSList) 
                                        { 
                                            writer.Write(StringUtils.FromString(sSListValue));
                                        }

                                        writer.WriteArrayEnd();
                                    }

                                    if (value != null && value.NS != null && value.NS.Count > 0) 
                                    {
                                        List<string> nSList = value.NS;
                                        writer.WritePropertyName("NS");
                                        writer.WriteArrayStart();

                                        foreach (string nSListValue in nSList) 
                                        { 
                                            writer.Write(StringUtils.FromString(nSListValue));
                                        }

                                        writer.WriteArrayEnd();
                                    }

                                    if (value != null && value.BS != null && value.BS.Count > 0) 
                                    {
                                        List<MemoryStream> bSList = value.BS;
                                        writer.WritePropertyName("BS");
                                        writer.WriteArrayStart();

                                        foreach (MemoryStream bSListValue in bSList) 
                                        { 
                                            writer.Write(StringUtils.FromMemoryStream(bSListValue));
                                        }

                                        writer.WriteArrayEnd();
                                    }
                                    writer.WriteObjectEnd();
                                }
                            }
                            if (expectedListValue != null && expectedListValue.IsSetExists()) 
                            {
                                writer.WritePropertyName("Exists");
                                writer.Write(expectedListValue.Exists);
                            }
                            if (expectedListValue != null && expectedListValue.IsSetComparisonOperator()) 
                            {
                                writer.WritePropertyName("ComparisonOperator");
                                writer.Write(expectedListValue.ComparisonOperator);
                            }

                            if (expectedListValue != null && expectedListValue.AttributeValueList != null && expectedListValue.AttributeValueList.Count > 0)
                            {
                                List<AttributeValue> attributeValueListList = expectedListValue.AttributeValueList;
                                writer.WritePropertyName("AttributeValueList");
                                writer.WriteArrayStart();

                                foreach (AttributeValue attributeValueListListValue in attributeValueListList) 
                                {
                                    writer.WriteObjectStart();
                                    if (attributeValueListListValue != null && attributeValueListListValue.IsSetS()) 
                                    {
                                        writer.WritePropertyName("S");
                                        writer.Write(attributeValueListListValue.S);
                                    }
                                    if (attributeValueListListValue != null && attributeValueListListValue.IsSetN()) 
                                    {
                                        writer.WritePropertyName("N");
                                        writer.Write(attributeValueListListValue.N);
                                    }
                                    if (attributeValueListListValue != null && attributeValueListListValue.IsSetB()) 
                                    {
                                        writer.WritePropertyName("B");
                                        writer.Write(StringUtils.FromMemoryStream(attributeValueListListValue.B));
                                    }

                                    if (attributeValueListListValue != null && attributeValueListListValue.SS != null && attributeValueListListValue.SS.Count > 0) 
                                    {
                                        List<string> sSList = attributeValueListListValue.SS;
                                        writer.WritePropertyName("SS");
                                        writer.WriteArrayStart();

                                        foreach (string sSListValue in sSList) 
                                        { 
                                            writer.Write(StringUtils.FromString(sSListValue));
                                        }

                                        writer.WriteArrayEnd();
                                    }

                                    if (attributeValueListListValue != null && attributeValueListListValue.NS != null && attributeValueListListValue.NS.Count > 0) 
                                    {
                                        List<string> nSList = attributeValueListListValue.NS;
                                        writer.WritePropertyName("NS");
                                        writer.WriteArrayStart();

                                        foreach (string nSListValue in nSList) 
                                        { 
                                            writer.Write(StringUtils.FromString(nSListValue));
                                        }

                                        writer.WriteArrayEnd();
                                    }

                                    if (attributeValueListListValue != null && attributeValueListListValue.BS != null && attributeValueListListValue.BS.Count > 0) 
                                    {
                                        List<MemoryStream> bSList = attributeValueListListValue.BS;
                                        writer.WritePropertyName("BS");
                                        writer.WriteArrayStart();

                                        foreach (MemoryStream bSListValue in bSList) 
                                        { 
                                            writer.Write(StringUtils.FromMemoryStream(bSListValue));
                                        }

                                        writer.WriteArrayEnd();
                                    }
                                    writer.WriteObjectEnd();
                                }
                                writer.WriteArrayEnd();
                            }
                            writer.WriteObjectEnd();
                        }
                        writer.WriteObjectEnd();
                    }
                }
                if (putItemRequest != null && putItemRequest.IsSetReturnValues()) 
                {
                    writer.WritePropertyName("ReturnValues");
                    writer.Write(putItemRequest.ReturnValues);
                }
                if (putItemRequest != null && putItemRequest.IsSetReturnConsumedCapacity()) 
                {
                    writer.WritePropertyName("ReturnConsumedCapacity");
                    writer.Write(putItemRequest.ReturnConsumedCapacity);
                }
                if (putItemRequest != null && putItemRequest.IsSetReturnItemCollectionMetrics()) 
                {
                    writer.WritePropertyName("ReturnItemCollectionMetrics");
                    writer.Write(putItemRequest.ReturnItemCollectionMetrics);
                }
                if (putItemRequest != null && putItemRequest.IsSetConditionalOperator()) 
                {
                    writer.WritePropertyName("ConditionalOperator");
                    writer.Write(putItemRequest.ConditionalOperator);
                }

                writer.WriteObjectEnd();
                
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }
        

            return request;
        }
    }
}
