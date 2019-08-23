FROM microsoft/dotnet:2.1.4-aspnetcore-runtime
WORKDIR /app
EXPOSE 80
COPY ./dist/ .
ENTRYPOINT ["dotnet", "DXC.LM.Core.ReferenceDataAPI.Endpoints.dll"]

ARG application
ARG version
ARG gitcommithash
ARG branchname
ARG buildnumber


LABEL com.dxc.devops.application $application
LABEL com.dxc.devops.version $version
LABEL com.dxc.devops.commit $gitcommithash
LABEL com.dxc.devops.branch $branchname
LABEL com.dxc.devops.build $buildnumber
