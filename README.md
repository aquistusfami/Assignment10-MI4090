# Assignment week-10

---

### 1. Factory đang che giấu quyết định thiết kế nào

- `Factory` che giấu quyết định chọn lớp cụ thể nào dựa trên chuỗi loại, client chỉ việc thực hiện lời gọi tới `factory` để tạo thiết bị, còn việc cụ thể khởi tạo như nào hay cơ chế lựa chọn ra sao thì nằm ở bên trong, và khi có tình huống mới phát sinh thì không cần sửa ở client, chỉ sửa ở `factory`.

### 2. Singleton bảo đảm điều gì, nhưng tạo ra rủi ro nào?

- `Singleton` đảm bảo việc là chỉ có duy nhất 1 instance được khởi tạo chung và không cho phép khởi tạo từ bên ngoài. Nhưng rủi ro chính là khó viết unit test vì trạng thái toàn cục dùng chung: test này đổi giá trị thì test sau đọc phải giá trị đã bị đổi, nên các test phụ thuộc lẫn nhau.

### 3. Facade khác Factory ở mục đích chính như thế nào?

- `Factory` giúp client tạo đối tượng mà không biết lớp cụ thể, còn `Facade` giúp client dùng nhiều thiết bị cùng lúc bằng một thao tác đơn giản.

### 4. Nếu bỏ SmartHomeFacade, client sẽ phải biết thêm những chi tiết nào?

- nếu bỏ `SmartHomeFacade` client phải biết gọi các thiết bị theo đúng thứ tự để hoạt động theo ý của client và phải biết thông tin về `HomeConfiguration` là có `NightLightLevel` để in ra. đồng thời nếu đổi chế độ Đi ngủ, mọi nơi gọi lẻ đều phải sửa theo.

 