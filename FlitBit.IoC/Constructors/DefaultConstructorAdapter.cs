﻿#region COPYRIGHT© 2009-2012 Phillip Clark. All rights reserved.
// For licensing information see License.txt (MIT style licensing).
#endregion

namespace FlitBit.IoC.Constructors
{
	/// <summary>
	/// Constructor adapter for types that have a default constructor.
	/// </summary>
	/// <typeparam name="T"></typeparam>
	public sealed class DefaultConstructorAdapter<T> : ConstructorAdapter<T>
		where T: new()
	{
		/// <summary>
		/// Executes the constructor and returns the resulting instance.
		/// </summary>
		/// <param name="container">scoping container</param>
		/// <param name="name">the registered name or null</param>
		/// <param name="parameters">parameters intended for the new instance</param>
		/// <returns>a new instance</returns>
		public override T Execute(IContainer container, string name, params object[] parameters)
		{
			T instance = new T();
			return instance;
		}
	}

	/// <summary>
	/// Constructor adapter for types that have a default constructor.
	/// </summary>
	/// <typeparam name="T">target type T</typeparam>
	/// <typeparam name="C">concrete type C</typeparam>
	public sealed class DefaultConstructorAdapter<T, C> : ConstructorAdapter<T, C>
		where C: T, new()
	{
		/// <summary>
		/// Executes the constructor and returns the resulting instance.
		/// </summary>
		/// <param name="container">scoping container</param>
		/// <param name="name">the registered name or null</param>
		/// <param name="parameters">parameters intended for the new instance</param>
		/// <returns>a new instance</returns>
		public override T Execute(IContainer container, string name, params object[] parameters)
		{
			T instance = new C();
			return instance;
		}
	}
}
