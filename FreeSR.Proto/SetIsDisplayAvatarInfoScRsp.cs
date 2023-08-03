namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class SetIsDisplayAvatarInfoScRsp
	{
		[ProtoMember(10)] public int Retcode;
		[ProtoMember(2)] public bool IsDisplay;
	}
	
}
