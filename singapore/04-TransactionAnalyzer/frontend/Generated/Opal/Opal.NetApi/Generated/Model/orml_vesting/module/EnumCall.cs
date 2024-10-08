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


namespace Opal.NetApi.Generated.Model.orml_vesting.module
{
    
    
    /// <summary>
    /// >> Call
    /// Contains a variant per dispatchable extrinsic that this pallet has.
    /// </summary>
    public enum Call
    {
        
        /// <summary>
        /// >> claim
        /// See [`Pallet::claim`].
        /// </summary>
        claim = 0,
        
        /// <summary>
        /// >> vested_transfer
        /// See [`Pallet::vested_transfer`].
        /// </summary>
        vested_transfer = 1,
        
        /// <summary>
        /// >> update_vesting_schedules
        /// See [`Pallet::update_vesting_schedules`].
        /// </summary>
        update_vesting_schedules = 2,
        
        /// <summary>
        /// >> claim_for
        /// See [`Pallet::claim_for`].
        /// </summary>
        claim_for = 3,
    }
    
    /// <summary>
    /// >> 123 - Variant[orml_vesting.module.Call]
    /// Contains a variant per dispatchable extrinsic that this pallet has.
    /// </summary>
    public sealed class EnumCall : BaseEnumExt<Call, BaseVoid, BaseTuple<Opal.NetApi.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress, Opal.NetApi.Generated.Model.orml_vesting.VestingSchedule>, BaseTuple<Opal.NetApi.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress, Substrate.NetApi.Model.Types.Base.BaseVec<Opal.NetApi.Generated.Model.orml_vesting.VestingSchedule>>, Opal.NetApi.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress>
    {
    }
}
