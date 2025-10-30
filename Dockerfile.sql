FROM mcr.microsoft.com/mssql/server:2022-latest
USER root

ENV ACCEPT_EULA=Y
ENV DEBIAN_FRONTEND=noninteractive

RUN apt-get update && apt-get install -y mssql-tools unixodbc-dev
ENV PATH="$PATH:/opt/mssql-tools/bin"
USER mssql
