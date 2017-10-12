namespace Tmds.DotnetTrace.Tool
{
    static class DotNetEvents
    {
        public const string RuntimeInformationStart = "DotNETRuntime:RuntimeInformationStart";
        public const string GCAllocationTick_V3 = "DotNETRuntime:GCAllocationTick_V3";
        public const string GCAllocationTick_V2 = "DotNETRuntime:GCAllocationTick_V2";
        public const string GCStart_V2 = "DotNETRuntime:GCStart_V2";
        public const string GCHeapStats_V1 = "DotNETRuntime:GCHeapStats_V1";
        public const string ExceptionThrown_V1 = "DotNETRuntime:ExceptionThrown_V1";
        public const string GCSuspendEEBegin_V1 = "DotNETRuntime:GCSuspendEEBegin_V1";
        public const string GCRestartEEEnd_V1 = "DotNETRuntime:GCRestartEEEnd_V1";
    }
}