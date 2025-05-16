namespace NashtechPractical.AssetManagement.WebAPI.Application.Exceptions;

public class AssignmentNotFoundException : Exception
{
    public AssignmentNotFoundException(int assignmentId) : base($"Assignment {assignmentId} was Not Found")
    {
    }
}