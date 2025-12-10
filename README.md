# 🛒 Phone Store Mini Project (Blazor)

Dự án này là một mini project dùng để luyện tập Blazor (Server hoặc WebAssembly). Ứng dụng mô phỏng một **cửa hàng điện thoại** với khả năng lọc sản phẩm theo nhiều tiêu chí khác nhau.

---

## 🚀 Tính năng chính

### 🔍 1. Tìm kiếm theo tên sản phẩm
- Người dùng nhập từ khóa vào ô tìm kiếm
- Danh sách sản phẩm tự động lọc **realtime**
- Không phân biệt hoa – thường (case-insensitive)

### 💰 2. Lọc theo khoảng giá
- Dropdown chọn mức giá:
  - 0 – 1 triệu
  - 1 – 5 triệu
  - 5 – 10 triệu
  - Trên 10 triệu
- Chỉ hiển thị sản phẩm nằm trong khoảng giá đã chọn

### 📦 3. Lọc theo tình trạng hàng hóa
- Checkbox: *Còn hàng* / *Hết hàng*
- Cho phép bật tắt tùy ý

### 🖼️ 4. Hiển thị danh sách sản phẩm
- Dữ liệu được mô phỏng dưới dạng mảng/list cố định
- Mỗi sản phẩm hiển thị:
  - Tên
  - Giá
  - Hình ảnh (ảnh mạng tự động)
  - Tình trạng
  - Hãng sản xuất (hiển thị badge màu)

### 🎨 5. Badge màu theo hãng (nâng cấp)
- iPhone → xanh dương
- Samsung → tím
- Xiaomi → cam

### ✨ 6. Highlight từ khóa tìm kiếm (nâng cấp)
- Khi người dùng search: ví dụ search "pro"
- Tên sản phẩm sẽ được highlight phần trùng khớp

---

## 🛠 Công nghệ sử dụng
- **.NET** (từ 7.0 trở lên)
- **Blazor**
- **Bootstrap 5** để làm UI nhanh

---

## 📂 Cấu trúc thư mục
```
PhoneStore/
│   README.md
│   Program.cs
│   App.razor
│   Imports.razor
│
├── Pages/
│   ├── Index.razor
│   └── Components/
│       └── ProductList.razor
│
├── Models/
│   └── Phone.cs
│
└── wwwroot/
    └── images/
```

---

## 📘 Mục tiêu học tập
- Binding nhiều biến cùng lúc
- Dùng `@foreach`, `@if`, `@oninput`, `bind-...`
- Xử lý chuỗi nâng cao: `IndexOf`, `StringComparison.OrdinalIgnoreCase`
- Làm quen mini project theo style thực tế

---

## ▶️ Cách chạy project
1. Clone project hoặc copy folder
2. Mở bằng Visual Studio / VS Code
3. Chạy lệnh:
   ```bash
   dotnet run
   ```
4. Truy cập trình duyệt: `https://localhost:xxxx`

---

## 🙌 Ghi chú
Đây là dự án luyện tập—tất cả dữ liệu sản phẩm dùng dạng hard-code và đơn giản hóa logic để phù hợp người mới học Blazor.

Nếu muốn nâng cấp thêm, bạn có thể:
- Thêm giỏ hàng
- Thêm trang chi tiết sản phẩm
- Thêm API thật
- Thêm phân trang

Chúc bạn học Blazor thật vui và tiến bộ nhanh! 🚀