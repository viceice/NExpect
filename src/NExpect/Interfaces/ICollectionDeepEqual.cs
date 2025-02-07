﻿using System.Collections.Generic;

namespace NExpect.Interfaces;

/// <summary>
/// Provides the Alt. syntax for Deep Equality testing
/// </summary>
/// <typeparam name="T">Collection item type</typeparam>
public interface ICollectionDeepEqual<T>: ICanAddMatcher<IEnumerable<T>>
{
}