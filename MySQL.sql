drop database if exists qlthuquan;
create database qlthuquan;
use qlthuquan;

create table thanh_vien(
	id varchar(100) character set utf8mb4 primary key,
	lName varchar(100) character set utf8mb4,
	fName varchar(100) character set utf8mb4,
    dateCreate date default (current_date()),
	email varchar(100) character set utf8mb4,
	phone varchar(100) character set utf8mb4,
	password varchar(100) character set utf8mb4 default ''
);

create table thiet_bi(
	id varchar(100) character set utf8mb4 primary key,
	name varchar(100) character set utf8mb4,
	state varchar(100) character set utf8mb4 default 'Sẵn sàng' -- Sẵn sàng, Đang mượn, Hỏng
);

create table vao_tq(
	id int auto_increment primary key,
    idTV varchar(100) character set utf8mb4 not null,
    time_in datetime not null,
    
    foreign key (idTV) references thanh_vien(id)
);

create table muon_tra_tb(
	id int auto_increment primary key,
    idTV varchar(100) character set utf8mb4 not null,
    idTB varchar(100) character set utf8mb4 not null,
    time_book datetime not null,
    time_borrow datetime,
    time_return datetime,
    state varchar(100) character set utf8mb4 default 'Đang đặt chỗ', -- Đang đặt chỗ, Đang mượn, Đã trả, Đã hủy
    
	foreign key (idTV) references thanh_vien(id),
	foreign key (idTB) references thiet_bi(id)
);

create table vi_pham(
	id int auto_increment primary key,
    idTV varchar(100) character set utf8mb4 not null,
	name varchar(100) character set utf8mb4 not null,
	price double default 0,
    state varchar(100) character set utf8mb4 default 'Chưa xử lý', -- Chưa xử lý, Đã xử lý
    
	foreign key (idTV) references thanh_vien(id)
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

INSERT INTO thiet_bi(id, name) values
('MT_001', 'Máy tính 1'),
('MT_002', 'Máy tính 2'),
('MT_003', 'Máy tính 3'),
('MT_004', 'Máy tính 4'),
('MT_005', 'Máy tính 5'),
('MT_006', 'Máy tính 6'),
('MT_007', 'Máy tính 7'),
('MT_008', 'Máy tính 8'),
('MT_009', 'Máy tính 9'),
('MT_010', 'Máy tính 10'),
('MI_001', 'Máy in 1'),
('MI_002', 'Máy in 2'),
('MI_003', 'Máy in 3'),
('MI_004', 'Máy in 4'),
('MI_005', 'Máy in 5'),
('MC_001', 'Máy chiếu 1'),
('MC_002', 'Máy chiếu 2'),
('MC_003', 'Máy chiếu 3'),
('MC_004', 'Máy chiếu 4'),
('MC_005', 'Máy chiếu 5');

INSERT INTO vao_tq (idTV, time_in) VALUES
('01234567', '2025-04-27 08:05:22'),
('23456789', '2025-04-27 13:40:17'),
('45678901', '2025-04-28 07:25:49'),
('67890123', '2025-04-28 10:15:33'),
('89012345', '2025-04-28 15:50:41'),
('10234567', '2025-04-29 06:45:28'),
('32456789', '2025-04-29 09:30:55'),
('54678901', '2025-04-29 14:20:12'),
('76890123', '2025-04-30 08:10:46'),
('98012345', '2025-04-30 11:55:34'),
('19234567', '2025-04-30 16:30:27'),
('39456789', '2025-05-01 07:35:19'),
('59678901', '2025-05-01 10:45:52'),
('79890123', '2025-05-01 13:25:38'),
('90012345', '2025-05-02 06:50:44'),
('12345678', '2025-05-02 09:15:31'),
('34567890', '2025-05-02 12:40:16'),
('56789012', '2025-05-03 07:20:53'),
('78901234', '2025-05-03 08:55:29'),
('01123456', '2025-05-03 10:30:47');

select * from vao_tq;