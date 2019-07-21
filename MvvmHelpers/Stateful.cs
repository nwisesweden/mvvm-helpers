using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MvvmHelpers
{
    public class Stateful<T> : ObservableObject
    {
        public Stateful() =>
            state = default;

        public Stateful(T state) =>
            this.state = state;

        T state;
        public T State
        {
            get => state;
            set => SetProperty(ref state, value);
        }
    }
}