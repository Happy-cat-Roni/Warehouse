using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using WareHouseAPI.Interface;
using WareHouseBLL.Interface;
using WareHouseBLL.Models;

namespace WareHouseAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class GenericController<TModel,DTO> : ControllerBase 
    where TModel : BaseModel, new()
    where DTO : IBaseDTO,new()
{
    private readonly IGenericService<TModel> _genericService;
    private readonly IMapper _mapper;

    public GenericController(IGenericService<TModel> genericService, IMapper mapper)
    {
        _genericService = genericService;
        _mapper = mapper;
    }

    [HttpGet("all")]
    public async Task<List<DTO>> GetAll(CancellationToken cancellationToken)
    {
        var result = await _genericService.GetAll(cancellationToken);

        return _mapper.Map<List<DTO>>(result);
    }

    [HttpGet]
    public async Task<DTO?> GetById(Guid id, CancellationToken cancellationToken)
    {
        var result = await _genericService.GetById(id, cancellationToken);

        if (result == null)
            throw new Exception();

        return _mapper.Map<DTO>(result);
    }

    [HttpPost]
    public async Task Create(DTO dto, CancellationToken cancellationToken)
    {
        var model = _mapper.Map<TModel>(dto);

        await _genericService.Create(model, cancellationToken);
    }

    [HttpDelete]
    public async Task Delete(Guid id, CancellationToken cancellationToken)
    {
        await _genericService.Delete(id, cancellationToken);
    }

    [HttpPut]
    public async Task Update(DTO dto, CancellationToken cancellationToken)
    {
        var model = _mapper.Map<TModel>(dto);

        await _genericService.Update(model, cancellationToken);
    }
}
