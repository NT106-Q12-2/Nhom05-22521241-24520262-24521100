# Bài tập Môn Lập trình Mạng Căn bản

## Thông tin Nhóm

| MSSV | Họ và tên | Username |
| :--- | :--- | :--- |
| 22521251 | Nguyễn Duy Thế Sơn | [NDTSon](https://github.com/NDTSon) |
| 24520262 | Nguyễn Tấn Danh | [NTDanh-it](https://github.com/NTDanh-it) |
| 24521100 | Đoàn Nguyễn Hà Nam | [DoanNguyenHaNam](https://github.com/DoanNguyenHaNam) |

---

## 📂 Cấu trúc Thư mục

```
Nhom5-22521241-24520262-24521100/
|
├── Lab4/                   
|   |
|   ├── Lab4.sln              <-- Solution CHUNG cho cả Lab 4
|   |
|   ├── Lab4_Bai1/                 
|   |   ├── Bai1.csproj
|   |   ├── Bai1.cs
|   |   └── ...
|   |
|   ├── Lab4_Bai2/               
|   |   ├── Bai2.csproj
|   |   ├── Bai2.cs
|   |   └── ...
|   |
|   ├── Lab4_Bai3/             
|   |   ├── Bai3.csproj
|   |   ├── Bai3.cs
|   |   └── ...
|   |
|   ├── Lab4_Bai4/          
|   |   ├── Bai4.csproj
|   |   ├── Bai4.cs
|   |   └── ...
|   |
|   ├── Lab4_Bai5/           
|   |   ├── Bai5.csproj
|   |   ├── Bai5.cs
|   |   └── ...
|   |
|   └── Lab4_Bai6/              
|       ├── Bai6.csproj
|       ├── Bai6.cs
|       └── ...
|
└── .gitignore                <-- File .gitignore 
└── README.md                 
```

**Tóm tắt yêu cầu:**
1.  Mỗi **Lab** là một thư mục (ví dụ: `Lab1`, `Lab2`).
2.  Trong mỗi thư mục `LabX`, có **một Solution duy nhất** (ví dụ: `Lab1.sln`).
3.  Mỗi **Bài tập** (ví dụ: `Bai1`, `Bai2`) là một **Project** riêng biệt, nằm trong Solution đó.
---

## 🚀 Quy trình Làm bài (Cách tạo Solution đúng chuẩn)

Để tạo ra cấu trúc `Bai1/Bai1.sln` và `Bai1/Bai1/Bai1.csproj` như yêu cầu, hãy làm theo các bước sau khi tạo project trên Visual Studio:

1.  Trong thư mục repo, tạo các thư mục bằng tay trước, ví dụ: `Lab1` và bên trong nó là `Bai1`.
2.  Mở **Visual Studio**.
3.  Chọn **"Create a new project"** -> **"Windows Forms App (.NET Framework)"**.
4.  **Tại màn hình "Configure your new project":**
    * **Project name:** Đặt tên bài, ví dụ: `Bai1`.
    * **Location:** Bấm nút `...` và trỏ đến thư mục bạn vừa tạo.
        * *Ví dụ:* `D:\MyCode\Nhom-XX-MSSV1-MSSV2-MSSV3\Lab1\Bai1`


---

##  Workflow Luồng làm việc Git (Git Workflow)

Để đảm bảo chất lượng code, sự ổn định của nhánh `master` và tối ưu hóa quy trình làm việc nhóm, tất cả các thành viên BẮT BUỘC tuân thủ các quy tắc dưới đây.

### 1. Mô hình Nhánh (Branching Model)

#### Nhánh `master`

* Là nhánh chính, luôn ở trạng thái ổn định, sẵn sàng để "sử dụng" (production-ready).
* Nhánh `master` đã được cài đặt **Protection Rules** (Quy tắc Bảo vệ).
* **NGHIÊM CẤM** push code trực tiếp lên `master`. Mọi thay đổi phải thông qua Pull Request.

#### Nhánh Tính năng (Feature Branch)

* Tất cả các công việc (thêm tính năng, sửa bug) đều phải được thực hiện trên một nhánh riêng, gọi là "nhánh tính năng".
* Quy tắc đặt tên: `feature/ten-chuc-nang` hoặc `bugfix/sua-loi-abc` hoặc `hotfix/sua-loi-khan-cap`.

### 2. Quy trình Làm việc Chi tiết

#### Bước 0: Lấy code về máy (Clone)
(Chỉ làm 1 lần duy nhất khi mới tham gia dự án)
```bash
git clone [URL-repository-cua-ban]
cd [ten-repo]
```

#### Bước 1: Đồng bộ hóa (Synchronization)

Trước khi bắt đầu bất kỳ công việc nào, phải đảm bảo code ở local của bạn được cập nhật mới nhất từ `master`.

```bash
# Chuyển về nhánh master
git checkout master

# Lấy code mới nhất từ server về
git pull origin master
```

#### Bước 2: Tạo Nhánh Tính năng

Tạo một nhánh mới từ `master` để bắt đầu công việc.

```bash
# Tạo và chuyển sang nhánh mới (ví dụ: làm Lab 1 Bài 1)
git checkout -b feature/lab1-bai1
```

#### Bước 3: Làm việc và Commit (Work & Commit)

Đây là quy tắc quan trọng nhất trong quá trình làm việc cá nhân.

* **Atomic Commits:**
    * Chỉ `commit` khi bạn đã **hoàn thành một chức năng logic** (ví dụ: "Hoàn thành UI form đăng nhập") hoặc **sửa xong một bug** (ví dụ: "Sửa lỗi crash app khi nhấn nút XYZ").
    * **KHÔNG** commit code đang làm dở dang, code bị lỗi (build failed), hoặc code đang trong quá trình debug (ví dụ: còn `console.log` hoặc code comment lung tung).
    * **KHÔNG** "commit dồn" (gộp nhiều chức năng không liên quan vào một commit lớn) vì sẽ gây khó khăn cho việc review code và rollback khi cần.

* **Quy ước Commit Message (Nội dung Commit):**
    * Nội dung commit **BẮT BUỘC** viết bằng **tiếng Việt, có dấu**.
    * Nội dung phải rõ ràng, ngắn gọn, và mô tả chính xác sự thay đổi (ví dụ: "Hoan thanh Lab 1 - Bai 1: Chuc nang chat TCP Client").

#### Bước 4: Push Nhánh Tính năng

Khi hoàn thành task, hãy push nhánh cá nhân của bạn lên server (remote).

```bash
# Push nhánh 'feature/lab1-bai1' lên server
git push origin feature/lab1-bai1
```

#### Bước 5: Tạo Pull Request (PR) và Review Code

Khi nhánh tính năng đã hoàn thành và sẵn sàng để tích hợp vào `master`, bạn phải:

1.  Truy cập GitHub, vào trang repository của nhóm.
2.  Tạo một **Pull Request** (PR) từ nhánh của bạn (`feature/lab1-bai1`) vào nhánh `master`.
3.  Viết mô tả rõ ràng cho PR: Bạn đã làm gì? Chức năng này hoạt động ra sao?
4.  Tag (nhắc) ít nhất một thành viên khác trong nhóm (Reviewer) để thực hiện **review code**.
5.  Reviewer có trách nhiệm kiểm tra code, chạy thử, và để lại comment nếu cần chỉnh sửa.
6.  PR chỉ được **Merge** (tích hợp) vào `master` khi đã được Reviewer **Approve** (Chấp thuận).

#### Bước 6: Xử lý Tác vụ Phức tạp (Advanced Workflow)

Trong trường hợp bạn phải làm một chức năng lớn (ví dụ: "Lab 3") và muốn chia nhỏ công việc, bạn có thể sử dụng "nhánh con".

1.  Giả sử bạn đang ở nhánh `feature/lab-3`.
2.  Bạn muốn làm một tác vụ nhỏ trong Lab 3 (ví dụ: "Bai 1"), bạn tạo một nhánh con từ nhánh hiện tại:
    ```bash
    git checkout -b feature/lab-3/bai-1
    ```
3.  Sau khi làm xong `Bai 1` trên nhánh `feature/lab-3/bai-1`, bạn quay trở lại nhánh GỐC (`feature/lab-3`) và merge nhánh con vào:
    ```bash
    # Quay về nhánh gốc
    git checkout feature/lab-3
    
    # Merge nhánh con vào
    git merge feature/lab-3/bai-1
    ```
4.  Sau khi merge thành công, bạn có thể xóa nhánh con đi:
    ```bash
    git branch -d feature/lab-3/bai-1
    ```
5.  Lặp lại quy trình này cho `Bai 2`, `Bai 3`... Cuối cùng, khi `feature/lab-3` đã hoàn tất, bạn mới tạo PR để merge nó vào `master`.
