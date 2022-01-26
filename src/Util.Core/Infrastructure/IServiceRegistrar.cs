﻿using System;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Util.Reflections;

namespace Util.Infrastructure {
    /// <summary>
    /// 服务注册器
    /// </summary>
    public interface IServiceRegistrar {
        /// <summary>
        /// 标识
        /// </summary>
        int Id { get; }
        /// <summary>
        /// 是否启用
        /// </summary>
        bool Enabled { get; }
        /// <summary>
        /// 注册服务,该操作在启动开始时执行,如果需要延迟执行某些操作,可在返回的Action中执行,它将在启动最后执行
        /// </summary>
        /// <param name="services">服务集合</param>
        /// <param name="configuration">配置</param>
        /// <param name="finder">类型查找器</param>
        Action Register( IServiceCollection services, IConfiguration configuration, ITypeFinder finder );
    }
}