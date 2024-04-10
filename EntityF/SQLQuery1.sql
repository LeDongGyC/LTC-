create database ef;
use ef;

CREATE TABLE Department (
    DepartmentId INT PRIMARY KEY IDENTITY(1,1),
    Name NVARCHAR(50)
);

CREATE TABLE Student (
    StudentId INT PRIMARY KEY IDENTITY(1,1),
    Name NVARCHAR(50),
    Age INT,
    DepartmentId INT,  -- Thêm cột DepartmentId để lưu khóa ngoại
    FOREIGN KEY (DepartmentId) REFERENCES Department(DepartmentId)  -- Khóa ngoại tham chiếu đến bảng Department
);

INSERT INTO Department (Name) VALUES ('CNTT');
INSERT INTO Department (Name) VALUES ('Marketing');
INSERT INTO Department (Name) VALUES ('Y dược');
INSERT INTO Department (Name) VALUES ('Điện');

INSERT INTO Student (Name, Age, DepartmentId) VALUES ('Nguyễn Văn Bình', 18, 1);
INSERT INTO Student (Name, Age, DepartmentId) VALUES ('Lê Xuân Đan', 19, 2);
INSERT INTO Student (Name, Age, DepartmentId) VALUES ('Võ Văn Tấn', 20, 3);
INSERT INTO Student (Name, Age, DepartmentId) VALUES ('Nguyễn Thu Thủy', 21, 4);
