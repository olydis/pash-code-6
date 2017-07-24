using System;
using System.Configuration;

namespace Pash.Configuration
{
	public class ExecutionContextConfigurationSection : ConfigurationSection
	{
		internal const string PSSnapinsPropertyName = "psSnapins";

		internal const string FunctionsPropertyName = "functions";

		internal const string AliasesPropertyName = "aliases";

		internal const string VariablesPropertyName = "variables";

		internal const string ExecutionContextConfigurationSectionSectionName = "defaultExecutionContext";

		internal const string XmlnsPropertyName = "xmlns";

		[ConfigurationProperty("psSnapins", IsRequired = false, IsKey = false, IsDefaultCollection = false)]
		public PSSnapinCollection PSSnapins
		{
			get
			{
				return (PSSnapinCollection)base["psSnapins"];
			}
			set
			{
				base["psSnapins"] = value;
			}
		}

		[ConfigurationProperty("functions", IsRequired = false, IsKey = false, IsDefaultCollection = false)]
		public FunctionsCollection Functions
		{
			get
			{
				return (FunctionsCollection)base["functions"];
			}
			set
			{
				base["functions"] = value;
			}
		}

		[ConfigurationProperty("aliases", IsRequired = false, IsKey = false, IsDefaultCollection = false)]
		public AliasesCollection Aliases
		{
			get
			{
				return (AliasesCollection)base["aliases"];
			}
			set
			{
				base["aliases"] = value;
			}
		}

		[ConfigurationProperty("variables", IsRequired = false, IsKey = false, IsDefaultCollection = false)]
		public VariablesCollection Variables
		{
			get
			{
				return (VariablesCollection)base["variables"];
			}
			set
			{
				base["variables"] = value;
			}
		}

		public static ExecutionContextConfigurationSection Instance
		{
			get
			{
				return ConfigurationManager.GetSection("defaultExecutionContext") as ExecutionContextConfigurationSection;
			}
		}

		[ConfigurationProperty("xmlns", IsRequired = false, IsKey = false, IsDefaultCollection = false)]
		public string Xmlns
		{
			get
			{
				return (string)base["xmlns"];
			}
		}
	}
}
