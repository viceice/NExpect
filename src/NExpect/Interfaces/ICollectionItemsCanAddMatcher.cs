using System.Collections.Generic;

namespace NExpect.Interfaces;

/// <summary>
/// Provides a unified interface for matchers which deals with collection items
/// </summary>
/// <typeparam name="T"></typeparam>
public interface ICollectionItemsCanAddMatcher<T> : ICanAddMatcher<IEnumerable<T>>
{
}