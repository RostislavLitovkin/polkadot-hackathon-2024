//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Substrate.NetApi;
using Substrate.NetApi.Model.Extrinsics;
using Substrate.NetApi.Model.Meta;
using Substrate.NetApi.Model.Types;
using Substrate.NetApi.Model.Types.Base;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;


namespace Polkadot.NetApi.Generated.Storage
{
    
    
    /// <summary>
    /// >> ParaInclusionStorage
    /// </summary>
    public sealed class ParaInclusionStorage
    {
        
        // Substrate client for the storage calls.
        private SubstrateClientExt _client;
        
        /// <summary>
        /// >> ParaInclusionStorage Constructor
        /// </summary>
        public ParaInclusionStorage(SubstrateClientExt client)
        {
            this._client = client;
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("ParaInclusion", "AvailabilityBitfields"), new System.Tuple<Substrate.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                            Substrate.NetApi.Model.Meta.Storage.Hasher.Twox64Concat}, typeof(Polkadot.NetApi.Generated.Model.polkadot_primitives.v6.ValidatorIndex), typeof(Polkadot.NetApi.Generated.Model.polkadot_runtime_parachains.inclusion.AvailabilityBitfieldRecord)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("ParaInclusion", "PendingAvailability"), new System.Tuple<Substrate.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                            Substrate.NetApi.Model.Meta.Storage.Hasher.Twox64Concat}, typeof(Polkadot.NetApi.Generated.Model.polkadot_parachain_primitives.primitives.Id), typeof(Polkadot.NetApi.Generated.Model.polkadot_runtime_parachains.inclusion.CandidatePendingAvailability)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("ParaInclusion", "PendingAvailabilityCommitments"), new System.Tuple<Substrate.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                            Substrate.NetApi.Model.Meta.Storage.Hasher.Twox64Concat}, typeof(Polkadot.NetApi.Generated.Model.polkadot_parachain_primitives.primitives.Id), typeof(Polkadot.NetApi.Generated.Model.polkadot_primitives.v6.CandidateCommitments)));
        }
        
        /// <summary>
        /// >> AvailabilityBitfieldsParams
        ///  The latest bitfield for each validator, referred to by their index in the validator set.
        /// </summary>
        public static string AvailabilityBitfieldsParams(Polkadot.NetApi.Generated.Model.polkadot_primitives.v6.ValidatorIndex key)
        {
            return RequestGenerator.GetStorage("ParaInclusion", "AvailabilityBitfields", Substrate.NetApi.Model.Meta.Storage.Type.Map, new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                        Substrate.NetApi.Model.Meta.Storage.Hasher.Twox64Concat}, new Substrate.NetApi.Model.Types.IType[] {
                        key});
        }
        
        /// <summary>
        /// >> AvailabilityBitfieldsDefault
        /// Default value as hex string
        /// </summary>
        public static string AvailabilityBitfieldsDefault()
        {
            return "0x00";
        }
        
        /// <summary>
        /// >> AvailabilityBitfields
        ///  The latest bitfield for each validator, referred to by their index in the validator set.
        /// </summary>
        public async Task<Polkadot.NetApi.Generated.Model.polkadot_runtime_parachains.inclusion.AvailabilityBitfieldRecord> AvailabilityBitfields(Polkadot.NetApi.Generated.Model.polkadot_primitives.v6.ValidatorIndex key, string blockhash, CancellationToken token)
        {
            string parameters = ParaInclusionStorage.AvailabilityBitfieldsParams(key);
            var result = await _client.GetStorageAsync<Polkadot.NetApi.Generated.Model.polkadot_runtime_parachains.inclusion.AvailabilityBitfieldRecord>(parameters, blockhash, token);
            return result;
        }
        
        /// <summary>
        /// >> PendingAvailabilityParams
        ///  Candidates pending availability by `ParaId`.
        /// </summary>
        public static string PendingAvailabilityParams(Polkadot.NetApi.Generated.Model.polkadot_parachain_primitives.primitives.Id key)
        {
            return RequestGenerator.GetStorage("ParaInclusion", "PendingAvailability", Substrate.NetApi.Model.Meta.Storage.Type.Map, new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                        Substrate.NetApi.Model.Meta.Storage.Hasher.Twox64Concat}, new Substrate.NetApi.Model.Types.IType[] {
                        key});
        }
        
        /// <summary>
        /// >> PendingAvailabilityDefault
        /// Default value as hex string
        /// </summary>
        public static string PendingAvailabilityDefault()
        {
            return "0x00";
        }
        
        /// <summary>
        /// >> PendingAvailability
        ///  Candidates pending availability by `ParaId`.
        /// </summary>
        public async Task<Polkadot.NetApi.Generated.Model.polkadot_runtime_parachains.inclusion.CandidatePendingAvailability> PendingAvailability(Polkadot.NetApi.Generated.Model.polkadot_parachain_primitives.primitives.Id key, string blockhash, CancellationToken token)
        {
            string parameters = ParaInclusionStorage.PendingAvailabilityParams(key);
            var result = await _client.GetStorageAsync<Polkadot.NetApi.Generated.Model.polkadot_runtime_parachains.inclusion.CandidatePendingAvailability>(parameters, blockhash, token);
            return result;
        }
        
        /// <summary>
        /// >> PendingAvailabilityCommitmentsParams
        ///  The commitments of candidates pending availability, by `ParaId`.
        /// </summary>
        public static string PendingAvailabilityCommitmentsParams(Polkadot.NetApi.Generated.Model.polkadot_parachain_primitives.primitives.Id key)
        {
            return RequestGenerator.GetStorage("ParaInclusion", "PendingAvailabilityCommitments", Substrate.NetApi.Model.Meta.Storage.Type.Map, new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                        Substrate.NetApi.Model.Meta.Storage.Hasher.Twox64Concat}, new Substrate.NetApi.Model.Types.IType[] {
                        key});
        }
        
        /// <summary>
        /// >> PendingAvailabilityCommitmentsDefault
        /// Default value as hex string
        /// </summary>
        public static string PendingAvailabilityCommitmentsDefault()
        {
            return "0x00";
        }
        
        /// <summary>
        /// >> PendingAvailabilityCommitments
        ///  The commitments of candidates pending availability, by `ParaId`.
        /// </summary>
        public async Task<Polkadot.NetApi.Generated.Model.polkadot_primitives.v6.CandidateCommitments> PendingAvailabilityCommitments(Polkadot.NetApi.Generated.Model.polkadot_parachain_primitives.primitives.Id key, string blockhash, CancellationToken token)
        {
            string parameters = ParaInclusionStorage.PendingAvailabilityCommitmentsParams(key);
            var result = await _client.GetStorageAsync<Polkadot.NetApi.Generated.Model.polkadot_primitives.v6.CandidateCommitments>(parameters, blockhash, token);
            return result;
        }
    }
    
    /// <summary>
    /// >> ParaInclusionCalls
    /// </summary>
    public sealed class ParaInclusionCalls
    {
    }
    
    /// <summary>
    /// >> ParaInclusionConstants
    /// </summary>
    public sealed class ParaInclusionConstants
    {
    }
    
    /// <summary>
    /// >> ParaInclusionErrors
    /// </summary>
    public enum ParaInclusionErrors
    {
        
        /// <summary>
        /// >> UnsortedOrDuplicateValidatorIndices
        /// Validator indices are out of order or contains duplicates.
        /// </summary>
        UnsortedOrDuplicateValidatorIndices,
        
        /// <summary>
        /// >> UnsortedOrDuplicateDisputeStatementSet
        /// Dispute statement sets are out of order or contain duplicates.
        /// </summary>
        UnsortedOrDuplicateDisputeStatementSet,
        
        /// <summary>
        /// >> UnsortedOrDuplicateBackedCandidates
        /// Backed candidates are out of order (core index) or contain duplicates.
        /// </summary>
        UnsortedOrDuplicateBackedCandidates,
        
        /// <summary>
        /// >> UnexpectedRelayParent
        /// A different relay parent was provided compared to the on-chain stored one.
        /// </summary>
        UnexpectedRelayParent,
        
        /// <summary>
        /// >> WrongBitfieldSize
        /// Availability bitfield has unexpected size.
        /// </summary>
        WrongBitfieldSize,
        
        /// <summary>
        /// >> BitfieldAllZeros
        /// Bitfield consists of zeros only.
        /// </summary>
        BitfieldAllZeros,
        
        /// <summary>
        /// >> BitfieldDuplicateOrUnordered
        /// Multiple bitfields submitted by same validator or validators out of order by index.
        /// </summary>
        BitfieldDuplicateOrUnordered,
        
        /// <summary>
        /// >> ValidatorIndexOutOfBounds
        /// Validator index out of bounds.
        /// </summary>
        ValidatorIndexOutOfBounds,
        
        /// <summary>
        /// >> InvalidBitfieldSignature
        /// Invalid signature
        /// </summary>
        InvalidBitfieldSignature,
        
        /// <summary>
        /// >> UnscheduledCandidate
        /// Candidate submitted but para not scheduled.
        /// </summary>
        UnscheduledCandidate,
        
        /// <summary>
        /// >> CandidateScheduledBeforeParaFree
        /// Candidate scheduled despite pending candidate already existing for the para.
        /// </summary>
        CandidateScheduledBeforeParaFree,
        
        /// <summary>
        /// >> ScheduledOutOfOrder
        /// Scheduled cores out of order.
        /// </summary>
        ScheduledOutOfOrder,
        
        /// <summary>
        /// >> HeadDataTooLarge
        /// Head data exceeds the configured maximum.
        /// </summary>
        HeadDataTooLarge,
        
        /// <summary>
        /// >> PrematureCodeUpgrade
        /// Code upgrade prematurely.
        /// </summary>
        PrematureCodeUpgrade,
        
        /// <summary>
        /// >> NewCodeTooLarge
        /// Output code is too large
        /// </summary>
        NewCodeTooLarge,
        
        /// <summary>
        /// >> DisallowedRelayParent
        /// The candidate's relay-parent was not allowed. Either it was
        /// not recent enough or it didn't advance based on the last parachain block.
        /// </summary>
        DisallowedRelayParent,
        
        /// <summary>
        /// >> InvalidAssignment
        /// Failed to compute group index for the core: either it's out of bounds
        /// or the relay parent doesn't belong to the current session.
        /// </summary>
        InvalidAssignment,
        
        /// <summary>
        /// >> InvalidGroupIndex
        /// Invalid group index in core assignment.
        /// </summary>
        InvalidGroupIndex,
        
        /// <summary>
        /// >> InsufficientBacking
        /// Insufficient (non-majority) backing.
        /// </summary>
        InsufficientBacking,
        
        /// <summary>
        /// >> InvalidBacking
        /// Invalid (bad signature, unknown validator, etc.) backing.
        /// </summary>
        InvalidBacking,
        
        /// <summary>
        /// >> NotCollatorSigned
        /// Collator did not sign PoV.
        /// </summary>
        NotCollatorSigned,
        
        /// <summary>
        /// >> ValidationDataHashMismatch
        /// The validation data hash does not match expected.
        /// </summary>
        ValidationDataHashMismatch,
        
        /// <summary>
        /// >> IncorrectDownwardMessageHandling
        /// The downward message queue is not processed correctly.
        /// </summary>
        IncorrectDownwardMessageHandling,
        
        /// <summary>
        /// >> InvalidUpwardMessages
        /// At least one upward message sent does not pass the acceptance criteria.
        /// </summary>
        InvalidUpwardMessages,
        
        /// <summary>
        /// >> HrmpWatermarkMishandling
        /// The candidate didn't follow the rules of HRMP watermark advancement.
        /// </summary>
        HrmpWatermarkMishandling,
        
        /// <summary>
        /// >> InvalidOutboundHrmp
        /// The HRMP messages sent by the candidate is not valid.
        /// </summary>
        InvalidOutboundHrmp,
        
        /// <summary>
        /// >> InvalidValidationCodeHash
        /// The validation code hash of the candidate is not valid.
        /// </summary>
        InvalidValidationCodeHash,
        
        /// <summary>
        /// >> ParaHeadMismatch
        /// The `para_head` hash in the candidate descriptor doesn't match the hash of the actual
        /// para head in the commitments.
        /// </summary>
        ParaHeadMismatch,
        
        /// <summary>
        /// >> BitfieldReferencesFreedCore
        /// A bitfield that references a freed core,
        /// either intentionally or as part of a concluded
        /// invalid dispute.
        /// </summary>
        BitfieldReferencesFreedCore,
    }
}
