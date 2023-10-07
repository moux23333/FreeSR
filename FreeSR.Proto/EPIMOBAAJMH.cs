namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class EPIMOBAAJMH
	{
		[ProtoMember(14)] public bool IsNew;
		[ProtoMember(11)] public int BaseAvatarId;
		[ProtoMember(12)] public AddAvatarSrc Src;
		[ProtoMember(13)] public ItemList Reward;
	}

}
