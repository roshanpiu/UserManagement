FROM microsoft/dotnet

COPY . /app
WORKDIR /app

RUN ["dotnet", "restore"]

EXPOSE 8080

ENTRYPOINT ["dotnet", "run"]