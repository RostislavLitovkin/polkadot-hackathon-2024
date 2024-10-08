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


namespace Substrate.NetApi.Generated.Model.pallet_omnipool.pallet
{
    
    
    public enum Call
    {
        
        initialize_pool = 0,
        
        add_token = 1,
        
        add_liquidity = 2,
        
        remove_liquidity = 3,
        
        sacrifice_position = 4,
        
        sell = 5,
        
        buy = 6,
        
        set_asset_tradable_state = 7,
        
        refund_refused_asset = 8,
        
        set_asset_weight_cap = 9,
        
        set_tvl_cap = 10,
    }
    
    /// <summary>
    /// >> 274 - Variant[pallet_omnipool.pallet.Call]
    /// Contains one variant per dispatchable that can be called by an extrinsic.
    /// </summary>
    public sealed class EnumCall : BaseEnumExt<Call, BaseTuple<Substrate.NetApi.Generated.Model.sp_arithmetic.fixed_point.FixedU128, Substrate.NetApi.Generated.Model.sp_arithmetic.fixed_point.FixedU128, Substrate.NetApi.Generated.Model.sp_arithmetic.per_things.Permill, Substrate.NetApi.Generated.Model.sp_arithmetic.per_things.Permill>, BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Generated.Model.sp_arithmetic.fixed_point.FixedU128, Substrate.NetApi.Generated.Model.sp_arithmetic.per_things.Permill, Substrate.NetApi.Generated.Model.sp_core.crypto.AccountId32>, BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Primitive.U128>, BaseTuple<Substrate.NetApi.Model.Types.Primitive.U128, Substrate.NetApi.Model.Types.Primitive.U128>, Substrate.NetApi.Model.Types.Primitive.U128, BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Primitive.U128, Substrate.NetApi.Model.Types.Primitive.U128>, BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Primitive.U128, Substrate.NetApi.Model.Types.Primitive.U128>, BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Generated.Model.pallet_omnipool.types.Tradability>, BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Primitive.U128, Substrate.NetApi.Generated.Model.sp_core.crypto.AccountId32>, BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Generated.Model.sp_arithmetic.per_things.Permill>, Substrate.NetApi.Model.Types.Primitive.U128>
    {
    }
}
