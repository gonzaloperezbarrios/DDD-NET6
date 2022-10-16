using domain.entities;

namespace domain.value_objects;

public record ArtistaVentaVO(string id, string nombreArtista, string nombreDisco, int publicacion, string auditoria, decimal ventas);
