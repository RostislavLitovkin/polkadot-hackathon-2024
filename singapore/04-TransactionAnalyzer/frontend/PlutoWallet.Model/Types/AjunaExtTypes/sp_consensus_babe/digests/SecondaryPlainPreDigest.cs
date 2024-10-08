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


namespace Substrate.NetApi.Generated.Model.sp_consensus_babe.digests
{
    
    
    /// <summary>
    /// >> 464 - Composite[sp_consensus_babe.digests.SecondaryPlainPreDigest]
    /// </summary>
    [SubstrateNodeType(TypeDefEnum.Composite)]
    public sealed class SecondaryPlainPreDigest : BaseType
    {
        
        /// <summary>
        /// >> authority_index
        /// </summary>
        private Substrate.NetApi.Model.Types.Primitive.U32 _authorityIndex;
        
        /// <summary>
        /// >> slot
        /// </summary>
        private Substrate.NetApi.Generated.Model.sp_consensus_slots.Slot _slot;
        
        public Substrate.NetApi.Model.Types.Primitive.U32 AuthorityIndex
        {
            get
            {
                return this._authorityIndex;
            }
            set
            {
                this._authorityIndex = value;
            }
        }
        
        public Substrate.NetApi.Generated.Model.sp_consensus_slots.Slot Slot
        {
            get
            {
                return this._slot;
            }
            set
            {
                this._slot = value;
            }
        }
        
        public override string TypeName()
        {
            return "SecondaryPlainPreDigest";
        }
        
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(AuthorityIndex.Encode());
            result.AddRange(Slot.Encode());
            return result.ToArray();
        }
        
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            AuthorityIndex = new Substrate.NetApi.Model.Types.Primitive.U32();
            AuthorityIndex.Decode(byteArray, ref p);
            Slot = new Substrate.NetApi.Generated.Model.sp_consensus_slots.Slot();
            Slot.Decode(byteArray, ref p);
            TypeSize = p - start;
        }
    }
}
