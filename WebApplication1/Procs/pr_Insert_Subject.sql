create proc pr_Insert_Subject
(
	@p_SubjectName nvarchar(max),
	@p_SubjectDescription nvarchar(max)
)
as 
begin
	insert into Subjects([SubjectId],[Name],[Description]) values(newid(), @p_SubjectName, @p_SubjectDescription)
end

go

--pr_Insert_Subject 'test', 'test'

