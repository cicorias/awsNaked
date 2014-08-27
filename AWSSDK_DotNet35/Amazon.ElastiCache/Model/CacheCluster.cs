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

namespace Amazon.ElastiCache.Model
{
    /// <summary>
    /// Contains all of the attributes of a specific cache cluster.
    /// </summary>
    public partial class CacheCluster
    {
        private bool? _autoMinorVersionUpgrade;
        private DateTime? _cacheClusterCreateTime;
        private string _cacheClusterId;
        private string _cacheClusterStatus;
        private List<CacheNode> _cacheNodes = new List<CacheNode>();
        private string _cacheNodeType;
        private CacheParameterGroupStatus _cacheParameterGroup;
        private List<CacheSecurityGroupMembership> _cacheSecurityGroups = new List<CacheSecurityGroupMembership>();
        private string _cacheSubnetGroupName;
        private string _clientDownloadLandingPage;
        private Endpoint _configurationEndpoint;
        private string _engine;
        private string _engineVersion;
        private NotificationConfiguration _notificationConfiguration;
        private int? _numCacheNodes;
        private PendingModifiedValues _pendingModifiedValues;
        private string _preferredAvailabilityZone;
        private string _preferredMaintenanceWindow;
        private string _replicationGroupId;
        private List<SecurityGroupMembership> _securityGroups = new List<SecurityGroupMembership>();
        private int? _snapshotRetentionLimit;
        private string _snapshotWindow;


        /// <summary>
        /// Gets and sets the property AutoMinorVersionUpgrade. 
        /// <para>
        /// If <code>true</code>, then minor version patches are applied automatically; if <code>false</code>,
        /// then automatic minor version patches are disabled.
        /// </para>
        /// </summary>
        public bool AutoMinorVersionUpgrade
        {
            get { return this._autoMinorVersionUpgrade.GetValueOrDefault(); }
            set { this._autoMinorVersionUpgrade = value; }
        }

        // Check to see if AutoMinorVersionUpgrade property is set
        internal bool IsSetAutoMinorVersionUpgrade()
        {
            return this._autoMinorVersionUpgrade.HasValue; 
        }


        /// <summary>
        /// Gets and sets the property CacheClusterCreateTime. 
        /// <para>
        /// The date and time when the cache cluster was created.
        /// </para>
        /// </summary>
        public DateTime CacheClusterCreateTime
        {
            get { return this._cacheClusterCreateTime.GetValueOrDefault(); }
            set { this._cacheClusterCreateTime = value; }
        }

        // Check to see if CacheClusterCreateTime property is set
        internal bool IsSetCacheClusterCreateTime()
        {
            return this._cacheClusterCreateTime.HasValue; 
        }


        /// <summary>
        /// Gets and sets the property CacheClusterId. 
        /// <para>
        /// The user-supplied identifier of the cache cluster. This is a unique key that identifies
        /// a cache cluster.
        /// </para>
        /// </summary>
        public string CacheClusterId
        {
            get { return this._cacheClusterId; }
            set { this._cacheClusterId = value; }
        }

        // Check to see if CacheClusterId property is set
        internal bool IsSetCacheClusterId()
        {
            return this._cacheClusterId != null;
        }


        /// <summary>
        /// Gets and sets the property CacheClusterStatus. 
        /// <para>
        /// The current state of this cache cluster - <i>creating</i>, <i>available</i>, etc.
        /// </para>
        /// </summary>
        public string CacheClusterStatus
        {
            get { return this._cacheClusterStatus; }
            set { this._cacheClusterStatus = value; }
        }

        // Check to see if CacheClusterStatus property is set
        internal bool IsSetCacheClusterStatus()
        {
            return this._cacheClusterStatus != null;
        }


        /// <summary>
        /// Gets and sets the property CacheNodes. 
        /// <para>
        /// A list of cache nodes that are members of the cache cluster.
        /// </para>
        /// </summary>
        public List<CacheNode> CacheNodes
        {
            get { return this._cacheNodes; }
            set { this._cacheNodes = value; }
        }

        // Check to see if CacheNodes property is set
        internal bool IsSetCacheNodes()
        {
            return this._cacheNodes != null && this._cacheNodes.Count > 0; 
        }


        /// <summary>
        /// Gets and sets the property CacheNodeType. 
        /// <para>
        /// The name of the compute and memory capacity node type for the cache cluster.
        /// </para>
        /// </summary>
        public string CacheNodeType
        {
            get { return this._cacheNodeType; }
            set { this._cacheNodeType = value; }
        }

        // Check to see if CacheNodeType property is set
        internal bool IsSetCacheNodeType()
        {
            return this._cacheNodeType != null;
        }


        /// <summary>
        /// Gets and sets the property CacheParameterGroup.
        /// </summary>
        public CacheParameterGroupStatus CacheParameterGroup
        {
            get { return this._cacheParameterGroup; }
            set { this._cacheParameterGroup = value; }
        }

        // Check to see if CacheParameterGroup property is set
        internal bool IsSetCacheParameterGroup()
        {
            return this._cacheParameterGroup != null;
        }


        /// <summary>
        /// Gets and sets the property CacheSecurityGroups. 
        /// <para>
        /// A list of cache security group elements, composed of name and status sub-elements.
        /// </para>
        /// </summary>
        public List<CacheSecurityGroupMembership> CacheSecurityGroups
        {
            get { return this._cacheSecurityGroups; }
            set { this._cacheSecurityGroups = value; }
        }

        // Check to see if CacheSecurityGroups property is set
        internal bool IsSetCacheSecurityGroups()
        {
            return this._cacheSecurityGroups != null && this._cacheSecurityGroups.Count > 0; 
        }


        /// <summary>
        /// Gets and sets the property CacheSubnetGroupName. 
        /// <para>
        /// The name of the cache subnet group associated with the cache cluster.
        /// </para>
        /// </summary>
        public string CacheSubnetGroupName
        {
            get { return this._cacheSubnetGroupName; }
            set { this._cacheSubnetGroupName = value; }
        }

        // Check to see if CacheSubnetGroupName property is set
        internal bool IsSetCacheSubnetGroupName()
        {
            return this._cacheSubnetGroupName != null;
        }


        /// <summary>
        /// Gets and sets the property ClientDownloadLandingPage. 
        /// <para>
        /// The URL of the web page where you can download the latest ElastiCache client library.
        /// </para>
        /// </summary>
        public string ClientDownloadLandingPage
        {
            get { return this._clientDownloadLandingPage; }
            set { this._clientDownloadLandingPage = value; }
        }

        // Check to see if ClientDownloadLandingPage property is set
        internal bool IsSetClientDownloadLandingPage()
        {
            return this._clientDownloadLandingPage != null;
        }


        /// <summary>
        /// Gets and sets the property ConfigurationEndpoint.
        /// </summary>
        public Endpoint ConfigurationEndpoint
        {
            get { return this._configurationEndpoint; }
            set { this._configurationEndpoint = value; }
        }

        // Check to see if ConfigurationEndpoint property is set
        internal bool IsSetConfigurationEndpoint()
        {
            return this._configurationEndpoint != null;
        }


        /// <summary>
        /// Gets and sets the property Engine. 
        /// <para>
        /// The name of the cache engine (<i>memcached</i> or <i>redis</i>) to be used for this
        /// cache cluster.
        /// </para>
        /// </summary>
        public string Engine
        {
            get { return this._engine; }
            set { this._engine = value; }
        }

        // Check to see if Engine property is set
        internal bool IsSetEngine()
        {
            return this._engine != null;
        }


        /// <summary>
        /// Gets and sets the property EngineVersion. 
        /// <para>
        /// The version of the cache engine version that is used in this cache cluster.
        /// </para>
        /// </summary>
        public string EngineVersion
        {
            get { return this._engineVersion; }
            set { this._engineVersion = value; }
        }

        // Check to see if EngineVersion property is set
        internal bool IsSetEngineVersion()
        {
            return this._engineVersion != null;
        }


        /// <summary>
        /// Gets and sets the property NotificationConfiguration.
        /// </summary>
        public NotificationConfiguration NotificationConfiguration
        {
            get { return this._notificationConfiguration; }
            set { this._notificationConfiguration = value; }
        }

        // Check to see if NotificationConfiguration property is set
        internal bool IsSetNotificationConfiguration()
        {
            return this._notificationConfiguration != null;
        }


        /// <summary>
        /// Gets and sets the property NumCacheNodes. 
        /// <para>
        /// The number of cache nodes in the cache cluster.
        /// </para>
        /// </summary>
        public int NumCacheNodes
        {
            get { return this._numCacheNodes.GetValueOrDefault(); }
            set { this._numCacheNodes = value; }
        }

        // Check to see if NumCacheNodes property is set
        internal bool IsSetNumCacheNodes()
        {
            return this._numCacheNodes.HasValue; 
        }


        /// <summary>
        /// Gets and sets the property PendingModifiedValues.
        /// </summary>
        public PendingModifiedValues PendingModifiedValues
        {
            get { return this._pendingModifiedValues; }
            set { this._pendingModifiedValues = value; }
        }

        // Check to see if PendingModifiedValues property is set
        internal bool IsSetPendingModifiedValues()
        {
            return this._pendingModifiedValues != null;
        }


        /// <summary>
        /// Gets and sets the property PreferredAvailabilityZone. 
        /// <para>
        /// The name of the Availability Zone in which the cache cluster is located or "Multiple"
        /// if the cache nodes are located in different Availability Zones.
        /// </para>
        /// </summary>
        public string PreferredAvailabilityZone
        {
            get { return this._preferredAvailabilityZone; }
            set { this._preferredAvailabilityZone = value; }
        }

        // Check to see if PreferredAvailabilityZone property is set
        internal bool IsSetPreferredAvailabilityZone()
        {
            return this._preferredAvailabilityZone != null;
        }


        /// <summary>
        /// Gets and sets the property PreferredMaintenanceWindow. 
        /// <para>
        /// The time range (in UTC) during which weekly system maintenance can occur.
        /// </para>
        /// </summary>
        public string PreferredMaintenanceWindow
        {
            get { return this._preferredMaintenanceWindow; }
            set { this._preferredMaintenanceWindow = value; }
        }

        // Check to see if PreferredMaintenanceWindow property is set
        internal bool IsSetPreferredMaintenanceWindow()
        {
            return this._preferredMaintenanceWindow != null;
        }


        /// <summary>
        /// Gets and sets the property ReplicationGroupId. 
        /// <para>
        /// The replication group to which this cache cluster belongs. If this field is empty,
        /// the cache cluster is not associated with any replication group.
        /// </para>
        /// </summary>
        public string ReplicationGroupId
        {
            get { return this._replicationGroupId; }
            set { this._replicationGroupId = value; }
        }

        // Check to see if ReplicationGroupId property is set
        internal bool IsSetReplicationGroupId()
        {
            return this._replicationGroupId != null;
        }


        /// <summary>
        /// Gets and sets the property SecurityGroups. 
        /// <para>
        /// A list of VPC Security Groups associated with the cache cluster.
        /// </para>
        /// </summary>
        public List<SecurityGroupMembership> SecurityGroups
        {
            get { return this._securityGroups; }
            set { this._securityGroups = value; }
        }

        // Check to see if SecurityGroups property is set
        internal bool IsSetSecurityGroups()
        {
            return this._securityGroups != null && this._securityGroups.Count > 0; 
        }


        /// <summary>
        /// Gets and sets the property SnapshotRetentionLimit. 
        /// <para>
        /// The number of days for which ElastiCache will retain automatic cache cluster snapshots
        /// before deleting them. For example, if you set <i>SnapshotRetentionLimit</i> to 5,
        /// then a snapshot that was taken today will be retained for 5 days before being deleted.
        /// </para>
        ///  
        /// <para>
        /// <b>Important</b>If the value of SnapshotRetentionLimit is set to zero (0), backups
        /// are turned off.
        /// </para>
        /// </summary>
        public int SnapshotRetentionLimit
        {
            get { return this._snapshotRetentionLimit.GetValueOrDefault(); }
            set { this._snapshotRetentionLimit = value; }
        }

        // Check to see if SnapshotRetentionLimit property is set
        internal bool IsSetSnapshotRetentionLimit()
        {
            return this._snapshotRetentionLimit.HasValue; 
        }


        /// <summary>
        /// Gets and sets the property SnapshotWindow. 
        /// <para>
        /// The daily time range (in UTC) during which ElastiCache will begin taking a daily snapshot
        /// of your cache cluster.
        /// </para>
        ///  
        /// <para>
        /// Example: <code>05:00-09:00</code>
        /// </para>
        /// </summary>
        public string SnapshotWindow
        {
            get { return this._snapshotWindow; }
            set { this._snapshotWindow = value; }
        }

        // Check to see if SnapshotWindow property is set
        internal bool IsSetSnapshotWindow()
        {
            return this._snapshotWindow != null;
        }

    }
}