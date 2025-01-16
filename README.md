# Exercise: Database Discovery Application with SOAP Services

## Mô Tả
Bài tập này yêu cầu bạn phát triển một ứng dụng cho phép khám phá cơ sở dữ liệu thế giới thông qua dịch vụ SOAP. Ứng dụng được chia thành hai phần: server-side và client-side.

## Yêu Cầu
- **Server Side**: Tạo các dịch vụ SOAP để truy xuất dữ liệu từ cơ sở dữ liệu theo mô tả dưới đây:
  - Lấy tất cả các quốc gia từ cơ sở dữ liệu.
  - Lấy thông tin quốc gia theo mã quốc gia.
  - Lấy thông tin thành phố theo tên.
  - Lấy tất cả các thành phố của một quốc gia cụ thể.
  - Các dịch vụ khác mà bạn có thể nghĩ đến.

- **Client Side**: Tạo một ứng dụng Windows Form để gọi các dịch vụ ở server side.

## Hướng Dẫn Triển Khai

### Bước 1: Chuẩn Bị Cơ Sở Dữ Liệu
- Tải xuống script cơ sở dữ liệu thế giới (đính kèm) và nhập nó vào hệ thống quản lý cơ sở dữ liệu của bạn.

### Bước 2: Triển Khai Server Side
1. **Tạo Dịch Vụ SOAP**:
   - Sử dụng ngôn ngữ lập trình như C# để tạo dịch vụ SOAP.
   - Định nghĩa các phương thức như sau:
     - `GetAllCountries()`: Trả về danh sách tất cả các quốc gia.
     - `GetCountryByCode(string countryCode)`: Trả về thông tin quốc gia theo mã.
     - `GetCityByName(string cityName)`: Trả về thông tin thành phố theo tên.
     - `GetAllCitiesByCountry(string countryCode)`: Trả về tất cả các thành phố của một quốc gia cụ thể.

### Bước 3: Triển Khai Client Side
1. **Tạo Ứng Dụng Windows Form**:
   - Sử dụng Visual Studio để phát triển ứng dụng.
   - Thiết kế giao diện người dùng cho phép người dùng nhập thông tin và gửi yêu cầu đến dịch vụ SOAP.
   - Hiển thị kết quả trả về từ dịch vụ trên giao diện người dùng.

### Bước 4: Kiểm Tra và Chạy Ứng Dụng
- Chạy dịch vụ SOAP trên server.
[- ![Uploading image.png…]()](https://github.com/LemyTruc/Exercises1-LeMyTruc-SOA-/blob/main/WebService.png)

- Mở ứng dụng Windows Form và thử nghiệm với các chức năng đã triển khai.
     - `GetAllCountries()`: Trả về danh sách tất cả các quốc gia. https://github.com/LemyTruc/Exercises1-LeMyTruc-SOA-/blob/main/GetAllCountry.png 
     - `GetCountryByCode(string countryCode)`: Trả về thông tin quốc gia theo mã. [https://github.com/LemyTruc/Exercises1-LeMyTruc-SOA-/blob/main/GetCountryByCode.png](https://github.com/LemyTruc/Exercises1-LeMyTruc-SOA-/blob/main/GetCountryByCode.png) 
     - `GetCityByName(string cityName)`: Trả về thông tin thành phố theo tên. [https://github.com/LemyTruc/Exercises1-LeMyTruc-SOA-/blob/main/GetCityByName.png](https://github.com/LemyTruc/Exercises1-LeMyTruc-SOA-/blob/main/GetCityByName.png)  
     - `GetAllCitiesByCountry(string countryCode)`: Trả về tất cả các thành phố của một quốc gia cụ thể. https://github.com/LemyTruc/Exercises1-LeMyTruc-SOA-/blob/main/GetCityByCountryCode.png

## Kết Quả Đạt Được
- Triển khai thành công các phương thức xử lý dữ liệu thông qua dịch vụ SOAP.
- Cung cấp các chức năng yêu cầu từ ứng dụng client.
- Phát triển giao diện người dùng cho phép người dùng cuối gửi yêu cầu và xem kết quả.

## Liên Hệ
Nếu bạn có bất kỳ câu hỏi nào hoặc cần hỗ trợ, hãy liên hệ với tôi qua email: mytruckrbm@gmail.com
