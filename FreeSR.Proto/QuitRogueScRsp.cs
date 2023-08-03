namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class QuitRogueScRsp
	{
		[ProtoMember(3)] public int Retcode;
		[ProtoMember(8)] public RogueFinishInfo FinishInfo;
		[ProtoMember(12)] public RogueInfo RogueInfo;
	}
	
}
