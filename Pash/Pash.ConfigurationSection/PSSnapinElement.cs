using System;
using System.Configuration;

namespace Pash.Configuration
{
	public class PSSnapinElement : ConfigurationElement
	{
		internal const string typePropertyName = "type";

		[ConfigurationProperty("type", IsRequired = true, IsKey = true, IsDefaultCollection = false)]
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
	}
}
