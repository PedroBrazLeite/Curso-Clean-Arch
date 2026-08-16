using CleanArchMvc.Domain.Validation;

namespace CleanArchMvc.Domain.Entities;

public sealed class Product : Entity
{
    public string Name { get; private set; }
    public string Description { get; private set; }
    public decimal Price { get; private set; }
    public int Stock { get; private set; }
    public string Image { get; private set; }

    public Product(string name, string description, decimal price, int stock, string image)
    {
        ValidateDomain(name, description, price, stock, image);
    }

    public Product(int id, string name, string description, decimal price, int stock, string image)
    {
        DomainExceptionValidation.When(id < 0, "Id deve ser valido");
        Id = id;
        ValidateDomain(name, description, price, stock, image);
    }
    
    public void Update(string name, string description, decimal price, int stock, string image, int categoryId)
    {
        ValidateDomain(name, description, price, stock, image);
        CategoryId = categoryId;
    }
    

    private void ValidateDomain(string name, string description, decimal price, int stock, string image)
    {
        DomainExceptionValidation.When(string.IsNullOrEmpty(name), 
            "Nome invalido, nome eh necessario");

        DomainExceptionValidation.When(name.Length < 3,
            "Nome invalido, muito pequeno, minimo 3 caracteres");

        DomainExceptionValidation.When(string.IsNullOrEmpty(description),
            "Descricao invalida. Descricao eh necessario");

        DomainExceptionValidation.When(description.Length < 5, 
            "Descricao invalida. Descricao deve ter mais de 5 caracteres");

        DomainExceptionValidation.When(price < 0, "Price invalido");

        DomainExceptionValidation.When(stock < 0, "Stock invalido");

        DomainExceptionValidation.When(image?.Length > 250,
            "Imagem invalida, muito grande, imagem deve ter no maximo 250 caracteres");

        Name = name;
        Description = description;
        Price = price;
        Stock = stock;
        Image = image;
        
    }
    
    public int CategoryId { get; set; }
    public Category Category { get; set; }
}