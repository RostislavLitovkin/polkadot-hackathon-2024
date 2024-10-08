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


namespace Substrate.NetApi.Generated.Model.pallet_assets.types
{
    
    
    /// <summary>
    /// >> 344 - Composite[pallet_assets.types.Approval]
    /// </summary>
    [SubstrateNodeType(TypeDefEnum.Composite)]
    public sealed class Approval : BaseType
    {
        
        /// <summary>
        /// >> amount
        /// </summary>
        private Substrate.NetApi.Model.Types.Primitive.U128 _amount;
        
        /// <summary>
        /// >> deposit
        /// </summary>
        private Substrate.NetApi.Model.Types.Primitive.U128 _deposit;
        
        public Substrate.NetApi.Model.Types.Primitive.U128 Amount
        {
            get
            {
                return this._amount;
            }
            set
            {
                this._amount = value;
            }
        }
        
        public Substrate.NetApi.Model.Types.Primitive.U128 Deposit
        {
            get
            {
                return this._deposit;
            }
            set
            {
                this._deposit = value;
            }
        }
        
        public override string TypeName()
        {
            return "Approval";
        }
        
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(Amount.Encode());
            result.AddRange(Deposit.Encode());
            return result.ToArray();
        }
        
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            Amount = new Substrate.NetApi.Model.Types.Primitive.U128();
            Amount.Decode(byteArray, ref p);
            Deposit = new Substrate.NetApi.Model.Types.Primitive.U128();
            Deposit.Decode(byteArray, ref p);
            TypeSize = p - start;
        }
    }
}
