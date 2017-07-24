using System;
using System.Configuration;

namespace Pash.Configuration
{
	[ConfigurationCollection(typeof(AliasElement), CollectionType = ConfigurationElementCollectionType.BasicMap, AddItemName = "alias")]
	public class AliasesCollection : ConfigurationElementCollection
	{
		internal const string AliasElementPropertyName = "alias";

		public override ConfigurationElementCollectionType CollectionType
		{
			get
			{
				return ConfigurationElementCollectionType.BasicMap;
			}
		}

		public AliasElement this[int index]
		{
			get
			{
				return (AliasElement)base.BaseGet(index);
			}
		}

		protected override bool IsElementName(string elementName)
		{
			return elementName == "alias";
		}

		protected override object GetElementKey(ConfigurationElement element)
		{
			return ((AliasElement)element).name;
		}

		protected override ConfigurationElement CreateNewElement()
		{
			return new AliasElement();
		}

		public void Add(AliasElement alias)
		{
			base.BaseAdd(alias);
		}

		public void Remove(AliasElement alias)
		{
			base.BaseRemove(alias);
		}
	}
}
