﻿using System;
using Script.Reflection.Container;

namespace Script.Engine
{
    public class TSet<T>
    {
        public TSet() => SetUtils.RegisterSet(this, typeof(T));

        protected TSet(Type InValue)
        {
        }

        ~TSet() => SetUtils.UnRegisterSet(this);

        public void Empty(Int32 InExpectedNumElements = 0) => SetUtils.Set_Empty(this, InExpectedNumElements);

        public Int32 Num() => SetUtils.Set_Num(this);

        public void Add(T InValue) => SetUtils.Set_Add(this, InValue);

        public Int32 Remove(T InValue) => SetUtils.Set_Remove(this, InValue);

        public Boolean Contains(T InValue) => SetUtils.Set_Contains(this, InValue);
    }
}