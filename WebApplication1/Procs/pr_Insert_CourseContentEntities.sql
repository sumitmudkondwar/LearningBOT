alter proc pr_Insert_CourseContentEntities
(
	@p_ModuleId nvarchar(max), 
	@p_Name nvarchar(max),
	@p_Duration nvarchar(max),
	@p_Uri nvarchar(max),
	@p_Order int,
	@p_Style int
)
as 
begin
	
	insert into CourseContentEntities([CourseContentEntityId],[ModuleId],[Name],[Duration],[Uri],[Order],[Style]) 
	values(newid(),@p_ModuleId,@p_Name,@p_Duration,@p_Uri,@p_Order,@p_Style)

end

go


--pr_Insert_CourseContentEntities 'CF73F01F-C5F0-46EA-96AC-0BC798B15033', 

