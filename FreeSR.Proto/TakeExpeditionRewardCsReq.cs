namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class TakeExpeditionRewardCsReq
	{
		[ProtoMember(14)] public int ExpeditionId;
	}
	
}
