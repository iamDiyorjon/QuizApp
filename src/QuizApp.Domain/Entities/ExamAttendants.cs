﻿namespace QuizApp.Domain.Entities;

public class ExamAttendants
{
    public Guid Id { get; set; }
    public Guid ExamId { get; set; }
    public string Name { get; set; }
    public string Token { get; set; }
    public float Score { get; set; }
    public Exam Exam { get; set; }
}
