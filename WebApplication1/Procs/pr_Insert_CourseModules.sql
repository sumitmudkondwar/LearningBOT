alter proc pr_Insert_CourseModules
(
	@p_ModuleName nvarchar(max),
	@p_Description nvarchar(max),
	@p_Abstract nvarchar(max),
	@p_Details nvarchar(max),
	@p_CourseId nvarchar(max),
	@p_Level int,
	@p_Style int,
	@p_Duration time,
	@p_LastUpdated datetime,
	@p_Order int
)
as 
begin
	
	insert into CourseModules([ModuleId],[ModuleName],[Description],[Abstract],[Details],[CourseId],[Level],[Style],[Duration],[LastUpdated],[Order]) 
	values(newid(), @p_ModuleName, @p_Description,@p_Abstract,@p_Details,@p_CourseId,@p_Level,@p_Style,@p_Duration,@p_LastUpdated,@p_Order)

end

go


--pr_Insert_CourseModules 'asdf', 'aasdasd','asdadt','adad','7445F6E3-E2B0-41C6-9754-FF5741674151',1,1,'00:00:01','1/1/2016',2


