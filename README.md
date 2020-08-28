# Platform invoke playground

## C# calls Zig function

1. Build Zig library:
```
cd ./src/zig
zig build
```

2. Run C# app:
```
cd ./src/dotnet
dotnet run --project app-zig
```

## C# calls C function

1. Build C library:
```
cd ./src/c
mkdir cmake-build-debug
cd cmake-build-debug
cmake -DCMAKE_BUILD_TYPE=Debug ..
make
```

2. Run C# app:
```
cd ./src/dotnet
dotnet run --project app-c
```
