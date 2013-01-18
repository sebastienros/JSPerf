JSPerf
======

Simple and personal perf comparison between JS interpreters in .NET.

# Early results (smaller is better):

### Using a new engine for each iteration

    Jint: 1000 iterations in 2134 ms
    Jurassic: 1000 iterations in 6957 ms
    Press any key to continue . . .

### Reusing the same engine accross iterations

    Jint: 1000 iterations in 247 ms
    Jurassic: 1000 iterations in 2418 ms
    Press any key to continue . . .
