using AutoMapper;
using Cinema.BLL.Services.Core;
using Cinema.DAL.Interfaces;
using Microsoft.AspNetCore.Http;

namespace Cinema.BLL.Services;

public class BusinessService<TModel, TId>(
    IHttpContextAccessor httpContextAccessor,
    IGenericRepository<TModel, TId> repository,
    IMapper mapper
) : BaseBusinessService(httpContextAccessor) where TModel : class
{
    protected readonly IGenericRepository<TModel, TId> _repository = repository;
    protected readonly IMapper _mapper = mapper;
}