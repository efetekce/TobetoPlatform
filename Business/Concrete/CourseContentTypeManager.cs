﻿using AutoMapper;
using Business.Abstract;
using Business.Dtos.Request;
using Business.Dtos.Response;
using Business.Rules;
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
        CourseContentTypeBusinessRules _courseContentTypeBusinessRules;
        public CourseContentTypeManager(ICourseContentTypeDal courseContentTypeDal, IMapper mapper, CourseContentTypeBusinessRules courseContentTypeBusinessRules)
        {
            _courseContentTypeDal = courseContentTypeDal;
            _mapper = mapper;
            _courseContentTypeBusinessRules = courseContentTypeBusinessRules;
        }

        public async Task<CreatedCourseContentTypeResponse> Add(CreateCourseContentTypeRequest createCourseContentTypeRequest)
        {
            await _courseContentTypeBusinessRules.ContentTypeNameCantBeNull(createCourseContentTypeRequest.Name);

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

        public async Task<IPaginate<GetListCourseContentTypeResponse>> GetListCourseContentType()
        {
            var courseContentType = await _courseContentTypeDal.GetListAsync();
            var result = _mapper.Map<Paginate<GetListCourseContentTypeResponse>>(courseContentType);
            return result;
        }

        public async Task<UpdatedCourseContentTypeResponse> Update(UpdateCourseContentTypeRequest updateCourseContentTypeRequest)
        {
            await _courseContentTypeBusinessRules.ContentTypeNameCantBeNull(updateCourseContentTypeRequest.Name);

            CourseContentType courseContentType = _mapper.Map<CourseContentType>(updateCourseContentTypeRequest);
            var updatedCourseContentType = await _courseContentTypeDal.UpdateAsync(courseContentType);
            UpdatedCourseContentTypeResponse result = _mapper.Map<UpdatedCourseContentTypeResponse>(updatedCourseContentType);
            return result;
        }
    }
}
