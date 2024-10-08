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


namespace Bajun.NetApi.Generated.Model.staging_xcm.v4
{
    
    
    /// <summary>
    /// >> Instruction
    /// </summary>
    public enum Instruction
    {
        
        /// <summary>
        /// >> WithdrawAsset
        /// </summary>
        WithdrawAsset = 0,
        
        /// <summary>
        /// >> ReserveAssetDeposited
        /// </summary>
        ReserveAssetDeposited = 1,
        
        /// <summary>
        /// >> ReceiveTeleportedAsset
        /// </summary>
        ReceiveTeleportedAsset = 2,
        
        /// <summary>
        /// >> QueryResponse
        /// </summary>
        QueryResponse = 3,
        
        /// <summary>
        /// >> TransferAsset
        /// </summary>
        TransferAsset = 4,
        
        /// <summary>
        /// >> TransferReserveAsset
        /// </summary>
        TransferReserveAsset = 5,
        
        /// <summary>
        /// >> Transact
        /// </summary>
        Transact = 6,
        
        /// <summary>
        /// >> HrmpNewChannelOpenRequest
        /// </summary>
        HrmpNewChannelOpenRequest = 7,
        
        /// <summary>
        /// >> HrmpChannelAccepted
        /// </summary>
        HrmpChannelAccepted = 8,
        
        /// <summary>
        /// >> HrmpChannelClosing
        /// </summary>
        HrmpChannelClosing = 9,
        
        /// <summary>
        /// >> ClearOrigin
        /// </summary>
        ClearOrigin = 10,
        
        /// <summary>
        /// >> DescendOrigin
        /// </summary>
        DescendOrigin = 11,
        
        /// <summary>
        /// >> ReportError
        /// </summary>
        ReportError = 12,
        
        /// <summary>
        /// >> DepositAsset
        /// </summary>
        DepositAsset = 13,
        
        /// <summary>
        /// >> DepositReserveAsset
        /// </summary>
        DepositReserveAsset = 14,
        
        /// <summary>
        /// >> ExchangeAsset
        /// </summary>
        ExchangeAsset = 15,
        
        /// <summary>
        /// >> InitiateReserveWithdraw
        /// </summary>
        InitiateReserveWithdraw = 16,
        
        /// <summary>
        /// >> InitiateTeleport
        /// </summary>
        InitiateTeleport = 17,
        
        /// <summary>
        /// >> ReportHolding
        /// </summary>
        ReportHolding = 18,
        
        /// <summary>
        /// >> BuyExecution
        /// </summary>
        BuyExecution = 19,
        
        /// <summary>
        /// >> RefundSurplus
        /// </summary>
        RefundSurplus = 20,
        
        /// <summary>
        /// >> SetErrorHandler
        /// </summary>
        SetErrorHandler = 21,
        
        /// <summary>
        /// >> SetAppendix
        /// </summary>
        SetAppendix = 22,
        
        /// <summary>
        /// >> ClearError
        /// </summary>
        ClearError = 23,
        
        /// <summary>
        /// >> ClaimAsset
        /// </summary>
        ClaimAsset = 24,
        
        /// <summary>
        /// >> Trap
        /// </summary>
        Trap = 25,
        
        /// <summary>
        /// >> SubscribeVersion
        /// </summary>
        SubscribeVersion = 26,
        
        /// <summary>
        /// >> UnsubscribeVersion
        /// </summary>
        UnsubscribeVersion = 27,
        
        /// <summary>
        /// >> BurnAsset
        /// </summary>
        BurnAsset = 28,
        
        /// <summary>
        /// >> ExpectAsset
        /// </summary>
        ExpectAsset = 29,
        
        /// <summary>
        /// >> ExpectOrigin
        /// </summary>
        ExpectOrigin = 30,
        
        /// <summary>
        /// >> ExpectError
        /// </summary>
        ExpectError = 31,
        
        /// <summary>
        /// >> ExpectTransactStatus
        /// </summary>
        ExpectTransactStatus = 32,
        
        /// <summary>
        /// >> QueryPallet
        /// </summary>
        QueryPallet = 33,
        
        /// <summary>
        /// >> ExpectPallet
        /// </summary>
        ExpectPallet = 34,
        
        /// <summary>
        /// >> ReportTransactStatus
        /// </summary>
        ReportTransactStatus = 35,
        
        /// <summary>
        /// >> ClearTransactStatus
        /// </summary>
        ClearTransactStatus = 36,
        
        /// <summary>
        /// >> UniversalOrigin
        /// </summary>
        UniversalOrigin = 37,
        
        /// <summary>
        /// >> ExportMessage
        /// </summary>
        ExportMessage = 38,
        
        /// <summary>
        /// >> LockAsset
        /// </summary>
        LockAsset = 39,
        
        /// <summary>
        /// >> UnlockAsset
        /// </summary>
        UnlockAsset = 40,
        
        /// <summary>
        /// >> NoteUnlockable
        /// </summary>
        NoteUnlockable = 41,
        
        /// <summary>
        /// >> RequestUnlock
        /// </summary>
        RequestUnlock = 42,
        
        /// <summary>
        /// >> SetFeesMode
        /// </summary>
        SetFeesMode = 43,
        
        /// <summary>
        /// >> SetTopic
        /// </summary>
        SetTopic = 44,
        
        /// <summary>
        /// >> ClearTopic
        /// </summary>
        ClearTopic = 45,
        
        /// <summary>
        /// >> AliasOrigin
        /// </summary>
        AliasOrigin = 46,
        
        /// <summary>
        /// >> UnpaidExecution
        /// </summary>
        UnpaidExecution = 47,
    }
    
    /// <summary>
    /// >> 385 - Variant[staging_xcm.v4.Instruction]
    /// </summary>
    public sealed class EnumInstruction : BaseEnumExt<Instruction, Bajun.NetApi.Generated.Model.staging_xcm.v4.asset.Assets, Bajun.NetApi.Generated.Model.staging_xcm.v4.asset.Assets, Bajun.NetApi.Generated.Model.staging_xcm.v4.asset.Assets, BaseTuple<Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U64>, Bajun.NetApi.Generated.Model.staging_xcm.v4.EnumResponse, Bajun.NetApi.Generated.Model.sp_weights.weight_v2.Weight, Substrate.NetApi.Model.Types.Base.BaseOpt<Bajun.NetApi.Generated.Model.staging_xcm.v4.location.Location>>, BaseTuple<Bajun.NetApi.Generated.Model.staging_xcm.v4.asset.Assets, Bajun.NetApi.Generated.Model.staging_xcm.v4.location.Location>, BaseTuple<Bajun.NetApi.Generated.Model.staging_xcm.v4.asset.Assets, Bajun.NetApi.Generated.Model.staging_xcm.v4.location.Location, Bajun.NetApi.Generated.Model.staging_xcm.v4.XcmT1>, BaseTuple<Bajun.NetApi.Generated.Model.xcm.v3.EnumOriginKind, Bajun.NetApi.Generated.Model.sp_weights.weight_v2.Weight, Bajun.NetApi.Generated.Model.xcm.double_encoded.DoubleEncodedT2>, BaseTuple<Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U32>, Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U32>, Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U32>>, Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U32>, BaseTuple<Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U32>, Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U32>, Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U32>>, BaseVoid, Bajun.NetApi.Generated.Model.staging_xcm.v4.junctions.EnumJunctions, Bajun.NetApi.Generated.Model.staging_xcm.v4.QueryResponseInfo, BaseTuple<Bajun.NetApi.Generated.Model.staging_xcm.v4.asset.EnumAssetFilter, Bajun.NetApi.Generated.Model.staging_xcm.v4.location.Location>, BaseTuple<Bajun.NetApi.Generated.Model.staging_xcm.v4.asset.EnumAssetFilter, Bajun.NetApi.Generated.Model.staging_xcm.v4.location.Location, Bajun.NetApi.Generated.Model.staging_xcm.v4.XcmT1>, BaseTuple<Bajun.NetApi.Generated.Model.staging_xcm.v4.asset.EnumAssetFilter, Bajun.NetApi.Generated.Model.staging_xcm.v4.asset.Assets, Substrate.NetApi.Model.Types.Primitive.Bool>, BaseTuple<Bajun.NetApi.Generated.Model.staging_xcm.v4.asset.EnumAssetFilter, Bajun.NetApi.Generated.Model.staging_xcm.v4.location.Location, Bajun.NetApi.Generated.Model.staging_xcm.v4.XcmT1>, BaseTuple<Bajun.NetApi.Generated.Model.staging_xcm.v4.asset.EnumAssetFilter, Bajun.NetApi.Generated.Model.staging_xcm.v4.location.Location, Bajun.NetApi.Generated.Model.staging_xcm.v4.XcmT1>, BaseTuple<Bajun.NetApi.Generated.Model.staging_xcm.v4.QueryResponseInfo, Bajun.NetApi.Generated.Model.staging_xcm.v4.asset.EnumAssetFilter>, BaseTuple<Bajun.NetApi.Generated.Model.staging_xcm.v4.asset.Asset, Bajun.NetApi.Generated.Model.xcm.v3.EnumWeightLimit>, BaseVoid, Bajun.NetApi.Generated.Model.staging_xcm.v4.XcmT2, Bajun.NetApi.Generated.Model.staging_xcm.v4.XcmT2, BaseVoid, BaseTuple<Bajun.NetApi.Generated.Model.staging_xcm.v4.asset.Assets, Bajun.NetApi.Generated.Model.staging_xcm.v4.location.Location>, Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U64>, BaseTuple<Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U64>, Bajun.NetApi.Generated.Model.sp_weights.weight_v2.Weight>, BaseVoid, Bajun.NetApi.Generated.Model.staging_xcm.v4.asset.Assets, Bajun.NetApi.Generated.Model.staging_xcm.v4.asset.Assets, Substrate.NetApi.Model.Types.Base.BaseOpt<Bajun.NetApi.Generated.Model.staging_xcm.v4.location.Location>, Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Bajun.NetApi.Generated.Model.xcm.v3.traits.EnumError>>, Bajun.NetApi.Generated.Model.xcm.v3.EnumMaybeErrorCode, BaseTuple<Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Primitive.U8>, Bajun.NetApi.Generated.Model.staging_xcm.v4.QueryResponseInfo>, BaseTuple<Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U32>, Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Primitive.U8>, Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Primitive.U8>, Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U32>, Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U32>>, Bajun.NetApi.Generated.Model.staging_xcm.v4.QueryResponseInfo, BaseVoid, Bajun.NetApi.Generated.Model.staging_xcm.v4.junction.EnumJunction, BaseTuple<Bajun.NetApi.Generated.Model.staging_xcm.v4.junction.EnumNetworkId, Bajun.NetApi.Generated.Model.staging_xcm.v4.junctions.EnumJunctions, Bajun.NetApi.Generated.Model.staging_xcm.v4.XcmT1>, BaseTuple<Bajun.NetApi.Generated.Model.staging_xcm.v4.asset.Asset, Bajun.NetApi.Generated.Model.staging_xcm.v4.location.Location>, BaseTuple<Bajun.NetApi.Generated.Model.staging_xcm.v4.asset.Asset, Bajun.NetApi.Generated.Model.staging_xcm.v4.location.Location>, BaseTuple<Bajun.NetApi.Generated.Model.staging_xcm.v4.asset.Asset, Bajun.NetApi.Generated.Model.staging_xcm.v4.location.Location>, BaseTuple<Bajun.NetApi.Generated.Model.staging_xcm.v4.asset.Asset, Bajun.NetApi.Generated.Model.staging_xcm.v4.location.Location>, Substrate.NetApi.Model.Types.Primitive.Bool, Bajun.NetApi.Generated.Types.Base.Arr32U8, BaseVoid, Bajun.NetApi.Generated.Model.staging_xcm.v4.location.Location, BaseTuple<Bajun.NetApi.Generated.Model.xcm.v3.EnumWeightLimit, Substrate.NetApi.Model.Types.Base.BaseOpt<Bajun.NetApi.Generated.Model.staging_xcm.v4.location.Location>>>
    {
    }
}
