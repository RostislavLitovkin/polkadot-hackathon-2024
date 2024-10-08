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


namespace Substrate.NetApi.Generated.Model.frame_system.limits
{
    
    
    /// <summary>
    /// >> 165 - Composite[frame_system.limits.BlockWeights]
    /// </summary>
    [SubstrateNodeType(TypeDefEnum.Composite)]
    public sealed class BlockWeights : BaseType
    {
        
        /// <summary>
        /// >> base_block
        /// </summary>
        private Substrate.NetApi.Generated.Model.sp_weights.weight_v2.Weight _baseBlock;
        
        /// <summary>
        /// >> max_block
        /// </summary>
        private Substrate.NetApi.Generated.Model.sp_weights.weight_v2.Weight _maxBlock;
        
        /// <summary>
        /// >> per_class
        /// </summary>
        private Substrate.NetApi.Generated.Model.frame_support.dispatch.PerDispatchClassT2 _perClass;
        
        public Substrate.NetApi.Generated.Model.sp_weights.weight_v2.Weight BaseBlock
        {
            get
            {
                return this._baseBlock;
            }
            set
            {
                this._baseBlock = value;
            }
        }
        
        public Substrate.NetApi.Generated.Model.sp_weights.weight_v2.Weight MaxBlock
        {
            get
            {
                return this._maxBlock;
            }
            set
            {
                this._maxBlock = value;
            }
        }
        
        public Substrate.NetApi.Generated.Model.frame_support.dispatch.PerDispatchClassT2 PerClass
        {
            get
            {
                return this._perClass;
            }
            set
            {
                this._perClass = value;
            }
        }
        
        public override string TypeName()
        {
            return "BlockWeights";
        }
        
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(BaseBlock.Encode());
            result.AddRange(MaxBlock.Encode());
            result.AddRange(PerClass.Encode());
            return result.ToArray();
        }
        
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            BaseBlock = new Substrate.NetApi.Generated.Model.sp_weights.weight_v2.Weight();
            BaseBlock.Decode(byteArray, ref p);
            MaxBlock = new Substrate.NetApi.Generated.Model.sp_weights.weight_v2.Weight();
            MaxBlock.Decode(byteArray, ref p);
            PerClass = new Substrate.NetApi.Generated.Model.frame_support.dispatch.PerDispatchClassT2();
            PerClass.Decode(byteArray, ref p);
            TypeSize = p - start;
        }
    }
}
