using System;
using System.Collections.Generic;

namespace Eagle.Api.Models;

public partial class SystemUser
{
    public int Id { get; set; }

    public string? Guid { get; set; }

    public string? SystemUserName { get; set; }

    public string? SystemUserCode { get; set; }

    public string? FullName { get; set; }

    public string? Password { get; set; }

    public string? RoleGuid { get; set; }

    public string? RoleCode { get; set; }

    public string? DepartmentGuid { get; set; }

    public string? DepartmentCode { get; set; }

    public string? CreatedDate { get; set; }

    public string? CreatedBy { get; set; }

    public string? UpDatedDate { get; set; }

    public string? UpDatedBy { get; set; }

    public int? Status { get; set; }

    public string? SystemUserType { get; set; }

    public string? StartTime { get; set; }

    public string? EndTime { get; set; }

    public bool? IsActive { get; set; }

    public string? Theme { get; set; }

    public string? BranchGuid { get; set; }
}
