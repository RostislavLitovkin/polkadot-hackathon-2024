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


namespace Bifrost.NetApi.Generated.Model.bifrost_salp.pallet
{
    
    
    /// <summary>
    /// >> Call
    /// Contains a variant per dispatchable extrinsic that this pallet has.
    /// </summary>
    public enum Call
    {
        
        /// <summary>
        /// >> set_multisig_confirm_account
        /// See [`Pallet::set_multisig_confirm_account`].
        /// </summary>
        set_multisig_confirm_account = 0,
        
        /// <summary>
        /// >> fund_success
        /// See [`Pallet::fund_success`].
        /// </summary>
        fund_success = 1,
        
        /// <summary>
        /// >> fund_fail
        /// See [`Pallet::fund_fail`].
        /// </summary>
        fund_fail = 2,
        
        /// <summary>
        /// >> continue_fund
        /// See [`Pallet::continue_fund`].
        /// </summary>
        continue_fund = 3,
        
        /// <summary>
        /// >> fund_retire
        /// See [`Pallet::fund_retire`].
        /// </summary>
        fund_retire = 4,
        
        /// <summary>
        /// >> fund_end
        /// See [`Pallet::fund_end`].
        /// </summary>
        fund_end = 5,
        
        /// <summary>
        /// >> create
        /// See [`Pallet::create`].
        /// </summary>
        create = 6,
        
        /// <summary>
        /// >> edit
        /// See [`Pallet::edit`].
        /// </summary>
        edit = 7,
        
        /// <summary>
        /// >> contribute
        /// See [`Pallet::contribute`].
        /// </summary>
        contribute = 8,
        
        /// <summary>
        /// >> confirm_contribute
        /// See [`Pallet::confirm_contribute`].
        /// </summary>
        confirm_contribute = 9,
        
        /// <summary>
        /// >> unlock
        /// See [`Pallet::unlock`].
        /// </summary>
        unlock = 10,
        
        /// <summary>
        /// >> unlock_by_vsbond
        /// See [`Pallet::unlock_by_vsbond`].
        /// </summary>
        unlock_by_vsbond = 11,
        
        /// <summary>
        /// >> unlock_vstoken
        /// See [`Pallet::unlock_vstoken`].
        /// </summary>
        unlock_vstoken = 12,
        
        /// <summary>
        /// >> batch_unlock
        /// See [`Pallet::batch_unlock`].
        /// </summary>
        batch_unlock = 13,
        
        /// <summary>
        /// >> withdraw
        /// See [`Pallet::withdraw`].
        /// </summary>
        withdraw = 14,
        
        /// <summary>
        /// >> refund
        /// See [`Pallet::refund`].
        /// </summary>
        refund = 15,
        
        /// <summary>
        /// >> redeem
        /// See [`Pallet::redeem`].
        /// </summary>
        redeem = 16,
        
        /// <summary>
        /// >> dissolve_refunded
        /// See [`Pallet::dissolve_refunded`].
        /// </summary>
        dissolve_refunded = 17,
        
        /// <summary>
        /// >> dissolve
        /// See [`Pallet::dissolve`].
        /// </summary>
        dissolve = 18,
        
        /// <summary>
        /// >> buyback
        /// See [`Pallet::buyback`].
        /// </summary>
        buyback = 19,
        
        /// <summary>
        /// >> confirm_contribution
        /// See [`Pallet::confirm_contribution`].
        /// </summary>
        confirm_contribution = 20,
        
        /// <summary>
        /// >> buyback_vstoken_by_stable_pool
        /// See [`Pallet::buyback_vstoken_by_stable_pool`].
        /// </summary>
        buyback_vstoken_by_stable_pool = 21,
        
        /// <summary>
        /// >> reserve
        /// See [`Pallet::reserve`].
        /// </summary>
        reserve = 22,
        
        /// <summary>
        /// >> batch_handle_reserve
        /// See [`Pallet::batch_handle_reserve`].
        /// </summary>
        batch_handle_reserve = 23,
        
        /// <summary>
        /// >> cancel_reservation
        /// See [`Pallet::cancel_reservation`].
        /// </summary>
        cancel_reservation = 24,
    }
    
    /// <summary>
    /// >> 312 - Variant[bifrost_salp.pallet.Call]
    /// Contains a variant per dispatchable extrinsic that this pallet has.
    /// </summary>
    public sealed class EnumCall : BaseEnumExt<Call, Bifrost.NetApi.Generated.Model.sp_core.crypto.AccountId32, Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U32>, Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U32>, BaseTuple<Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U32>, Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U32>, Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U32>>, Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U32>, Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U32>, BaseTuple<Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U32>, Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U128>, Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U32>, Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U32>>, BaseTuple<Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U32>, Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U128>, Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U128>, Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U32>, Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U32>, Substrate.NetApi.Model.Types.Base.BaseOpt<Bifrost.NetApi.Generated.Model.bifrost_salp.EnumFundStatus>>, BaseTuple<Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U32>, Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U128>>, BaseTuple<Substrate.NetApi.Model.Types.Primitive.U64, Substrate.NetApi.Model.Types.Primitive.Bool>, BaseTuple<Bifrost.NetApi.Generated.Model.sp_core.crypto.AccountId32, Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U32>>, BaseTuple<Bifrost.NetApi.Generated.Model.sp_core.crypto.AccountId32, Bifrost.NetApi.Generated.Model.bifrost_primitives.currency.EnumCurrencyId>, Bifrost.NetApi.Generated.Model.sp_core.crypto.AccountId32, Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U32>, Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U32>, BaseTuple<Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U32>, Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U32>, Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U32>, Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U128>>, BaseTuple<Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U32>, Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U128>>, BaseTuple<Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U32>, Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U32>, Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U32>>, Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U32>, Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U128>, BaseTuple<Substrate.NetApi.Model.Types.Primitive.U64, Bifrost.NetApi.Generated.Model.staging_xcm.v4.EnumResponse>, BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Bifrost.NetApi.Generated.Model.bifrost_primitives.currency.EnumCurrencyId, Substrate.NetApi.Model.Types.Primitive.U128>, BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Primitive.U128, Substrate.NetApi.Model.Types.Primitive.Bool>, Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Primitive.U32>
    {
    }
}
