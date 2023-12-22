using AutoMapper;
using Business.Abstract;
using Business.Dtos.Request;
using Business.Dtos.Response;
using Core.DataAccess.Paging;
using DataAccess.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CourseContentTypeManager :ICourseContentTypeService
    {

        ICourseContentTypeDal _courseContentTypeDal;
        IMapper _mapper;
        public CourseContentTypeManager(ICourseContentTypeDal courseContentTypeDal, IMapper mapper)
        {
            _courseContentTypeDal = courseContentTypeDal;
            _mapper = mapper;
        }

        public async Task<CreatedCourseContentTypeResponse> Add(CreateCourseContentTypeRequest createCourseContentTypeRequest)
        {
            CourseContentType courseContentType = _mapper.Map<CourseContentType>(createCourseContentTypeRequest);
            var createdCourseContentType = await _courseContentTypeDal.AddAsync(courseContentType);
            CreatedCourseContentTypeResponse result = _mapper.Map<CreatedCourseContentTypeResponse>(createdCourseContentType);
            return result;
        }

        public async Task<DeletedCourseContentTypeResponse> Delete(DeleteCourseContentTypeRequest deleteCourseContentTypeRequest)
        {
            CourseContentType courseContentType = _mapper.Map<CourseContentType>(deleteCourseContentTypeRequest);
            var deletedCourseContentType = await _courseContentTypeDal.DeleteAsync(courseContentType, false);
            DeletedCourseContentTypeResponse result = _mapper.Map<DeletedCourseContentTypeResponse>(deletedCourseContentType);
            return result;
        }

        public async Task<IPaginate<GetListCourseContentTypeResponse>> GetListCourseContentType(PageRequest pageRequest)
        {
            var courseContentType = await _courseContentTypeDal.GetListAsync();
            var result = _mapper.Map<Paginate<GetListCourseContentTypeResponse>>(courseContentType);
            return result;
        }

        public async Task<UpdatedCourseContentTypeResponse> Update(UpdateCourseContentTypeRequest updateCourseContentTypeRequest)
        {
            CourseContentType courseContentType = _mapper.Map<CourseContentType>(updateCourseContentTypeRequest);
            var updatedCourseContentType = await _courseContentTypeDal.UpdateAsync(courseContentType);
            UpdatedCourseContentTypeResponse result = _mapper.Map<UpdatedCourseContentTypeResponse>(updatedCourseContentType);
            return result;
        }
    }
}
