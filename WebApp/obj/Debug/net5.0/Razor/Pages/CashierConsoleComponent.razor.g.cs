#pragma checksum "C:\Users\Sefa\Source\Repos\Blazor-SupermarketManagement\WebApp\Pages\CashierConsoleComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e397ebd3347c86e61a83084cb1974e8097f7c5ec"
// <auto-generated/>
#pragma warning disable 1591
namespace WebApp.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Sefa\Source\Repos\Blazor-SupermarketManagement\WebApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Sefa\Source\Repos\Blazor-SupermarketManagement\WebApp\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Sefa\Source\Repos\Blazor-SupermarketManagement\WebApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Sefa\Source\Repos\Blazor-SupermarketManagement\WebApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Sefa\Source\Repos\Blazor-SupermarketManagement\WebApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Sefa\Source\Repos\Blazor-SupermarketManagement\WebApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Sefa\Source\Repos\Blazor-SupermarketManagement\WebApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Sefa\Source\Repos\Blazor-SupermarketManagement\WebApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Sefa\Source\Repos\Blazor-SupermarketManagement\WebApp\_Imports.razor"
using WebApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Sefa\Source\Repos\Blazor-SupermarketManagement\WebApp\_Imports.razor"
using WebApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Sefa\Source\Repos\Blazor-SupermarketManagement\WebApp\_Imports.razor"
using WebApp.Controls;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Sefa\Source\Repos\Blazor-SupermarketManagement\WebApp\_Imports.razor"
using CoreBusiness;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/cashier_console")]
    public partial class CashierConsoleComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "row");
            __builder.AddMarkupContent(2, "<div class=\"col-7\"><h3>Cashier\'s Console</h3></div>\r\n    ");
            __builder.AddMarkupContent(3, "<div class=\"col-2\"><label for=\"cashier\">Cashier Name:</label></div>\r\n    ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "col-3");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "form-group");
            __builder.OpenElement(8, "input");
            __builder.AddAttribute(9, "type", "text");
            __builder.AddAttribute(10, "id", "cashier");
            __builder.AddAttribute(11, "class", "form-control");
            __builder.AddAttribute(12, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 7 "C:\Users\Sefa\Source\Repos\Blazor-SupermarketManagement\WebApp\Pages\CashierConsoleComponent.razor"
                                                                              cashierName

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(13, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => cashierName = __value, cashierName));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n\r\n<br>\r\n\r\n");
            __builder.OpenElement(15, "div");
            __builder.AddAttribute(16, "class", "row");
            __builder.OpenElement(17, "div");
            __builder.AddAttribute(18, "class", "col-4");
            __builder.OpenComponent<WebApp.Controls.SelectProductForSellingComponent>(19);
            __builder.AddAttribute(20, "OnProductSelected", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<CoreBusiness.Product>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<CoreBusiness.Product>(this, 
#nullable restore
#line 16 "C:\Users\Sefa\Source\Repos\Blazor-SupermarketManagement\WebApp\Pages\CashierConsoleComponent.razor"
                                                             SelectProduct

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.AddMarkupContent(21, "\r\n        <br>\r\n        ");
            __builder.OpenComponent<WebApp.Controls.SellProductComponent>(22);
            __builder.AddAttribute(23, "CashierName", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 19 "C:\Users\Sefa\Source\Repos\Blazor-SupermarketManagement\WebApp\Pages\CashierConsoleComponent.razor"
                                            cashierName

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(24, "SelectedProduct", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<CoreBusiness.Product>(
#nullable restore
#line 20 "C:\Users\Sefa\Source\Repos\Blazor-SupermarketManagement\WebApp\Pages\CashierConsoleComponent.razor"
                                               selectedProduct

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(25, "OnProductSold", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<CoreBusiness.Product>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<CoreBusiness.Product>(this, 
#nullable restore
#line 21 "C:\Users\Sefa\Source\Repos\Blazor-SupermarketManagement\WebApp\Pages\CashierConsoleComponent.razor"
                                             SellProduct

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n    ");
            __builder.OpenElement(27, "div");
            __builder.AddAttribute(28, "class", "col");
            __builder.OpenComponent<WebApp.Controls.TodayTransactionsComponent>(29);
            __builder.AddComponentReferenceCapture(30, (__value) => {
#nullable restore
#line 25 "C:\Users\Sefa\Source\Repos\Blazor-SupermarketManagement\WebApp\Pages\CashierConsoleComponent.razor"
                                          transactionComponent = (WebApp.Controls.TodayTransactionsComponent)__value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 29 "C:\Users\Sefa\Source\Repos\Blazor-SupermarketManagement\WebApp\Pages\CashierConsoleComponent.razor"
       

    private TodayTransactionsComponent transactionComponent;

    private Product selectedProduct;
    private string cashierName;

    protected override void OnInitialized()
    {
        base.OnInitialized();
    }

    protected override void OnAfterRender(bool firstRender)
    {
        base.OnAfterRender(firstRender);

        if (firstRender)
        {
            transactionComponent.LoadTransactions(cashierName);
        }
    }

    private void SelectProduct(Product product)
    {
        selectedProduct = product;
    }

    private void SellProduct(Product product)
    {
        transactionComponent.LoadTransactions(cashierName);
    }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
