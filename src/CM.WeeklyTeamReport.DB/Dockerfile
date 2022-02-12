FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
CMD ls
COPY ["CM.WeeklyTeamReport.DB.csproj", "CM.WeeklyTeamReport.DB.csproj"]
RUN dotnet restore "CM.WeeklyTeamReport.DB.csproj"
COPY . .
RUN dotnet build "CM.WeeklyTeamReport.DB.csproj"

ENTRYPOINT ["dotnet", "publish", "/src/CM.WeeklyTeamReport.DB.csproj", \
	"/p:TargetServerName=$TargetServerName", \
	"/p:TargetDatabaseName=$TargetDatabaseName", \
	"/p:TargetUser=$TargetUser", \
	"/p:TargetPassword=$TargetPassword"]
