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
    public class CourseContentManager : ICourseContentService
    {

        ICourseContentDal _courseContentDal;
        IMapper _mapper;
        public CourseContentManager(ICourseContentDal courseContentDal, IMapper mapper)
        {
            _courseContentDal = courseContentDal;
            _mapper = mapper;
        }

        public async Task<CreatedCourseContentResponse> Add(CreateCourseContentRequest createCourseContentRequest)
        {
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
            var courseContent = await _courseContentDal.GetListAsync();
            var result = _mapper.Map<Paginate<GetListCourseContentResponse>>(courseContent);
            return result;
        }

        public async Task<UpdatedCourseContentResponse> Update(UpdateCourseContentRequest updateCourseContentRequest)
        {
            CourseContent courseContent = _mapper.Map<CourseContent>(updateCourseContentRequest);
            var updatedCourseContent = await _courseContentDal.UpdateAsync(courseContent);
            UpdatedCourseContentResponse result = _mapper.Map<UpdatedCourseContentResponse>(updatedCourseContent);
            return result;
        }
    }
}
