﻿using Domain.Entities;

namespace Application.Dtos.MedicalSpecialtyDtos;

public class MedicalSpecialtyReadDto
{
    public Guid Id { get; set; }
    public string FullName { get; set; }
    public Guid MedicalSpecialtyId { get; set; }
    public MedicalSpecialty Specialty { get; set; }
}
