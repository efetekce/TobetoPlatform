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
    public class CourseCategoryManager : ICourseCategoryService
    {
        ICourseCategoryDal _courseCategoryDal;
        IMapper _mapper;
        public CourseCategoryManager(ICourseCategoryDal courseCategoryDal,IMapper mapper)
        {
            _courseCategoryDal = courseCategoryDal;
            _mapper = mapper;
        }

        public async Task<CreatedCourseCategoryResponse> Add(CreateCourseCategoryRequest createCourseCategoryRequest)
        {
            CourseCategory courseCategory = _mapper.Map<CourseCategory>(createCourseCategoryRequest);
            var createdCourseCategory = await _courseCategoryDal.AddAsync(courseCategory);
            CreatedCourseCategoryResponse result = _mapper.Map<CreatedCourseCategoryResponse>(createdCourseCategory);
            return result;
        }

        public async Task<DeletedCourseCategoryResponse> Delete(DeleteCourseCategoryRequest deleteCourseCategoryRequest)
        {
            CourseCategory courseCategory = _mapper.Map<CourseCategory>(deleteCourseCategoryRequest);
            var deletedCourseCategory = await _courseCategoryDal.DeleteAsync(courseCategory, false);
            DeletedCourseCategoryResponse result = _mapper.Map<DeletedCourseCategoryResponse>(deletedCourseCategory);
            return result;
        }

        public async Task<IPaginate<GetListCourseCategoryResponse>> GetListCourseCategory()
        {
            var courseCategory = await _courseCategoryDal.GetListAsync();
            var result = _mapper.Map<Paginate<GetListCourseCategoryResponse>>(courseCategory);
            return result;
        }

        public async Task<UpdatedCourseCategoryResponse> Update(UpdateCourseCategoryRequest updateCourseCategoryRequest)
        {
            CourseCategory CourseCategory = _mapper.Map<CourseCategory>(updateCourseCategoryRequest);
            var updatedCourseCategory = await _courseCategoryDal.UpdateAsync(CourseCategory);
            UpdatedCourseCategoryResponse result = _mapper.Map<UpdatedCourseCategoryResponse>(updatedCourseCategory);
            return result;
        }
    }
}
