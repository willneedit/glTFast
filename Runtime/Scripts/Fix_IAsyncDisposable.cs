/*
 * Copyright (c) 2023, willneedit
 * 
 * Licensed by the Mozilla Public License 2.0,
 * residing in the LICENSE.md file in the project's root directory.
 */

/*
 * UGLY HACK for this...
 * 
 * https://github.com/atteneder/glTFast/issues/584
 * 
 * We *need* the Microsoft.Bcl.AsyncInterfaces.dll plugin for another purpose,
 * and the fixup from https://github.com/dotnet/roslyn/issues/45111 remedies this.
 * 
 * Note that Visual Studio thinks that the code would be conditioned out -- but it's live,
 * even in the GltfImport.cs's 'await using' snippet.
 */

#if UNITY_2021_3_OR_NEWER && NET_STANDARD_2_1

namespace System
{
    public enum IAsyncDisposable
    {
    }
}

#endif
