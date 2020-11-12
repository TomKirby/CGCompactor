using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using CodingGameCompactor.Service;

namespace CodingGameCompactor.UI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            string solutionPath = GetSolutionPathValue(args);
            string[] exclusionDirectories = GetExclusionDirectories();

            CodeCompactor compactor = new CodeCompactor(solutionPath,exclusionDirectories);

            Application.Run(new CodeCompactorForm(compactor));
        }

        private static string[] GetExclusionDirectories()
        {
            var configExclusionDirs = ConfigurationManager.AppSettings["exclusionDirectories"];

            if (!string.IsNullOrEmpty(configExclusionDirs))
            {
                return configExclusionDirs.Split(',');
            }
            else
            {
                return new string[0];
            }
        }

        private static string GetSolutionPathValue(string[] args)
        {
            //Favor the Solution Path being provided through arguments.
            if (args.Length == 1)
            {
                return args[0];
            }

            var configSolutionPath = ConfigurationManager.AppSettings["solutionPath"];

            if (!string.IsNullOrEmpty(configSolutionPath))
            {
                return configSolutionPath;
            }
            else
            {
                throw new ConfigurationErrorsException("No Solution Path was provided in the app.config file!");
            }
        }
    }
}
