﻿namespace JobPortal.Application.Features.JobSeeker.Dtos
{
    public class JobSeekerRegistrationDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Password { get; set; }
    }
}
