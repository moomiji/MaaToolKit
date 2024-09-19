﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

#pragma warning disable CS1573 // 参数在 XML 注释中没有匹配的 param 标记
#pragma warning disable CS1591 // 缺少对公共可见类型或成员的 XML 注释

namespace MaaFramework.Binding;

/// <summary>
///     Option keys for controller instance options. See MaaControllerSetOption().
/// </summary>
public enum ControllerOption : System.Int32
{
    Invalid = 0,
    /// <summary>
    ///     Only one of long and short side can be set, and the other is automatically scaled according to the aspect ratio.
    /// </summary>
    /// <remarks>
    ///     <para>value: int, eg: 1920; val_size: sizeof(int)</para>
    /// </remarks>
    ScreenshotTargetLongSide = 1,
    /// <summary>
    ///     Only one of long and short side can be set, and the other is automatically scaled according to the aspect ratio.
    /// </summary>
    /// <remarks>
    ///     <para>value: int, eg: 1080; val_size: sizeof(int)</para>
    /// </remarks>
    ScreenshotTargetShortSide = 2,
    /// <summary>
    ///     Dump all screenshots and actions
    /// </summary>
    /// <remarks>
    ///     <para>Recording will evaluate to true if any of this or</para>
    ///     <para>MaaGlobalOptionEnum::MaaGlobalOption_Recording is true.</para>
    ///     <para>value: bool, eg: true; val_size: sizeof(bool)</para>
    /// </remarks>
    Recording = 5,
}

