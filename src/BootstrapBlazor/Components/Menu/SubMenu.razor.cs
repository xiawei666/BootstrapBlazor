﻿// **********************************
// 框架名称：BootstrapBlazor 
// 框架作者：Argo Zhang
// 开源地址：
// Gitee : https://gitee.com/LongbowEnterprise/BootstrapBlazor
// GitHub: https://github.com/ArgoZhang/BootstrapBlazor 
// 开源协议：Apache-2.0 (https://gitee.com/LongbowEnterprise/BootstrapBlazor/blob/dev/LICENSE)
// **********************************

using Microsoft.AspNetCore.Components;
using System;
using System.Threading.Tasks;

namespace BootstrapBlazor.Components
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SubMenu
    {
        /// <summary>
        /// 获得 组件样式
        /// </summary>
        private string? ClassString => CssBuilder.Default("has-leaf")
            .AddClass("active", Item?.IsActive ?? false)
            .AddClassFromAttributes(AdditionalAttributes)
            .Build();

        /// <summary>
        /// 获得/设置 组件数据源
        /// </summary>
        [Parameter]
        public MenuItem? Item { get; set; }

        /// <summary>
        /// 获得/设置 菜单项点击回调委托
        /// </summary>
        [Parameter]
        public Func<MenuItem, Task> OnClick { get; set; } = _ => Task.CompletedTask;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="className"></param>
        /// <param name="item"></param>
        /// <returns></returns>
        private string? GetClassString(string className, MenuItem item) => CssBuilder.Default(className)
            .AddClass("active", item.IsActive && !item.IsDisabled)
            .AddClass("disabled", item.IsDisabled)
            .Build();

    }
}
