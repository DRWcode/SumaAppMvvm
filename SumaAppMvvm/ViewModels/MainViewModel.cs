using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using SumaAppMvvm.Models;
using System;

namespace SumaAppMvvm.ViewModels
{
    public partial class MainViewModel : ObservableObject
    {
        [ObservableProperty]
        private double _valor1;

        [ObservableProperty]
        private double _valor2;

        [ObservableProperty]

        private double _resultado;

        [RelayCommand]
        
        private void Sumar()
        {
            try
            {
                SumaModel s = new SumaModel();
                s.Valor1 = _valor1;
                s.Valor2 = _valor2;
                Resultado = s.Sumar();
            }
            catch (Exception ex)
            {
                MainThread.BeginInvokeOnMainThread(async () => await App.Current!.MainPage!.DisplayAlert("ERROR", ex.Message, "Aceptar"));
            }
        }
       
     [RelayCommand]
     
        private void Limpiar()
        {
            Valor1 = 0;
            Valor2 = 0;
            Resultado = 0;
        }

        
    }
}
