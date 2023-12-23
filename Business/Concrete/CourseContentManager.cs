using AutoMapper;
using Business.Abstract;
using Business.Dtos.Request;
using Business.Dtos.Response;
using Business.Rules;
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
    public class CourseContentManager : ICourseContentService
    {

        ICourseContentDal _courseContentDal;
        IMapper _mapper;
        CourseContentBusinessRules _courseContentBusinessRules;
        public CourseContentManager(ICourseContentDal courseContentDal, IMapper mapper, CourseContentBusinessRules courseContentBusinessRules)
        {
            _courseContentDal = courseContentDal;
            _mapper = mapper;
            _courseContentBusinessRules = courseContentBusinessRules;
        }

        public async Task<CreatedCourseContentResponse> Add(CreateCourseContentRequest createCourseContentRequest)
        {
            await _courseContentBusinessRules.MustBeCourseDefined(createCourseContentRequest.CourseId);
            await _courseContentBusinessRules.MustBeContentTypeDefined(createCourseContentRequest.CourseContentTypeId);
            await _courseContentBusinessRules.ContentNameCantBeNull(createCourseContentRequest.Name);

            CourseContent courseContent = _mapper.Map<CourseContent>(createCourseContentRequest);
            var createdCourseContent = await _courseContentDal.AddAsync(courseContent);
            CreatedCourseContentResponse result = _mapper.Map<CreatedCourseContentResponse>(createdCourseContent);
            return result;
        }

        public async Task<DeletedCourseContentResponse> Delete(DeleteCourseContentRequest deleteCourseContentRequest)
        {
            CourseContent courseContent = _mapper.Map<CourseContent>(deleteCourseContentRequest);
            var deletedCourseContent = await _courseContentDal.DeleteAsync(courseContent, false);
            DeletedCourseContentResponse result = _mapper.Map<DeletedCourseContentResponse>(deletedCourseContent);
            return result;
        }

        public async Task<IPaginate<GetListCourseContentResponse>> GetListCourseContent(PageRequest pageRequest)
        {
            var courseContent = await _courseContentDal.GetListAsync(
                orderBy: c => c.OrderBy(c => c.Id),
                index: pageRequest.PageIndex,
                size: pageRequest.PageSize);
            var result = _mapper.Map<Paginate<GetListCourseContentResponse>>(courseContent);
            return result;
        }

        public async Task<UpdatedCourseContentResponse> Update(UpdateCourseContentRequest updateCourseContentRequest)
        {
            await _courseContentBusinessRules.MustBeCourseDefined(updateCourseContentRequest.CourseId);
            await _courseContentBusinessRules.MustBeContentTypeDefined(updateCourseContentRequest.CourseContentTypeId);
            await _courseContentBusinessRules.ContentNameCantBeNull(updateCourseContentRequest.Name);

            CourseContent courseContent = _mapper.Map<CourseContent>(updateCourseContentRequest);
            var updatedCourseContent = await _courseContentDal.UpdateAsync(courseContent);
            UpdatedCourseContentResponse result = _mapper.Map<UpdatedCourseContentResponse>(updatedCourseContent);
            return result;
        }
    }
}
