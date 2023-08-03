namespace FreeSR.Gateserver.Manager.Handlers
{
    using FreeSR.Gateserver.Manager.Handlers.Core;
    using FreeSR.Gateserver.Network;
    using FreeSR.Proto;

    internal static class AvatarReqGroup
    {
        [Handler(CmdType.GetAvatarDataCsReq)]
        public static void OnGetAvatarDataCsReq(NetSession session, int cmdId, object data)
        {
            var request = data as GetAvatarDataCsReq;

            var response = new GetAvatarDataScRsp
            {
                Retcode = Retcode.RETCODE_RET_SUCC,
                IsAll = request.IsGetAll,
                AvatarList = new List<Avatar>()
            };

            int[] characters = new int[] { 8001, 1005, 1003 };

            foreach (int id in characters)
            {
                response.AvatarList.Add(new Avatar
                {
                    BaseAvatarId = id,
                    Exp = 0,
                    Level = 1,
                    Promotion = 0,
                    Rank = 6,
                    SkilltreeList = new List<AvatarSkillTree>(),
                    EquipmentUniqueId = 0
                });
            }

            session.Send(CmdType.GetAvatarDataScRsp, response);
        }
    }
}
