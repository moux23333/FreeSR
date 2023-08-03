namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class GetLevelRewardTakenListScRsp
	{
		[ProtoMember(14)] public int Retcode;
		[ProtoMember(13)] public List<int> TakenLevelList;
	}
	
}
