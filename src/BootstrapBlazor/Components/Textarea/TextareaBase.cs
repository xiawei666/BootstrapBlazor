﻿// **********************************
// 框架名称：BootstrapBlazor 
// 框架作者：Argo Zhang
// 开源地址：
// Gitee : https://gitee.com/LongbowEnterprise/BootstrapBlazor
// GitHub: https://github.com/ArgoZhang/BootstrapBlazor 
// 开源协议：Apache-2.0 (https://gitee.com/LongbowEnterprise/BootstrapBlazor/blob/dev/LICENSE)
// **********************************

namespace BootstrapBlazor.Components
{
    /// <summary>
    /// Textarea 组件基类
    /// </summary>
    public abstract class TextareaBase : ValidateBase<string?>
    {
        /// <summary>
        /// 获得 class 样式集合
        /// </summary>
        protected string? ClassName => CssBuilder.Default("form-control")
            .AddClass(CssClass).AddClass(ValidCss)
            .Build();
    }
}
