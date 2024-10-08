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


namespace Bifrost.NetApi.Generated.Model.lend_market.pallet
{
    
    
    /// <summary>
    /// >> Call
    /// Contains a variant per dispatchable extrinsic that this pallet has.
    /// </summary>
    public enum Call
    {
        
        /// <summary>
        /// >> add_market
        /// See [`Pallet::add_market`].
        /// </summary>
        add_market = 0,
        
        /// <summary>
        /// >> activate_market
        /// See [`Pallet::activate_market`].
        /// </summary>
        activate_market = 1,
        
        /// <summary>
        /// >> update_rate_model
        /// See [`Pallet::update_rate_model`].
        /// </summary>
        update_rate_model = 2,
        
        /// <summary>
        /// >> update_market
        /// See [`Pallet::update_market`].
        /// </summary>
        update_market = 3,
        
        /// <summary>
        /// >> force_update_market
        /// See [`Pallet::force_update_market`].
        /// </summary>
        force_update_market = 4,
        
        /// <summary>
        /// >> add_reward
        /// See [`Pallet::add_reward`].
        /// </summary>
        add_reward = 5,
        
        /// <summary>
        /// >> withdraw_missing_reward
        /// See [`Pallet::withdraw_missing_reward`].
        /// </summary>
        withdraw_missing_reward = 6,
        
        /// <summary>
        /// >> update_market_reward_speed
        /// See [`Pallet::update_market_reward_speed`].
        /// </summary>
        update_market_reward_speed = 7,
        
        /// <summary>
        /// >> claim_reward
        /// See [`Pallet::claim_reward`].
        /// </summary>
        claim_reward = 8,
        
        /// <summary>
        /// >> claim_reward_for_market
        /// See [`Pallet::claim_reward_for_market`].
        /// </summary>
        claim_reward_for_market = 9,
        
        /// <summary>
        /// >> mint
        /// See [`Pallet::mint`].
        /// </summary>
        mint = 10,
        
        /// <summary>
        /// >> redeem
        /// See [`Pallet::redeem`].
        /// </summary>
        redeem = 11,
        
        /// <summary>
        /// >> redeem_all
        /// See [`Pallet::redeem_all`].
        /// </summary>
        redeem_all = 12,
        
        /// <summary>
        /// >> borrow
        /// See [`Pallet::borrow`].
        /// </summary>
        borrow = 13,
        
        /// <summary>
        /// >> repay_borrow
        /// See [`Pallet::repay_borrow`].
        /// </summary>
        repay_borrow = 14,
        
        /// <summary>
        /// >> repay_borrow_all
        /// See [`Pallet::repay_borrow_all`].
        /// </summary>
        repay_borrow_all = 15,
        
        /// <summary>
        /// >> collateral_asset
        /// See [`Pallet::collateral_asset`].
        /// </summary>
        collateral_asset = 16,
        
        /// <summary>
        /// >> liquidate_borrow
        /// See [`Pallet::liquidate_borrow`].
        /// </summary>
        liquidate_borrow = 17,
        
        /// <summary>
        /// >> add_reserves
        /// See [`Pallet::add_reserves`].
        /// </summary>
        add_reserves = 18,
        
        /// <summary>
        /// >> reduce_reserves
        /// See [`Pallet::reduce_reserves`].
        /// </summary>
        reduce_reserves = 19,
        
        /// <summary>
        /// >> reduce_incentive_reserves
        /// See [`Pallet::reduce_incentive_reserves`].
        /// </summary>
        reduce_incentive_reserves = 20,
        
        /// <summary>
        /// >> update_liquidation_free_collateral
        /// See [`Pallet::update_liquidation_free_collateral`].
        /// </summary>
        update_liquidation_free_collateral = 21,
    }
    
    /// <summary>
    /// >> 415 - Variant[lend_market.pallet.Call]
    /// Contains a variant per dispatchable extrinsic that this pallet has.
    /// </summary>
    public sealed class EnumCall : BaseEnumExt<Call, BaseTuple<Bifrost.NetApi.Generated.Model.bifrost_primitives.currency.EnumCurrencyId, Bifrost.NetApi.Generated.Model.lend_market.types.Market>, Bifrost.NetApi.Generated.Model.bifrost_primitives.currency.EnumCurrencyId, BaseTuple<Bifrost.NetApi.Generated.Model.bifrost_primitives.currency.EnumCurrencyId, Bifrost.NetApi.Generated.Model.lend_market.rate_model.EnumInterestRateModel>, BaseTuple<Bifrost.NetApi.Generated.Model.bifrost_primitives.currency.EnumCurrencyId, Substrate.NetApi.Model.Types.Base.BaseOpt<Bifrost.NetApi.Generated.Model.sp_arithmetic.per_things.Permill>, Substrate.NetApi.Model.Types.Base.BaseOpt<Bifrost.NetApi.Generated.Model.sp_arithmetic.per_things.Permill>, Substrate.NetApi.Model.Types.Base.BaseOpt<Bifrost.NetApi.Generated.Model.sp_arithmetic.per_things.Permill>, Substrate.NetApi.Model.Types.Base.BaseOpt<Bifrost.NetApi.Generated.Model.sp_arithmetic.per_things.Permill>, Substrate.NetApi.Model.Types.Base.BaseOpt<Bifrost.NetApi.Generated.Model.sp_arithmetic.per_things.Permill>, Substrate.NetApi.Model.Types.Base.BaseOpt<Bifrost.NetApi.Generated.Model.sp_arithmetic.fixed_point.FixedU128>, Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.NetApi.Model.Types.Primitive.U128>, Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.NetApi.Model.Types.Primitive.U128>>, BaseTuple<Bifrost.NetApi.Generated.Model.bifrost_primitives.currency.EnumCurrencyId, Bifrost.NetApi.Generated.Model.lend_market.types.Market>, Substrate.NetApi.Model.Types.Primitive.U128, BaseTuple<Bifrost.NetApi.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress, Substrate.NetApi.Model.Types.Primitive.U128>, BaseTuple<Bifrost.NetApi.Generated.Model.bifrost_primitives.currency.EnumCurrencyId, Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.NetApi.Model.Types.Primitive.U128>, Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.NetApi.Model.Types.Primitive.U128>>, BaseVoid, Bifrost.NetApi.Generated.Model.bifrost_primitives.currency.EnumCurrencyId, BaseTuple<Bifrost.NetApi.Generated.Model.bifrost_primitives.currency.EnumCurrencyId, Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U128>>, BaseTuple<Bifrost.NetApi.Generated.Model.bifrost_primitives.currency.EnumCurrencyId, Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U128>>, Bifrost.NetApi.Generated.Model.bifrost_primitives.currency.EnumCurrencyId, BaseTuple<Bifrost.NetApi.Generated.Model.bifrost_primitives.currency.EnumCurrencyId, Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U128>>, BaseTuple<Bifrost.NetApi.Generated.Model.bifrost_primitives.currency.EnumCurrencyId, Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U128>>, Bifrost.NetApi.Generated.Model.bifrost_primitives.currency.EnumCurrencyId, BaseTuple<Bifrost.NetApi.Generated.Model.bifrost_primitives.currency.EnumCurrencyId, Substrate.NetApi.Model.Types.Primitive.Bool>, BaseTuple<Bifrost.NetApi.Generated.Model.sp_core.crypto.AccountId32, Bifrost.NetApi.Generated.Model.bifrost_primitives.currency.EnumCurrencyId, Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U128>, Bifrost.NetApi.Generated.Model.bifrost_primitives.currency.EnumCurrencyId>, BaseTuple<Bifrost.NetApi.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress, Bifrost.NetApi.Generated.Model.bifrost_primitives.currency.EnumCurrencyId, Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U128>>, BaseTuple<Bifrost.NetApi.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress, Bifrost.NetApi.Generated.Model.bifrost_primitives.currency.EnumCurrencyId, Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U128>>, BaseTuple<Bifrost.NetApi.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress, Bifrost.NetApi.Generated.Model.bifrost_primitives.currency.EnumCurrencyId, Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U128>>, Substrate.NetApi.Model.Types.Base.BaseVec<Bifrost.NetApi.Generated.Model.bifrost_primitives.currency.EnumCurrencyId>>
    {
    }
}
