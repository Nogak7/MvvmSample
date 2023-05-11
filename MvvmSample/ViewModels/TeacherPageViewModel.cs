using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MvvmSample.ViewModels
{
    public class TeacherPageViewModel : ViewModel
    {
        private string text;

        public string Text { get { return text; } set { if (text != value) { text = value;  OnPropertyChanged(); } } }
        private string _text;
        public ICommand ChangeText { get; set; }

        public TeacherPageViewModel()
        {
            ChangeText = new Command(async () => Text = await AppShell.Current.DisplayPromptAsync("enter", "enter name" , "aprove"));
        }
    }
}
