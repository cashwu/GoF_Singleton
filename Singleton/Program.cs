using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class Program
    {
        private static void Main(string[] args)
        {
        }
    }

    public class FileSystem
    {
        private static FileSystem mFileSystem = new FileSystem();

        private FileSystem()
        {
        }

        public static FileSystem getInstance()
        {
            return mFileSystem;
        }
    }

    public class FileSystem2
    {
        public static FileSystem2 current()
        {
            return new FileSystem2();
        }
    }
}