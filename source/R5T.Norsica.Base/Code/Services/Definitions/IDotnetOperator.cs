using System;


namespace R5T.Norsica
{
    /// <summary>
    /// An operator that performs the same services as the "dotnet" executable.
    /// </summary>
    public interface IDotnetOperator
    {
        void AddProjectFileToSolutionFile(string solutionFilePath, string projectFilePath);

        void CreateNewSolutionFile(string solutionDirectoryPath, string solutionName);
        void CreateNewProjectFile(string projectTemplateShortName, string projectDirectoryPath, string projectName);

        void Publish(string projectFilePath, string outputDirectoryPath, string buildConfigurationName, string frameworkName);
    }
}
