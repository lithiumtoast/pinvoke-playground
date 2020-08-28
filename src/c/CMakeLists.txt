cmake_minimum_required(VERSION 3.17)
project(library C)

set(CMAKE_C_STANDARD 11)

add_library(library SHARED library.c)