﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ValheimPlusManager.SupportClasses
{
    public static class FileManager
    {
        public static bool InstallValheimPlus(string fromPath, string toPath)
        {
            // Create subdirectory structure in destination    
            foreach (string dir in System.IO.Directory.GetDirectories(fromPath, "*", System.IO.SearchOption.AllDirectories))
            {
                System.IO.Directory.CreateDirectory(System.IO.Path.Combine(toPath, dir.Substring(fromPath.Length + 1)));
            }

            // Copying files from ValheimPlus package to server directory
            foreach (string file_name in System.IO.Directory.GetFiles(fromPath, "*", System.IO.SearchOption.AllDirectories))
            {
                System.IO.File.Copy(file_name, System.IO.Path.Combine(toPath, file_name.Substring(fromPath.Length + 1)), true);
            }

            return true;
        }
    }
}