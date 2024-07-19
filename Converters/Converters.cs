using Avalonia.Data.Converters;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToggleColorApp.Converters
{
    public class ColorToCssConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is string color)
            {
                return $".inner-rect {{ fill: {color}; }}";
            }

            return $".inner-rect {{ fill: blue; }}";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
    public static class ValueConverters
    {
        public static FuncValueConverter<string, string> ColorToCssConverter =>
                new FuncValueConverter<string, string>(color => $".inner-rect {{ fill: {color}; }}");
    }
}
