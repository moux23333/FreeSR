namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class GetPrivateChatHistoryCsReq
	{
		[ProtoMember(5)] public int OEFBNCFALLM;
		[ProtoMember(14)] public int TargetUid;
	}
	
}
