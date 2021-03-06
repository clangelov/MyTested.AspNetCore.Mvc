﻿namespace MyTested.AspNetCore.Mvc.Builders.Contracts.Base
{
    public interface IBaseTestBuilderWithComponentShouldHaveTestBuilder<TBuilder> : IBaseTestBuilder
        where TBuilder : IBaseTestBuilder
    {
    }
}
