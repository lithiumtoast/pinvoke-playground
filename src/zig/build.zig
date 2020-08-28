const Builder = @import("std").build.Builder;

pub fn build(builder: *Builder) void {
    const target = builder.standardTargetOptions(.{});
    const mode = builder.standardReleaseOptions();
    const lib = builder.addSharedLibrary("library", "./library.zig", builder.version(1, 0, 0));
    lib.setOutputDir("./bin");
    lib.setTarget(target);
    lib.setBuildMode(mode);
    lib.install();
}
