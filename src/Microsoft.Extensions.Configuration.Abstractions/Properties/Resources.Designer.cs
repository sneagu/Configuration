// <auto-generated />
namespace Microsoft.Extensions.Configuration
{
    using System.Globalization;
    using System.Reflection;
    using System.Resources;

    internal static class Resources
    {
        private static readonly ResourceManager _resourceManager
            = new ResourceManager("Microsoft.Extensions.Configuration.Abstractions.Resources", typeof(Resources).GetTypeInfo().Assembly);

        /// <summary>
        /// Required configuration value for key '{0}' could not be found.
        /// </summary>
        internal static string Error_RequiredKeyNotFound
        {
            get { return GetString("Error_RequiredKeyNotFound"); }
        }

        /// <summary>
        /// Required configuration value for key '{0}' could not be found.
        /// </summary>
        internal static string FormatError_RequiredKeyNotFound(object p0)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("Error_RequiredKeyNotFound"), p0);
        }

        private static string GetString(string name, params string[] formatterNames)
        {
            var value = _resourceManager.GetString(name);

            System.Diagnostics.Debug.Assert(value != null);

            if (formatterNames != null)
            {
                for (var i = 0; i < formatterNames.Length; i++)
                {
                    value = value.Replace("{" + formatterNames[i] + "}", "{" + i + "}");
                }
            }

            return value;
        }
    }
}
