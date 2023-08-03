namespace FreeSR.Gateserver.Manager.Handlers
{
    using FreeSR.Gateserver.Manager.Handlers.Core;
    using FreeSR.Gateserver.Network;
    using FreeSR.Proto;
    using NLog;

    internal static class TutorialReqGroup
    {
        private static readonly Logger s_log = LogManager.GetCurrentClassLogger();

        [Handler(CmdType.GetTutorialGuideCsReq)]
        public static void OnGetTutorialGuideCsReq(NetSession session, int cmdId, object _)
        {
            var response = new GetTutorialGuideScRsp
            {
                Retcode = Retcode.RETCODE_RET_SUCC,
                TutorialGuideList = new List<TutorialGuide>()
            };

            int[] guides = new int[]
            {
                1101, 1102, 1104, 1105, 1116, 1117, 2006, 2007, 2101, 2105, 2106, 2107, 3007, 3105, 3106, 4001, 4101, 4102, 4103, 4104, 4105, 4106, 4107, 4108, 4109, 5101, 5102, 5103, 5104, 5105, 6001, 6002, 6003, 6004, 6005, 6006, 6007, 9101, 9102, 9103, 9104, 9105, 9106, 9107, 9108
            };
            
            foreach (int id in guides)
            {
                response.TutorialGuideList.Add(new TutorialGuide
                {
                    Id = id,
                    Status = TutorialStatus.TUTORIAL_FINISH
                });
            }

            session.Send(CmdType.GetTutorialGuideScRsp, response);
        }

        [Handler(CmdType.GetTutorialCsReq)]
        public static void OnGetTutorialCsReq(NetSession session, int cmdId, object _)
        {
            int[] completedTutorials = new int[]
            {
                1001, 1002, 1003, 1004, 1005, 1007, 1008, 1010, 1011,
                2001, 2002, 2003, 2004, 2005, 2008, 2009, 2010, 2011, 2012, 2013, 2014, 2015,
                3001, 3002, 3003, 3004, 3005, 3006,
                4002, 4003, 4004, 4005, 4006, 4007, 4008, 4009,
                5001, 5002, 5003, 5004, 5005, 5006, 5007, 5008, 5009, 5010, 5011, 5012,
                7001,
                9001, 9002, 9003, 9004, 9005, 9006
            };

            var response = new GetTutorialScRsp
            {
                Retcode = Retcode.RETCODE_RET_SUCC,
                TutorialList = new List<Tutorial>()
            };

            foreach (int id in completedTutorials)
            {
                response.TutorialList.Add(new Tutorial
                {
                    Id = id,
                    Status = TutorialStatus.TUTORIAL_FINISH
                });
            }

            session.Send(CmdType.GetTutorialScRsp, response);
        }
    }
}
