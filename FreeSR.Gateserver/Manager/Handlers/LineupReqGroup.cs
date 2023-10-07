namespace FreeSR.Gateserver.Manager.Handlers
{
    using FreeSR.Gateserver.Manager.Handlers.Core;
    using FreeSR.Gateserver.Network;
    using FreeSR.Proto;

    internal static class LineupReqGroup
    {
        [Handler(CmdType.GetCurLineupDataCsReq)]
        public static void OnGetCurLineupDataCsReq(NetSession session, int cmdId, object _)
        {
            var response = new GetCurLineupDataScRsp
            {
                Retcode = Retcode.RETCODE_RET_SUCC
            };

            response.Lineup = new LineupInfo
            {
                ExtraLineupType = ExtraLineupType.LINEUP_NONE,
                Name = "Squad 1",
                AvatarList = new List<LineupAvatar>(),
                LeaderSlot = 5,
                Foafdgjflmc = 5
            };

            var characters = new int[] { 8001, 1005, 1003 };

            foreach (int id in characters)
            {
                response.Lineup.AvatarList.Add(new LineupAvatar
                {
                    AvatarType = AvatarType.AVATAR_FORMAL_TYPE,
                    CurHealth = new HealthBarInfo { CurHp = 10000, MaxHp = 10000 },
                    Sp = 10000,
                    Satiety = 100,
                    Id = id,
                    Slot = response.Lineup.AvatarList.Count
                });
            }

            session.Send(CmdType.GetCurLineupDataScRsp, response);
        }

        [Handler(CmdType.GetAllLineupDataCsReq)]
        public static void OnGetAllLineupDataCsReq(NetSession session, int cmdId, object data)
        {
            var response = new GetAllLineupDataScRsp
            {
                Retcode = Retcode.RETCODE_RET_SUCC,
                CurIndex = 0,
                LineupList = new List<LineupInfo>()
            };

            response.LineupList.Add(new LineupInfo
            {
                ExtraLineupType = ExtraLineupType.LINEUP_NONE,
                Name = "Squad 1",
                AvatarList = new List<LineupAvatar>(),
                Foafdgjflmc = 5,
                LeaderSlot = 3
            });

            var characters = new int[] { 8001, 1005, 1003 };

            foreach (int id in characters)
            {
                response.LineupList[0].AvatarList.Add(new LineupAvatar
                {
                    AvatarType = AvatarType.AVATAR_FORMAL_TYPE,
                    CurHealth = new HealthBarInfo { CurHp = 10000, MaxHp = 10000 },
                    Sp = 10000,
                    Satiety = 100,
                    Id = id,
                    Slot = response.LineupList[0].AvatarList.Count
                });
            }

            session.Send(CmdType.GetAllLineupDataScRsp, response);
        }

        [Handler(CmdType.ChangeLineupLeaderCsReq)]
        public static void OnChangeLineupLeaderCsReq(NetSession session, int cmdId, object data)
        {
            var request = data as ChangeLineupLeaderCsReq;
            session.Send(CmdType.ChangeLineupLeaderScRsp, new ChangeLineupLeaderScRsp
            {
                Slot = request.Slot,
                Retcode = Retcode.RETCODE_RET_SUCC
            });
        }
    }
}
