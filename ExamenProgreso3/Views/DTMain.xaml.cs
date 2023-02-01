using System.Net;
using ExamenProgreso3.Models;
using Newtonsoft.Json;

namespace ExamenProgreso3.Views;



public partial class DTMain : ContentPage
{
	public DTMain()
	{
		InitializeComponent();
	}

    public async Task Button_ClickedDTAsync(object sender, EventArgs e)
    {
        //string cadena = Buscador.Text;
        var request = new HttpRequestMessage();
        //request.RequestUri = new Uri("https://jsonplaceholder.typicode.com/posts");
        request.RequestUri = new Uri("https://api.blockchain.com/v3/exchange/tickers");
        //request.RequestUri = new Uri("https://swapi.dev/api/planets/" + cadena);
        //request.RequestUri = new Uri("https://jsonplaceholder.typicode.com/posts?userId=" + cadena);

        request.Method = HttpMethod.Get;
        request.Headers.Add("Accept", "application/json");

        var client = new HttpClient();

        HttpResponseMessage response = await client.SendAsync(request);
        if (response.StatusCode == HttpStatusCode.OK)
        {
            String content = await response.Content.ReadAsStringAsync();
            //Dictionary<string, Post> dictionary = JsonConvert.DeserializeObject<Dictionary<string, Post>>(content);
            //var resultado = JsonConvert.DeserializeObject<Dictionary<string, Post>>(content); 
            var resultado = JsonConvert.DeserializeObject<List<API>>(content);
            //var resultado = root.results;
            ListaDemo.ItemsSource = resultado;


        }
    }
}