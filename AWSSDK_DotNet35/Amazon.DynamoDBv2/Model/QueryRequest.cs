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
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.DynamoDBv2.Model
{
    /// <summary>
    /// Container for the parameters to the Query operation.
    /// <para>A <i>Query</i> operation directly accesses items from a table using the table primary key, or from an index using the index key. You
    /// must provide a specific hash key value. You can narrow the scope of the query by using comparison operators on the range key value, or on
    /// the index key. You can use the <i>ScanIndexForward</i> parameter to get results in forward or reverse order, by range key or by index key.
    /// </para> <para>Queries that do not return results consume the minimum read capacity units according to the type of read.</para> <para>If the
    /// total number of items meeting the query criteria exceeds the result set size limit of 1 MB, the query stops and results are returned to the
    /// user with a <i>LastEvaluatedKey</i> to continue the query in a subsequent operation. Unlike a <i>Scan</i> operation, a <i>Query</i>
    /// operation never returns an empty result set <i>and</i> a
    /// <i>LastEvaluatedKey</i> . The <i>LastEvaluatedKey</i> is only provided if the results exceed 1 MB, or if you have used
    /// <i>Limit</i> . </para> <para>You can query a table, a local secondary index, or a global secondary index. For a query on a table or on a
    /// local secondary index, you can set <i>ConsistentRead</i> to true and obtain a strongly consistent result. Global secondary indexes support
    /// eventually consistent reads only, so do not specify <i>ConsistentRead</i> when querying a global secondary index.</para>
    /// </summary>
    public partial class QueryRequest : AmazonDynamoDBv2Request
    {
        private string tableName;
        private string indexName;
        private Select select;
        private List<string> attributesToGet = new List<string>();
        private int? limit;
        private bool? consistentRead;
        private Dictionary<string,Condition> keyConditions = new Dictionary<string,Condition>();
        private Dictionary<string,Condition> queryFilter = new Dictionary<string,Condition>();
        private ConditionalOperator conditionalOperator;
        private bool? scanIndexForward;
        private Dictionary<string,AttributeValue> exclusiveStartKey = new Dictionary<string,AttributeValue>();
        private ReturnConsumedCapacity returnConsumedCapacity;


        /// <summary>
        /// The name of the table containing the requested items.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>3 - 255</description>
        ///     </item>
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>[a-zA-Z0-9_.-]+</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string TableName
        {
            get { return this.tableName; }
            set { this.tableName = value; }
        }

        // Check to see if TableName property is set
        internal bool IsSetTableName()
        {
            return this.tableName != null;
        }

        /// <summary>
        /// The name of an index to query. This can be any local secondary index or global secondary index on the table.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>3 - 255</description>
        ///     </item>
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>[a-zA-Z0-9_.-]+</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string IndexName
        {
            get { return this.indexName; }
            set { this.indexName = value; }
        }

        // Check to see if IndexName property is set
        internal bool IsSetIndexName()
        {
            return this.indexName != null;
        }

        /// <summary>
        /// The attributes to be returned in the result. You can retrieve all item attributes, specific item attributes, the count of matching items, or
        /// in the case of an index, some or all of the attributes projected into the index. <ul> <li> <c>ALL_ATTRIBUTES</c>: Returns all of the item
        /// attributes from the specified table or index. If you are querying a local secondary index, then for each matching item in the index DynamoDB
        /// will fetch the entire item from the parent table. If the index is configured to project all item attributes, then all of the data can be
        /// obtained from the local secondary index, and no fetching is required.. </li> <li> <c>ALL_PROJECTED_ATTRIBUTES</c>: Allowed only when
        /// querying an index. Retrieves all attributes which have been projected into the index. If the index is configured to project all attributes,
        /// this is equivalent to specifying <c>ALL_ATTRIBUTES</c>. </li> <li> <c>COUNT</c>: Returns the number of matching items, rather than the
        /// matching items themselves. </li> <li> <c>SPECIFIC_ATTRIBUTES</c> : Returns only the attributes listed in <i>AttributesToGet</i>. This is
        /// equivalent to specifying <i>AttributesToGet</i> without specifying any value for <i>Select</i>. If you are querying a local secondary index
        /// and request only attributes that are projected into that index, the operation will read only the index and not the table. If any of the
        /// requested attributes are not projected into the local secondary index, DynamoDB will fetch each of these attributes from the parent table.
        /// This extra fetching incurs additional throughput cost and latency. If you are querying a global secondary index, you can only request
        /// attributes that are projected into the index. Global secondary index queries cannot fetch attributes from the parent table. </li> </ul> If
        /// neither <i>Select</i> nor <i>AttributesToGet</i> are specified, DynamoDB defaults to <c>ALL_ATTRIBUTES</c> when accessing a table, and
        /// <c>ALL_PROJECTED_ATTRIBUTES</c> when accessing an index. You cannot use both <i>Select</i> and <i>AttributesToGet</i> together in a single
        /// request, <i>unless</i> the value for <i>Select</i> is <c>SPECIFIC_ATTRIBUTES</c>. (This usage is equivalent to specifying
        /// <i>AttributesToGet</i> without any value for <i>Select</i>.)
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Allowed Values</term>
        ///         <description>ALL_ATTRIBUTES, ALL_PROJECTED_ATTRIBUTES, SPECIFIC_ATTRIBUTES, COUNT</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public Select Select
        {
            get { return this.select; }
            set { this.select = value; }
        }

        // Check to see if Select property is set
        internal bool IsSetSelect()
        {
            return this.select != null;
        }

        /// <summary>
        /// The names of one or more attributes to retrieve. If no attribute names are specified, then all attributes will be returned. If any of the
        /// requested attributes are not found, they will not appear in the result. Note that <i>AttributesToGet</i> has no effect on provisioned
        /// throughput consumption. DynamoDB determines capacity units consumed based on item size, not on the amount of data that is returned to an
        /// application. You cannot use both <i>AttributesToGet</i> and <i>Select</i> together in a <i>Query</i> request, <i>unless</i> the value for
        /// <i>Select</i> is <c>SPECIFIC_ATTRIBUTES</c>. (This usage is equivalent to specifying <i>AttributesToGet</i> without any value for
        /// <i>Select</i>.) If you are querying a local secondary index and request only attributes that are projected into that index, the operation
        /// will read only the index and not the table. If any of the requested attributes are not projected into the local secondary index, DynamoDB
        /// will fetch each of these attributes from the parent table. This extra fetching incurs additional throughput cost and latency. If you are
        /// querying a global secondary index, you can only request attributes that are projected into the index. Global secondary index queries cannot
        /// fetch attributes from the parent table.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>1 - </description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public List<string> AttributesToGet
        {
            get { return this.attributesToGet; }
            set { this.attributesToGet = value; }
        }

        // Check to see if AttributesToGet property is set
        internal bool IsSetAttributesToGet()
        {
            return this.attributesToGet.Count > 0;
        }

        /// <summary>
        /// The maximum number of items to evaluate (not necessarily the number of matching items). If DynamoDB processes the number of items up to the
        /// limit while processing the results, it stops the operation and returns the matching values up to that point, and a <i>LastEvaluatedKey</i>
        /// to apply in a subsequent operation, so that you can pick up where you left off. Also, if the processed data set size exceeds 1 MB before
        /// DynamoDB reaches this limit, it stops the operation and returns the matching values up to the limit, and a <i>LastEvaluatedKey</i> to apply
        /// in a subsequent operation to continue the operation. For more information see <a
        /// href="http://docs.aws.amazon.com/amazondynamodb/latest/developerguide/QueryAndScan.html">Query and Scan</a> in the Amazon DynamoDB Developer
        /// Guide.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Range</term>
        ///         <description>1 - </description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public int Limit
        {
            get { return this.limit ?? default(int); }
            set { this.limit = value; }
        }

        // Check to see if Limit property is set
        internal bool IsSetLimit()
        {
            return this.limit.HasValue;
        }

        /// <summary>
        /// If set to <c>true</c>, then the operation uses strongly consistent reads; otherwise, eventually consistent reads are used. Strongly
        /// consistent reads are not supported on global secondary indexes. If you query a global secondary index with <i>ConsistentRead</i> set to
        /// <c>true</c>, you will receive an error message.
        ///  
        /// </summary>
        public bool ConsistentRead
        {
            get { return this.consistentRead ?? default(bool); }
            set { this.consistentRead = value; }
        }

        // Check to see if ConsistentRead property is set
        internal bool IsSetConsistentRead()
        {
            return this.consistentRead.HasValue;
        }

        /// <summary>
        /// The selection criteria for the query. For a query on a table, you can only have conditions on the table primary key attributes. You must
        /// specify the hash key attribute name and value as an <c>EQ</c> condition. You can optionally specify a second condition, referring to the
        /// range key attribute. For a query on an index, you can only have conditions on the index key attributes. You must specify the index hash
        /// attribute name and value as an EQ condition. You can optionally specify a second condition, referring to the index key range attribute. If
        /// you specify more than one condition in the <i>KeyConditions</i> map, then by default all of the conditions must evaluate to true. In other
        /// words, the conditions are ANDed together. (You can use the <i>ConditionalOperator</i> parameter to OR the conditions instead. If you do
        /// this, then at least one of the conditions must evaluate to true, rather than all of them.) Each <i>KeyConditions</i> element consists of an
        /// attribute name to compare, along with the following: <ul> <li> <i>AttributeValueList</i> - One or more values to evaluate against the
        /// supplied attribute. The number of values in the list depends on the <i>ComparisonOperator</i> being used. For type Number, value comparisons
        /// are numeric. String value comparisons for greater than, equals, or less than are based on ASCII character code values. For example, <c>a</c>
        /// is greater than <c>A</c>, and <c>aa</c> is greater than <c>B</c>. For a list of code values, see <a
        /// href="http://en.wikipedia.org/wiki/ASCII#ASCII_printable_characters">http://en.wikipedia.org/wiki/ASCII#ASCII_printable_characters</a>. For
        /// Binary, DynamoDB treats each byte of the binary data as unsigned when it compares binary values, for example when evaluating query
        /// expressions. For information on specifying data types in JSON, see <a
        /// href="http://docs.aws.amazon.com/amazondynamodb/latest/developerguide/DataFormat.html">JSON Data Format</a> in the Amazon DynamoDB Developer
        /// Guide.</li> <li><i>ComparisonOperator</i> - A comparator for evaluating attributes. For example, equals, greater than, less than, etc.
        /// <important>For <i>KeyConditions</i>, the following comparison operators are supported: <c>EQ | LE | LT | GE | GT | BEGINS_WITH | BETWEEN</c>
        /// </important> For complete descriptions of comparison operators, see <a
        /// href="http://docs.aws.amazon.com/amazondynamodb/latest/APIReference/API_Condition.html">API_Condition.html</a>. </li> </ul>
        ///  
        /// </summary>
        public Dictionary<string,Condition> KeyConditions
        {
            get { return this.keyConditions; }
            set { this.keyConditions = value; }
        }

        // Check to see if KeyConditions property is set
        internal bool IsSetKeyConditions()
        {
            return this.keyConditions != null;
        }

        /// <summary>
        /// Evaluates the query results and returns only the desired values. If you specify more than one condition in the <i>QueryFilter</i> map, then
        /// by default all of the conditions must evaluate to true. In other words, the conditions are ANDed together. (You can use the
        /// <i>ConditionalOperator</i> parameter to OR the conditions instead. If you do this, then at least one of the conditions must evaluate to
        /// true, rather than all of them.) Each <i>QueryFilter</i> element consists of an attribute name to compare, along with the following: <ul>
        /// <li> <i>AttributeValueList</i> - One or more values to evaluate against the supplied attribute. The number of values in the list depends on
        /// the <i>ComparisonOperator</i> being used. For type Number, value comparisons are numeric. String value comparisons for greater than, equals,
        /// or less than are based on ASCII character code values. For example, <c>a</c> is greater than <c>A</c>, and <c>aa</c> is greater than
        /// <c>B</c>. For a list of code values, see <a
        /// href="http://en.wikipedia.org/wiki/ASCII#ASCII_printable_characters">http://en.wikipedia.org/wiki/ASCII#ASCII_printable_characters</a>. For
        /// Binary, DynamoDB treats each byte of the binary data as unsigned when it compares binary values, for example when evaluating query
        /// expressions. For information on specifying data types in JSON, see <a
        /// href="http://docs.aws.amazon.com/amazondynamodb/latest/developerguide/DataFormat.html">JSON Data Format</a> in the Amazon DynamoDB Developer
        /// Guide. </li> <li><i>ComparisonOperator</i> - A comparator for evaluating attributes. For example, equals, greater than, less than, etc. The
        /// following comparison operators are available: <c>EQ | NE | LE | LT | GE | GT | NOT_NULL | NULL | CONTAINS | NOT_CONTAINS | BEGINS_WITH | IN
        /// | BETWEEN</c> For complete descriptions of all comparison operators, see <a
        /// href="http://docs.aws.amazon.com/amazondynamodb/latest/APIReference/API_Condition.html">API_Condition.html</a>. </li> </ul>
        ///  
        /// </summary>
        public Dictionary<string,Condition> QueryFilter
        {
            get { return this.queryFilter; }
            set { this.queryFilter = value; }
        }

        // Check to see if QueryFilter property is set
        internal bool IsSetQueryFilter()
        {
            return this.queryFilter != null;
        }

        /// <summary>
        /// A logical operator to apply to the conditions in the <i>QueryFilter</i> map: <ul> <li><c>AND</c> - If <i>all</i> of the conditions evaluate
        /// to true, then the entire map evaluates to true.</li> <li><c>OR</c> - If <i>at least one</i> of the conditions evaluate to true, then the
        /// entire map evaluates to true.</li> </ul> If you omit <i>ConditionalOperator</i>, then <c>AND</c> is used as the default. The operation will
        /// succeed only if the entire map evaluates to true.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Allowed Values</term>
        ///         <description>AND, OR</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public ConditionalOperator ConditionalOperator
        {
            get { return this.conditionalOperator; }
            set { this.conditionalOperator = value; }
        }

        // Check to see if ConditionalOperator property is set
        internal bool IsSetConditionalOperator()
        {
            return this.conditionalOperator != null;
        }

        /// <summary>
        /// Specifies ascending (true) or descending (false) traversal of the index. DynamoDB returns results reflecting the requested order determined
        /// by the range key. If the data type is Number, the results are returned in numeric order. For String, the results are returned in order of
        /// ASCII character code values. For Binary, DynamoDB treats each byte of the binary data as unsigned when it compares binary values. If
        /// <i>ScanIndexForward</i> is not specified, the results are returned in ascending order.
        ///  
        /// </summary>
        public bool ScanIndexForward
        {
            get { return this.scanIndexForward ?? default(bool); }
            set { this.scanIndexForward = value; }
        }

        // Check to see if ScanIndexForward property is set
        internal bool IsSetScanIndexForward()
        {
            return this.scanIndexForward.HasValue;
        }

        /// <summary>
        /// The primary key of the first item that this operation will evaluate. Use the value that was returned for <i>LastEvaluatedKey</i> in the
        /// previous operation. The data type for <i>ExclusiveStartKey</i> must be String, Number or Binary. No set data types are allowed.
        ///  
        /// </summary>
        public Dictionary<string,AttributeValue> ExclusiveStartKey
        {
            get { return this.exclusiveStartKey; }
            set { this.exclusiveStartKey = value; }
        }

        // Check to see if ExclusiveStartKey property is set
        internal bool IsSetExclusiveStartKey()
        {
            return this.exclusiveStartKey != null;
        }

        /// <summary>
        /// If set to <c>TOTAL</c>, the response includes <i>ConsumedCapacity</i> data for tables and indexes. If set to <c>INDEXES</c>, the response
        /// includes <i>ConsumedCapacity</i> for indexes. If set to <c>NONE</c> (the default), <i>ConsumedCapacity</i> is not included in the response.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Allowed Values</term>
        ///         <description>INDEXES, TOTAL, NONE</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public ReturnConsumedCapacity ReturnConsumedCapacity
        {
            get { return this.returnConsumedCapacity; }
            set { this.returnConsumedCapacity = value; }
        }

        // Check to see if ReturnConsumedCapacity property is set
        internal bool IsSetReturnConsumedCapacity()
        {
            return this.returnConsumedCapacity != null;
        }

    }
}
    
