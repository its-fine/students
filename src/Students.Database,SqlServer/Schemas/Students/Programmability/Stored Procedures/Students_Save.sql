CREATE PROCEDURE [Students].[Students_Save]
(
    @Id int,
    @FirstName nvarchar(100),
    @LastName nvarchar(100),
    @ReturnId int output
)
AS

    INSERT INTO
        [Students].[Students]
        (
            [FirstName],
            [LastName]
        )
        VALUES
        (
            @FirstName,
            @LastName
        )

    SET @ReturnId = SCOPE_IDENTITY()