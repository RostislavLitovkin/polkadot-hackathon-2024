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


namespace Bifrost.NetApi.Generated.Model.sp_runtime.multiaddress
{
    
    
    /// <summary>
    /// >> MultiAddress
    /// </summary>
    public enum MultiAddress
    {
        
        /// <summary>
        /// >> Id
        /// </summary>
        Id = 0,
        
        /// <summary>
        /// >> Index
        /// </summary>
        Index = 1,
        
        /// <summary>
        /// >> Raw
        /// </summary>
        Raw = 2,
        
        /// <summary>
        /// >> Address32
        /// </summary>
        Address32 = 3,
        
        /// <summary>
        /// >> Address20
        /// </summary>
        Address20 = 4,
    }
    
    /// <summary>
    /// >> 65 - Variant[sp_runtime.multiaddress.MultiAddress]
    /// </summary>
    public sealed class EnumMultiAddress : BaseEnumExt<MultiAddress, Bifrost.NetApi.Generated.Model.sp_core.crypto.AccountId32, Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U32>, Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Primitive.U8>, Bifrost.NetApi.Generated.Types.Base.Arr32U8, Bifrost.NetApi.Generated.Types.Base.Arr20U8>
    {
    }
}
