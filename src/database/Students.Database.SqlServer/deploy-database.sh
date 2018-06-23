echo 'Starting SQL Server...'
sleep 30s
echo 'SQL Server Running.'

echo 'Deploying database...'
/opt/mssql-tools/bin/sqlcmd -S localhost -U sa -P ItsF1n3-_- -d master -i Students.Database.SqlServer_Create.sql
echo 'Deployment complete.'