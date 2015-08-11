﻿namespace Academetrics.Data.Enums
{
	/// <summary>
	/// these will be dynamic objects when we need to expand on them
	/// </summary>
	public enum ClaimType
	{
		Undefined = 0,
		IsAdmin = 1,
		CanRead = 5,
		CanWrite = 10, 
		CanInsert = 11,
		CanInsertUser = 12,
		CanUpdate = 15,
		CanUpdateUser = 16,
		CanDelete = 20,
		CanDeleteUser = 21,
		CanEditTimeTable = 25,
		CanEditHomework = 26,
		IsPrincipal = 30,
		IsInstitutionAdmin = 35
	}
}