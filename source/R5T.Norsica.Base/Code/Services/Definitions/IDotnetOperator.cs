using System;

using R5T.T0064;


namespace R5T.Norsica
{
    /// <summary>
    /// An operator that performs the same services as the "dotnet" executable.
    /// </summary>
    [ServiceDefinitionMarker]
    public interface IDotnetOperator : IServiceDefinition
    {
        void AddProjectFileToSolutionFile(string solutionFilePath, string projectFilePath);

        void CreateNewSolutionFile(string solutionDirectoryPath, string solutionName);
        void CreateNewProjectFile(string projectTemplateShortName, string projectDirectoryPath, string projectName);

        void Publish(string projectFilePath, string outputDirectoryPath, string buildConfigurationName, string frameworkName);
    }
}
