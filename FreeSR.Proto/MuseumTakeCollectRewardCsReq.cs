namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class MuseumTakeCollectRewardCsReq
	{
		[ProtoMember(12)] public int ItemId;
	}
	
}
