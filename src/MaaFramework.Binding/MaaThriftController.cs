﻿using static MaaFramework.Binding.Interop.Framework.MaaController;

namespace MaaFramework.Binding;

/// <summary>
///     A class providing a reference implementation for <see cref="MaaThriftControllerCreate"/>.
/// </summary>
public class MaaThriftController : MaaController
{
    /// <summary>
    ///     Creates a <see cref="MaaThriftController"/> instance.
    /// </summary>
    /// <param name="param"></param>
    /// <param name="maaCallbackTransparentArg"></param>
    /// <remarks>
    ///     Wrapper of <see cref="MaaThriftControllerCreate"/>.
    /// </remarks>
    public MaaThriftController(string param, MaaCallbackTransparentArg maaCallbackTransparentArg)
        : base()
    {
        _handle = MaaThriftControllerCreate(param, MaaApiCallback, maaCallbackTransparentArg);
    }
}
