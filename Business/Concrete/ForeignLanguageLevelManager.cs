using AutoMapper;
using Business.Abstract;
using Business.Dtos.Request;
using Business.Dtos.Response;
using Core.DataAccess.Paging;
using DataAccess.Abstracts;
using DataAccess.Concretes;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ForeignLanguageLevelManager : IForeignLanguageLevelService
    {
        IForeignLanguageLevelDal _foreignLanguageLevelDal;
        IMapper _mapper;
        public ForeignLanguageLevelManager(IForeignLanguageLevelDal foreignLanguageLevelDal, IMapper mapper)
        {
            _foreignLanguageLevelDal = foreignLanguageLevelDal;
            _mapper = mapper;
        }

        public async Task<CreatedForeignLanguageLevelResponse> Add(CreateForeignLanguageLevelRequest createForeignLanguageLevelRequest)
        {
            ForeignLanguageLevel foreignLanguageLevel = _mapper.Map<ForeignLanguageLevel>(createForeignLanguageLevelRequest);
            var createdForeignLanguageLevel = await _foreignLanguageLevelDal.AddAsync(foreignLanguageLevel);
            CreatedForeignLanguageLevelResponse result = _mapper.Map<CreatedForeignLanguageLevelResponse>(createdForeignLanguageLevel);
            return result;
        }

        public async Task<DeletedForeignLanguageLevelResponse> Delete(DeleteForeignLanguageLevelRequest deleteForeignLanguageLevelRequest)
        {
            //ForeignLanguageLevel foreignLanguageLevel = _mapper.Map<ForeignLanguageLevel>(deleteForeignLanguageLevelRequest);
            ForeignLanguageLevel foreignLanguageLevel = await _foreignLanguageLevelDal.GetAsync(d => d.Id == deleteForeignLanguageLevelRequest.Id);
            var deletedForeignLanguageLevel = await _foreignLanguageLevelDal.DeleteAsync(foreignLanguageLevel,false);
            DeletedForeignLanguageLevelResponse result = _mapper.Map<DeletedForeignLanguageLevelResponse>(deletedForeignLanguageLevel);
            return result;
        }

        public async Task<IPaginate<GetListForeignLanguageLevelResponse>> GetListForeignLanguageLevel(PageRequest pageRequest)
        {        
            var foreignLanguageLevel = await _foreignLanguageLevelDal.GetListAsync(
                orderBy: f => f.OrderBy(f => f.Id),
                index: pageRequest.PageIndex,
                size: pageRequest.PageSize);
            var result = _mapper.Map<Paginate<GetListForeignLanguageLevelResponse>>(foreignLanguageLevel);
            return result;
        }

        public async Task<UpdatedForeignLanguageLevelResponse> Update(UpdateForeignLanguageLevelRequest updateForeignLanguageLevelRequest)
        {
            //ForeignLanguageLevel foreignLanguageLevel = _mapper.Map<ForeignLanguageLevel>(updateForeignLanguageLevelRequest);
            ForeignLanguageLevel foreignLanguageLevel = await _foreignLanguageLevelDal.GetAsync(i => i.Id == updateForeignLanguageLevelRequest.Id);
            _mapper.Map(updateForeignLanguageLevelRequest, foreignLanguageLevel);
            var updatedForeignLanguageLevel = await _foreignLanguageLevelDal.UpdateAsync(foreignLanguageLevel);
            UpdatedForeignLanguageLevelResponse result = _mapper.Map<UpdatedForeignLanguageLevelResponse>(updatedForeignLanguageLevel);
            return result;
        }
    }
}
