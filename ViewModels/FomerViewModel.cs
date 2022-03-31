using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ga.Services;
using GestionDesAbsencesv1.Models;

namespace Ga.ViewModels
{
    class FomerViewModel : ObservableObject
    {
        User userFormer = new();
        string _userId;

        public string UserId { get => _userId; set => OnPropertyChanged(ref _userId, value); }

    }
}
