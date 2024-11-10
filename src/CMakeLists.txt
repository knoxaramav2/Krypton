message(">> PLAYGROUND @ ${CMAKE_CURRENT_SOURCE_DIR}")

target_link_libraries( playground
PUBLIC
)

target_include_directories( playground
PRIVATE

PUBLIC
)

target_sources(
    playground
PRIVATE
    playground.cpp
)
