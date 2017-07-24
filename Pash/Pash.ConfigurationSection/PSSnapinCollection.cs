using System;
using System.Configuration;

namespace Pash.Configuration
{
	[ConfigurationCollection(typeof(PSSnapinElement), CollectionType = ConfigurationElementCollectionType.BasicMapAlternate, AddItemName = "psSnapin")]
	public class PSSnapinCollection : ConfigurationElementCollection
	{
		internal const string PSSnapinElementPropertyName = "psSnapin";

		public override ConfigurationElementCollectionType CollectionType
		{
			get
			{
				return ConfigurationElementCollectionType.BasicMapAlternate;
			}
		}

		public PSSnapinElement this[int index]
		{
			get
			{
				return (PSSnapinElement)base.BaseGet(index);
			}
		}

		protected override bool IsElementName(string elementName)
		{
			return elementName == "psSnapin";
		}

		protected override object GetElementKey(ConfigurationElement element)
		{
			return ((PSSnapinElement)element).type;
		}

		protected override ConfigurationElement CreateNewElement()
		{
			return new PSSnapinElement();
		}

		public void Add(PSSnapinElement psSnapin)
		{
			base.BaseAdd(psSnapin);
		}

		public void Remove(PSSnapinElement psSnapin)
		{
			base.BaseRemove(psSnapin);
		}
	}
}
