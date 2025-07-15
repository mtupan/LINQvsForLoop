# LINQ vs For-loop Performance

Test comparing the performance between LINQ and a traditional `for` loop when filtering even numbers from a list of 1 million integers.

## Summary

This project executes the same filtering logic 100 times and measures the total and average execution time for each approach.

- **LINQ total:** 2100 ms  
- **LINQ average:** 21.00 ms  
- **For-loop total:** 739 ms  
- **For-loop average:** 7.39 ms

## Code Overview

- The LINQ approach uses `.Where(x => x % 2 == 0).ToList()`
- The for-loop counts and copies only even numbers into a pre-sized array

## Conclusion

LINQ is more readable but introduces overhead.  
In performance-critical scenarios — like cloud environments where execution time = cost — small differences can matter.