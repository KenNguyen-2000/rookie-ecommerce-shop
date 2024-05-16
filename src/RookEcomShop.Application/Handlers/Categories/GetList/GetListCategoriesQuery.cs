using MediatR;
using RookEcomShop.ViewModels.Category;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RookEcomShop.Application.Handlers.Categories.GetList
{
    public class GetListCategoriesQuery : IRequest<IEnumerable<CategoryVM>>
    { }
}
