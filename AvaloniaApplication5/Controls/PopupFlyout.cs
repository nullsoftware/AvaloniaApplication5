using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.Primitives;
using Avalonia.Media;
using Avalonia.Metadata;

namespace AvaloniaApplication5.Controls
{
    public class PopupFlyout : PopupFlyoutBase
    {
        public static readonly StyledProperty<object?> PopupContentProperty = 
            AvaloniaProperty.Register<PopupFlyout, object?>(nameof(PopupContent));

        [Content]
        public object? PopupContent { get; set; }

        protected override Control CreatePresenter()
        {
            Popup.OverlayDismissEventPassThrough = true;

            return new FlyoutPresenter()
            {
                Content = PopupContent,
            };
        }
    }
}
