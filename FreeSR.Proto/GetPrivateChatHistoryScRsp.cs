namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class GetPrivateChatHistoryScRsp
	{
		[ProtoMember(8)] public int Retcode;
		[ProtoMember(5)] public List<GCHADCENEOK> BMCMOKLNMBB;
		[ProtoMember(15)] public int TargetUid;
		[ProtoMember(14)] public int OEFBNCFALLM;
	}
	
}
