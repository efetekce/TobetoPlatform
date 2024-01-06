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
    public class SubLectureManager : ISubLectureService
    {
        ISubLectureDal _subLectureDal;
        IMapper _mapper;

        public SubLectureManager(ISubLectureDal subLectureDal,
        IMapper mapper)
        {
            _subLectureDal= subLectureDal;
            _mapper= mapper;
        }

        public async Task<CreatedSubLectureResponse> Add(CreateSubLectureRequest createSubLectureRequest)
        {
            SubLecture subLecture = _mapper.Map<SubLecture>(createSubLectureRequest);
            var createdSubLecture = await _subLectureDal.AddAsync(subLecture);
            CreatedSubLectureResponse result = _mapper.Map<CreatedSubLectureResponse>(createdSubLecture);
            return result;
        }

        public async Task<DeletedSubLectureResponse> Delete(DeleteSubLectureRequest deleteSubLectureRequest)
        {
            SubLecture subLecture = _mapper.Map<SubLecture>(deleteSubLectureRequest);
            var deletedSubLecture = await _subLectureDal.DeleteAsync(subLecture);
            DeletedSubLectureResponse result = _mapper.Map<DeletedSubLectureResponse>(deletedSubLecture);
            return result;
        }

        public async Task<IPaginate<GetListSubLectureResponse>> GetListSubLecture(PageRequest pageRequest)
        {
            var subLecture = await _subLectureDal.GetListAsync(
                orderBy: s => s.OrderBy(s => s.LectureId),
                index: pageRequest.PageIndex,
                size: pageRequest.PageSize);
            var result = _mapper.Map<Paginate<GetListSubLectureResponse>>(subLecture);
            return result;
        }

        public async Task<UpdatedSubLectureResponse> Update(UpdateSubLectureRequest updateSubLectureRequest)
        {
            SubLecture subLecture = _mapper.Map<SubLecture>(updateSubLectureRequest);
            var updatedSubLecture = await _subLectureDal.UpdateAsync(subLecture);
            UpdatedSubLectureResponse result = _mapper.Map<UpdatedSubLectureResponse>(updatedSubLecture);
            return result;
        }
    }
}
