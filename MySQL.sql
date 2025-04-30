drop database if exists qlthuquan;
create database qlthuquan;
use qlthuquan;

create table thanh_vien(
	id int auto_increment primary key,
	lName varchar(100) character set utf8mb4,
	fName varchar(100) character set utf8mb4,
    dateCreate date default (current_date()),
	email varchar(100) character set utf8mb4,
	phone varchar(100) character set utf8mb4,
	password varchar(100) character set utf8mb4 default ''
);

create table thiet_bi(
	id int auto_increment primary key,
	name varchar(100) character set utf8mb4,
	state varchar(100) character set utf8mb4 default 'Sẵn sàng' -- Sẵn sàng, Đang mượn, Hỏng
);

-- INSERT
INSERT INTO thanh_vien (fName, lName, dateCreate, email, phone, password) VALUES
('Hữu', 'Nguyễn', '2023-05-12', 'huu.nguyen@gmail.com', '0912345678', ''),
('Thị Mai', 'Trần', '2021-08-23', 'mai.tran@yahoo.com', '0987654321', ''),
('Văn', 'Lê', '2024-01-15', 'van.le@outlook.com', '0901234567', ''),
('Thị Lan', 'Phạm', '2022-11-30', 'lan.pham@gmail.com', '0932143657', ''),
('Quốc', 'Hoàng', '2020-12-05', 'quoc.hoang@icloud.com', '0978456123', ''),
('Thị Hương', 'Vũ', '2023-09-17', 'huong.vu@gmail.com', '0945678912', ''),
('Minh', 'Đặng', '2021-03-22', 'minh.dang@yahoo.com', '0923456789', ''),
('Thị Ngọc', 'Bùi', '2024-06-10', 'ngoc.bui@outlook.com', '0967891234', ''),
('Hùng', 'Đoàn', '2022-07-19', 'hung.doan@gmail.com', '0956782345', ''),
('Thị Hồng', 'Ngô', '2023-02-28', 'hong.ngo@yahoo.com', '0918765432', ''),
('Anh', 'Đỗ', '2021-10-14', 'anh.do@icloud.com', '0981234567', ''),
('Thị Linh', 'Hà', '2024-03-05', 'linh.ha@gmail.com', '0902345678', ''),
('Tuấn', 'Lương', '2020-06-25', 'tuan.luong@outlook.com', '0933456789', ''),
('Thị Thảo', 'Phan', '2022-12-01', 'thao.phan@yahoo.com', '0974567891', ''),
('Nam', 'Trương', '2023-11-11', 'nam.truong@gmail.com', '0945671234', ''),
('Thị Hà', 'Lý', '2021-04-30', 'ha.ly@icloud.com', '0926789012', ''),
('Đức', 'Mai', '2024-08-22', 'duc.mai@gmail.com', '0967892345', ''),
('Thị Trang', 'Đào', '2022-09-15', 'trang.dao@yahoo.com', '0912346789', ''),
('Long', 'Vương', '2023-07-03', 'long.vuong@outlook.com', '0983456789', ''),
('Thị Duyên', 'Tô', '2020-11-20', 'duyen.to@gmail.com', '0904567891', ''),
('Bình', 'Hồ', '2021-12-10', 'binh.ho@yahoo.com', '0935678901', ''),
('Thị Ánh', 'Dương', '2024-02-14', 'anh.duong@icloud.com', '0976789012', ''),
('Kiên', 'Cao', '2022-05-27', 'kien.cao@gmail.com', '0947890123', ''),
('Thị Hoa', 'Đinh', '2023-10-08', 'hoa.dinh@outlook.com', '0928901234', ''),
('Phong', 'Bùi', '2021-01-19', 'phong.bui@yahoo.com', '0969012345', ''),
('Thị Oanh', 'Trịnh', '2024-04-25', 'oanh.trinh@gmail.com', '0910123456', ''),
('Hải', 'Lâm', '2022-06-13', 'hai.lam@icloud.com', '0989012345', ''),
('Thị Yến', 'Khổng', '2023-03-07', 'yen.khong@yahoo.com', '0907890123', ''),
('Tâm', 'Tăng', '2020-09-29', 'tam.tang@outlook.com', '0939012345', ''),
('Thị Nhung', 'Hứa', '2021-07-16', 'nhung.hua@gmail.com', '0970123456', '');

INSERT INTO thiet_bi(name)
VALUES 
    ('Máy 1'),
    ('Máy 2'),
    ('Máy 3'),
    ('Máy 4'),
    ('Máy 5'),
    ('Máy 6'),
    ('Máy 7'),
    ('Máy 8'),
    ('Máy 9'),
    ('Máy 10');

select *
from thanh_vien
where year(dateCreate) = 2021