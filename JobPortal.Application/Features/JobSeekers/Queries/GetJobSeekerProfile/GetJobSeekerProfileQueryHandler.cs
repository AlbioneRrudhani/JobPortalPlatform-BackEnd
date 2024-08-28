using AutoMapper;
using JobPortal.Application.Contracts.Infrastructure;
using JobPortal.Application.Contracts.Persistence;
using JobPortal.Application.Features.JobSeeker.Dtos;
using MediatR;

namespace JobPortal.Application.Features.JobSeeker.Queries.GetJobSeekerDetail
{
    public class GetEmployerProfileQueryHandler : IRequestHandler<GetJobEmployerProfileQuery, JobSeekerDto>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IClaimsPrincipalAccessor _claimsPrincipalAccessor;
        private readonly IMapper _mapper;

        public GetEmployerProfileQueryHandler(IUnitOfWork unitOfWork, IClaimsPrincipalAccessor claimsPrincipalAccessor, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _claimsPrincipalAccessor = claimsPrincipalAccessor;
            _mapper = mapper;
        }

        public async Task<JobSeekerDto> Handle(GetJobEmployerProfileQuery request, CancellationToken cancellationToken)
        {

            var jobSeekerToReturn = await _claimsPrincipalAccessor.GetCurrentJobSeekerAsync();

            var userDto = _mapper.Map<JobSeekerDto>(jobSeekerToReturn);
            return userDto;

        }

    }
}
