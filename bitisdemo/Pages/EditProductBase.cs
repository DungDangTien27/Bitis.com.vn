using bitis.mode;
using bitisdemo.Services;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace bitisdemo.Pages
{
    public class EditProductBase : ComponentBase
    {
        [Inject]
        public IProductService ProductService { get; set; }
        public Product Product { get; set; } = new Product();

        [Inject]
        public ICategoryService CategoryService { get; set; }
        public List<Category> Categorys { get; set; } = new List<Category>();
        public string IdDanhMuc { get; set; }

        [Required(ErrorMessage = "Nhập giá sản phẩm")]
        public string Gia { get; set; }
        [Required(ErrorMessage = "Nhập số lượng sản phẩm")]
        public string SoLuong { get; set; }
        
        [Parameter]
        public string Id { get; set; }

        [Inject]
        public NavigationManager NavigationManager { get; set; }

        protected async override Task OnInitializedAsync()
        {
            Product = await ProductService.GetProduct(int.Parse(Id));

            Categorys = (await CategoryService.GetCategorys()).ToList();
            IdDanhMuc = Product.IdDanhMuc.ToString();

            Gia = Product.Gia.ToString();
            SoLuong = Product.SoLuong.ToString();
        }

        protected async Task HandleValidSubmit()
        {           
            var result = await ProductService.UpdateProduct(Product);
            if (result != null)
            {
                NavigationManager.NavigateTo("/");
            }
        }
    }
}
