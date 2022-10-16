using domain.entities;
using domain.value_objects;

namespace domain.services;

public class ArtistaService : IArtistaService
{
    public ArtistaVentaVO create(ArtistaCompletoEntity artistaCompleto)
    {
        return new ArtistaVentaVO
        {
            id = artistaCompleto.id,
            nombreArtista = artistaCompleto.nombreArtista,
            nombreDisco = artistaCompleto.nombreDisco,
            publicacion = artistaCompleto.publicacion,
            auditoria = "Admin",
            ventas = artistaCompleto.publicacion * 2 
        };
    }
}
