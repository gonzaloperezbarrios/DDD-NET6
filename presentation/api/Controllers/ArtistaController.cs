using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using application.services;
using api.Dtos;
using api.entities;
using domain.value_objects;

namespace api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ArtistaController : ControllerBase
{

    private readonly IMapper _mapper;
    private readonly IArtistaService artistaService;

    public ArtistaController(IMapper mapper, IArtistaService artistaService)
    {
        _mapper = mapper;
        this.artistaService = artistaService;
    }

    [HttpGet]
    public ArtistaDto get()
    {
        return new ArtistaDto();
    }

    [HttpPost]
    public ActionResult<ArtistaVentaVO> post(ArtistaDto request)
    {
        ArtistaVentaVO artista = this.artistaService.create(_mapper.Map<ArtistaEntity>(request));
        return Ok(artista.ToString());
    }
}