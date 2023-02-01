using System.Net;
using ExamenProgreso3.Models;
using Newtonsoft.Json;

namespace ExamenProgreso3.Views;


[QueryProperty("Item", "Item")]
public partial class DTMain : ContentPage
{
	public DTMain()
	{
		InitializeComponent();
	}

    public async void Button_ClickedDT(object sender, EventArgs e)
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
            var resultado = JsonConvert.DeserializeObject<List<APIDT>>(content);
            ListaDemo.ItemsSource = resultado;
            

            //var resultado = root.results;



        }
        
    }

    //private void OnCollectionView_SelectionChangedDT(object sender, SelectionChangedEventArgs e)
    //{
    //    APIDT burger = e.CurrentSelection.FirstOrDefault() as APIDT;
    //    if (burger == null)
    //    {
    //        return;
    //    }
    //    //Shell.Current.GoToAsync(nameof(APIItemPage), true, new Dictionary<string, object>
    //    //{
    //    //{ "Item", burger}
    //    //});
    //    App.APIRepoDT.AddNew(resultado)
    //    ((CollectionView)sender).SelectedItem = null;
    //}
}