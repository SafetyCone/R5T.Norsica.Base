using System;

using R5T.Angleterria;


namespace R5T.Norsica
{
    public static class IDotnetOperatorExtensions
    {
        public static void Publish(this IDotnetOperator dotnetOperator, string projectFilePath, string outputDirectoryPath, string buildConfigurationName)
        {
            var frameworkName = NetCoreAppV2_2.FrameworkName;

            dotnetOperator.Publish(projectFilePath, outputDirectoryPath, buildConfigurationName, frameworkName);
        }

        public static void Publish(this IDotnetOperator dotnetOperator, string projectFilePath, string outputDirectoryPath)
        {
            var buildConfigurationName = ReleaseBuildConfiguration.BuildConfigurationName;

            dotnetOperator.Publish(projectFilePath, outputDirectoryPath, buildConfigurationName);
        }
    }
}
