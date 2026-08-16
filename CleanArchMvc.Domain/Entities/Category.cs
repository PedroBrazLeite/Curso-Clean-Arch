using CleanArchMvc.Domain.Validation;

namespace CleanArchMvc.Domain.Entities;

public sealed class Category : Entity
{
    public string Name { get; private set; }

    public Category(string name)
    {
        ValidateDomain(name);
    }

    public Category(int id, string name)
    {
        DomainExceptionValidation.When(id < 0, "Id deve ser valido");
        Id = id;
        ValidateDomain(name);
    }

    public void Update(string name)
    {ValidateDomain(name);
    }
    
    public ICollection<Product> Products { get; set; }

    private void ValidateDomain(string name)
    {
        DomainExceptionValidation.When(string.IsNullOrEmpty(name), "Nome invalido, nome eh necessario");
        DomainExceptionValidation.When(name.Length < 3, "Nome invalido, muito pequeno, minimo 3 caracteres");

        Name = name;
    }
}