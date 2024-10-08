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


namespace Bifrost.NetApi.Generated.Model.orml_xtokens.module
{
    
    
    /// <summary>
    /// >> Call
    /// Contains a variant per dispatchable extrinsic that this pallet has.
    /// </summary>
    public enum Call
    {
        
        /// <summary>
        /// >> transfer
        /// See [`Pallet::transfer`].
        /// </summary>
        transfer = 0,
        
        /// <summary>
        /// >> transfer_multiasset
        /// See [`Pallet::transfer_multiasset`].
        /// </summary>
        transfer_multiasset = 1,
        
        /// <summary>
        /// >> transfer_with_fee
        /// See [`Pallet::transfer_with_fee`].
        /// </summary>
        transfer_with_fee = 2,
        
        /// <summary>
        /// >> transfer_multiasset_with_fee
        /// See [`Pallet::transfer_multiasset_with_fee`].
        /// </summary>
        transfer_multiasset_with_fee = 3,
        
        /// <summary>
        /// >> transfer_multicurrencies
        /// See [`Pallet::transfer_multicurrencies`].
        /// </summary>
        transfer_multicurrencies = 4,
        
        /// <summary>
        /// >> transfer_multiassets
        /// See [`Pallet::transfer_multiassets`].
        /// </summary>
        transfer_multiassets = 5,
    }
    
    /// <summary>
    /// >> 291 - Variant[orml_xtokens.module.Call]
    /// Contains a variant per dispatchable extrinsic that this pallet has.
    /// </summary>
    public sealed class EnumCall : BaseEnumExt<Call, BaseTuple<Bifrost.NetApi.Generated.Model.bifrost_primitives.currency.EnumCurrencyId, Substrate.NetApi.Model.Types.Primitive.U128, Bifrost.NetApi.Generated.Model.xcm.EnumVersionedLocation, Bifrost.NetApi.Generated.Model.xcm.v3.EnumWeightLimit>, BaseTuple<Bifrost.NetApi.Generated.Model.xcm.EnumVersionedAsset, Bifrost.NetApi.Generated.Model.xcm.EnumVersionedLocation, Bifrost.NetApi.Generated.Model.xcm.v3.EnumWeightLimit>, BaseTuple<Bifrost.NetApi.Generated.Model.bifrost_primitives.currency.EnumCurrencyId, Substrate.NetApi.Model.Types.Primitive.U128, Substrate.NetApi.Model.Types.Primitive.U128, Bifrost.NetApi.Generated.Model.xcm.EnumVersionedLocation, Bifrost.NetApi.Generated.Model.xcm.v3.EnumWeightLimit>, BaseTuple<Bifrost.NetApi.Generated.Model.xcm.EnumVersionedAsset, Bifrost.NetApi.Generated.Model.xcm.EnumVersionedAsset, Bifrost.NetApi.Generated.Model.xcm.EnumVersionedLocation, Bifrost.NetApi.Generated.Model.xcm.v3.EnumWeightLimit>, BaseTuple<Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Base.BaseTuple<Bifrost.NetApi.Generated.Model.bifrost_primitives.currency.EnumCurrencyId, Substrate.NetApi.Model.Types.Primitive.U128>>, Substrate.NetApi.Model.Types.Primitive.U32, Bifrost.NetApi.Generated.Model.xcm.EnumVersionedLocation, Bifrost.NetApi.Generated.Model.xcm.v3.EnumWeightLimit>, BaseTuple<Bifrost.NetApi.Generated.Model.xcm.EnumVersionedAssets, Substrate.NetApi.Model.Types.Primitive.U32, Bifrost.NetApi.Generated.Model.xcm.EnumVersionedLocation, Bifrost.NetApi.Generated.Model.xcm.v3.EnumWeightLimit>>
    {
    }
}
