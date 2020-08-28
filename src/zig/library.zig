export fn getScreenBounds() ScreenBounds {
    return ScreenBounds {
        .x = 0,
        .y = 0,
        .width = 32,
        .height = 32,
    };
}

const ScreenBounds = extern struct {
    x: u32,
    y: u32,
    width: u32,
    height: u32,
};