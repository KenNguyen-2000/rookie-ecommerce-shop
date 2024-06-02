

using FluentAssertions;
using RookEcomShop.Application.Handlers.Products.Create;
using RookEcomShop.Domain.Entities;

public static partial class ProductsExtensions
{
    public static void ValidateCreatedFrom(this Product product, CreateProductCommand command)
    {
        product.Name.Should().Be(command.Name);
        product.Description.Should().Be(command.Description);
        // product.Sections.Should().HaveSameCount(command.Sections);
        // product.Sections.Zip(command.Sections).ToList().ForEach(pair => ValidateSection(pair.First, pair.Second));


        // static void ValidateSection(MenuSection section, CreateMenuSectionCommand command)
        // {
        //     section.Name.Should().Be(command.Name);
        //     section.Description.Should().Be(command.Description);
        //     section.Items.Should().HaveSameCount(command.Items);
        //     section.Items.Zip(command.Items).ToList().ForEach(pair => ValidateItem(pair.First, pair.Second));
        // }

        // static void ValidateItem(MenuItem item, CreateMenuItemCommand command)
        // {
        //     item.Name.Should().Be(command.Name);
        //     item.Description.Should().Be(command.Description);
        // }
    }
}