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

BenhNhans

BenhNhans.Where(o=>o.Tuoi==null).Select(o=>new
{
 Ma=o.Ma,
 Ten=o.Ten,
 Tuoi=o.Tuoi,
 DianhaChi=o.DiaChiSoNha
})

BenhNhans.Select(o=>new
{
 Ma =o.Ma,
 Ten=o.Ten,
 NS=o.NgaySinh
 
})

BenhNhans.Select (o => new 
{
        Ma = o.Ma,
        Ten = o.Ten,
        ID = o.ID
}).ToDictionary(o => o.ID)

BenhNhans.SelectMany(o=>o.KhamBenhs)
.Select(o=>new{kb=o, bn=o.BenhNhan})
.Select(o=>new
{
 MaKB=o.kb.Ma,
 MaBN=o.bn.Ma,
 TenBN=o.bn.Ten,
 TuoiBN=o.bn.Tuoi,
 DiaChiBN=o.bn.DiaChiSoNha
})

BenhNhans.Select(o=>new
{
 Id=o.ID,
 Ma =o.Ma,
 Ten=o.Ten,
 NgaySinh=o.NgaySinh
}).Skip(2)

BenhNhans.Select(o=>new
{
 Id=o.ID,
 Ma =o.Ma,
 Ten=o.Ten,
 NgaySinh=o.NgaySinh
}).Skip(2)

BenhNhans.Select(o=>new
{
        Id=o.ID,
        Ma =o.Ma,
        TenBN=o.Ten,
        NgaySinh=o.NgaySinh,
        Tuoi=o.Tuoi,
		GioiTinh = o.GioiTinh,
}).First(o=>o.TenBN=="Nguyễn Thế Anh")

BenhNhans.Where(o=>o.Ten.Contains("Trần")).Select(o=>new
{
        Ma=o.Ma,
        Ten=o.Ten
})


BenhNhans.Select(o=>o.Ma).
Concat(BenhNhans.Select(o=>o.Ten)).
Concat(BenhNhans.Select(o=>o.DienThoai))

BenhNhans.Select(o=>o.Ma).
Union(BenhNhans.Select(o=>o.Ten)).
Union(BenhNhans.Select(o=>o.DienThoai))

BenhNhans.Select(o=>new{Ma=o.Ma,Ten=o.Ten,Tuoi=o.Tuoi}).Distinct()

BenhNhans.Select(o=>new
{
Ma=o.Ma,Ten=o.Ten,Tuoi=o.Tuoi
}
).Distinct().ToArray()




BenhNhans.Select(o=>new
{
Ma=o.Ma,Ten=o.Ten,Tuoi=o.Tuoi
}
).Distinct().ToList()

SucKhoes.Where(o=>o.NhipTho<39).SelectMany(o=>o.KhamBenhs)
.Select(o=>new{kb=o, sk=o.SucKhoe, bn=o.BenhNhan})
.Select(o=>new
{
        MaKB=o.kb.Ma,
        MaBN=o.bn.Ma,
        BenhNhan=o.bn.Ten,
        IdSK=o.sk.ID,
        NhipTho=o.sk.NhipTho,
        CanNang=o.sk.CanNang
}).OrderBy(o=>o.NhipTho).ThenBy(o=>o.CanNang)



