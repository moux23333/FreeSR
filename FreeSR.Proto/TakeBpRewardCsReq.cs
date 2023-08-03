namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class TakeBpRewardCsReq
	{
		[ProtoMember(2)] public int OptionalRewardId;
		[ProtoMember(11)] public int Level;
		[ProtoMember(15)] public LNEOGCKLOPC Type;
	}
	
}
