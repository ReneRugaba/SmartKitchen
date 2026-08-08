FROM mcr.microsoft.com/dotnet/aspnet:10.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM node:22-bookworm-slim AS node

FROM --platform=$BUILDPLATFORM mcr.microsoft.com/dotnet/sdk:10.0 AS build
ARG TARGETARCH
ENV DOTNET_CLI_TELEMETRY_OPTOUT=1 \
    NUGET_XMLDOC_MODE=skip
WORKDIR /src

COPY --from=node /usr/local/bin/node /usr/local/bin/node
COPY --from=node /usr/local/lib/node_modules /usr/local/lib/node_modules
RUN ln -s /usr/local/lib/node_modules/npm/bin/npm-cli.js /usr/local/bin/npm \
    && npm install -g npm@latest \
    && node --version && npm --version

COPY ["src/MyProject.Admin/MyProject.Admin.csproj", "src/MyProject.Admin/"]
COPY ["src/MyProject.Admin.EntityFramework.Identity/MyProject.Admin.EntityFramework.Identity.csproj", "src/MyProject.Admin.EntityFramework.Identity/"]
COPY ["src/MyProject.Admin.EntityFramework/MyProject.Admin.EntityFramework.csproj", "src/MyProject.Admin.EntityFramework/"]
COPY ["src/MyProject.Admin.EntityFramework.Extensions/MyProject.Admin.EntityFramework.Extensions.csproj", "src/MyProject.Admin.EntityFramework.Extensions/"]
COPY ["src/MyProject.Admin.EntityFramework.Configuration/MyProject.Admin.EntityFramework.Configuration.csproj", "src/MyProject.Admin.EntityFramework.Configuration/"]
COPY ["src/MyProject.Admin.UI/MyProject.Admin.UI.csproj", "src/MyProject.Admin.UI/"]
COPY ["src/MyProject.Shared.Configuration/MyProject.Shared.Configuration.csproj", "src/MyProject.Shared.Configuration/"]
COPY ["src/MyProject.Admin.EntityFramework.Shared/MyProject.Admin.EntityFramework.Shared.csproj", "src/MyProject.Admin.EntityFramework.Shared/"]

RUN dotnet restore -a $TARGETARCH "src/MyProject.Admin/MyProject.Admin.csproj"

COPY . .
WORKDIR "/src/src/MyProject.Admin"
RUN dotnet build -a $TARGETARCH "MyProject.Admin.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish -a $TARGETARCH "MyProject.Admin.csproj" -c Release --no-restore -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENV ASPNETCORE_FORWARDEDHEADERS_ENABLED=true
ENTRYPOINT ["dotnet", "MyProject.Admin.dll"]
