FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["src/CM.WeeklyTeamReport.DB/CM.WeeklyTeamReport.DB.csproj", "scr/CM.WeeklyTeamReport.DB.csproj"]
RUN dotnet restore "src/CM.WeeklyTeamReport.DB.csproj"
COPY . .
RUN dotnet build "src/CM.WeeklyTeamReport.DB.csproj"

ENTRYPOINT ["dotnet", "publish", "/src/CM.WeeklyTeamReport.DB.csproj", \
	"/p:TargetServerName=$TargetServerName", \
	"/p:TargetDatabaseName=$TargetDatabaseName", \
	"/p:TargetUser=$TargetUser", \
	"/p:TargetPassword=$TargetPassword"]
