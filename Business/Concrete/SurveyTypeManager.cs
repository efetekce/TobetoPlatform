using AutoMapper;
using Business.Abstract;
using Business.Dtos.Request;
using Business.Dtos.Response;
using Business.Rules;
using Core.DataAccess.Paging;
using DataAccess.Abstracts;
using DataAccess.Concretes;
using Entities.Concretes;

namespace Business.Concrete
{
    public class SurveyTypeManager : ISurveyTypeService
    {
        ISurveyTypeDal _surveyTypeDal;
        IMapper _mapper;
        //SurveyTypeBusinessRules _surveyTypeBusinessRules;

        public SurveyTypeManager(ISurveyTypeDal surveyTypeDal,
        IMapper mapper)
        {
            _surveyTypeDal = surveyTypeDal;
            _mapper = mapper;
            //_surveyTypeBusinessRules = surveyTypeBusinessRules;
        }

        public async Task<CreatedSurveyTypeResponse> Add(CreateSurveyTypeRequest createSurveyTypeRequest)
        {
            SurveyType surveyType = _mapper.Map<SurveyType>(createSurveyTypeRequest);
            var createdSurveyType = await _surveyTypeDal.AddAsync(surveyType);
            CreatedSurveyTypeResponse result = _mapper.Map<CreatedSurveyTypeResponse>(createdSurveyType);
            return result;
        }

        public async Task<DeletedSurveyTypeResponse> Delete(DeleteSurveyTypeRequest deleteSurveyTypeRequest)
        {
            SurveyType surveyType = _mapper.Map<SurveyType>(deleteSurveyTypeRequest);
            var deletedSurveyType = await _surveyTypeDal.DeleteAsync(surveyType);
            DeletedSurveyTypeResponse result = _mapper.Map<DeletedSurveyTypeResponse>(deletedSurveyType);
            return result;
        }

        public async Task<IPaginate<GetListSurveyTypeResponse>> GetListSurveyType(PageRequest pageRequest)
        {
            var surveyType = await _surveyTypeDal.GetListAsync();
            var result = _mapper.Map<Paginate<GetListSurveyTypeResponse>>(surveyType);
            return result;
        }

        public async Task<UpdatedSurveyTypeResponse> Update(UpdateSurveyTypeRequest updateSurveyTypeRequest)
        {
            SurveyType surveyType = _mapper.Map<SurveyType>(updateSurveyTypeRequest);
            var updatedSurveyType = await _surveyTypeDal.UpdateAsync(surveyType);
            UpdatedSurveyTypeResponse result = _mapper.Map<UpdatedSurveyTypeResponse>(updatedSurveyType);
            return result;
        }
    }
}
