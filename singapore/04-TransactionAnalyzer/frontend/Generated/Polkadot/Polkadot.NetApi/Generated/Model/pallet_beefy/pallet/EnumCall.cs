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


namespace Polkadot.NetApi.Generated.Model.pallet_beefy.pallet
{
    
    
    /// <summary>
    /// >> Call
    /// Contains a variant per dispatchable extrinsic that this pallet has.
    /// </summary>
    public enum Call
    {
        
        /// <summary>
        /// >> report_equivocation
        /// See [`Pallet::report_equivocation`].
        /// </summary>
        report_equivocation = 0,
        
        /// <summary>
        /// >> report_equivocation_unsigned
        /// See [`Pallet::report_equivocation_unsigned`].
        /// </summary>
        report_equivocation_unsigned = 1,
        
        /// <summary>
        /// >> set_new_genesis
        /// See [`Pallet::set_new_genesis`].
        /// </summary>
        set_new_genesis = 2,
    }
    
    /// <summary>
    /// >> 470 - Variant[pallet_beefy.pallet.Call]
    /// Contains a variant per dispatchable extrinsic that this pallet has.
    /// </summary>
    public sealed class EnumCall : BaseEnumExt<Call, BaseTuple<Polkadot.NetApi.Generated.Model.sp_consensus_beefy.EquivocationProof, Polkadot.NetApi.Generated.Model.sp_session.MembershipProof>, BaseTuple<Polkadot.NetApi.Generated.Model.sp_consensus_beefy.EquivocationProof, Polkadot.NetApi.Generated.Model.sp_session.MembershipProof>, Substrate.NetApi.Model.Types.Primitive.U32>
    {
    }
}
