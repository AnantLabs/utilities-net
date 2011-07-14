using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

/// <summary>
/// Methods to work with processes.
/// </summary>
public static class ProcessUtils
{
    /// <summary>
    /// Starts a process with specified filename and arguments, waits for it to exit and returns the process's exit code.
    /// </summary>
    public static int RunProcess(string fileName, params string[] arguments)
    {
        using (var process = Process.Start(fileName, arguments.Aggregate(" ", "\"", "\"")))
        {
            process.WaitForExit();
            return process.ExitCode;
        }
    }
}