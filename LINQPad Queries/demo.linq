<Query Kind="Expression">
  <Connection>
    <ID>d2ec63ee-d6d7-4548-8084-8844d5a7cec3</ID>
    <Persist>true</Persist>
    <Driver>EntityFrameworkDbContext</Driver>
    <CustomAssemblyPath>D:\baitapdemo\QuanLyBenhVien\QuanLyBenhVien\bin\QuanLyBenhVien.dll</CustomAssemblyPath>
    <CustomTypeName>QuanLyBenhVien.Models.OneMesEntities</CustomTypeName>
    <AppConfigPath>D:\baitapdemo\QuanLyBenhVien\QuanLyBenhVien\Web.config</AppConfigPath>
    <DisplayName>OnePKEntities</DisplayName>
  </Connection>
</Query>

BenhNhans.Where( o => o.Tuoi == null).Select(o => new 
{
Ma = o.Ma,
Ten = o.Ten,
NgaySinh = o.NgaySinh,
DiaChiSoNha = o.DiaChiSoNha
}
)