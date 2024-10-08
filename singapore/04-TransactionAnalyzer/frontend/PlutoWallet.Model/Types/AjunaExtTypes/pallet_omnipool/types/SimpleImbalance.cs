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


namespace Substrate.NetApi.Generated.Model.pallet_omnipool.types
{
    
    
    /// <summary>
    /// >> 435 - Composite[pallet_omnipool.types.SimpleImbalance]
    /// </summary>
    [SubstrateNodeType(TypeDefEnum.Composite)]
    public sealed class SimpleImbalance : BaseType
    {
        
        /// <summary>
        /// >> value
        /// </summary>
        private Substrate.NetApi.Model.Types.Primitive.U128 _value;
        
        /// <summary>
        /// >> negative
        /// </summary>
        private Substrate.NetApi.Model.Types.Primitive.Bool _negative;
        
        public Substrate.NetApi.Model.Types.Primitive.U128 Value
        {
            get
            {
                return this._value;
            }
            set
            {
                this._value = value;
            }
        }
        
        public Substrate.NetApi.Model.Types.Primitive.Bool Negative
        {
            get
            {
                return this._negative;
            }
            set
            {
                this._negative = value;
            }
        }
        
        public override string TypeName()
        {
            return "SimpleImbalance";
        }
        
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(Value.Encode());
            result.AddRange(Negative.Encode());
            return result.ToArray();
        }
        
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            Value = new Substrate.NetApi.Model.Types.Primitive.U128();
            Value.Decode(byteArray, ref p);
            Negative = new Substrate.NetApi.Model.Types.Primitive.Bool();
            Negative.Decode(byteArray, ref p);
            var bytesLength = p - start;
            TypeSize = bytesLength;
            Bytes = new byte[bytesLength];
            System.Array.Copy(byteArray, start, Bytes, 0, bytesLength);
        }
    }
}
