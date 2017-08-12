using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace BwolfXamarin.Components
{
    public class CardView : Frame
    {
        public CardView()
        {
            Margin = 5;
            Padding = 10;
            if (Device.OS == TargetPlatform.iOS)
            {
                HasShadow = false;
                OutlineColor = Color.Transparent;
                BackgroundColor = Color.Transparent;
            }
        }
    }
}
