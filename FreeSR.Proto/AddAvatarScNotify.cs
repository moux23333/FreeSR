namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class AddAvatarScNotify
	{
		[ProtoMember(2)] public AddAvatarSrc Src;
		[ProtoMember(11)] public bool IsNew;
		[ProtoMember(9)] public ItemList Reward;
		[ProtoMember(1)] public int BaseAvatarId;
	}
	
}
