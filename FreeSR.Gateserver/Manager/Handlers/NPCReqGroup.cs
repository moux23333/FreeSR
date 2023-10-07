namespace FreeSR.Gateserver.Manager.Handlers
{
    using FreeSR.Gateserver.Manager.Handlers.Core;
    using FreeSR.Gateserver.Network;
    using FreeSR.Proto;
    using System.ComponentModel.Design;

    internal static class NPCReqGroup
    {
        //maybe useless
        [Handler(CmdType.GetNpcTakenRewardCsReq)]
        public static void OnGetNpcTakenRewardCsReq(NetSession session, int cmdId, object data)
        {

            var npcRewardReq = data as GetNpcTakenRewardCsReq;

            session.Send(CmdType.GetNpcTakenRewardScRsp, new GetNpcTakenRewardScRsp
            {
                NpcId = npcRewardReq.NpcId,
                Retcode = Retcode.RETCODE_RET_SUCC
            });
        }

        [Handler(CmdType.GetFirstTalkByPerformanceNpcCsReq)]
        public static void OnGetFirstTalkByPerformanceNpcCsReq(NetSession session, int cmdId, object data)
        {
            session.Send(CmdType.GetFirstTalkByPerformanceNpcScRsp, new GetFirstTalkByPerformanceNpcScRsp
            {
                Retcode = Retcode.RETCODE_RET_SUCC,
                NpcMeetStatusList = new List<OCLEPLBNNPA>
                {
                    new OCLEPLBNNPA
                    {
                        IsMeet = true,
                        Jljhobhmaof = 1
                    },
                }
            });
        }
    }
}
