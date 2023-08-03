namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class UseItemCsReq
	{
		[ProtoMember(4)] public int KIGIOHEAIFF;
		[ProtoMember(8)] public int OptionalRewardId;
		[ProtoMember(15)] public int OKGAKEHFKFE;
		[ProtoMember(12)] public int BaseAvatarId;
		[ProtoMember(13)] public AvatarType UseAvatarType;
	}
	
}
