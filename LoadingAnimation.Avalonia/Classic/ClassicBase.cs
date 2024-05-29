using Avalonia;
using Avalonia.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoadingAnimation.Avalonia.Classic
{
    public class ClassicBase : UserControl
    {
        public static readonly StyledProperty<object> CaptionTextProperty =
       AvaloniaProperty.Register<ClassicBase, object>(nameof(CaptionText), defaultValue: "Loading...");

        public object CaptionText
        {
            get => GetValue(CaptionTextProperty);
            set => SetValue(CaptionTextProperty, value);
        }
    }
}
