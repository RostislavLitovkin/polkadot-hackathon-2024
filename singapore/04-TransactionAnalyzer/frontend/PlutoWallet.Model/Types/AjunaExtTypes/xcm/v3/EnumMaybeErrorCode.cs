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


namespace Substrate.NetApi.Generated.Model.xcm.v3
{
    
    
    /// <summary>
    /// >> MaybeErrorCode
    /// </summary>
    public enum MaybeErrorCode
    {
        
        /// <summary>
        /// >> Success
        /// </summary>
        Success = 0,
        
        /// <summary>
        /// >> Error
        /// </summary>
        Error = 1,
        
        /// <summary>
        /// >> TruncatedError
        /// </summary>
        TruncatedError = 2,
    }
    
    /// <summary>
    /// >> 425 - Variant[xcm.v3.MaybeErrorCode]
    /// </summary>
    public sealed class EnumMaybeErrorCode : BaseEnumExt<MaybeErrorCode, BaseVoid, Substrate.NetApi.Generated.Model.bounded_collections.bounded_vec.BoundedVecT10, Substrate.NetApi.Generated.Model.bounded_collections.bounded_vec.BoundedVecT10>
    {
    }
}
