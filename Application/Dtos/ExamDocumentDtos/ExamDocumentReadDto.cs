﻿using Domain.Entities;

namespace Application.Dtos.ExamDocumentDtos;

public class ExamDocumentReadDto
{
    public Guid Id { get; set; }
    public Guid PatientId { get; set; }
    public string ExamName { get; set; }
    public string ExamType { get; set; }
    public DateTime ExamDate { get; set; }
    public string FilePath { get; set; }
    public Patient Patient { get; set; }
}
