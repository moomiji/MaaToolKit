﻿using System.Runtime.InteropServices;

namespace MaaToolKit.Extensions.Interop.Rpc;

#pragma warning disable S4200 // Native methods should be wrapped
#pragma warning disable CA1401 // P/Invoke method should not be visible
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///     The base P/Invoke methods for MaaRpc, use this class to call all the native methods.
///     If you do not known what you are doing, do not use this class. In most situations, you
///     should use <see cref="Extensions"/> instead.
/// </summary>
public static partial class MaaRpc
{

    #region include/MaaRpc/MaaRpc.h, version: v1.1.0.

    [LibraryImport("MaaRpc")]
    public static partial void MaaRpcStart([MarshalAs(UnmanagedType.LPUTF8Str)] string address);

    [LibraryImport("MaaRpc")]
    public static partial void MaaRpcStop();

    [LibraryImport("MaaRpc")]
    public static partial void MaaRpcWait();

    #endregion

}
