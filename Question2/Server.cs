using System;
using System.Collections.Generic;
using System.Text;

namespace Question2
{
    public static class Server
    {
        private static ReaderWriterLockSlim readerWriter = new();
        private static int count = 0;

        public static int GetCount()
        {
            readerWriter.EnterReadLock();
            try
            {
                return count;
            }
            finally
            {
                readerWriter.ExitReadLock();
            }
        }

        public static void AddToCount(int value)
        {
            readerWriter.EnterWriteLock();
            try
            {
                count += value;
                //count = value;
            }
            finally 
            { 
                readerWriter.ExitWriteLock(); 
            }
        }
    }
}
