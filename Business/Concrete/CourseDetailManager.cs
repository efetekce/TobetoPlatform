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
    public class CourseDetailManager : ICourseDetailService
    {

        ICourseDetailDal _courseDetailDal;
        IMapper _mapper;
        CourseDetailBusinessRules _courseDetailBusinessRules;
        public CourseDetailManager(ICourseDetailDal courseDetailDal, IMapper mapper, CourseDetailBusinessRules courseDetailBusinessRules)
        {
            _courseDetailDal = courseDetailDal;
            _mapper = mapper;
            _courseDetailBusinessRules = courseDetailBusinessRules;
        }

        public async Task<CreatedCourseDetailResponse> Add(CreateCourseDetailRequest createCourseDetailRequest)
        {
            await _courseDetailBusinessRules.MustBeCourseDefined(createCourseDetailRequest.CourseId);
            await _courseDetailBusinessRules.MustBeOrganizationDefined(createCourseDetailRequest.OrganizationId);
            await _courseDetailBusinessRules.MustBeContentDefined(createCourseDetailRequest.CourseContentId);
            await _courseDetailBusinessRules.MustBeCategoryDefined(createCourseDetailRequest.CategoryId);
            await _courseDetailBusinessRules.SubTypeCantBeNull(createCourseDetailRequest.SubType);
            await _courseDetailBusinessRules.LanguageCantBeNull(createCourseDetailRequest.Language);

            CourseDetail courseDetail = _mapper.Map<CourseDetail>(createCourseDetailRequest);
            var createdCourseDetail = await _courseDetailDal.AddAsync(courseDetail);
            CreatedCourseDetailResponse result = _mapper.Map<CreatedCourseDetailResponse>(createdCourseDetail);
            return result;
        }

        public async Task<DeletedCourseDetailResponse> Delete(DeleteCourseDetailRequest deleteCourseDetailRequest)
        {
            CourseDetail courseDetail = _mapper.Map<CourseDetail>(deleteCourseDetailRequest);
            var deletedCourseDetail = await _courseDetailDal.DeleteAsync(courseDetail, false);
            DeletedCourseDetailResponse result = _mapper.Map<DeletedCourseDetailResponse>(deletedCourseDetail);
            return result;
        }

        public async Task<IPaginate<GetListCourseDetailResponse>> GetListCourseDetail()
        {
            var CourseDetail = await _courseDetailDal.GetListAsync();
            var result = _mapper.Map<Paginate<GetListCourseDetailResponse>>(CourseDetail);
            return result;
        }

        public async Task<UpdatedCourseDetailResponse> Update(UpdateCourseDetailRequest updateCourseDetailRequest)
        {
            await _courseDetailBusinessRules.MustBeCourseDefined(updateCourseDetailRequest.CourseId);
            await _courseDetailBusinessRules.MustBeOrganizationDefined(updateCourseDetailRequest.OrganizationId);
            await _courseDetailBusinessRules.MustBeContentDefined(updateCourseDetailRequest.CourseContentId);
            await _courseDetailBusinessRules.MustBeCategoryDefined(updateCourseDetailRequest.CategoryId);
            await _courseDetailBusinessRules.SubTypeCantBeNull(updateCourseDetailRequest.SubType);
            await _courseDetailBusinessRules.LanguageCantBeNull(updateCourseDetailRequest.Language);

            CourseDetail courseDetail = _mapper.Map<CourseDetail>(updateCourseDetailRequest);
            var updatedCourseDetail = await _courseDetailDal.UpdateAsync(courseDetail);
            UpdatedCourseDetailResponse result = _mapper.Map<UpdatedCourseDetailResponse>(updatedCourseDetail);
            return result;
        }
    }
}
