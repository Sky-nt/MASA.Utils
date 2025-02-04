[中](README.zh-CN.md) | EN

# MASA.Utils

MASA.Utils is a library of MASA tools used by projects such as [MASA Stack](https://github.com/masastack) and [MASA Labs](https://github.com/masalabs).



## Roadmap
* [Release Notes](https://github.com/masastack/MASA.Utils/releases)
* [Latest Roadmap](https://github.com/masastack/MASA.Utils/issues/40)



## Features
* Caching
  * Memory: memory cache
  * Redis
  * DistributedMemory: Distributed memory cache
* Caller
  * HttpClient
  * DaprClient
* [Elasticsearch](./src/Data/Masa.Utils.Data.Elasticsearch/README.md)
* [EntityFrameworkCore](./src/Data/Masa.Utils.Data.EntityFrameworkCore/README.md)
  * [SqlServer](./src/Data/Masa.Utils.Data.EntityFrameworkCore.SqlServer/README.md)
  * [MySql](./src/Data/Masa.Utils.Data.EntityFrameworkCore.MySql/README.md)
  * [Pomelo.MySql](./src/Data/Masa.Utils.Data.EntityFrameworkCore.Pomelo.MySql/README.md)
  * [Sqlite](./src/Data/Masa.Utils.Data.EntityFrameworkCore.Sqlite/README.md)
  * [Cosmos](./src/Data/Masa.Utils.Data.EntityFrameworkCore.Cosmos/README.md)
  * [InMemory](./src/Data/Masa.Utils.Data.EntityFrameworkCore.InMemory/README.md)
  * [Oracle](./src/Data/Masa.Utils.Data.EntityFrameworkCore.Oracle/README.md)
  * [PostgreSql](./src/Data/Masa.Utils.Data.EntityFrameworkCore.PostgreSql/README.md)
*Dapr
  * [Development.Dapr](./src/Development/Masa.Utils.Development.Dapr/README.md): Dapr Starter Core Library
  * [Development.Dapr.AspNetCore](./src/Development/Masa.Utils.Development.Dapr.AspNetCore/README.md)
*Extensions
  * DependencyInjection: inject extension
  * DotNet: DotNet extension
  * Enums: enum extension
  * Expressions: Expression expansion
* Ldap
  * Ldap.Novell: Novell-based LDAP client library
* Exceptions: exception extension
* Security: security
  * Authentication: Authentication
  * Cryptography: Password extension, support AES encryption and decryption, DES encryption and decryption, Base64 encoding, MD5 encryption, SHA encryption, etc.
  * Token: JWT token management



## How to contribute

1. Fork & Clone
2. Create Feature_xxx branch
3. Commit with commit message, like `feat(Elasticsearch): Support Index management, document management, alias management`
4. Create Pull Request

If you wish to contribute, please [Pull Request](https://github.com/masastack/MASA.Utils/pulls), or send us a [Report Bug](https://github.com/masastack/MASA.Utils /issues/new) .



## Contributors

Thanks to all the friends who have contributed to this project.

<a href="https://github.com/masastack/MASA.Utils/graphs/contributors">
    <img src="https://contrib.rocks/image?repo=masastack/MASA.Utils" />
</a>



## Code of conduct

This project adopts the Code of Conduct as defined by the Contributors Covenant to clarify the expected behavior of our community. For more information see [MASA Stack Community Code of Conduct](https://github.com/masastack/community/blob/main/CODE-OF-CONDUCT.md).



## ☀️ License Statement

[![MASA.Utils](https://img.shields.io/badge/License-MIT-blue?style=flat-square)](/LICENSE.txt)

Copyright (c) 2021-present MASA Stack