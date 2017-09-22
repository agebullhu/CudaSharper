using System;
using System.Threading;

/*
 * CudaSharper - a wrapper for CUDA-accelerated functions. CudaSharper is not intended to write CUDA in C#, but rather a
 * library that allows one to easily use CUDA-accelerated functions without having to directly interact with the device.
 * This file acts as a wrapper for CudaSharperLibrary.dll, which is required for these functions to run. CudaSharperLibrary.dll
 * is the actual CUDA C code compiled as a C++/CLI assembly; however, it is unmanaged and therefore requires this wrapper to be used
 * in C# projects.
 * 
 * Current Classes:
 * - CudaSettings: Initialization class.
 * - Cuda: Array functions, such as SplitArray and AddArrays
 * - CuRand: cuRAND functions; allows the generation of pseudorandom number sets using uniform, normal, or poisson distributions.
 */

namespace CudaSharper
{
    public static class CudaSettings
    {
        private static bool WorkingDirSet { get; set; } = false;
        private static Mutex LoadingMutex { get; set; } = new Mutex(true);

        public static void Load(string working_directory)
        {
            LoadingMutex.WaitOne();

            if (WorkingDirSet)
                return;

            Environment.SetEnvironmentVariable("PATH", Environment.GetEnvironmentVariable("PATH") + AppDomain.CurrentDomain.BaseDirectory);
            WorkingDirSet = true;

            LoadingMutex.ReleaseMutex();
        }

        public static void Load()
        {
            Load(AppDomain.CurrentDomain.BaseDirectory);
        }
    }
}