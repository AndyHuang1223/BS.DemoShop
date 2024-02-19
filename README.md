# BS.DemoShop
## ���ҳ]�w
1. SDK : .NET 7.0(�ΥH�W)�C
2. �s�u�r��]�w : �ק�`appsettings.json`�Ϊ�`�ϥΨϥΪ̱K�X(sectets.json)`(�ѦҸ��:[�b ASP.NET Core ���}�o���w���x�s���ε{���K�X](https://learn.microsoft.com/zh-tw/aspnet/core/security/app-secrets?view=aspnetcore-7.0&tabs=windows))�C
3. �E��(��s)��Ʈw : 
	- �ϥ�.Net Core CLI : `dotnet ef database update --project ./DemoShop.Infrastructure/ --startup-project ./DemoShop.Web/`�C
	- �ϥ�Visual Studio PMC(�w�]�M�׬�DemoShop.Infrastructure) : `Update-Database`�C

## ��Ʈw���ʬy�{(�ϥ�.Net Core CLI)
�H�U��ؤ覡��ĳ�Ĥ@���إ�Entity��DbContext�ɥi�H�ϥ�Scaffold�覡�٭�F�E����Ʈw�ɦA�ϥ�Migration���覡��s���L���Ҫ���Ʈw�C

### Code First
1. �ק�Entity Model�C
2. �s�WMigration���ʬ��� : ���O `dotnet ef migrations add <Migration name> --project ./DemoShop.Infrastructure/ --startup-project ./DemoShop.Web/ --output-dir ./Data/Migrations`�C
3. �E��(��s)��Ʈw : `dotnet ef database update --project ./DemoShop.Infrastructure/ --startup-project ./DemoShop.Web/`�C

### Code First From DB(Scaffolding)
1. �ק��ƮwSchema�C
2. Scaffolding��Ʈw : `dotnet ef dbcontext scaffold "Name=ConnectionStrings:BSDemoShopConnection" Microsoft.EntityFrameworkCore.SqlServer --output-dir ../DemoShop.ApplicationCore/Entities --context-dir ../DemoShop.Infrastructure/Data --namespace DemoShop.ApplicationCore.Entities --context BSDemoShopContext --context-namespace DemoShop.Infrastructure.Data --startup-project ./DemoShop.Web --data-annotations --force`�C
3. �ק�`IRepository<T>`��`EfRepository<T>`���x������ : �N`BaseEntity`�קאּ`class`(�S�ק諸�ܷ|�L�k�ظm)�C


## ��L
- [Entity Framework Core �u��Ѧ� - .NET Core CLI](https://learn.microsoft.com/zh-tw/ef/core/cli/dotnet)�C
- [Scaffolding (�ϦV�u�{)](https://learn.microsoft.com/zh-tw/ef/core/managing-schemas/scaffolding/?tabs=dotnet-core-cli)�C