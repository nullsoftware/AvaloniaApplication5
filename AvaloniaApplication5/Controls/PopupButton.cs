using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.Primitives;
using Avalonia.Media;
using Avalonia.Metadata;

namespace AvaloniaApplication5.Controls
{
    public class PopupButton : Button
    {
        public static readonly StyledProperty<Control?> PopupContentProperty = AvaloniaProperty.Register<PopupButton, Control?>(nameof(PopupContent));

        [Content]
        public Control? PopupContent { get; set; }

        private Popup _host;


        public PopupButton()
        {
            _host = new Popup();
            _host.PlacementTarget = this;
            _host.Placement = PlacementMode.BottomEdgeAlignedLeft;
            _host.IsLightDismissEnabled = true;
            _host.OverlayDismissEventPassThrough = true;

        }

        protected override void OnClick()
        {
            if (_host.IsOpen)
            {
                return;
            }

            if (_host.Child != PopupContent)
            {
                _host.Child = PopupContent;
            }

            _host.IsOpen = true;
        }
    }
}
