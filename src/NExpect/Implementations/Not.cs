﻿using NExpect.Interfaces;
// ReSharper disable ClassNeverInstantiated.Global
// ReSharper disable MemberCanBePrivate.Global
// ReSharper disable MemberCanBeProtected.Global
// ReSharper disable VirtualMemberCallInConstructor

namespace NExpect.Implementations
{
    internal class Not<T>: ExpectationContext<T>, INot<T>
    {
        public T Actual { get; }
        public IToAfterNot<T> To => Factory.Create<T, ToAfterNot<T>>(Actual, this);

        public Not(T actual)
        {
            Actual = actual;
            Negate();
        }
    }
}