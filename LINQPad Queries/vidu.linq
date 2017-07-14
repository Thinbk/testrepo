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
Tuoi = o.Tuoi,
DiaChiSoNha = o.DiaChiSoNha
}
)


KhamBenhs.Select( o => o.BenhNhan).Where(o => o.Tuoi ==null).Select( o => new
{
Ma = o.Ma,
ten = o.Ten,
Tuoi = o.Tuoi,
DiaChi = o.DiaChiSoNha
}
)


//KhamBenhs.Select(o => new
//{
//kb = o,
//bn = o.BenhNhan
//}
//)
//
//.Select (o => new 
//{
//MaBK = o.kb.Ma,
//MaBN = o.bn.Ma,
//TenBN = o.bn.Ten,
//TuoiBN = o.bn.Tuoi
//
//}
//)
//
//BenhNhans.SelectMany(o => o.KhamBenhs) 
//.Select(o =>new { kb = o, bn = o.BenhNhan})
//.Select(o => new
//{
//MaBk = o.kb.Ma,
//MaBN = o.bn.Ma,
//TenBN = o.bn.Ten,
//TuoiBN = o.bn.Tuoi
//}
//)

SucKhoes.Where(o=>o.NhipTho<39).SelectMany(o=>o.KhamBenhs)
.Select(o=>new{kb=o, sk=o.SucKhoe, bn=o.BenhNhan})
.Select(o=>new
{
 MaKB=o.kb.Ma,
 MaBN=o.bn.Ma,
 BenhNhan=o.bn.Ten,
 NhipTho=o.sk.NhipTho,
}). Count()

