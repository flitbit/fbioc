﻿#region COPYRIGHT© 2009-2013 Phillip Clark. All rights reserved.
// For licensing information see License.txt (MIT style licensing).
#endregion


namespace FlitBit.IoC.Constructors
{
	/// <summary>
	/// Adapter for constructors defined on concrete type C of type T
	/// </summary>
	/// <typeparam name="T">type T</typeparam>
	/// <typeparam name="C">concrete type C</typeparam>
	public abstract partial class ConstructorAdapter<T, C> : ConstructorAdapter<T>
		where C: T
	{
		/// <summary>
		/// Creates a new instance.
		/// </summary>
		public ConstructorAdapter()
		{
		}
	}
}
