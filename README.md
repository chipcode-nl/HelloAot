2023-10-02

Test C# AOT gives segmentation fault on Mac OSX x64.


2023-10-93

The following fix was suggested:
https://github.com/dotnet/runtime/issues/92894 

The description matches the issues with Xcode 15 linker. We fixed it but there is no official release yet.

The new linker creates garbage unwinding information, which causes null pointer dereference in UnixNativeCodeManager.

You may be able to workaround it with:
```xml
<ItemGroup>
  <LinkerArg Include="-Wl,-ld_classic" />
</ItemGroup>
```

Console.WriteLine($"start time {stopwatch.ElapsedMilliseconds} ms");
Unfortunately the start time is extremely long.