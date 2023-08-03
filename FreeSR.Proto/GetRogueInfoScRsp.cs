namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class GetRogueInfoScRsp
	{
		[ProtoMember(11)] public int Retcode;
		[ProtoMember(10)] public RogueInfo RogueInfo;
	}
	
}
