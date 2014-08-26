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
using System;
using System.Threading;
using System.Threading.Tasks;

using Amazon.ElastiCache.Model;

namespace Amazon.ElastiCache
{
    /// <summary>
    /// Implementation for accessing ElastiCache
    /// 
    /// Amazon ElastiCache
    /// <para>
    /// Amazon ElastiCache is a web service that makes it easier to set up, operate, and scale
    /// a distributed cache in the cloud.
    /// </para>
    /// 
    /// <para>
    /// With ElastiCache, customers gain all of the benefits of a high-performance, in-memory
    /// cache with far less of the administrative burden of launching and managing a distributed
    /// cache. The service makes set-up, scaling, and cluster failure handling much simpler
    /// than in a self-managed cache deployment.
    /// </para>
    /// 
    /// <para>
    /// In addition, through integration with Amazon CloudWatch, customers get enhanced visibility
    /// into the key performance statistics associated with their cache and can receive alarms
    /// if a part of their cache runs hot.
    /// </para>
    /// </summary>
	public partial interface IAmazonElastiCache : IDisposable
    {
 

        /// <summary>
        /// The <i>AuthorizeCacheSecurityGroupIngress</i> operation allows network ingress to
        /// a cache security group. Applications using ElastiCache must be running on Amazon EC2,
        /// and Amazon EC2 security groups are used as the authorization mechanism.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AuthorizeCacheSecurityGroupIngress service method.</param>
        /// 
        /// <returns>The response from the AuthorizeCacheSecurityGroupIngress service method, as returned by ElastiCache.</returns>
        /// <exception cref="T:Amazon.ElastiCache.Model.AuthorizationAlreadyExistsException">
        /// The specified Amazon EC2 security group is already authorized for the specified cache
        /// security group.
        /// </exception>
        /// <exception cref="T:Amazon.ElastiCache.Model.CacheSecurityGroupNotFoundException">
        /// The requested cache security group name does not refer to an existing cache security
        /// group.
        /// </exception>
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidCacheSecurityGroupStateException">
        /// The current state of the cache security group does not allow deletion.
        /// </exception>
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidParameterCombinationException">
        /// Two or more incompatible parameters were specified.
        /// </exception>
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidParameterValueException">
        /// The value for a parameter is invalid.
        /// </exception>
		AuthorizeCacheSecurityGroupIngressResponse AuthorizeCacheSecurityGroupIngress(AuthorizeCacheSecurityGroupIngressRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the AuthorizeCacheSecurityGroupIngress operation.
        /// <seealso cref="Amazon.ElastiCache.IAmazonElastiCache.AuthorizeCacheSecurityGroupIngress"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AuthorizeCacheSecurityGroupIngress operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<AuthorizeCacheSecurityGroupIngressResponse> AuthorizeCacheSecurityGroupIngressAsync(AuthorizeCacheSecurityGroupIngressRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// The <i>CopySnapshot</i> operation makes a copy of an existing snapshot.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CopySnapshot service method.</param>
        /// 
        /// <returns>The response from the CopySnapshot service method, as returned by ElastiCache.</returns>
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidParameterCombinationException">
        /// Two or more incompatible parameters were specified.
        /// </exception>
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidParameterValueException">
        /// The value for a parameter is invalid.
        /// </exception>
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidSnapshotStateException">
        /// The current state of the snapshot does not allow the requested action to occur.
        /// </exception>
        /// <exception cref="T:Amazon.ElastiCache.Model.SnapshotAlreadyExistsException">
        /// You already have a snapshot with the given name.
        /// </exception>
        /// <exception cref="T:Amazon.ElastiCache.Model.SnapshotNotFoundException">
        /// The requested snapshot name does not refer to an existing snapshot.
        /// </exception>
        /// <exception cref="T:Amazon.ElastiCache.Model.SnapshotQuotaExceededException">
        /// The request cannot be processed because it would exceed the maximum number of snapshots.
        /// </exception>
		CopySnapshotResponse CopySnapshot(CopySnapshotRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CopySnapshot operation.
        /// <seealso cref="Amazon.ElastiCache.IAmazonElastiCache.CopySnapshot"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CopySnapshot operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<CopySnapshotResponse> CopySnapshotAsync(CopySnapshotRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// The <i>CreateCacheCluster</i> operation creates a new cache cluster. All nodes in
        /// the cache cluster run the same protocol-compliant cache engine software - either Memcached
        /// or Redis.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCacheCluster service method.</param>
        /// 
        /// <returns>The response from the CreateCacheCluster service method, as returned by ElastiCache.</returns>
        /// <exception cref="T:Amazon.ElastiCache.Model.CacheClusterAlreadyExistsException">
        /// You already have a cache cluster with the given identifier.
        /// </exception>
        /// <exception cref="T:Amazon.ElastiCache.Model.CacheParameterGroupNotFoundException">
        /// The requested cache parameter group name does not refer to an existing cache parameter
        /// group.
        /// </exception>
        /// <exception cref="T:Amazon.ElastiCache.Model.CacheSecurityGroupNotFoundException">
        /// The requested cache security group name does not refer to an existing cache security
        /// group.
        /// </exception>
        /// <exception cref="T:Amazon.ElastiCache.Model.CacheSubnetGroupNotFoundException">
        /// The requested cache subnet group name does not refer to an existing cache subnet group.
        /// </exception>
        /// <exception cref="T:Amazon.ElastiCache.Model.ClusterQuotaForCustomerExceededException">
        /// The request cannot be processed because it would exceed the allowed number of cache
        /// clusters per customer.
        /// </exception>
        /// <exception cref="T:Amazon.ElastiCache.Model.InsufficientCacheClusterCapacityException">
        /// The requested cache node type is not available in the specified Availability Zone.
        /// </exception>
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidParameterCombinationException">
        /// Two or more incompatible parameters were specified.
        /// </exception>
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidParameterValueException">
        /// The value for a parameter is invalid.
        /// </exception>
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidReplicationGroupStateException">
        /// The requested replication group is not in the <i>available</i> state.
        /// </exception>
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidVPCNetworkStateException">
        /// The VPC network is in an invalid state.
        /// </exception>
        /// <exception cref="T:Amazon.ElastiCache.Model.NodeQuotaForClusterExceededException">
        /// The request cannot be processed because it would exceed the allowed number of cache
        /// nodes in a single cache cluster.
        /// </exception>
        /// <exception cref="T:Amazon.ElastiCache.Model.NodeQuotaForCustomerExceededException">
        /// The request cannot be processed because it would exceed the allowed number of cache
        /// nodes per customer.
        /// </exception>
        /// <exception cref="T:Amazon.ElastiCache.Model.ReplicationGroupNotFoundException">
        /// The specified replication group does not exist.
        /// </exception>
		CreateCacheClusterResponse CreateCacheCluster(CreateCacheClusterRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateCacheCluster operation.
        /// <seealso cref="Amazon.ElastiCache.IAmazonElastiCache.CreateCacheCluster"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateCacheCluster operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<CreateCacheClusterResponse> CreateCacheClusterAsync(CreateCacheClusterRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// The <i>CreateCacheParameterGroup</i> operation creates a new cache parameter group.
        /// A cache parameter group is a collection of parameters that you apply to all of the
        /// nodes in a cache cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCacheParameterGroup service method.</param>
        /// 
        /// <returns>The response from the CreateCacheParameterGroup service method, as returned by ElastiCache.</returns>
        /// <exception cref="T:Amazon.ElastiCache.Model.CacheParameterGroupAlreadyExistsException">
        /// A cache parameter group with the requested name already exists.
        /// </exception>
        /// <exception cref="T:Amazon.ElastiCache.Model.CacheParameterGroupQuotaExceededException">
        /// The request cannot be processed because it would exceed the maximum number of cache
        /// security groups.
        /// </exception>
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidCacheParameterGroupStateException">
        /// The current state of the cache parameter group does not allow the requested action
        /// to occur.
        /// </exception>
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidParameterCombinationException">
        /// Two or more incompatible parameters were specified.
        /// </exception>
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidParameterValueException">
        /// The value for a parameter is invalid.
        /// </exception>
		CreateCacheParameterGroupResponse CreateCacheParameterGroup(CreateCacheParameterGroupRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateCacheParameterGroup operation.
        /// <seealso cref="Amazon.ElastiCache.IAmazonElastiCache.CreateCacheParameterGroup"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateCacheParameterGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<CreateCacheParameterGroupResponse> CreateCacheParameterGroupAsync(CreateCacheParameterGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// The <i>CreateCacheSecurityGroup</i> operation creates a new cache security group.
        /// Use a cache security group to control access to one or more cache clusters.
        /// 
        /// 
        /// <para>
        /// Cache security groups are only used when you are creating a cluster outside of an
        /// Amazon Virtual Private Cloud (VPC). If you are creating a cluster inside of a VPC,
        /// use a cache subnet group instead. For more information, see <i>CreateCacheSubnetGroup</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCacheSecurityGroup service method.</param>
        /// 
        /// <returns>The response from the CreateCacheSecurityGroup service method, as returned by ElastiCache.</returns>
        /// <exception cref="T:Amazon.ElastiCache.Model.CacheSecurityGroupAlreadyExistsException">
        /// A cache security group with the specified name already exists.
        /// </exception>
        /// <exception cref="T:Amazon.ElastiCache.Model.CacheSecurityGroupQuotaExceededException">
        /// The request cannot be processed because it would exceed the allowed number of cache
        /// security groups.
        /// </exception>
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidParameterCombinationException">
        /// Two or more incompatible parameters were specified.
        /// </exception>
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidParameterValueException">
        /// The value for a parameter is invalid.
        /// </exception>
		CreateCacheSecurityGroupResponse CreateCacheSecurityGroup(CreateCacheSecurityGroupRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateCacheSecurityGroup operation.
        /// <seealso cref="Amazon.ElastiCache.IAmazonElastiCache.CreateCacheSecurityGroup"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateCacheSecurityGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<CreateCacheSecurityGroupResponse> CreateCacheSecurityGroupAsync(CreateCacheSecurityGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// The <i>CreateCacheSubnetGroup</i> operation creates a new cache subnet group.
        /// 
        /// 
        /// <para>
        /// Use this parameter only when you are creating a cluster in an Amazon Virtual Private
        /// Cloud (VPC).
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCacheSubnetGroup service method.</param>
        /// 
        /// <returns>The response from the CreateCacheSubnetGroup service method, as returned by ElastiCache.</returns>
        /// <exception cref="T:Amazon.ElastiCache.Model.CacheSubnetGroupAlreadyExistsException">
        /// The requested cache subnet group name is already in use by an existing cache subnet
        /// group.
        /// </exception>
        /// <exception cref="T:Amazon.ElastiCache.Model.CacheSubnetGroupQuotaExceededException">
        /// The request cannot be processed because it would exceed the allowed number of cache
        /// subnet groups.
        /// </exception>
        /// <exception cref="T:Amazon.ElastiCache.Model.CacheSubnetQuotaExceededException">
        /// The request cannot be processed because it would exceed the allowed number of subnets
        /// in a cache subnet group.
        /// </exception>
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidSubnetException">
        /// An invalid subnet identifier was specified.
        /// </exception>
		CreateCacheSubnetGroupResponse CreateCacheSubnetGroup(CreateCacheSubnetGroupRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateCacheSubnetGroup operation.
        /// <seealso cref="Amazon.ElastiCache.IAmazonElastiCache.CreateCacheSubnetGroup"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateCacheSubnetGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<CreateCacheSubnetGroupResponse> CreateCacheSubnetGroupAsync(CreateCacheSubnetGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// The <i>CreateReplicationGroup</i> operation creates a replication group. A replication
        /// group is a collection of cache clusters, where one of the clusters is a read/write
        /// primary and the other clusters are read-only replicas. Writes to the primary are automatically
        /// propagated to the replicas.
        /// 
        /// 
        /// <para>
        /// When you create a replication group, you must specify an existing cache cluster that
        /// is in the primary role. When the replication group has been successfully created,
        /// you can add one or more read replica replicas to it, up to a total of five read replicas.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateReplicationGroup service method.</param>
        /// 
        /// <returns>The response from the CreateReplicationGroup service method, as returned by ElastiCache.</returns>
        /// <exception cref="T:Amazon.ElastiCache.Model.CacheClusterNotFoundException">
        /// The requested cache cluster ID does not refer to an existing cache cluster.
        /// </exception>
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidCacheClusterStateException">
        /// The requested cache cluster is not in the <i>available</i> state.
        /// </exception>
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidParameterCombinationException">
        /// Two or more incompatible parameters were specified.
        /// </exception>
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidParameterValueException">
        /// The value for a parameter is invalid.
        /// </exception>
        /// <exception cref="T:Amazon.ElastiCache.Model.ReplicationGroupAlreadyExistsException">
        /// The specified replication group already exists.
        /// </exception>
		CreateReplicationGroupResponse CreateReplicationGroup(CreateReplicationGroupRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateReplicationGroup operation.
        /// <seealso cref="Amazon.ElastiCache.IAmazonElastiCache.CreateReplicationGroup"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateReplicationGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<CreateReplicationGroupResponse> CreateReplicationGroupAsync(CreateReplicationGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// The <i>CreateSnapshot</i> operation creates a copy of an entire cache cluster at a
        /// specific moment in time.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSnapshot service method.</param>
        /// 
        /// <returns>The response from the CreateSnapshot service method, as returned by ElastiCache.</returns>
        /// <exception cref="T:Amazon.ElastiCache.Model.CacheClusterNotFoundException">
        /// The requested cache cluster ID does not refer to an existing cache cluster.
        /// </exception>
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidCacheClusterStateException">
        /// The requested cache cluster is not in the <i>available</i> state.
        /// </exception>
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidParameterCombinationException">
        /// Two or more incompatible parameters were specified.
        /// </exception>
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidParameterValueException">
        /// The value for a parameter is invalid.
        /// </exception>
        /// <exception cref="T:Amazon.ElastiCache.Model.SnapshotAlreadyExistsException">
        /// You already have a snapshot with the given name.
        /// </exception>
        /// <exception cref="T:Amazon.ElastiCache.Model.SnapshotFeatureNotSupportedException">
        /// You attempted one of the following actions:
        /// 
        /// <ul> <li>
        /// <para>
        /// Creating a snapshot of a Redis cache cluster running on a a <i>t1.micro</i> cache
        /// node.
        /// </para>
        /// </li> <li>
        /// <para>
        /// Creating a snapshot of a cache cluster that is running Memcached rather than Redis.
        /// </para>
        /// </li> </ul>
        /// <para>
        /// Neither of these are supported by ElastiCache.
        /// </para>
        /// </exception>
        /// <exception cref="T:Amazon.ElastiCache.Model.SnapshotQuotaExceededException">
        /// The request cannot be processed because it would exceed the maximum number of snapshots.
        /// </exception>
		CreateSnapshotResponse CreateSnapshot(CreateSnapshotRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateSnapshot operation.
        /// <seealso cref="Amazon.ElastiCache.IAmazonElastiCache.CreateSnapshot"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateSnapshot operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<CreateSnapshotResponse> CreateSnapshotAsync(CreateSnapshotRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// The <i>DeleteCacheCluster</i> operation deletes a previously provisioned cache cluster.
        /// <i>DeleteCacheCluster</i> deletes all associated cache nodes, node endpoints and the
        /// cache cluster itself. When you receive a successful response from this operation,
        /// Amazon ElastiCache immediately begins deleting the cache cluster; you cannot cancel
        /// or revert this operation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCacheCluster service method.</param>
        /// 
        /// <returns>The response from the DeleteCacheCluster service method, as returned by ElastiCache.</returns>
        /// <exception cref="T:Amazon.ElastiCache.Model.CacheClusterNotFoundException">
        /// The requested cache cluster ID does not refer to an existing cache cluster.
        /// </exception>
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidCacheClusterStateException">
        /// The requested cache cluster is not in the <i>available</i> state.
        /// </exception>
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidParameterCombinationException">
        /// Two or more incompatible parameters were specified.
        /// </exception>
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidParameterValueException">
        /// The value for a parameter is invalid.
        /// </exception>
        /// <exception cref="T:Amazon.ElastiCache.Model.SnapshotAlreadyExistsException">
        /// You already have a snapshot with the given name.
        /// </exception>
        /// <exception cref="T:Amazon.ElastiCache.Model.SnapshotFeatureNotSupportedException">
        /// You attempted one of the following actions:
        /// 
        /// <ul> <li>
        /// <para>
        /// Creating a snapshot of a Redis cache cluster running on a a <i>t1.micro</i> cache
        /// node.
        /// </para>
        /// </li> <li>
        /// <para>
        /// Creating a snapshot of a cache cluster that is running Memcached rather than Redis.
        /// </para>
        /// </li> </ul>
        /// <para>
        /// Neither of these are supported by ElastiCache.
        /// </para>
        /// </exception>
        /// <exception cref="T:Amazon.ElastiCache.Model.SnapshotQuotaExceededException">
        /// The request cannot be processed because it would exceed the maximum number of snapshots.
        /// </exception>
		DeleteCacheClusterResponse DeleteCacheCluster(DeleteCacheClusterRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteCacheCluster operation.
        /// <seealso cref="Amazon.ElastiCache.IAmazonElastiCache.DeleteCacheCluster"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteCacheCluster operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<DeleteCacheClusterResponse> DeleteCacheClusterAsync(DeleteCacheClusterRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// The <i>DeleteCacheParameterGroup</i> operation deletes the specified cache parameter
        /// group. You cannot delete a cache parameter group if it is associated with any cache
        /// clusters.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCacheParameterGroup service method.</param>
        /// 
        /// <returns>The response from the DeleteCacheParameterGroup service method, as returned by ElastiCache.</returns>
        /// <exception cref="T:Amazon.ElastiCache.Model.CacheParameterGroupNotFoundException">
        /// The requested cache parameter group name does not refer to an existing cache parameter
        /// group.
        /// </exception>
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidCacheParameterGroupStateException">
        /// The current state of the cache parameter group does not allow the requested action
        /// to occur.
        /// </exception>
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidParameterCombinationException">
        /// Two or more incompatible parameters were specified.
        /// </exception>
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidParameterValueException">
        /// The value for a parameter is invalid.
        /// </exception>
		DeleteCacheParameterGroupResponse DeleteCacheParameterGroup(DeleteCacheParameterGroupRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteCacheParameterGroup operation.
        /// <seealso cref="Amazon.ElastiCache.IAmazonElastiCache.DeleteCacheParameterGroup"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteCacheParameterGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<DeleteCacheParameterGroupResponse> DeleteCacheParameterGroupAsync(DeleteCacheParameterGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// The <i>DeleteCacheSecurityGroup</i> operation deletes a cache security group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCacheSecurityGroup service method.</param>
        /// 
        /// <returns>The response from the DeleteCacheSecurityGroup service method, as returned by ElastiCache.</returns>
        /// <exception cref="T:Amazon.ElastiCache.Model.CacheSecurityGroupNotFoundException">
        /// The requested cache security group name does not refer to an existing cache security
        /// group.
        /// </exception>
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidCacheSecurityGroupStateException">
        /// The current state of the cache security group does not allow deletion.
        /// </exception>
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidParameterCombinationException">
        /// Two or more incompatible parameters were specified.
        /// </exception>
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidParameterValueException">
        /// The value for a parameter is invalid.
        /// </exception>
		DeleteCacheSecurityGroupResponse DeleteCacheSecurityGroup(DeleteCacheSecurityGroupRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteCacheSecurityGroup operation.
        /// <seealso cref="Amazon.ElastiCache.IAmazonElastiCache.DeleteCacheSecurityGroup"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteCacheSecurityGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<DeleteCacheSecurityGroupResponse> DeleteCacheSecurityGroupAsync(DeleteCacheSecurityGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// The <i>DeleteCacheSubnetGroup</i> operation deletes a cache subnet group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCacheSubnetGroup service method.</param>
        /// 
        /// <returns>The response from the DeleteCacheSubnetGroup service method, as returned by ElastiCache.</returns>
        /// <exception cref="T:Amazon.ElastiCache.Model.CacheSubnetGroupInUseException">
        /// The requested cache subnet group is currently in use.
        /// </exception>
        /// <exception cref="T:Amazon.ElastiCache.Model.CacheSubnetGroupNotFoundException">
        /// The requested cache subnet group name does not refer to an existing cache subnet group.
        /// </exception>
		DeleteCacheSubnetGroupResponse DeleteCacheSubnetGroup(DeleteCacheSubnetGroupRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteCacheSubnetGroup operation.
        /// <seealso cref="Amazon.ElastiCache.IAmazonElastiCache.DeleteCacheSubnetGroup"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteCacheSubnetGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<DeleteCacheSubnetGroupResponse> DeleteCacheSubnetGroupAsync(DeleteCacheSubnetGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// The <i>DeleteReplicationGroup</i> operation deletes an existing replication group.
        /// By default, this operation deletes the entire replication group, including the primary
        /// cache cluster and all of the read replicas. You can optionally delete only the read
        /// replicas, while retaining the primary cache cluster.
        /// 
        /// 
        /// <para>
        /// When you receive a successful response from this operation, Amazon ElastiCache immediately
        /// begins deleting the selected resources; you cannot cancel or revert this operation.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteReplicationGroup service method.</param>
        /// 
        /// <returns>The response from the DeleteReplicationGroup service method, as returned by ElastiCache.</returns>
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidParameterCombinationException">
        /// Two or more incompatible parameters were specified.
        /// </exception>
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidParameterValueException">
        /// The value for a parameter is invalid.
        /// </exception>
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidReplicationGroupStateException">
        /// The requested replication group is not in the <i>available</i> state.
        /// </exception>
        /// <exception cref="T:Amazon.ElastiCache.Model.ReplicationGroupNotFoundException">
        /// The specified replication group does not exist.
        /// </exception>
        /// <exception cref="T:Amazon.ElastiCache.Model.SnapshotAlreadyExistsException">
        /// You already have a snapshot with the given name.
        /// </exception>
        /// <exception cref="T:Amazon.ElastiCache.Model.SnapshotFeatureNotSupportedException">
        /// You attempted one of the following actions:
        /// 
        /// <ul> <li>
        /// <para>
        /// Creating a snapshot of a Redis cache cluster running on a a <i>t1.micro</i> cache
        /// node.
        /// </para>
        /// </li> <li>
        /// <para>
        /// Creating a snapshot of a cache cluster that is running Memcached rather than Redis.
        /// </para>
        /// </li> </ul>
        /// <para>
        /// Neither of these are supported by ElastiCache.
        /// </para>
        /// </exception>
        /// <exception cref="T:Amazon.ElastiCache.Model.SnapshotQuotaExceededException">
        /// The request cannot be processed because it would exceed the maximum number of snapshots.
        /// </exception>
		DeleteReplicationGroupResponse DeleteReplicationGroup(DeleteReplicationGroupRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteReplicationGroup operation.
        /// <seealso cref="Amazon.ElastiCache.IAmazonElastiCache.DeleteReplicationGroup"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteReplicationGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<DeleteReplicationGroupResponse> DeleteReplicationGroupAsync(DeleteReplicationGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// The <i>DeleteSnapshot</i> operation deletes an existing snapshot. When you receive
        /// a successful response from this operation, ElastiCache immediately begins deleting
        /// the snapshot; you cannot cancel or revert this operation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSnapshot service method.</param>
        /// 
        /// <returns>The response from the DeleteSnapshot service method, as returned by ElastiCache.</returns>
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidParameterCombinationException">
        /// Two or more incompatible parameters were specified.
        /// </exception>
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidParameterValueException">
        /// The value for a parameter is invalid.
        /// </exception>
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidSnapshotStateException">
        /// The current state of the snapshot does not allow the requested action to occur.
        /// </exception>
        /// <exception cref="T:Amazon.ElastiCache.Model.SnapshotNotFoundException">
        /// The requested snapshot name does not refer to an existing snapshot.
        /// </exception>
		DeleteSnapshotResponse DeleteSnapshot(DeleteSnapshotRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteSnapshot operation.
        /// <seealso cref="Amazon.ElastiCache.IAmazonElastiCache.DeleteSnapshot"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteSnapshot operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<DeleteSnapshotResponse> DeleteSnapshotAsync(DeleteSnapshotRequest request, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// The <i>DescribeCacheClusters</i> operation returns information about all provisioned
        /// cache clusters if no cache cluster identifier is specified, or about a specific cache
        /// cluster if a cache cluster identifier is supplied.
        /// 
        /// 
        /// <para>
        /// By default, abbreviated information about the cache clusters(s) will be returned.
        /// You can use the optional <i>ShowDetails</i> flag to retrieve detailed information
        /// about the cache nodes associated with the cache clusters. These details include the
        /// DNS address and port for the cache node endpoint.
        /// </para>
        /// 
        /// <para>
        /// If the cluster is in the CREATING state, only cluster level information will be displayed
        /// until all of the nodes are successfully provisioned.
        /// </para>
        /// 
        /// <para>
        /// If the cluster is in the DELETING state, only cluster level information will be displayed.
        /// </para>
        /// 
        /// <para>
        /// If cache nodes are currently being added to the cache cluster, node endpoint information
        /// and creation time for the additional nodes will not be displayed until they are completely
        /// provisioned. When the cache cluster state is <i>available</i>, the cluster is ready
        /// for use.
        /// </para>
        /// 
        /// <para>
        /// If cache nodes are currently being removed from the cache cluster, no endpoint information
        /// for the removed nodes is displayed.
        /// </para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeCacheClusters service method, as returned by ElastiCache.</returns>
        /// <exception cref="T:Amazon.ElastiCache.Model.CacheClusterNotFoundException">
        /// The requested cache cluster ID does not refer to an existing cache cluster.
        /// </exception>
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidParameterCombinationException">
        /// Two or more incompatible parameters were specified.
        /// </exception>
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidParameterValueException">
        /// The value for a parameter is invalid.
        /// </exception>
		DescribeCacheClustersResponse DescribeCacheClusters();
 

        /// <summary>
        /// The <i>DescribeCacheClusters</i> operation returns information about all provisioned
        /// cache clusters if no cache cluster identifier is specified, or about a specific cache
        /// cluster if a cache cluster identifier is supplied.
        /// 
        /// 
        /// <para>
        /// By default, abbreviated information about the cache clusters(s) will be returned.
        /// You can use the optional <i>ShowDetails</i> flag to retrieve detailed information
        /// about the cache nodes associated with the cache clusters. These details include the
        /// DNS address and port for the cache node endpoint.
        /// </para>
        /// 
        /// <para>
        /// If the cluster is in the CREATING state, only cluster level information will be displayed
        /// until all of the nodes are successfully provisioned.
        /// </para>
        /// 
        /// <para>
        /// If the cluster is in the DELETING state, only cluster level information will be displayed.
        /// </para>
        /// 
        /// <para>
        /// If cache nodes are currently being added to the cache cluster, node endpoint information
        /// and creation time for the additional nodes will not be displayed until they are completely
        /// provisioned. When the cache cluster state is <i>available</i>, the cluster is ready
        /// for use.
        /// </para>
        /// 
        /// <para>
        /// If cache nodes are currently being removed from the cache cluster, no endpoint information
        /// for the removed nodes is displayed.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeCacheClusters service method.</param>
        /// 
        /// <returns>The response from the DescribeCacheClusters service method, as returned by ElastiCache.</returns>
        /// <exception cref="T:Amazon.ElastiCache.Model.CacheClusterNotFoundException">
        /// The requested cache cluster ID does not refer to an existing cache cluster.
        /// </exception>
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidParameterCombinationException">
        /// Two or more incompatible parameters were specified.
        /// </exception>
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidParameterValueException">
        /// The value for a parameter is invalid.
        /// </exception>
		DescribeCacheClustersResponse DescribeCacheClusters(DescribeCacheClustersRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeCacheClusters operation.
        /// <seealso cref="Amazon.ElastiCache.IAmazonElastiCache.DescribeCacheClusters"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeCacheClusters operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<DescribeCacheClustersResponse> DescribeCacheClustersAsync(DescribeCacheClustersRequest request, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// The <i>DescribeCacheEngineVersions</i> operation returns a list of the available cache
        /// engines and their versions.
        /// </summary>
        /// 
        /// <returns>The response from the DescribeCacheEngineVersions service method, as returned by ElastiCache.</returns>
		DescribeCacheEngineVersionsResponse DescribeCacheEngineVersions();
 

        /// <summary>
        /// The <i>DescribeCacheEngineVersions</i> operation returns a list of the available cache
        /// engines and their versions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeCacheEngineVersions service method.</param>
        /// 
        /// <returns>The response from the DescribeCacheEngineVersions service method, as returned by ElastiCache.</returns>
		DescribeCacheEngineVersionsResponse DescribeCacheEngineVersions(DescribeCacheEngineVersionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeCacheEngineVersions operation.
        /// <seealso cref="Amazon.ElastiCache.IAmazonElastiCache.DescribeCacheEngineVersions"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeCacheEngineVersions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<DescribeCacheEngineVersionsResponse> DescribeCacheEngineVersionsAsync(DescribeCacheEngineVersionsRequest request, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// The <i>DescribeCacheParameterGroups</i> operation returns a list of cache parameter
        /// group descriptions. If a cache parameter group name is specified, the list will contain
        /// only the descriptions for that group.
        /// </summary>
        /// 
        /// <returns>The response from the DescribeCacheParameterGroups service method, as returned by ElastiCache.</returns>
        /// <exception cref="T:Amazon.ElastiCache.Model.CacheParameterGroupNotFoundException">
        /// The requested cache parameter group name does not refer to an existing cache parameter
        /// group.
        /// </exception>
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidParameterCombinationException">
        /// Two or more incompatible parameters were specified.
        /// </exception>
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidParameterValueException">
        /// The value for a parameter is invalid.
        /// </exception>
		DescribeCacheParameterGroupsResponse DescribeCacheParameterGroups();
 

        /// <summary>
        /// The <i>DescribeCacheParameterGroups</i> operation returns a list of cache parameter
        /// group descriptions. If a cache parameter group name is specified, the list will contain
        /// only the descriptions for that group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeCacheParameterGroups service method.</param>
        /// 
        /// <returns>The response from the DescribeCacheParameterGroups service method, as returned by ElastiCache.</returns>
        /// <exception cref="T:Amazon.ElastiCache.Model.CacheParameterGroupNotFoundException">
        /// The requested cache parameter group name does not refer to an existing cache parameter
        /// group.
        /// </exception>
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidParameterCombinationException">
        /// Two or more incompatible parameters were specified.
        /// </exception>
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidParameterValueException">
        /// The value for a parameter is invalid.
        /// </exception>
		DescribeCacheParameterGroupsResponse DescribeCacheParameterGroups(DescribeCacheParameterGroupsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeCacheParameterGroups operation.
        /// <seealso cref="Amazon.ElastiCache.IAmazonElastiCache.DescribeCacheParameterGroups"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeCacheParameterGroups operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<DescribeCacheParameterGroupsResponse> DescribeCacheParameterGroupsAsync(DescribeCacheParameterGroupsRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// The <i>DescribeCacheParameters</i> operation returns the detailed parameter list for
        /// a particular cache parameter group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeCacheParameters service method.</param>
        /// 
        /// <returns>The response from the DescribeCacheParameters service method, as returned by ElastiCache.</returns>
        /// <exception cref="T:Amazon.ElastiCache.Model.CacheParameterGroupNotFoundException">
        /// The requested cache parameter group name does not refer to an existing cache parameter
        /// group.
        /// </exception>
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidParameterCombinationException">
        /// Two or more incompatible parameters were specified.
        /// </exception>
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidParameterValueException">
        /// The value for a parameter is invalid.
        /// </exception>
		DescribeCacheParametersResponse DescribeCacheParameters(DescribeCacheParametersRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeCacheParameters operation.
        /// <seealso cref="Amazon.ElastiCache.IAmazonElastiCache.DescribeCacheParameters"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeCacheParameters operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<DescribeCacheParametersResponse> DescribeCacheParametersAsync(DescribeCacheParametersRequest request, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// The <i>DescribeCacheSecurityGroups</i> operation returns a list of cache security
        /// group descriptions. If a cache security group name is specified, the list will contain
        /// only the description of that group.
        /// </summary>
        /// 
        /// <returns>The response from the DescribeCacheSecurityGroups service method, as returned by ElastiCache.</returns>
        /// <exception cref="T:Amazon.ElastiCache.Model.CacheSecurityGroupNotFoundException">
        /// The requested cache security group name does not refer to an existing cache security
        /// group.
        /// </exception>
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidParameterCombinationException">
        /// Two or more incompatible parameters were specified.
        /// </exception>
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidParameterValueException">
        /// The value for a parameter is invalid.
        /// </exception>
		DescribeCacheSecurityGroupsResponse DescribeCacheSecurityGroups();
 

        /// <summary>
        /// The <i>DescribeCacheSecurityGroups</i> operation returns a list of cache security
        /// group descriptions. If a cache security group name is specified, the list will contain
        /// only the description of that group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeCacheSecurityGroups service method.</param>
        /// 
        /// <returns>The response from the DescribeCacheSecurityGroups service method, as returned by ElastiCache.</returns>
        /// <exception cref="T:Amazon.ElastiCache.Model.CacheSecurityGroupNotFoundException">
        /// The requested cache security group name does not refer to an existing cache security
        /// group.
        /// </exception>
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidParameterCombinationException">
        /// Two or more incompatible parameters were specified.
        /// </exception>
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidParameterValueException">
        /// The value for a parameter is invalid.
        /// </exception>
		DescribeCacheSecurityGroupsResponse DescribeCacheSecurityGroups(DescribeCacheSecurityGroupsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeCacheSecurityGroups operation.
        /// <seealso cref="Amazon.ElastiCache.IAmazonElastiCache.DescribeCacheSecurityGroups"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeCacheSecurityGroups operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<DescribeCacheSecurityGroupsResponse> DescribeCacheSecurityGroupsAsync(DescribeCacheSecurityGroupsRequest request, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// The <i>DescribeCacheSubnetGroups</i> operation returns a list of cache subnet group
        /// descriptions. If a subnet group name is specified, the list will contain only the
        /// description of that group.
        /// </summary>
        /// 
        /// <returns>The response from the DescribeCacheSubnetGroups service method, as returned by ElastiCache.</returns>
        /// <exception cref="T:Amazon.ElastiCache.Model.CacheSubnetGroupNotFoundException">
        /// The requested cache subnet group name does not refer to an existing cache subnet group.
        /// </exception>
		DescribeCacheSubnetGroupsResponse DescribeCacheSubnetGroups();
 

        /// <summary>
        /// The <i>DescribeCacheSubnetGroups</i> operation returns a list of cache subnet group
        /// descriptions. If a subnet group name is specified, the list will contain only the
        /// description of that group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeCacheSubnetGroups service method.</param>
        /// 
        /// <returns>The response from the DescribeCacheSubnetGroups service method, as returned by ElastiCache.</returns>
        /// <exception cref="T:Amazon.ElastiCache.Model.CacheSubnetGroupNotFoundException">
        /// The requested cache subnet group name does not refer to an existing cache subnet group.
        /// </exception>
		DescribeCacheSubnetGroupsResponse DescribeCacheSubnetGroups(DescribeCacheSubnetGroupsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeCacheSubnetGroups operation.
        /// <seealso cref="Amazon.ElastiCache.IAmazonElastiCache.DescribeCacheSubnetGroups"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeCacheSubnetGroups operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<DescribeCacheSubnetGroupsResponse> DescribeCacheSubnetGroupsAsync(DescribeCacheSubnetGroupsRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// The <i>DescribeEngineDefaultParameters</i> operation returns the default engine and
        /// system parameter information for the specified cache engine.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeEngineDefaultParameters service method.</param>
        /// 
        /// <returns>The response from the DescribeEngineDefaultParameters service method, as returned by ElastiCache.</returns>
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidParameterCombinationException">
        /// Two or more incompatible parameters were specified.
        /// </exception>
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidParameterValueException">
        /// The value for a parameter is invalid.
        /// </exception>
		DescribeEngineDefaultParametersResponse DescribeEngineDefaultParameters(DescribeEngineDefaultParametersRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeEngineDefaultParameters operation.
        /// <seealso cref="Amazon.ElastiCache.IAmazonElastiCache.DescribeEngineDefaultParameters"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeEngineDefaultParameters operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<DescribeEngineDefaultParametersResponse> DescribeEngineDefaultParametersAsync(DescribeEngineDefaultParametersRequest request, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// The <i>DescribeEvents</i> operation returns events related to cache clusters, cache
        /// security groups, and cache parameter groups. You can obtain events specific to a particular
        /// cache cluster, cache security group, or cache parameter group by providing the name
        /// as a parameter.
        /// 
        /// 
        /// <para>
        /// By default, only the events occurring within the last hour are returned; however,
        /// you can retrieve up to 14 days' worth of events if necessary.
        /// </para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeEvents service method, as returned by ElastiCache.</returns>
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidParameterCombinationException">
        /// Two or more incompatible parameters were specified.
        /// </exception>
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidParameterValueException">
        /// The value for a parameter is invalid.
        /// </exception>
		DescribeEventsResponse DescribeEvents();
 

        /// <summary>
        /// The <i>DescribeEvents</i> operation returns events related to cache clusters, cache
        /// security groups, and cache parameter groups. You can obtain events specific to a particular
        /// cache cluster, cache security group, or cache parameter group by providing the name
        /// as a parameter.
        /// 
        /// 
        /// <para>
        /// By default, only the events occurring within the last hour are returned; however,
        /// you can retrieve up to 14 days' worth of events if necessary.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeEvents service method.</param>
        /// 
        /// <returns>The response from the DescribeEvents service method, as returned by ElastiCache.</returns>
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidParameterCombinationException">
        /// Two or more incompatible parameters were specified.
        /// </exception>
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidParameterValueException">
        /// The value for a parameter is invalid.
        /// </exception>
		DescribeEventsResponse DescribeEvents(DescribeEventsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeEvents operation.
        /// <seealso cref="Amazon.ElastiCache.IAmazonElastiCache.DescribeEvents"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeEvents operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<DescribeEventsResponse> DescribeEventsAsync(DescribeEventsRequest request, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// The <i>DescribeReplicationGroups</i> operation returns information about a particular
        /// replication group. If no identifier is specified, <i>DescribeReplicationGroups</i>
        /// returns information about all replication groups.
        /// </summary>
        /// 
        /// <returns>The response from the DescribeReplicationGroups service method, as returned by ElastiCache.</returns>
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidParameterCombinationException">
        /// Two or more incompatible parameters were specified.
        /// </exception>
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidParameterValueException">
        /// The value for a parameter is invalid.
        /// </exception>
        /// <exception cref="T:Amazon.ElastiCache.Model.ReplicationGroupNotFoundException">
        /// The specified replication group does not exist.
        /// </exception>
		DescribeReplicationGroupsResponse DescribeReplicationGroups();
 

        /// <summary>
        /// The <i>DescribeReplicationGroups</i> operation returns information about a particular
        /// replication group. If no identifier is specified, <i>DescribeReplicationGroups</i>
        /// returns information about all replication groups.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeReplicationGroups service method.</param>
        /// 
        /// <returns>The response from the DescribeReplicationGroups service method, as returned by ElastiCache.</returns>
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidParameterCombinationException">
        /// Two or more incompatible parameters were specified.
        /// </exception>
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidParameterValueException">
        /// The value for a parameter is invalid.
        /// </exception>
        /// <exception cref="T:Amazon.ElastiCache.Model.ReplicationGroupNotFoundException">
        /// The specified replication group does not exist.
        /// </exception>
		DescribeReplicationGroupsResponse DescribeReplicationGroups(DescribeReplicationGroupsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeReplicationGroups operation.
        /// <seealso cref="Amazon.ElastiCache.IAmazonElastiCache.DescribeReplicationGroups"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeReplicationGroups operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<DescribeReplicationGroupsResponse> DescribeReplicationGroupsAsync(DescribeReplicationGroupsRequest request, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// The <i>DescribeReservedCacheNodes</i> operation returns information about reserved
        /// cache nodes for this account, or about a specified reserved cache node.
        /// </summary>
        /// 
        /// <returns>The response from the DescribeReservedCacheNodes service method, as returned by ElastiCache.</returns>
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidParameterCombinationException">
        /// Two or more incompatible parameters were specified.
        /// </exception>
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidParameterValueException">
        /// The value for a parameter is invalid.
        /// </exception>
        /// <exception cref="T:Amazon.ElastiCache.Model.ReservedCacheNodeNotFoundException">
        /// The requested reserved cache node was not found.
        /// </exception>
		DescribeReservedCacheNodesResponse DescribeReservedCacheNodes();
 

        /// <summary>
        /// The <i>DescribeReservedCacheNodes</i> operation returns information about reserved
        /// cache nodes for this account, or about a specified reserved cache node.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeReservedCacheNodes service method.</param>
        /// 
        /// <returns>The response from the DescribeReservedCacheNodes service method, as returned by ElastiCache.</returns>
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidParameterCombinationException">
        /// Two or more incompatible parameters were specified.
        /// </exception>
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidParameterValueException">
        /// The value for a parameter is invalid.
        /// </exception>
        /// <exception cref="T:Amazon.ElastiCache.Model.ReservedCacheNodeNotFoundException">
        /// The requested reserved cache node was not found.
        /// </exception>
		DescribeReservedCacheNodesResponse DescribeReservedCacheNodes(DescribeReservedCacheNodesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeReservedCacheNodes operation.
        /// <seealso cref="Amazon.ElastiCache.IAmazonElastiCache.DescribeReservedCacheNodes"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeReservedCacheNodes operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<DescribeReservedCacheNodesResponse> DescribeReservedCacheNodesAsync(DescribeReservedCacheNodesRequest request, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// The <i>DescribeReservedCacheNodesOfferings</i> operation lists available reserved
        /// cache node offerings.
        /// </summary>
        /// 
        /// <returns>The response from the DescribeReservedCacheNodesOfferings service method, as returned by ElastiCache.</returns>
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidParameterCombinationException">
        /// Two or more incompatible parameters were specified.
        /// </exception>
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidParameterValueException">
        /// The value for a parameter is invalid.
        /// </exception>
        /// <exception cref="T:Amazon.ElastiCache.Model.ReservedCacheNodesOfferingNotFoundException">
        /// The requested cache node offering does not exist.
        /// </exception>
		DescribeReservedCacheNodesOfferingsResponse DescribeReservedCacheNodesOfferings();
 

        /// <summary>
        /// The <i>DescribeReservedCacheNodesOfferings</i> operation lists available reserved
        /// cache node offerings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeReservedCacheNodesOfferings service method.</param>
        /// 
        /// <returns>The response from the DescribeReservedCacheNodesOfferings service method, as returned by ElastiCache.</returns>
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidParameterCombinationException">
        /// Two or more incompatible parameters were specified.
        /// </exception>
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidParameterValueException">
        /// The value for a parameter is invalid.
        /// </exception>
        /// <exception cref="T:Amazon.ElastiCache.Model.ReservedCacheNodesOfferingNotFoundException">
        /// The requested cache node offering does not exist.
        /// </exception>
		DescribeReservedCacheNodesOfferingsResponse DescribeReservedCacheNodesOfferings(DescribeReservedCacheNodesOfferingsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeReservedCacheNodesOfferings operation.
        /// <seealso cref="Amazon.ElastiCache.IAmazonElastiCache.DescribeReservedCacheNodesOfferings"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeReservedCacheNodesOfferings operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<DescribeReservedCacheNodesOfferingsResponse> DescribeReservedCacheNodesOfferingsAsync(DescribeReservedCacheNodesOfferingsRequest request, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// The <i>DescribeSnapshots</i> operation returns information about cache cluster snapshots.
        /// By default, <i>DescribeSnapshots</i> lists all of your snapshots; it can optionally
        /// describe a single snapshot, or just the snapshots associated with a particular cache
        /// cluster.
        /// </summary>
        /// 
        /// <returns>The response from the DescribeSnapshots service method, as returned by ElastiCache.</returns>
        /// <exception cref="T:Amazon.ElastiCache.Model.CacheClusterNotFoundException">
        /// The requested cache cluster ID does not refer to an existing cache cluster.
        /// </exception>
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidParameterCombinationException">
        /// Two or more incompatible parameters were specified.
        /// </exception>
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidParameterValueException">
        /// The value for a parameter is invalid.
        /// </exception>
        /// <exception cref="T:Amazon.ElastiCache.Model.SnapshotNotFoundException">
        /// The requested snapshot name does not refer to an existing snapshot.
        /// </exception>
		DescribeSnapshotsResponse DescribeSnapshots();
 

        /// <summary>
        /// The <i>DescribeSnapshots</i> operation returns information about cache cluster snapshots.
        /// By default, <i>DescribeSnapshots</i> lists all of your snapshots; it can optionally
        /// describe a single snapshot, or just the snapshots associated with a particular cache
        /// cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeSnapshots service method.</param>
        /// 
        /// <returns>The response from the DescribeSnapshots service method, as returned by ElastiCache.</returns>
        /// <exception cref="T:Amazon.ElastiCache.Model.CacheClusterNotFoundException">
        /// The requested cache cluster ID does not refer to an existing cache cluster.
        /// </exception>
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidParameterCombinationException">
        /// Two or more incompatible parameters were specified.
        /// </exception>
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidParameterValueException">
        /// The value for a parameter is invalid.
        /// </exception>
        /// <exception cref="T:Amazon.ElastiCache.Model.SnapshotNotFoundException">
        /// The requested snapshot name does not refer to an existing snapshot.
        /// </exception>
		DescribeSnapshotsResponse DescribeSnapshots(DescribeSnapshotsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeSnapshots operation.
        /// <seealso cref="Amazon.ElastiCache.IAmazonElastiCache.DescribeSnapshots"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeSnapshots operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<DescribeSnapshotsResponse> DescribeSnapshotsAsync(DescribeSnapshotsRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// The <i>ModifyCacheCluster</i> operation modifies the settings for a cache cluster.
        /// You can use this operation to change one or more cluster configuration parameters
        /// by specifying the parameters and the new values.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyCacheCluster service method.</param>
        /// 
        /// <returns>The response from the ModifyCacheCluster service method, as returned by ElastiCache.</returns>
        /// <exception cref="T:Amazon.ElastiCache.Model.CacheClusterNotFoundException">
        /// The requested cache cluster ID does not refer to an existing cache cluster.
        /// </exception>
        /// <exception cref="T:Amazon.ElastiCache.Model.CacheParameterGroupNotFoundException">
        /// The requested cache parameter group name does not refer to an existing cache parameter
        /// group.
        /// </exception>
        /// <exception cref="T:Amazon.ElastiCache.Model.CacheSecurityGroupNotFoundException">
        /// The requested cache security group name does not refer to an existing cache security
        /// group.
        /// </exception>
        /// <exception cref="T:Amazon.ElastiCache.Model.InsufficientCacheClusterCapacityException">
        /// The requested cache node type is not available in the specified Availability Zone.
        /// </exception>
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidCacheClusterStateException">
        /// The requested cache cluster is not in the <i>available</i> state.
        /// </exception>
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidCacheSecurityGroupStateException">
        /// The current state of the cache security group does not allow deletion.
        /// </exception>
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidParameterCombinationException">
        /// Two or more incompatible parameters were specified.
        /// </exception>
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidParameterValueException">
        /// The value for a parameter is invalid.
        /// </exception>
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidVPCNetworkStateException">
        /// The VPC network is in an invalid state.
        /// </exception>
        /// <exception cref="T:Amazon.ElastiCache.Model.NodeQuotaForClusterExceededException">
        /// The request cannot be processed because it would exceed the allowed number of cache
        /// nodes in a single cache cluster.
        /// </exception>
        /// <exception cref="T:Amazon.ElastiCache.Model.NodeQuotaForCustomerExceededException">
        /// The request cannot be processed because it would exceed the allowed number of cache
        /// nodes per customer.
        /// </exception>
		ModifyCacheClusterResponse ModifyCacheCluster(ModifyCacheClusterRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ModifyCacheCluster operation.
        /// <seealso cref="Amazon.ElastiCache.IAmazonElastiCache.ModifyCacheCluster"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyCacheCluster operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<ModifyCacheClusterResponse> ModifyCacheClusterAsync(ModifyCacheClusterRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// The <i>ModifyCacheParameterGroup</i> operation modifies the parameters of a cache
        /// parameter group. You can modify up to 20 parameters in a single request by submitting
        /// a list parameter name and value pairs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyCacheParameterGroup service method.</param>
        /// 
        /// <returns>The response from the ModifyCacheParameterGroup service method, as returned by ElastiCache.</returns>
        /// <exception cref="T:Amazon.ElastiCache.Model.CacheParameterGroupNotFoundException">
        /// The requested cache parameter group name does not refer to an existing cache parameter
        /// group.
        /// </exception>
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidCacheParameterGroupStateException">
        /// The current state of the cache parameter group does not allow the requested action
        /// to occur.
        /// </exception>
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidParameterCombinationException">
        /// Two or more incompatible parameters were specified.
        /// </exception>
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidParameterValueException">
        /// The value for a parameter is invalid.
        /// </exception>
		ModifyCacheParameterGroupResponse ModifyCacheParameterGroup(ModifyCacheParameterGroupRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ModifyCacheParameterGroup operation.
        /// <seealso cref="Amazon.ElastiCache.IAmazonElastiCache.ModifyCacheParameterGroup"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyCacheParameterGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<ModifyCacheParameterGroupResponse> ModifyCacheParameterGroupAsync(ModifyCacheParameterGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// The <i>ModifyCacheSubnetGroup</i> operation modifies an existing cache subnet group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyCacheSubnetGroup service method.</param>
        /// 
        /// <returns>The response from the ModifyCacheSubnetGroup service method, as returned by ElastiCache.</returns>
        /// <exception cref="T:Amazon.ElastiCache.Model.CacheSubnetGroupNotFoundException">
        /// The requested cache subnet group name does not refer to an existing cache subnet group.
        /// </exception>
        /// <exception cref="T:Amazon.ElastiCache.Model.CacheSubnetQuotaExceededException">
        /// The request cannot be processed because it would exceed the allowed number of subnets
        /// in a cache subnet group.
        /// </exception>
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidSubnetException">
        /// An invalid subnet identifier was specified.
        /// </exception>
        /// <exception cref="T:Amazon.ElastiCache.Model.SubnetInUseException">
        /// The requested subnet is being used by another cache subnet group.
        /// </exception>
		ModifyCacheSubnetGroupResponse ModifyCacheSubnetGroup(ModifyCacheSubnetGroupRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ModifyCacheSubnetGroup operation.
        /// <seealso cref="Amazon.ElastiCache.IAmazonElastiCache.ModifyCacheSubnetGroup"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyCacheSubnetGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<ModifyCacheSubnetGroupResponse> ModifyCacheSubnetGroupAsync(ModifyCacheSubnetGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// The <i>ModifyReplicationGroup</i> operation modifies the settings for a replication
        /// group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyReplicationGroup service method.</param>
        /// 
        /// <returns>The response from the ModifyReplicationGroup service method, as returned by ElastiCache.</returns>
        /// <exception cref="T:Amazon.ElastiCache.Model.CacheClusterNotFoundException">
        /// The requested cache cluster ID does not refer to an existing cache cluster.
        /// </exception>
        /// <exception cref="T:Amazon.ElastiCache.Model.CacheParameterGroupNotFoundException">
        /// The requested cache parameter group name does not refer to an existing cache parameter
        /// group.
        /// </exception>
        /// <exception cref="T:Amazon.ElastiCache.Model.CacheSecurityGroupNotFoundException">
        /// The requested cache security group name does not refer to an existing cache security
        /// group.
        /// </exception>
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidCacheClusterStateException">
        /// The requested cache cluster is not in the <i>available</i> state.
        /// </exception>
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidCacheSecurityGroupStateException">
        /// The current state of the cache security group does not allow deletion.
        /// </exception>
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidParameterCombinationException">
        /// Two or more incompatible parameters were specified.
        /// </exception>
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidParameterValueException">
        /// The value for a parameter is invalid.
        /// </exception>
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidReplicationGroupStateException">
        /// The requested replication group is not in the <i>available</i> state.
        /// </exception>
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidVPCNetworkStateException">
        /// The VPC network is in an invalid state.
        /// </exception>
        /// <exception cref="T:Amazon.ElastiCache.Model.ReplicationGroupNotFoundException">
        /// The specified replication group does not exist.
        /// </exception>
		ModifyReplicationGroupResponse ModifyReplicationGroup(ModifyReplicationGroupRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ModifyReplicationGroup operation.
        /// <seealso cref="Amazon.ElastiCache.IAmazonElastiCache.ModifyReplicationGroup"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyReplicationGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<ModifyReplicationGroupResponse> ModifyReplicationGroupAsync(ModifyReplicationGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// The <i>PurchaseReservedCacheNodesOffering</i> operation allows you to purchase a reserved
        /// cache node offering.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PurchaseReservedCacheNodesOffering service method.</param>
        /// 
        /// <returns>The response from the PurchaseReservedCacheNodesOffering service method, as returned by ElastiCache.</returns>
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidParameterCombinationException">
        /// Two or more incompatible parameters were specified.
        /// </exception>
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidParameterValueException">
        /// The value for a parameter is invalid.
        /// </exception>
        /// <exception cref="T:Amazon.ElastiCache.Model.ReservedCacheNodeAlreadyExistsException">
        /// You already have a reservation with the given identifier.
        /// </exception>
        /// <exception cref="T:Amazon.ElastiCache.Model.ReservedCacheNodeQuotaExceededException">
        /// The request cannot be processed because it would exceed the user's cache node quota.
        /// </exception>
        /// <exception cref="T:Amazon.ElastiCache.Model.ReservedCacheNodesOfferingNotFoundException">
        /// The requested cache node offering does not exist.
        /// </exception>
		PurchaseReservedCacheNodesOfferingResponse PurchaseReservedCacheNodesOffering(PurchaseReservedCacheNodesOfferingRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the PurchaseReservedCacheNodesOffering operation.
        /// <seealso cref="Amazon.ElastiCache.IAmazonElastiCache.PurchaseReservedCacheNodesOffering"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PurchaseReservedCacheNodesOffering operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<PurchaseReservedCacheNodesOfferingResponse> PurchaseReservedCacheNodesOfferingAsync(PurchaseReservedCacheNodesOfferingRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// The <i>RebootCacheCluster</i> operation reboots some, or all, of the cache nodes within
        /// a provisioned cache cluster. This API will apply any modified cache parameter groups
        /// to the cache cluster. The reboot action takes place as soon as possible, and results
        /// in a momentary outage to the cache cluster. During the reboot, the cache cluster status
        /// is set to REBOOTING.
        /// 
        /// 
        /// <para>
        /// The reboot causes the contents of the cache (for each cache node being rebooted) to
        /// be lost.
        /// </para>
        /// 
        /// <para>
        /// When the reboot is complete, a cache cluster event is created.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RebootCacheCluster service method.</param>
        /// 
        /// <returns>The response from the RebootCacheCluster service method, as returned by ElastiCache.</returns>
        /// <exception cref="T:Amazon.ElastiCache.Model.CacheClusterNotFoundException">
        /// The requested cache cluster ID does not refer to an existing cache cluster.
        /// </exception>
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidCacheClusterStateException">
        /// The requested cache cluster is not in the <i>available</i> state.
        /// </exception>
		RebootCacheClusterResponse RebootCacheCluster(RebootCacheClusterRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the RebootCacheCluster operation.
        /// <seealso cref="Amazon.ElastiCache.IAmazonElastiCache.RebootCacheCluster"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RebootCacheCluster operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<RebootCacheClusterResponse> RebootCacheClusterAsync(RebootCacheClusterRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// The <i>ResetCacheParameterGroup</i> operation modifies the parameters of a cache parameter
        /// group to the engine or system default value. You can reset specific parameters by
        /// submitting a list of parameter names. To reset the entire cache parameter group, specify
        /// the <i>ResetAllParameters</i> and <i>CacheParameterGroupName</i> parameters.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ResetCacheParameterGroup service method.</param>
        /// 
        /// <returns>The response from the ResetCacheParameterGroup service method, as returned by ElastiCache.</returns>
        /// <exception cref="T:Amazon.ElastiCache.Model.CacheParameterGroupNotFoundException">
        /// The requested cache parameter group name does not refer to an existing cache parameter
        /// group.
        /// </exception>
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidCacheParameterGroupStateException">
        /// The current state of the cache parameter group does not allow the requested action
        /// to occur.
        /// </exception>
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidParameterCombinationException">
        /// Two or more incompatible parameters were specified.
        /// </exception>
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidParameterValueException">
        /// The value for a parameter is invalid.
        /// </exception>
		ResetCacheParameterGroupResponse ResetCacheParameterGroup(ResetCacheParameterGroupRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ResetCacheParameterGroup operation.
        /// <seealso cref="Amazon.ElastiCache.IAmazonElastiCache.ResetCacheParameterGroup"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ResetCacheParameterGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<ResetCacheParameterGroupResponse> ResetCacheParameterGroupAsync(ResetCacheParameterGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// The <i>RevokeCacheSecurityGroupIngress</i> operation revokes ingress from a cache
        /// security group. Use this operation to disallow access from an Amazon EC2 security
        /// group that had been previously authorized.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RevokeCacheSecurityGroupIngress service method.</param>
        /// 
        /// <returns>The response from the RevokeCacheSecurityGroupIngress service method, as returned by ElastiCache.</returns>
        /// <exception cref="T:Amazon.ElastiCache.Model.AuthorizationNotFoundException">
        /// The specified Amazon EC2 security group is not authorized for the specified cache
        /// security group.
        /// </exception>
        /// <exception cref="T:Amazon.ElastiCache.Model.CacheSecurityGroupNotFoundException">
        /// The requested cache security group name does not refer to an existing cache security
        /// group.
        /// </exception>
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidCacheSecurityGroupStateException">
        /// The current state of the cache security group does not allow deletion.
        /// </exception>
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidParameterCombinationException">
        /// Two or more incompatible parameters were specified.
        /// </exception>
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidParameterValueException">
        /// The value for a parameter is invalid.
        /// </exception>
		RevokeCacheSecurityGroupIngressResponse RevokeCacheSecurityGroupIngress(RevokeCacheSecurityGroupIngressRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the RevokeCacheSecurityGroupIngress operation.
        /// <seealso cref="Amazon.ElastiCache.IAmazonElastiCache.RevokeCacheSecurityGroupIngress"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RevokeCacheSecurityGroupIngress operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<RevokeCacheSecurityGroupIngressResponse> RevokeCacheSecurityGroupIngressAsync(RevokeCacheSecurityGroupIngressRequest request, CancellationToken cancellationToken = default(CancellationToken));
    }
}
