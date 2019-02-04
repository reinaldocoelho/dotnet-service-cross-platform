using System;
using System.Threading.Tasks;
using System.Timers;

namespace simple_service_counter
{
    public class ImplementacaoServico
    {
        private int contador;
        private readonly Timer _timer;

        public ImplementacaoServico()
        {
            _timer = new Timer(1000);
            _timer.Elapsed += new ElapsedEventHandler(EventoContador);
        }

        private void EventoContador(object source, ElapsedEventArgs e)
        {
            contador++;
            Console.WriteLine($"Contador em: {contador}");
            Task.Delay(10000).Wait();
        }

        public void Iniciar()
        {
            _timer.AutoReset = true;
            _timer.Enabled = true;
            _timer.Start();
        }

        public void Parar()
        {
            _timer.Stop();
            _timer.AutoReset = false;
            _timer.Enabled = false;
        }
    }
}