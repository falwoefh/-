# biến mật khẩu đã tạo sẵn là "12345"
# viết một chương trình kiểm tra xem người dùng có nhập đúng mật khẩu hay không
# nếu nhập sai mật khẩu thì chưong trình sẽ liên tục hỏi lại ng dùng cho đến khi nào đúng thì thôi
# nếu người dùng nhập đúng thì thông báo lêbn "bạn đã nhập đúng mk"

matkhau = "12345"
usermk = str(input("nhap mat khau vao day"))
while matkhau != usermk :
    usermk = str(input("nhap mat khau vao day"))    
print("mk chinh xac")