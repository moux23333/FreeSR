namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class SetIsDisplayAvatarInfoCsReq
	{
		[ProtoMember(4)] public bool IsDisplay;
	}
	
}
