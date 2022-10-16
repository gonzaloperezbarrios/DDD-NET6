using domain.contracts;
using domain.entities;
using domain.value_objects;

namespace domain.services;

public class ArtistaService : IArtistaService
{
    private readonly IArtistaRepository artistaRepository;

    public ArtistaService(IArtistaRepository artistaRepository)
    {
        this.artistaRepository = artistaRepository;
    }

    public ArtistaVentaVO create(ArtistaCompletoEntity artistaCompleto)
    {
        artistaCompleto = artistaCompleto with { auditoria = "Admin" };
        if (!this.artistaRepository.create(artistaCompleto))
        {
            throw new Exception("No guardo en la fuente datos");
        }
        return new ArtistaVentaVO(artistaCompleto.id
       , artistaCompleto.nombreArtista
       , artistaCompleto.nombreDisco
       , artistaCompleto.publicacion
       , artistaCompleto.auditoria
       , artistaCompleto.publicacion * 2
       );
    }
}
