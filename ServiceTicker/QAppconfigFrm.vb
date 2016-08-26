Public Class QAppconfigFrm

    Private Sub QAppconfigFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = Mainfrm.Icon
        Me.TextBox1.Text = " - กรณีเลือกเป็น เครื่องแม่ข่าย โปรแกรมจะทำการ สตาร์ทฐานข้อมูลตอนเปิดโปรแกรม เสมอ" & vbNewLine & _
                           " - กรณีเลือกเป็น เครื่องลูกข่าย โปรแกรมจะไม่ทำการ สตาร์ทฐานข้อมูลตอนเปิดโปรแกรม" & vbNewLine & _
                           " - กรณีเลือกเป็น เครื่องลูกข่าย แล้ว ต้องการอยากจะเปลี่ยนมาใช้งานเครื่องเดียวแต่ฐานข้อมูลไม่ยอมทำงาน ให้ทำการสตาร์ทฐานข้อมูล ดัวยตัวท่านเอง โดยไปที่ ไดร์ C:\ServiceTicker\Mysql\Start.exe" & vbNewLine & _
                           " - หากต้องการสต็อบ(หยุด)การทำงานของ ฐานข้อมูล ดัวยตัวท่านเอง โดยไปที่ ไดร์ C:\ServiceTicker\Mysql\Stop.exe" & vbNewLine & _
                           " - ชื่อประจำเครื่อง คือ กรณีใช้งานหลายเครื่อง ให้ตั้งชื่อประจำเครื่องให้ไม่ซ้ำกัน มีผลกับการบันทึกเงินสดที่ใช้ทอนเท่านั้น"
    End Sub
End Class