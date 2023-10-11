CREATE TABLE
    Blog.Post (
        Post_ID INT NOT NULL IDENTITY (1, 1),
        Post_Subject NVARCHAR (60) NOT NULL,
        Post_Body NVARCHAR (MAX) NOT NULL CONSTRAINT DF_Blog_Post_Post_Body DEFAULT '',
        Posted_Date DATETIMEOFFSET NOT NULL CONSTRAINT DF_Blog_Post_Posted_Date DEFAULT GETUTCDATE (),
        CONSTRAINT PK_Blog_Post PRIMARY KEY (Post_ID)
    );