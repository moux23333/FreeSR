namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class TakeApRewardCsReq
	{
		[ProtoMember(11)] public int Level;
	}
	
}
