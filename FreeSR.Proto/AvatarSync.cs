namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class AvatarSync
	{
		[ProtoMember(12)] public List<Avatar> AvatarList;
	}
	
}
