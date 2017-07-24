using System;
using System.Configuration;

namespace Pash.Configuration
{
	public class AliasElement : ConfigurationElement
	{
		internal const string namePropertyName = "name";

		internal const string definitionPropertyName = "definition";

		internal const string scopePropertyName = "scope";

		[ConfigurationProperty("name", IsRequired = true, IsKey = true, IsDefaultCollection = false)]
		public string name
		{
			get
			{
				return (string)base["name"];
			}
		}

		[ConfigurationProperty("definition", IsRequired = true, IsKey = false, IsDefaultCollection = false)]
		public string definition
		{
			get
			{
				return (string)base["definition"];
			}
			set
			{
				base["definition"] = value;
			}
		}

		[ConfigurationProperty("scope", IsRequired = false, IsKey = false, IsDefaultCollection = false, DefaultValue = "global")]
		public string scope
		{
			get
			{
				return (string)base["scope"];
			}
			set
			{
				base["scope"] = value;
			}
		}
	}
}
