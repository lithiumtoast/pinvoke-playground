#pragma once

#include <stdint.h>

typedef struct ScreenBounds ScreenBounds;
struct ScreenBounds
{
    uint32_t x;
    uint32_t y;
    uint32_t width;
    uint32_t height;
};

ScreenBounds getScreenBounds()
{
    ScreenBounds bounds;

    bounds.x = 0;
    bounds.y = 0;
    bounds.width = 32;
    bounds.height = 32;

    return bounds;
}
