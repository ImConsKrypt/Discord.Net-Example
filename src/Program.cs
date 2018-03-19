using System.Threading.Tasks;

namespace Example
{
        class Program
    {
        static void Main(string[] args)
            => new Program().MainAsync(args).GetAwaiter().GetResult();

        public async Task MainAsync(string[] args)
        {
            await Startup.RunAsync(args);
        }
    }
}
