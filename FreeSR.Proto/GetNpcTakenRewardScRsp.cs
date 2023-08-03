namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class GetNpcTakenRewardScRsp
	{
		[ProtoMember(8)] public List<int> TalkEventList;
		[ProtoMember(3)] public int NpcId;
		[ProtoMember(6)] public int Retcode;
	}
	
}
