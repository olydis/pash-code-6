using System;
using System.Configuration;

namespace Pash.Configuration
{
	public class VariableElement : ConfigurationElement
	{
		internal const string namePropertyName = "name";

		internal const string typePropertyName = "type";

		internal const string valuePropertyName = "value";

		internal const string scopePropertyName = "scope";

		[ConfigurationProperty("name", IsRequired = true, IsKey = true, IsDefaultCollection = false)]
		public string name
		{
			get
			{
				return (string)base["name"];
			}
		}

		[ConfigurationProperty("type", IsRequired = false, IsKey = false, IsDefaultCollection = false, DefaultValue = "System.String")]
		public string type
		{
			get
			{
				return (string)base["type"];
			}
			set
			{
				base["type"] = value;
			}
		}

		[ConfigurationProperty("value", IsRequired = false, IsKey = false, IsDefaultCollection = false, DefaultValue = null)]
		public string value
		{
			get
			{
				return (string)base["value"];
			}
			set
			{
				base["value"] = value;
			}
		}

		[ConfigurationProperty("scope", IsRequired = false, IsKey = false, IsDefaultCollection = false, DefaultValue = "global")]
		public string scope
		{
			get
			{
				return (string)base["scope"];
			}
		}
	}
}
