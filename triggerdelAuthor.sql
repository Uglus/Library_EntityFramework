create trigger DelAuthor
on Authors
instead of delete
as
begin
Declare @Id int

Select @Id from deleted

Delete from BooksAuthors where AuthorId = @Id
Delete from Authors where Id = @Id

end