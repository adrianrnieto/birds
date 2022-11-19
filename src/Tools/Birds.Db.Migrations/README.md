1. Run: docker pull mcr.microsoft.com/mssql/server:2022-latest
2. Run: docker run -e "ACCEPT_EULA=Y" -e "MSSQL_SA_PASSWORD=Abcd1234.," -p 1433:1433 --name sql1 --hostname sql1 -d mcr.microsoft.com/mssql/server:2022-latest
3. Run: docker ps
4. The Status of the container must be Up