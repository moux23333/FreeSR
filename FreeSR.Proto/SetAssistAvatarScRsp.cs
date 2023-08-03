namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class SetAssistAvatarScRsp
	{
		[ProtoMember(10)] public int Retcode;
		[ProtoMember(15)] public int AvatarId;
	}
	
}
