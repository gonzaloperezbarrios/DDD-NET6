using domain.entities;

namespace domain.value_objects;

public class ArtistaVentaVO : ArtistaCompletoEntity
{
    public decimal ventas { get; set; }
}
