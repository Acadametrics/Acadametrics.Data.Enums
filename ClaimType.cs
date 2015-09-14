namespace Academetrics.Data.Enums
{
	/// <summary>
	/// these will be dynamic objects when we need to expand on them
	/// </summary>
	public enum ClaimType
	{
		Undefined = 0,
		IsSystemAdmin = 1,
    // To simplify the authR structure, only use 'is a' claims.  What those claims mean is set at logic branch.
		//CanRead = 5,
		//CanWrite = 10, 
		//CanInsert = 11,
		//CanInsertUser = 12,
		//CanUpdate = 15,
		//CanUpdateUser = 16,
		//CanDelete = 20,
		//CanDeleteUser = 21,
		//CanEditTimeTable = 25,
		//CanEditHomework = 26,
		IsPrincipal = 30,
		IsInstitutionAdmin = 35,
    IsTeacher = 40,
    IsParent = 45,
    IsStudent = 50,
    IsInstitutionMember = 55
	}
}
