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


namespace Bifrost.NetApi.Generated.Model.bifrost_slpx.pallet
{
    
    
    /// <summary>
    /// >> Call
    /// Contains a variant per dispatchable extrinsic that this pallet has.
    /// </summary>
    public enum Call
    {
        
        /// <summary>
        /// >> mint
        /// See [`Pallet::mint`].
        /// </summary>
        mint = 0,
        
        /// <summary>
        /// >> zenlink_swap
        /// See [`Pallet::zenlink_swap`].
        /// </summary>
        zenlink_swap = 1,
        
        /// <summary>
        /// >> redeem
        /// See [`Pallet::redeem`].
        /// </summary>
        redeem = 2,
        
        /// <summary>
        /// >> stable_pool_swap
        /// See [`Pallet::stable_pool_swap`].
        /// </summary>
        stable_pool_swap = 3,
        
        /// <summary>
        /// >> add_whitelist
        /// See [`Pallet::add_whitelist`].
        /// </summary>
        add_whitelist = 4,
        
        /// <summary>
        /// >> remove_whitelist
        /// See [`Pallet::remove_whitelist`].
        /// </summary>
        remove_whitelist = 5,
        
        /// <summary>
        /// >> set_execution_fee
        /// See [`Pallet::set_execution_fee`].
        /// </summary>
        set_execution_fee = 6,
        
        /// <summary>
        /// >> set_transfer_to_fee
        /// See [`Pallet::set_transfer_to_fee`].
        /// </summary>
        set_transfer_to_fee = 7,
        
        /// <summary>
        /// >> set_currency_ethereum_call_switch
        /// See [`Pallet::set_currency_ethereum_call_switch`].
        /// </summary>
        set_currency_ethereum_call_switch = 8,
        
        /// <summary>
        /// >> set_ethereum_call_configration
        /// See [`Pallet::set_ethereum_call_configration`].
        /// </summary>
        set_ethereum_call_configration = 9,
        
        /// <summary>
        /// >> set_currency_support_xcm_fee
        /// See [`Pallet::set_currency_support_xcm_fee`].
        /// </summary>
        set_currency_support_xcm_fee = 10,
        
        /// <summary>
        /// >> set_delay_block
        /// See [`Pallet::set_delay_block`].
        /// </summary>
        set_delay_block = 11,
        
        /// <summary>
        /// >> force_add_order
        /// See [`Pallet::force_add_order`].
        /// </summary>
        force_add_order = 12,
        
        /// <summary>
        /// >> mint_with_channel_id
        /// See [`Pallet::mint_with_channel_id`].
        /// </summary>
        mint_with_channel_id = 13,
    }
    
    /// <summary>
    /// >> 398 - Variant[bifrost_slpx.pallet.Call]
    /// Contains a variant per dispatchable extrinsic that this pallet has.
    /// </summary>
    public sealed class EnumCall : BaseEnumExt<Call, BaseTuple<Bifrost.NetApi.Generated.Model.primitive_types.H160, Bifrost.NetApi.Generated.Model.bifrost_primitives.currency.EnumCurrencyId, Bifrost.NetApi.Generated.Model.bifrost_slpx.types.EnumTargetChain, Bifrost.NetApi.Generated.Model.bounded_collections.bounded_vec.BoundedVecT7>, BaseTuple<Bifrost.NetApi.Generated.Model.primitive_types.H160, Bifrost.NetApi.Generated.Model.bifrost_primitives.currency.EnumCurrencyId, Bifrost.NetApi.Generated.Model.bifrost_primitives.currency.EnumCurrencyId, Substrate.NetApi.Model.Types.Primitive.U128, Bifrost.NetApi.Generated.Model.bifrost_slpx.types.EnumTargetChain>, BaseTuple<Bifrost.NetApi.Generated.Model.primitive_types.H160, Bifrost.NetApi.Generated.Model.bifrost_primitives.currency.EnumCurrencyId, Bifrost.NetApi.Generated.Model.bifrost_slpx.types.EnumTargetChain>, BaseTuple<Bifrost.NetApi.Generated.Model.primitive_types.H160, Substrate.NetApi.Model.Types.Primitive.U32, Bifrost.NetApi.Generated.Model.bifrost_primitives.currency.EnumCurrencyId, Bifrost.NetApi.Generated.Model.bifrost_primitives.currency.EnumCurrencyId, Substrate.NetApi.Model.Types.Primitive.U128, Bifrost.NetApi.Generated.Model.bifrost_slpx.types.EnumTargetChain>, BaseTuple<Bifrost.NetApi.Generated.Model.bifrost_slpx.types.EnumSupportChain, Bifrost.NetApi.Generated.Model.sp_core.crypto.AccountId32>, BaseTuple<Bifrost.NetApi.Generated.Model.bifrost_slpx.types.EnumSupportChain, Bifrost.NetApi.Generated.Model.sp_core.crypto.AccountId32>, BaseTuple<Bifrost.NetApi.Generated.Model.bifrost_primitives.currency.EnumCurrencyId, Substrate.NetApi.Model.Types.Primitive.U128>, BaseTuple<Bifrost.NetApi.Generated.Model.bifrost_slpx.types.EnumSupportChain, Substrate.NetApi.Model.Types.Primitive.U128>, BaseTuple<Bifrost.NetApi.Generated.Model.bifrost_primitives.currency.EnumCurrencyId, Substrate.NetApi.Model.Types.Primitive.Bool>, BaseTuple<Substrate.NetApi.Model.Types.Primitive.U128, Bifrost.NetApi.Generated.Model.sp_weights.weight_v2.Weight, Substrate.NetApi.Model.Types.Primitive.U32, Bifrost.NetApi.Generated.Model.primitive_types.H160>, BaseTuple<Bifrost.NetApi.Generated.Model.bifrost_primitives.currency.EnumCurrencyId, Substrate.NetApi.Model.Types.Primitive.Bool>, Substrate.NetApi.Model.Types.Primitive.U32, BaseTuple<Bifrost.NetApi.Generated.Model.sp_core.crypto.AccountId32, Bifrost.NetApi.Generated.Model.primitive_types.H160, Bifrost.NetApi.Generated.Model.bifrost_primitives.currency.EnumCurrencyId, Bifrost.NetApi.Generated.Model.bifrost_slpx.types.EnumTargetChain, Bifrost.NetApi.Generated.Model.bounded_collections.bounded_vec.BoundedVecT7, Bifrost.NetApi.Generated.Model.bifrost_slpx.types.EnumOrderType>, BaseTuple<Bifrost.NetApi.Generated.Model.primitive_types.H160, Bifrost.NetApi.Generated.Model.bifrost_primitives.currency.EnumCurrencyId, Bifrost.NetApi.Generated.Model.bifrost_slpx.types.EnumTargetChain, Bifrost.NetApi.Generated.Model.bounded_collections.bounded_vec.BoundedVecT7, Substrate.NetApi.Model.Types.Primitive.U32>>
    {
    }
}
