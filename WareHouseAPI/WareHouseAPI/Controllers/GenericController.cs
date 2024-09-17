using Microsoft.AspNetCore.Mvc;
using WareHouseBLL.Interface;
using WareHouseBLL.Models;
using WareHouseDAL.Interface;

namespace WareHouseAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class GenericController<TModel,DTO> : ControllerBase 
    where TModel : BaseModel, new()
    where DTO : IBaseDTO,new()
{
    private readonly IGenericService<TModel> _genericService;

    public GenericController(IGenericService<TModel> genericService)
    {
        _genericService = genericService;
    }

    [HttpGet("all")]
    public async Task<List<DTO>> GetAll(CancellationToken cancellationToken)
    {
        var result = await _genericService.GetAll(cancellationToken);

        return result.Select(x => new DTO
        {
            Id = x.Id,
        }).ToList();
    }

    [HttpGet]
    public async Task<DTO?> GetById(string id, CancellationToken cancellationToken)
    {
        var result = await _genericService.GetById(id, cancellationToken);

        if (result == null)
            throw new Exception();

        return new DTO
        {
            Id = result.Id
        };
    }

    [HttpPost]
    public async Task Create(DTO dto, CancellationToken cancellationToken)
    {
        var model = new TModel
        {
            Id = dto.Id
        };

        await _genericService.Create(model, cancellationToken);
    }

    [HttpDelete]
    public async Task Delete(string id, CancellationToken cancellationToken)
    {
        await _genericService.Delete(id, cancellationToken);
    }

    [HttpPut]
    public async Task Update(DTO dto, CancellationToken cancellationToken)
    {
        var model = new TModel
        {
            Id = dto.Id
        };

        await _genericService.Update(model, cancellationToken);
    }
}
