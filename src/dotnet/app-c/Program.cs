using System;
using System.IO;

namespace app
{
    internal static class Program
    {
        private static void Main()
        {
            var libraryName = GetLibraryName();
            var libraryPath = GetLibraryPath(libraryName);
            var libraryPointer = Native.LoadLibrary(libraryPath);
            var libraryFunction = Native.GetLibraryFunction<D_getScreenBounds>(libraryPointer);
            var screenBounds = libraryFunction();
            Console.WriteLine(screenBounds);
        }

        private static string GetLibraryPath(string libraryName)
        {
            var libraryPath = Path.GetFullPath(Path.Combine(
                AppDomain.CurrentDomain.BaseDirectory!,
                "../../../../../c/cmake-build-debug",
                libraryName
            ));
            return libraryPath;
        }

        private static string GetLibraryName()
        {
            var libraryName = string.Empty;
            var platform = Native.GetPlatform();
            libraryName = platform switch
            {
                NativePlatform.Windows => "library.dll",
                NativePlatform.macOS => "liblibrary.dylib",
                NativePlatform.Linux => "liblibrary.so",
                _ => libraryName
            };
            return libraryName;
        }
    }
}
