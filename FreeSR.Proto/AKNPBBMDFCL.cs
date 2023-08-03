namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class AKNPBBMDFCL
	{
		[ProtoMember(13)] public AvatarType AvatarType;
		[ProtoMember(7)] public int AvatarId;
	}
	
}
