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


namespace Substrate.NetApi.Generated.Model.orml_tokens.module
{
    
    
    public enum Error
    {
        
        BalanceTooLow = 0,
        
        AmountIntoBalanceFailed = 1,
        
        LiquidityRestrictions = 2,
        
        MaxLocksExceeded = 3,
        
        KeepAlive = 4,
        
        ExistentialDeposit = 5,
        
        DeadAccount = 6,
        
        TooManyReserves = 7,
    }
    
    /// <summary>
    /// >> 486 - Variant[orml_tokens.module.Error]
    /// 
    ///			Custom [dispatch errors](https://docs.substrate.io/main-docs/build/events-errors/)
    ///			of this pallet.
    ///			
    /// </summary>
    public sealed class EnumError : BaseEnum<Error>
    {
    }
}
