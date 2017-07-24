using System;
using System.Configuration;

namespace Pash.Configuration
{
	[ConfigurationCollection(typeof(VariableElement), CollectionType = ConfigurationElementCollectionType.BasicMap, AddItemName = "variable")]
	public class VariablesCollection : ConfigurationElementCollection
	{
		internal const string VariableElementPropertyName = "variable";

		public override ConfigurationElementCollectionType CollectionType
		{
			get
			{
				return ConfigurationElementCollectionType.BasicMap;
			}
		}

		public VariableElement this[int index]
		{
			get
			{
				return (VariableElement)base.BaseGet(index);
			}
		}

		protected override bool IsElementName(string elementName)
		{
			return elementName == "variable";
		}

		protected override object GetElementKey(ConfigurationElement element)
		{
			return ((VariableElement)element).name;
		}

		protected override ConfigurationElement CreateNewElement()
		{
			return new VariableElement();
		}

		public void Add(VariableElement variable)
		{
			base.BaseAdd(variable);
		}

		public void Remove(VariableElement variable)
		{
			base.BaseRemove(variable);
		}
	}
}
