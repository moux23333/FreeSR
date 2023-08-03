namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class GetPunkLordMonsterDataScRsp
	{
		[ProtoMember(3)] public int Retcode;
		[ProtoMember(10)] public List<EGCLCLMLPNE> MonsterInfoList;
	}
	
}
