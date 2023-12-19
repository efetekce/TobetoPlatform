using AutoMapper;
using Business.Abstract;
using Business.Dtos.Request;
using Business.Dtos.Response;
using Core.DataAccess.Paging;
using DataAccess.Abstracts;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class LanguageManager : ILanguageService
    {
        ILanguageDal _languageDal;
        IMapper _mapper;
        public LanguageManager(ILanguageDal languageDal, IMapper mapper)
        {
            _languageDal = languageDal;
            _mapper = mapper;
        }
        public async Task<CreatedLanguageResponse> Add(CreateLanguageRequest createLanguageRequest)
        {
            ForeignLanguage language = _mapper.Map<ForeignLanguage>(createLanguageRequest);
            var createdLanguage = await _languageDal.AddAsync(language);
            CreatedLanguageResponse result =_mapper.Map<CreatedLanguageResponse>(createdLanguage);
            return result;

        }

        public async Task<DeletedLanguageResponse> Delete(DeleteLanguageRequest deletedLanguageRequest)
        {
            ForeignLanguage language = _mapper.Map<ForeignLanguage>(deletedLanguageRequest);
            var deletedLanguage = await _languageDal.DeleteAsync(language,true);
            DeletedLanguageResponse result = _mapper.Map<DeletedLanguageResponse>(deletedLanguage);
            return result;
        }

        public async Task<IPaginate<GetListLanguageResponse>> GetListLanguage()
        {
            var languages = await _languageDal.GetListAsync();
            var result=_mapper.Map<Paginate<GetListLanguageResponse>>(languages);
            return result;
        }

        public async Task<UpdatedLanguageResponse> Update(UpdateLanguageRequest updateLanguageRequest)
        {
            ForeignLanguage language = _mapper.Map<ForeignLanguage>(updateLanguageRequest);
            var updatedLanguage = await _languageDal.UpdateAsync(language);
            UpdatedLanguageResponse result = _mapper.Map<UpdatedLanguageResponse>(updatedLanguage);
            return result;
        }
    }
}
