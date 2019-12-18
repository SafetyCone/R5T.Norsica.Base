using System;


namespace R5T.Norsica
{
    /// <summary>
    /// An operator that performs the same services as the "dotnet" executable.
    /// </summary>
    public interface IDotnetOperator
    {
        void CreateNewSolutionFile(string solutionDirectoryPath, string solutionName);
        void CreateNewProjectFile(string projectTemplateShortName, string projectDirectoryPath, string projectName);

        void AddProjectFileToSolutionFile(string solutionFilePath, string projectFilePath);
    }
}
