namespace FreeSR.Gateserver.Network.Handlers.Manager
{
    using DotNetty.Transport.Channels;
    using FreeSR.Gateserver.Manager;
    using FreeSR.Gateserver.Network.Packet;
    using FreeSR.Proto;
    using NLog;
    using ProtoBuf;

    internal class PacketHandler : ChannelHandlerAdapter
    {
        private static readonly Logger s_log = LogManager.GetCurrentClassLogger();
        private readonly NetSession _session;

        public PacketHandler(NetSession session)
        {
            _session = session;
        }

        public override void ChannelRead(IChannelHandlerContext context, object message)
        {
            NetPacket packet = message as NetPacket;
            if (packet.Data == null)
            {
                if (!SendDummyResponse(packet.CmdId))
                    s_log.Warn($"CmdID {packet.CmdId} is undefined.");

                return;
            }

            s_log.Info($"Received packet {packet.CmdId}!");
            NotifyManager.Notify(_session, packet.CmdId, packet.Data);
        }

        private bool SendDummyResponse(int id)
        {
            if (s_dummyTable.TryGetValue((CmdType)id, out CmdType rspId))
            {
                _session.Send(rspId, new DummyPacket());
                return true;
            }

            return false;
        }

        private static Dictionary<CmdType, CmdType> s_dummyTable = new Dictionary<CmdType, CmdType>
        {
            {CmdType.GetLevelRewardTakenListCsReq, CmdType.GetLevelRewardTakenListScRsp},
            {CmdType.GetRogueScoreRewardInfoCsReq, CmdType.GetRogueScoreRewardInfoScRsp},
            {CmdType.GetGachaInfoCsReq, CmdType.GetGachaInfoScRsp},
            {CmdType.QueryProductInfoCsReq, CmdType.QueryProductInfoScRsp},
            {CmdType.GetQuestDataCsReq, CmdType.GetQuestDataScRsp},
            {CmdType.GetQuestRecordCsReq, CmdType.GetQuestRecordScRsp},
            {CmdType.GetFriendListInfoCsReq, CmdType.GetFriendListInfoScRsp},
            {CmdType.GetFriendApplyListInfoCsReq, CmdType.GetFriendApplyListInfoScRsp},
            {CmdType.GetCurAssistCsReq, CmdType.GetCurAssistScRsp},
            {CmdType.GetRogueHandbookDataCsReq, CmdType.GetRogueHandbookDataScRsp},
            {CmdType.GetDailyActiveInfoCsReq, CmdType.GetDailyActiveInfoScRsp},
            {CmdType.GetFightActivityDataCsReq, CmdType.GetFightActivityDataScRsp},
            {CmdType.GetMultipleDropInfoCsReq, CmdType.GetMultipleDropInfoScRsp},
            {CmdType.GetPlayerReturnMultiDropInfoCsReq, CmdType.GetPlayerReturnMultiDropInfoScRsp},
            {CmdType.GetShareDataCsReq, CmdType.GetShareDataScRsp},
            {CmdType.GetTreasureDungeonActivityDataCsReq, CmdType.GetTreasureDungeonActivityDataScRsp},
            {CmdType.PlayerReturnInfoQueryCsReq, CmdType.PlayerReturnInfoQueryScRsp},
            {CmdType.GetBasicInfoCsReq, CmdType.GetBasicInfoScRsp},
            {CmdType.GetHeroBasicTypeInfoCsReq, CmdType.GetHeroBasicTypeInfoScRsp},
            {CmdType.GetBagCsReq, CmdType.GetBagScRsp},
            {CmdType.GetPlayerBoardDataCsReq, CmdType.GetPlayerBoardDataScRsp},
            {CmdType.GetAvatarDataCsReq, CmdType.GetAvatarDataScRsp},
            {CmdType.GetAllLineupDataCsReq, CmdType.GetAllLineupDataScRsp},
            {CmdType.GetActivityScheduleConfigCsReq, CmdType.GetActivityScheduleConfigScRsp},
            {CmdType.GetMissionDataCsReq, CmdType.GetMissionDataScRsp},
            {CmdType.GetMissionEventDataCsReq, CmdType.GetMissionEventDataScRsp},
            {CmdType.GetChallengeCsReq, CmdType.GetChallengeScRsp},
            {CmdType.GetCurChallengeCsReq, CmdType.GetCurChallengeScRsp},
            {CmdType.GetRogueInfoCsReq, CmdType.GetRogueInfoScRsp},
            {CmdType.GetExpeditionDataCsReq, CmdType.GetExpeditionDataScRsp},
            {CmdType.GetRogueDialogueEventDataCsReq, CmdType.GetRogueDialogueEventDataScRsp},
            {CmdType.GetJukeboxDataCsReq, CmdType.GetJukeboxDataScRsp},
            {CmdType.SyncClientResVersionCsReq, CmdType.SyncClientResVersionScRsp},
            {CmdType.DailyFirstMeetPamCsReq, CmdType.DailyFirstMeetPamScRsp},
            {CmdType.GetMuseumInfoCsReq, CmdType.GetMuseumInfoScRsp},
            {CmdType.GetLoginActivityCsReq, CmdType.GetLoginActivityScRsp},
            {CmdType.GetRaidInfoCsReq, CmdType.GetRaidInfoScRsp},
            {CmdType.GetTrialActivityDataCsReq, CmdType.GetTrialActivityDataScRsp},
            {CmdType.GetBoxingClubInfoCsReq, CmdType.GetBoxingClubInfoScRsp},
            {CmdType.GetNpcStatusCsReq, CmdType.GetNpcStatusScRsp},
            {CmdType.TextJoinQueryCsReq, CmdType.TextJoinQueryScRsp},
            {CmdType.GetSpringRecoverDataCsReq, CmdType.GetSpringRecoverDataScRsp},
            {CmdType.GetChatFriendHistoryCsReq, CmdType.GetChatFriendHistoryScRsp},
            {CmdType.GetSecretKeyInfoCsReq, CmdType.GetSecretKeyInfoScRsp},
            {CmdType.GetVideoVersionKeyCsReq, CmdType.GetVideoVersionKeyScRsp},
            {CmdType.GetCurLineupDataCsReq, CmdType.GetCurLineupDataScRsp},
            {CmdType.GetCurBattleInfoCsReq, CmdType.GetCurBattleInfoScRsp},
            {CmdType.GetCurSceneInfoCsReq, CmdType.GetCurSceneInfoScRsp},
            {CmdType.GetPhoneDataCsReq, CmdType.GetPhoneDataScRsp},
            {CmdType.PlayerLoginFinishCsReq, CmdType.PlayerLoginFinishScRsp}
        };

        [ProtoContract]
        private class DummyPacket { }
    }
}
