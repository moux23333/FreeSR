namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class SummonPunkLordMonsterScRsp
	{
		[ProtoMember(14)] public EGCLCLMLPNE MonsterInfo;
		[ProtoMember(2)] public int Retcode;
	}
	
}
