using System.Collections.ObjectModel;
using telas.Models;
using telas.Services;

namespace telas;

public partial class RankingPage : ContentPage
{
    public ObservableCollection<ParticipanteViewModel> ListaRanking { get; set; } = new ObservableCollection<ParticipanteViewModel>();

    public RankingPage()
	{
		InitializeComponent();
        BindingContext = this;
	}

    protected override void OnAppearing()
    {
        base.OnAppearing();
        LoadData();
    }

    private async Task LoadData()
    {
        var listaRanking = await ApiService<ParticipanteViewModel>.GetList("Ranking");

        Console.WriteLine(listaRanking.Count);
        Console.WriteLine("teste");
        foreach (var item in listaRanking.OrderByDescending(x => x.Pontos))
        {
            ListaRanking.Add(item);
        }
        Console.WriteLine(listaRanking.Count);

    }
}