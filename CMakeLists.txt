project(myopengl)

cmake_minimum_required(VERSION 2.8.12)

set(CMAKE_CXX_STANDARD 14)

set(OpenGL_GL_PREFERENCE "GLVND")
find_package(OpenGL REQUIRED)
find_package(glfw3 3.2 REQUIRED)

add_subdirectory(dep)

include_directories(
    ${CMAKE_SOURCE_DIR}
)

include_directories(SYSTEM
    ${CMAKE_SOURCE_DIR}/dep/glad/include
)

set(EXECUTABLE_NAME myopengl)

add_executable(
    ${EXECUTABLE_NAME}
    Main.cpp
)

target_link_libraries(
    ${EXECUTABLE_NAME}
    ${OPENGL_LIBRARIES}
    glad
    glfw
    ${CMAKE_DL_LIBS}
)