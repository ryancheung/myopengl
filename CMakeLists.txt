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
    ${CMAKE_SOURCE_DIR}/dep/glm/include
    ${CMAKE_SOURCE_DIR}/dep/stb/include
)

set(EXECUTABLE_NAME myopengl)

add_executable(
    ${EXECUTABLE_NAME}
    Main.cpp
    ${CMAKE_SOURCE_DIR}/dep/stb/src/stb_image.cpp
)

target_link_libraries(
    ${EXECUTABLE_NAME}
    ${OPENGL_LIBRARIES}
    glad
    glfw
    ${CMAKE_DL_LIBS}
)

install(DIRECTORY ${CMAKE_SOURCE_DIR}/assets/ DESTINATION ${CMAKE_BINARY_DIR}/)
