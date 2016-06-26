using System;

namespace StructureMap.AutoMocking.Moq
{
    /// <summary>
    /// 
    /// </summary>
    public class MoqServiceLocator : ServiceLocator
    {
        private readonly MoqFactory _moqs = new MoqFactory();

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public T Service<T>() where T : class
        {
            return (T) _moqs.CreateMock(typeof (T));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="serviceType"></param>
        /// <returns></returns>
        public object Service(Type serviceType)
        {
            return _moqs.CreateMock(serviceType);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public T PartialMock<T>(params object[] args) where T : class
        {
            return (T) _moqs.CreateMockThatCallsBase(typeof (T), args);
        }
    }
}