using System;
using System.Reflection;

namespace Common
{
    [Serializable]
    public abstract class SerializableCommand<TTarget> : ICommand
    {
        public TTarget Target { get; set; }
        public string Method { get; set; }
        public object[] Parameters { get; set; }

        public SerializableCommand(TTarget target, string method, object[] parameters)
        {
            Target = target;
            Method = method;
            Parameters = parameters;
        }

        public void Execute()
        {
            var mi = GetMethodInfo();
            mi.Invoke(Target, Parameters);
        }

        private MethodInfo GetMethodInfo()
        {
            var mi = typeof(TTarget).GetMethod(Method,
                BindingFlags.Instance | BindingFlags.Public);
            if (mi == null)
            {
                string message = string.Format
                    ("Public instance method '{0}' does not exist on {1}",
                    Method, typeof(TTarget).Name);
                throw new Exception(message);
            }
            return mi;
        }
    }
}
