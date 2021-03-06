# Scaffolding Oracle Database in Dotnet Core 

![Framework](https://img.shields.io/badge/framework-.net%20core%20v3.1-green)
![Database](https://img.shields.io/badge/Database-Oracle-brightgreen)

# About This
This is a project for Scaffolding DBContext in Entity Framework Core from existing oracle database.

# NuGet Packages
  
| NuGet Packages | Version |
| ------ | ------ |
| Microsoft.EntityFrameworkCore | 3.1.10 |
| Microsoft.EntityFrameworkCore.Design | 3.1.10 |
| Microsoft.EntityFrameworkCore.Relational | 3.1.10 |
| Microsoft.EntityFrameworkCore.Relational.Design | 1.1.6 |
| Microsoft.EntityFrameworkCore.Tools | 3.1.10 |
| Oracle.EntityFrameworkCore | 3.19.80 |
| Oracle.ManagedDataAccess.Core | 2.19.100 |

# Dependencies
  - Visual Studio 2019 | [Download](https://visualstudio.microsoft.com/downloads/)
  - Dotnet Core 3.1 | [Download](https://dotnet.microsoft.com/download/dotnet-core/3.1) |

# How to use it?
It's very simple. It's a C# class library targeting ***.net core 3.1.*** So Makesure you have ***.net core 3.1 or above***.

**Step # 1 :** 
    
    Clone the repository
**Step # 2 :** 
    
    Open the solution file (Recommended with Visual Studio 2019)
**Step # 3 :** 

    Go to ***Tools > NuGet package manger > Package Manager Console***
**Step # 4 :** 

    Run the following Command

```sh
Scaffold-DbContext "User Id=[Your User Id];Password=[Your Password];Data Source=[Your Data Source];" Oracle.EntityFrameworkCore -OutputDir Models
```

License
----

MIT


**Free Software, Hell Yeah!**

***Tools I used to create this read me. Might also help you!***
[Shields IO](https://shields.io)
[Dillinger](https://dillinger.io)
