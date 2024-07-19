using ReactiveUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Subjects;
using System.Text;
using System.Threading.Tasks;

namespace ToggleColorApp.ViewModels
{
    public class ToggleColorAppViewModel : ViewModelBase
    {
        private BehaviorSubject<string> _colorRect = new BehaviorSubject<string>("black");
        public IObservable<string> ColorRect => _colorRect;

        public ToggleColorAppViewModel()
        {
            _colorRect.OnNext("pink");
        }

        public void ToggleColor()
        {
            var newColor = _colorRect.Value == "pink" ? "blue" : "red";
            _colorRect.OnNext(newColor);
            this.RaisePropertyChanged(nameof(ColorRect));
        }
    }
}
