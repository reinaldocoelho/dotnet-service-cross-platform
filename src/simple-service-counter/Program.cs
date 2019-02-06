using System;
using Topshelf;

namespace simple_service_counter
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Iniciando o serviço...");
            HostFactory.Run(x =>
            {
                x.Service<ImplementacaoServico>(s =>
                {
                    s.ConstructUsing(nameof => new ImplementacaoServico());
                    s.WhenStarted(ws => ws.Iniciar());
                    s.WhenStopped(ws => ws.Parar());
                });
                x.SetDescription("Serviço de apresentação TopShelf.");
                x.SetDisplayName("simple_service_counter");
                x.SetServiceName("simple_service_counter");
            });
        }
    }
}
