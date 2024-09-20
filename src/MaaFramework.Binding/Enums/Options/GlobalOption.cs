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

public enum GlobalOption : System.Int32
{
    Invalid = 0,
    /// <summary>
    ///     Log dir
    /// </summary>
    /// <remarks>
    ///     <para>value: string, eg: "C:\\Users\\Administrator\\Desktop\\log"; val_size: string length</para>
    /// </remarks>
    LogDir = 1,
    /// <summary>
    ///     Whether to save draw
    /// </summary>
    /// <remarks>
    ///     <para>value: bool, eg: true; val_size: sizeof(bool)</para>
    /// </remarks>
    SaveDraw = 2,
    /// <summary>
    ///     Dump all screenshots and actions
    /// </summary>
    /// <remarks>
    ///     <para>Recording will evaluate to true if any of this or MaaCtrlOptionEnum::MaaCtrlOption_Recording</para>
    ///     <para>is true. value: bool, eg: true; val_size: sizeof(bool)</para>
    /// </remarks>
    Recording = 3,
    /// <summary>
    ///     The level of log output to stdout
    /// </summary>
    /// <remarks>
    ///     <para>value: MaaLoggingLevel, val_size: sizeof(MaaLoggingLevel)</para>
    ///     <para>default value is MaaLoggingLevel_Error</para>
    /// </remarks>
    StdoutLevel = 4,
    /// <summary>
    ///     Whether to show hit draw
    /// </summary>
    /// <remarks>
    ///     <para>value: bool, eg: true; val_size: sizeof(bool)</para>
    /// </remarks>
    ShowHitDraw = 5,
    /// <summary>
    ///     Whether to debug
    /// </summary>
    /// <remarks>
    ///     <para>value: bool, eg: true; val_size: sizeof(bool)</para>
    /// </remarks>
    DebugMode = 6,
}

