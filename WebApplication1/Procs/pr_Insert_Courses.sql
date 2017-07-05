alter proc pr_Insert_Courses
(
	@p_SubjectId nvarchar(max),
	@p_Source int,
	@p_CourseName nvarchar(max),
	@p_Description nvarchar(max),
	@p_Abstract nvarchar(max),
	@p_CourseAudience int,
	@p_courseDuration nvarchar(max),
	@p_Level int,
	@p_Rating int,
	@p_RatingCount int,
	@p_Author nvarchar(max),
	@p_CourseDate datetime
)
as 
begin
	
	insert into Courses([CourseId],[SubjectId],[Source],[CourseName],[Description],[Abstract],[CourseAudience],[courseDuration],[Level],[Rating],[RatingCount],[Author],[CourseDate]) 
	values(newid(), @p_SubjectId, @p_Source,@p_CourseName,@p_Description,@p_Abstract,@p_CourseAudience,@p_courseDuration,@p_Level,@p_Rating,@p_RatingCount,@p_Author,@p_CourseDate)

end

go


--pr_Insert_Courses 'CF73F01F-C5F0-46EA-96AC-0BC798B15033', 1,'test','test','test',1,'00:00:01',1,1,1,'sumit','1/1/2016'







