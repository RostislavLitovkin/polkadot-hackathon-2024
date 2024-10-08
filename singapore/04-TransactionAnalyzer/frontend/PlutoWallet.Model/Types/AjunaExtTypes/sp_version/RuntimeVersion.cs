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


namespace Substrate.NetApi.Generated.Model.sp_version
{
    
    
    /// <summary>
    /// >> 172 - Composite[sp_version.RuntimeVersion]
    /// </summary>
    [SubstrateNodeType(TypeDefEnum.Composite)]
    public sealed class RuntimeVersion : BaseType
    {
        
        /// <summary>
        /// >> spec_name
        /// </summary>
        private Substrate.NetApi.Model.Types.Primitive.Str _specName;
        
        /// <summary>
        /// >> impl_name
        /// </summary>
        private Substrate.NetApi.Model.Types.Primitive.Str _implName;
        
        /// <summary>
        /// >> authoring_version
        /// </summary>
        private Substrate.NetApi.Model.Types.Primitive.U32 _authoringVersion;
        
        /// <summary>
        /// >> spec_version
        /// </summary>
        private Substrate.NetApi.Model.Types.Primitive.U32 _specVersion;
        
        /// <summary>
        /// >> impl_version
        /// </summary>
        private Substrate.NetApi.Model.Types.Primitive.U32 _implVersion;
        
        /// <summary>
        /// >> apis
        /// </summary>
        private Substrate.NetApi.Generated.Types.Base.Cow _apis;
        
        /// <summary>
        /// >> transaction_version
        /// </summary>
        private Substrate.NetApi.Model.Types.Primitive.U32 _transactionVersion;
        
        /// <summary>
        /// >> state_version
        /// </summary>
        private Substrate.NetApi.Model.Types.Primitive.U8 _stateVersion;
        
        public Substrate.NetApi.Model.Types.Primitive.Str SpecName
        {
            get
            {
                return this._specName;
            }
            set
            {
                this._specName = value;
            }
        }
        
        public Substrate.NetApi.Model.Types.Primitive.Str ImplName
        {
            get
            {
                return this._implName;
            }
            set
            {
                this._implName = value;
            }
        }
        
        public Substrate.NetApi.Model.Types.Primitive.U32 AuthoringVersion
        {
            get
            {
                return this._authoringVersion;
            }
            set
            {
                this._authoringVersion = value;
            }
        }
        
        public Substrate.NetApi.Model.Types.Primitive.U32 SpecVersion
        {
            get
            {
                return this._specVersion;
            }
            set
            {
                this._specVersion = value;
            }
        }
        
        public Substrate.NetApi.Model.Types.Primitive.U32 ImplVersion
        {
            get
            {
                return this._implVersion;
            }
            set
            {
                this._implVersion = value;
            }
        }
        
        public Substrate.NetApi.Generated.Types.Base.Cow Apis
        {
            get
            {
                return this._apis;
            }
            set
            {
                this._apis = value;
            }
        }
        
        public Substrate.NetApi.Model.Types.Primitive.U32 TransactionVersion
        {
            get
            {
                return this._transactionVersion;
            }
            set
            {
                this._transactionVersion = value;
            }
        }
        
        public Substrate.NetApi.Model.Types.Primitive.U8 StateVersion
        {
            get
            {
                return this._stateVersion;
            }
            set
            {
                this._stateVersion = value;
            }
        }
        
        public override string TypeName()
        {
            return "RuntimeVersion";
        }
        
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(SpecName.Encode());
            result.AddRange(ImplName.Encode());
            result.AddRange(AuthoringVersion.Encode());
            result.AddRange(SpecVersion.Encode());
            result.AddRange(ImplVersion.Encode());
            result.AddRange(Apis.Encode());
            result.AddRange(TransactionVersion.Encode());
            result.AddRange(StateVersion.Encode());
            return result.ToArray();
        }
        
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            SpecName = new Substrate.NetApi.Model.Types.Primitive.Str();
            SpecName.Decode(byteArray, ref p);
            ImplName = new Substrate.NetApi.Model.Types.Primitive.Str();
            ImplName.Decode(byteArray, ref p);
            AuthoringVersion = new Substrate.NetApi.Model.Types.Primitive.U32();
            AuthoringVersion.Decode(byteArray, ref p);
            SpecVersion = new Substrate.NetApi.Model.Types.Primitive.U32();
            SpecVersion.Decode(byteArray, ref p);
            ImplVersion = new Substrate.NetApi.Model.Types.Primitive.U32();
            ImplVersion.Decode(byteArray, ref p);
            Apis = new Substrate.NetApi.Generated.Types.Base.Cow();
            Apis.Decode(byteArray, ref p);
            TransactionVersion = new Substrate.NetApi.Model.Types.Primitive.U32();
            TransactionVersion.Decode(byteArray, ref p);
            StateVersion = new Substrate.NetApi.Model.Types.Primitive.U8();
            StateVersion.Decode(byteArray, ref p);
            TypeSize = p - start;
        }
    }
}
