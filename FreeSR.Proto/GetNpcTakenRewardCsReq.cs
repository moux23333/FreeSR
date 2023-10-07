namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class GetNpcTakenRewardCsReq
	{
		[ProtoMember(5)] public int NpcId;
	}

}
