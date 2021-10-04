using System;

namespace BeanStalkPOC.Utility.Singleton
{
    public class Singleton : ISingleton
    {
        //private static readonly Singleton instance = new Singleton();

        //private Singleton()
        //{

        //}

        //public static Singleton Instance => instance;
        public int TenantId { get; set; }
    }
}
