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
            backing = default;

        public Stateful(T defaultValue) =>
            backing = defaultValue;

        T backing;
        public T Value
        {
            get => backing;
            set => SetProperty(ref backing, value);
        }
    }

    public class MyViewModel
    {
        public Stateful<int> Count { get; } = new Stateful<int>(1);

        public void CountUp()
        {
            var current = Count.Value;

            Count.Value = current + 1;
        }
    }
}