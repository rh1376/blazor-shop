﻿using Pulumi;
using BitTodo.Iac;

public class Program
{
    static Task<int> Main() => Deployment.RunAsync<TdStack>();
}
