namespace FreeSR.Gateserver.Manager.Handlers
{
    using FreeSR.Gateserver.Manager.Handlers.Core;
    using FreeSR.Gateserver.Network;
    using FreeSR.Proto;
    using static System.Net.WebRequestMethods;
    using System.Collections.Generic;
    using System.Net.Http.Headers;
    using System.ComponentModel.Design;

    internal static class GachaReqGroup
    {
        [Handler(CmdType.GetGachaInfoCsReq)]
        public static void OnGetGachaInfoCsReq(NetSession session, int cmdId, object data)
        {
            var Gacha1List = new List<int>();
            session.Send(CmdType.GetGachaInfoScRsp, new GetGachaInfoScRsp
            {
                Retcode = Retcode.RETCODE_RET_SUCC,
                GachaRandom = 0,
                GachaInfoList = new List<GachaInfo>
                {
                    new GachaInfo
                    {
                        //ENJHJHKNGOG = "https://webstatic-sea.hoyoverse.com/hkrpg/event/e20211215gacha-v2/index.html?authkey_ver=1&sign_type=2&auth_appid=webview_gacha&win_mode=fullscreen#/log",
                        Dmdldgldfdj = new List<int>(1208),
                        //JDMIIMJFAPK = "https://webstatic-sea.hoyoverse.com/hkrpg/event/e20211215gacha-v2/index.html?authkey_ver=1&sign_type=2&auth_appid=webview_gacha&win_mode=fullscreen&gacha_id=ad9815cdf2308104c377aac42c7f0cdd8d&timestamp=1689725163",
                        Pldioknjpjj = new List<int>{1208, 1110, 1109, 1106},
                        BeginTime = 1689719400,
                        EndTime = 4070880000,
                        GachaId = 2010
                    }
                }
            });
        }

        [Handler(CmdType.DoGachaCsReq)]
        public static void OnDoGachaCsReq(NetSession session, int cmdId, object data)
        {
            var gachaReq = data as DoGachaCsReq;
            if (gachaReq.GachaNum == 1)
            {
                session.Send(CmdType.DoGachaScRsp, new DoGachaScRsp
                {
                    GachaId = gachaReq.GachaId,
                    Nmaojeiedak = gachaReq.GachaRandom + 1,
                    GachaNum = gachaReq.GachaNum,
                    GachaItemList = new List<GachaItem>
                    {
                        new GachaItem
                        {
                            Item = new List<Item>
                            {
                                new Item
                                {
                                    ItemId = 1107,
                                    Num = 1,
                                }
                            }[0],
                            Dpjjnjflnjm = new List<ItemList>
                            {
                                new ItemList
                                {
                                    List = new List<Item>
                                    {
                                        new Item
                                        {
                                            ItemId = 252,
                                            Num = 40,
                                        }
                                    }
                                }
                            }[0]
                        }
                    },
                });
            }

            if (gachaReq.GachaNum == 10)
            {
                session.Send(CmdType.DoGachaScRsp, new DoGachaScRsp
                {
                    GachaId = gachaReq.GachaId,
                    Nmaojeiedak = gachaReq.GachaRandom + 10,
                    GachaNum = gachaReq.GachaNum,
                    GachaItemList = new List<GachaItem>
                    {
                        new GachaItem
                        {
                            Item = new List<Item>
                            {
                                new Item
                                {
                                    ItemId = 1208,
                                    Num = 1,
                                }
                            }[0],
                            Dpjjnjflnjm = new List<ItemList>
                            {
                                new ItemList
                                {
                                    List = new List<Item>
                                    {
                                        new Item
                                        {
                                            ItemId = 252,
                                            Num = 40,
                                        }
                                    }
                                }
                            }[0]
                        },
                        new GachaItem
                        {
                            Item = new List<Item>
                            {
                                new Item
                                {
                                    ItemId = 1208,
                                    Num = 1,
                                }
                            }[0],
                            Dpjjnjflnjm = new List<ItemList>
                            {
                                new ItemList
                                {
                                    List = new List<Item>
                                    {
                                        new Item
                                        {
                                            ItemId = 252,
                                            Num = 40,
                                        }
                                    }
                                }
                            }[0]
                        },
                        new GachaItem
                        {
                            Item = new List<Item>
                            {
                                new Item
                                {
                                    ItemId = 1208,
                                    Num = 1,
                                }
                            }[0],
                            Dpjjnjflnjm = new List<ItemList>
                            {
                                new ItemList
                                {
                                    List = new List<Item>
                                    {
                                        new Item
                                        {
                                            ItemId = 252,
                                            Num = 40,
                                        }
                                    }
                                }
                            }[0]
                        },
                        new GachaItem
                        {
                            Item = new List<Item>
                            {
                                new Item
                                {
                                    ItemId = 1208,
                                    Num = 1,
                                }
                            }[0],
                            Dpjjnjflnjm = new List<ItemList>
                            {
                                new ItemList
                                {
                                    List = new List<Item>
                                    {
                                        new Item
                                        {
                                            ItemId = 252,
                                            Num = 40,
                                        }
                                    }
                                }
                            }[0]
                        },
                        new GachaItem
                        {
                            Item = new List<Item>
                            {
                                new Item
                                {
                                    ItemId = 1208,
                                    Num = 1,
                                }
                            }[0],
                            Dpjjnjflnjm = new List<ItemList>
                            {
                                new ItemList
                                {
                                    List = new List<Item>
                                    {
                                        new Item
                                        {
                                            ItemId = 252,
                                            Num = 40,
                                        }
                                    }
                                }
                            }[0]
                        },
                        new GachaItem
                        {
                            Item = new List<Item>
                            {
                                new Item
                                {
                                    ItemId = 1208,
                                    Num = 1,
                                }
                            }[0],
                            Dpjjnjflnjm = new List<ItemList>
                            {
                                new ItemList
                                {
                                    List = new List<Item>
                                    {
                                        new Item
                                        {
                                            ItemId = 252,
                                            Num = 40,
                                        }
                                    }
                                }
                            }[0]
                        },
                        new GachaItem
                        {
                            Item = new List<Item>
                            {
                                new Item
                                {
                                    ItemId = 1208,
                                    Num = 1,
                                }
                            }[0],
                            Dpjjnjflnjm = new List<ItemList>
                            {
                                new ItemList
                                {
                                    List = new List<Item>
                                    {
                                        new Item
                                        {
                                            ItemId = 252,
                                            Num = 40,
                                        }
                                    }
                                }
                            }[0]
                        },
                        new GachaItem
                        {
                            Item = new List<Item>
                            {
                                new Item
                                {
                                    ItemId = 1208,
                                    Num = 1,
                                }
                            }[0],
                            Dpjjnjflnjm = new List<ItemList>
                            {
                                new ItemList
                                {
                                    List = new List<Item>
                                    {
                                        new Item
                                        {
                                            ItemId = 252,
                                            Num = 40,
                                        }
                                    }
                                }
                            }[0]
                        },
                        new GachaItem
                        {
                            Item = new List<Item>
                            {
                                new Item
                                {
                                    ItemId = 1208,
                                    Num = 1,
                                }
                            }[0],
                            Dpjjnjflnjm = new List<ItemList>
                            {
                                new ItemList
                                {
                                    List = new List<Item>
                                    {
                                        new Item
                                        {
                                            ItemId = 252,
                                            Num = 40,
                                        }
                                    }
                                }
                            }[0]
                        },
                        new GachaItem
                        {
                            Item = new List<Item>
                            {
                                new Item
                                {
                                    ItemId = 1208,
                                    Num = 1,
                                }
                            }[0],
                            Dpjjnjflnjm = new List<ItemList>
                            {
                                new ItemList
                                {
                                    List = new List<Item>
                                    {
                                        new Item
                                        {
                                            ItemId = 252,
                                            Num = 40,
                                        }
                                    }
                                }
                            }[0]
                        }
                    },
                });
            }
        }
    }
}
