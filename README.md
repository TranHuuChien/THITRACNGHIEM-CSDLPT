ĐỀ TÀI MÔN CƠ SỞ DỮ LIỆU PHÂN TÁN ĐỀ 1. THI TRẮC NGHIỆM Nội dung: Thi trắc nghiệm các môn học theo các trình độ khác nhau. Yêu cầu: Giả sử trường có 2 cơ sở chính : cơ sở 1 (CS1), cơ sở 2 (CS2) Phân tán cơ sở dữ liệu THITN ra làm 3 mảnh với điều kiện sau:

THITN được đặt trên server1: chứa thông tin của các lớp, đăng ký thi trắc nghiệm của các lớp thuộc cơ sở 1.
THITN được đặt trên server2: chứa thông tin của các lớp, đăng ký thi trắc nghiệm của các lớp thuộc cơ sở 2.
THITN được đặt trên server3: chứa thông tin các lớp, sinh viên của cả 2 cơ sở 1 và 2. Server này dùng để tra cứu thông tin của lớp, sinh viên của cả 2 cơ sở.
Viết chương trình thực hiện các công việc sau trên từng cơ sở:

Đăng nhập: GIẢNG VIÊN SINH VIÊN Cơ sở : Login : Password : Trước khi sinh viên/ giáo viên sử dụng chương trình thì phải đăng ký trước. Đối với sinh viên thì masv xem như là login name
Nhập môn học: tạo form cho phép user nhập vào các môn học sẽ thi trắc nghiệm. Form có các chức năng sau: Thêm, Xóa, Ghi, Phục hồi, Reload.
Nhập Khoa, lớp: cho phép nhập dữ liệu cả 2 table Khoa, lớp (trình bày theo SubForm). Form có các chức năng sau: Thêm, Xóa, Ghi, Phục hồi, Reload
Nhập sinh viên : tạo form cho phép user nhập vào sinh viên của lớp (trình bày dưới dạng SubForm) . Form có các chức năng sau: Thêm, Xóa, Ghi, Phục hồi, Reload
Nhập giáo viên : tạo form cho phép user nhập vào thông tin của giáo viên của Khoa (trình bày dưới dạng SubForm) . Form có các chức năng sau: Thêm, Xóa, Ghi, Phục hồi, Reload.
Nhập đề: Form này cho phép user là giáo viên nhập vào bộ đề thi trắc nghiệm (Giảng viên chỉ thấy và cập nhật câu hỏi của mình) . Các câu hỏi sẽ được ghi vào table Bo_de. Form có các chức năng sau: Thêm, Xóa, Ghi, Phục hồi, Reload.
Chuẩn bị thi: Nhân viên nhập vào tên lớp, chọn môn học sẽ thi, chọn trình độ, lần thi, số câu thi, ngày thi, thời gian thi (số phút). Kết quả đăng ký sẽ được ghi vào table GiaoVien_DangKy. Khi đăng ký thi cho 1 lớp thì chương trình phải kiểm tra các ràng buộc.
Thi : Chương trình tự động in ra mã lớp, tên lớp, họ tên của sinh viên dựa vào loginname (mã sinh viên), password của sinh viên khi đăng nhập. Sinh viên chọn môn học, ngày thi, lần thi thì chương trình sẽ tự động lọc ra số câu thi, thời gian thi, trình độ mà giáo viên đã đăng ký. Sau khi click nút Bắt đầu thi thì chương trình sẽ lọc ra số câu thi ngẫu nhiên dựa vào các thông số đó, và sau đó tiến hành cho sinh viên thi Lưu ý: (Giao tác)
Các câu ngẫu nhiên không được trùng nhau, và lấy theo trình độ A, B hay C. Tuy nhiên, nếu ta chọn cho lớp thi các câu với trình độ cao (tối thiểu phải đạt 70% số câu thi) thì vẫn được lấy các câu cho các hệ với trình độ thấp hơn 1 bậc (không quá 30% số câu thi).
Các câu hỏi thi sẽ ưu tiên lấy ở cơ sở mà lớp đó học. Nếu thiếu thì mới lấy thêm ở cơ sở còn lại.
Điểm lớn nhất là 10
Số điểm các câu là như nhau
Cho phép user chọn lại các câu đã thi của lần thi trước
Khi hết thời gian qui định thì chương trình tự động kết thúc việc thi
Thông báo điểm ngay cho sinh viên thi và ghi kết quả vào table Bangdiem.
Xem kết quả: Mục này cho phép user in ra lại các câu đã thi dựa vào các thông tin : Mã sinh viên, môn học, lần thi. (login của user đã nhập). Màn hình kết xuất có dạng: Lớp : xxxxxxxxxxxxxxxxxxxxxxx Họ tên : xxxxxxxxxxxxxxxxxxxxxx Môn thi : xxxxxxxxxxxxxx Ngày thi : dd/mm/yyyy Lần thi: ##
STT Câu số (trong bộ đề) Nội dung Các chọn lựa Đáp án Đã chọn A. B. C. D.

Bảng điểm môn học: Giáo viên chọn tên lớp, tên môn học, lần thi ; chương trình sẽ in ra bảng điểm thi hết môn của lớp đã chọn . Mẫu in : thực hiện giống như của trường. (MASV HO TENjj DIEM ĐIỂM CHỮ)
Xem danh sách đăng ký thi trắc nghiệm của 2 cơ sở từ ngày @tungay đến ngày @denngay. Báo cáo sẽ nhóm danh sách đăng ký theo từng cơ sở, và in theo thứ tự tăng dần của ngày đăng ký (xử lý job) Báo cáo có dạng DANH SÁCH ĐĂNG KÝ THI TRẮC NGHIỆM CƠ SỞ 1 TỪ NGÀY dd/mm/yyyy ĐẾN NGÀY dd/mm/yyyy
STT TÊN LỚP TÊN MÔN HỌC GIẢNG VIÊN ĐĂNG KÝ SỐ CÂU THI NGÀY THI ĐÃ THI (X) GHI CHÚ 1 2 3 Tổng cộng số lượt đăng ký : ###

Phân quyền : 1 tài khoản thuộc 1 trong các nhóm Truong, CoSo, Giangvien, Sinhvien.
Nếu login thuộc nhóm Truong thì login đó có thể đăng nhập vào bất kỳ phân mảnh nào để xem dữ liệu bằng cách chọn tên cơ sở:
Chỉ có thể xem dữ liệu của phân mảnh tương ứng.(datareader)
Xem được các báo cáo.(xử lí sau)
Tạo login thuộc nhóm Truong(securityadmin create loginName and create user name : db-accessadmin and db-securityadmin ) Đối tượng PVH (Trường)
Nếu login thuộc nhóm CoSo thì ta chỉ cho phép toàn quyền làm việc(ower) trên cơ sở đó, không được log vào cơ sở khác, được tạo tài khoản mới cho nhóm Coso, Giangvien(securityadmin).(TEST Đối tượng là DAOVANTUYET)
Nếu login thuộc nhóm Giangvien (reader) thì chỉ được quyền cập nhật đề thi(1 table BODE VÀ CT_baithi), và chỉ được quyền xem và cập nhật câu hỏi thi do mình soạn, được thi thử nhưng không ghi điểm
Nhóm Sinhvien: Tất cả sinh viên dùng chung 1 tài khoản khi đăng nhập vào chương trình. Nhóm Sinhvien có các quyền: thi, xem lại bài thi đã thi. (db.datareader : BAITHI)(001) Chương trình cho phép ta tạo các login, password và cho login này làm việc với quyền hạn tương ứng. Căn cứ vào quyền này khi user login vào hệ thống, ta sẽ biết người đó được quyền làm việc với mảnh phân tán nào hay trên tất cả các phân mảnh,và các chức năng tương ứng. Ghi chú: Sinh viên tự kiểm tra các ràng buộc có thể có khi viết chương trình.
Cơ sở dữ liệu THI_TN gồm các tables như sau: a. Table CoSo : FieldName Type Constraint MACS nChar(3) Primary Key TENCS nVarchar(50) Unique DIACHI nVarchar(100) b. Table Khoa : FieldName Type Constraint MAKH nChar(8) Primary Key TENKH nVarchar(50) Unique MACS nChar(3) FK c. Table Lop : FieldName Type Constraint MALOP nChar(15) Primary Key TENLOP nVarchar(40) Unique MAKH nChar(8) FK d. Caáu truùc cuûa Table Monhoc: FieldName Type Constraint MAMH nChar(5) Primary key TENMH nVarchar(50) Unique Key e. Table Sinhvien: Field Name Type Constraint MASV nChar(8) Primary Key HO nvarchar(50) Chæ nhaän chöõ vaø blank TEN nvarchar(10) Chæ nhaän chöõ vaø blank NGAYSINH Date DIACHI nvarchar(100) MALOP nchar(15) Foreign key f. Table Giaovien: Field Name Type Constraint MAGV nChar(8) Primary Key HO nvarchar(40) TEN nvarchar(10) HOCVI nvarchar(40) MAKH nCHAR(8) FK g. Giaovien_Dangky Field Name Type Constraint MAGV nChar(8) Foreign Key MALOP nchar(15) Foreign key MAMH nChar(5) Foreign key TRINHDO nChar(1) ‘A’, ‘B’, ‘C’ NGAYTHI datetime Getdate() LAN SmallInt Laàn thi >=1 vaø Laàn thi <=2 SOCAUTHI SmallInt >=10 vaø <=100 THOIGIAN SmallInt >=15’ vaø <=60’ Khoùa chính: MALOP+ MAMH+LAN h. Caáu truùc cuûa Table BODE : FieldName Type Constraint MAMH nChar(5) Foreign Key CAUHOI int Primary key TRINHDO nchar(1) ‘A’ : Đại học , chuyên ngành ‘B’ : Đại học , không chuyên ngành ‘C’ : Cao đẳng NOIDUNG NText A NText B NText C NText D NText DAP_AN nchar (1) chæ thuoäc 1 trong 4 ñaùp aùn sau: ‘A’, ‘B’, ‘C’, ‘D’ MAGV nChar(8) Foreign Key i. Caáu truùc cuûa Table BangDiem : FieldName Type Constraint MASV nChar(8) Foreign Key MAMH nChar(5) Foreign Key LAN SmallInt Laàn thi >=1 vaø Laàn thi <=2 NGAYTHI datetime date DIEM float Điểm từ 0 đến 10 Primary key : MASV + MAMH + LAN

HEÁT NHÓM GIANG VIEN :

/những việc phải làm Tiến hành thực hiện nút làm mới củalớp để in ra thông tin lớp cập nhật
