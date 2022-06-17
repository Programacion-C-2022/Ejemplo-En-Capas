using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Net;
using Newtonsoft.Json;
using CapaLogica;

namespace API
{
    class Program
    {
        static void Main(string[] args)
        {

            // Crear e iniciar el Listener HTTP
            HttpListener listener = new HttpListener();
            string listenUrl = "http://127.0.0.1:8888/";
            listener.Prefixes.Add(listenUrl);
            listener.Start();
            Console.WriteLine("Listening...");


            while (true)
            {
                // Obtener contexto del Listener para extraer informacion
                HttpListenerContext context = listener.GetContext();

                // Extraer el request del contexto del listener
                HttpListenerRequest request = context.Request;
                HttpListenerResponse response = context.Response;

                // Imprimir el log del request en consola
                Log(request);

                // Crear body de respuesta
                Respuesta r = new Respuesta(request,response);

                // Enviar body de respuesta
                System.IO.Stream output = r.response.OutputStream;
                output.Write(r.buffer, 0, r.buffer.Length);

                // Cerrar la con el cliente
                output.Close();
            }
        }

        static string getData()
        {
            return JsonConvert.SerializeObject(PersonitaControlador.ObtenerTodos());
        }
        

        public static void Log(HttpListenerRequest request)
        {
            Console.WriteLine(request.RemoteEndPoint + " " + request.HttpMethod + " " + request.RawUrl);
        }
    }
}
