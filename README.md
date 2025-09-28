HỌ  TÊN: NGUYỄN TIẾN ĐỨC_K225480106081


BÀI TOÁN: KỂ  CHUYỆN BẰNG CÁCH GHÉP TỪ


BÀI  TẬP VỀ   NHÀ: TẠO SOLUTION GỒM CÁC PROJECT SAU: ###
1. DLL đa năng, keyword: c# window library -› **Class Library (-NET Framework)**: giải bài toán bất kỳ, độc lạ càng tốt, có dấu ấn cá nhân trong kết quả, biên dịch ra


2. Console sử dụng được DLL trên: nhập được input, gọi DLL, hiển thị kết quả. keyword: c# window Console => **Console App (-NET Framework)**, biên dịch ra EXE


3. Windows Form Application sử dụng được DLL đa năng trên, kéo các control vào để có thể lấy đc input, gọi DLL truyền input để lấy đc kq, hiển thị kq ra window form;
keyword: c# window Desktop => **Windows Form Application (-NET Framework)**, biên dịch ra EXE


4. Web đơn giản, sử dụng web server là IIS, dùng file hosts để tự tạo domain, gắn domain này vào iis, file index.html có sử dụng html css js để xây dựng giao diện nhập
được các input cho bài toán, dùng mã js để tiền xử lý dữ liệu, js để gửi lên backend. backend là api.aspx, trong code của api.aspx.cs thì lấy được các input mà js gửi lên, rồi sử dụng được DLL đa năng trên, kết quả gửi lại json cho client, js phía client sẽ nhận được gson này hậu xử lý để thay đổi giao diện theo dữ liệu nhận dược.
keyword: c# window web => **ASP.NET Web Application (.NET Framework)** + tham khảo link chatgpt thầy gửi. project web này biên dịch ra DLL, phải kết hợp với IIS mới chạy

 
 CÁCH LÀM:

 
I:    Console app, bắt buộc sử dụng .NET Framework 2.0, sử dụng được DLL trên: nhập được input, gọi DLL, hiển thị kết quả, phải có dấu án cá nhân. keyword: c# window Console => Console App (.NET Framework), biên dịch ra EXE


<img width="1892" height="1073" alt="image" src="https://github.com/user-attachments/assets/19dc3135-2019-46bb-9214-2d6aa2036b07" />




II:   Windows Form Application, bắt buộc sử dụng .NET Framework 2.0**, sử dụng được DLL đa năng trên, kéo các control vào để có thể lấy đc input, gọi DLL truyền input để lấy đc kq, hiển thị kq ra window form, phải có dấu án cá nhân; keyword: c# window Desktop => Windows Form Application (.NET Framework), biên dịch ra EXE



<img width="1911" height="1069" alt="image" src="https://github.com/user-attachments/assets/411b4361-537a-49c2-ac21-07fcb17f745a" />


KẾT  QUẢ KHI  CHẠY ĐƯỢC


<img width="1904" height="1050" alt="image" src="https://github.com/user-attachments/assets/ddd576c3-ad52-4656-812d-45c8b895cdbc" />



III:   Web đơn giản, bắt buộc sử dụng .NET Framework 2.0, sử dụng web server là IIS, dùng file hosts để tự tạo domain, gắn domain này vào iis, file index.html có sử dụng html css js để xây dựng giao diện nhập được các input cho bài toán, dùng mã js để tiền xử lý dữ liệu, js để gửi lên backend. backend là api.aspx, trong code của api.aspx.cs thì lấy được các input mà js gửi lên, rồi sử dụng được DLL đa năng trên. kết quả gửi lại json cho client, js phía client sẽ nhận được json này hậu xử lý để thay đổi giao diện theo dữ liệu nhận dược, phải có dấu án cá nhân. keyword: c# window web => ASP.NET Web Application (.NET Framework) + tham khảo link chatgpt thầy gửi. project web này biên dịch ra DLL, phải kết hợp với IIS mới chạy được.


<img width="1897" height="1080" alt="image" src="https://github.com/user-attachments/assets/aa6c0581-5e87-43b0-b4ad-e04a8b614ed0" />



KẾT QUẢ  KHI CHẠY :



<img width="1914" height="1072" alt="image" src="https://github.com/user-attachments/assets/e061c469-4247-4c31-b6a2-86aee3060159" />
