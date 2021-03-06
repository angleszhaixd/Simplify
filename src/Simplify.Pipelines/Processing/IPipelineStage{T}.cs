﻿namespace Simplify.Pipelines.Processing
{
	/// <summary>
	/// Represent pipeline stage
	/// </summary>
	/// <typeparam name="T"></typeparam>
	public interface IPipelineStage<in T>
	{
		/// <summary>
		/// Process the specified item.
		/// </summary>
		/// <param name="item">The item.</param>
		/// <returns></returns>
		bool Execute(T item);
	}
}