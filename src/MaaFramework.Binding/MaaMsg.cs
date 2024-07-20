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

﻿namespace MaaFramework.Binding.Messages;

/// <summary>
///  A callback consists of a message and a payload.
///  The message is a string that indicates the type of the message.
///  The payload is a JSON object that contains the details of the message.
/// </summary>
public static class MaaMsg
{
    public static class Resource
    {
        /// <summary>
        ///     The message for the resource loading.
        /// </summary>
        /// <remarks>
        ///     payload: { id: number, path: string }
        /// </remarks>
        public const string StartLoading = "Resource.StartLoading";

        /// <summary>
        ///     The message for the resource loading.
        /// </summary>
        /// <remarks>
        ///     payload: { id: number, path: string }
        /// </remarks>
        public const string LoadingCompleted = "Resource.LoadingCompleted";

        /// <summary>
        ///     The message for the resource loading.
        /// </summary>
        /// <remarks>
        ///     payload: { id: number, path: string }
        /// </remarks>
        public const string LoadingFailed = "Resource.LoadingFailed";

    }
    public static class Controller
    {
        public static class Action
        {
            /// <summary>
            ///     Message for the controller actions.
            /// </summary>
            /// <remarks>
            ///     payload: { id: number }
            /// </remarks>
            public const string Started = "Controller.Action.Started";

            /// <summary>
            ///     Message for the controller actions.
            /// </summary>
            /// <remarks>
            ///     payload: { id: number }
            /// </remarks>
            public const string Completed = "Controller.Action.Completed";

            /// <summary>
            ///     Message for the controller actions.
            /// </summary>
            /// <remarks>
            ///     payload: { id: number }
            /// </remarks>
            public const string Failed = "Controller.Action.Failed";

        }
        /// <summary>
        ///     The message for the UUID got.
        /// </summary>
        /// <remarks>
        ///     payload: { uuid: string }
        /// </remarks>
        public const string UUIDGot = "Controller.UUIDGot";

        public const string UUIDGetFailed = "Controller.UUIDGetFailed";

        /// <remarks>
        ///     payload: { }
        /// </remarks>
        public const string ScreencapInited = "Controller.ScreencapInited";

        public const string ScreencapInitFailed = "Controller.ScreencapInitFailed";

        public const string TouchInputInited = "Controller.TouchinputInited";

        public const string TouchInputInitFailed = "Controller.TouchinputInitFailed";

        public const string KeyInputInited = "Controller.KeyinputInited";

        public const string KeyInputInitFailed = "Controller.KeyinputInitFailed";

        /// <summary>
        ///     Message for the controller connected.
        /// </summary>
        /// <remarks>
        ///     payload: { uuid: string }
        /// </remarks>
        public const string ConnectSuccess = "Controller.ConnectSuccess";

        /// <summary>
        ///     Message for the controller connect failed.
        /// </summary>
        /// <remarks>
        ///     payload: { why: string }
        /// </remarks>
        public const string ConnectFailed = "Controller.ConnectFailed";

    }
    public static class Task
    {
        /// <summary>
        ///     Message for the tasks.
        /// </summary>
        /// <remarks>
        ///     payload: { id: number, entry: string, name: string, uuid: string, hash: string }
        /// </remarks>
        public const string Started = "Task.Started";

        /// <summary>
        ///     Message for the tasks.
        /// </summary>
        /// <remarks>
        ///     payload: { id: number, entry: string, name: string, uuid: string, hash: string }
        /// </remarks>
        public const string Completed = "Task.Completed";

        /// <summary>
        ///     Message for the tasks.
        /// </summary>
        /// <remarks>
        ///     payload: { id: number, entry: string, name: string, uuid: string, hash: string }
        /// </remarks>
        public const string Failed = "Task.Failed";

        public static class Focus
        {
            /// <summary>
            ///     Message for the task focus.
            /// </summary>
            /// <remarks>
            ///     payload: { task_id: number, entry: string, uuid: string, hash: string, pre_hit_task: string, name: string, recognition: { id: number, box: [number, number, number, number], detail: string, hit: boolean, }, node_id: number, status: number, }
            /// </remarks>
            public const string ReadyToRun = "Task.Focus.ReadyToRun";

            /// <summary>
            ///     Message for the task focus.
            /// </summary>
            /// <remarks>
            ///     payload: { task_id: number, entry: string, uuid: string, hash: string, pre_hit_task: string, name: string, recognition: { id: number, box: [number, number, number, number], detail: string, hit: boolean, }, node_id: number, status: number, }
            /// </remarks>
            public const string Runout = "Task.Focus.Runout";

            /// <summary>
            ///     Message for the task focus.
            /// </summary>
            /// <remarks>
            ///     payload: { task_id: number, entry: string, uuid: string, hash: string, pre_hit_task: string, name: string, recognition: { id: number, box: [number, number, number, number], detail: string, hit: boolean, }, node_id: number, status: number, }
            /// </remarks>
            public const string Completed = "Task.Focus.Completed";

        }
        public static class Debug
        {
            /// <summary>
            ///     Message for debug.
            /// </summary>
            /// <remarks>
            ///     payload: { task_id: number, entry: string, uuid: string, hash: string, pre_hit_task: string, name: string, recognition: { id: number, box: [number, number, number, number], detail: string, hit: boolean, }, node_id: number, status: number, }
            /// </remarks>
            public const string ReadyToRun = "Task.Debug.ReadyToRun";

            /// <summary>
            ///     Message for debug.
            /// </summary>
            /// <remarks>
            ///     payload: { task_id: number, entry: string, uuid: string, hash: string, pre_hit_task: string, name: string, recognition: { id: number, box: [number, number, number, number], detail: string, hit: boolean, }, node_id: number, status: number, }
            /// </remarks>
            public const string Runout = "Task.Debug.Runout";

            /// <summary>
            ///     Message for debug.
            /// </summary>
            /// <remarks>
            ///     payload: { task_id: number, entry: string, uuid: string, hash: string, pre_hit_task: string, name: string, recognition: { id: number, box: [number, number, number, number], detail: string, hit: boolean, }, node_id: number, status: number, }
            /// </remarks>
            public const string Completed = "Task.Debug.Completed";

            public const string ListToRecognize = "Task.Debug.ListToRecognize";

            public const string RecognitionResult = "Task.Debug.RecognitionResult";

            public const string Hit = "Task.Debug.Hit";

            public const string MissAll = "Task.Debug.MissAll";

        }
    }
    public const string Invalid = "Invalid";

}