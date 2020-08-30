using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using Receitas.CustomRenderers;
using Receitas.iOS.CustomRenderer;
using UIKit;
using Xamarin.Forms;

[assembly : ExportRenderer(typeof(CustomSearchBar), typeof(CustomSearchBarRenderer))]
namespace Receitas.iOS.CustomRenderer
{
    public class CustomSearchBarRenderer : UISearchBar
    {

    }
}