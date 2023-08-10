namespace FreeSR.Gateserver.Network.Factory
{
    using FreeSR.Proto;
    using ProtoBuf;
    using System.Collections.Immutable;

    internal static class ProtoFactory
    {
        private static readonly ImmutableDictionary<CmdType, Type> s_types;

        static ProtoFactory()
        {
            var builder = ImmutableDictionary.CreateBuilder<CmdType, Type>();
            builder.AddRange(new Dictionary<CmdType, Type>()
            {
                {CmdType.PlayerGetTokenCsReq, typeof(PlayerGetTokenCsReq)},
                {CmdType.PlayerLoginCsReq, typeof(PlayerLoginCsReq)},
                {CmdType.GetAvatarDataCsReq, typeof(GetAvatarDataCsReq)},

                {CmdType.GetAllLineupDataCsReq, typeof(GetAllLineupDataCsReq)},
                {CmdType.GetCurLineupDataCsReq, typeof(GetCurLineupDataCsReq)},
                {CmdType.ChangeLineupLeaderCsReq, typeof(ChangeLineupLeaderCsReq)},

                {CmdType.GetMissionStatusCsReq, typeof(GetMissionStatusCsReq)},
                {CmdType.GetQuestDataCsReq, typeof(GetQuestDataCsReq)},
                {CmdType.GetChallengeCsReq, typeof(GetChallengeCsReq)},
                {CmdType.GetCurSceneInfoCsReq, typeof(GetCurSceneInfoCsReq)},

                {CmdType.GetBasicInfoCsReq, typeof(GetBasicInfoCsReq)},
                {CmdType.GetHeroBasicTypeInfoCsReq, typeof(GetHeroBasicTypeInfoCsReq)},
                {CmdType.PlayerHeartBeatCsReq, typeof(PlayerHeartBeatCsReq)},

                {CmdType.GetGachaInfoCsReq, typeof(GetGachaInfoCsReq)},
                {CmdType.DoGachaCsReq, typeof(DoGachaCsReq)},

                {CmdType.GetNpcTakenRewardCsReq, typeof(GetNpcTakenRewardCsReq)},
                {CmdType.GetFirstTalkByPerformanceNpcCsReq, typeof(GetFirstTalkByPerformanceNpcCsReq)},
                
                {CmdType.GetBagCsReq, typeof(GetBagCsReq)}
            });

            s_types = builder.ToImmutable();
        }

        public static object Deserialize(int id, byte[] rawData)
        {
            if (s_types.TryGetValue((CmdType)id, out var type))
                return Serializer.Deserialize(type, new MemoryStream(rawData));

            return null;
        }
    }
}
