//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Substrate.NetApi.Model.Types.Base;
using System.Collections.Generic;


namespace Polkadot.NetApi.Generated.Model.polkadot_primitives.v6
{
    
    
    /// <summary>
    /// >> ValidDisputeStatementKind
    /// </summary>
    public enum ValidDisputeStatementKind
    {
        
        /// <summary>
        /// >> Explicit
        /// </summary>
        Explicit = 0,
        
        /// <summary>
        /// >> BackingSeconded
        /// </summary>
        BackingSeconded = 1,
        
        /// <summary>
        /// >> BackingValid
        /// </summary>
        BackingValid = 2,
        
        /// <summary>
        /// >> ApprovalChecking
        /// </summary>
        ApprovalChecking = 3,
        
        /// <summary>
        /// >> ApprovalCheckingMultipleCandidates
        /// </summary>
        ApprovalCheckingMultipleCandidates = 4,
    }
    
    /// <summary>
    /// >> 362 - Variant[polkadot_primitives.v6.ValidDisputeStatementKind]
    /// </summary>
    public sealed class EnumValidDisputeStatementKind : BaseEnumExt<ValidDisputeStatementKind, BaseVoid, Polkadot.NetApi.Generated.Model.primitive_types.H256, Polkadot.NetApi.Generated.Model.primitive_types.H256, BaseVoid, Substrate.NetApi.Model.Types.Base.BaseVec<Polkadot.NetApi.Generated.Model.polkadot_core_primitives.CandidateHash>>
    {
    }
}