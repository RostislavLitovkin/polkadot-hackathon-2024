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


namespace Hydration.NetApi.Generated.Model.pallet_elections_phragmen
{
    
    
    /// <summary>
    /// >> Renouncing
    /// </summary>
    public enum Renouncing
    {
        
        /// <summary>
        /// >> Member
        /// </summary>
        Member = 0,
        
        /// <summary>
        /// >> RunnerUp
        /// </summary>
        RunnerUp = 1,
        
        /// <summary>
        /// >> Candidate
        /// </summary>
        Candidate = 2,
    }
    
    /// <summary>
    /// >> 341 - Variant[pallet_elections_phragmen.Renouncing]
    /// </summary>
    public sealed class EnumRenouncing : BaseEnumExt<Renouncing, BaseVoid, BaseVoid, Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U32>>
    {
    }
}
