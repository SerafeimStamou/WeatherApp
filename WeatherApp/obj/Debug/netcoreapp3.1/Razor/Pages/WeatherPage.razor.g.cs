#pragma checksum "C:\WeatherApp\WeatherApp\Pages\WeatherPage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4f99316f1292a6b624251b1f0cd8019b24cc55bd"
// <auto-generated/>
#pragma warning disable 1591
namespace WeatherApp.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\WeatherApp\WeatherApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\WeatherApp\WeatherApp\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\WeatherApp\WeatherApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\WeatherApp\WeatherApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\WeatherApp\WeatherApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\WeatherApp\WeatherApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\WeatherApp\WeatherApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\WeatherApp\WeatherApp\_Imports.razor"
using WeatherApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\WeatherApp\WeatherApp\_Imports.razor"
using WeatherApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\WeatherApp\WeatherApp\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/weather")]
    public partial class WeatherPage : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 6 "C:\WeatherApp\WeatherApp\Pages\WeatherPage.razor"
 if(string.IsNullOrEmpty(error) is false)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(0, "    ");
            __builder.OpenElement(1, "p");
            __builder.AddContent(2, 
#nullable restore
#line 8 "C:\WeatherApp\WeatherApp\Pages\WeatherPage.razor"
        error

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(3, "\r\n");
#nullable restore
#line 9 "C:\WeatherApp\WeatherApp\Pages\WeatherPage.razor"
}
else if(forecast is null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(4, "   ");
            __builder.AddMarkupContent(5, "<h3>Loading...</h3>\r\n");
#nullable restore
#line 13 "C:\WeatherApp\WeatherApp\Pages\WeatherPage.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(6, "    ");
            __builder.OpenElement(7, "h1");
            __builder.AddContent(8, 
#nullable restore
#line 16 "C:\WeatherApp\WeatherApp\Pages\WeatherPage.razor"
         forecast.Title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n");
            __builder.AddContent(10, "    ");
            __builder.OpenElement(11, "table");
            __builder.AddAttribute(12, "class", "table table-bordered ");
            __builder.AddAttribute(13, "style", "margin-top:2px;");
            __builder.AddMarkupContent(14, "\r\n        ");
            __builder.AddMarkupContent(15, "<thead>\r\n            <tr>\r\n                <th>Date</th>\r\n                <th>Weather State</th>\r\n                <th>Low</th>\r\n                <th>High</th>\r\n            </tr>\r\n        </thead>\r\n        ");
            __builder.OpenElement(16, "tbody");
            __builder.AddMarkupContent(17, "\r\n");
#nullable restore
#line 28 "C:\WeatherApp\WeatherApp\Pages\WeatherPage.razor"
             foreach(var weather in forecast.Consolidated_weather)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(18, "                ");
            __builder.OpenElement(19, "tr");
            __builder.AddMarkupContent(20, "\r\n                    ");
            __builder.OpenElement(21, "td");
            __builder.AddContent(22, 
#nullable restore
#line 31 "C:\WeatherApp\WeatherApp\Pages\WeatherPage.razor"
                         weather.Applicable_date

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n                    ");
            __builder.OpenElement(24, "td");
            __builder.AddContent(25, 
#nullable restore
#line 32 "C:\WeatherApp\WeatherApp\Pages\WeatherPage.razor"
                         weather.Weather_state_name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n                    ");
            __builder.OpenElement(27, "td");
            __builder.AddContent(28, 
#nullable restore
#line 33 "C:\WeatherApp\WeatherApp\Pages\WeatherPage.razor"
                         weather.Min_temp

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n                    ");
            __builder.OpenElement(30, "td");
            __builder.AddContent(31, 
#nullable restore
#line 34 "C:\WeatherApp\WeatherApp\Pages\WeatherPage.razor"
                         weather.Max_temp

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n");
#nullable restore
#line 36 "C:\WeatherApp\WeatherApp\Pages\WeatherPage.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(34, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n");
#nullable restore
#line 40 "C:\WeatherApp\WeatherApp\Pages\WeatherPage.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 42 "C:\WeatherApp\WeatherApp\Pages\WeatherPage.razor"
            

    WeatherForecastModel forecast;
    string error;

    protected override async Task OnInitializedAsync()
    {
       
        var client = _clientFactory.CreateClient("meta");

        try
        {
            forecast = await client.GetFromJsonAsync<WeatherForecastModel>("location/946738/");
            error = null;
        }
        catch(Exception ex)
        {
            error = $"There is an error:{ex.Message}";
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IHttpClientFactory _clientFactory { get; set; }
    }
}
#pragma warning restore 1591
