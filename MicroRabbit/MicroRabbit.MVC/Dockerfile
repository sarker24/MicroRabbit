FROM microsoft/dotnet:2.2-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM microsoft/dotnet:2.2-sdk AS build
WORKDIR /src
COPY ["MicroRabbit.MVC/MicroRabbit.MVC.csproj", "MicroRabbit.MVC/"]
RUN dotnet restore "MicroRabbit.MVC/MicroRabbit.MVC.csproj"
COPY . .
WORKDIR "/src/MicroRabbit.MVC"
RUN dotnet build "MicroRabbit.MVC.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "MicroRabbit.MVC.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "MicroRabbit.MVC.dll"]