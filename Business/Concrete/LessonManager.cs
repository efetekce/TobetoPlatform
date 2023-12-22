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
    public class LessonManager : ILessonService
    {

        ILessonDal _lessonDal;
        IMapper _mapper;
        public LessonManager(ILessonDal lessonDal, IMapper mapper)
        {
            _lessonDal = lessonDal;
            _mapper = mapper;
        }

        public async Task<CreatedLessonResponse> Add(CreateLessonRequest createLessonRequest)
        {
            Lesson lesson = _mapper.Map<Lesson>(createLessonRequest);
            var createdLesson = await _lessonDal.AddAsync(lesson);
            CreatedLessonResponse result = _mapper.Map<CreatedLessonResponse>(createdLesson);
            return result;
        }

        public async Task<DeletedLessonResponse> Delete(DeleteLessonRequest deleteLessonRequest)
        {
            Lesson lesson = _mapper.Map<Lesson>(deleteLessonRequest);
            var deletedLesson = await _lessonDal.DeleteAsync(lesson, false);
            DeletedLessonResponse result = _mapper.Map<DeletedLessonResponse>(deletedLesson);
            return result;
        }

        public async Task<IPaginate<GetListLessonResponse>> GetListLesson(PageRequest pageRequest)
        {
            var Lesson = await _lessonDal.GetListAsync();
            var result = _mapper.Map<Paginate<GetListLessonResponse>>(Lesson);
            return result;
        }

        public async Task<UpdatedLessonResponse> Update(UpdateLessonRequest updateLessonRequest)
        {
            Lesson Lesson = _mapper.Map<Lesson>(updateLessonRequest);
            var updatedLesson = await _lessonDal.UpdateAsync(Lesson);
            UpdatedLessonResponse result = _mapper.Map<UpdatedLessonResponse>(updatedLesson);
            return result;
        }
    }
}
