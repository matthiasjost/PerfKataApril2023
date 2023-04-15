# PerfKataApril2023

## Description

The goal is to solve the [Largest Product in a Grid problem from Project Euler](https://projecteuler.net/problem=11) with the best performance possible.

This repository is a template for the kata. It contains a class library project where you can implement
your solution, a unit test project already set up with a test for the problem, and a benchmark project
where you can test the performance of your solution.

We will use the [BenchmarkDotNet](https://benchmarkdotnet.org/) library to measure the performance of
our solutions and we will be doing so on .NET 7.

The deadline for the kata is Friday, April 14th, 2023 at 23:59 UTC. At that point we'll run all solutions through a benchmarking suite and the fastest one will win.

One important thing to keep in mind is that for the official benchmarking we will be running tests and benchmarks using a different grid than the one provided in the problem description and in this repo. The grid will have the same dimensions, and the sequence length will be the same, but the numbers will be different. The reason for this is that we want to make sure that the solutions are not hard-coded to the grid provided in the problem description.

Have fun!
