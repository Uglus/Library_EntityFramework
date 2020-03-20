CREATE TRIGGER DelGenres
	ON Genres
	instead of delete
	AS
	BEGIN
		declare @Gid int
		Select @Gid = Id from deleted

		Delete j from Journal j
		join Books b on j.BookId=b.Id
		where b.GenreId = @Gid

		Delete ba 
		from BooksAuthors ba
		join Books b on ba.BookId = b.Id
		where b.GenreId = @Gid
		Delete from Books where GenreId = @Gid
		Delete from Genres where Id = @Gid
	END