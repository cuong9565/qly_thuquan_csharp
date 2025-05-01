drop database if exists qlthuquan;
create database qlthuquan;
use qlthuquan;

create table thanh_vien(
	id varchar(100) primary key,
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
INSERT INTO thanh_vien (id, lName, fName, dateCreate, email, phone) VALUES
('01234567', 'Nguyễn Văn', 'Hùng', '2023-07-15', 'hung.nguyen@gmail.com', '0901234567'),
('12345678', 'Trần Thị', 'Mai', '2021-03-22', 'mai.tran@yahoo.com', '0912345678'),
('23456789', 'Lê Hoàng', 'Nam', '2024-01-10', 'nam.le@outlook.com', '0923456789'),
('34567890', 'Phạm Ngọc', 'Lan', '2020-11-05', 'lan.pham@gmail.com', '0934567890'),
('45678901', 'Hoàng Minh', 'Đức', '2022-09-18', 'duc.hoang@yahoo.com', '0945678901'),
('56789012', 'Vũ Thị', 'Hương', '2023-12-30', 'huong.vu@outlook.com', '0956789012'),
('67890123', 'Đặng Văn', 'Tùng', '2021-06-25', 'tung.dang@gmail.com', '0967890123'),
('78901234', 'Bùi Thị', 'Thảo', '2024-04-12', 'thao.bui@yahoo.com', '0978901234'),
('89012345', 'Ngô Hoàng', 'Phong', '2022-02-08', 'phong.ngo@outlook.com', '0989012345'),
('90123456', 'Đỗ Văn', 'Hải', '2020-08-14', 'hai.do@gmail.com', '0990123456'),
('10234567', 'Trương Thị', 'Yến', '2023-10-03', 'yen.truong@yahoo.com', '0902345678'),
('21345678', 'Lý Văn', 'Long', '2021-12-17', 'long.ly@outlook.com', '0913456789'),
('32456789', 'Mai Thị', 'Hoa', '2024-06-20', 'hoa.mai@gmail.com', '0924567890'),
('43567890', 'Nguyễn Hoàng', 'Việt', '2022-04-29', 'viet.nguyen@yahoo.com', '0935678901'),
('54678901', 'Trần Văn', 'Dũng', '2020-10-11', 'dung.tran@outlook.com', '0946789012'),
('65789012', 'Lê Thị', 'Linh', '2023-03-07', 'linh.le@gmail.com', '0957890123'),
('76890123', 'Phạm Văn', 'Tâm', '2021-09-23', 'tam.pham@yahoo.com', '0968901234'),
('87901234', 'Hoàng Thị', 'Ngọc', '2024-02-14', 'ngoc.hoang@outlook.com', '0979012345'),
('98012345', 'Vũ Văn', 'Kiên', '2022-07-01', 'kien.vu@gmail.com', '0980123456'),
('09123456', 'Đặng Thị', 'Hạnh', '2020-12-28', 'hanh.dang@yahoo.com', '0991234567'),
('19234567', 'Bùi Văn', 'Quang', '2023-05-19', 'quang.bui@outlook.com', '0903456789'),
('29345678', 'Ngô Thị', 'Thư', '2021-04-04', 'thu.ngo@gmail.com', '0914567890'),
('39456789', 'Đỗ Hoàng', 'Bình', '2024-08-09', 'binh.do@yahoo.com', '0925678901'),
('49567890', 'Trương Văn', 'Hòa', '2022-11-26', 'hoa.truong@outlook.com', '0936789012'),
('59678901', 'Lý Thị', 'Phương', '2020-07-13', 'phuong.ly@gmail.com', '0947890123'),
('69789012', 'Mai Văn', 'Thắng', '2023-01-31', 'thang.mai@yahoo.com', '0958901234'),
('79890123', 'Nguyễn Thị', 'Oanh', '2021-08-06', 'oanh.nguyen@outlook.com', '0969012345'),
('89901234', 'Trần Hoàng', 'Ân', '2024-03-25', 'an.tran@gmail.com', '0970123456'),
('90012345', 'Lê Văn', 'Khôi', '2022-06-12', 'khoi.le@yahoo.com', '0981234567'),
('01123456', 'Phạm Thị', 'Nhi', '2020-09-08', 'nhi.pham@outlook.com', '0992345678');


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

