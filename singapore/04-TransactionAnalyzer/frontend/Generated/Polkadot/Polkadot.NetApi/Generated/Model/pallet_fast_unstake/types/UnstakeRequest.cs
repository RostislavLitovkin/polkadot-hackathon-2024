//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Substrate.NetApi.Attributes;
using Substrate.NetApi.Model.Types.Base;
using Substrate.NetApi.Model.Types.Metadata.V14;
using System.Collections.Generic;


namespace Polkadot.NetApi.Generated.Model.pallet_fast_unstake.types
{
    
    
    /// <summary>
    /// >> 740 - Composite[pallet_fast_unstake.types.UnstakeRequest]
    /// </summary>
    [SubstrateNodeType(TypeDefEnum.Composite)]
    public sealed class UnstakeRequest : BaseType
    {
        
        /// <summary>
        /// >> stashes
        /// </summary>
        public Polkadot.NetApi.Generated.Model.bounded_collections.bounded_vec.BoundedVecT39 Stashes { get; set; }
        /// <summary>
        /// >> checked
        /// </summary>
        public Polkadot.NetApi.Generated.Model.bounded_collections.bounded_vec.BoundedVecT40 Checked { get; set; }
        
        /// <inheritdoc/>
        public override string TypeName()
        {
            return "UnstakeRequest";
        }
        
        /// <inheritdoc/>
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(Stashes.Encode());
            result.AddRange(Checked.Encode());
            return result.ToArray();
        }
        
        /// <inheritdoc/>
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            Stashes = new Polkadot.NetApi.Generated.Model.bounded_collections.bounded_vec.BoundedVecT39();
            Stashes.Decode(byteArray, ref p);
            Checked = new Polkadot.NetApi.Generated.Model.bounded_collections.bounded_vec.BoundedVecT40();
            Checked.Decode(byteArray, ref p);
            var bytesLength = p - start;
            TypeSize = bytesLength;
            Bytes = new byte[bytesLength];
            global::System.Array.Copy(byteArray, start, Bytes, 0, bytesLength);
        }
    }
}
