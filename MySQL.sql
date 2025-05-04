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
    dateCreate date default (current_date()),
    state varchar(100) character set utf8mb4 default 'Chưa xử lý', -- Chưa xử lý, Đã xử lý
    
	foreign key (idTV) references thanh_vien(id)
);

-- INSERT
INSERT INTO thanh_vien (id, lName, fName, dateCreate, email, phone) VALUES
('0012345678', 'Nguyễn Văn', 'Hùng', '2023-07-15', 'hung.nguyen@gmail.com', '0901234567'),
('0123456789', 'Trần Thị', 'Mai', '2021-03-22', 'mai.tran@yahoo.com', '0912345678'),
('0234567890', 'Lê Hoàng', 'Nam', '2024-01-10', 'nam.le@outlook.com', '0923456789'),
('0345678901', 'Phạm Ngọc', 'Lan', '2020-11-05', 'lan.pham@gmail.com', '0934567890'),
('0456789012', 'Hoàng Minh', 'Đức', '2022-09-18', 'duc.hoang@yahoo.com', '0945678901'),
('0567890123', 'Vũ Thị', 'Hương', '2023-12-30', 'huong.vu@outlook.com', '0956789012'),
('0678901234', 'Đặng Văn', 'Tùng', '2021-06-25', 'tung.dang@gmail.com', '0967890123'),
('0789012345', 'Bùi Thị', 'Thảo', '2024-04-12', 'thao.bui@yahoo.com', '0978901234'),
('0890123456', 'Ngô Hoàng', 'Phong', '2022-02-08', 'phong.ngo@outlook.com', '0989012345'),
('0901234567', 'Đỗ Văn', 'Hải', '2020-08-14', 'hai.do@gmail.com', '0990123456'),
('0102345678', 'Trương Thị', 'Yến', '2023-10-03', 'yen.truong@yahoo.com', '0902345678'),
('0213456789', 'Lý Văn', 'Long', '2021-12-17', 'long.ly@outlook.com', '0913456789'),
('0324567890', 'Mai Thị', 'Hoa', '2024-06-20', 'hoa.mai@gmail.com', '0924567890'),
('0435678901', 'Nguyễn Hoàng', 'Việt', '2022-04-29', 'viet.nguyen@yahoo.com', '0935678901'),
('0546789012', 'Trần Văn', 'Dũng', '2020-10-11', 'dung.tran@outlook.com', '0946789012'),
('0657890123', 'Lê Thị', 'Linh', '2023-03-07', 'linh.le@gmail.com', '0957890123'),
('0768901234', 'Phạm Văn', 'Tâm', '2021-09-23', 'tam.pham@yahoo.com', '0968901234'),
('0879012345', 'Hoàng Thị', 'Ngọc', '2024-02-14', 'ngoc.hoang@outlook.com', '0979012345'),
('0980123456', 'Vũ Văn', 'Kiên', '2022-07-01', 'kien.vu@gmail.com', '0980123456'),
('0091234567', 'Đặng Thị', 'Hạnh', '2020-12-28', 'hanh.dang@yahoo.com', '0991234567'),
('0192345678', 'Bùi Văn', 'Quang', '2023-05-19', 'quang.bui@outlook.com', '0903456789'),
('0293456789', 'Ngô Thị', 'Thư', '2021-04-04', 'thu.ngo@gmail.com', '0914567890'),
('0394567890', 'Đỗ Hoàng', 'Bình', '2024-08-09', 'binh.do@yahoo.com', '0925678901'),
('0495678901', 'Trương Văn', 'Hòa', '2022-11-26', 'hoa.truong@outlook.com', '0936789012'),
('0596789012', 'Lý Thị', 'Phương', '2020-07-13', 'phuong.ly@gmail.com', '0947890123'),
('0697890123', 'Mai Văn', 'Thắng', '2023-01-31', 'thang.mai@yahoo.com', '0958901234'),
('0798901234', 'Nguyễn Thị', 'Oanh', '2021-08-06', 'oanh.nguyen@outlook.com', '0969012345'),
('0899012345', 'Trần Hoàng', 'Ân', '2024-03-25', 'an.tran@gmail.com', '0970123456'),
('0900123456', 'Lê Văn', 'Khôi', '2022-06-12', 'khoi.le@yahoo.com', '0981234567'),
('0011234567', 'Phạm Thị', 'Nhi', '2020-09-08', 'nhi.pham@outlook.com', '0992345678');

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

INSERT INTO vi_pham (idTV, name, price, dateCreate, state) VALUES
-- Chưa xử lý
('0012345678', 'Khóa thẻ 1 tháng', 0, '2024-11-15', 'Chưa xử lý'),
('0123456789', 'Bồi thường', 500000, '2025-01-10', 'Chưa xử lý'),
('0234567890', 'Khóa thẻ 2 tháng', 0, '2025-04-01', 'Chưa xử lý'),
('0345678901', 'Khóa thẻ vĩnh viễn', 0, '2025-03-25', 'Chưa xử lý'),
('0890123456', 'Khóa thẻ vĩnh viễn', 0, '2023-08-01', 'Chưa xử lý'),
('0456789012', 'Bồi thường', 250000, '2025-02-05', 'Chưa xử lý'),
-- Đã xử lý
('0567890123', 'Khóa thẻ 1 tháng', 0, '2024-10-20', 'Đã xử lý'),
('0678901234', 'Bồi thường', 1000000, '2024-12-18', 'Đã xử lý'),
('0789012345', 'Khóa thẻ 2 tháng', 0, '2024-09-11', 'Đã xử lý'),
('0901234567', 'Bồi thường', 750000, '2024-05-30', 'Đã xử lý');


INSERT INTO vao_tq (idTV, time_in) VALUES
('0012345678', '2025-04-27 08:05:22'),
('0234567890', '2025-04-27 13:40:17'),
('0456789012', '2025-04-28 07:25:49'),
('0678901234', '2025-04-28 10:15:33'),
('0890123456', '2025-04-28 15:50:41'),
('0102345678', '2025-04-29 06:45:28'),
('0324567890', '2025-04-29 09:30:55'),
('0546789012', '2025-04-29 14:20:12'),
('0768901234', '2025-04-30 08:10:46'),
('0980123456', '2025-04-30 11:55:34'),
('0192345678', '2025-04-30 16:30:27'),
('0394567890', '2025-05-01 07:35:19'),
('0596789012', '2025-05-01 10:45:52'),
('0798901234', '2025-05-01 13:25:38'),
('0900123456', '2025-05-02 06:50:44'),
('0123456789', '2025-05-02 09:15:31'),
('0345678901', '2025-05-02 12:40:16'),
('0567890123', '2025-05-03 07:20:53'),
('0789012345', '2025-05-03 08:55:29'),
('0011234567', '2025-05-03 10:30:47');

-- select * from vao_thu;