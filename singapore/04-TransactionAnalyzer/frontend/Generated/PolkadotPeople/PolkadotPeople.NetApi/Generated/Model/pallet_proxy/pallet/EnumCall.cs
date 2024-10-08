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


namespace PolkadotPeople.NetApi.Generated.Model.pallet_proxy.pallet
{
    
    
    /// <summary>
    /// >> Call
    /// Contains a variant per dispatchable extrinsic that this pallet has.
    /// </summary>
    public enum Call
    {
        
        /// <summary>
        /// >> proxy
        /// See [`Pallet::proxy`].
        /// </summary>
        proxy = 0,
        
        /// <summary>
        /// >> add_proxy
        /// See [`Pallet::add_proxy`].
        /// </summary>
        add_proxy = 1,
        
        /// <summary>
        /// >> remove_proxy
        /// See [`Pallet::remove_proxy`].
        /// </summary>
        remove_proxy = 2,
        
        /// <summary>
        /// >> remove_proxies
        /// See [`Pallet::remove_proxies`].
        /// </summary>
        remove_proxies = 3,
        
        /// <summary>
        /// >> create_pure
        /// See [`Pallet::create_pure`].
        /// </summary>
        create_pure = 4,
        
        /// <summary>
        /// >> kill_pure
        /// See [`Pallet::kill_pure`].
        /// </summary>
        kill_pure = 5,
        
        /// <summary>
        /// >> announce
        /// See [`Pallet::announce`].
        /// </summary>
        announce = 6,
        
        /// <summary>
        /// >> remove_announcement
        /// See [`Pallet::remove_announcement`].
        /// </summary>
        remove_announcement = 7,
        
        /// <summary>
        /// >> reject_announcement
        /// See [`Pallet::reject_announcement`].
        /// </summary>
        reject_announcement = 8,
        
        /// <summary>
        /// >> proxy_announced
        /// See [`Pallet::proxy_announced`].
        /// </summary>
        proxy_announced = 9,
    }
    
    /// <summary>
    /// >> 322 - Variant[pallet_proxy.pallet.Call]
    /// Contains a variant per dispatchable extrinsic that this pallet has.
    /// </summary>
    public sealed class EnumCall : BaseEnumExt<Call, BaseTuple<PolkadotPeople.NetApi.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress, Substrate.NetApi.Model.Types.Base.BaseOpt<PolkadotPeople.NetApi.Generated.Model.people_polkadot_runtime.EnumProxyType>, PolkadotPeople.NetApi.Generated.Model.people_polkadot_runtime.EnumRuntimeCall>, BaseTuple<PolkadotPeople.NetApi.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress, PolkadotPeople.NetApi.Generated.Model.people_polkadot_runtime.EnumProxyType, Substrate.NetApi.Model.Types.Primitive.U32>, BaseTuple<PolkadotPeople.NetApi.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress, PolkadotPeople.NetApi.Generated.Model.people_polkadot_runtime.EnumProxyType, Substrate.NetApi.Model.Types.Primitive.U32>, BaseVoid, BaseTuple<PolkadotPeople.NetApi.Generated.Model.people_polkadot_runtime.EnumProxyType, Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Primitive.U16>, BaseTuple<PolkadotPeople.NetApi.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress, PolkadotPeople.NetApi.Generated.Model.people_polkadot_runtime.EnumProxyType, Substrate.NetApi.Model.Types.Primitive.U16, Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U32>, Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U32>>, BaseTuple<PolkadotPeople.NetApi.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress, PolkadotPeople.NetApi.Generated.Model.primitive_types.H256>, BaseTuple<PolkadotPeople.NetApi.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress, PolkadotPeople.NetApi.Generated.Model.primitive_types.H256>, BaseTuple<PolkadotPeople.NetApi.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress, PolkadotPeople.NetApi.Generated.Model.primitive_types.H256>, BaseTuple<PolkadotPeople.NetApi.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress, PolkadotPeople.NetApi.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress, Substrate.NetApi.Model.Types.Base.BaseOpt<PolkadotPeople.NetApi.Generated.Model.people_polkadot_runtime.EnumProxyType>, PolkadotPeople.NetApi.Generated.Model.people_polkadot_runtime.EnumRuntimeCall>>
    {
    }
}
