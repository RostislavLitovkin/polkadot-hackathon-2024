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


namespace Substrate.NetApi.Generated.Model.pallet_elections_phragmen
{
    
    
    /// <summary>
    /// >> 550 - Composite[pallet_elections_phragmen.SeatHolder]
    /// </summary>
    [SubstrateNodeType(TypeDefEnum.Composite)]
    public sealed class SeatHolder : BaseType
    {
        
        /// <summary>
        /// >> who
        /// </summary>
        private Substrate.NetApi.Generated.Model.sp_core.crypto.AccountId32 _who;
        
        /// <summary>
        /// >> stake
        /// </summary>
        private Substrate.NetApi.Model.Types.Primitive.U128 _stake;
        
        /// <summary>
        /// >> deposit
        /// </summary>
        private Substrate.NetApi.Model.Types.Primitive.U128 _deposit;
        
        public Substrate.NetApi.Generated.Model.sp_core.crypto.AccountId32 Who
        {
            get
            {
                return this._who;
            }
            set
            {
                this._who = value;
            }
        }
        
        public Substrate.NetApi.Model.Types.Primitive.U128 Stake
        {
            get
            {
                return this._stake;
            }
            set
            {
                this._stake = value;
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
            return "SeatHolder";
        }
        
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(Who.Encode());
            result.AddRange(Stake.Encode());
            result.AddRange(Deposit.Encode());
            return result.ToArray();
        }
        
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            Who = new Substrate.NetApi.Generated.Model.sp_core.crypto.AccountId32();
            Who.Decode(byteArray, ref p);
            Stake = new Substrate.NetApi.Model.Types.Primitive.U128();
            Stake.Decode(byteArray, ref p);
            Deposit = new Substrate.NetApi.Model.Types.Primitive.U128();
            Deposit.Decode(byteArray, ref p);
            TypeSize = p - start;
        }
    }
}
