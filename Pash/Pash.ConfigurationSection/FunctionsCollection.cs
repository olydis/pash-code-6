using System;
using System.Configuration;

namespace Pash.Configuration
{
	[ConfigurationCollection(typeof(FunctionElement), CollectionType = ConfigurationElementCollectionType.BasicMap, AddItemName = "function")]
	public class FunctionsCollection : ConfigurationElementCollection
	{
		internal const string FunctionElementPropertyName = "function";

		public override ConfigurationElementCollectionType CollectionType
		{
			get
			{
				return ConfigurationElementCollectionType.BasicMap;
			}
		}

		public FunctionElement this[int index]
		{
			get
			{
				return (FunctionElement)base.BaseGet(index);
			}
		}

		protected override bool IsElementName(string elementName)
		{
			return elementName == "function";
		}

		protected override object GetElementKey(ConfigurationElement element)
		{
			return ((FunctionElement)element).name;
		}

		protected override ConfigurationElement CreateNewElement()
		{
			return new FunctionElement();
		}

		public void Add(FunctionElement function)
		{
			base.BaseAdd(function);
		}

		public void Remove(FunctionElement function)
		{
			base.BaseRemove(function);
		}
	}
}
