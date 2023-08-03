namespace FreeSR.Gateserver.Manager.Handlers
{
    using FreeSR.Gateserver.Manager.Handlers.Core;
    using FreeSR.Gateserver.Network;
    using FreeSR.Proto;

    internal static class MissionReqGroup
    {
        [Handler(CmdType.GetMissionStatusCsReq)]
        public static void OnGetMissionStatusCsReq(NetSession session, int cmdId, object data)
        {
            var request = data as GetMissionStatusCsReq;
            GetMissionStatusScRsp response = new GetMissionStatusScRsp
            {
                Retcode = Retcode.RETCODE_RET_SUCC,

                DisabledMainMissionIdList = new List<int>(),
                FinishedMainMissionIdList = new List<int>(),
                MissionEventStatusList = new List<Mission>(),
                SubMissionStatusList = new List<Mission>(),
                UnfinishedMainMissionIdList = new List<int>()
            };

            response.FinishedMainMissionIdList = new List<int>
            {
                1000101,
                1000112,
                1000113,
                1000201,
                1000202,
                1000204,
                1000301,
                1000401,
                1000402,
                1000410,
                1000510,
                1000601,
                1010301,
                1010302,
                1010401,
                1010403,
                1010701,
                1011403,
                1010202,
                1010902,
                1011102,
                4010101
            };

            if (request.MissionEventIdList != null)
            {
                foreach (int id in request.MissionEventIdList)
                {
                    response.UnfinishedMainMissionIdList.Add(id);
                }
            }

            if (request.SubMissionIdList != null)
            {
                foreach (int id in request.SubMissionIdList)
                {
                    response.MissionEventStatusList.Add(new Mission()
                    {
                        Id = id,
                        Progress = 0,
                        Status = MissionStatus.MISSION_FINISH
                    });
                }
            }

            if (request.MainMissionIdList != null)
            {
                foreach (int id in request.MainMissionIdList)
                {
                    response.SubMissionStatusList.Add(new Mission()
                    {
                        Id = id,
                        Progress = 0,
                        Status = MissionStatus.MISSION_FINISH
                    });
                }
            }

            session.Send(CmdType.GetMissionStatusScRsp, response);
        }
    }
}
