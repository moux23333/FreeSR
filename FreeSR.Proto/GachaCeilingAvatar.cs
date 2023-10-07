namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class GachaCeilingAvatar
	{
		[ProtoMember(1)] public int RepeatedCnt;
		[ProtoMember(14)] public int AvatarId;
	}

}
