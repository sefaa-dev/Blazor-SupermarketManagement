// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace WebApp.Controls
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
    public partial class SelectProductForSellingComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 44 "C:\Users\Sefa\Source\Repos\Blazor-SupermarketManagement\WebApp\Controls\SelectProductForSellingComponent.razor"
       

    private IEnumerable<Product> productsInCategory;

    [Parameter]
    public EventCallback<Product>  OnProductSelected { get; set; }

    private int selectedCategoryId;
    private int SelectedCategoryId
    {
        get
        {
            return selectedCategoryId;
        }
        set
        {
            selectedCategoryId = value;
            productsInCategory = ViewProductsByCategoryId.Execute(value);
            StateHasChanged();
        }
    }

    private IEnumerable<Category> categories;

    protected override void OnInitialized()
    {
        base.OnInitialized();

        categories = ViewCategoriesUseCase.Execute();
    }

    private void OnSelectProduct(Product product)
    {
        OnProductSelected.InvokeAsync(product);
        }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private UseCases.IViewProductsByCategoryId ViewProductsByCategoryId { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private UseCases.IViewCategoriesUseCase ViewCategoriesUseCase { get; set; }
    }
}
#pragma warning restore 1591
