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


namespace Substrate.NetApi.Generated.Model.pallet_identity.pallet
{
    
    
    public enum Error
    {
        
        TooManySubAccounts = 0,
        
        NotFound = 1,
        
        NotNamed = 2,
        
        EmptyIndex = 3,
        
        FeeChanged = 4,
        
        NoIdentity = 5,
        
        StickyJudgement = 6,
        
        JudgementGiven = 7,
        
        InvalidJudgement = 8,
        
        InvalidIndex = 9,
        
        InvalidTarget = 10,
        
        TooManyFields = 11,
        
        TooManyRegistrars = 12,
        
        AlreadyClaimed = 13,
        
        NotSub = 14,
        
        NotOwned = 15,
        
        JudgementForDifferentIdentity = 16,
        
        JudgementPaymentFailed = 17,
    }
    
    /// <summary>
    /// >> 577 - Variant[pallet_identity.pallet.Error]
    /// 
    ///			Custom [dispatch errors](https://docs.substrate.io/main-docs/build/events-errors/)
    ///			of this pallet.
    ///			
    /// </summary>
    public sealed class EnumError : BaseEnum<Error>
    {
    }
}
