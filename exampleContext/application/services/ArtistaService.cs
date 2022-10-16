using api.entities;
using DomainService = domain.services;
using AutoMapper;
using domain.entities;
using domain.value_objects;

namespace application.services;

public class ArtistaService : IArtistaService
{
    private readonly IMapper _mapper;
    private readonly DomainService.IArtistaService artistaDomainService;

    public ArtistaService(DomainService.IArtistaService artistaDomainService, IMapper mapper = null)
    {
        this.artistaDomainService = artistaDomainService;
        _mapper = mapper;
    }

    public ArtistaVentaVO create(ArtistaEntity artista)
    {
        ArtistaEntity _artista = new ArtistaEntity
        {
            id = Guid.NewGuid().ToString(),
            nombreArtista = artista.nombreArtista,
            nombreDisco = artista.nombreDisco,
            publicacion = artista.publicacion
        };

        ArtistaCompletoEntity artistaCompleto=_mapper.Map<ArtistaCompletoEntity>(_artista);
        ArtistaVentaVO artistaVenta = this.artistaDomainService.create(artistaCompleto);
        return artistaVenta;
    }
}
