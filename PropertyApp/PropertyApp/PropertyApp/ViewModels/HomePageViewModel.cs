using PropertyApp.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace PropertyApp.ViewModels
{
    public class HomePageViewModel : PropertyChangedBase
    {
        private string nome;
        public string Nome
        {
            get { return nome; }
            set
            {
                nome = value;
                Notificar("Nome");
            }
        }
    }
}
