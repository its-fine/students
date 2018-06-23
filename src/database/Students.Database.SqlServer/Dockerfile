FROM microsoft/mssql-server-linux:2017-latest

ENV ACCEPT_EULA=Y
ENV SA_PASSWORD=ItsF1n3-_-
ENV MSSQL_PID=Developer

WORKDIR /src

COPY ./bin/Debug/Students.Database.SqlServer_Create.sql ./
COPY deploy-database.sh ./
COPY startup.sh ./

RUN chmod +x ./deploy-database.sh
RUN chmod +x ./startup.sh

CMD ./startup.sh