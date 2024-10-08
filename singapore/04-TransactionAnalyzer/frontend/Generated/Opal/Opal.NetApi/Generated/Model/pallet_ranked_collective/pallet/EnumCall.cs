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


namespace Opal.NetApi.Generated.Model.pallet_ranked_collective.pallet
{
    
    
    /// <summary>
    /// >> Call
    /// Contains a variant per dispatchable extrinsic that this pallet has.
    /// </summary>
    public enum Call
    {
        
        /// <summary>
        /// >> add_member
        /// See [`Pallet::add_member`].
        /// </summary>
        add_member = 0,
        
        /// <summary>
        /// >> promote_member
        /// See [`Pallet::promote_member`].
        /// </summary>
        promote_member = 1,
        
        /// <summary>
        /// >> demote_member
        /// See [`Pallet::demote_member`].
        /// </summary>
        demote_member = 2,
        
        /// <summary>
        /// >> remove_member
        /// See [`Pallet::remove_member`].
        /// </summary>
        remove_member = 3,
        
        /// <summary>
        /// >> vote
        /// See [`Pallet::vote`].
        /// </summary>
        vote = 4,
        
        /// <summary>
        /// >> cleanup_poll
        /// See [`Pallet::cleanup_poll`].
        /// </summary>
        cleanup_poll = 5,
    }
    
    /// <summary>
    /// >> 205 - Variant[pallet_ranked_collective.pallet.Call]
    /// Contains a variant per dispatchable extrinsic that this pallet has.
    /// </summary>
    public sealed class EnumCall : BaseEnumExt<Call, Opal.NetApi.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress, Opal.NetApi.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress, Opal.NetApi.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress, BaseTuple<Opal.NetApi.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress, Substrate.NetApi.Model.Types.Primitive.U16>, BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Primitive.Bool>, BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Primitive.U32>>
    {
    }
}
