﻿namespace BitTodo.Shared.Services.Contracts;

public interface IDateTimeProvider
{
    DateTimeOffset GetCurrentDateTime();
}
