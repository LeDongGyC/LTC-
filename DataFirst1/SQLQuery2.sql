CREATE TABLE CongTy (
    Id INT PRIMARY KEY,
    CompanyName VARCHAR(255)
);
CREATE TABLE PhongBan (
    Id INT PRIMARY KEY,
    Name VARCHAR(255),
    CongTy_Id INT,
    FOREIGN KEY (CongTy_Id) REFERENCES CongTy(Id)
);
CREATE TABLE NhanVien (
    Id INT PRIMARY KEY,
    FullName VARCHAR(255),
    Age INT,
    PhongBan_Id INT,
    Gender int,
    FOREIGN KEY (PhongBan_Id) REFERENCES PhongBan(Id)
);
INSERT INTO CongTy (Id, CompanyName)
VALUES (1, 'Công ty A'),
       (2, 'Công ty B');
INSERT INTO PhongBan (Id, Name, CongTy_Id)
VALUES (1, 'IT', 1),
       (2, 'Marketing', 1),
       (3, 'Sale', 2);
INSERT INTO NhanVien (Id, FullName, Age, PhongBan_Id, Gender)
VALUES (1, 'Nguyễn Văn A', 33, 2, 1),
       (2, 'Trần Thị B', 25, 1, 0),
       (3, 'Lê Văn C', 35, 2, 1),
       (4, 'Phạm Thị D', 28, 2, 0),
       (5, 'Hoàng Văn E', 40, 3, 1),
       (6, 'Nguyễn Thị F', 32, 3, 0);
