// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.


internal class TestCultureModule
{
    [System.Runtime.CompilerServices.ModuleInitializer()]
    internal static void Init()
    {
        var culture = new System.Globalization.CultureInfo("en-US");
        System.Globalization.CultureInfo.DefaultThreadCurrentCulture = culture;
        System.Globalization.CultureInfo.DefaultThreadCurrentUICulture = culture;

        var thrnead = System.Threading.Thread.CurrentThread;
        thrnead.CurrentCulture = culture;
        thrnead.CurrentUICulture = culture;

    }
}

#if NET5_0_OR_GREATER
#else
namespace System.Runtime.CompilerServices
{
    [global::System.AttributeUsage(global::System.AttributeTargets.Method, Inherited = false)]
    [global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
    internal sealed class ModuleInitializerAttribute : global::System.Attribute
    {
    }
}
#endif
