using System;
using System.Collections.Generic;
using System.Text;

namespace MSBuild.Community.Tasks.Subversion
{
    public class SvnExport : SvnClient
    {
        public SvnExport()
        {
            base.Command = "export";
        }

        protected override bool ValidateParameters()
        {
            if (string.IsNullOrEmpty(base.RepositoryPath))
            {
                Log.LogError(MSBuild.Community.Tasks.Properties.Resources.ParameterRequired, "SvnCheckout", "RepositoryPath");
                return false;
            }
            return base.ValidateParameters();
        }

    }
}