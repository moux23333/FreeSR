namespace FreeSR.Gateserver.Manager.Handlers
{
    using FreeSR.Gateserver.Manager.Handlers.Core;
    using FreeSR.Gateserver.Network;
    using FreeSR.Proto;


    internal static class SceneReqGroup
    {
        [Handler(CmdType.GetCurSceneInfoCsReq)]
        public static void OnGetCurSceneInfoCsReq(NetSession session, int cmdId, object data)
        {
            SceneInfo scene = new SceneInfo
            {
                GameModeType = 1,
                Bkmbkahohif = 1,
                Admbbnbnibk = 1,
                EntryId = 1000101,
                PlaneId = 10001,
                FloorId = 10001001,
                EntityList = new List<SceneEntityInfo>(),
                EnvBuffList = new List<BuffInfo>(),
                LightenSectionList = new List<int>()
            };

            scene.EntityList.Add(new SceneEntityInfo
            {
                EntityId = 0,
                GroupId = 0,
                InstId = 0,
                Motion = new MotionInfo()
                {
                    Pos = new Vector(),
                    Rot = new Vector()
                }
            });

            session.Send(CmdType.GetCurSceneInfoScRsp, new GetCurSceneInfoScRsp
            {
                Scene = scene,
                Retcode = Retcode.RETCODE_RET_SUCC
            });
        }
    }
}
