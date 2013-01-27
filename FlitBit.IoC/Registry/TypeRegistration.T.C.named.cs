﻿#region COPYRIGHT© 2009-2012 Phillip Clark. All rights reserved.
// For licensing information see License.txt (MIT style licensing).
#endregion

using System;

namespace FlitBit.IoC.Registry
{
	internal sealed class NamedTypeRegistration<T, C> : TypeRegistration<T, C>, INamedTypeRegistration<T>
		where C : class, T
	{
		public NamedTypeRegistration(IContainer container, string name, Param[] parameters)
			: base(container, parameters)
		{
			if (name == null) throw new ArgumentNullException("name");
			if (name.Length == 0) throw new ArgumentException("name cannot be empty", "name");

			base.IsNamed = true;
			this.Name = name;
		}

		public string Name { get; private set; }
	}
}
