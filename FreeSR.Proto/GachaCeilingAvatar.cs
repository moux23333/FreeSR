namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class GachaCeilingAvatar
	{
		[ProtoMember(12)] public int RepeatedCnt;
		[ProtoMember(1)] public int AvatarId;
	}
	
}
