using CommunityToolkit.Mvvm.ComponentModel;

using System.Collections.ObjectModel;

namespace PeopleBuyMobile.Pages;

public partial class Offers : ContentPage
{
    public Offers()
    {
        BindingContext = new SwipeCardViewModel();   
    }
  
}
public class SwipeCardViewModel : ObservableObject
{
    public SwipeCardViewModel()
    {
        Cards = new ObservableCollection<CardModel>
        {
            new CardModel { Title = "T�tulo do Card 1", Description = "Descri��o do Card 1" },
            new CardModel { Title = "T�tulo do Card 2", Description = "Descri��o do Card 2" },
            new CardModel { Title = "T�tulo do Card 3", Description = "Descri��o do Card 3" },
        };
    }

    public ObservableCollection<CardModel> Cards { get; set; }
}

public class CardModel
{
    public string Title { get; set; }
    public string Description { get; set; }
}


