using System;
using System.Globalization;
using System.Reflection;

namespace SingletonExamples.Generic
{
    public abstract class Singleton<T>
        where T : class
    {
        // ReSharper disable once StaticFieldInGenericType
        private static WeakReference _weakInstance
            = new WeakReference(null);

        // ReSharper disable once StaticFieldInGenericType
        private static readonly object SharedLock = new object();

        // Return shared instance
        protected static T InternalGetInstance()
        {
            // Get strong instance
            var strongInstance = (T)_weakInstance.Target;
            if (strongInstance == null)
            {
                lock (SharedLock)
                {
                    if (strongInstance == null)
                    {
                        // Set strong and weak instance
                        strongInstance = (T)Activator.CreateInstance(typeof(T),
                            BindingFlags.NonPublic | BindingFlags.Instance, 
                            null, null, CultureInfo.InvariantCulture);
                        _weakInstance = new WeakReference(strongInstance);
                    }
                } 
            }

            return strongInstance;
        }
    }
}
