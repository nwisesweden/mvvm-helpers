using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace MvvmHelpers.Samples
{
    public class MainViewModel
    {
        public Stateful<string> Name { get; } = new Stateful<string>();
        public Stateful<int> Count { get; } = new Stateful<int>();
        public Stateful<string> CountLabel { get; } = new Stateful<string>("Click Me!");
        public Command IncreaseCountCommand { get; }

        public MainViewModel()
        {
            IncreaseCountCommand = new Command(ExecuteIncreaseCommand);
        }

        private void ExecuteIncreaseCommand()
        {
            Count.Value++;
            CountLabel.Value = $"You clicked {Count.Value} times.";
        }
    }
}
