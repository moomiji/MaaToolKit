﻿using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;

namespace MaaFramework.Binding.Native.Interop;

#pragma warning disable S1133 // Deprecated code should be removed
#pragma warning disable S4200 // Native methods should be wrapped
#pragma warning disable CA1401 // P/Invoke method should not be visible
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
#pragma warning disable CA1707 // 标识符不应包含下划线

/// <summary>
///     A static class provides the delegates of <see cref="MaaCustomRecognizerApi" />.
/// </summary>
public static class MaaRecognizerApi
{

    #region include/MaaFramework/Task/MaaCustomRecognizer.h, version: v1.4.0.

    public delegate MaaBool Analyze(MaaSyncContextHandle sync_context, MaaImageBufferHandle image, MaaStringView task_name, MaaStringView custom_recognition_param, /*out*/ MaaRectHandle out_box, /*out*/ MaaStringBufferHandle out_detail);

    #endregion

}

/// <summary>
///     MaaCustomRecognizerApi
/// </summary>
[NativeMarshalling(typeof(MaaCustomRecognizerApiMarshaller))]
public class MaaCustomRecognizerApi : IMaaDef
{
    public required MaaRecognizerApi.Analyze Analyze { get; init; }
}

/// <summary>
///     A static class providing a reference implementation of marshaller for <see cref="MaaCustomRecognizerApi" />.
/// </summary>
[CustomMarshaller(typeof(MaaCustomRecognizerApi), MarshalMode.Default, typeof(MaaCustomRecognizerApiMarshaller))]
internal static class MaaCustomRecognizerApiMarshaller
{
    [StructLayout(LayoutKind.Sequential)]
    internal struct Unmanaged
    {
        public nint Analyze;
    }

    public static Unmanaged ConvertToUnmanaged(MaaCustomRecognizerApi managed)
        => new() { Analyze = Marshal.GetFunctionPointerForDelegate<MaaRecognizerApi.Analyze>(managed.Analyze) };

    public static MaaCustomRecognizerApi ConvertToManaged(Unmanaged unmanaged)
        => new() { Analyze = Marshal.GetDelegateForFunctionPointer<MaaRecognizerApi.Analyze>(unmanaged.Analyze) };

    public static void Free(Unmanaged unmanaged)
    {
        // Method intentionally left empty.
    }
}
