using MediatR;

namespace Settings.Application.Features.Roles.Commands.DeleteRole
{
    public class DeleteRoleCommand : IRequest
    {
        public Guid Id { get; set; }
        public string Code { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public Guid CompanyId { get; set; }
        public Guid DepartmentId { get; set; }
        public int DesignationId { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.UtcNow;
        public DateTime? UpdatedDate { get; set; }
        public bool IsActive { get; set; } = true;
    }
}





