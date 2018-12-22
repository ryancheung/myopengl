set(LIB_SRCS
    src/glad.c
)

include_directories(SYSTEM
    include
)

add_library(glad
    ${LIB_SRCS}
)

target_link_libraries(
    glad
    ${OPENGL_LIBRARIES}
)
