FROM microsoft/dotnet

COPY . /app
WORKDIR /app/UserManagementCore

RUN ["dotnet", "restore"]

EXPOSE 5000

ENTRYPOINT ["dotnet", "run"]