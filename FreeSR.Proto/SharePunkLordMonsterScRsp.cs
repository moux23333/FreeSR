namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class SharePunkLordMonsterScRsp
	{
		[ProtoMember(4)] public BlackLimitLevel GLOPBHNOANO;
		[ProtoMember(7)] public int Retcode;
		[ProtoMember(2)] public int MonsterId;
		[ProtoMember(9)] public int Uid;
	}
	
}
