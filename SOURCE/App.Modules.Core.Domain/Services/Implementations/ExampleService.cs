using App.Modules.Base.Domain.Services;

namespace App.Modules.Base.Domain.Services.Implementations
{
    /// <summary>
    /// An implementation of the 
    /// <see cref="IExampleService"/>
    /// </summary>
    public class ExampleService : IExampleService
    {


        /// <summary>
        /// An example operation.
        /// </summary>
        /// <returns></returns>
        public string Do()
        {
            return "works...";
        }
    }
}