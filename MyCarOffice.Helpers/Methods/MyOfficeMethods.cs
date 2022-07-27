using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MyCarOffice.Helpers.Methods;

public static class MyOfficeMethods
{
    /// <summary>
    ///     O método ValidRequireds, utiliza a recursividade para percorrer um dto recebido e listar todas as propriedades requeridas.
    ///     Com a lista de propriedades requeridas, varre o objeto recebido, analisando se todoas as propriedades requeridas possuem
    ///     valor, validando assim, seu estado
    /// </summary>
    public static bool ValidarRequeridos<TEntityDto>(TEntityDto dtoRecebido)
    {
        // Monta uma lista com as propriedades marcadas com required
        var propertiesRequireds = TypeDescriptor.GetProperties(typeof(TEntityDto))
            .Cast<PropertyDescriptor>()
            .Where(p => p.Attributes.Cast<Attribute>().Any(a => a.GetType() == typeof(RequiredAttribute)))
            .Select(p => p.Name)
            .ToList();

        // Monta uma lista com todas as propriedades existentes no Dto
        var type = dtoRecebido?.GetType();
        var properties = type?.GetProperties().ToList();

        // Faz um loop em cada propriedade do objetoDto
        if (properties != null)
            foreach (var property in properties)
            {
                // Pega o nome da propriedade
                var propValue = property.GetValue(dtoRecebido, null)!;
                // Pega o valor que está na propriedade
                var propName = property.Name!;

                // Se a propriedade está na lista de requireds, analise se tem valor, se não tiver, o retorno é false'
                if (propertiesRequireds.Contains(propName) && string.IsNullOrEmpty(propValue.ToString())) return false;
            }

        return true;
    }
}