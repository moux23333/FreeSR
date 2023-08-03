namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class GetNpcTakenRewardCsReq
	{
		[ProtoMember(11)] public int NpcId;
	}
	
}
