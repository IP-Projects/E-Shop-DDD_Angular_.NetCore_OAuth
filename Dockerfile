FROM nosinovacao/dotnet-sonar

ARG linkToRepository
ARG sonarCloudSecret

ENV repo="${linkToRepository}"
ENV sonarSecret="${sonarCloudSecret}"

CMD git clone ${repo}  \
    && dotnet /sonar-scanner/SonarScanner.MSBuild.dll begin \
    /k:E-Shop-DDD_Angular_.NetCore_OAuth /name:E-Shop-DDD_Angular_.NetCore_OAuth /version:1.0.0 /o:iulianoctavianpreda \
    /d:sonar.host.url="https://sonarcloud.io" \
    /d:sonar.login=${sonarSecret} \
    /d:sonar.links.scm=${repo} \
    && dotnet restore E-Shop-DDD_Angular_.NetCore_OAuth/Solution/Solution.sln \
    && dotnet build E-Shop-DDD_Angular_.NetCore_OAuth/Solution/Solution.sln -c Release \
    && dotnet /sonar-scanner/SonarScanner.MSBuild.dll end /d:sonar.login=${sonarSecret}


