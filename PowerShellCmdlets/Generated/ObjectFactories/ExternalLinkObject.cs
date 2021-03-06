// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.externalLink&quot; (or one of its derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.externalLink&quot; (or one of its derived types).</para>
    /// </summary>
    [Cmdlet("New", "ExternalLinkObject", DefaultParameterSetName = @"microsoft.graph.externalLink")]
    [ODataType("microsoft.graph.externalLink")]
    public class New_ExternalLinkObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;href&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.externalLink&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.externalLink", HelpMessage = @"The &quot;href&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String href { get; set; }
    }
}