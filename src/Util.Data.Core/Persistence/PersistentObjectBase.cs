﻿using System;
using System.ComponentModel.DataAnnotations;
using Util.Domain;

namespace Util.Data.Persistence {
    /// <summary>
    /// 持久化对象
    /// </summary>
    public abstract class PersistentObjectBase : PersistentObjectBase<Guid> {
    }

    /// <summary>
    /// 持久化对象
    /// </summary>
    /// <typeparam name="TKey">标识类型</typeparam>
    public abstract class PersistentObjectBase<TKey> : IKey<TKey> {
        /// <summary>
        /// 标识
        /// </summary>
        [Key]
        public TKey Id { get; set; }

        /// <summary>
        /// 相等运算
        /// </summary>
        public override bool Equals( object other ) {
            return this == ( other as PersistentObjectBase<TKey> );
        }

        /// <summary>
        /// 获取哈希
        /// </summary>
        public override int GetHashCode() {
            return ReferenceEquals( Id, null ) ? 0 : Id.GetHashCode();
        }

        /// <summary>
        /// 相等比较
        /// </summary>
        public static bool operator ==( PersistentObjectBase<TKey> left, PersistentObjectBase<TKey> right ) {
            if( (object)left == null && (object)right == null )
                return true;
            if( !( left is PersistentObjectBase ) || !( right is PersistentObjectBase ) )
                return false;
            if( Equals( left.Id, null ) )
                return false;
            if( left.Id.Equals( default( TKey ) ) )
                return false;
            return left.Id.Equals( right.Id );
        }

        /// <summary>
        /// 不相等比较
        /// </summary>
        public static bool operator !=( PersistentObjectBase<TKey> left, PersistentObjectBase<TKey> right ) {
            return !( left == right );
        }
    }
}