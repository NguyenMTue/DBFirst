CREATE DATABASE StudentDB;
GO

USE StudentDB;
GO

CREATE TABLE Students (
    Id INT PRIMARY KEY IDENTITY(1,1),
    FullName NVARCHAR(100) NOT NULL,
    Age INT,
    Email NVARCHAR(100)
);

-- Chèn dữ liệu mẫu
INSERT INTO Students (FullName, Age, Email) VALUES 
(N'Nguyen Van A', 20, 'a.nguyen@example.com'),
(N'Tran Thi B', 22, 'b.tran@example.com');
GO