# Match brackets

According to the specifications, this is the output of the matching brackets program.
![image](https://github.com/reneflorendo/matchbrackets/assets/4901363/395bb6cc-fc2a-41d7-9765-d2bee860eb5a)


Performance graph using BenchmarkDotNet
![image](https://github.com/reneflorendo/matchbrackets/assets/4901363/857948de-6f8c-478c-9129-b58a0fd9358e)

The output of a benchmark test using BenchmarkDotNet, a popular .NET library for benchmarking code performance. In this output, various aspects of a method's performance are measured and reported in a tabular format.

Mean: This column represents the average time (in nanoseconds) taken by the method to execute. It is a measure of the central tendency of the execution times for the method. In your example, the mean execution time is reported as "29.20 ns," which means that, on average, the "HasMatchingBrackets" method took approximately 29.20 nanoseconds to run.

Error: This column represents the margin of error associated with the mean value. It indicates the range within which the actual execution times are likely to fall. In your example, the error is reported as "0.622 ns," meaning that the actual execution times are expected to be within approximately 0.622 nanoseconds of the mean value.

StdDev: This column represents the standard deviation of the execution times. Standard deviation measures the spread or dispersion of the execution times. A lower standard deviation indicates that the execution times are more consistent and less variable. In your example, the standard deviation is reported as "0.582 ns," suggesting that the execution times are relatively consistent, with little variation.
