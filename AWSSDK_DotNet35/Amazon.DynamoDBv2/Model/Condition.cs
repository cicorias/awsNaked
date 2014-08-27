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

namespace Amazon.DynamoDBv2.Model
{
    /// <summary>
    /// <para>Represents the selection criteria for a <i>Query</i> or <i>Scan</i> operation:</para>
    /// <ul>
    /// <li> <para>For a <i>Query</i> operation, <i>Condition</i> is used for specifying the <i>KeyConditions</i> to use when querying a table or
    /// an index. For <i>KeyConditions</i> ,
    /// the following comparison operators are supported:</para> <para> <c>EQ | LE | LT | GE | GT | BEGINS_WITH | BETWEEN</c> </para>
    /// <para> <i>Condition</i> is also used in a <i>QueryFilter</i> , which evaluates the query results and returns only the desired values.</para>
    /// </li>
    /// <li> <para>For a <i>Scan</i> operation, <i>Condition</i> is used in a <i>ScanFilter</i> , which evalues the scan results and returns only
    /// the desired values.</para> </li>
    /// 
    /// </ul>
    /// </summary>
    public partial class Condition
    {
        
        private List<AttributeValue> attributeValueList = new List<AttributeValue>();
        private ComparisonOperator comparisonOperator;


        /// <summary>
        /// One or more values to evaluate against the supplied attribute. The number of values in the list depends on the <i>ComparisonOperator</i>
        /// being used. For type Number, value comparisons are numeric. String value comparisons for greater than, equals, or less than are based on
        /// ASCII character code values. For example, <c>a</c> is greater than <c>A</c>, and <c>aa</c> is greater than <c>B</c>. For a list of code
        /// values, see <a
        /// href="http://en.wikipedia.org/wiki/ASCII#ASCII_printable_characters">http://en.wikipedia.org/wiki/ASCII#ASCII_printable_characters</a>. For
        /// Binary, DynamoDB treats each byte of the binary data as unsigned when it compares binary values, for example when evaluating query
        /// expressions. For information on specifying data types in JSON, see <a
        /// href="http://docs.aws.amazon.com/amazondynamodb/latest/developerguide/DataFormat.html">JSON Data Format</a> in the Amazon DynamoDB Developer
        /// Guide.
        ///  
        /// </summary>
        public List<AttributeValue> AttributeValueList
        {
            get { return this.attributeValueList; }
            set { this.attributeValueList = value; }
        }

        // Check to see if AttributeValueList property is set
        internal bool IsSetAttributeValueList()
        {
            return this.attributeValueList.Count > 0;
        }

        /// <summary>
        /// A comparator for evaluating attributes. For example, equals, greater than, less than, etc. The following comparison operators are available:
        /// <c>EQ | NE | LE | LT | GE | GT | NOT_NULL | NULL | CONTAINS | NOT_CONTAINS | BEGINS_WITH | IN | BETWEEN</c> The following are descriptions
        /// of each comparison operator. <ul> <li> <c>EQ</c> : Equal. <i>AttributeValueList</i> can contain only one <i>AttributeValue</i> of type
        /// String, Number, or Binary (not a set). If an item contains an <i>AttributeValue</i> of a different type than the one specified in the
        /// request, the value does not match. For example, <c>{"S":"6"}</c> does not equal <c>{"N":"6"}</c>. Also, <c>{"N":"6"}</c> does not equal
        /// <c>{"NS":["6", "2", "1"]}</c>. <p/> </li> <li> <c>NE</c> : Not equal. <i>AttributeValueList</i> can contain only one <i>AttributeValue</i>
        /// of type String, Number, or Binary (not a set). If an item contains an <i>AttributeValue</i> of a different type than the one specified in
        /// the request, the value does not match. For example, <c>{"S":"6"}</c> does not equal <c>{"N":"6"}</c>. Also, <c>{"N":"6"}</c> does not equal
        /// <c>{"NS":["6", "2", "1"]}</c>. <p/> </li> <li> <c>LE</c> : Less than or equal. <i>AttributeValueList</i> can contain only one
        /// <i>AttributeValue</i> of type String, Number, or Binary (not a set). If an item contains an <i>AttributeValue</i> of a different type than
        /// the one specified in the request, the value does not match. For example, <c>{"S":"6"}</c> does not equal <c>{"N":"6"}</c>. Also,
        /// <c>{"N":"6"}</c> does not compare to <c>{"NS":["6", "2", "1"]}</c>. <p/> </li> <li> <c>LT</c> : Less than. <i>AttributeValueList</i> can
        /// contain only one <i>AttributeValue</i> of type String, Number, or Binary (not a set). If an item contains an <i>AttributeValue</i> of a
        /// different type than the one specified in the request, the value does not match. For example, <c>{"S":"6"}</c> does not equal
        /// <c>{"N":"6"}</c>. Also, <c>{"N":"6"}</c> does not compare to <c>{"NS":["6", "2", "1"]}</c>. <p/> </li> <li> <c>GE</c> : Greater than or
        /// equal. <i>AttributeValueList</i> can contain only one <i>AttributeValue</i> of type String, Number, or Binary (not a set). If an item
        /// contains an <i>AttributeValue</i> of a different type than the one specified in the request, the value does not match. For example,
        /// <c>{"S":"6"}</c> does not equal <c>{"N":"6"}</c>. Also, <c>{"N":"6"}</c> does not compare to <c>{"NS":["6", "2", "1"]}</c>. <p/> </li> <li>
        /// <c>GT</c> : Greater than. <i>AttributeValueList</i> can contain only one <i>AttributeValue</i> of type String, Number, or Binary (not a
        /// set). If an item contains an <i>AttributeValue</i> of a different type than the one specified in the request, the value does not match. For
        /// example, <c>{"S":"6"}</c> does not equal <c>{"N":"6"}</c>. Also, <c>{"N":"6"}</c> does not compare to <c>{"NS":["6", "2", "1"]}</c>. <p/>
        /// </li> <li> <c>NOT_NULL</c> : The attribute exists. </li> <li> <c>NULL</c> : The attribute does not exist. </li> <li> <c>CONTAINS</c> :
        /// checks for a subsequence, or value in a set. <i>AttributeValueList</i> can contain only one <i>AttributeValue</i> of type String, Number, or
        /// Binary (not a set). If the target attribute of the comparison is a String, then the operation checks for a substring match. If the target
        /// attribute of the comparison is Binary, then the operation looks for a subsequence of the target that matches the input. If the target
        /// attribute of the comparison is a set ("SS", "NS", or "BS"), then the operation checks for a member of the set (not as a substring). </li>
        /// <li> <c>NOT_CONTAINS</c> : checks for absence of a subsequence, or absence of a value in a set. <i>AttributeValueList</i> can contain only
        /// one <i>AttributeValue</i> of type String, Number, or Binary (not a set). If the target attribute of the comparison is a String, then the
        /// operation checks for the absence of a substring match. If the target attribute of the comparison is Binary, then the operation checks for
        /// the absence of a subsequence of the target that matches the input. If the target attribute of the comparison is a set ("SS", "NS", or "BS"),
        /// then the operation checks for the absence of a member of the set (not as a substring). </li> <li> <c>BEGINS_WITH</c> : checks for a prefix.
        /// <i>AttributeValueList</i> can contain only one <i>AttributeValue</i> of type String or Binary (not a Number or a set). The target attribute
        /// of the comparison must be a String or Binary (not a Number or a set). <p/> </li> <li> <c>IN</c> : checks for exact matches.
        /// <i>AttributeValueList</i> can contain more than one <i>AttributeValue</i> of type String, Number, or Binary (not a set). The target
        /// attribute of the comparison must be of the same type and exact value to match. A String never matches a String set. </li> <li>
        /// <c>BETWEEN</c> : Greater than or equal to the first value, and less than or equal to the second value. <i>AttributeValueList</i> must
        /// contain two <i>AttributeValue</i> elements of the same type, either String, Number, or Binary (not a set). A target attribute matches if the
        /// target value is greater than, or equal to, the first element and less than, or equal to, the second element. If an item contains an
        /// <i>AttributeValue</i> of a different type than the one specified in the request, the value does not match. For example, <c>{"S":"6"}</c>
        /// does not compare to <c>{"N":"6"}</c>. Also, <c>{"N":"6"}</c> does not compare to <c>{"NS":["6", "2", "1"]}</c> </li> </ul>
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Allowed Values</term>
        ///         <description>EQ, NE, IN, LE, LT, GE, GT, BETWEEN, NOT_NULL, NULL, CONTAINS, NOT_CONTAINS, BEGINS_WITH</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public ComparisonOperator ComparisonOperator
        {
            get { return this.comparisonOperator; }
            set { this.comparisonOperator = value; }
        }

        // Check to see if ComparisonOperator property is set
        internal bool IsSetComparisonOperator()
        {
            return this.comparisonOperator != null;
        }
    }
}
