namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class SetAssistAvatarCsReq
	{
		[ProtoMember(12)] public int AvatarId;
	}
	
}
