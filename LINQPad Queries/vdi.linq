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

KhamBenhs.Select(o=>new{
	IDBenhNhan = o.BenhNhanID,
	Ten = o.BenhNhan.Ten,
	TienBienLai = o.TienBienLai
})
.GroupBy(o=> new {o.IDBenhNhan, o.Ten})
.Select(o => new{
IDBenhNhan = o.Key.IDBenhNhan,
Ten = o.Key.Ten,
SL = o.Count(),
Tien = o.Sum(a=>a.TienBienLai)
})


///bai vi du moi 
KhamBenhs.Select(o=>new{
	IDBenhNhan = o.BenhNhanID,
	Ten = o.BenhNhan.Ten,
	TienBienLai = o.TienBienLai
})
.GroupBy(o=> new {o.IDBenhNhan, o.Ten}).Where(o=>o.Count()>2)
.Select(o => new{
IDBenhNhan = o.Key.IDBenhNhan,
Ten = o.Key.Ten,
SL = o.Count(),
Tien = o.Sum(a=>a.TienBienLai)
})