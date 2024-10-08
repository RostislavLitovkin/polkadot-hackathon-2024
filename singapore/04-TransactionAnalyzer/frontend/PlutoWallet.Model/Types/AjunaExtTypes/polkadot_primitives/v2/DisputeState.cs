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


namespace Substrate.NetApi.Generated.Model.polkadot_primitives.v2
{
    
    
    /// <summary>
    /// >> 701 - Composite[polkadot_primitives.v2.DisputeState]
    /// </summary>
    [SubstrateNodeType(TypeDefEnum.Composite)]
    public sealed class DisputeState : BaseType
    {
        
        /// <summary>
        /// >> validators_for
        /// </summary>
        private Substrate.NetApi.Model.Types.Base.BaseBitSeq<Substrate.NetApi.Model.Types.Primitive.U8, Substrate.NetApi.Generated.Model.bitvec.order.Lsb0> _validatorsFor;
        
        /// <summary>
        /// >> validators_against
        /// </summary>
        private Substrate.NetApi.Model.Types.Base.BaseBitSeq<Substrate.NetApi.Model.Types.Primitive.U8, Substrate.NetApi.Generated.Model.bitvec.order.Lsb0> _validatorsAgainst;
        
        /// <summary>
        /// >> start
        /// </summary>
        private Substrate.NetApi.Model.Types.Primitive.U32 _start;
        
        /// <summary>
        /// >> concluded_at
        /// </summary>
        private Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.NetApi.Model.Types.Primitive.U32> _concludedAt;
        
        public Substrate.NetApi.Model.Types.Base.BaseBitSeq<Substrate.NetApi.Model.Types.Primitive.U8, Substrate.NetApi.Generated.Model.bitvec.order.Lsb0> ValidatorsFor
        {
            get
            {
                return this._validatorsFor;
            }
            set
            {
                this._validatorsFor = value;
            }
        }
        
        public Substrate.NetApi.Model.Types.Base.BaseBitSeq<Substrate.NetApi.Model.Types.Primitive.U8, Substrate.NetApi.Generated.Model.bitvec.order.Lsb0> ValidatorsAgainst
        {
            get
            {
                return this._validatorsAgainst;
            }
            set
            {
                this._validatorsAgainst = value;
            }
        }
        
        public Substrate.NetApi.Model.Types.Primitive.U32 Start
        {
            get
            {
                return this._start;
            }
            set
            {
                this._start = value;
            }
        }
        
        public Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.NetApi.Model.Types.Primitive.U32> ConcludedAt
        {
            get
            {
                return this._concludedAt;
            }
            set
            {
                this._concludedAt = value;
            }
        }
        
        public override string TypeName()
        {
            return "DisputeState";
        }
        
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(ValidatorsFor.Encode());
            result.AddRange(ValidatorsAgainst.Encode());
            result.AddRange(Start.Encode());
            result.AddRange(ConcludedAt.Encode());
            return result.ToArray();
        }
        
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            ValidatorsFor = new Substrate.NetApi.Model.Types.Base.BaseBitSeq<Substrate.NetApi.Model.Types.Primitive.U8, Substrate.NetApi.Generated.Model.bitvec.order.Lsb0>();
            ValidatorsFor.Decode(byteArray, ref p);
            ValidatorsAgainst = new Substrate.NetApi.Model.Types.Base.BaseBitSeq<Substrate.NetApi.Model.Types.Primitive.U8, Substrate.NetApi.Generated.Model.bitvec.order.Lsb0>();
            ValidatorsAgainst.Decode(byteArray, ref p);
            Start = new Substrate.NetApi.Model.Types.Primitive.U32();
            Start.Decode(byteArray, ref p);
            ConcludedAt = new Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.NetApi.Model.Types.Primitive.U32>();
            ConcludedAt.Decode(byteArray, ref p);
            TypeSize = p - start;
        }
    }
}
